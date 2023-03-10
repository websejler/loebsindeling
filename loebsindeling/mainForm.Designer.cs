namespace loebsindeling
{
    partial class mainForm
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
            this.loadData = new System.Windows.Forms.TabPage();
            this.loadedBoatsTextBox = new System.Windows.Forms.TextBox();
            this.openDataFilePathTextBox = new System.Windows.Forms.TextBox();
            this.sortBoats = new System.Windows.Forms.TabPage();
            this.sortedBoatsTextBox = new System.Windows.Forms.TextBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sortingAlgorithmComboBox = new System.Windows.Forms.ComboBox();
            this.groupeBoat = new System.Windows.Forms.TabPage();
            this.groupeBoatsTextBox = new System.Windows.Forms.TextBox();
            this.groupeBoatsButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupeBoatsComboBox = new System.Windows.Forms.ComboBox();
            this.exportData = new System.Windows.Forms.TabPage();
            this.exportButton = new System.Windows.Forms.Button();
            this.exportPathTextBox = new System.Windows.Forms.TextBox();
            this.chooseExportPathButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.loadData.SuspendLayout();
            this.sortBoats.SuspendLayout();
            this.groupeBoat.SuspendLayout();
            this.exportData.SuspendLayout();
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
            this.openDataFileButton.Text = "Åben datafil";
            this.openDataFileButton.UseVisualStyleBackColor = true;
            this.openDataFileButton.Click += new System.EventHandler(this.openDataFileButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.loadData);
            this.tabControl1.Controls.Add(this.sortBoats);
            this.tabControl1.Controls.Add(this.groupeBoat);
            this.tabControl1.Controls.Add(this.exportData);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 523);
            this.tabControl1.TabIndex = 1;
            // 
            // loadData
            // 
            this.loadData.Controls.Add(this.loadedBoatsTextBox);
            this.loadData.Controls.Add(this.openDataFilePathTextBox);
            this.loadData.Controls.Add(this.openDataFileButton);
            this.loadData.Location = new System.Drawing.Point(4, 22);
            this.loadData.Name = "loadData";
            this.loadData.Padding = new System.Windows.Forms.Padding(3);
            this.loadData.Size = new System.Drawing.Size(772, 497);
            this.loadData.TabIndex = 0;
            this.loadData.Text = "Indlæs både";
            this.loadData.UseVisualStyleBackColor = true;
            // 
            // loadedBoatsTextBox
            // 
            this.loadedBoatsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadedBoatsTextBox.Location = new System.Drawing.Point(6, 50);
            this.loadedBoatsTextBox.Multiline = true;
            this.loadedBoatsTextBox.Name = "loadedBoatsTextBox";
            this.loadedBoatsTextBox.ReadOnly = true;
            this.loadedBoatsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.loadedBoatsTextBox.Size = new System.Drawing.Size(760, 441);
            this.loadedBoatsTextBox.TabIndex = 2;
            // 
            // openDataFilePathTextBox
            // 
            this.openDataFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openDataFilePathTextBox.Location = new System.Drawing.Point(121, 6);
            this.openDataFilePathTextBox.Name = "openDataFilePathTextBox";
            this.openDataFilePathTextBox.ReadOnly = true;
            this.openDataFilePathTextBox.Size = new System.Drawing.Size(645, 20);
            this.openDataFilePathTextBox.TabIndex = 1;
            // 
            // sortBoats
            // 
            this.sortBoats.Controls.Add(this.sortedBoatsTextBox);
            this.sortBoats.Controls.Add(this.sortButton);
            this.sortBoats.Controls.Add(this.label1);
            this.sortBoats.Controls.Add(this.sortingAlgorithmComboBox);
            this.sortBoats.Location = new System.Drawing.Point(4, 22);
            this.sortBoats.Name = "sortBoats";
            this.sortBoats.Padding = new System.Windows.Forms.Padding(3);
            this.sortBoats.Size = new System.Drawing.Size(772, 497);
            this.sortBoats.TabIndex = 1;
            this.sortBoats.Text = "Sorter både";
            this.sortBoats.UseVisualStyleBackColor = true;
            // 
            // sortedBoatsTextBox
            // 
            this.sortedBoatsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sortedBoatsTextBox.Location = new System.Drawing.Point(6, 53);
            this.sortedBoatsTextBox.Multiline = true;
            this.sortedBoatsTextBox.Name = "sortedBoatsTextBox";
            this.sortedBoatsTextBox.ReadOnly = true;
            this.sortedBoatsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sortedBoatsTextBox.Size = new System.Drawing.Size(760, 441);
            this.sortedBoatsTextBox.TabIndex = 3;
            this.sortedBoatsTextBox.TextChanged += new System.EventHandler(this.sortedBoatsTextBox_TextChanged);
            // 
            // sortButton
            // 
            this.sortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortButton.Location = new System.Drawing.Point(687, 6);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(85, 25);
            this.sortButton.TabIndex = 2;
            this.sortButton.Text = "Sorter både";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sorteringsalgoritmer";
            // 
            // sortingAlgorithmComboBox
            // 
            this.sortingAlgorithmComboBox.FormattingEnabled = true;
            this.sortingAlgorithmComboBox.Items.AddRange(new object[] {
            "Sv",
            "DH2022"});
            this.sortingAlgorithmComboBox.Location = new System.Drawing.Point(116, 6);
            this.sortingAlgorithmComboBox.Name = "sortingAlgorithmComboBox";
            this.sortingAlgorithmComboBox.Size = new System.Drawing.Size(248, 21);
            this.sortingAlgorithmComboBox.TabIndex = 0;
            // 
            // groupeBoat
            // 
            this.groupeBoat.Controls.Add(this.groupeBoatsTextBox);
            this.groupeBoat.Controls.Add(this.groupeBoatsButton);
            this.groupeBoat.Controls.Add(this.label2);
            this.groupeBoat.Controls.Add(this.groupeBoatsComboBox);
            this.groupeBoat.Location = new System.Drawing.Point(4, 22);
            this.groupeBoat.Name = "groupeBoat";
            this.groupeBoat.Size = new System.Drawing.Size(772, 497);
            this.groupeBoat.TabIndex = 3;
            this.groupeBoat.Text = "Grupper både";
            this.groupeBoat.UseVisualStyleBackColor = true;
            // 
            // groupeBoatsTextBox
            // 
            this.groupeBoatsTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupeBoatsTextBox.Location = new System.Drawing.Point(3, 51);
            this.groupeBoatsTextBox.Multiline = true;
            this.groupeBoatsTextBox.Name = "groupeBoatsTextBox";
            this.groupeBoatsTextBox.ReadOnly = true;
            this.groupeBoatsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.groupeBoatsTextBox.Size = new System.Drawing.Size(760, 441);
            this.groupeBoatsTextBox.TabIndex = 7;
            // 
            // groupeBoatsButton
            // 
            this.groupeBoatsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupeBoatsButton.Location = new System.Drawing.Point(684, 4);
            this.groupeBoatsButton.Name = "groupeBoatsButton";
            this.groupeBoatsButton.Size = new System.Drawing.Size(85, 25);
            this.groupeBoatsButton.TabIndex = 6;
            this.groupeBoatsButton.Text = "Grupper både";
            this.groupeBoatsButton.UseVisualStyleBackColor = true;
            this.groupeBoatsButton.Click += new System.EventHandler(this.groupeBoatsButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Grupperings algoritme";
            // 
            // groupeBoatsComboBox
            // 
            this.groupeBoatsComboBox.FormattingEnabled = true;
            this.groupeBoatsComboBox.Items.AddRange(new object[] {
            "JST-Grouping"});
            this.groupeBoatsComboBox.Location = new System.Drawing.Point(123, 3);
            this.groupeBoatsComboBox.Name = "groupeBoatsComboBox";
            this.groupeBoatsComboBox.Size = new System.Drawing.Size(248, 21);
            this.groupeBoatsComboBox.TabIndex = 4;
            // 
            // exportData
            // 
            this.exportData.Controls.Add(this.exportButton);
            this.exportData.Controls.Add(this.exportPathTextBox);
            this.exportData.Controls.Add(this.chooseExportPathButton);
            this.exportData.Location = new System.Drawing.Point(4, 22);
            this.exportData.Name = "exportData";
            this.exportData.Padding = new System.Windows.Forms.Padding(3);
            this.exportData.Size = new System.Drawing.Size(772, 497);
            this.exportData.TabIndex = 2;
            this.exportData.Text = "Gem både";
            this.exportData.UseVisualStyleBackColor = true;
            // 
            // exportButton
            // 
            this.exportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exportButton.Location = new System.Drawing.Point(691, 7);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 2;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // exportPathTextBox
            // 
            this.exportPathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exportPathTextBox.Location = new System.Drawing.Point(128, 8);
            this.exportPathTextBox.Name = "exportPathTextBox";
            this.exportPathTextBox.ReadOnly = true;
            this.exportPathTextBox.Size = new System.Drawing.Size(542, 20);
            this.exportPathTextBox.TabIndex = 1;
            // 
            // chooseExportPathButton
            // 
            this.chooseExportPathButton.Location = new System.Drawing.Point(7, 7);
            this.chooseExportPathButton.Name = "chooseExportPathButton";
            this.chooseExportPathButton.Size = new System.Drawing.Size(115, 23);
            this.chooseExportPathButton.TabIndex = 0;
            this.chooseExportPathButton.Text = "Vælg export sti";
            this.chooseExportPathButton.UseVisualStyleBackColor = true;
            this.chooseExportPathButton.Click += new System.EventHandler(this.chooseExportPathButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 527);
            this.Controls.Add(this.tabControl1);
            this.Name = "mainForm";
            this.Text = "Løbsindeling";
            this.tabControl1.ResumeLayout(false);
            this.loadData.ResumeLayout(false);
            this.loadData.PerformLayout();
            this.sortBoats.ResumeLayout(false);
            this.sortBoats.PerformLayout();
            this.groupeBoat.ResumeLayout(false);
            this.groupeBoat.PerformLayout();
            this.exportData.ResumeLayout(false);
            this.exportData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openDataFileButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage loadData;
        private System.Windows.Forms.TextBox openDataFilePathTextBox;
        private System.Windows.Forms.TabPage sortBoats;
        private System.Windows.Forms.TextBox loadedBoatsTextBox;
        private System.Windows.Forms.ComboBox sortingAlgorithmComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.TextBox sortedBoatsTextBox;
        private System.Windows.Forms.TabPage exportData;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.TextBox exportPathTextBox;
        private System.Windows.Forms.Button chooseExportPathButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage groupeBoat;
        private System.Windows.Forms.TextBox groupeBoatsTextBox;
        private System.Windows.Forms.Button groupeBoatsButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox groupeBoatsComboBox;
    }
}

