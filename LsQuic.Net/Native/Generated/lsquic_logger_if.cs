namespace StirlingLabs.LsQuic.Native
{
    public unsafe partial struct lsquic_logger_if
    {
        [NativeTypeName("int (*)(void *, const char *, size_t)")]
        public delegate* unmanaged[Cdecl]<void*, sbyte*, nuint, int> log_buf;
    }
}
