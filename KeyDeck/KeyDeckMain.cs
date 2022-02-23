using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyDeck
{
    public partial class KeyDeckMain : Form
    {
        //WM_APP is hex:8000 long:32768
        private const int WM_HOOK = 0x8000 + 1;
        private const int WM_ACTIVATEAPP = 0x001C;
        private Entry entry;
        private bool blockHook = false;
        
        public KeyDeckMain(Entry enter)
        {
            InitializeComponent();
            entry = enter;

            RAWINPUTDEVICE[] rawInputDevice = new RAWINPUTDEVICE[1];
            rawInputDevice[0].UsagePage = HIDUsagePage.Generic;
            rawInputDevice[0].Usage = HIDUsage.Keyboard;
            rawInputDevice[0].Flags = RawInputDeviceFlags.InputSink;
            rawInputDevice[0].WindowHandle = this.Handle;
            int size;
            size = Marshal.SizeOf(typeof(RAWINPUTDEVICE)) * rawInputDevice.Length;
            User32.RegisterRawInputDevices(rawInputDevice, 1, size);

            this.HookLabel.Text = Keyboards.primaryKeyboard;
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
                case (int)WindowsMessages.INPUT:
                    RAWINPUT raw = new RAWINPUT();
                    uint size = (uint)Marshal.SizeOf(typeof(RAWINPUT));
                    _ = User32.GetRawInputData(m.LParam, RAWINPUTCOMMAND.RID_INPUT, out raw, ref size, Marshal.SizeOf(typeof(RAWINPUTHEADER)));

                    ushort vKey = (ushort)raw.Data.Keyboard.VirtualKey;
                    ushort keyPressed = (ushort)raw.Data.Keyboard.Flags;
                    this.HookLabel.Text = vKey.ToString();

                    uint bufferSize = 0;
                    _ = User32.GetRawInputDeviceInfo(raw.Header.Device, (uint)DeviceInfoTypes.RIDI_DEVICENAME, IntPtr.Zero, ref bufferSize);
                    IntPtr pData = Marshal.AllocHGlobal(((int)bufferSize) * 2);
                    _ = User32.GetRawInputDeviceInfo(raw.Header.Device, (uint)DeviceInfoTypes.RIDI_DEVICENAME, pData, ref bufferSize);
                    string name = Marshal.PtrToStringAnsi(pData);

                    if (name == Keyboards.primaryKeyboard)
                    {
                        blockHook = false;
                        break;
                    }

                    if (vKey == 27) //esc key
                    {
                        //keep esc key as an escape on all keyboards apart from the primary.
                        blockHook = false;
                    }
                    else
                    {
                        blockHook = true;
                    }

                    break;
                case WM_HOOK:
                    if (blockHook)
                    {
                        m.Result = new IntPtr(1);
                    }
                    else
                    {
                        //this.HookLabel.Text = "Hook successful";
                        m.Result = new IntPtr(0); //return 1?
                    }
                    break;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            entry.Close();
            HookDll.UninstallHook();
        }
    }
}
