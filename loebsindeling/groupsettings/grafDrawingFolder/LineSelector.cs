using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loebsindeling.groupsettings.grafDrawingFolder
{
    public partial class LineSelector : Form
    {   
        public int selectedLine = 0;

        public enum LineType : int
        {   
            NA,
            Horizontal,
            Vertical,
            LeftDown,
            RightDown,
            LeftUp,
            RightUp
        }


        /* 
         * LineSelector constructor
         * 
         * selectedLine = 0 if non is selected
         * selectedLine = 1 if horizontal is selected
         * selectedLine = 2 if vertical is selected
         * selectedLine = 3 if leftDown is selected
         * selectedLine = 4 if rightDown is selected
         * selectedLine = 5 if leftUp is selected
         * selectedLine = 6 if rightUp is selected
        */
        public LineSelector(int selectedLine)
        {
            InitializeComponent();
            this.selectedLine = selectedLine;
            switch(selectedLine)
            {
                case 1:
                    pictureBoxHorizontal.Image = Properties.Resources.horizontalGreenBox;
                    break;
                case 2:
                    pictureBoxVertical.Image = Properties.Resources.verticalGreenBox;
                    break;
                case 3:
                    pictureBoxLeftDown.Image = Properties.Resources.leftDownGreenBox;
                    break;
                case 4:
                    pictureBoxRightDown.Image = Properties.Resources.rightDownGreenBox;
                    break;
                case 5:
                    pictureBoxLeftUp.Image = Properties.Resources.leftUpGreenBox;
                    break;
                case 6:
                    pictureBoxRightUp.Image = Properties.Resources.rightUpGreenBox;
                    break;
                default:
                    break;
            }
        }

        private void LineSelector_Load(object sender, EventArgs e)
        {

        }

        private void pictureBoxHorizontal_Click(object sender, EventArgs e)
        {
            selectedLine = 1;
            this.Close();
        }

        private void pictureBoxVertical_Click(object sender, EventArgs e)
        {
            selectedLine = 2;
            this.Close();
        }

        private void pictureBoxLeftDown_Click(object sender, EventArgs e)
        {
            selectedLine = 3;
            this.Close();
        }

        private void pictureBoxRightDown_Click(object sender, EventArgs e)
        {
            selectedLine = 4;
            this.Close();
        }

        private void pictureBoxLeftUp_Click(object sender, EventArgs e)
        {
            selectedLine = 5;
            this.Close();
        }

        private void pictureBoxRightUp_Click(object sender, EventArgs e)
        {
            selectedLine = 6;
            this.Close();
        }
    }
}
