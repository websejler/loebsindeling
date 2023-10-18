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
    public partial class FlyveGrupperSettings : Form
    {
        public bool abortFlag;
        public int state;
        public FlyveGrupperSettings()
        {
            InitializeComponent();
            abortFlag = false;
            state = 0;
            setRaceLabel0Groupes();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(state == 0)
            {
                MessageBox.Show("Vælg en opdeling!");
                return;
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abortFlag = true;
            this.Close();
        }
        private void setRaceLabel0Groupes()
        {
            raceLabel1.Hide();
            numericUpDown1.Hide();
            nrOfBoats1.Hide();
            raceLabel2.Hide();
            numericUpDown2.Hide();
            nrOfBoats2.Hide();
            raceLabel3.Hide();
            numericUpDown3.Hide();
            nrOfBoats3.Hide();
            raceLabel4.Hide();
            numericUpDown4.Hide();
            nrOfBoats4.Hide();
        }
        private void setRaceLabel1Groupe()
        {
            raceLabel1.Show();
            raceLabel1.Text = "Antal løb";
            numericUpDown1.Show();
            nrOfBoats1.Show();
            nrOfBoats1.Text = "Antal Både: " + Boat.boats.Count.ToString();
            raceLabel2.Hide();
            numericUpDown2.Hide();
            nrOfBoats2.Hide();
            raceLabel3.Hide();
            numericUpDown3.Hide();
            nrOfBoats3.Hide();
            raceLabel4.Hide();
            numericUpDown4.Hide();
            nrOfBoats4.Hide();
        }

        private void setRaceLabel2Groupe()
        {
            raceLabel1.Show();
            raceLabel1.Text = "Antal løb for både uden flyve sejl";
            numericUpDown1.Show();
            nrOfBoats1.Show();
            nrOfBoats1.Text = "Antal Både: " + Boat.nrOfBoatsWithNoFlyingSails;
            raceLabel2.Show();
            raceLabel2.Text = "Antal løb for både med flyve sejl";
            numericUpDown2.Show();
            nrOfBoats2.Show();
            nrOfBoats2.Text = "Antal Både: " + Boat.nrOfBoatsWithSpinnakerOrGennaker;
            raceLabel3.Hide();
            numericUpDown3.Hide();
            nrOfBoats3.Hide();
            raceLabel4.Hide();
            numericUpDown4.Hide();
            nrOfBoats4.Hide();
        }

        private void setRaceLabel4Groupe()
        {
            raceLabel1.Show();
            raceLabel1.Text = "Antal løb Uden flyve sejl";
            numericUpDown1.Show();
            nrOfBoats1.Show();
            nrOfBoats1.Text = "Antal Både: " + Boat.nrOfBoatsWithNoFlyingSails;
            raceLabel2.Show();
            raceLabel2.Text = "Antal løb for både med asymmetriske spiler";
            numericUpDown2.Show();
            nrOfBoats2.Show();
            nrOfBoats2.Text = "Antal Både: " + Boat.nrOfBoatsWithGennaker;
            raceLabel3.Show();
            raceLabel3.Text = "Antal løb for både med spiler";
            numericUpDown3.Show();
            nrOfBoats3.Show();
            nrOfBoats3.Text = "Antal Både: " + Boat.nrOfBoatsWithSpinnaker;
            raceLabel4.Show();
            raceLabel4.Text = "Antal løb for både med spiler og asymmetriske spiler";
            numericUpDown4.Show();
            nrOfBoats4.Show();
            nrOfBoats4.Text = "Antal Både: " + Boat.nrOfBoatsWithSpinnakerAndGennaker;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            // If the radio button is checked, uncheck all other radio buttons in the group
            if (radioButton.Checked)
            {
                foreach (Control control in radioButton.Parent.Controls)
                {
                    if (control is RadioButton && control != radioButton)
                    {
                        ((RadioButton)control).Checked = false;
                    }
                }
            }
            setRaceLabel1Groupe();
            state = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            // If the radio button is checked, uncheck all other radio buttons in the group
            if (radioButton.Checked)
            {
                foreach (Control control in radioButton.Parent.Controls)
                {
                    if (control is RadioButton && control != radioButton)
                    {
                        ((RadioButton)control).Checked = false;
                    }
                }
            }
            setRaceLabel2Groupe();
            state = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

            // If the radio button is checked, uncheck all other radio buttons in the group
            if (radioButton.Checked)
            {
                foreach (Control control in radioButton.Parent.Controls)
                {
                    if (control is RadioButton && control != radioButton)
                    {
                        ((RadioButton)control).Checked = false;
                    }
                }
            }
            setRaceLabel4Groupe();
            state = 3;
        }
    }
}
