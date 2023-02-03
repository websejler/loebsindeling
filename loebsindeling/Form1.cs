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
            loadedBoatsTextBox.Text = Boat.boatsToString(Boat.boats);
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
                    sortedBoatsTextBox.Text = Boat.boatsToString(Boat.boats);
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
    }
}
