namespace loebsindeling.sortsettings
{
    partial class DHCDLWindSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DHCDLWindSelector));
            this.WindSelectorComboBox = new System.Windows.Forms.ComboBox();
            this.SortButon = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WindSelectorComboBox
            // 
            this.WindSelectorComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WindSelectorComboBox.FormattingEnabled = true;
            this.WindSelectorComboBox.Location = new System.Drawing.Point(12, 12);
            this.WindSelectorComboBox.Name = "WindSelectorComboBox";
            this.WindSelectorComboBox.Size = new System.Drawing.Size(295, 21);
            this.WindSelectorComboBox.TabIndex = 0;
            // 
            // SortButon
            // 
            this.SortButon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SortButon.Location = new System.Drawing.Point(232, 230);
            this.SortButon.Name = "SortButon";
            this.SortButon.Size = new System.Drawing.Size(75, 23);
            this.SortButon.TabIndex = 1;
            this.SortButon.Text = "Soter";
            this.SortButon.UseVisualStyleBackColor = true;
            this.SortButon.Click += new System.EventHandler(this.SortButon_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(151, 230);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Annuller";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // DHCDLWindSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 268);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SortButon);
            this.Controls.Add(this.WindSelectorComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DHCDLWindSelector";
            this.Text = "DHCDL";
            this.Load += new System.EventHandler(this.DHCDLWindSelector_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox WindSelectorComboBox;
        private System.Windows.Forms.Button SortButon;
        private System.Windows.Forms.Button CancelButton;
    }
}