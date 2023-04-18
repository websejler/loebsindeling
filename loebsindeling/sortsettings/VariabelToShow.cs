using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loebsindeling.sortsettings
{
    public partial class VariabelToShow : Form
    {

        public bool abortFlag;
        public VariabelToShow()
        {
            InitializeComponent();
            abortFlag = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abortFlag = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
