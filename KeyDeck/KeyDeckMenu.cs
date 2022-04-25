using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyDeck
{
    public partial class KeyDeckMenu : Form
    {
        private ushort vKey;
        private string keyboardName = null;
        public static Keyboard keyboardData;
        private Entry entry;

        public KeyDeckMenu(Entry enter)
        {
            InitializeComponent();

            entry = enter;

            this.ChangeButton.Enabled = false;
            this.DeleteButton.Enabled = false;

            RAWINPUTDEVICE[] rawInputDevice = new RAWINPUTDEVICE[1];
            rawInputDevice[0].UsagePage = HIDUsagePage.Generic;
            rawInputDevice[0].Usage = HIDUsage.Keyboard;
            rawInputDevice[0].Flags = RawInputDeviceFlags.InputSink;
            rawInputDevice[0].WindowHandle = this.Handle;
            int size;
            size = Marshal.SizeOf(typeof(RAWINPUTDEVICE)) * rawInputDevice.Length;
            User32.RegisterRawInputDevices(rawInputDevice, 1, size);

            if (File.Exists("KeyboardData.json"))
            {
                try
                {
                    string fileName = "KeyboardData.json";
                    string jsonString = File.ReadAllText(fileName);
                    keyboardData = JsonSerializer.Deserialize<Keyboard>(jsonString);
                }
                catch (Exception)
                {
                    string message = "Saved keyboard functions were unable to be read";
                    MessageBox.Show(message);
                    //Make yes no
                    //Or make copy .json to my documents and create new
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

            //Add keyboards to drop down
            //Add keys to drop down
            foreach (var kb in keyboardData.Keyboards)
            {
                this.KeyboardDropDown.Items.Add(kb.Keyboard);
                /*foreach (Key key in kb)
                {
                    //something like this, might have to put in selected drop down changed
                    // allowed drop?
                }*/
            }
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

                    ushort virtualKey = (ushort)raw.Data.Keyboard.VirtualKey;

                    uint bufferSize = 0;
                    _ = User32.GetRawInputDeviceInfo(raw.Header.Device, (uint)DeviceInfoTypes.RIDI_DEVICENAME, IntPtr.Zero, ref bufferSize);
                    IntPtr pData = Marshal.AllocHGlobal(((int)bufferSize) * 2);
                    _ = User32.GetRawInputDeviceInfo(raw.Header.Device, (uint)DeviceInfoTypes.RIDI_DEVICENAME, pData, ref bufferSize);
                    string kbName = Marshal.PtrToStringAnsi(pData); //set as string here otherwise can't use keyboard to select keys

                    //Return if keyboard not a connected keyboard
                    //Tab arrow keys space and enter need to be disabled
                    //All these need to be able to be selected from the drop down

                    //this.ChangeButton.Enabled = false;
                    //this.DeleteButton.Enabled = false;

                    if (kbName == PriKeyboard.PrimaryKeyboard)
                    {
                        //unpdate drop downs and text boxes
                        break;
                    }
                    else if (vKey == 9 || vKey == 13 || vKey == 27 || vKey == 32 || vKey == 37 || vKey == 38 || vKey == 39 || vKey == 40)
                    {
                        // tab 9, enter 13, esc 27, space 32, left 37, up 38, right 39, down 40
                        break;
                    }
                    else
                    {
                        vKey = virtualKey;
                        keyboardName = kbName;

                        this.ChangeButton.Enabled = true;
                        //this.DeleteFunctionButton.Enabled = true;
                        //Delete need to be in loop as delete should only be shown if functions are available

                        //Loop to get key if in the index 
                        
                        if (KeyboardDropDown.Items.Contains(keyboardName))
                        {
                            this.KeyboardDropDown.SelectedItem = keyboardName;
                        }
                        else
                        {
                            this.KeyboardDropDown.Items.Add(keyboardName);
                            this.KeyboardDropDown.SelectedItem = keyboardName;
                        }
                        
                        if (KeyDropDown.Items.Contains((VirtualKeys)vKey))
                        {
                            this.KeyDropDown.SelectedItem = (VirtualKeys)vKey;
                        }
                        else
                        {
                            this.KeyDropDown.Items.Add((VirtualKeys)vKey);
                            this.KeyDropDown.SelectedItem = (VirtualKeys)vKey;
                        }
                    }
                    /*
                    this.FunctionTextBox.Text = "None";
                    this.DataTextBox.Text = "n/a";
                    
                    for (int i = 0; i < keyboardData.Keyboards.Count; i++)
                    {
                        if (keyboardName == keyboardData.Keyboards[i].Keyboard)
                        {
                            for (int j = 0; j < keyboardData.Keyboards[i].KeyData.Count; j++)
                            {
                                if (vKey == keyboardData.Keyboards[i].KeyData[j].Key)
                                {
                                    this.FunctionTextBox.Text = keyboardData.Keyboards[i].KeyData[j].Function;
                                    this.DataTextBox.Text = keyboardData.Keyboards[i].KeyData[j].FunctionData;
                                    this.DeleteButton.Enabled = true;
                                    break;
                                }
                            }
                            break;
                        }
                    }*/
                    
                    break;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            entry.Close();
            HookDll.UninstallHook();
        }

        private void KeyboardDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            keyboardName = KeyboardDropDown.SelectedItem.ToString();

            this.KeyDropDown.Items.Clear();
            this.FunctionTextBox.Text = "None";
            this.DataTextBox.Text = "n/a";
            this.ChangeButton.Enabled = false;
            this.DeleteButton.Enabled = false;

            //if primary, disable buttons and show error
            for (int i = 0; i < keyboardData.Keyboards.Count; i++)
            {
                if (keyboardData.Keyboards[i].Keyboard == keyboardName)
                {
                    foreach (var key in keyboardData.Keyboards[i].KeyData)
                    {
                        this.KeyDropDown.Items.Add((VirtualKeys)key.Key);
                    }
                }
            }
        }

        private void KeyDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Test();
            
            this.FunctionTextBox.Text = "None";
            this.DataTextBox.Text = "n/a";
            this.DeleteButton.Enabled = false;

            //this.ChangeButton.Enabled = !(this.KeyboardDropDown.SelectedItem.ToString() == PriKeyboard.PrimaryKeyboard);

            if (keyboardName == PriKeyboard.PrimaryKeyboard)
            {
                this.ChangeButton.Enabled = false;
            }
            else
            {
                this.ChangeButton.Enabled = true;
            }
            
            vKey = (ushort)(VirtualKeys)this.KeyDropDown.SelectedItem;
            
            for (int i = 0; i < keyboardData.Keyboards.Count; i++)
            {
                if (keyboardName == keyboardData.Keyboards[i].Keyboard)
                {
                    for (int j = 0; j < keyboardData.Keyboards[i].KeyData.Count; j++)
                    {
                        //this.label1.Text = keyboardData.Keyboards[i].KeyData.Count.ToString();
                        if (vKey == keyboardData.Keyboards[i].KeyData[j].Key)
                        {
                            //this.label1.Text = "key";
                            this.FunctionTextBox.Text = keyboardData.Keyboards[i].KeyData[j].Function;
                            this.DataTextBox.Text = keyboardData.Keyboards[i].KeyData[j].FunctionData;
                            this.DeleteButton.Enabled= true;
                            break;
                        }
                    }
                    break;
                }
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            var changeFunction = new ChangeFunction(vKey, keyboardName);
            changeFunction.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
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

                            if (keyboardData.Keyboards[i].KeyData.Count == 0)
                            {
                                keyboardData.Keyboards.RemoveAt(i);
                            }

                            this.FunctionTextBox.Text = "None";
                            this.DataTextBox.Text = "n/a";
                            this.DeleteButton.Enabled = false;

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

        private void RunButton_Click(object sender, EventArgs e)
        {
            IPAddress ipAddress = new IPAddress(new byte[] { (byte)this.IPUpDown1.Value, (byte)this.IPUpDown2.Value, (byte)this.IPUpDown3.Value, (byte)this.IPUpDown4.Value });
            int port = (int)this.PortUpDown.Value;
            var running = new Running(this, keyboardData);
            running.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure that you would like to close the application?";
            const string caption = "Application Closing";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void DefaultButton_Click(object sender, EventArgs e)
        {
            this.IPUpDown1.Value = 127;
            this.IPUpDown2.Value = 0;
            this.IPUpDown3.Value = 0;
            this.IPUpDown4.Value = 1;
            this.PortUpDown.Value = 4444;
        }
    }
}
