namespace StirlingLabs.LsQuic.Native
{
    public unsafe partial struct lsquic_engine_api
    {
        [NativeTypeName("const struct lsquic_engine_settings *")]
        public lsquic_engine_settings* ea_settings;

        [NativeTypeName("const struct lsquic_stream_if *")]
        public lsquic_stream_if* ea_stream_if;

        public void* ea_stream_if_ctx;

        [NativeTypeName("lsquic_packets_out_f")]
        public delegate* unmanaged[Cdecl]<void*, lsquic_out_spec*, uint, int> ea_packets_out;

        public void* ea_packets_out_ctx;

        [NativeTypeName("lsquic_lookup_cert_f")]
        public delegate* unmanaged[Cdecl]<void*, sockaddr*, sbyte*, ssl_ctx_st*> ea_lookup_cert;

        public void* ea_cert_lu_ctx;

        [NativeTypeName("struct ssl_ctx_st *(*)(void *, const struct sockaddr *)")]
        public delegate* unmanaged[Cdecl]<void*, sockaddr*, ssl_ctx_st*> ea_get_ssl_ctx;

        [NativeTypeName("const struct lsquic_shared_hash_if *")]
        public lsquic_shared_hash_if* ea_shi;

        public void* ea_shi_ctx;

        [NativeTypeName("const struct lsquic_packout_mem_if *")]
        public lsquic_packout_mem_if* ea_pmi;

        public void* ea_pmi_ctx;

        [NativeTypeName("lsquic_cids_update_f")]
        public delegate* unmanaged[Cdecl]<void*, void**, lsquic_cid*, uint, void> ea_new_scids;

        [NativeTypeName("lsquic_cids_update_f")]
        public delegate* unmanaged[Cdecl]<void*, void**, lsquic_cid*, uint, void> ea_live_scids;

        [NativeTypeName("lsquic_cids_update_f")]
        public delegate* unmanaged[Cdecl]<void*, void**, lsquic_cid*, uint, void> ea_old_scids;

        public void* ea_cids_update_ctx;

        [NativeTypeName("int (*)(void *, struct stack_st_X509 *)")]
        public delegate* unmanaged[Cdecl]<void*, stack_st_X509*, int> ea_verify_cert;

        public void* ea_verify_ctx;

        [NativeTypeName("const struct lsquic_hset_if *")]
        public lsquic_hset_if* ea_hsi_if;

        public void* ea_hsi_ctx;

        public void* ea_stats_fh;

        [NativeTypeName("const char *")]
        public sbyte* ea_alpn;

        [NativeTypeName("void (*)(void *, lsquic_conn_t *, lsquic_cid_t *, unsigned int)")]
        public delegate* unmanaged[Cdecl]<void*, lsquic_conn*, lsquic_cid*, uint, void> ea_generate_scid;

        public void* ea_gen_scid_ctx;
    }
}
