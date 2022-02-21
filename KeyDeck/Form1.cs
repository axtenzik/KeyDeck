using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyDeck
{
    public partial class Form1 : Form
    {
        //WM_APP is hex:8000 long:32768
        private const int WM_HOOK = 0x8000 + 1;
        private const int WM_ACTIVATEAPP = 0x001C;
        
        public Form1()
        {
            InitializeComponent();
            HookDll.InstallHook(this.Handle);
        }

        //[System.Security.Permissions.PermissionSet(System.Security.Permissions.SecurityAction.Demand, Name="FullTrust")]
        protected override void WndProc(ref Message m)
        {
            //Put before code because apparently after code will just return 0
            // https://stackoverflow.com/questions/18264358/how-to-return-a-value-in-wndproc-for-c
            base.WndProc(ref m);

            switch (m.Msg)
            {
                case WM_HOOK:
                    this.HookLabel.Text = "Hook successful";
                    m.Result = new IntPtr(1); //return 1?
                    break;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            HookDll.UninstallHook();
        }
    }
}
