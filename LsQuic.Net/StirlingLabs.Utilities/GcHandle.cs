using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;

namespace StirlingLabs.Utilities
{
    [PublicAPI]
    public struct GcHandle<T>
    {
        private GCHandle _handle;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public GcHandle(T target)
            => _handle = GCHandle.Alloc(target);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void SetTarget(T target)
        {
            if (_handle != default) _handle.Free();
            _handle = GCHandle.Alloc(target);
        }

        public T? Target
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => (T)_handle.Target!;
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set => SetTarget(value);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Free()
            => _handle.Free();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator GcHandle<T>(T target)
            => new(target);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator T?(GcHandle<T> handle)
            => handle.Target;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator GCHandle(GcHandle<T> handle)
            => handle._handle;
    }
}
