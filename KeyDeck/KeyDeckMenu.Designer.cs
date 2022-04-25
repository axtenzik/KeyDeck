
namespace KeyDeck
{
    partial class KeyDeckMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExitButton = new System.Windows.Forms.Button();
            this.RunButton = new System.Windows.Forms.Button();
            this.KeyboardLabel = new System.Windows.Forms.Label();
            this.KeyboardDropDown = new System.Windows.Forms.ComboBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.KeyDropDown = new System.Windows.Forms.ComboBox();
            this.FunctionLabel = new System.Windows.Forms.Label();
            this.FunctionTextBox = new System.Windows.Forms.TextBox();
            this.DataTextBox = new System.Windows.Forms.RichTextBox();
            this.DataLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.IPLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.PortUpDown = new System.Windows.Forms.NumericUpDown();
            this.IPUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.IPUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.IPUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.IPUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.DefaultButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PortUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(368, 416);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(104, 33);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // RunButton
            // 
            this.RunButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RunButton.Location = new System.Drawing.Point(258, 416);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(104, 33);
            this.RunButton.TabIndex = 9;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // KeyboardLabel
            // 
            this.KeyboardLabel.AutoSize = true;
            this.KeyboardLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyboardLabel.Location = new System.Drawing.Point(12, 15);
            this.KeyboardLabel.Name = "KeyboardLabel";
            this.KeyboardLabel.Size = new System.Drawing.Size(136, 21);
            this.KeyboardLabel.TabIndex = 10;
            this.KeyboardLabel.Text = "Current Keyboard:";
            // 
            // KeyboardDropDown
            // 
            this.KeyboardDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KeyboardDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyboardDropDown.FormattingEnabled = true;
            this.KeyboardDropDown.Location = new System.Drawing.Point(154, 12);
            this.KeyboardDropDown.Name = "KeyboardDropDown";
            this.KeyboardDropDown.Size = new System.Drawing.Size(318, 29);
            this.KeyboardDropDown.TabIndex = 11;
            this.KeyboardDropDown.SelectedIndexChanged += new System.EventHandler(this.KeyboardDropDown_SelectedIndexChanged);
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyLabel.Location = new System.Drawing.Point(12, 50);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(95, 21);
            this.KeyLabel.TabIndex = 12;
            this.KeyLabel.Text = "Current Key:";
            // 
            // KeyDropDown
            // 
            this.KeyDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KeyDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyDropDown.FormattingEnabled = true;
            this.KeyDropDown.Location = new System.Drawing.Point(154, 47);
            this.KeyDropDown.Name = "KeyDropDown";
            this.KeyDropDown.Size = new System.Drawing.Size(318, 29);
            this.KeyDropDown.TabIndex = 13;
            this.KeyDropDown.SelectedIndexChanged += new System.EventHandler(this.KeyDropDown_SelectedIndexChanged);
            // 
            // FunctionLabel
            // 
            this.FunctionLabel.AutoSize = true;
            this.FunctionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FunctionLabel.Location = new System.Drawing.Point(12, 85);
            this.FunctionLabel.Name = "FunctionLabel";
            this.FunctionLabel.Size = new System.Drawing.Size(134, 21);
            this.FunctionLabel.TabIndex = 14;
            this.FunctionLabel.Text = "Current Function: ";
            // 
            // FunctionTextBox
            // 
            this.FunctionTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FunctionTextBox.Location = new System.Drawing.Point(154, 82);
            this.FunctionTextBox.Name = "FunctionTextBox";
            this.FunctionTextBox.ReadOnly = true;
            this.FunctionTextBox.Size = new System.Drawing.Size(318, 29);
            this.FunctionTextBox.TabIndex = 15;
            // 
            // DataTextBox
            // 
            this.DataTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataTextBox.Location = new System.Drawing.Point(154, 118);
            this.DataTextBox.Name = "DataTextBox";
            this.DataTextBox.ReadOnly = true;
            this.DataTextBox.Size = new System.Drawing.Size(318, 96);
            this.DataTextBox.TabIndex = 16;
            this.DataTextBox.Text = "";
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataLabel.Location = new System.Drawing.Point(12, 118);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(122, 21);
            this.DataLabel.TabIndex = 17;
            this.DataLabel.Text = "Performed Data:";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.Location = new System.Drawing.Point(368, 220);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(104, 33);
            this.DeleteButton.TabIndex = 18;
            this.DeleteButton.Text = "Delete Key";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeButton.Location = new System.Drawing.Point(258, 220);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(104, 33);
            this.ChangeButton.TabIndex = 19;
            this.ChangeButton.Text = "Change Key";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IPLabel.Location = new System.Drawing.Point(12, 286);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(76, 21);
            this.IPLabel.TabIndex = 20;
            this.IPLabel.Text = "Socket IP:";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PortLabel.Location = new System.Drawing.Point(12, 321);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(91, 21);
            this.PortLabel.TabIndex = 21;
            this.PortLabel.Text = "Socket Port:";
            // 
            // PortUpDown
            // 
            this.PortUpDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PortUpDown.Location = new System.Drawing.Point(154, 319);
            this.PortUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.PortUpDown.Name = "PortUpDown";
            this.PortUpDown.Size = new System.Drawing.Size(318, 29);
            this.PortUpDown.TabIndex = 34;
            this.PortUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PortUpDown.Value = new decimal(new int[] {
            4444,
            0,
            0,
            0});
            // 
            // IPUpDown4
            // 
            this.IPUpDown4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IPUpDown4.Location = new System.Drawing.Point(397, 284);
            this.IPUpDown4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.IPUpDown4.Name = "IPUpDown4";
            this.IPUpDown4.Size = new System.Drawing.Size(75, 29);
            this.IPUpDown4.TabIndex = 33;
            this.IPUpDown4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.IPUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // IPUpDown3
            // 
            this.IPUpDown3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IPUpDown3.Location = new System.Drawing.Point(316, 284);
            this.IPUpDown3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.IPUpDown3.Name = "IPUpDown3";
            this.IPUpDown3.Size = new System.Drawing.Size(75, 29);
            this.IPUpDown3.TabIndex = 32;
            this.IPUpDown3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IPUpDown2
            // 
            this.IPUpDown2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IPUpDown2.Location = new System.Drawing.Point(235, 284);
            this.IPUpDown2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.IPUpDown2.Name = "IPUpDown2";
            this.IPUpDown2.Size = new System.Drawing.Size(75, 29);
            this.IPUpDown2.TabIndex = 31;
            this.IPUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // IPUpDown1
            // 
            this.IPUpDown1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IPUpDown1.Location = new System.Drawing.Point(154, 284);
            this.IPUpDown1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.IPUpDown1.Name = "IPUpDown1";
            this.IPUpDown1.Size = new System.Drawing.Size(75, 29);
            this.IPUpDown1.TabIndex = 30;
            this.IPUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.IPUpDown1.Value = new decimal(new int[] {
            127,
            0,
            0,
            0});
            // 
            // DefaultButton
            // 
            this.DefaultButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DefaultButton.Location = new System.Drawing.Point(368, 354);
            this.DefaultButton.Name = "DefaultButton";
            this.DefaultButton.Size = new System.Drawing.Size(104, 33);
            this.DefaultButton.TabIndex = 35;
            this.DefaultButton.Text = "Default";
            this.DefaultButton.UseVisualStyleBackColor = true;
            this.DefaultButton.Click += new System.EventHandler(this.DefaultButton_Click);
            // 
            // KeyDeckMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.DefaultButton);
            this.Controls.Add(this.PortUpDown);
            this.Controls.Add(this.IPUpDown4);
            this.Controls.Add(this.IPUpDown3);
            this.Controls.Add(this.IPUpDown2);
            this.Controls.Add(this.IPUpDown1);
            this.Controls.Add(this.PortLabel);
            this.Controls.Add(this.IPLabel);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.DataTextBox);
            this.Controls.Add(this.FunctionTextBox);
            this.Controls.Add(this.FunctionLabel);
            this.Controls.Add(this.KeyDropDown);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.KeyboardDropDown);
            this.Controls.Add(this.KeyboardLabel);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.ExitButton);
            this.Name = "KeyDeckMenu";
            this.Text = "KeyDeck";
            ((System.ComponentModel.ISupportInitialize)(this.PortUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Label KeyboardLabel;
        private System.Windows.Forms.ComboBox KeyboardDropDown;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.ComboBox KeyDropDown;
        private System.Windows.Forms.Label FunctionLabel;
        private System.Windows.Forms.TextBox FunctionTextBox;
        private System.Windows.Forms.RichTextBox DataTextBox;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.NumericUpDown PortUpDown;
        private System.Windows.Forms.NumericUpDown IPUpDown4;
        private System.Windows.Forms.NumericUpDown IPUpDown3;
        private System.Windows.Forms.NumericUpDown IPUpDown2;
        private System.Windows.Forms.NumericUpDown IPUpDown1;
        private System.Windows.Forms.Button DefaultButton;
    }
}