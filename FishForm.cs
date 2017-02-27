using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fish.Models;

namespace FishGUI
{
    public partial class FishForm : Form
    {
   

        public FishForm()
        {
            InitializeComponent();
            button1AddFish.Enabled = false;
        }

        private void button1AddFish_Click(object sender, EventArgs e)
        {
         

        }

        private void textBox3Size_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void textBox2Name_TextChanged(object sender, EventArgs e)
        {
            UnlockAddFishBt();
        }

        private void textBox3Size_TextChanged(object sender, EventArgs e)
        {
            int temp;

            if(!int.TryParse(textBox3Size.Text, out temp))
            {
                errorProvider1.SetError(textBox3Size, "Enter a valid value");
               
            }
            else
            {
                errorProvider1.Clear();   
            }

            UnlockAddFishBt();
        }

        private void textBox4MinTemperature_TextChanged(object sender, EventArgs e)
        {
            int temp;

            if(!int.TryParse(textBox4MinTemperature.Text, out temp))
            {
                errorProvider1.SetError(textBox4MinTemperature, "Enter a valid min temperature ");
            }
            else
            {
                errorProvider1.Clear();
            }

            UnlockAddFishBt();
        }

        private void textBox5MaxTemperature_TextChanged(object sender, EventArgs e)
        {
            int temp;

            if(!int.TryParse(textBox5MaxTemperature.Text, out temp))
            {
                errorProvider1.SetError(textBox5MaxTemperature, "Enter a valid max temperature");
            }
            else
            {
                errorProvider1.Clear();
            }

            UnlockAddFishBt();
        }

        private void textBox6NeedLitters_TextChanged(object sender, EventArgs e)
        {
            int temp;

            if(!int.TryParse(textBox6NeedLitters.Text, out temp))
            {
                errorProvider1.SetError(textBox6NeedLitters, "Enter a valid litters");
            }
            else
            {
                errorProvider1.Clear();
            }

            UnlockAddFishBt();
        }

        private  void UnlockAddFishBt()
        {
            bool isValidInfo = textBox2Name.Text.Trim().Length > 0
                && errorProvider1.GetError(textBox3Size) == string.Empty
                && errorProvider1.GetError(textBox4MinTemperature) == string.Empty
                && errorProvider1.GetError(textBox5MaxTemperature) == string.Empty
                && errorProvider1.GetError(textBox6NeedLitters) == string.Empty;

            bool isInfoNotNull = textBox2Name.Text.Trim().Length > 0
                && textBox3Size.Text.Trim().Length > 0
                && textBox4MinTemperature.Text.Trim().Length > 0
                && textBox5MaxTemperature.Text.Trim().Length > 0
                && textBox6NeedLitters.Text.Trim().Length > 0;
            if (isValidInfo && isInfoNotNull)
            {
                button1AddFish.Enabled = true;
            }
            else
            {
                button1AddFish.Enabled = false;
            }
        }
    }
}
