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
       

        public AnimalWrapper(Animal animal)
        {
            picBox = new PictureBox();
            picBox.Location = new Point(animal.XPossition, animal.YPossition);
            picBox.Image = animal.Img;

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
