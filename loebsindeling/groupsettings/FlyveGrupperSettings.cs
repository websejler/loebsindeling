﻿using System;
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
        public FlyveGrupperSettings()
        {
            InitializeComponent();
            abortFlag = false;
            setRaceLabel0Groupes();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
            raceLabel2.Hide();
            numericUpDown2.Hide();
            raceLabel3.Hide();
            numericUpDown3.Hide();
            raceLabel4.Hide();
            numericUpDown4.Hide();
        }
        private void setRaceLabel1Groupe()
        {
            raceLabel1.Show();
            raceLabel1.Text = "Antal løb";
            numericUpDown1.Show();
            raceLabel2.Hide();
            numericUpDown2.Hide();
            raceLabel3.Hide();
            numericUpDown3.Hide();
            raceLabel4.Hide();
            numericUpDown4.Hide();
        }

        private void setRaceLabel2Groupe()
        {
            raceLabel1.Show();
            raceLabel1.Text = "Antal løb for både uden flyve sejl";
            numericUpDown1.Show();
            raceLabel2.Show();
            raceLabel2.Text = "Antal løb for både med flyve sejl";
            numericUpDown2.Show();
            raceLabel3.Hide();
            numericUpDown3.Hide();
            raceLabel4.Hide();
            numericUpDown4.Hide();
        }

        private void setRaceLabel4Groupe()
        {
            raceLabel1.Show();
            raceLabel1.Text = "Antal løb Uden flyve sejl";
            numericUpDown1.Show();
            raceLabel2.Show();
            raceLabel2.Text = "Antal løb for både med genakker";
            numericUpDown2.Show();
            raceLabel3.Show();
            raceLabel3.Text = "Antal løb for både med spiler";
            numericUpDown3.Show();
            raceLabel4.Show();
            raceLabel4.Text = "Antal løb for både med spiler og genammer";
            numericUpDown4.Show();
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
        }
    }
}
