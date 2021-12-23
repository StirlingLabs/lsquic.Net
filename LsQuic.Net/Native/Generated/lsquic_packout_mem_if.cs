namespace StirlingLabs.LsQuic.Native
{
    public unsafe partial struct lsquic_packout_mem_if
    {
        [NativeTypeName("void *(*)(void *, void *, lsquic_conn_ctx_t *, unsigned short, char)")]
        public delegate* unmanaged[Cdecl]<void*, void*, lsquic_conn_ctx*, ushort, sbyte, void*> pmi_allocate;

        [NativeTypeName("void (*)(void *, void *, void *, char)")]
        public delegate* unmanaged[Cdecl]<void*, void*, void*, sbyte, void> pmi_release;

        [NativeTypeName("void (*)(void *, void *, void *, char)")]
        public delegate* unmanaged[Cdecl]<void*, void*, void*, sbyte, void> pmi_return;
    }
}
