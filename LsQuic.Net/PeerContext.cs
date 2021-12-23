using StirlingLabs.Utilities;

namespace StirlingLabs.LsQuic
{
    public struct PeerContext
    {
        private Ptr<CertificateContext> _certCtx;
        private Ptr<ssl_ctx_st> _sslCtx;

        public unsafe CertificateContext* CertificateContext => _certCtx;
        public unsafe ssl_ctx_st* SslContext => _sslCtx;
        public unsafe void Init(CertificateContext* certCtx, ssl_ctx_st* sslCtx)
        {
            _certCtx = certCtx;
            _sslCtx = sslCtx;
        }
    }
}