namespace StirlingLabs.LsQuic.Native
{
    public unsafe partial struct lsquic_stream_if
    {
        [NativeTypeName("lsquic_conn_ctx_t *(*)(void *, lsquic_conn_t *)")]
        public delegate* unmanaged[Cdecl]<void*, lsquic_conn*, lsquic_conn_ctx*> on_new_conn;

        [NativeTypeName("void (*)(lsquic_conn_t *)")]
        public delegate* unmanaged[Cdecl]<lsquic_conn*, void> on_goaway_received;

        [NativeTypeName("void (*)(lsquic_conn_t *)")]
        public delegate* unmanaged[Cdecl]<lsquic_conn*, void> on_conn_closed;

        [NativeTypeName("lsquic_stream_ctx_t *(*)(void *, lsquic_stream_t *)")]
        public delegate* unmanaged[Cdecl]<void*, lsquic_stream*, lsquic_stream_ctx*> on_new_stream;

        [NativeTypeName("void (*)(lsquic_stream_t *, lsquic_stream_ctx_t *)")]
        public delegate* unmanaged[Cdecl]<lsquic_stream*, lsquic_stream_ctx*, void> on_read;

        [NativeTypeName("void (*)(lsquic_stream_t *, lsquic_stream_ctx_t *)")]
        public delegate* unmanaged[Cdecl]<lsquic_stream*, lsquic_stream_ctx*, void> on_write;

        [NativeTypeName("void (*)(lsquic_stream_t *, lsquic_stream_ctx_t *)")]
        public delegate* unmanaged[Cdecl]<lsquic_stream*, lsquic_stream_ctx*, void> on_close;

        [NativeTypeName("ssize_t (*)(lsquic_conn_t *, void *, size_t)")]
        public delegate* unmanaged[Cdecl]<lsquic_conn*, void*, nuint, long> on_dg_write;

        [NativeTypeName("void (*)(lsquic_conn_t *, const void *, size_t)")]
        public delegate* unmanaged[Cdecl]<lsquic_conn*, void*, nuint, void> on_datagram;

        [NativeTypeName("void (*)(lsquic_conn_t *, enum lsquic_hsk_status)")]
        public delegate* unmanaged[Cdecl]<lsquic_conn*, lsquic_hsk_status, void> on_hsk_done;

        [NativeTypeName("void (*)(lsquic_conn_t *, const unsigned char *, size_t)")]
        public delegate* unmanaged[Cdecl]<lsquic_conn*, byte*, nuint, void> on_new_token;

        [NativeTypeName("void (*)(lsquic_conn_t *, const unsigned char *, size_t)")]
        public delegate* unmanaged[Cdecl]<lsquic_conn*, byte*, nuint, void> on_sess_resume_info;

        [NativeTypeName("void (*)(lsquic_stream_t *, lsquic_stream_ctx_t *, int)")]
        public delegate* unmanaged[Cdecl]<lsquic_stream*, lsquic_stream_ctx*, int, void> on_reset;

        [NativeTypeName("void (*)(lsquic_conn_t *, int, uint64_t, const char *, int)")]
        public delegate* unmanaged[Cdecl]<lsquic_conn*, int, ulong, sbyte*, int, void> on_conncloseframe_received;
    }
}
