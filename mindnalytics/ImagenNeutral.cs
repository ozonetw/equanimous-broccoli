﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace mindnalytics
{
    public partial class ImagenNeutral : Form
    {

        string iNeutral;
        public ImagenNeutral(String iNeutral)
        {
            this.iNeutral = iNeutral;
            InitializeComponent();
        }

        private void ImagenNeutral_Load(object sender, EventArgs e)
        {

            pictureBox1.Image = Image.FromFile(iNeutral);
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

       

    }
}
