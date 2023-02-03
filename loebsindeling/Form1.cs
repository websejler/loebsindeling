using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loebsindeling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openDataFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            openDataFilePathTextBox.Text = openFileDialog1.FileName;
            Boat.loadBoatsFromFile(openFileDialog1.FileName);
            loadedBoatsTextBox.Text = "";
            foreach (Boat boat in Boat.boats) {
                loadedBoatsTextBox.Text += boat.Certifikat + "  -  " + boat.BaadNavn + "  -  " + boat.SejlNummer + "\r\n";
            }
        }
    }
}
