
namespace KeyDeck
{
    partial class KeyDeckMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SelectorLabel = new System.Windows.Forms.Label();
            this.SelectorTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.PrimaryErrorLabel = new System.Windows.Forms.Label();
            this.ChangeFunctionButton = new System.Windows.Forms.Button();
            this.DeleteFunctionButton = new System.Windows.Forms.Button();
            this.SelectedKeyLabel = new System.Windows.Forms.Label();
            this.ListedKeyLabel = new System.Windows.Forms.Label();
            this.CurrentFunctionLabel = new System.Windows.Forms.Label();
            this.ListedFunctionLabel = new System.Windows.Forms.Label();
            this.DataLabel = new System.Windows.Forms.Label();
            this.ListedDataLabel = new System.Windows.Forms.Label();
            this.EscapeKeyLabel = new System.Windows.Forms.Label();
            this.TestLabel = new System.Windows.Forms.Label();
            this.ToDoLabel = new System.Windows.Forms.Label();
            this.MinimiseButton = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectorLabel
            // 
            this.SelectorLabel.AutoSize = true;
            this.SelectorLabel.Location = new System.Drawing.Point(13, 13);
            this.SelectorLabel.Name = "SelectorLabel";
            this.SelectorLabel.Size = new System.Drawing.Size(333, 15);
            this.SelectorLabel.TabIndex = 1;
            this.SelectorLabel.Text = "Type with the desired Keyboard that you want to edit the keys:";
            // 
            // SelectorTextBox
            // 
            this.SelectorTextBox.Location = new System.Drawing.Point(13, 31);
            this.SelectorTextBox.Name = "SelectorTextBox";
            this.SelectorTextBox.Size = new System.Drawing.Size(459, 23);
            this.SelectorTextBox.TabIndex = 2;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(13, 61);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(139, 15);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Selected keyboard name:";
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.AutoSize = true;
            this.DisplayLabel.Location = new System.Drawing.Point(159, 61);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(25, 15);
            this.DisplayLabel.TabIndex = 4;
            this.DisplayLabel.Text = "n/a";
            // 
            // PrimaryErrorLabel
            // 
            this.PrimaryErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrimaryErrorLabel.AutoSize = true;
            this.PrimaryErrorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrimaryErrorLabel.Location = new System.Drawing.Point(13, 98);
            this.PrimaryErrorLabel.Name = "PrimaryErrorLabel";
            this.PrimaryErrorLabel.Size = new System.Drawing.Size(455, 21);
            this.PrimaryErrorLabel.TabIndex = 5;
            this.PrimaryErrorLabel.Text = "Selected keyboard is the primary keyboard and cannot be edited";
            // 
            // ChangeFunctionButton
            // 
            this.ChangeFunctionButton.Location = new System.Drawing.Point(12, 376);
            this.ChangeFunctionButton.Name = "ChangeFunctionButton";
            this.ChangeFunctionButton.Size = new System.Drawing.Size(236, 73);
            this.ChangeFunctionButton.TabIndex = 6;
            this.ChangeFunctionButton.Text = "Change Function";
            this.ChangeFunctionButton.UseVisualStyleBackColor = true;
            this.ChangeFunctionButton.Click += new System.EventHandler(this.ChangeFunctionButton_Click);
            // 
            // DeleteFunctionButton
            // 
            this.DeleteFunctionButton.Location = new System.Drawing.Point(267, 376);
            this.DeleteFunctionButton.Name = "DeleteFunctionButton";
            this.DeleteFunctionButton.Size = new System.Drawing.Size(205, 73);
            this.DeleteFunctionButton.TabIndex = 7;
            this.DeleteFunctionButton.Text = "Delete Function";
            this.DeleteFunctionButton.UseVisualStyleBackColor = true;
            this.DeleteFunctionButton.Click += new System.EventHandler(this.DeleteFunctionButton_Click);
            // 
            // SelectedKeyLabel
            // 
            this.SelectedKeyLabel.AutoSize = true;
            this.SelectedKeyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectedKeyLabel.Location = new System.Drawing.Point(13, 98);
            this.SelectedKeyLabel.Name = "SelectedKeyLabel";
            this.SelectedKeyLabel.Size = new System.Drawing.Size(104, 21);
            this.SelectedKeyLabel.TabIndex = 8;
            this.SelectedKeyLabel.Text = "Selected Key: ";
            // 
            // ListedKeyLabel
            // 
            this.ListedKeyLabel.AutoSize = true;
            this.ListedKeyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListedKeyLabel.Location = new System.Drawing.Point(149, 98);
            this.ListedKeyLabel.Name = "ListedKeyLabel";
            this.ListedKeyLabel.Size = new System.Drawing.Size(33, 21);
            this.ListedKeyLabel.TabIndex = 9;
            this.ListedKeyLabel.Text = "n/a";
            // 
            // CurrentFunctionLabel
            // 
            this.CurrentFunctionLabel.AutoSize = true;
            this.CurrentFunctionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CurrentFunctionLabel.Location = new System.Drawing.Point(13, 123);
            this.CurrentFunctionLabel.Name = "CurrentFunctionLabel";
            this.CurrentFunctionLabel.Size = new System.Drawing.Size(130, 21);
            this.CurrentFunctionLabel.TabIndex = 10;
            this.CurrentFunctionLabel.Text = "Current Function:";
            // 
            // ListedFunctionLabel
            // 
            this.ListedFunctionLabel.AutoSize = true;
            this.ListedFunctionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListedFunctionLabel.Location = new System.Drawing.Point(149, 123);
            this.ListedFunctionLabel.Name = "ListedFunctionLabel";
            this.ListedFunctionLabel.Size = new System.Drawing.Size(48, 21);
            this.ListedFunctionLabel.TabIndex = 11;
            this.ListedFunctionLabel.Text = "None";
            // 
            // DataLabel
            // 
            this.DataLabel.AutoSize = true;
            this.DataLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DataLabel.Location = new System.Drawing.Point(13, 148);
            this.DataLabel.Name = "DataLabel";
            this.DataLabel.Size = new System.Drawing.Size(113, 21);
            this.DataLabel.TabIndex = 12;
            this.DataLabel.Text = "Function Data: ";
            // 
            // ListedDataLabel
            // 
            this.ListedDataLabel.AutoSize = true;
            this.ListedDataLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ListedDataLabel.Location = new System.Drawing.Point(149, 148);
            this.ListedDataLabel.Name = "ListedDataLabel";
            this.ListedDataLabel.Size = new System.Drawing.Size(33, 21);
            this.ListedDataLabel.TabIndex = 13;
            this.ListedDataLabel.Text = "n/a";
            // 
            // EscapeKeyLabel
            // 
            this.EscapeKeyLabel.AutoSize = true;
            this.EscapeKeyLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EscapeKeyLabel.Location = new System.Drawing.Point(13, 98);
            this.EscapeKeyLabel.Name = "EscapeKeyLabel";
            this.EscapeKeyLabel.Size = new System.Drawing.Size(233, 21);
            this.EscapeKeyLabel.TabIndex = 14;
            this.EscapeKeyLabel.Text = "The escape key cannot be edited";
            // 
            // TestLabel
            // 
            this.TestLabel.AutoSize = true;
            this.TestLabel.Location = new System.Drawing.Point(87, 240);
            this.TestLabel.Name = "TestLabel";
            this.TestLabel.Size = new System.Drawing.Size(38, 15);
            this.TestLabel.TabIndex = 15;
            this.TestLabel.Text = "label1";
            // 
            // ToDoLabel
            // 
            this.ToDoLabel.AutoSize = true;
            this.ToDoLabel.Location = new System.Drawing.Point(12, 338);
            this.ToDoLabel.Name = "ToDoLabel";
            this.ToDoLabel.Size = new System.Drawing.Size(333, 15);
            this.ToDoLabel.TabIndex = 16;
            this.ToDoLabel.Text = "Dropdown for keyboards then dropdown for keys to manually";
            // 
            // MinimiseButton
            // 
            this.MinimiseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimiseButton.Location = new System.Drawing.Point(369, 318);
            this.MinimiseButton.Name = "MinimiseButton";
            this.MinimiseButton.Size = new System.Drawing.Size(103, 50);
            this.MinimiseButton.TabIndex = 17;
            this.MinimiseButton.Text = "Minimise";
            this.MinimiseButton.UseVisualStyleBackColor = true;
            this.MinimiseButton.Click += new System.EventHandler(this.MinimiseButton_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(392, 289);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 18;
            this.Refresh.Text = "Refresh devices";
            this.Refresh.UseVisualStyleBackColor = true;
            // 
            // KeyDeckMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.MinimiseButton);
            this.Controls.Add(this.ToDoLabel);
            this.Controls.Add(this.TestLabel);
            this.Controls.Add(this.EscapeKeyLabel);
            this.Controls.Add(this.ListedDataLabel);
            this.Controls.Add(this.DataLabel);
            this.Controls.Add(this.ListedFunctionLabel);
            this.Controls.Add(this.CurrentFunctionLabel);
            this.Controls.Add(this.ListedKeyLabel);
            this.Controls.Add(this.SelectedKeyLabel);
            this.Controls.Add(this.DeleteFunctionButton);
            this.Controls.Add(this.ChangeFunctionButton);
            this.Controls.Add(this.PrimaryErrorLabel);
            this.Controls.Add(this.DisplayLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.SelectorTextBox);
            this.Controls.Add(this.SelectorLabel);
            this.Name = "KeyDeckMain";
            this.Text = "KeyDeck";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectorLabel;
        private System.Windows.Forms.TextBox SelectorTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.Label PrimaryErrorLabel;
        private System.Windows.Forms.Button ChangeFunctionButton;
        private System.Windows.Forms.Button DeleteFunctionButton;
        private System.Windows.Forms.Label SelectedKeyLabel;
        private System.Windows.Forms.Label ListedKeyLabel;
        private System.Windows.Forms.Label CurrentFunctionLabel;
        private System.Windows.Forms.Label ListedFunctionLabel;
        private System.Windows.Forms.Label DataLabel;
        private System.Windows.Forms.Label ListedDataLabel;
        private System.Windows.Forms.Label EscapeKeyLabel;
        private System.Windows.Forms.Label TestLabel;
        private System.Windows.Forms.Label ToDoLabel;
        private System.Windows.Forms.Button MinimiseButton;
        private System.Windows.Forms.Button Refresh;
    }
}

