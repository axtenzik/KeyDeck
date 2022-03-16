using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class KeyDeckMain : Form
    {
        //WM_APP is hex:8000 long:32768
        private const int WM_HOOK = 0x8000 + 1;
        private const int WM_ACTIVATEAPP = 0x001C;
        private Entry entry;
        private bool blockHook = false;
        private ushort vKey = 0x41;
        private string keyboardName = null;
        private Keyboard keyboardData;
        
        public KeyDeckMain(Entry enter)
        {
            InitializeComponent();
            entry = enter;

            this.ChangeFunctionButton.Enabled = false;
            this.DeleteFunctionButton.Enabled = false;

            this.PrimaryErrorLabel.Hide();
            this.EscapeKeyLabel.Hide();

            this.SelectedKeyLabel.Hide();
            this.ListedKeyLabel.Hide();
            this.CurrentFunctionLabel.Hide();
            this.ListedFunctionLabel.Hide();
            this.DataLabel.Hide();
            this.ListedDataLabel.Hide();

            RAWINPUTDEVICE[] rawInputDevice = new RAWINPUTDEVICE[1];
            rawInputDevice[0].UsagePage = HIDUsagePage.Generic;
            rawInputDevice[0].Usage = HIDUsage.Keyboard;
            rawInputDevice[0].Flags = RawInputDeviceFlags.InputSink;
            rawInputDevice[0].WindowHandle = this.Handle;
            int size;
            size = Marshal.SizeOf(typeof(RAWINPUTDEVICE)) * rawInputDevice.Length;
            User32.RegisterRawInputDevices(rawInputDevice, 1, size);

            //this.HookLabel.Text = Keyboards.primaryKeyboard;
            HookDll.InstallHook(this.Handle);

            if (File.Exists("KeyboardData.json"))
            {
                try
                {
                    string fileName = "KeyboardData.json";
                    string jsonString = File.ReadAllText(fileName);
                    keyboardData = JsonSerializer.Deserialize<Keyboard>(jsonString);
                }
                catch
                {

                }
            }
            else
            {
                keyboardData = new Keyboard
                {
                    Keyboards = new List<KeyboardList>()
                };
                string fileName = "KeyboardData.json";
                string jsonString = JsonSerializer.Serialize(keyboardData);
                File.WriteAllText(fileName, jsonString);
            }
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

                    vKey = (ushort)raw.Data.Keyboard.VirtualKey;
                    ushort keyPressed = (ushort)raw.Data.Keyboard.Flags;
                    //this.HookLabel.Text = vKey.ToString();
                    //this.TestLabel.Text = keyPressed.ToString();

                    uint bufferSize = 0;
                    _ = User32.GetRawInputDeviceInfo(raw.Header.Device, (uint)DeviceInfoTypes.RIDI_DEVICENAME, IntPtr.Zero, ref bufferSize);
                    IntPtr pData = Marshal.AllocHGlobal(((int)bufferSize) * 2);
                    _ = User32.GetRawInputDeviceInfo(raw.Header.Device, (uint)DeviceInfoTypes.RIDI_DEVICENAME, pData, ref bufferSize);
                    keyboardName = Marshal.PtrToStringAnsi(pData);

                    this.DisplayLabel.Text = keyboardName;
                    this.SelectorTextBox.Text = ((VirtualKeys)vKey).ToString();

                    blockHook = false; //Set false then if needed set to true

                    //Return if keyboard not a connected keyboard

                    if (keyboardName == PriKeyboard.PrimaryKeyboard)
                    {
                        this.ChangeFunctionButton.Enabled = false;
                        this.DeleteFunctionButton.Enabled = false;

                        this.PrimaryErrorLabel.Show();
                        this.EscapeKeyLabel.Hide();

                        this.SelectedKeyLabel.Hide();
                        this.ListedKeyLabel.Hide();
                        this.CurrentFunctionLabel.Hide();
                        this.ListedFunctionLabel.Hide();
                        this.DataLabel.Hide();
                        this.ListedDataLabel.Hide();

                        //blockHook = false;
                        break;
                    }
                    else if (vKey == 27)
                    {
                        this.ChangeFunctionButton.Enabled = false;
                        this.DeleteFunctionButton.Enabled = false;

                        this.PrimaryErrorLabel.Hide();
                        this.EscapeKeyLabel.Show();

                        this.SelectedKeyLabel.Hide();
                        this.ListedKeyLabel.Hide();
                        this.CurrentFunctionLabel.Hide();
                        this.ListedFunctionLabel.Hide();
                        this.DataLabel.Hide();
                        this.ListedDataLabel.Hide();

                        //blockHook = false;
                        break;
                    }
                    else
                    {
                        this.ChangeFunctionButton.Enabled = true;
                        //this.DeleteFunctionButton.Enabled = true;

                        this.PrimaryErrorLabel.Hide();
                        this.EscapeKeyLabel.Hide();

                        this.SelectedKeyLabel.Show();
                        this.ListedKeyLabel.Show();
                        this.CurrentFunctionLabel.Show();
                        this.ListedFunctionLabel.Show();
                        this.DataLabel.Show();
                        this.ListedDataLabel.Show();

                        this.ListedKeyLabel.Text = ((VirtualKeys)vKey).ToString();

                        //blockHook = true;
                    }

                    //Check for null, keyboard data was null
                    for (int i = 0; i < keyboardData.Keyboards.Count; i++)
                    {
                        if (keyboardName == keyboardData.Keyboards[i].Keyboard)
                        {
                            for (int j = 0; j < keyboardData.Keyboards[i].KeyData.Count; j++)
                            {
                                if (vKey == keyboardData.Keyboards[i].KeyData[j].Key)
                                {
                                    this.ListedFunctionLabel.Text = keyboardData.Keyboards[i].KeyData[j].Function;
                                    this.ListedDataLabel.Text = keyboardData.Keyboards[i].KeyData[j].FunctionData;
                                    this.DeleteFunctionButton.Enabled = true;

                                    //Perform task here

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
                                                Thread thread = new Thread(()=>TestThread(keyboardData.Keyboards[i].KeyData[j].FunctionData));
                                                thread.Start();
                                                
                                                //SendKeys.Send(keyboardData.Keyboards[i].KeyData[j].FunctionData);
                                                //Issues with this approach
                                                /*foreach (char ch in insertText)
                                                {
                                                    //User32.keybd_event((byte)ch, 0, 0, 0);
                                                    //User32.keybd_event((byte)ch, 0, User32.KEYEVENTF_KEYUP, 0);
                                                }*/
                                                //User32.keybd_event((byte)'B', 0, 0, 0);
                                            }
                                            break;
                                        default:
                                            break;
                                    }

                                    blockHook = true;
                                    break;
                                }
                                else
                                {
                                    this.ListedFunctionLabel.Text = "None";
                                    this.ListedDataLabel.Text = "n/a";
                                    this.DeleteFunctionButton.Enabled = false;

                                    //blockHook = false;
                                }
                            }
                            //blockHook = true;
                            break;
                        }
                        else
                        {
                            //blockHook = false;
                        }
                    }

                    /*if (vKey == 27) //esc key
                    {
                        //keep esc key as an escape on all keyboards apart from the primary.
                        blockHook = false;
                    }
                    else
                    {
                        blockHook = true;
                    }*/

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

        private void TestThread(string printstring)
        {
            SendKeys.SendWait(printstring);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            entry.Close();
            HookDll.UninstallHook();
        }

        private void ChangeFunctionButton_Click(object sender, EventArgs e)
        {
            var changeFunction = new ChangeFunction(vKey, keyboardName, keyboardData);
            changeFunction.Show();
        }

        private void DeleteFunctionButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < keyboardData.Keyboards.Count; i++)
            {
                if (keyboardName == keyboardData.Keyboards[i].Keyboard)
                {
                    for (int j = 0; j < keyboardData.Keyboards[i].KeyData.Count; j++)
                    {
                        if (vKey == keyboardData.Keyboards[i].KeyData[j].Key)
                        {
                            keyboardData.Keyboards[i].KeyData.RemoveAt(j);

                            this.ListedFunctionLabel.Text = "None";
                            this.ListedDataLabel.Text = "n/a";
                            this.DeleteFunctionButton.Enabled = false;

                            string fileName = "KeyboardData.json";
                            string jsonString = JsonSerializer.Serialize(keyboardData);
                            File.WriteAllText(fileName, jsonString);

                            break;
                        }
                    }
                    break;
                }
            }
        }
    }
}
