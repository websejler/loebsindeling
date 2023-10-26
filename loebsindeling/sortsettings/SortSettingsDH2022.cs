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
        private bool bChecked;
        private const double STANDARD_LIGHT_WIND_WEIGHT    = 1.0;
        private const double STANDARD_MEDIUM_WIND_WEIGHT   = 1.0;
        private const double STANDARD_HARD_WIND_WEIGHT     = 1.0;
        private const double WEIGHT_INCREMENT_STEP_SIZE = 0.5;
        private const int WEIGHT_DECIMALS = 1;

        public SortSettingsDH2022()
        {
            InitializeComponent();
            abortFlag = true;
            bChecked = false;
            LightWindLable.Enabled = bChecked;
            LightWindWeightNumericUpDown.Enabled = bChecked;
            LightWindWeightNumericUpDown.Increment = Convert.ToDecimal(WEIGHT_INCREMENT_STEP_SIZE);
            LightWindWeightNumericUpDown.DecimalPlaces = WEIGHT_DECIMALS;
            MediumWindLable.Enabled = bChecked;
            MediumWindWeightNumericUpDown.Enabled = bChecked;
            MediumWindWeightNumericUpDown.Increment = Convert.ToDecimal(WEIGHT_INCREMENT_STEP_SIZE);
            MediumWindWeightNumericUpDown.DecimalPlaces = WEIGHT_DECIMALS;
            HardWindLable.Enabled = bChecked;
            HardWindWeightNumericUpDown.Enabled = bChecked;
            HardWindWeightNumericUpDown.Increment = Convert.ToDecimal(WEIGHT_INCREMENT_STEP_SIZE);
            HardWindWeightNumericUpDown.DecimalPlaces = WEIGHT_DECIMALS;
        }

        private void button2_Click(object sender, EventArgs e)//annuller button
        {
            
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)//gem button
        {
            if(numberOfCircleRaces.Value == 0 && numberOfUpDownRaces.Value == 0)
            {
                MessageBox.Show("Der skal være minimum en sejlads");
                return;
            }
            if (isWeightAllZero())
            {
                MessageBox.Show("Der skal være en vægt som er størrer end 0");
                return;
            }
            abortFlag = false;
            this.Close();
        }

        private void WindWeightCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            bChecked = WindWeightCheckBox.Checked;
            LightWindLable.Enabled = bChecked;
            LightWindWeightNumericUpDown.Enabled = bChecked;
            MediumWindLable.Enabled = bChecked;
            MediumWindWeightNumericUpDown.Enabled = bChecked;
            HardWindLable.Enabled = bChecked;
            HardWindWeightNumericUpDown.Enabled = bChecked;
        }

        public double getLightWindWeight()
        {
            if(bChecked)
            {
                return Decimal.ToDouble(LightWindWeightNumericUpDown.Value);
            } else
            {
                return STANDARD_LIGHT_WIND_WEIGHT;
            }
        }

        public double getMediumWindWeight()
        {
            if (bChecked)
            {
                return Decimal.ToDouble(MediumWindWeightNumericUpDown.Value);
            }
            else
            {
                return STANDARD_MEDIUM_WIND_WEIGHT;
            }
        }

        public double getHardWindWeight()
        {
            if (bChecked)
            {
                return Decimal.ToDouble(HardWindWeightNumericUpDown.Value);
            }
            else
            {
                return STANDARD_HARD_WIND_WEIGHT;
            }
        }

        private bool isWeightAllZero()
        {
            if(getLightWindWeight() == 0 && getMediumWindWeight() == 0 && getHardWindWeight() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
