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

        
        List<AnimalWrapper> animals = new List<AnimalWrapper>();
        Timer MyTimer;

        public AquariumForm()
        {
            randonGenerator = new Random();
            currentAquarium = new Аquarium();
            
            InitializeComponent();

            button1Stop.Enabled = false;
            textBox1FishNumber.Text = currentAquarium.FishCollection.Count().ToString();
            textBox2MolluskNumber.Text = currentAquarium.MolluskCollection.Count().ToString();
            MyTimer = new Timer();
            MyTimer.Interval = (250); //(45 * 60 * 1000); // 45 mins
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            //foreach (Animal animal in currentAquarium.AllAnimalsCollection)
            //{
            //    var aw = new AnimalWrapper(animal);
            //    animals.Add(aw);
            //    //PictureBox pb = new PictureBox();
            //    //pb.Location = new Point(animal.XPossition, animal.YPossition);
            //    //pb.Image = animal.Img;
            //    this.Controls.Add(aw.picBox); 
            //}


        }

        //   int count = 0;
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            foreach (var curenentAnimal in animals)
            {
                //count--;
                //if (count <= 0)
                //{
                //    //change direction
                //    count = randonGenerator.Next(0, 100);

                //}

                button1Stop.Enabled = true;
                curenentAnimal.animal.Swim(Аquarium.xMinValue, Аquarium.xMaxValue, Аquarium.yMinValue, Аquarium.yMaxValue);
                // Invalidate();
                curenentAnimal.Location = new Point(curenentAnimal.animal.XPossition, curenentAnimal.animal.YPossition);
                curenentAnimal.labelName.Location = new Point(curenentAnimal.animal.XPossition+50, curenentAnimal.animal.YPossition-15);

                //animal.Location = new Point(randonGenerator.Next(xMinValue, xMaxValue),
                //randonGenerator.Next(yMinValue, yMaxValue));

            }
        }

        private void textBox1FishNumber_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1Swim_Click(object sender, EventArgs e)
        {

            
            MyTimer.Start(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btAddFish_Click(object sender, EventArgs e)
        {
            var fm = new FishForm();
            using (fm)
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    if (fm.shark != null)
                    {
                      //  MyTimer.Enabled = false;
                        currentAquarium.AllAnimalsCollection.Add(fm.shark);
                        currentAquarium.FishCollection.Add(fm.shark);
                        var aw = new AnimalWrapper(fm.shark);
                        animals.Add(aw);
                        //PictureBox pb = new PictureBox();
                        //pb.Location = new Point(animal.XPossition, animal.YPossition);
                        //pb.Image = animal.Img;
                        this.Controls.Add(aw.picBox);
                        //animal wrapper
                        textBox1FishNumber.Text = currentAquarium.FishCollection.Count().ToString();
                        MessageBox.Show("You successfully added a new shark", "Happy little shark", MessageBoxButtons.OK, MessageBoxIcon.Information);
                      //  MyTimer.Enabled = true;
                    }
                    if(fm.goldFish != null)
                    {
                        MyTimer.Enabled = false;
                        currentAquarium.AllAnimalsCollection.Add(fm.goldFish);
                        currentAquarium.FishCollection.Add(fm.goldFish);
                        var aw = new AnimalWrapper(fm.goldFish);
                        animals.Add(aw);
                        this.Controls.Add(aw.picBox);
                        textBox1FishNumber.Text = currentAquarium.FishCollection.Count().ToString();
                        MessageBox.Show("You successfully added a new goldfish", "Happy little goldfish", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MyTimer.Enabled = true;
                    }
                }

            }
        }

        private void button2AddMullusk_Click(object sender, EventArgs e)
        {
            var mf = new MulluskForm();
            using (mf)
            {
                if(mf.ShowDialog() == DialogResult.OK)
                {
                    if(mf.octopus != null)
                    {
                        MyTimer.Enabled = false;
                        currentAquarium.AllAnimalsCollection.Add(mf.octopus);
                        currentAquarium.MolluskCollection.Add(mf.octopus);
                        var aw = new AnimalWrapper(mf.octopus);
                      //  aw.picBox.Name = mf.octopus.AnimalName;
                        animals.Add(aw);
                        this.Controls.Add(aw.picBox);
                        this.Controls.Add(aw.labelName);
                        textBox2MolluskNumber.Text = currentAquarium.MolluskCollection.Count().ToString();
                        MessageBox.Show("You successfully added a new octopus", "Happy little octopus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MyTimer.Enabled = true;
                    }
                }
                if(mf.starFish != null)
                {
                    MyTimer.Enabled = false;
                    currentAquarium.AllAnimalsCollection.Add(mf.starFish);
                    currentAquarium.MolluskCollection.Add(mf.starFish);
                    var aw = new AnimalWrapper(mf.starFish);
                    animals.Add(aw);
                    this.Controls.Add(aw.picBox);
                    textBox2MolluskNumber.Text = currentAquarium.MolluskCollection.Count().ToString();
                    MessageBox.Show("You successfully added a new starfish", "Happy little starfish", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MyTimer.Enabled = true;
                }
                if(mf.snail != null)
                {

                    MyTimer.Enabled = false;
                    currentAquarium.AllAnimalsCollection.Add(mf.snail);
                    currentAquarium.MolluskCollection.Add(mf.snail);
                    var aw = new AnimalWrapper(mf.snail);
                    animals.Add(aw);
                    this.Controls.Add(aw.picBox);
                    textBox2MolluskNumber.Text = currentAquarium.MolluskCollection.Count().ToString();
                    MessageBox.Show("You successfully added a new snail", "Happy little snail", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MyTimer.Enabled = true;
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(animals.Count > 0)
            {
                //button1Stop.Enabled = true;
                MyTimer.Stop();
            }
        }
    }
}

