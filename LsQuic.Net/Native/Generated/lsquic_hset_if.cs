namespace StirlingLabs.LsQuic.Native
{
    public unsafe partial struct lsquic_hset_if
    {
        [NativeTypeName("void *(*)(void *, lsquic_stream_t *, int)")]
        public delegate* unmanaged[Cdecl]<void*, lsquic_stream*, int, void*> hsi_create_header_set;

        [NativeTypeName("struct lsxpack_header *(*)(void *, struct lsxpack_header *, size_t)")]
        public delegate* unmanaged[Cdecl]<void*, lsxpack_header*, nuint, lsxpack_header*> hsi_prepare_decode;

        [NativeTypeName("int (*)(void *, struct lsxpack_header *)")]
        public delegate* unmanaged[Cdecl]<void*, lsxpack_header*, int> hsi_process_header;

        [NativeTypeName("void (*)(void *)")]
        public delegate* unmanaged[Cdecl]<void*, void> hsi_discard_header_set;

        [NativeTypeName("enum lsquic_hsi_flag")]
        public lsquic_hsi_flag hsi_flags;
    }
}
