namespace loebsindeling
{
    partial class SortSettingsDH2022
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortSettingsDH2022));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfUpDownRaces = new System.Windows.Forms.NumericUpDown();
            this.numberOfCircleRaces = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfUpDownRaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfCircleRaces)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Antal op ned sejladser";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Antal cirkel sejladser";
            // 
            // numberOfUpDownRaces
            // 
            this.numberOfUpDownRaces.Location = new System.Drawing.Point(129, 7);
            this.numberOfUpDownRaces.Name = "numberOfUpDownRaces";
            this.numberOfUpDownRaces.Size = new System.Drawing.Size(117, 20);
            this.numberOfUpDownRaces.TabIndex = 8;
            // 
            // numberOfCircleRaces
            // 
            this.numberOfCircleRaces.Location = new System.Drawing.Point(129, 33);
            this.numberOfCircleRaces.Name = "numberOfCircleRaces";
            this.numberOfCircleRaces.Size = new System.Drawing.Size(117, 20);
            this.numberOfCircleRaces.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(699, 413);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "Gem";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(604, 413);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 25);
            this.button2.TabIndex = 11;
            this.button2.Text = "Annuller";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SortSettingsDH2022
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numberOfCircleRaces);
            this.Controls.Add(this.numberOfUpDownRaces);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SortSettingsDH2022";
            this.Text = "SortSettings";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfUpDownRaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfCircleRaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.NumericUpDown numberOfUpDownRaces;
        public System.Windows.Forms.NumericUpDown numberOfCircleRaces;
    }
}