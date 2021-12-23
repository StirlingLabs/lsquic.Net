using NUnit.Framework;
using StirlingLabs.LsQuic.Native;
using StirlingLabs.Native;

namespace StirlingLabs.LsQuic.Tests
{
    public class Tests
    {
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            lsquic.global_init(LSQUIC_GLOBAL.CLIENT | LSQUIC_GLOBAL.SERVER);
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            lsquic.global_cleanup();
        }


        [Test]
        public unsafe void SaneGlobalStartup()
        {
            var engineContext = NativeMemory.New<EngineContext>();
            engineContext->Init(LSENG.SERVER);
            var streamContext = NativeMemory.New<StreamContext>();
            streamContext->Init();
            var streamInterface = NativeMemory.New<lsquic_stream_if>();
            streamInterface->on_new_conn = &StreamContext.OnNewConnection;
            streamInterface->on_conn_closed = &StreamContext.OnConnectionClosed;
            streamInterface->on_new_stream = &StreamContext.OnNewStream;
            streamInterface->on_read = &StreamContext.OnStreamRead;
            streamInterface->on_write = &StreamContext.OnStreamWrite;
            streamInterface->on_close = &StreamContext.OnStreamClose;
            streamInterface->on_sess_resume_info = &StreamContext.OnSessionResumed;
            streamInterface->on_new_token = &StreamContext.OnNewToken;
            streamInterface->on_hsk_done = &StreamContext.OnHandshake;
            var certContext = NativeMemory.New<CertificateContext>();
            certContext->Init();

            var ea = NativeMemory.New<lsquic_engine_api>();
            ea->ea_packets_out_ctx = engineContext;
            ea->ea_packets_out = &EngineContext.OnPacketsOut;
            ea->ea_stream_if = streamInterface;
            ea->ea_stream_if_ctx = streamContext;
            ea->ea_lookup_cert = &CertificateContext.LookupCertificateFromSni;
            ea->ea_cert_lu_ctx = certContext;
            ea->ea_get_ssl_ctx = &CertificateContext.GetSslContext;

            var engine = lsquic.engine_new(LSENG.SERVER, ea);
            
            
        }
    }
}
