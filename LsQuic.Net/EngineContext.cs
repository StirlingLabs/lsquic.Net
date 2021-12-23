using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Unicode;
using JetBrains.Annotations;
using StirlingLabs.LsQuic.Native;
using StirlingLabs.Native;

namespace StirlingLabs.LsQuic
{
    public struct EngineContext
    {
        private LSENG _flags;

        public void Init(LSENG flags)
            => _flags = flags;

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        public static unsafe int OnPacketsOut(void* engineCtx,
            lsquic_out_spec* outPackets,
            uint packetsOutCount
        )
        {
            //var ctx = (EngineContext*)engineCtx;

            for (uint i = 0; i < packetsOutCount; ++i)
            {
                var outPacket = &outPackets[i];
                var connCtx = (ConnectionContext*)outPacket->conn_ctx;
                connCtx->Socket.Send(outPacket->iov->ToReadOnlySpanOfBytes());
            }

            return (int)packetsOutCount;
        }
    }
}
