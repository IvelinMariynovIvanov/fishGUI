using Fish.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FishGUI
{
    public partial class MulluskForm : Form
    {

        private Аquarium aquarium;
        private Random locationGenerator;

        public Octopus octopus = null;
        public Snail snail = null;
        public Starfish starFish = null;

        List<AnimalWrapper> animals = new List<AnimalWrapper>();

        public MulluskForm()
        {
            InitializeComponent();
            button1AddMullusk.Enabled = false;
            locationGenerator = new Random();
            aquarium = new Аquarium();
        }

        private void button1AddMullusk_Click(object sender, EventArgs e)
        {
            string molluskType;
            

            string name = textBox1Name.Text;
            int sizeInCm = int.Parse(textBox2Size.Text);
            int minTemp = int.Parse(textBox3MinTemp.Text);
            int maxTemp = int.Parse(textBox4MaxTemp.Text);
            string color = textBox5Color.Text;

          

            if (radioButton3Starfish.Checked)
            {
                molluskType = radioButton3Starfish.Text;

                starFish = new Starfish(); 
                aquarium.AllAnimalsCollection.Add(starFish);
                aquarium.MolluskCollection.Add(starFish);
                starFish.Img = FishGUI.Properties.Resources.starfish_icon;
                starFish.XPossition = locationGenerator.Next(Аquarium.xMinValue + 100, Аquarium.xMaxValue);
                starFish.YPossition = locationGenerator.Next(Аquarium.yMaxValue - 20, Аquarium.yMaxValue);
            }
            if (radioButton1Octopus.Checked)
            {
                molluskType = radioButton1Octopus.Text;

                octopus = new Octopus();
                octopus.AnimalName = name;
                aquarium.AllAnimalsCollection.Add(octopus);
                aquarium.MolluskCollection.Add(octopus);
                octopus.Img = FishGUI.Properties.Resources.octopus_icon;
                octopus.XPossition = locationGenerator.Next(Аquarium.xMinValue + 300, Аquarium.xMaxValue);
                octopus.YPossition = locationGenerator.Next(Аquarium.yMaxValue - 200, Аquarium.yMaxValue);


                
            }
            if(radioButton2Snail.Checked)
            {
                molluskType = radioButton2Snail.Text;

                snail = new Snail();
                aquarium.AllAnimalsCollection.Add(snail);
                aquarium.MolluskCollection.Add(snail);
                snail.Img = FishGUI.Properties.Resources.Snail_icon;
                snail.XPossition = locationGenerator.Next(Аquarium.xMinValue + 500, Аquarium.xMaxValue);
                snail.YPossition = locationGenerator.Next(Аquarium.yMaxValue - 400, Аquarium.yMaxValue);

            }
            

            this.DialogResult = DialogResult.OK;


        }

        private void textBox1Name_TextChanged(object sender, EventArgs e)
        {
            UnlockBt1AddMullusk();
        }

        private void textBox2Size_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if(!int.TryParse(textBox2Size.Text, out temp))
            {
                errorProvider1.SetError(textBox2Size, "Enter a valid number");
            }
            else
            {
                errorProvider1.Clear();
            }

            UnlockBt1AddMullusk();
        }

        private void textBox3MinTemp_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if(!int.TryParse(textBox3MinTemp.Text, out temp))
            {
                errorProvider1.SetError(textBox3MinTemp, "Enter a valid number for min temperature");
            }
            else
            {
                errorProvider1.Clear();
            }

            UnlockBt1AddMullusk();
        }

        private void textBox4MaxTemp_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if(!int.TryParse(textBox4MaxTemp.Text, out temp))
            {
                errorProvider1.SetError(textBox4MaxTemp, "Enter a valid number for max temperature");
            }
            else
            {
                errorProvider1.Clear();
            }

            UnlockBt1AddMullusk();
        }

        private void textBox5Color_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if (int.TryParse(textBox5Color.Text, out temp))
            {
                errorProvider1.SetError(textBox5Color, "Enter a valid color");
            }
            else
            {
                errorProvider1.Clear();
            }

            UnlockBt1AddMullusk();
        }



        private void UnlockBt1AddMullusk()
        {
            bool isInfoNotNull;
            isInfoNotNull =
               ( textBox1Name.Text.Trim().Length > 0
                && textBox2Size.Text.Trim().Length > 0
                && textBox3MinTemp.Text.Trim().Length > 0
                && textBox4MaxTemp.Text.Trim().Length > 0
                && textBox5Color.Text.Trim().Length > 0);

            bool isInfoValid;
        isInfoValid =
           ( textBox1Name.Text.Trim().Length > 0
            && errorProvider1.GetError(textBox2Size) == string.Empty
            && errorProvider1.GetError(textBox3MinTemp) == string.Empty
            && errorProvider1.GetError(textBox4MaxTemp) == string.Empty
            && textBox5Color.Text.Trim().Length > 2)
            && errorProvider1.GetError(textBox5Color) == string.Empty;

            if(isInfoValid && isInfoNotNull)
            {
                button1AddMullusk.Enabled = true;
            }
            else
            {
                button1AddMullusk.Enabled = false;
            }
        }
    }
}
