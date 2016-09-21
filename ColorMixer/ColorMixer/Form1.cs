using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorMixer
{
    public partial class colorMixer : Form
    {
        public colorMixer()
        {
            InitializeComponent();
        }

        private void mixButton_Click(object sender, EventArgs e)
        {
            //Red raido button controls
            if (red1RadioButton.Checked && red2RadioButton.Checked)
            {
                this.BackColor = Color.Red;
            }
            else if (red1RadioButton.Checked && blue2RadioButton.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (red1RadioButton.Checked && yellow2RadioButton.Checked)
            {
                this.BackColor = Color.Orange;
            }
            //Blue radio button controls
            else if (blue1RadioButton.Checked && blue2RadioButton.Checked)
            {
                this.BackColor = Color.Blue;
            }
            else if (blue1RadioButton.Checked && red2RadioButton.Checked)
            {
                this.BackColor = Color.Purple;
            }
            else if (blue1RadioButton.Checked && yellow2RadioButton.Checked)
            {
                this.BackColor = Color.Green;
            }
            //Yellow radio button controls
            else if (yellow1RadioButton.Checked && yellow2RadioButton.Checked)
            {
                this.BackColor = Color.Yellow;
            }
            else if (yellow1RadioButton.Checked && red2RadioButton.Checked)
            {
                this.BackColor = Color.Orange;
            }
            else if (yellow1RadioButton.Checked && blue2RadioButton.Checked)
            {
                this.BackColor = Color.Green;
            }
            //Catch 
            else
                this.BackColor = SystemColors.Control;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }
    }
}
