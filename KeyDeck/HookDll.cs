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
        [DllImport("KeyDeck.DLL")]
        public extern static bool InstallHook(IntPtr hWndParent);

        [DllImport("KeyDeck.DLL")]
        public extern static bool UninstallHook();
    }
}
