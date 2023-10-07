namespace loebsindeling.groupsettings
{
    partial class GrafDrawing
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrafDrawing));
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xAxis = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.yAxis = new System.Windows.Forms.Button();
            this.AxisText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 414);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // xAxis
            // 
            this.xAxis.Location = new System.Drawing.Point(12, 457);
            this.xAxis.Name = "xAxis";
            this.xAxis.Size = new System.Drawing.Size(113, 23);
            this.xAxis.TabIndex = 3;
            this.xAxis.Text = "Skift X akse data";
            this.xAxis.UseVisualStyleBackColor = true;
            this.xAxis.Click += new System.EventHandler(this.xAxis_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(713, 457);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Gem";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(632, 457);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Anuller";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // yAxis
            // 
            this.yAxis.Location = new System.Drawing.Point(131, 457);
            this.yAxis.Name = "yAxis";
            this.yAxis.Size = new System.Drawing.Size(113, 23);
            this.yAxis.TabIndex = 7;
            this.yAxis.Text = "Skift Y akse data";
            this.yAxis.UseVisualStyleBackColor = true;
            this.yAxis.Click += new System.EventHandler(this.yAxis_Click);
            // 
            // AxisText
            // 
            this.AxisText.AutoSize = true;
            this.AxisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AxisText.Location = new System.Drawing.Point(14, 429);
            this.AxisText.Name = "AxisText";
            this.AxisText.Size = new System.Drawing.Size(167, 20);
            this.AxisText.TabIndex = 8;
            this.AxisText.Text = "x Axis: score     y Axis: l";
            // 
            // GrafDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.AxisText);
            this.Controls.Add(this.yAxis);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.xAxis);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GrafDrawing";
            this.Text = "Graf gruppering";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button xAxis;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button yAxis;
        private System.Windows.Forms.Label AxisText;
    }
}