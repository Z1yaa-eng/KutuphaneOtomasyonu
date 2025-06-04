using System;
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
    public partial class ÇalışanEkranı: Form
    {
        public ÇalışanEkranı()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl1());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl2());
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl4());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl3());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl5());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl6());
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadUserControl(UserControl uc)
        {
            panelMain.Controls.Clear();          // Öncekini temizle
            uc.Dock = DockStyle.Fill;            // Paneli kaplasın
            panelMain.Controls.Add(uc);          // Ekleyip göster
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl6());
        }
    }
}
