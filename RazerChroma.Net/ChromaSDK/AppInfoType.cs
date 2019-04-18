using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RazerChroma.Net.ChromaSDK
{


    [StructLayout(LayoutKind.Sequential)]
    public struct AppInfoType
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct Author
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public char[] Name;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public char[] Contact;
        }

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public char[] Title;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
        public char[] Description;
        public Author CurrentAuthor;
        public uint SupportedDevice;
        public uint  Category;
    }


}
