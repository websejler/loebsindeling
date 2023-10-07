using loebsindeling.groupsettings.grafDrawingFolder;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loebsindeling.groupsettings
{
    public partial class GrafDrawing : Form
    {
        
        public GrafDrawing()
        {
            InitializeComponent();   
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.FromArgb(91, 192, 222) , 2);
            List<double> xs = new List<double>();
            List<double> ys = new List<double>();
            foreach(Boat boat in Boat.boats)
            {
               xs.Add(boat.Score);
                //ys.Add(boat.LOA-boat.OA-boat.OF);
                ys.Add(boat.L);
            }

            double minX = xs.Min();
            double minY = ys.Min();

            double maxX = xs.Max();
            double maxY = ys.Max();

            double xRange = maxX- minX;
            double yRange = maxY- minY;

            double xScale = (panel1.Width - 3)/ xRange;
            double yScale = (panel1.Height - 3)/ yRange;

            for(int i = 0; i < xs.Count; i++)
            {
                xs[i] = (xs[i]-minX)*xScale;
                ys[i] = (ys[i]-minY)*yScale;
                g.DrawRectangle(pen, dot((int)xs[i], (int)ys[i]));
            }
            
        }

        private System.Drawing.Rectangle dot(int x, int y)
        {
            return new System.Drawing.Rectangle(x+1, panel1.Height - (y + 2),1,1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> varNames = new List<string>(Boat.getDataLocationIndex().Keys);
            //todo remove other axis form list.
            
            ChangeDataInGraph changeDataInGraph = new ChangeDataInGraph(varNames);
            changeDataInGraph.Show();

        }
    }
}
