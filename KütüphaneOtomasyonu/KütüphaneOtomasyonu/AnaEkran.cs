﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneOtomasyonu
{
    public partial class AnaEkran: Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            KayıtEkranı kytekr = new KayıtEkranı();
            kytekr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ÇalışanEkranı grşbtn = new ÇalışanEkranı();
            grşbtn.Show();
          
        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
