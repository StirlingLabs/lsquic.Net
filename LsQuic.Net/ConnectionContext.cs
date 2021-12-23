using System.Net;
using System.Net.Sockets;
using StirlingLabs.LsQuic.Native;
using StirlingLabs.Utilities;

namespace StirlingLabs.LsQuic
{
    public struct ConnectionContext
    {
        private GcHandle<Socket> _socket;
        public Socket Socket => _socket;

        public void Init(EndPoint local, IPEndPoint peer)
            => _socket = (GcHandle<Socket>)
                new Socket(
                    local.AddressFamily,
                    SocketType.Dgram,
                    ProtocolType.Udp
                );

        public ConnectionContext(LSENG flags, EndPoint endPoint)
        {
            _socket = (GcHandle<Socket>)
                new Socket(
                    endPoint.AddressFamily,
                    SocketType.Dgram,
                    ProtocolType.Udp
                );
        }
    }
}