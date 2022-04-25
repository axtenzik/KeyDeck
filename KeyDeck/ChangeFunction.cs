using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyDeck
{
    public partial class ChangeFunction : Form
    {
        private string keyboardName;
        private ushort virtualKey;
        private string function;
        //private string functionData;
        //private Keyboard keyboardData;
        
        /*public ChangeFunction(ushort vkey, string boardName)
        {
            InitializeComponent();
            virtualKey = vkey;
            keyboardName = boardName;

            this.VirtualKeyLabel.Text = ((VirtualKeys)vkey).ToString();
            this.FunctionDropDown.SelectedIndex = 0;
        }*/

        public ChangeFunction(ushort vkey, string boardName)
        {
            InitializeComponent();
            virtualKey = vkey;
            keyboardName = boardName;
            //keyboardData = keyboard;

            this.VirtualKeyLabel.Text = ((VirtualKeys)vkey).ToString();
            this.FunctionDropDown.SelectedIndex = 0;
            //Load key data

            for (int i = 0; i < KeyDeckMenu.keyboardData.Keyboards.Count; i++)
            {
                if (keyboardName == KeyDeckMenu.keyboardData.Keyboards[i].Keyboard)
                {
                    for (int j = 0; j < KeyDeckMenu.keyboardData.Keyboards[i].KeyData.Count; j++)
                    {
                        if (virtualKey == KeyDeckMenu.keyboardData.Keyboards[i].KeyData[j].Key)
                        {
                            this.InputDataTextBox.Text = KeyDeckMenu.keyboardData.Keyboards[i].KeyData[j].FunctionData;
                            string keyFun = KeyDeckMenu.keyboardData.Keyboards[i].KeyData[j].Function;

                            switch (keyFun)
                            {
                                case "PRESS":
                                    this.FunctionDropDown.SelectedIndex = 0;
                                    break;
                                case "INSERT":
                                    this.FunctionDropDown.SelectedIndex = 1;
                                    break;
                                case "FOLDER":
                                    this.FunctionDropDown.SelectedIndex = 2;
                                    break;
                                case "PROGRAM":
                                    this.FunctionDropDown.SelectedIndex = 3;
                                    break;
                                case "SEND":
                                    this.FunctionDropDown.SelectedIndex = 4;
                                    break;
                                default:
                                    break;
                            }

                            break;
                        }
                    }
                    
                    break;
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            //check keyboards for keyboard with said name
            //check keyboards for key

            /*
             * Check keyboards
             * check keys
             * 
             * if keyboard and key, save function and function data
             * 
             * if keyboard !key, list.add new keydata
             * 
             * if !keyboard, list.add new keyboardlist
             * 
             */

            //maybe this right
            bool definedBoard = false;
            //Keyboard data was null
            for (int i = 0; i < KeyDeckMenu.keyboardData.Keyboards.Count; i++)
            {
                if (keyboardName == KeyDeckMenu.keyboardData.Keyboards[i].Keyboard)
                {
                    definedBoard = true;

                    bool definedKey = false;
                    for (int j = 0; j < KeyDeckMenu.keyboardData.Keyboards[i].KeyData.Count; j++)
                    {
                        if (virtualKey == KeyDeckMenu.keyboardData.Keyboards[i].KeyData[j].Key)
                        {
                            KeyDeckMenu.keyboardData.Keyboards[i].KeyData[j].Function = function;
                            KeyDeckMenu.keyboardData.Keyboards[i].KeyData[j].FunctionData = this.InputDataTextBox.Text;

                            definedKey = true;
                            break;
                        }
                    }

                    if (!definedKey)
                    {
                        var keydata = new KeyData
                        {
                            Key = virtualKey,
                            Function = function,
                            FunctionData = this.InputDataTextBox.Text
                        };
                        KeyDeckMenu.keyboardData.Keyboards[i].KeyData.Add(keydata);
                    }
                    
                    break;
                }
            }

            if (!definedBoard)
            {
                var keydata = new KeyData
                {
                    Key = virtualKey,
                    Function = function,
                    FunctionData = this.InputDataTextBox.Text
                };

                var keyboardlist = new KeyboardList
                {
                    Keyboard = keyboardName,
                    KeyData = new List<KeyData>()
                };
                KeyDeckMenu.keyboardData.Keyboards.Add(keyboardlist);
                //keyboardData.Keyboards[keyboardData.Keyboards.Count - 1].KeyData.Add(keydata);
                KeyDeckMenu.keyboardData.Keyboards[^ 1].KeyData.Add(keydata);
            }

            string fileName = "KeyboardData.json";
            string jsonString = JsonSerializer.Serialize(KeyDeckMenu.keyboardData);
            File.WriteAllText(fileName, jsonString);

            this.Close();
        }

        private void FunctionDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.InputDataTextBox.Text = this.FunctionDropDown.SelectedIndex.ToString();
            switch (this.FunctionDropDown.SelectedIndex)
            {
                case 0:
                    function = "PRESS";
                    break;
                case 1:
                    function = "INSERT";
                    break;
                case 2:
                    function = "FOLDER";
                    break;
                case 3:
                    function = "PROGRAM";
                    break;
                case 4:
                    function = "SEND";
                    break;
            }
        }

        private void InputDataTextBox_TextChanged(object sender, EventArgs e)
        {
            //functionData = this.InputDataTextBox.Text;
        }
    }
}
