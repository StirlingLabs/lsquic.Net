using System.Collections.Concurrent;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using StirlingLabs.LsQuic.Native;
using StirlingLabs.Utilities;
using StirlingLabs.BoringSsl.Native;
using static StirlingLabs.BoringSsl.Native.libcrypto;
using static StirlingLabs.BoringSsl.Native.libssl;

namespace StirlingLabs.LsQuic
{
    public struct CertificateContext
    {
        public GcHandle<ConcurrentDictionary<Utf8String, IPEndPoint>> _hostEpMap;
        public GcHandle<ConcurrentDictionary<IPEndPoint, Ptr<ssl_ctx_st>>> _epSslContexts;

        private unsafe stack_st_X509* ExtraCerts;

        public ConcurrentDictionary<Utf8String, IPEndPoint> HostToEndPointMap
            => _hostEpMap!;

        public ConcurrentDictionary<IPEndPoint, Ptr<ssl_ctx_st>> EndPointSslContexts
            => _epSslContexts!;

        public void Init()
        {
            _hostEpMap.Target = new();
            _epSslContexts.Target = new();
        }

        public unsafe void Add(string? hostName, IPEndPoint endPoint, ssl_ctx_st* ctx)
        {
            if (hostName is not null)
                HostToEndPointMap[string.Intern(hostName)] = endPoint;
            EndPointSslContexts[endPoint] = ctx;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        public static unsafe ssl_ctx_st* LookupCertificateFromSni(void* pCertCtx, sockaddr* local, sbyte* sni)
        {
            var certCtx = (CertificateContext*)pCertCtx;
            return certCtx->LookupCertificateFromSni(local, sni);
        }

        public unsafe ssl_ctx_st* LookupCertificateFromSni(sockaddr* local, sbyte* sni)
        {
            // sni is hostname
            var host = new Utf8String(sni);

            if (!HostToEndPointMap.TryGetValue(host, out var ep))
                return null;

            if (!EndPointSslContexts.TryGetValue(ep, out var pSslCtx))
                return null;

            return pSslCtx.Target;
        }

        [UnmanagedCallersOnly(CallConvs = new[] { typeof(CallConvCdecl) })]
        public static unsafe ssl_ctx_st* GetSslContext(void* pPeerCtx, sockaddr* local)
        {
            var peerCtx = (PeerContext*)pPeerCtx;

            if (peerCtx == null)
                return null;

            /*
            var certCtx = peerCtx->CertificateContext;
            
            var ep = sockaddr.Read(local);

            if (certCtx->EndPointSslContexts.TryGetValue(ep, out var pSslCtx))
                return (ssl_ctx_st*)pSslCtx.Target;
            */

            return peerCtx->SslContext;
        }

        private static unsafe bool LoadCA(CertificateContext * ctx, string path)
        {
            var f = BIO_new(BIO_s_mem());
            SetCertificateChain(ctx, f);
        }

        private static unsafe bool SetCertificateChain(CertificateContext* ctx, bio_st* f)
        {
            stack_st_X509* extraCerts = ctx->ExtraCerts;
            if (extraCerts != NULL)
            {
                sk_X509_pop_free(extraCerts, &X509_free_cdecl);
                pCtx->extra_certs = NULL;
            }
            SSL_CTX_clear_extra_chain_certs(ctx);
            
            
        }
    }
}
