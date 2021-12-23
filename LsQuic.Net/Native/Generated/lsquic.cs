using System;
using System.Runtime.InteropServices;
using static StirlingLabs.LsQuic.Native.lsquic_version;

namespace StirlingLabs.LsQuic.Native
{
    public static unsafe partial class lsquic
    {
        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_engine_init_settings", ExactSpelling = true)]
        public static extern void engine_init_settings([NativeTypeName("struct lsquic_engine_settings *")] lsquic_engine_settings* param0, [NativeTypeName("unsigned int")] uint lsquic_engine_flags);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_engine_check_settings", ExactSpelling = true)]
        public static extern int engine_check_settings([NativeTypeName("const struct lsquic_engine_settings *")] lsquic_engine_settings* settings, [NativeTypeName("unsigned int")] uint lsquic_engine_flags, [NativeTypeName("char *")] sbyte* err_buf, [NativeTypeName("size_t")] nuint err_buf_sz);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_engine_new", ExactSpelling = true)]
        [return: NativeTypeName("lsquic_engine_t *")]
        public static extern lsquic_engine* engine_new([NativeTypeName("unsigned int")] uint lsquic_engine_flags, [NativeTypeName("const struct lsquic_engine_api *")] lsquic_engine_api* api);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_engine_connect", ExactSpelling = true)]
        [return: NativeTypeName("lsquic_conn_t *")]
        public static extern lsquic_conn* engine_connect([NativeTypeName("lsquic_engine_t *")] lsquic_engine* param0, [NativeTypeName("enum lsquic_version")] lsquic_version param1, [NativeTypeName("const struct sockaddr *")] sockaddr* local_sa, [NativeTypeName("const struct sockaddr *")] sockaddr* peer_sa, void* peer_ctx, [NativeTypeName("lsquic_conn_ctx_t *")] lsquic_conn_ctx* conn_ctx, [NativeTypeName("const char *")] sbyte* hostname, [NativeTypeName("unsigned short")] ushort base_plpmtu, [NativeTypeName("const unsigned char *")] byte* sess_resume, [NativeTypeName("size_t")] nuint sess_resume_len, [NativeTypeName("const unsigned char *")] byte* token, [NativeTypeName("size_t")] nuint token_sz);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_engine_packet_in", ExactSpelling = true)]
        public static extern int engine_packet_in([NativeTypeName("lsquic_engine_t *")] lsquic_engine* param0, [NativeTypeName("const unsigned char *")] byte* packet_in_data, [NativeTypeName("size_t")] nuint packet_in_size, [NativeTypeName("const struct sockaddr *")] sockaddr* sa_local, [NativeTypeName("const struct sockaddr *")] sockaddr* sa_peer, void* peer_ctx, int ecn);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_engine_process_conns", ExactSpelling = true)]
        public static extern void engine_process_conns([NativeTypeName("lsquic_engine_t *")] lsquic_engine* engine);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_engine_has_unsent_packets", ExactSpelling = true)]
        public static extern int engine_has_unsent_packets([NativeTypeName("lsquic_engine_t *")] lsquic_engine* engine);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_engine_send_unsent_packets", ExactSpelling = true)]
        public static extern void engine_send_unsent_packets([NativeTypeName("lsquic_engine_t *")] lsquic_engine* engine);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_engine_destroy", ExactSpelling = true)]
        public static extern void engine_destroy([NativeTypeName("lsquic_engine_t *")] lsquic_engine* param0);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_n_avail_streams", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint conn_n_avail_streams([NativeTypeName("const lsquic_conn_t *")] lsquic_conn* param0);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_make_stream", ExactSpelling = true)]
        public static extern void conn_make_stream([NativeTypeName("lsquic_conn_t *")] lsquic_conn* param0);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_n_pending_streams", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint conn_n_pending_streams([NativeTypeName("const lsquic_conn_t *")] lsquic_conn* param0);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_cancel_pending_streams", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint conn_cancel_pending_streams([NativeTypeName("lsquic_conn_t *")] lsquic_conn* param0, [NativeTypeName("unsigned int")] uint n);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_going_away", ExactSpelling = true)]
        public static extern void conn_going_away([NativeTypeName("lsquic_conn_t *")] lsquic_conn* param0);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_close", ExactSpelling = true)]
        public static extern void conn_close([NativeTypeName("lsquic_conn_t *")] lsquic_conn* param0);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_wantread", ExactSpelling = true)]
        public static extern int stream_wantread([NativeTypeName("lsquic_stream_t *")] lsquic_stream* s, int is_want);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_read", ExactSpelling = true)]
        [return: NativeTypeName("ssize_t")]
        public static extern long stream_read([NativeTypeName("lsquic_stream_t *")] lsquic_stream* s, void* buf, [NativeTypeName("size_t")] nuint len);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_readv", ExactSpelling = true)]
        [return: NativeTypeName("ssize_t")]
        public static extern long stream_readv([NativeTypeName("lsquic_stream_t *")] lsquic_stream* s, [NativeTypeName("const struct iovec *")] iovec* vec, int iovcnt);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_readf", ExactSpelling = true)]
        [return: NativeTypeName("ssize_t")]
        public static extern long stream_readf([NativeTypeName("lsquic_stream_t *")] lsquic_stream* s, [NativeTypeName("size_t (*)(void *, const unsigned char *, size_t, int)")] delegate* unmanaged[Cdecl]<void*, byte*, nuint, int, nuint> readf, void* ctx);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_wantwrite", ExactSpelling = true)]
        public static extern int stream_wantwrite([NativeTypeName("lsquic_stream_t *")] lsquic_stream* s, int is_want);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_write", ExactSpelling = true)]
        [return: NativeTypeName("ssize_t")]
        public static extern long stream_write([NativeTypeName("lsquic_stream_t *")] lsquic_stream* s, [NativeTypeName("const void *")] void* buf, [NativeTypeName("size_t")] nuint len);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_writev", ExactSpelling = true)]
        [return: NativeTypeName("ssize_t")]
        public static extern long stream_writev([NativeTypeName("lsquic_stream_t *")] lsquic_stream* s, [NativeTypeName("const struct iovec *")] iovec* vec, int count);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_pwritev", ExactSpelling = true)]
        [return: NativeTypeName("ssize_t")]
        public static extern long stream_pwritev([NativeTypeName("lsquic_stream_t *")] lsquic_stream* s, [NativeTypeName("ssize_t (*)(void *, const struct iovec *, int)")] delegate* unmanaged[Cdecl]<void*, iovec*, int, long> preadv, void* user_data, [NativeTypeName("size_t")] nuint n_to_write);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_writef", ExactSpelling = true)]
        [return: NativeTypeName("ssize_t")]
        public static extern long stream_writef([NativeTypeName("lsquic_stream_t *")] lsquic_stream* param0, [NativeTypeName("struct lsquic_reader *")] lsquic_reader* param1);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_flush", ExactSpelling = true)]
        public static extern int stream_flush([NativeTypeName("lsquic_stream_t *")] lsquic_stream* s);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_send_headers", ExactSpelling = true)]
        public static extern int stream_send_headers([NativeTypeName("lsquic_stream_t *")] lsquic_stream* s, [NativeTypeName("const lsquic_http_headers_t *")] lsquic_http_headers* headers, int eos);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_get_hset", ExactSpelling = true)]
        public static extern void* stream_get_hset([NativeTypeName("lsquic_stream_t *")] lsquic_stream* param0);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_push_stream", ExactSpelling = true)]
        public static extern int conn_push_stream([NativeTypeName("lsquic_conn_t *")] lsquic_conn* c, void* hdr_set, [NativeTypeName("lsquic_stream_t *")] lsquic_stream* s, [NativeTypeName("const lsquic_http_headers_t *")] lsquic_http_headers* headers);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_is_push_enabled", ExactSpelling = true)]
        public static extern int conn_is_push_enabled([NativeTypeName("lsquic_conn_t *")] lsquic_conn* param0);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_shutdown", ExactSpelling = true)]
        public static extern int stream_shutdown([NativeTypeName("lsquic_stream_t *")] lsquic_stream* s, int how);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_close", ExactSpelling = true)]
        public static extern int stream_close([NativeTypeName("lsquic_stream_t *")] lsquic_stream* s);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_has_unacked_data", ExactSpelling = true)]
        public static extern int stream_has_unacked_data([NativeTypeName("lsquic_stream_t *")] lsquic_stream* s);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_get_server_cert_chain", ExactSpelling = true)]
        [return: NativeTypeName("struct stack_st_X509 *")]
        public static extern stack_st_X509* conn_get_server_cert_chain([NativeTypeName("lsquic_conn_t *")] lsquic_conn* param0);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_id", ExactSpelling = true)]
        [return: NativeTypeName("lsquic_stream_id_t")]
        public static extern ulong stream_id([NativeTypeName("const lsquic_stream_t *")] lsquic_stream* s);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_get_ctx", ExactSpelling = true)]
        [return: NativeTypeName("lsquic_stream_ctx_t *")]
        public static extern lsquic_stream_ctx* stream_get_ctx([NativeTypeName("const lsquic_stream_t *")] lsquic_stream* s);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_set_ctx", ExactSpelling = true)]
        public static extern void stream_set_ctx([NativeTypeName("lsquic_stream_t *")] lsquic_stream* stream, [NativeTypeName("lsquic_stream_ctx_t *")] lsquic_stream_ctx* ctx);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_is_pushed", ExactSpelling = true)]
        public static extern int stream_is_pushed([NativeTypeName("const lsquic_stream_t *")] lsquic_stream* s);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_is_rejected", ExactSpelling = true)]
        public static extern int stream_is_rejected([NativeTypeName("const lsquic_stream_t *")] lsquic_stream* s);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_refuse_push", ExactSpelling = true)]
        public static extern int stream_refuse_push([NativeTypeName("lsquic_stream_t *")] lsquic_stream* s);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_push_info", ExactSpelling = true)]
        public static extern int stream_push_info([NativeTypeName("const lsquic_stream_t *")] lsquic_stream* param0, [NativeTypeName("lsquic_stream_id_t *")] ulong* ref_stream_id, void** hdr_set);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_priority", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint stream_priority([NativeTypeName("const lsquic_stream_t *")] lsquic_stream* s);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_set_priority", ExactSpelling = true)]
        public static extern int stream_set_priority([NativeTypeName("lsquic_stream_t *")] lsquic_stream* s, [NativeTypeName("unsigned int")] uint priority);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_get_http_prio", ExactSpelling = true)]
        public static extern int stream_get_http_prio([NativeTypeName("lsquic_stream_t *")] lsquic_stream* param0, [NativeTypeName("struct lsquic_ext_http_prio *")] lsquic_ext_http_prio* param1);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_set_http_prio", ExactSpelling = true)]
        public static extern int stream_set_http_prio([NativeTypeName("lsquic_stream_t *")] lsquic_stream* param0, [NativeTypeName("const struct lsquic_ext_http_prio *")] lsquic_ext_http_prio* param1);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_stream_conn", ExactSpelling = true)]
        [return: NativeTypeName("lsquic_conn_t *")]
        public static extern lsquic_conn* stream_conn([NativeTypeName("const lsquic_stream_t *")] lsquic_stream* s);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_id", ExactSpelling = true)]
        [return: NativeTypeName("const lsquic_cid_t *")]
        public static extern lsquic_cid* conn_id([NativeTypeName("const lsquic_conn_t *")] lsquic_conn* c);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_get_engine", ExactSpelling = true)]
        [return: NativeTypeName("lsquic_engine_t *")]
        public static extern lsquic_engine* conn_get_engine([NativeTypeName("lsquic_conn_t *")] lsquic_conn* c);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_get_sockaddr", ExactSpelling = true)]
        public static extern int conn_get_sockaddr([NativeTypeName("lsquic_conn_t *")] lsquic_conn* c, [NativeTypeName("const struct sockaddr **")] sockaddr** local, [NativeTypeName("const struct sockaddr **")] sockaddr** peer);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_want_datagram_write", ExactSpelling = true)]
        public static extern int conn_want_datagram_write([NativeTypeName("lsquic_conn_t *")] lsquic_conn* param0, int is_want);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_get_min_datagram_size", ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        public static extern nuint conn_get_min_datagram_size([NativeTypeName("lsquic_conn_t *")] lsquic_conn* param0);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_set_min_datagram_size", ExactSpelling = true)]
        public static extern int conn_set_min_datagram_size([NativeTypeName("lsquic_conn_t *")] lsquic_conn* param0, [NativeTypeName("size_t")] nuint sz);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_logger_init", ExactSpelling = true)]
        public static extern void logger_init([NativeTypeName("const struct lsquic_logger_if *")] lsquic_logger_if* param0, void* logger_ctx, [NativeTypeName("enum lsquic_logger_timestamp_style")] lsquic_logger_timestamp_style param2);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_set_log_level", ExactSpelling = true)]
        public static extern int set_log_level([NativeTypeName("const char *")] sbyte* log_level);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_logger_lopt", ExactSpelling = true)]
        public static extern int logger_lopt([NativeTypeName("const char *")] sbyte* optarg);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_engine_quic_versions", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint engine_quic_versions([NativeTypeName("const lsquic_engine_t *")] lsquic_engine* param0);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_global_init", ExactSpelling = true)]
        public static extern int global_init(int flags);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_global_cleanup", ExactSpelling = true)]
        public static extern void global_cleanup();

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_quic_version", ExactSpelling = true)]
        [return: NativeTypeName("enum lsquic_version")]
        public static extern lsquic_version conn_quic_version([NativeTypeName("const lsquic_conn_t *")] lsquic_conn* c);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_crypto_keysize", ExactSpelling = true)]
        public static extern int conn_crypto_keysize([NativeTypeName("const lsquic_conn_t *")] lsquic_conn* c);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_crypto_alg_keysize", ExactSpelling = true)]
        public static extern int conn_crypto_alg_keysize([NativeTypeName("const lsquic_conn_t *")] lsquic_conn* c);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_crypto_ver", ExactSpelling = true)]
        [return: NativeTypeName("enum lsquic_crypto_ver")]
        public static extern lsquic_crypto_ver conn_crypto_ver([NativeTypeName("const lsquic_conn_t *")] lsquic_conn* c);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_crypto_cipher", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* conn_crypto_cipher([NativeTypeName("const lsquic_conn_t *")] lsquic_conn* c);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_str2ver", ExactSpelling = true)]
        [return: NativeTypeName("enum lsquic_version")]
        public static extern lsquic_version str2ver([NativeTypeName("const char *")] sbyte* str, [NativeTypeName("size_t")] nuint len);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_alpn2ver", ExactSpelling = true)]
        [return: NativeTypeName("enum lsquic_version")]
        public static extern lsquic_version alpn2ver([NativeTypeName("const char *")] sbyte* alpn, [NativeTypeName("size_t")] nuint len);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_engine_cooldown", ExactSpelling = true)]
        public static extern void engine_cooldown([NativeTypeName("lsquic_engine_t *")] lsquic_engine* param0);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_get_ctx", ExactSpelling = true)]
        [return: NativeTypeName("lsquic_conn_ctx_t *")]
        public static extern lsquic_conn_ctx* conn_get_ctx([NativeTypeName("const lsquic_conn_t *")] lsquic_conn* param0);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_set_ctx", ExactSpelling = true)]
        public static extern void conn_set_ctx([NativeTypeName("lsquic_conn_t *")] lsquic_conn* param0, [NativeTypeName("lsquic_conn_ctx_t *")] lsquic_conn_ctx* param1);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_get_peer_ctx", ExactSpelling = true)]
        public static extern void* conn_get_peer_ctx([NativeTypeName("lsquic_conn_t *")] lsquic_conn* param0, [NativeTypeName("const struct sockaddr *")] sockaddr* local_sa);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_get_sni", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* conn_get_sni([NativeTypeName("lsquic_conn_t *")] lsquic_conn* param0);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_abort", ExactSpelling = true)]
        public static extern void conn_abort([NativeTypeName("lsquic_conn_t *")] lsquic_conn* param0);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_get_alt_svc_versions", ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* get_alt_svc_versions([NativeTypeName("unsigned int")] uint versions);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_get_h3_alpns", ExactSpelling = true)]
        [return: NativeTypeName("const char *const *")]
        public static extern sbyte** get_h3_alpns([NativeTypeName("unsigned int")] uint versions);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_is_valid_hs_packet", ExactSpelling = true)]
        public static extern int is_valid_hs_packet([NativeTypeName("lsquic_engine_t *")] lsquic_engine* param0, [NativeTypeName("const unsigned char *")] byte* param1, [NativeTypeName("size_t")] nuint param2);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_cid_from_packet", ExactSpelling = true)]
        public static extern int cid_from_packet([NativeTypeName("const unsigned char *")] byte* param0, [NativeTypeName("size_t")] nuint bufsz, [NativeTypeName("lsquic_cid_t *")] lsquic_cid* cid);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_dcid_from_packet", ExactSpelling = true)]
        public static extern int dcid_from_packet([NativeTypeName("const unsigned char *")] byte* param0, [NativeTypeName("size_t")] nuint bufsz, [NativeTypeName("unsigned int")] uint server_cid_len, [NativeTypeName("unsigned int *")] uint* cid_len);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_engine_earliest_adv_tick", ExactSpelling = true)]
        public static extern int engine_earliest_adv_tick([NativeTypeName("lsquic_engine_t *")] lsquic_engine* engine, int* diff);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_engine_count_attq", ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint engine_count_attq([NativeTypeName("lsquic_engine_t *")] lsquic_engine* engine, int from_now);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_conn_status", ExactSpelling = true)]
        [return: NativeTypeName("enum LSQUIC_CONN_STATUS")]
        public static extern LSQUIC_CONN_STATUS conn_status([NativeTypeName("lsquic_conn_t *")] lsquic_conn* param0, [NativeTypeName("char *")] sbyte* errbuf, [NativeTypeName("size_t")] nuint bufsz);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_ssl_to_conn", ExactSpelling = true)]
        [return: NativeTypeName("lsquic_conn_t *")]
        public static extern lsquic_conn* ssl_to_conn([NativeTypeName("const struct ssl_st *")] ssl_st* param0);

        [DllImport("lsquic", CallingConvention = CallingConvention.Cdecl, EntryPoint = "lsquic_ssl_sess_to_resume_info", ExactSpelling = true)]
        public static extern int ssl_sess_to_resume_info([NativeTypeName("struct ssl_st *")] ssl_st* param0, [NativeTypeName("struct ssl_session_st *")] ssl_session_st* param1, [NativeTypeName("unsigned char **")] byte** buf, [NativeTypeName("size_t *")] nuint* buf_sz);

        [NativeTypeName("#define LSQUIC_MAJOR_VERSION 3")]
        public const int LSQUIC_MAJOR_VERSION = 3;

        [NativeTypeName("#define LSQUIC_MINOR_VERSION 0")]
        public const int LSQUIC_MINOR_VERSION = 0;

        [NativeTypeName("#define LSQUIC_PATCH_VERSION 3")]
        public const int LSQUIC_PATCH_VERSION = 3;

        [NativeTypeName("#define LSENG_SERVER (1 << 0)")]
        public const int LSENG_SERVER = (1 << 0);

        [NativeTypeName("#define LSENG_HTTP (1 << 1)")]
        public const int LSENG_HTTP = (1 << 1);

        [NativeTypeName("#define LSENG_HTTP_SERVER (LSENG_SERVER|LSENG_HTTP)")]
        public const int LSENG_HTTP_SERVER = ((1 << 0) | (1 << 1));

        [NativeTypeName("#define LSQUIC_SUPPORTED_VERSIONS ((1 << N_LSQVER) - 1)")]
        public const int LSQUIC_SUPPORTED_VERSIONS = ((1 << (int)(N_LSQVER)) - 1);

        [NativeTypeName("#define LSQUIC_FORCED_TCID0_VERSIONS ((1 << LSQVER_046)|(1 << LSQVER_050))")]
        public const int LSQUIC_FORCED_TCID0_VERSIONS = ((1 << (int)(LSQVER_046)) | (1 << (int)(LSQVER_050)));

        [NativeTypeName("#define LSQUIC_EXPERIMENTAL_VERSIONS ( \\\n                            (1 << LSQVER_VERNEG))")]
        public const int LSQUIC_EXPERIMENTAL_VERSIONS = ((1 << (int)(LSQVER_VERNEG)));

        [NativeTypeName("#define LSQUIC_DEPRECATED_VERSIONS ((1 << LSQVER_ID27))")]
        public const int LSQUIC_DEPRECATED_VERSIONS = ((1 << (int)(LSQVER_ID27)));

        [NativeTypeName("#define LSQUIC_GQUIC_HEADER_VERSIONS (1 << LSQVER_043)")]
        public const int LSQUIC_GQUIC_HEADER_VERSIONS = (1 << (int)(LSQVER_043));

        [NativeTypeName("#define LSQUIC_IETF_VERSIONS ((1 << LSQVER_ID27) \\\n                          | (1 << LSQVER_ID29) \\\n                          | (1 << LSQVER_I001) | (1 << LSQVER_VERNEG))")]
        public const int LSQUIC_IETF_VERSIONS = ((1 << (int)(LSQVER_ID27)) | (1 << (int)(LSQVER_ID29)) | (1 << (int)(LSQVER_I001)) | (1 << (int)(LSQVER_VERNEG)));

        [NativeTypeName("#define LSQUIC_IETF_DRAFT_VERSIONS ((1 << LSQVER_ID27) \\\n                                  | (1 << LSQVER_ID29) \\\n                                  | (1 << LSQVER_VERNEG))")]
        public const int LSQUIC_IETF_DRAFT_VERSIONS = ((1 << (int)(LSQVER_ID27)) | (1 << (int)(LSQVER_ID29)) | (1 << (int)(LSQVER_VERNEG)));

        [NativeTypeName("#define LSQUIC_MIN_FCW (16 * 1024)")]
        public const int LSQUIC_MIN_FCW = (16 * 1024);

        [NativeTypeName("#define LSQUIC_DF_VERSIONS (LSQUIC_SUPPORTED_VERSIONS & \\\n                                            ~LSQUIC_DEPRECATED_VERSIONS & \\\n                                            ~LSQUIC_EXPERIMENTAL_VERSIONS)")]
        public const int LSQUIC_DF_VERSIONS = (((1 << (int)(N_LSQVER)) - 1) & ~((1 << (int)(LSQVER_ID27))) & ~((1 << (int)(LSQVER_VERNEG))));

        [NativeTypeName("#define LSQUIC_DF_CFCW_SERVER (3 * 1024 * 1024 / 2)")]
        public const int LSQUIC_DF_CFCW_SERVER = (3 * 1024 * 1024 / 2);

        [NativeTypeName("#define LSQUIC_DF_CFCW_CLIENT (15 * 1024 * 1024)")]
        public const int LSQUIC_DF_CFCW_CLIENT = (15 * 1024 * 1024);

        [NativeTypeName("#define LSQUIC_DF_SFCW_SERVER (1 * 1024 * 1024)")]
        public const int LSQUIC_DF_SFCW_SERVER = (1 * 1024 * 1024);

        [NativeTypeName("#define LSQUIC_DF_SFCW_CLIENT (6 * 1024 * 1024)")]
        public const int LSQUIC_DF_SFCW_CLIENT = (6 * 1024 * 1024);

        [NativeTypeName("#define LSQUIC_DF_MAX_STREAMS_IN 100")]
        public const int LSQUIC_DF_MAX_STREAMS_IN = 100;

        [NativeTypeName("#define LSQUIC_DF_INIT_MAX_DATA_SERVER LSQUIC_DF_CFCW_SERVER")]
        public const int LSQUIC_DF_INIT_MAX_DATA_SERVER = (3 * 1024 * 1024 / 2);

        [NativeTypeName("#define LSQUIC_DF_INIT_MAX_DATA_CLIENT LSQUIC_DF_CFCW_CLIENT")]
        public const int LSQUIC_DF_INIT_MAX_DATA_CLIENT = (15 * 1024 * 1024);

        [NativeTypeName("#define LSQUIC_DF_INIT_MAX_STREAM_DATA_BIDI_REMOTE_SERVER LSQUIC_DF_SFCW_SERVER")]
        public const int LSQUIC_DF_INIT_MAX_STREAM_DATA_BIDI_REMOTE_SERVER = (1 * 1024 * 1024);

        [NativeTypeName("#define LSQUIC_DF_INIT_MAX_STREAM_DATA_BIDI_LOCAL_SERVER 0")]
        public const int LSQUIC_DF_INIT_MAX_STREAM_DATA_BIDI_LOCAL_SERVER = 0;

        [NativeTypeName("#define LSQUIC_DF_INIT_MAX_STREAM_DATA_BIDI_REMOTE_CLIENT 0")]
        public const int LSQUIC_DF_INIT_MAX_STREAM_DATA_BIDI_REMOTE_CLIENT = 0;

        [NativeTypeName("#define LSQUIC_DF_INIT_MAX_STREAM_DATA_BIDI_LOCAL_CLIENT LSQUIC_DF_SFCW_CLIENT")]
        public const int LSQUIC_DF_INIT_MAX_STREAM_DATA_BIDI_LOCAL_CLIENT = (6 * 1024 * 1024);

        [NativeTypeName("#define LSQUIC_DF_INIT_MAX_STREAMS_BIDI LSQUIC_DF_MAX_STREAMS_IN")]
        public const int LSQUIC_DF_INIT_MAX_STREAMS_BIDI = 100;

        [NativeTypeName("#define LSQUIC_DF_INIT_MAX_STREAMS_UNI_CLIENT 100")]
        public const int LSQUIC_DF_INIT_MAX_STREAMS_UNI_CLIENT = 100;

        [NativeTypeName("#define LSQUIC_DF_INIT_MAX_STREAMS_UNI_SERVER 3")]
        public const int LSQUIC_DF_INIT_MAX_STREAMS_UNI_SERVER = 3;

        [NativeTypeName("#define LSQUIC_DF_INIT_MAX_STREAM_DATA_UNI_CLIENT (32 * 1024)")]
        public const int LSQUIC_DF_INIT_MAX_STREAM_DATA_UNI_CLIENT = (32 * 1024);

        [NativeTypeName("#define LSQUIC_DF_INIT_MAX_STREAM_DATA_UNI_SERVER (12 * 1024)")]
        public const int LSQUIC_DF_INIT_MAX_STREAM_DATA_UNI_SERVER = (12 * 1024);

        [NativeTypeName("#define LSQUIC_DF_IDLE_TIMEOUT 30")]
        public const int LSQUIC_DF_IDLE_TIMEOUT = 30;

        [NativeTypeName("#define LSQUIC_DF_PING_PERIOD 15")]
        public const int LSQUIC_DF_PING_PERIOD = 15;

        [NativeTypeName("#define LSQUIC_DF_HANDSHAKE_TO (10 * 1000 * 1000)")]
        public const int LSQUIC_DF_HANDSHAKE_TO = (10 * 1000 * 1000);

        [NativeTypeName("#define LSQUIC_DF_IDLE_CONN_TO (LSQUIC_DF_IDLE_TIMEOUT * 1000 * 1000)")]
        public const int LSQUIC_DF_IDLE_CONN_TO = (30 * 1000 * 1000);

        [NativeTypeName("#define LSQUIC_DF_SILENT_CLOSE 1")]
        public const int LSQUIC_DF_SILENT_CLOSE = 1;

        [NativeTypeName("#define LSQUIC_DF_MAX_HEADER_LIST_SIZE 0")]
        public const int LSQUIC_DF_MAX_HEADER_LIST_SIZE = 0;

        [NativeTypeName("#define LSQUIC_DF_UA \"LSQUIC\"")]
        public static ReadOnlySpan<byte> LSQUIC_DF_UA => new byte[] { 0x4C, 0x53, 0x51, 0x55, 0x49, 0x43, 0x00 };

        [NativeTypeName("#define LSQUIC_DF_STTL 86400")]
        public const int LSQUIC_DF_STTL = 86400;

        [NativeTypeName("#define LSQUIC_DF_MAX_INCHOATE (1 * 1000 * 1000)")]
        public const int LSQUIC_DF_MAX_INCHOATE = (1 * 1000 * 1000);

        [NativeTypeName("#define LSQUIC_DF_SUPPORT_NSTP 0")]
        public const int LSQUIC_DF_SUPPORT_NSTP = 0;

        [NativeTypeName("#define LSQUIC_DF_SUPPORT_PUSH 1")]
        public const int LSQUIC_DF_SUPPORT_PUSH = 1;

        [NativeTypeName("#define LSQUIC_DF_SUPPORT_TCID0 1")]
        public const int LSQUIC_DF_SUPPORT_TCID0 = 1;

        [NativeTypeName("#define LSQUIC_DF_HONOR_PRST 0")]
        public const int LSQUIC_DF_HONOR_PRST = 0;

        [NativeTypeName("#define LSQUIC_DF_SEND_PRST 0")]
        public const int LSQUIC_DF_SEND_PRST = 0;

        [NativeTypeName("#define LSQUIC_DF_PROGRESS_CHECK 1000")]
        public const int LSQUIC_DF_PROGRESS_CHECK = 1000;

        [NativeTypeName("#define LSQUIC_DF_RW_ONCE 0")]
        public const int LSQUIC_DF_RW_ONCE = 0;

        [NativeTypeName("#define LSQUIC_DF_PROC_TIME_THRESH 0")]
        public const int LSQUIC_DF_PROC_TIME_THRESH = 0;

        [NativeTypeName("#define LSQUIC_DF_PACE_PACKETS 1")]
        public const int LSQUIC_DF_PACE_PACKETS = 1;

        [NativeTypeName("#define LSQUIC_DF_CLOCK_GRANULARITY 1000")]
        public const int LSQUIC_DF_CLOCK_GRANULARITY = 1000;

        [NativeTypeName("#define LSQUIC_DF_SCID_LEN 8")]
        public const int LSQUIC_DF_SCID_LEN = 8;

        [NativeTypeName("#define LSQUIC_DF_SCID_ISS_RATE 60")]
        public const int LSQUIC_DF_SCID_ISS_RATE = 60;

        [NativeTypeName("#define LSQUIC_DF_QPACK_DEC_MAX_BLOCKED 100")]
        public const int LSQUIC_DF_QPACK_DEC_MAX_BLOCKED = 100;

        [NativeTypeName("#define LSQUIC_DF_QPACK_DEC_MAX_SIZE 4096")]
        public const int LSQUIC_DF_QPACK_DEC_MAX_SIZE = 4096;

        [NativeTypeName("#define LSQUIC_DF_QPACK_ENC_MAX_BLOCKED 100")]
        public const int LSQUIC_DF_QPACK_ENC_MAX_BLOCKED = 100;

        [NativeTypeName("#define LSQUIC_DF_QPACK_ENC_MAX_SIZE 4096")]
        public const int LSQUIC_DF_QPACK_ENC_MAX_SIZE = 4096;

        [NativeTypeName("#define LSQUIC_DF_QPACK_EXPERIMENT 0")]
        public const int LSQUIC_DF_QPACK_EXPERIMENT = 0;

        [NativeTypeName("#define LSQUIC_DF_ECN 0")]
        public const int LSQUIC_DF_ECN = 0;

        [NativeTypeName("#define LSQUIC_DF_ALLOW_MIGRATION 1")]
        public const int LSQUIC_DF_ALLOW_MIGRATION = 1;

        [NativeTypeName("#define LSQUIC_DF_QL_BITS 2")]
        public const int LSQUIC_DF_QL_BITS = 2;

        [NativeTypeName("#define LSQUIC_DF_SPIN 1")]
        public const int LSQUIC_DF_SPIN = 1;

        [NativeTypeName("#define LSQUIC_DF_DELAYED_ACKS 1")]
        public const int LSQUIC_DF_DELAYED_ACKS = 1;

        [NativeTypeName("#define LSQUIC_DF_PTPC_PERIODICITY 3")]
        public const int LSQUIC_DF_PTPC_PERIODICITY = 3;

        [NativeTypeName("#define LSQUIC_DF_PTPC_MAX_PACKTOL 150")]
        public const int LSQUIC_DF_PTPC_MAX_PACKTOL = 150;

        [NativeTypeName("#define LSQUIC_DF_PTPC_DYN_TARGET 1")]
        public const int LSQUIC_DF_PTPC_DYN_TARGET = 1;

        [NativeTypeName("#define LSQUIC_DF_PTPC_TARGET 1.0")]
        public const double LSQUIC_DF_PTPC_TARGET = 1.0;

        [NativeTypeName("#define LSQUIC_DF_PTPC_PROP_GAIN 0.8")]
        public const double LSQUIC_DF_PTPC_PROP_GAIN = 0.8;

        [NativeTypeName("#define LSQUIC_DF_PTPC_INT_GAIN 0.35")]
        public const double LSQUIC_DF_PTPC_INT_GAIN = 0.35;

        [NativeTypeName("#define LSQUIC_DF_PTPC_ERR_THRESH 0.05")]
        public const double LSQUIC_DF_PTPC_ERR_THRESH = 0.05;

        [NativeTypeName("#define LSQUIC_DF_PTPC_ERR_DIVISOR 0.05")]
        public const double LSQUIC_DF_PTPC_ERR_DIVISOR = 0.05;

        [NativeTypeName("#define LSQUIC_DF_TIMESTAMPS 1")]
        public const int LSQUIC_DF_TIMESTAMPS = 1;

        [NativeTypeName("#define LSQUIC_DF_CC_ALGO 3")]
        public const int LSQUIC_DF_CC_ALGO = 3;

        [NativeTypeName("#define LSQUIC_DF_CC_RTT_THRESH 1500")]
        public const int LSQUIC_DF_CC_RTT_THRESH = 1500;

        [NativeTypeName("#define LSQUIC_DF_DATAGRAMS 0")]
        public const int LSQUIC_DF_DATAGRAMS = 0;

        [NativeTypeName("#define LSQUIC_DF_OPTIMISTIC_NAT 1")]
        public const int LSQUIC_DF_OPTIMISTIC_NAT = 1;

        [NativeTypeName("#define LSQUIC_DF_EXT_HTTP_PRIO 1")]
        public const int LSQUIC_DF_EXT_HTTP_PRIO = 1;

        [NativeTypeName("#define LSQUIC_DF_MAX_UDP_PAYLOAD_SIZE_RX 0")]
        public const int LSQUIC_DF_MAX_UDP_PAYLOAD_SIZE_RX = 0;

        [NativeTypeName("#define LSQUIC_DF_GREASE_QUIC_BIT 1")]
        public const int LSQUIC_DF_GREASE_QUIC_BIT = 1;

        [NativeTypeName("#define LSQUIC_DF_DPLPMTUD 1")]
        public const int LSQUIC_DF_DPLPMTUD = 1;

        [NativeTypeName("#define LSQUIC_DF_BASE_PLPMTU 0")]
        public const int LSQUIC_DF_BASE_PLPMTU = 0;

        [NativeTypeName("#define LSQUIC_DF_MAX_PLPMTU 0")]
        public const int LSQUIC_DF_MAX_PLPMTU = 0;

        [NativeTypeName("#define LSQUIC_DF_NOPROGRESS_TIMEOUT_SERVER 60")]
        public const int LSQUIC_DF_NOPROGRESS_TIMEOUT_SERVER = 60;

        [NativeTypeName("#define LSQUIC_DF_NOPROGRESS_TIMEOUT_CLIENT 0")]
        public const int LSQUIC_DF_NOPROGRESS_TIMEOUT_CLIENT = 0;

        [NativeTypeName("#define LSQUIC_DF_MTU_PROBE_TIMER 1000")]
        public const int LSQUIC_DF_MTU_PROBE_TIMER = 1000;

        [NativeTypeName("#define LSQUIC_DF_DELAY_ONCLOSE 0")]
        public const int LSQUIC_DF_DELAY_ONCLOSE = 0;

        [NativeTypeName("#define LSQUIC_DF_MAX_BATCH_SIZE 0")]
        public const int LSQUIC_DF_MAX_BATCH_SIZE = 0;

        [NativeTypeName("#define LSQUIC_DF_CHECK_TP_SANITY 1")]
        public const int LSQUIC_DF_CHECK_TP_SANITY = 1;

        [NativeTypeName("#define LSQUIC_MAX_HTTP_URGENCY 7")]
        public const int LSQUIC_MAX_HTTP_URGENCY = 7;

        [NativeTypeName("#define LSQUIC_DEF_HTTP_URGENCY 3")]
        public const int LSQUIC_DEF_HTTP_URGENCY = 3;

        [NativeTypeName("#define LSQUIC_DEF_HTTP_INCREMENTAL 0")]
        public const int LSQUIC_DEF_HTTP_INCREMENTAL = 0;

        [NativeTypeName("#define LSQUIC_GLOBAL_CLIENT (1 << 0)")]
        public const int LSQUIC_GLOBAL_CLIENT = (1 << 0);

        [NativeTypeName("#define LSQUIC_GLOBAL_SERVER (1 << 1)")]
        public const int LSQUIC_GLOBAL_SERVER = (1 << 1);

        [NativeTypeName("#define MAX_CID_LEN 20")]
        public const int MAX_CID_LEN = 20;

        [NativeTypeName("#define GQUIC_CID_LEN 8")]
        public const int GQUIC_CID_LEN = 8;
    }
}
