namespace loebsindeling.groupsettings.grafDrawingFolder
{
    partial class LineSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LineSelector));
            this.pictureBoxHorizontal = new System.Windows.Forms.PictureBox();
            this.pictureBoxVertical = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeftDown = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeftUp = new System.Windows.Forms.PictureBox();
            this.pictureBoxRightDown = new System.Windows.Forms.PictureBox();
            this.pictureBoxRightUp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightUp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHorizontal
            // 
            this.pictureBoxHorizontal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxHorizontal.Image = global::loebsindeling.Properties.Resources.horizontal;
            this.pictureBoxHorizontal.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxHorizontal.Name = "pictureBoxHorizontal";
            this.pictureBoxHorizontal.Size = new System.Drawing.Size(102, 102);
            this.pictureBoxHorizontal.TabIndex = 0;
            this.pictureBoxHorizontal.TabStop = false;
            this.pictureBoxHorizontal.Click += new System.EventHandler(this.pictureBoxHorizontal_Click);
            // 
            // pictureBoxVertical
            // 
            this.pictureBoxVertical.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxVertical.Image = global::loebsindeling.Properties.Resources.vertical;
            this.pictureBoxVertical.Location = new System.Drawing.Point(12, 120);
            this.pictureBoxVertical.Name = "pictureBoxVertical";
            this.pictureBoxVertical.Size = new System.Drawing.Size(102, 102);
            this.pictureBoxVertical.TabIndex = 1;
            this.pictureBoxVertical.TabStop = false;
            this.pictureBoxVertical.Click += new System.EventHandler(this.pictureBoxVertical_Click);
            // 
            // pictureBoxLeftDown
            // 
            this.pictureBoxLeftDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLeftDown.Image = global::loebsindeling.Properties.Resources.leftDown;
            this.pictureBoxLeftDown.Location = new System.Drawing.Point(120, 12);
            this.pictureBoxLeftDown.Name = "pictureBoxLeftDown";
            this.pictureBoxLeftDown.Size = new System.Drawing.Size(102, 102);
            this.pictureBoxLeftDown.TabIndex = 2;
            this.pictureBoxLeftDown.TabStop = false;
            this.pictureBoxLeftDown.Click += new System.EventHandler(this.pictureBoxLeftDown_Click);
            // 
            // pictureBoxLeftUp
            // 
            this.pictureBoxLeftUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLeftUp.Image = global::loebsindeling.Properties.Resources.leftUp;
            this.pictureBoxLeftUp.Location = new System.Drawing.Point(228, 12);
            this.pictureBoxLeftUp.Name = "pictureBoxLeftUp";
            this.pictureBoxLeftUp.Size = new System.Drawing.Size(102, 102);
            this.pictureBoxLeftUp.TabIndex = 3;
            this.pictureBoxLeftUp.TabStop = false;
            this.pictureBoxLeftUp.Click += new System.EventHandler(this.pictureBoxLeftUp_Click);
            // 
            // pictureBoxRightDown
            // 
            this.pictureBoxRightDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRightDown.Image = global::loebsindeling.Properties.Resources.rightDown;
            this.pictureBoxRightDown.Location = new System.Drawing.Point(120, 120);
            this.pictureBoxRightDown.Name = "pictureBoxRightDown";
            this.pictureBoxRightDown.Size = new System.Drawing.Size(102, 102);
            this.pictureBoxRightDown.TabIndex = 4;
            this.pictureBoxRightDown.TabStop = false;
            this.pictureBoxRightDown.Click += new System.EventHandler(this.pictureBoxRightDown_Click);
            // 
            // pictureBoxRightUp
            // 
            this.pictureBoxRightUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxRightUp.Image = global::loebsindeling.Properties.Resources.rightUp;
            this.pictureBoxRightUp.Location = new System.Drawing.Point(228, 120);
            this.pictureBoxRightUp.Name = "pictureBoxRightUp";
            this.pictureBoxRightUp.Size = new System.Drawing.Size(102, 102);
            this.pictureBoxRightUp.TabIndex = 5;
            this.pictureBoxRightUp.TabStop = false;
            this.pictureBoxRightUp.Click += new System.EventHandler(this.pictureBoxRightUp_Click);
            // 
            // LineSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 237);
            this.Controls.Add(this.pictureBoxRightUp);
            this.Controls.Add(this.pictureBoxRightDown);
            this.Controls.Add(this.pictureBoxLeftUp);
            this.Controls.Add(this.pictureBoxLeftDown);
            this.Controls.Add(this.pictureBoxVertical);
            this.Controls.Add(this.pictureBoxHorizontal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(360, 276);
            this.MinimumSize = new System.Drawing.Size(360, 276);
            this.Name = "LineSelector";
            this.Text = "LineSelector";
            this.Load += new System.EventHandler(this.LineSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightUp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox pictureBoxHorizontal;
        public System.Windows.Forms.PictureBox pictureBoxLeftDown;
        public System.Windows.Forms.PictureBox pictureBoxLeftUp;
        public System.Windows.Forms.PictureBox pictureBoxVertical;
        public System.Windows.Forms.PictureBox pictureBoxRightDown;
        public System.Windows.Forms.PictureBox pictureBoxRightUp;
    }
}