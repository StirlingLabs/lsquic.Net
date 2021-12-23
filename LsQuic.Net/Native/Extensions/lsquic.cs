using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace StirlingLabs.LsQuic.Native
{
    [PublicAPI]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public static partial class lsquic
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int global_init(LSQUIC_GLOBAL flags)
            => global_init((int)flags);

        public static unsafe lsquic_engine* engine_new(
            LSENG lsquic_engine_flags,
            [NativeTypeName("const struct lsquic_engine_api *")]
            lsquic_engine_api* api
        )
            => engine_new((uint)lsquic_engine_flags, api);

        public static unsafe void engine_init_settings(
            [NativeTypeName("struct lsquic_engine_settings *")]
            lsquic_engine_settings* param0,
            LSENG lsquic_engine_flags
        )
            => engine_init_settings(param0, (uint)lsquic_engine_flags);
    }
}
