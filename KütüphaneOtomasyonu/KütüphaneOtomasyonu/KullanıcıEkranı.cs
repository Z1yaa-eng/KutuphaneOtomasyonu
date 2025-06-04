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
    public partial class KullanıcıEkranı: Form
    {
        public KullanıcıEkranı()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadUserControl(UserControl dort)
        {
            panel3.Controls.Clear();
            dort.Dock = DockStyle.Fill;
            panel3.Controls.Add(dort);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl7());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl8());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControl9());
        }
    }
}
