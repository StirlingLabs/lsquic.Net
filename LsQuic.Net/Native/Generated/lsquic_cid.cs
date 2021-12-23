using System.Runtime.InteropServices;

namespace StirlingLabs.LsQuic.Native
{
    public partial struct lsquic_cid
    {
        [NativeTypeName("uint_fast8_t")]
        public byte len;

        [NativeTypeName("union (anonymous union at lsquic_types.h:22:5)")]
        public _u_cid_e__Union u_cid;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _u_cid_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("uint8_t [20]")]
            public fixed byte buf[20];

            [FieldOffset(0)]
            [NativeTypeName("uint64_t")]
            public ulong id;
        }
    }
}
