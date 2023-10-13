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
        int mouseX, mouseY;
        bool mouseInPanel;
        string xVar, yVar;
        private double xScale, yScale;
        private double minX, minY, maxX, maxY;
        private double xRange, yRange;
        public bool abort;
        List<double> pointsXValue;
        List<double> pointsYValue;
        const int DIST_FROM_CLICK_TO_POINT = 7;

        Color blueColor = Color.FromArgb(91, 192, 222);
        Color redColor = Color.FromArgb(255,0,0);
        Color blackColor = Color.FromArgb(0,0,0);

        public GrafDrawing()
        {
            InitializeComponent();
            xVar = "score";
            yVar = "l";
            xScale = 1;
            yScale = 1;
            abort = true;
            pointsXValue = new List<double>();
            pointsYValue = new List<double>();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen penBlue = new Pen(blueColor, 2);
            Pen penRed = new Pen(redColor, 5);
            Pen penBlack = new Pen(blackColor, 1);
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
                g.DrawRectangle(penBlue, dot((int)xs[i], (int)ys[i] + 2));
                
                
            }
            if (pointsXValue.Count > 0) {
                for (int i = 0; i < pointsXValue.Count; i++)
                {
                    int x = (int)((pointsXValue[i] - minX) * xScale);
                    int y = (int)((pointsYValue[i] - minY) * yScale);
                    g.DrawLine(penBlack, x, panel1.Height, x, y);
                    g.DrawLine(penBlack, 0, y, x, y);
                    g.DrawRectangle(penRed, square(x - 2, y - 1, 3));
                }
            }
            if (mouseInPanel)
            {
                g.DrawLine(penBlack, mouseX, panel1.Height, mouseX, mouseY);
                g.DrawLine(penBlack, 0, mouseY, mouseX, mouseY);
            }

            AxisText.Text = "x Axis: " + xVar + "      y Axis: " + yVar;
        }

        private System.Drawing.Rectangle dot(int x, int y)
        {
            return new System.Drawing.Rectangle(x + 1, panel1.Height - (y + 2), 1, 1);
        }

        private System.Drawing.Rectangle square(int x, int y, int size)
        {
            
            return new System.Drawing.Rectangle((int)x, (int)y, size, size);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            mouseInPanel = true;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            mouseInPanel = false;
            this.Refresh();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseInPanel)
            {
                mouseX = e.X;
                mouseY = e.Y;
                this.Refresh();
            }

        }

        private void save_Click(object sender, EventArgs e)
        {
            //todo: lig både i grupper alt efter hvor der er blevet klikket.
            abort = false;
            int i;
            for (i = 0; i < pointsXValue.Count; i++)
            {
                foreach(Boat boat in Boat.boats)
                {
                    if(boat.GroupeId == 0)
                    {
                        if(boat.getDataDoubleCast(xVar) < pointsXValue[i])
                        {
                            if(boat.getDataDoubleCast(yVar) < pointsYValue[i])
                            {
                                boat.GroupeId = i + 1;
                            }
                        }
                    }
                }
            }
            foreach (Boat boat in Boat.boats)
            {
                if (boat.GroupeId == 0)
                {
                    boat.GroupeId = i + 1;
                }
            }
            this.Close();
        }

        private void yAxis_Click(object sender, EventArgs e)
        {
            List<String> varNames = new List<string>(Boat.getDataLocationIndex().Keys);
            removeNonNumberVarsFromList(varNames);
            varNames.Add("score");
            ChangeDataInGraph changeDataInGraph = new ChangeDataInGraph(varNames);
            changeDataInGraph.ShowDialog();
            if (changeDataInGraph.var.Equals(""))
                return;
            yVar = changeDataInGraph.var;
            pointsXValue.Clear();
            pointsYValue.Clear();
            this.Refresh();
        }

        private void xAxis_Click(object sender, EventArgs e)
        {
            List<String> varNames = new List<string>(Boat.getDataLocationIndex().Keys);
            removeNonNumberVarsFromList(varNames);
            varNames.Add("score");
            ChangeDataInGraph changeDataInGraph = new ChangeDataInGraph(varNames);
            changeDataInGraph.ShowDialog();
            if (changeDataInGraph.var.Equals(""))
                return;
            xVar = changeDataInGraph.var;
            pointsXValue.Clear();
            pointsYValue.Clear();
            this.Refresh();
        }

        private void GrafDrawing_ResizeEnd(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void panel1_Click(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;

            for(int i = 0; i < pointsXValue.Count; i++)
            {
                int otherX = (int)((pointsXValue[i] - minX) * xScale);
                int otherY = (int)((pointsYValue[i] - minY) * yScale);
                double dist = Math.Sqrt(Math.Pow(x - otherX, 2) + Math.Pow(y-otherY,2));

                if(dist < DIST_FROM_CLICK_TO_POINT)
                {
                    pointsXValue.RemoveAt(i);
                    pointsYValue.RemoveAt(i);
                    this.Refresh();
                    return;
                }
            }
            
            double xD = e.X / xScale;
            double yD = e.Y / yScale;
            xD += minX;
            yD += minY;
            pointsXValue.Add(xD);
            pointsYValue.Add(yD);
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
