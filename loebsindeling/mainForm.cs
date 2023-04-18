﻿using loebsindeling.groupsettings;
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
            try
            {   
                loadDataDataGridView1.Rows.Clear();
                loadDataDataGridView1.Refresh();
                loadDataDataGridView1.ColumnCount = 5;
                loadDataDataGridView1.Columns[0].Name = "Certifikat";
                loadDataDataGridView1.Columns[0].ValueType = typeof(int);
                loadDataDataGridView1.Columns[1].Name = "Baad type";
                loadDataDataGridView1.Columns[2].Name = "Nation";
                loadDataDataGridView1.Columns[3].Name = "SejlNummer";
                loadDataDataGridView1.Columns[3].ValueType = typeof(int);
                loadDataDataGridView1.Columns[4].Name = "Baad navn";


                Boat.loadBoatsFromFile(openFileDialog1.FileName);
                object[,] data = Boat.boatsToDataGridViewString(Boat.boats);
                object[] temp = new object[data.GetLength(1)];
                for (int j = 0; j < Boat.boats.Count; j++)
                {
                    for (int i = 0; i < data.GetLength(1); i++)
                    {
                        temp[i] = data[j, i];
                    }
                    loadDataDataGridView1.Rows.Add(temp);
                }
            }
            catch (InvalidDataException error)
            {
                MessageBox.Show("Data kunne ikke læses \n\r" + error.StackTrace);
            }
            exportDataCheckedListBox1.Items.Clear();
            List<string> variable = Boat.getDataLocationIndex().Keys.ToList();
            for (int i = 0; i < variable.Count; i++){
                exportDataCheckedListBox1.Items.Add(variable[i]);
                if (Boat.standartDisplayVars.Contains(variable[i]))
                {
                    exportDataCheckedListBox1.SetItemCheckState(i,CheckState.Checked);
                }
            }
            exportDataCheckedListBox1.Items.Add("sorterings score");
            exportDataCheckedListBox1.SetItemCheckState(exportDataCheckedListBox1.Items.Count- 1,CheckState.Checked);
            exportDataCheckedListBox1.Items.Add("loeb nr");
            exportDataCheckedListBox1.SetItemCheckState(exportDataCheckedListBox1.Items.Count - 1, CheckState.Checked);
        }

        private void sortButton_Click(object sender, EventArgs e) {
            int i = sortingAlgorithmComboBox.SelectedIndex;
            if(i == -1) {
                sortedBoatsTextBox.Text = "Please select a sorting algorithm.";
                return;
            }
            
            switch(sortingAlgorithmComboBox.Items[i].ToString().ToLower()) {
                case "sv":
                    Sorting.svSorting(Boat.boats);
                    sortedBoatsTextBox.Text = Boat.boatsToStringSimpel(Boat.boats);
                    break;
                case "dh2022":
                    SortSettingsDH2022 Form2 = new SortSettingsDH2022();
                    Form2.ShowDialog();

                    if (Form2.abortFlag)
                        break;

                    int circleCount = Decimal.ToInt32(Form2.numberOfCircleRaces.Value);
                    int upDownCount = Decimal.ToInt32(Form2.numberOfUpDownRaces.Value);
                    Sorting.dh2022Sort(Boat.boats, upDownCount, circleCount);
                    sortedBoatsTextBox.Text = Boat.boatsToStringSort(Boat.boats);
                    break;
                default:
                    sortedBoatsTextBox.Text = "Please select a sorting algorithm.";
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
                List<string> list = new List<string>();
                for(int i = 0; i < exportDataCheckedListBox1.CheckedItems.Count; i++)
                {
                    list.Add(exportDataCheckedListBox1.CheckedItems[i].ToString());
                }
                File.WriteAllText(path, Boat.boatsToCsvString(Boat.boats, list));
                MessageBox.Show("Export success.");
            } else {
                MessageBox.Show("Please choose a export path.");
            }
        }

        private void groupeBoatsButton_Click(object sender, EventArgs e)
        {
            int i = groupeBoatsComboBox.SelectedIndex;
            if (i == -1){
                groupeBoatsTextBox.Text = "Please select a grouping algorithm.";
                return;
            }

            switch(groupeBoatsComboBox.Items[i].ToString().ToLower())
            {
                case "jst-grouping":
                    jst_groupSettings form2 = new jst_groupSettings();
                    form2.ShowDialog();

                    if (form2.abortFlag)
                        break;

                    int numberOfgroups = Decimal.ToInt32(form2.numberOfGroups.Value);
                    Grouping.jst_grouping(Boat.boats, numberOfgroups);
                    groupeBoatsTextBox.Text = Boat.boatsToStringGrouping(Boat.boats);
                    break;

                default :
                    sortedBoatsTextBox.Text = "Please select a grouping algorithm.";
                    break;
            }

        }

        
    }
}
