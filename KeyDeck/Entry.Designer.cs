
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
            this.PrimaryTextBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StartButton = new System.Windows.Forms.Button();
            this.KeyName = new System.Windows.Forms.Label();
            this.KeyHeader = new System.Windows.Forms.Label();
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
            // PrimaryTextBox
            // 
            this.PrimaryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryTextBox.Location = new System.Drawing.Point(13, 32);
            this.PrimaryTextBox.Name = "PrimaryTextBox";
            this.PrimaryTextBox.Size = new System.Drawing.Size(359, 23);
            this.PrimaryTextBox.TabIndex = 1;
            this.PrimaryTextBox.TextChanged += new System.EventHandler(this.PrimaryTextBox_TextChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(297, 126);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(216, 126);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
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
            this.KeyHeader.Location = new System.Drawing.Point(13, 81);
            this.KeyHeader.Name = "KeyHeader";
            this.KeyHeader.Size = new System.Drawing.Size(25, 15);
            this.KeyHeader.TabIndex = 5;
            this.KeyHeader.Text = "n/a";
            // 
            // Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.KeyHeader);
            this.Controls.Add(this.KeyName);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.PrimaryTextBox);
            this.Controls.Add(this.PrimaryLabel);
            this.Name = "Entry";
            this.Text = "KeyDeck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrimaryLabel;
        private System.Windows.Forms.TextBox PrimaryTextBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label KeyName;
        private System.Windows.Forms.Label KeyHeader;
    }
}