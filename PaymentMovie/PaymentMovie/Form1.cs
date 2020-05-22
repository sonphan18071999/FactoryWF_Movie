using PaymentMovie.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentMovie
{
    public partial class FPayment : Form
    {
        public static string TenPhimFMain = "";
        public static string MaRapMain = "";
        public static string GioChieuMain = "";
        public FPayment()
        {
            InitializeComponent();
        }
      
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TenPhimFMain = "On the beach night alone";
            GioChieuMain = "19:40";
            MaRapMain = "5";
            Form3 fn = new Form3();
            fn.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Form2 fn = new Form2("Cô hầu gái", "17:40", "4");
            //fn.Show();
            TenPhimFMain = "Cô hầu gái";
            GioChieuMain = "17:40";
            MaRapMain = "4";
            Form3 fn = new Form3();
            fn.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TenPhimFMain = "Đại thảm họa";
            GioChieuMain = "19:40";
            MaRapMain = "3";
            Form3 fn = new Form3();
            fn.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            TenPhimFMain = "Need more Flags";
            GioChieuMain = "20:30";
            MaRapMain = "1";
            Form3 fn = new Form3();
            fn.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            TenPhimFMain = "The Journey";
            GioChieuMain = "22:30";
            MaRapMain = "3";
            Form3 fn = new Form3();
            fn.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            TenPhimFMain = "Tấm cám";
            GioChieuMain = "18:30";
            MaRapMain = "6";
            Form3 fn = new Form3();
            fn.Show();
        }

        private void FPayment_Load(object sender, EventArgs e)
        {
            List film1 = new PhimTamLyFactory();
            List film2 = new PhimTinhCamFactory();
            List film3 = new PhimVienTuongFactory();
            film1.SetPhim();
            film2.SetPhim();
            film3.SetPhim();
            pictureBox1.Tag = film1.PhimInfo();
            pictureBox2.Tag = film2.PhimInfo();
            pictureBox3.Tag = film3.PhimInfo();
            pictureBox4.Tag = film3.PhimInfo();
            pictureBox5.Tag = film2.PhimInfo();
            pictureBox6.Tag = film1.PhimInfo();
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            List film1 = new PhimTamLyFactory();
            List film2 = new PhimTinhCamFactory();
            List film3 = new PhimVienTuongFactory();
            film1.SetPhim();
            film2.SetPhim();
            film3.SetPhim();
            if (cbCategories.SelectedIndex == 0)
            {
                hide(film1.PhimInfo());
            }
            if (cbCategories.SelectedIndex == 1)
            {
                hide(film3.PhimInfo());
            }
            if (cbCategories.SelectedIndex == 2)
            {
                hide(film2.PhimInfo());
            }
            if (cbCategories.SelectedIndex == 3)
            {
                hide("");
            }
        }
        private void hide(string x)
        {
            if(pictureBox1.Tag.ToString()==x)
            {
                pictureBox1.Enabled = true;
                label3.Enabled = true;
                pictureBox6.Enabled = true;
                label8.Enabled = true;

                pictureBox2.Enabled = false;
                label4.Enabled = false;
                pictureBox3.Enabled = false;
                label5.Enabled = false;
                pictureBox4.Enabled = false;
                label6.Enabled = false;
                pictureBox5.Enabled = false;
                label7.Enabled = false;
            }
            if (pictureBox2.Tag.ToString() == x)
            {
                pictureBox2.Enabled = true;
                label4.Enabled = true;
                pictureBox5.Enabled = true;
                label7.Enabled = true;

                pictureBox1.Enabled = false;
                label3.Enabled = false;
                pictureBox3.Enabled = false;
                label5.Enabled = false;
                pictureBox4.Enabled = false;
                label6.Enabled = false;
                pictureBox6.Enabled = false;
                label8.Enabled = false;
            }
            if (pictureBox3.Tag.ToString() == x)
            {
                pictureBox3.Enabled = true;
                label5.Enabled = true;
                pictureBox4.Enabled = true;
                label6.Enabled = true;

                pictureBox1.Enabled = false;
                label3.Enabled = false;
                pictureBox2.Enabled = false;
                label4.Enabled = false;
                pictureBox5.Enabled = false;
                label7.Enabled = false;
                pictureBox6.Enabled = false;
                label8.Enabled = false;
            }
            if(x=="Tất Cả")
            {
                pictureBox1.Enabled = true;
                label3.Enabled = true;
                pictureBox6.Enabled = true;
                label8.Enabled = true;
                pictureBox2.Enabled = true;
                label4.Enabled = true;
                pictureBox5.Enabled = true;
                label7.Enabled = true;
                pictureBox3.Enabled = true;
                label5.Enabled = true;
                pictureBox4.Enabled = true;
                label6.Enabled = true;
            }
        }
    }
}
