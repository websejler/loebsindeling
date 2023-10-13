using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loebsindeling.groupsettings.grafDrawingFolder
{
    public partial class ChangeDataInGraph : Form
    {
        public int i = 1;
        List<Button> buttonList = new List<Button>();
        public string var = "";

        public ChangeDataInGraph(List<String> varNames)
        {
            InitializeComponent();
            i = varNames.Count;
            for (int j = 0; j < i; j++)
            {
                Button button = new Button();
                button.Text = j.ToString();
                if (j == 0)
                {
                    button.Location = new Point(0, 0);
                }
                else
                {
                    int x = buttonList[(j - 1)].Location.X;
                    int y = buttonList[(j - 1)].Location.Y;
                    y += button.Height;
                    button.Location = new Point(x, y);
                }
                button.Text = varNames[j];
                button.Click += new EventHandler(changeVarButton_Click);
                this.panel1.Controls.Add(button);
                button.Show();
                buttonList.Add(button);
            }

        }

        protected void changeVarButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            var = b.Text;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
