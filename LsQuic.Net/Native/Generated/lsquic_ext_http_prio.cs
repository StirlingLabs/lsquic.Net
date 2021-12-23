namespace StirlingLabs.LsQuic.Native
{
    public partial struct lsquic_ext_http_prio
    {
        [NativeTypeName("unsigned char")]
        public byte urgency;

        [NativeTypeName("signed char")]
        public sbyte incremental;
    }
}
