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
    public partial class DHCDLWindSelector : Form
    {
        public bool abort;


        public DHCDLWindSelector(List<string> vars)
        {
            InitializeComponent();
            abort = false;
            WindSelectorComboBox.Items.Clear();
            foreach (string var in vars)
            {
                WindSelectorComboBox.Items.Add(var);
            }
            int i = vars.IndexOf("tau6");
            if(i != -1)
            {
                WindSelectorComboBox.SelectedIndex = i;
            }
        }

        private void DHCDLWindSelector_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            abort = true;
            this.Close();
        }

        private void SortButon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string getSelectedVar()
        {
            return (string) WindSelectorComboBox.SelectedItem;
        }
    }
}
