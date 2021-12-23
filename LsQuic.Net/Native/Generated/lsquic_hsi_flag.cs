namespace StirlingLabs.LsQuic.Native
{
    public enum lsquic_hsi_flag
    {
        LSQUIC_HSI_HTTP1X = 1 << 1,
        LSQUIC_HSI_HASH_NAME = 1 << 2,
        LSQUIC_HSI_HASH_NAMEVAL = 1 << 3,
    }
}
