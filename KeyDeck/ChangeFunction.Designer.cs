
namespace KeyDeck
{
    partial class ChangeFunction
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
            this.FunctionDropDown = new System.Windows.Forms.ComboBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.VirtualKeyLabel = new System.Windows.Forms.Label();
            this.FunctionLabel = new System.Windows.Forms.Label();
            this.FunctionDataLabel = new System.Windows.Forms.Label();
            this.InputDataTextBox = new System.Windows.Forms.RichTextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FunctionDropDown
            // 
            this.FunctionDropDown.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FunctionDropDown.FormattingEnabled = true;
            this.FunctionDropDown.Items.AddRange(new object[] {
            "Press keyboard keys",
            "Insert desired text",
            "Open Folder",
            "Open Program",
            "Send data over socket connection"});
            this.FunctionDropDown.Location = new System.Drawing.Point(152, 44);
            this.FunctionDropDown.Name = "FunctionDropDown";
            this.FunctionDropDown.Size = new System.Drawing.Size(320, 29);
            this.FunctionDropDown.TabIndex = 0;
            this.FunctionDropDown.SelectedIndexChanged += new System.EventHandler(this.FunctionDropDown_SelectedIndexChanged);
            // 
            // KeyLabel
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KeyLabel.Location = new System.Drawing.Point(12, 9);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(104, 21);
            this.KeyLabel.TabIndex = 1;
            this.KeyLabel.Text = "Selected Key: ";
            // 
            // VirtualKeyLabel
            // 
            this.VirtualKeyLabel.AutoSize = true;
            this.VirtualKeyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VirtualKeyLabel.Location = new System.Drawing.Point(152, 9);
            this.VirtualKeyLabel.Name = "VirtualKeyLabel";
            this.VirtualKeyLabel.Size = new System.Drawing.Size(162, 21);
            this.VirtualKeyLabel.TabIndex = 2;
            this.VirtualKeyLabel.Text = "Shouldn\'t see this text";
            // 
            // FunctionLabel
            // 
            this.FunctionLabel.AutoSize = true;
            this.FunctionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FunctionLabel.Location = new System.Drawing.Point(12, 44);
            this.FunctionLabel.Name = "FunctionLabel";
            this.FunctionLabel.Size = new System.Drawing.Size(134, 21);
            this.FunctionLabel.TabIndex = 3;
            this.FunctionLabel.Text = "Desired Function: ";
            // 
            // FunctionDataLabel
            // 
            this.FunctionDataLabel.AutoSize = true;
            this.FunctionDataLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FunctionDataLabel.Location = new System.Drawing.Point(13, 85);
            this.FunctionDataLabel.Name = "FunctionDataLabel";
            this.FunctionDataLabel.Size = new System.Drawing.Size(42, 21);
            this.FunctionDataLabel.TabIndex = 4;
            this.FunctionDataLabel.Text = "Data";
            // 
            // InputDataTextBox
            // 
            this.InputDataTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InputDataTextBox.Location = new System.Drawing.Point(152, 85);
            this.InputDataTextBox.Name = "InputDataTextBox";
            this.InputDataTextBox.Size = new System.Drawing.Size(320, 200);
            this.InputDataTextBox.TabIndex = 5;
            this.InputDataTextBox.Text = "";
            this.InputDataTextBox.TextChanged += new System.EventHandler(this.InputDataTextBox_TextChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.Location = new System.Drawing.Point(368, 291);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(104, 33);
            this.CancelButton.TabIndex = 6;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.Location = new System.Drawing.Point(258, 291);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(104, 33);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ChangeFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 336);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.InputDataTextBox);
            this.Controls.Add(this.FunctionDataLabel);
            this.Controls.Add(this.FunctionLabel);
            this.Controls.Add(this.VirtualKeyLabel);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.FunctionDropDown);
            this.Name = "ChangeFunction";
            this.Text = "KeyDeck Edit Key";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FunctionDropDown;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.Label VirtualKeyLabel;
        private System.Windows.Forms.Label FunctionLabel;
        private System.Windows.Forms.Label FunctionDataLabel;
        private System.Windows.Forms.RichTextBox InputDataTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
    }
}