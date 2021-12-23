namespace StirlingLabs.LsQuic.Native
{
    public unsafe partial struct lsquic_shared_hash_if
    {
        [NativeTypeName("int (*)(void *, void *, unsigned int, void *, unsigned int, time_t)")]
        public delegate* unmanaged[Cdecl]<void*, void*, uint, void*, uint, long, int> shi_insert;

        [NativeTypeName("int (*)(void *, const void *, unsigned int)")]
        public delegate* unmanaged[Cdecl]<void*, void*, uint, int> shi_delete;

        [NativeTypeName("int (*)(void *, const void *, unsigned int, void **, unsigned int *)")]
        public delegate* unmanaged[Cdecl]<void*, void*, uint, void**, uint*, int> shi_lookup;
    }
}
