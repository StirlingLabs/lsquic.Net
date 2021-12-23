using System;

namespace StirlingLabs.LsQuic.Native
{
    using static lsquic;

    [Flags]
    public enum LSENG : uint
    {
        SERVER = LSENG_SERVER,
        HTTP = LSENG_HTTP,
        HTTP_SERVER = LSENG_HTTP_SERVER
    }
}
