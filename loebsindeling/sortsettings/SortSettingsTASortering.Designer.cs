namespace loebsindeling
{
    partial class SortSettingsTASortering
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortSettingsTASortering));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberOfUpDownRaces = new System.Windows.Forms.NumericUpDown();
            this.numberOfCircleRaces = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LightWindLable = new System.Windows.Forms.Label();
            this.WindWeightCheckBox = new System.Windows.Forms.CheckBox();
            this.MediumWindLable = new System.Windows.Forms.Label();
            this.HardWindLable = new System.Windows.Forms.Label();
            this.LightWindWeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MediumWindWeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HardWindWeightNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfUpDownRaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfCircleRaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightWindWeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediumWindWeightNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HardWindWeightNumericUpDown)).BeginInit();
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
            // LightWindLable
            // 
            this.LightWindLable.AutoSize = true;
            this.LightWindLable.Location = new System.Drawing.Point(12, 113);
            this.LightWindLable.Name = "LightWindLable";
            this.LightWindLable.Size = new System.Drawing.Size(118, 13);
            this.LightWindLable.TabIndex = 12;
            this.LightWindLable.Text = "Let vind vægt 0 - 4 m/s";
            // 
            // WindWeightCheckBox
            // 
            this.WindWeightCheckBox.AutoSize = true;
            this.WindWeightCheckBox.Location = new System.Drawing.Point(12, 80);
            this.WindWeightCheckBox.Name = "WindWeightCheckBox";
            this.WindWeightCheckBox.Size = new System.Drawing.Size(132, 17);
            this.WindWeightCheckBox.TabIndex = 14;
            this.WindWeightCheckBox.Text = "Manuel vind vægtning";
            this.WindWeightCheckBox.UseVisualStyleBackColor = true;
            this.WindWeightCheckBox.CheckStateChanged += new System.EventHandler(this.WindWeightCheckBox_CheckStateChanged);
            // 
            // MediumWindLable
            // 
            this.MediumWindLable.AutoSize = true;
            this.MediumWindLable.Location = new System.Drawing.Point(12, 146);
            this.MediumWindLable.Name = "MediumWindLable";
            this.MediumWindLable.Size = new System.Drawing.Size(136, 13);
            this.MediumWindLable.TabIndex = 15;
            this.MediumWindLable.Text = "Mellem vind vægt 3 - 9 m/s";
            // 
            // HardWindLable
            // 
            this.HardWindLable.AutoSize = true;
            this.HardWindLable.Location = new System.Drawing.Point(12, 179);
            this.HardWindLable.Name = "HardWindLable";
            this.HardWindLable.Size = new System.Drawing.Size(117, 13);
            this.HardWindLable.TabIndex = 17;
            this.HardWindLable.Text = "Hård vind vægt +8 m/s";
            // 
            // LightWindWeightNumericUpDown
            // 
            this.LightWindWeightNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.LightWindWeightNumericUpDown.Location = new System.Drawing.Point(179, 111);
            this.LightWindWeightNumericUpDown.Name = "LightWindWeightNumericUpDown";
            this.LightWindWeightNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.LightWindWeightNumericUpDown.TabIndex = 19;
            this.LightWindWeightNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MediumWindWeightNumericUpDown
            // 
            this.MediumWindWeightNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.MediumWindWeightNumericUpDown.Location = new System.Drawing.Point(179, 144);
            this.MediumWindWeightNumericUpDown.Name = "MediumWindWeightNumericUpDown";
            this.MediumWindWeightNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.MediumWindWeightNumericUpDown.TabIndex = 20;
            this.MediumWindWeightNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HardWindWeightNumericUpDown
            // 
            this.HardWindWeightNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.HardWindWeightNumericUpDown.Location = new System.Drawing.Point(179, 177);
            this.HardWindWeightNumericUpDown.Name = "HardWindWeightNumericUpDown";
            this.HardWindWeightNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.HardWindWeightNumericUpDown.TabIndex = 21;
            this.HardWindWeightNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SortSettingsTASortering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HardWindWeightNumericUpDown);
            this.Controls.Add(this.MediumWindWeightNumericUpDown);
            this.Controls.Add(this.LightWindWeightNumericUpDown);
            this.Controls.Add(this.HardWindLable);
            this.Controls.Add(this.MediumWindLable);
            this.Controls.Add(this.WindWeightCheckBox);
            this.Controls.Add(this.LightWindLable);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numberOfCircleRaces);
            this.Controls.Add(this.numberOfUpDownRaces);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SortSettingsTASortering";
            this.Text = "SortSettings";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfUpDownRaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfCircleRaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LightWindWeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediumWindWeightNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HardWindWeightNumericUpDown)).EndInit();
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
        private System.Windows.Forms.Label LightWindLable;
        private System.Windows.Forms.CheckBox WindWeightCheckBox;
        private System.Windows.Forms.Label MediumWindLable;
        private System.Windows.Forms.Label HardWindLable;
        private System.Windows.Forms.NumericUpDown LightWindWeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown MediumWindWeightNumericUpDown;
        private System.Windows.Forms.NumericUpDown HardWindWeightNumericUpDown;
    }
}