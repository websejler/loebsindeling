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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.FileName = "NA";
        }

        //openDataFileButton_Click
        // function runs when "open data file" button is pressed.
        // selects the path to the file from data shall be loaded.
        private void openDataFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
            openDataFilePathTextBox.Text = openFileDialog1.FileName;
            Boat.loadBoatsFromFile(openFileDialog1.FileName);
            loadedBoatsTextBox.Text = Boat.boatsToStringSimpel(Boat.boats);
        }
        //sortButton_Click
        // function runs when "sort butten is pressed
        // sorts the list acording to the sorting algorithem specifides by "sortedBoatsTextBox"
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
        //chooseExportPathButton_Click
        // function runs when "choose export Path" butten is pressed
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
