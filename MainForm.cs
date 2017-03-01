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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void btAddFish_Click(object sender, EventArgs e)
        {
            using (var fm = new FishForm())
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    if (fm.shark != null)
                    {
                        //timer.enabled = false;
                        //animal wrapper
                        //timer.enabled = true;
                    }
                }

            }
        }

        private void button2AddMullusk_Click(object sender, EventArgs e)
        {
            MulluskForm mf = new MulluskForm();
            mf.ShowDialog();
        }

        private void button1CreateAquarium_Click(object sender, EventArgs e)
        {
            AquariumForm af = new AquariumForm();
            af.ShowDialog();
        }
    }
}
