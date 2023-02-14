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
using static System.Net.Mime.MediaTypeNames;

namespace loebsindeling
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            saveFileDialog1.FileName = "NA";
        }

        private void openDataFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            openDataFilePathTextBox.Text = openFileDialog1.FileName;
            Boat.loadBoatsFromFile(openFileDialog1.FileName);
            loadedBoatsTextBox.Text = Boat.boatsToStringSimpel(Boat.boats);
        }

        private void sortButton_Click(object sender, EventArgs e) {
            int i = sortingAlgorithmComboBox.SelectedIndex;
            if(i == -1) {
                sortedBoatsTextBox.Text = "Pleas select a sorting algorithm.";
                return;
            }
            
            switch(sortingAlgorithmComboBox.Items[i].ToString().ToLower()) {
                case "sv":
                    Sorting.svSorting(Boat.boats);
                    sortedBoatsTextBox.Text = Boat.boatsToStringSimpel(Boat.boats);
                    break;
                default:
                    sortedBoatsTextBox.Text = "Pleas select a sorting algorithm.";
                    break;
            }
            
            
        }

        private void chooseExportPathButton_Click(object sender, EventArgs e) {
            saveFileDialog1.Filter = "CSV File (.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.ShowDialog(this);
            exportPathTextBox.Text = saveFileDialog1.FileName;

        }

        private void exportButton_Click(object sender, EventArgs e) {
            string path = saveFileDialog1.FileName;
            if (!(path.Equals("NA"))) {
                File.WriteAllText(path, Boat.boatsToCsvString(Boat.boats));
                MessageBox.Show("Export success.");
            } else {
                MessageBox.Show("Please choose a export path.");
            }
        }
    }
}
