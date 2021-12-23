namespace StirlingLabs.LsQuic.Native
{
    public unsafe partial struct lsquic_http_headers
    {
        public int count;

        [NativeTypeName("struct lsxpack_header *")]
        public lsxpack_header* headers;
    }

    public partial struct lsquic_http_headers
    {
    }
}
