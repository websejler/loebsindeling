using loebsindeling.groupsettings.grafDrawingFolder;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loebsindeling.groupsettings
{
    public partial class GrafDrawing : Form
    {

        string xVar, yVar;
        private double xScale, yScale;
        private double minX, minY, maxX, maxY;
        private double xRange, yRange;
        public bool abort;
        List<double> pointsX;
        List<double> pointsY;
        Color blueColor = Color.FromArgb(91, 192, 222);
        Color redColor = Color.FromArgb(255,0,0);

        public GrafDrawing()
        {
            InitializeComponent();
            xVar = "score";
            yVar = "l";
            xScale = 1;
            yScale = 1;
            abort = true;
            pointsX = new List<double>();
            pointsY = new List<double>();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(blueColor, 2);
            List<double> xs = new List<double>();
            List<double> ys = new List<double>();
            foreach (Boat boat in Boat.boats)
            {
                xs.Add(boat.getDataDoubleCast(xVar));
                ys.Add(boat.getDataDoubleCast(yVar));
            }

            minX = xs.Min();
            minY = ys.Min();

            maxX = xs.Max();
            maxY = ys.Max();

            xRange = maxX - minX;
            yRange = maxY - minY;

            xScale = (panel1.Width - 5) / xRange;
            yScale = (panel1.Height - 5) / yRange;

            for (int i = 0; i < xs.Count; i++)
            {
                xs[i] = (xs[i] - minX) * xScale;
                ys[i] = (ys[i] - minY) * yScale;
                g.DrawRectangle(pen, dot((int)xs[i], (int)ys[i] + 2));
            }
            if (pointsX.Count > 0) {
                pen = new Pen(redColor, 5);
                for (int i = 0; i < pointsX.Count; i++)
                {
                    g.DrawRectangle(pen, square((pointsX[i]-minX)*xScale, (pointsY[i]-minY)*yScale, 3));
                }
            }

            AxisText.Text = "x Axis: " + xVar + "      y Axis: " + yVar;
        }

        private System.Drawing.Rectangle dot(int x, int y)
        {
            return new System.Drawing.Rectangle(x + 1, panel1.Height - (y + 2), 1, 1);
        }

        private System.Drawing.Rectangle square(double x, double y, int size)
        {
            
            return new System.Drawing.Rectangle((int)x, (int)y, size, size);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            //todo: lig både i grupper alt efter hvor der er blevet klikket.
            abort = false;
            this.Close();
        }

        private void yAxis_Click(object sender, EventArgs e)
        {
            List<String> varNames = new List<string>(Boat.getDataLocationIndex().Keys);
            removeNonNumberVarsFromList(varNames);
            ChangeDataInGraph changeDataInGraph = new ChangeDataInGraph(varNames);
            changeDataInGraph.ShowDialog();
            if (changeDataInGraph.var.Equals(""))
                return;
            yVar = changeDataInGraph.var;
            pointsX.Clear();
            pointsY.Clear();
            this.Refresh();
        }

        private void xAxis_Click(object sender, EventArgs e)
        {
            List<String> varNames = new List<string>(Boat.getDataLocationIndex().Keys);
            removeNonNumberVarsFromList(varNames);
            ChangeDataInGraph changeDataInGraph = new ChangeDataInGraph(varNames);
            changeDataInGraph.ShowDialog();
            if (changeDataInGraph.var.Equals(""))
                return;
            xVar = changeDataInGraph.var;
            pointsX.Clear();
            pointsY.Clear();
            this.Refresh();
        }

        private void GrafDrawing_ResizeEnd(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void panel1_Click(object sender, MouseEventArgs e)
        {
            
            double x = e.X / xScale;
            double y = e.Y / yScale;
            x += minX;
            y += minY;
            pointsX.Add(x);
            pointsY.Add(y);
            this.Refresh();
        }

        private void removeNonNumberVarsFromList(List<String> varNames)
        {
            for (int i = 0; i < varNames.Count; i++)
            {
                if (Boat.valuesThatIsString.Contains(varNames[i]))
                {
                    varNames.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
