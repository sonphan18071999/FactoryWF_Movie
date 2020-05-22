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

        }
                
        
    }
}
