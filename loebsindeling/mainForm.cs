using loebsindeling.groupsettings;
using loebsindeling.sortsettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Policy;
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
            this.Text = "Løbsindeling - " + VersionLabel;
            DateTime dateTime = DateTime.Now;
            if(dateTime.CompareTo(DateTime.Parse("1 March 2024")) == 1)
                MessageBox.Show("!!!  Dette er måske ikke den nyeste version af Lobesindeling  !!!");
        }

        private void openDataFileButton_Click(object sender, EventArgs e)
        {
            string fileFilter = "CSV files (*.csv)|*.csv";

            Type officeType = Type.GetTypeFromProgID("Excel.Application");
            if (officeType != null) {
                fileFilter += "|Excel files (*.xlsx)|*.xlsx";
            }
            
            openFileDialog1.Filter = fileFilter;
            openFileDialog1.ShowDialog(this);
            if (openFileDialog1.FileName.Equals("openFileDialog1")){
                return;
            }
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
        }

        private void sortButton_Click(object sender, EventArgs e) {
            int i = sortingAlgorithmComboBox.SelectedIndex;
            if(i == -1) {
                MessageBox.Show("Vælg en sortering algoritme");
                return;
            }
            
            switch(sortingAlgorithmComboBox.Items[i].ToString().ToLower()) {
                case "sv":
                    Sorting.svSorting(Boat.boats);
                    Boat.SetgroupeIdForAll(0);
                    Boat.displayDataGridView(Boat.boats, sortDataGridView, Boat.standartDisplayVars);
                    break;
                case "ta sortering":
                    SortSettingsTASortering Form2 = new SortSettingsTASortering();
                    Form2.ShowDialog();

                    if (Form2.abortFlag)
                        break;

                    int circleCount = Decimal.ToInt32(Form2.numberOfCircleRaces.Value);
                    int upDownCount = Decimal.ToInt32(Form2.numberOfUpDownRaces.Value);
                    Sorting.tASortering(Boat.boats, upDownCount, circleCount,Form2.getLightWindWeight(), Form2.getMediumWindWeight(), Form2.getHardWindWeight());
                    Boat.SetgroupeIdForAll(0);
                    Boat.displayDataGridView(Boat.boats, sortDataGridView, Boat.standartDisplayVars);
                    break;
                case "dh cdl":
                    List<string> vars = Boat.getWindVarsTAU();
                    sortsettings.DHCDLWindSelector windSelector = new sortsettings.DHCDLWindSelector(vars);
                    windSelector.ShowDialog();
                    string var = windSelector.getSelectedVar();
                    Sorting.dHCDL(Boat.boats, var);
                    Boat.SetgroupeIdForAll(0);
                    Boat.displayDataGridView(Boat.boats, sortDataGridView, Boat.standartDisplayVars);
                    break;
                default:
                    MessageBox.Show("Vælg en sortering algoritme");
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
                MessageBox.Show("Export succes");
            } else {
                MessageBox.Show("Vælg en export sti.");
            }
        }

        private void groupeBoatsButton_Click(object sender, EventArgs e)
        {
            int i = groupeBoatsComboBox.SelectedIndex;
            if (i == -1){
                MessageBox.Show("Vælg en grupperings algoritme");
                return;
            }

            if (!Boat.boats[0].sorted)
            {
                MessageBox.Show("Sorter båden før gruppering");
                return;
            }

            switch(groupeBoatsComboBox.Items[i].ToString().ToLower())
            {
                case "score step gruppering":
                    ScoreStepGrupperingSettings form2 = new ScoreStepGrupperingSettings();
                    form2.ShowDialog();

                    if (form2.abortFlag)
                        return;

                    int numberOfgroups = Decimal.ToInt32(form2.numberOfGroups.Value);
                    Boat.SetgroupeIdForAll(0);
                    Grouping.scoreStepGruppering(Boat.boats, numberOfgroups);
                    Boat.displayDataGridView(Boat.boats, groupeDataGridView1, Boat.standartDisplayVars);
                    break;
                case "flyve grupper":
                    FlyveGrupperSettings flyveGrupperSettings = new FlyveGrupperSettings();
                    flyveGrupperSettings.ShowDialog();

                    if (flyveGrupperSettings.abortFlag)
                    {
                        return;
                    }
                    Boat.SetgroupeIdForAll(0);
                    //do some thing
                    int temp1 = Decimal.ToInt32(flyveGrupperSettings.numericUpDown1.Value);
                    int temp2 = Decimal.ToInt32(flyveGrupperSettings.numericUpDown2.Value);
                    int temp3 = Decimal.ToInt32(flyveGrupperSettings.numericUpDown3.Value);
                    int temp4 = Decimal.ToInt32(flyveGrupperSettings.numericUpDown4.Value);
                    switch (flyveGrupperSettings.state)
                    {
                        case 1:
                            Grouping.scoreStepGruppering(Boat.boats, temp1);
                            break;
                        case 2:
                            Grouping.flyvergruppering2(Boat.boats, temp1, temp2);
                            break;
                        case 3:
                            Grouping.flyvergruppering4(Boat.boats, temp1, temp2, temp3, temp4);
                            break;
                        default:
                            break;
                    }
                    Boat.displayDataGridView(Boat.boats, groupeDataGridView1, Boat.standartDisplayVars);
                    break;
                case "graf gruppering":
                    GrafDrawing graf = new GrafDrawing();
                    graf.ShowDialog();
                    if (!graf.abort)
                    {
                        
                        Boat.displayDataGridView(Boat.boats, groupeDataGridView1, Boat.standartDisplayVars);
                    }
                    break;
                default :
                    MessageBox.Show("Vælg en grupperings algoritme");
                    break;
            }

        }

        private void sortBoatChangeDataButton1_Click(object sender, EventArgs e)
        {
            VariabelToShow variabelToShow = new VariabelToShow();
            
            List<string> variable = Boat.getDataLocationIndex().Keys.ToList();
            variabelToShow.checkedListBox1.Items.Clear();
            for (int i = 0; i < variable.Count; i++)
            {
                variabelToShow.checkedListBox1.Items.Add(variable[i]);
                if (Boat.standartDisplayVars.Contains(variable[i]))
                {
                    variabelToShow.checkedListBox1.SetItemCheckState(i, CheckState.Checked);
                }
            }
            variabelToShow.checkedListBox1.Items.Add("sorterings score");
            variabelToShow.checkedListBox1.SetItemCheckState(variabelToShow.checkedListBox1.Items.Count - 1, CheckState.Checked);
            variabelToShow.checkedListBox1.Items.Add("loeb nr");
            variabelToShow.checkedListBox1.SetItemCheckState(variabelToShow.checkedListBox1.Items.Count - 1, CheckState.Checked);
            variabelToShow.ShowDialog();

            if (variabelToShow.abortFlag)
                return;

            Boat.standartDisplayVars.Clear();
            for(int i = 0;i < variabelToShow.checkedListBox1.CheckedItems.Count; i++)
            {
                Boat.standartDisplayVars.Add(variabelToShow.checkedListBox1.CheckedItems[i].ToString());
            }

            Boat.displayDataGridView(Boat.boats, sortDataGridView, Boat.standartDisplayVars);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = tabControl1.SelectedTab.Name;
            if(name.Equals("exportData"))
            {
                if (Boat.boats.Count > 0)
                {
                    exportDataCheckedListBox1.Items.Clear();
                    List<string> variable = Boat.getDataLocationIndex().Keys.ToList();
                    for (int i = 0; i < variable.Count; i++)
                    {
                        exportDataCheckedListBox1.Items.Add(variable[i]);
                        if (Boat.standartDisplayVars.Contains(variable[i]))
                        {
                            exportDataCheckedListBox1.SetItemCheckState(i, CheckState.Checked);
                        }
                    }
                    exportDataCheckedListBox1.Items.Add("sorterings score");
                    exportDataCheckedListBox1.SetItemCheckState(exportDataCheckedListBox1.Items.Count - 1, CheckState.Checked);
                    exportDataCheckedListBox1.Items.Add("loeb nr");
                    exportDataCheckedListBox1.SetItemCheckState(exportDataCheckedListBox1.Items.Count - 1, CheckState.Checked);
                }
            } else if (name.Equals("sortBoats")) {
                Boat.displayDataGridView(Boat.boats, sortDataGridView, Boat.standartDisplayVars);
            } else if (name.Equals("groupeBoat")){
                Boat.displayDataGridView(Boat.boats, groupeDataGridView1, Boat.standartDisplayVars);
            }
        }

        private void groupeBoatsChangeDatabutton1_Click(object sender, EventArgs e)
        {
            VariabelToShow variabelToShow = new VariabelToShow();

            List<string> variable = Boat.getDataLocationIndex().Keys.ToList();
            variabelToShow.checkedListBox1.Items.Clear();
            for (int i = 0; i < variable.Count; i++)
            {
                variabelToShow.checkedListBox1.Items.Add(variable[i]);
                if (Boat.standartDisplayVars.Contains(variable[i]))
                {
                    variabelToShow.checkedListBox1.SetItemCheckState(i, CheckState.Checked);
                }
            }
            variabelToShow.checkedListBox1.Items.Add("sorterings score");
            variabelToShow.checkedListBox1.SetItemCheckState(variabelToShow.checkedListBox1.Items.Count - 1, CheckState.Checked);
            variabelToShow.checkedListBox1.Items.Add("loeb nr");
            variabelToShow.checkedListBox1.SetItemCheckState(variabelToShow.checkedListBox1.Items.Count - 1, CheckState.Checked);
            variabelToShow.ShowDialog();

            if (variabelToShow.abortFlag)
                return;

            Boat.standartDisplayVars.Clear();
            for (int i = 0; i < variabelToShow.checkedListBox1.CheckedItems.Count; i++)
            {
                Boat.standartDisplayVars.Add(variabelToShow.checkedListBox1.CheckedItems[i].ToString());
            }

            Boat.displayDataGridView(Boat.boats, groupeDataGridView1, Boat.standartDisplayVars);
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        public string VersionLabel
        {
            get
            {
                if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
                {
                    Version ver = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion;
                    return string.Format("{0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision);
                }
                else
                {
                    var ver = Assembly.GetExecutingAssembly().GetName().Version;
                    return string.Format("{0}.{1}.{2}.{3}", ver.Major, ver.Minor, ver.Build, ver.Revision);
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(this.linkLabel1.Text);
        }
    }
}
