using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using StirlingLabs.Native;

namespace StirlingLabs.LsQuic.Native
{
    [PublicAPI]
    public readonly partial struct sockaddr
    {
        public static readonly nuint SizeOfSockAddrIn
            = (nuint)new IPEndPoint(IPAddress.Any, 0).Serialize().Size;

        public static readonly nuint SizeOfSockAddrIn6
            = (nuint)new IPEndPoint(IPAddress.IPv6Any, 0).Serialize().Size;

        public static readonly nuint MaxSizeOfSockAddr
            = SizeOfSockAddrIn6 > SizeOfSockAddrIn ? SizeOfSockAddrIn6 : SizeOfSockAddrIn;

        private static readonly IPEndPoint IPEndPointInstance = new(0, 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe void Serialize(IPEndPoint value, Span<byte> bytes)
        {
            var bytesLength = (nuint)bytes.Length;

            switch (value.AddressFamily)
            {
                case AddressFamily.InterNetwork: {
                    if (bytesLength < SizeOfSockAddrIn)
                        throw new ArgumentException("Not enough bytes.", nameof(bytes));
                    break;
                }
                case AddressFamily.InterNetworkV6: {
                    if (bytesLength < SizeOfSockAddrIn6)
                        throw new ArgumentException("Not enough bytes.", nameof(bytes));
                    break;
                }
                default: throw new NotImplementedException("Address family not implemented.");
            }

            var sa = value.Serialize();

            var saSize = sa.Size;

            fixed (byte* data = bytes)
            {
                for (var i = 0; i < saSize; ++i)
                    data[i] = sa[i];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe sockaddr* New(IPEndPoint value)
        {
            var sa = value.Serialize();

            var saSize = sa.Size;

            var data = (byte*)NativeMemory.New((nuint)saSize);
            for (var i = 0; i < saSize; ++i)
                data[i] = sa[i];

            return (sockaddr*)data;
        }

        public static unsafe IPEndPoint Read(sockaddr* address)
        {
            var af = (AddressFamily)(*(short*)address);
            var sa = new SocketAddress(af);
            var saSize = sa.Size;
            var data = (byte*)address;
            for (var i = 0; i < saSize; ++i)
                sa[i] = data[i];
            return (IPEndPoint) IPEndPointInstance.Create(sa);
        }
    }
}
