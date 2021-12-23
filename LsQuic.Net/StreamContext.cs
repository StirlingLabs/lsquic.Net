using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using StirlingLabs.LsQuic.Native;

namespace StirlingLabs.LsQuic
{
    public struct StreamContext
    {
        public void Init() { }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        public static unsafe lsquic_conn_ctx* OnNewConnection(void* pStreamCtx, lsquic_conn* conn)
        {
            var streamCtx = (StreamContext*)pStreamCtx;
            sockaddr* local;
            sockaddr* peer;
            if (lsquic.conn_get_sockaddr(conn, &local, &peer) != 0)
                return null;

            //lsquic.conn_abort(conn);
            //var connCtx = NativeMemory.New<ConnectionContext>();
            //connCtx->Init(sockaddr.Read(local), sockaddr.Read(peer));
            //return (lsquic_conn_ctx*)connCtx;
            //lsquic.conn_make_stream(conn);

            return null;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        public static unsafe void OnConnectionClosed(lsquic_conn* conn) { }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        public static unsafe lsquic_stream_ctx* OnNewStream(void* pStreamCtx, lsquic_stream* stream)
        {
            var streamCtx = (StreamContext*)pStreamCtx;
            return null;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        public static unsafe void OnStreamRead(lsquic_stream* stream, lsquic_stream_ctx* streamCtx)
        {
            
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        public static unsafe void OnStreamWrite(lsquic_stream* stream, lsquic_stream_ctx* streamCtx)
        {
            
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        public static unsafe void OnStreamClose(lsquic_stream* stream, lsquic_stream_ctx* streamCtx)
        {
            
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        public static unsafe void OnSessionResumed(lsquic_conn* conn, byte* data, nuint size)
        {
            
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        public static unsafe void OnNewToken(lsquic_conn* conn, byte* data, nuint size)
        {
            
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        public static unsafe void OnHandshake(lsquic_conn* conn, lsquic_hsk_status status)
        {
            
        }
    }
}