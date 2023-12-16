using loebsindeling.groupsettings.grafDrawingFolder;
using loebsindeling.sortsettings;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace loebsindeling.groupsettings
{
    public partial class GrafDrawing : Form
    {
        int mouseX, mouseY;
        bool mouseInPanel;
        string xVar, yVar;
        List<string> dotVars;
        private double xScale, yScale;
        private double minX, minY, maxX, maxY;
        private double xRange, yRange;
        public bool abort;
        List<double> pointsXValue;
        List<double> pointsYValue;

        const int DIST_FROM_CLICK_TO_POINT = 7;
        const int QUEUE_MAX_SIZE = 2;
        const double TOOL_TIP_DISPLAY_DIST = 10.0;

        Bitmap dotBitMap;
        Bitmap clicksBitMap;

        Color blueColor = Color.FromArgb(91, 192, 222);
        Color redColor = Color.FromArgb(255,0,0);
        Color blackColor = Color.FromArgb(0,0,0);

        Pen penBlue;
        Pen penRed;
        Pen penBlack;


        private System.Timers.Timer aTimer;
        private Queue<int> xMouseQueue;
        private Queue<int> yMouseQueue;

        System.Windows.Forms.ToolTip toolTip;


        public GrafDrawing()
        {
            InitializeComponent();
            xVar = "score";
            yVar = "l";
            dotVars = new List<string>();
            dotVars.Add("baadtypenavn");
            xScale = 1;
            yScale = 1;
            abort = true;
            pointsXValue = new List<double>();
            pointsYValue = new List<double>();

            dotBitMap = new Bitmap(panel1.Width, panel1.Height);
            clicksBitMap = new Bitmap(panel1.Width, panel1.Height);

            penBlue = new Pen(blueColor, 2);
            penRed = new Pen(redColor, 5);
            penBlack = new Pen(blackColor, 1);

            aTimer = new System.Timers.Timer(30);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;

            xMouseQueue = new Queue<int>();
            yMouseQueue = new Queue<int>();

            toolTip = new System.Windows.Forms.ToolTip();

            reCalNumbers();
            reDrawDotsOnBitMap();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;

            g.DrawImage(dotBitMap, 0, 0);
            g.DrawImage(clicksBitMap, 0, 0);

            if (mouseInPanel)
            {
                g.DrawLine(penBlack, mouseX, panel1.Height, mouseX, mouseY);
                g.DrawLine(penBlack, 0, mouseY, mouseX, mouseY);
            }
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
            aTimer.Start();
            mouseInPanel = true;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            aTimer.Stop();
            mouseInPanel = false;
            mouseY = 0;
            mouseX = 0;
            this.Refresh();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseInPanel)
            {
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            updateMouseQueue(mouseX,mouseY);

            if (updatePlaneGraphics()) { 
                this.Invoke((MethodInvoker)delegate
                {
                    string text = getToolTipString();
                    if (!text.Equals(""))
                    {
                        toolTip.SetToolTip(panel1, text);
                    }
                    else
                    {
                        toolTip.Hide(panel1);
                    }
                    this.Refresh();
                });
            }
            
        }

        private void save_Click(object sender, EventArgs e)
        {
            aTimer.Stop();
            aTimer.Elapsed -= OnTimedEvent;
            aTimer.Dispose();
            Boat.SetgroupeIdForAll(0);
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
            reCalNumbers();
            reDrawDotsOnBitMap();
            AxisText.Text = "x Axis: " + xVar + "      y Axis: " + yVar;
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
            reCalNumbers();
            reDrawDotsOnBitMap();
            AxisText.Text = "x Axis: " + xVar + "      y Axis: " + yVar;
            this.Refresh();
        }

        private void GrafDrawing_ResizeEnd(object sender, EventArgs e)
        {
            reCalNumbers();
            reDrawDotsOnBitMap();
            reDrawClicksOnBitMap();
            this.Refresh();
        }

        private void panel1_Click(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = this.panel1.Height - e.Y;

            for(int i = 0; i < pointsXValue.Count; i++)
            {
                int otherX = (int)((pointsXValue[i] - minX) * xScale);
                int otherY = (int)((pointsYValue[i] - minY) * yScale);
                double dist = Math.Sqrt(Math.Pow(x - otherX, 2) + Math.Pow(y-otherY,2));

                if(dist < DIST_FROM_CLICK_TO_POINT)
                {
                    pointsXValue.RemoveAt(i);
                    pointsYValue.RemoveAt(i);
                    reDrawClicksOnBitMap();
                    this.Refresh();
                    return;
                }
            }
            
            double xD = x / xScale;
            double yD = y / yScale;
            xD += minX;
            yD += minY;
            pointsXValue.Add(xD);
            pointsYValue.Add(yD);
            reDrawClicksOnBitMap();
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

        private void changeDataOnDotsButton_Click(object sender, EventArgs e)
        {
            List<string> varNames;
            varNames = Boat.getDataLocationIndex().Keys.ToList();
            VariabelToShow variabelToShow = new VariabelToShow();
            variabelToShow.checkedListBox1.Items.Clear();
            for(int i = 0; i < varNames.Count; i++)
            {
                variabelToShow.checkedListBox1.Items.Add(varNames[i]);
                if (dotVars.Contains(varNames[i]))
                {
                    variabelToShow.checkedListBox1.SetItemChecked(i, true);
                }
            }
            variabelToShow.checkedListBox1.Items.Add("sorterings score");
            variabelToShow.ShowDialog();

            if (variabelToShow.abortFlag)
                return;

            dotVars.Clear();
            for(int i = 0; i < variabelToShow.checkedListBox1.CheckedItems.Count; i++)
            {
                dotVars.Add(variabelToShow.checkedListBox1.CheckedItems[i].ToString());
            }
        }

        private void reCalNumbers()
        {
            minX = Double.MaxValue; minY = Double.MaxValue;
            maxX = Double.MinValue; maxY = Double.MinValue;
            foreach (Boat boat in Boat.boats)
            {
                boat.xCordDraw = boat.getDataDoubleCast(xVar);
                boat.yCordDraw = boat.getDataDoubleCast(yVar);
                
                if (minX > boat.xCordDraw)
                    minX = boat.xCordDraw;
                
                if (minY > boat.yCordDraw)
                    minY = boat.yCordDraw;

                if (maxX < boat.xCordDraw)
                    maxX = boat.xCordDraw;

                if (maxY < boat.yCordDraw)
                    maxY = boat.yCordDraw;
            }

            xRange = maxX - minX;
            yRange = maxY - minY;

            xScale = (panel1.Width - 5) / xRange;
            yScale = (panel1.Height - 5) / yRange;

            foreach(Boat boat in Boat.boats)
            {
                boat.xCordDraw = ((boat.xCordDraw - minX) * xScale);
                boat.yCordDraw = ((boat.yCordDraw - minY) * yScale);
            }
        }

        private void reDrawDotsOnBitMap()
        {
            Graphics tempGraphics;
            dotBitMap = new Bitmap(panel1.Width, panel1.Height);
            tempGraphics = Graphics.FromImage(dotBitMap);
            foreach(Boat boat in Boat.boats)
            {
                tempGraphics.DrawRectangle(penBlue, dot((int) boat.xCordDraw, (int) boat.yCordDraw + 2));
            }
            tempGraphics.Dispose();
        }

        private void reDrawClicksOnBitMap()
        {
            if (pointsXValue.Count > 0)
            {
                Graphics tempGraphics;
                clicksBitMap = new Bitmap(panel1.Width, panel1.Height);
                tempGraphics = Graphics.FromImage(clicksBitMap);
                for (int i = 0; i < pointsXValue.Count; i++)
                {
                    int x = (int)((pointsXValue[i] - minX) * xScale);
                    int y = (int)((pointsYValue[i] - minY) * yScale);
                    tempGraphics.DrawLine(penBlack, x, panel1.Height, x, panel1.Height-y);
                    tempGraphics.DrawLine(penBlack, 0, panel1.Height - y, x, panel1.Height - y);
                    tempGraphics.DrawRectangle(penRed, square(x - 2, panel1.Height - y - 1, 3));
                }
                tempGraphics.Dispose();
            } else
            {
                Graphics tempGraphics;
                clicksBitMap = new Bitmap(panel1.Width, panel1.Height);
                tempGraphics = Graphics.FromImage(clicksBitMap);
                tempGraphics.Dispose();
            }
        }

        private void updateMouseQueue(int x, int y)
        {
            if (xMouseQueue.Count >= QUEUE_MAX_SIZE)
            {
                xMouseQueue.Dequeue();
                yMouseQueue.Dequeue();
            }
            xMouseQueue.Enqueue(x);
            yMouseQueue.Enqueue(y);
        }

        private bool updatePlaneGraphics()
        {
            int[] xArr = xMouseQueue.ToArray();
            int[] yArr = yMouseQueue.ToArray();

            for (int i = 0; i < xMouseQueue.Count; i++)
            {
                if (xArr[0] != xArr[i])
                    return true;
                if (yArr[0] != yArr[i])
                    return true;
            }
            
            return false;
        }

        private string getToolTipString()
        {
            string returnString = "";
            if (mouseInPanel) {
                foreach (Boat boat in Boat.boats)
                {
                    double dst = dist(boat.xCordDraw, boat.yCordDraw, mouseX, (panel1.Height - mouseY));
                    if (dst <= TOOL_TIP_DISPLAY_DIST)
                    {
                        if (!returnString.Equals(""))
                            returnString += "\n";
                        returnString += getBoatDotDataString(boat);
                    }
                }
            }
            return returnString;
        }

        private double dist(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1-x2,2) + Math.Pow(y1-y2,2));
        }
        

        private string getBoatDotDataString(Boat boat)
        {
            string dataString = "";
            if (dotVars.Count == 1 && dotVars[0].Equals("baadtypenavn")) {
                dataString = boat.BaadType;
            } else {
                for (int i = 0; i < dotVars.Count; i++)
                {
                    dataString+= dotVars[i].ToString() + ": " + boat.getDataAsString(dotVars[i]) + "   ";
                }
                dataString.Remove(dataString.Length-3, 3);
            }
            return dataString;
        }

    }
}
