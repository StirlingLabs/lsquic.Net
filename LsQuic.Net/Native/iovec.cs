using System;


namespace StirlingLabs.LsQuic.Native
{
    // technically you could just straight up cast this to a span
    public struct iovec
    {
        public unsafe byte* iov_base; /* Starting address */
        public nuint iov_len; /* Number of bytes to transfer */
        public readonly unsafe ReadOnlySpan<byte> ToReadOnlySpanOfBytes()
            => new(iov_base, (int)iov_len);

        public readonly unsafe Span<byte> ToSpanOfBytes()
            => new(iov_base, (int)iov_len);

        public static unsafe implicit operator ReadOnlySpan<byte>(in iovec p)
            => p.ToReadOnlySpanOfBytes();

        public static unsafe implicit operator Span<byte>(in iovec p)
            => p.ToSpanOfBytes();
    }
}
