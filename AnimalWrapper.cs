using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fish.Models;
using System.Windows.Forms;
using System.Drawing;

namespace FishGUI
{
    public class AnimalWrapper
    {
        public int step;
        public Animal animal;
        public PictureBox picBox;
        public Label labelName;

        public AnimalWrapper(Animal animal)
        {
            labelName = new Label();
            picBox = new PictureBox();
            
            labelName.Location = new Point(animal.XPossition+50, animal.YPossition -10);
            labelName.Height = 15;
            labelName.Width = 60;
            labelName.AutoSize = true;
            labelName.Text = animal.AnimalName;
            picBox.Height = 60;
            picBox.Width = 60;
            picBox.Location = new Point(animal.XPossition, animal.YPossition);
            picBox.Image = animal.Img;
            

          //  picBox.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            
          //  this.refresh();

            this.animal = animal;
           // this.step = step;
        }

        public Point Location
        {
            get
            {
                return picBox.Location;
            }
            set
            {
                picBox.Location = value;
            }
        }

        //public void Move()
        //{
        //    if(this.animal.GetType() == typeof(Fish.Models.Shark))
        //    {
        //        picBox.Location = new Point();
                    
        //    }
       // }

    }
}
