using System;

namespace StirlingLabs.LsQuic.Native
{
    [Flags]
    public enum LSQUIC_GLOBAL
    {
        CLIENT = lsquic.LSQUIC_GLOBAL_CLIENT,
        SERVER = lsquic.LSQUIC_GLOBAL_SERVER
    }
}