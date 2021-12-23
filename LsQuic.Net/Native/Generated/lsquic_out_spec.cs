namespace StirlingLabs.LsQuic.Native
{
    public unsafe partial struct lsquic_out_spec
    {
        [NativeTypeName("struct iovec *")]
        public iovec* iov;

        [NativeTypeName("size_t")]
        public nuint iovlen;

        [NativeTypeName("const struct sockaddr *")]
        public sockaddr* local_sa;

        [NativeTypeName("const struct sockaddr *")]
        public sockaddr* dest_sa;

        public void* peer_ctx;

        [NativeTypeName("lsquic_conn_ctx_t *")]
        public lsquic_conn_ctx* conn_ctx;

        public int ecn;
    }
}
