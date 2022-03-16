
namespace KeyDeck
{
    partial class Entry
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
            this.PrimaryLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.KeyName = new System.Windows.Forms.Label();
            this.KeyHeader = new System.Windows.Forms.Label();
            this.KeyPressedLabel = new System.Windows.Forms.Label();
            this.CurrentPressLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PrimaryLabel
            // 
            this.PrimaryLabel.AutoSize = true;
            this.PrimaryLabel.Location = new System.Drawing.Point(13, 13);
            this.PrimaryLabel.Name = "PrimaryLabel";
            this.PrimaryLabel.Size = new System.Drawing.Size(232, 15);
            this.PrimaryLabel.TabIndex = 0;
            this.PrimaryLabel.Text = "Please type with desired primary keyboard:";
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(268, 116);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(104, 33);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(158, 116);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(104, 33);
            this.StartButton.TabIndex = 3;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // KeyName
            // 
            this.KeyName.AutoSize = true;
            this.KeyName.Location = new System.Drawing.Point(13, 62);
            this.KeyName.Name = "KeyName";
            this.KeyName.Size = new System.Drawing.Size(93, 15);
            this.KeyName.TabIndex = 4;
            this.KeyName.Text = "Keyboard name:";
            // 
            // KeyHeader
            // 
            this.KeyHeader.AutoSize = true;
            this.KeyHeader.Location = new System.Drawing.Point(112, 62);
            this.KeyHeader.Name = "KeyHeader";
            this.KeyHeader.Size = new System.Drawing.Size(29, 15);
            this.KeyHeader.TabIndex = 5;
            this.KeyHeader.Text = "N/A";
            // 
            // KeyPressedLabel
            // 
            this.KeyPressedLabel.AutoSize = true;
            this.KeyPressedLabel.Location = new System.Drawing.Point(13, 35);
            this.KeyPressedLabel.Name = "KeyPressedLabel";
            this.KeyPressedLabel.Size = new System.Drawing.Size(75, 15);
            this.KeyPressedLabel.TabIndex = 6;
            this.KeyPressedLabel.Text = "Key pressed: ";
            // 
            // CurrentPressLabel
            // 
            this.CurrentPressLabel.AutoSize = true;
            this.CurrentPressLabel.Location = new System.Drawing.Point(95, 35);
            this.CurrentPressLabel.Name = "CurrentPressLabel";
            this.CurrentPressLabel.Size = new System.Drawing.Size(29, 15);
            this.CurrentPressLabel.TabIndex = 7;
            this.CurrentPressLabel.Text = "N/A";
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.CurrentPressLabel);
            this.Controls.Add(this.KeyPressedLabel);
            this.Controls.Add(this.KeyHeader);
            this.Controls.Add(this.KeyName);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PrimaryLabel);
            this.Name = "Entry";
            this.Text = "KeyDeck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrimaryLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label KeyName;
        private System.Windows.Forms.Label KeyHeader;
        private System.Windows.Forms.Label KeyPressedLabel;
        private System.Windows.Forms.Label CurrentPressLabel;
    }
}