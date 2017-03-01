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
        public Shark shark = null;
        public GoldenFish goldFish = null;
        private Аquarium aquarium;
        private Random locationGenerator;

        List<AnimalWrapper> animals = new List<AnimalWrapper>();

        public FishForm()
        {
            InitializeComponent();
            button1AddFish.Enabled = false;
            aquarium = new Аquarium();
            locationGenerator = new Random();
        }

        private void button1AddFish_Click(object sender, EventArgs e)
        {
            string fishType;
            string fishGender;

            if (radioButton1Male.Checked)
            {

            }

            if (radioButton3Shark.Checked)
            {
                fishType = radioButton3Shark.Text;
            }
            if(radioButton4GoldFish.Checked)
            {
                fishType = radioButton4GoldFish.Text;
            }

            if(radioButton1Male.Checked)
            {
                fishGender = radioButton1Male.Text;
            }
            if(radioButton2Female.Checked)
            {
                fishGender = radioButton2Female.Text;
            }

            string fishName = textBox2Name.Text;

            int sizeInCm = int.Parse(textBox3Size.Text);
            int minTemp = int.Parse(textBox4MinTemperature.Text);
            int maxTemp = int.Parse(textBox5MaxTemperature.Text);
            int needdedLitters = int.Parse(textBox6NeedLitters.Text);

            if (radioButton3Shark.Checked)
            {
                shark = new Shark();
                aquarium.AllAnimalsCollection.Add(shark);
                aquarium.FishCollection.Add(shark);
                shark.Img = FishGUI.Properties.Resources.shark_icon;
                shark.XPossition = locationGenerator.Next(Аquarium.xMinValue, Аquarium.xMaxValue);
                shark.YPossition = locationGenerator.Next(Аquarium.yMinValue, Аquarium.yMaxValue);
                
            }

            if (radioButton4GoldFish.Checked)
            {
                goldFish = new GoldenFish();
                aquarium.AllAnimalsCollection.Add(goldFish);
                aquarium.FishCollection.Add(goldFish);
                goldFish.Img = FishGUI.Properties.Resources.goldenfish_icon;
                goldFish.XPossition = locationGenerator.Next(Аquarium.xMinValue, Аquarium.xMaxValue);
                goldFish.YPossition = locationGenerator.Next(Аquarium.yMinValue, Аquarium.yMaxValue);


                //PictureBox pb = new PictureBox();
                //pb.Location = new Point(goldFish.XPossition, goldFish.YPossition);
                //pb.Image = goldFish.Img;
                //this.Controls.Add(goldFish.picBox);
            }

            this.DialogResult = DialogResult.OK;
        }

      

        private void UnlockAddFishBt()
        {
            bool isValidInfo = 
                (textBox2Name.Text.Trim().Length > 0
                && errorProvider1.GetError(textBox3Size) == string.Empty
                && errorProvider1.GetError(textBox4MinTemperature) == string.Empty
                && errorProvider1.GetError(textBox5MaxTemperature) == string.Empty
                && errorProvider1.GetError(textBox6NeedLitters) == string.Empty);

            bool isInfoNotNull = 
                (textBox2Name.Text.Trim().Length > 0
                && textBox3Size.Text.Trim().Length > 0
                && textBox4MinTemperature.Text.Trim().Length > 0
                && textBox5MaxTemperature.Text.Trim().Length > 0
                && textBox6NeedLitters.Text.Trim().Length > 0);

            if (isValidInfo && isInfoNotNull)
            {
                button1AddFish.Enabled = true;
            }
            else
            {
                button1AddFish.Enabled = false;
            }
        }

        private void textBox2Name_TextChanged_1(object sender, EventArgs e)
        {
            UnlockAddFishBt();
        }

        private void textBox3Size_TextChanged_1(object sender, EventArgs e)
        {
            int temp;

            if (!int.TryParse(textBox3Size.Text, out temp))
            {
                errorProvider1.SetError(textBox3Size, "Enter a valid value");

            }
            else
            {
                errorProvider1.SetError(textBox3Size, string.Empty);
            }

            UnlockAddFishBt();
        }

        private void textBox4MinTemperature_TextChanged_1(object sender, EventArgs e)
        {
            int temp;

            if (!int.TryParse(textBox4MinTemperature.Text, out temp))
            {
                errorProvider1.SetError(textBox4MinTemperature, "Enter a valid min temperature ");
            }
            else
            {
                errorProvider1.SetError(textBox4MinTemperature, string.Empty);
            }

            UnlockAddFishBt();
        }

        private void textBox5MaxTemperature_TextChanged_1(object sender, EventArgs e)
        {

            int temp;

            if (!int.TryParse(textBox5MaxTemperature.Text, out temp))
            {
                errorProvider1.SetError(textBox5MaxTemperature, "Enter a valid max temperature");
            }
            else
            {
                errorProvider1.SetError(textBox5MaxTemperature, string.Empty);
            }

            UnlockAddFishBt();
        }

        private void textBox6NeedLitters_TextChanged_1(object sender, EventArgs e)
        {
            int temp;

            if (!int.TryParse(textBox6NeedLitters.Text, out temp))
            {
                errorProvider1.SetError(textBox6NeedLitters, "Enter a valid litters");
            }
            else
            {
                errorProvider1.SetError(textBox6NeedLitters, string.Empty);
            }

            UnlockAddFishBt();
        }
    }
}
