using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyDeck
{
    public partial class Running : Form
    {
        //WM_APP is hex:8000 long:32768
        private const int WM_HOOK = 0x8000 + 1;
        private const int WM_ACTIVATEAPP = 0x001C;
        private bool blockHook = false;
        private Keyboard keyboardData;
        private KeyDeckMenu menuForm;

        public Running(KeyDeckMenu form, Keyboard keyboard)
        {
            InitializeComponent();

            menuForm = form;
            keyboardData = keyboard;

            RAWINPUTDEVICE[] rawInputDevice = new RAWINPUTDEVICE[1];
            rawInputDevice[0].UsagePage = HIDUsagePage.Generic;
            rawInputDevice[0].Usage = HIDUsage.Keyboard;
            rawInputDevice[0].Flags = RawInputDeviceFlags.InputSink;
            rawInputDevice[0].WindowHandle = this.Handle;
            int size;
            size = Marshal.SizeOf(typeof(RAWINPUTDEVICE)) * rawInputDevice.Length;
            User32.RegisterRawInputDevices(rawInputDevice, 1, size);

            HookDll.InstallHook(this.Handle);
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
                    _ = User32.GetRawInputData(m.LParam, RAWINPUTCOMMAND.RID_INPUT, out raw, ref size, Marshal.SizeOf(typeof(RAWINPUTHEADER)));

                    ushort vKey = (ushort)raw.Data.Keyboard.VirtualKey;
                    ushort keyPressed = (ushort)raw.Data.Keyboard.Flags;

                    uint bufferSize = 0;
                    _ = User32.GetRawInputDeviceInfo(raw.Header.Device, (uint)DeviceInfoTypes.RIDI_DEVICENAME, IntPtr.Zero, ref bufferSize);
                    IntPtr pData = Marshal.AllocHGlobal(((int)bufferSize) * 2);
                    _ = User32.GetRawInputDeviceInfo(raw.Header.Device, (uint)DeviceInfoTypes.RIDI_DEVICENAME, pData, ref bufferSize);
                    string keyboardName = Marshal.PtrToStringAnsi(pData);

                    blockHook = false; //Set false then if needed set to true

                    
                    if (keyboardName == PriKeyboard.PrimaryKeyboard)
                    {
                        break;
                    }
                    else if (vKey == 27) //esc key
                    {
                        break;
                    }

                    for (int i = 0; i < keyboardData.Keyboards.Count; i++)
                    {
                        if (keyboardName == keyboardData.Keyboards[i].Keyboard)
                        {
                            for (int j = 0; j < keyboardData.Keyboards[i].KeyData.Count; j++)
                            {
                                if (vKey == keyboardData.Keyboards[i].KeyData[j].Key)
                                {
                                    switch (keyboardData.Keyboards[i].KeyData[j].Function)
                                    {
                                        case "PRESS":
                                            if (keyPressed == 0)
                                            {

                                            }
                                            else if (keyPressed == 1)
                                            {

                                            }
                                            break;
                                        case "INSERT":
                                            if (keyPressed == 0)
                                            {
                                                //https://stackoverflow.com/questions/14854878/creating-new-thread-with-method-with-parameter
                                                Thread thread = new Thread(() => SendThread(keyboardData.Keyboards[i].KeyData[j].FunctionData));
                                                thread.Start();
                                            }
                                            break;
                                        case "FOLDER":
                                            if (keyPressed == 0)
                                            {
                                                try
                                                {
                                                    Process.Start("explorer.exe", keyboardData.Keyboards[i].KeyData[j].FunctionData);
                                                }
                                                catch (Exception e)
                                                {
                                                    string message = "Unable to open folder";
                                                    MessageBox.Show(message);
                                                }
                                            }
                                            break;
                                        case "PROGRAM":
                                            if (keyPressed == 0)
                                            {
                                                try
                                                {
                                                    Process.Start(keyboardData.Keyboards[i].KeyData[j].FunctionData);
                                                }
                                                catch
                                                {
                                                    string message = "Unable to open Program";
                                                    MessageBox.Show(message);
                                                }
                                            }
                                            break;
                                        case "SEND":
                                            //Need to pass data to socket connection
                                            //Need to also have a Form for starting Socket Connection
                                            if (keyPressed == 0)
                                            {

                                            }
                                            break;
                                        default:
                                            break;
                                    }

                                    blockHook = true;
                                    break;
                                }
                            }
                            break;
                        }
                    }

                    break;
                case WM_HOOK:
                    if (blockHook)
                    {
                        m.Result = new IntPtr(1);
                    }
                    else
                    {
                        m.Result = new IntPtr(0);
                    }
                    break;
            }
        }

        private static void SendThread(string printstring)
        {
            SendKeys.SendWait(printstring);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            menuForm.Show();
            HookDll.UninstallHook();
        }

        private void HideButton_Click(object sender, EventArgs e)
        {
            //minimize to tray
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            menuForm.Show();
            this.Close();
        }
    }
}
