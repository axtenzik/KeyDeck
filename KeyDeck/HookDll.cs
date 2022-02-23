using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KeyDeck
{
    class HookDll
    {
        //C:\Users\brver\Documents\GitHub\KeyDeck\Debug
        [DllImport("C:\\Users\\brver\\Documents\\GitHub\\KeyDeck\\Debug\\KeyDeckDLL.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public extern static bool InstallHook(IntPtr hWndParent);

        [DllImport("C:\\Users\\brver\\Documents\\GitHub\\KeyDeck\\Debug\\KeyDeckDLL.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
        public extern static bool UninstallHook();
    }
}
