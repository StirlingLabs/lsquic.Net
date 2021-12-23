using System.Runtime.CompilerServices;
using JetBrains.Annotations;

namespace StirlingLabs.Utilities
{
    [PublicAPI]
    public readonly struct Ptr<T> where T : unmanaged
    {
        public readonly unsafe T* Target;

        public unsafe ref T Reference => ref Unsafe.AsRef<T>(Target);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe Ptr(T* target)
            => Target = target;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe implicit operator T*(Ptr<T> ptr)
            => ptr.Target;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe implicit operator Ptr<T>(T* ptr)
            => new(ptr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static unsafe T* operator ~(Ptr<T> ptr)
            => ptr.Target;

        public ref T this[nint offset]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => ref Unsafe.Add(ref Reference, offset);
        }
    }
}
