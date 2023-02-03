namespace loebsindeling
{
    partial class Form1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openDataFileButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.openDataFilePathTextBox = new System.Windows.Forms.TextBox();
            this.loadedBoatsTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openDataFileButton
            // 
            this.openDataFileButton.Location = new System.Drawing.Point(6, 5);
            this.openDataFileButton.Name = "openDataFileButton";
            this.openDataFileButton.Size = new System.Drawing.Size(99, 23);
            this.openDataFileButton.TabIndex = 0;
            this.openDataFileButton.Text = "Open Data File";
            this.openDataFileButton.UseVisualStyleBackColor = true;
            this.openDataFileButton.Click += new System.EventHandler(this.openDataFileButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 436);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.loadedBoatsTextBox);
            this.tabPage1.Controls.Add(this.openDataFilePathTextBox);
            this.tabPage1.Controls.Add(this.openDataFileButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 410);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // openDataFilePathTextBox
            // 
            this.openDataFilePathTextBox.Enabled = false;
            this.openDataFilePathTextBox.Location = new System.Drawing.Point(121, 6);
            this.openDataFilePathTextBox.Name = "openDataFilePathTextBox";
            this.openDataFilePathTextBox.Size = new System.Drawing.Size(647, 20);
            this.openDataFilePathTextBox.TabIndex = 1;
            // 
            // loadedBoatsTextBox
            // 
            this.loadedBoatsTextBox.Location = new System.Drawing.Point(33, 81);
            this.loadedBoatsTextBox.Multiline = true;
            this.loadedBoatsTextBox.Name = "loadedBoatsTextBox";
            this.loadedBoatsTextBox.ReadOnly = true;
            this.loadedBoatsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.loadedBoatsTextBox.Size = new System.Drawing.Size(718, 276);
            this.loadedBoatsTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openDataFileButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox openDataFilePathTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox loadedBoatsTextBox;
    }
}

