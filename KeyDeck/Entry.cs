using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyDeck
{
    public partial class Entry : Form
    {
        private string name = "";

        public Entry()
        {
            InitializeComponent();
            this.StartButton.Enabled = false;

            RAWINPUTDEVICE[] rawInputDevice = new RAWINPUTDEVICE[1];
            //rawInputDevice[0].UsagePage = (HIDUsagePage)1;
            //rawInputDevice[0].Usage = (HIDUsage)6;
            //rawInputDevice[0].Flags = (RawInputDeviceFlags)0x00000100;
            rawInputDevice[0].UsagePage = HIDUsagePage.Generic;
            rawInputDevice[0].Usage = HIDUsage.Keyboard;
            rawInputDevice[0].Flags = RawInputDeviceFlags.InputSink;
            rawInputDevice[0].WindowHandle = this.Handle;
            int size;
            size = Marshal.SizeOf(typeof(RAWINPUTDEVICE)) * rawInputDevice.Length;
            /*unsafe
            {
                //https://stackoverflow.com/questions/5656161/size-of-array-of-structs-in-bytes
                size = sizeof(RAWINPUTDEVICE) * rawInputDevice.Length;
            }*/
            User32.RegisterRawInputDevices(rawInputDevice, 1, size);
        }

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
                    User32.GetRawInputData(m.LParam, RAWINPUTCOMMAND.RID_INPUT, out raw, ref size, Marshal.SizeOf(typeof(RAWINPUTHEADER)));

                    uint bufferSize = 0;
                    User32.GetRawInputDeviceInfo(raw.Header.Device, (uint)DeviceInfoTypes.RIDI_DEVICENAME, IntPtr.Zero, ref bufferSize);
                    IntPtr pData = Marshal.AllocHGlobal(((int)bufferSize) * 2);
                    User32.GetRawInputDeviceInfo(raw.Header.Device, (uint)DeviceInfoTypes.RIDI_DEVICENAME, pData, ref bufferSize);
                    name = Marshal.PtrToStringAnsi(pData);
                    //this.KeyHeader.Text = name;
                    this.KeyHeader.Text = "Keyboard 1";
                    ushort vKey = (ushort)raw.Data.Keyboard.VirtualKey;
                    //this.PrimaryTextBox.Text = ((VirtualKeys)vKey).ToString();
                    //this.PrimaryTextBox.Text = "";
                    this.CurrentPressLabel.Text = ((VirtualKeys)vKey).ToString();
                    this.StartButton.Enabled = true;

                    break;
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            PriKeyboard.PrimaryKeyboard = name;
            var keyDeckMain = new KeyDeckMain(this);
            keyDeckMain.Show();
            //Application.Run(new KeyDeckMain());
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to close the application?";
            const string caption = "Application Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            //this.Close();
        }

        private void PrimaryTextBox_TextChanged(object sender, EventArgs e)
        {
            this.StartButton.Enabled = true;
        }
    }
}
