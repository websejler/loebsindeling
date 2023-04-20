using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loebsindeling.groupsettings
{
    public partial class Jst_groupSettings : Form
    {
        public bool abortFlag;
        public Jst_groupSettings()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//annuller button
        {
            abortFlag = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//gem button
        {   
            this.Close();
        }
    }
}
