namespace StirlingLabs.LsQuic.Native
{
    public unsafe partial struct lsquic_reader
    {
        [NativeTypeName("size_t (*)(void *, void *, size_t)")]
        public delegate* unmanaged[Cdecl]<void*, void*, nuint, nuint> lsqr_read;

        [NativeTypeName("size_t (*)(void *)")]
        public delegate* unmanaged[Cdecl]<void*, nuint> lsqr_size;

        public void* lsqr_ctx;
    }
}
