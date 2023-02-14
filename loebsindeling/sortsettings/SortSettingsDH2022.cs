using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loebsindeling
{
    public partial class SortSettingsDH2022 : Form
    {
        public bool abortFlag;
        public SortSettingsDH2022()
        {
            InitializeComponent();
            abortFlag = false;
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
