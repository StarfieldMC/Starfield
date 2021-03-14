using System;
using System.Reflection;

namespace nylium.Extensions {

    //unsafe delegate void MemCpyImpl(byte* src, byte* dest, int len);

    public static class ArrayExtensions {

        //static MemCpyImpl memcpyimpl = (MemCpyImpl) Delegate.CreateDelegate(
        //    typeof(MemCpyImpl), typeof(Buffer).GetMethod("memcpyimpl",
        //        BindingFlags.Static | BindingFlags.NonPublic));

        unsafe public static void UnsafeCopy(this byte[] _in, byte[] _out) {
            fixed(byte* pSrc = _in)
            fixed(byte* pDest = _out)
                Buffer.MemoryCopy(pSrc, pDest, _out.Length, _in.Length);
                //memcpyimpl(pSrc, pDest, _in.Length);
        }

        unsafe public static void UnsafeCopy(this bool[] _in, bool[] _out) {
            fixed(bool* pSrc = _in)
            fixed(bool* pDest = _out)
                Buffer.MemoryCopy(pSrc, pDest, _out.Length, _in.Length);
            //memcpyimpl((byte*) pSrc, (byte*) pDest, _in.Length);
        }

        public static bool InBounds(this int index, int[] array) {
            return (index >= 0) && (index < array.Length);
        }
    }
}
