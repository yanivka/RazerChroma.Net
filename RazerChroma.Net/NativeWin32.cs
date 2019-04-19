using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net
{
    public static class NativeWin32
    {

        [StructLayout(LayoutKind.Sequential)]
        public struct ColorRef
        {
            public byte R;
            public byte G;
            public byte B;
            public byte A;

            public ColorRef(byte r, byte g, byte b, byte a)
            {
                R = r;
                G = g;
                B = b;
                A = a;
            }
        }

        [DllImport("kernel32", SetLastError = true, CharSet = CharSet.Unicode, EntryPoint= "LoadLibrary")]
        private static extern IntPtr LoadLibraryNative([MarshalAs(UnmanagedType.LPWStr)]string lpFileName);

        [DllImport("kernel32", CharSet = CharSet.Ansi, EntryPoint="GetProcAddress", ExactSpelling = true, SetLastError = true)]
        private static extern IntPtr GetProcAddressNative(IntPtr hModule, string procName);

        public static IntPtr GetProcAddress(IntPtr hModule, string funcName)
        {
            IntPtr handle = GetProcAddressNative(hModule, funcName);
            if(handle == IntPtr.Zero) throw new Win32Exception(Marshal.GetLastWin32Error());
            return handle;
        }
        public static IntPtr LoadLibrary(string filePath)
        {
            IntPtr handle = NativeWin32.LoadLibraryNative(filePath);
            if (handle == IntPtr.Zero) throw new Win32Exception(Marshal.GetLastWin32Error());
            return handle;
        }

    }
}
