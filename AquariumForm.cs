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
    public partial class AquariumForm : Form
    {
        private Аquarium currentAquarium;
        private Random randonGenerator;

        private int xMinValue = 250;
        private int xMaxValue = 925;
        private int yMinValue = 10;
        private int yMaxValue = 625;
        List<AnimalWrapper> animals = new List<AnimalWrapper>();
        
        public AquariumForm()
        {
            randonGenerator = new Random();
            currentAquarium = new Аquarium();

            Timer MyTimer = new Timer();
            MyTimer.Interval = (650); //(45 * 60 * 1000); // 45 mins
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();

            Shark sh1 = new Shark();
            sh1.Img = FishGUI.Properties.Resources.shark_icon;
            sh1.XPossition = randonGenerator.Next(xMinValue , this.Width);
            sh1.YPossition = randonGenerator.Next(yMinValue , this.Height);
            currentAquarium.FishCollection.Add(sh1);
            currentAquarium.AllAnimalsCollection.Add(sh1);

            Shark sh2 = new Shark();
            sh2.Img = FishGUI.Properties.Resources.shark_icon;
            sh2.XPossition = randonGenerator.Next(xMinValue , this.Width );
            sh2.YPossition = randonGenerator.Next(yMinValue , this.Height);
            currentAquarium.FishCollection.Add(sh2);
            currentAquarium.AllAnimalsCollection.Add(sh2);

            Starfish sf1 = new Starfish();
            sf1.Img = FishGUI.Properties.Resources.starfish_icon;
            sf1.XPossition = randonGenerator.Next(xMinValue , this.Width );
            sf1.YPossition = yMaxValue;
            currentAquarium.MolluskCollection.Add(sf1);
            currentAquarium.AllAnimalsCollection.Add(sf1);

            InitializeComponent();

            textBox1FishNumber.Text = currentAquarium.FishCollection.Count().ToString();
            textBox2MolluskNumber.Text = currentAquarium.MolluskCollection.Count().ToString();

            foreach (Animal animal in currentAquarium.AllAnimalsCollection)
            {
                var aw = new AnimalWrapper(animal);
                animals.Add(aw);
                //PictureBox pb = new PictureBox();
                //pb.Location = new Point(animal.XPossition, animal.YPossition);
                //pb.Image = animal.Img;
                this.Controls.Add(aw.picBox); 
            }
            

        }

        private void MyTimer_Tick(object sender, EventArgs e)
        {
            foreach (var currentAnimal in animals)
                {
                
                currentAnimal.animal.Swim(xMinValue, xMaxValue, yMinValue, yMaxValue);
                currentAnimal.Location = new Point(currentAnimal.animal.XPossition, currentAnimal.animal.YPossition);

                //curenentAnimal.Location = new Point(randonGenerator.Next(xMinValue, xMaxValue),
                //    randonGenerator.Next(yMinValue, yMaxValue));
             
                
            }
        }

        private void textBox1FishNumber_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

