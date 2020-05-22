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
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtTenPhim.Text = FPayment.TenPhimFMain;
            txtHour.Text = FPayment.GioChieuMain;
            txtRoom.Text = FPayment.MaRapMain;
            string[] seat_name = { "", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L" };
            for (int i = 1; i < 10; i++)
                for (int j = 1; j < 10; j++)
                {
                    flowLayoutPanel1.Controls.Add(btn(j + seat_name[i].ToString()));
                }
        }
        Button btn(string i)
        {
            Button seat = new Button();
            seat.Name = i.ToString();
            seat.Width = 50;
            seat.Height = 40;
            seat.Text = i.ToString();
            seat.ForeColor = Color.White;
            seat.BackColor = Color.Gray;
            seat.Click += seat_click;
            return seat;
        }

        void seat_click(Object sender, EventArgs e)
        {
            Button seat = (Button)sender;
            //MessageBox.Show(seat.Name.ToString());
            //Thêm vào ghế ngồi
            
            if (lvChoNgoi.Items.Contains(seat.Name))
            {
                lvChoNgoi.Items.Remove(seat.Name);
            }
            else
            {
                lvChoNgoi.Items.Add(seat.Name);
            }
            //Thêm màu button
            if (seat.BackColor == Color.Red)
            {
                seat.BackColor = Color.Gray;
            }
            else
            {
                seat.BackColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserFactory vephim = null;
            string tenphim = txtTenPhim.Text.ToString();
            string hour = txtHour.Text.ToString();
            string sophong = txtRoom.Text.ToString();
            string chongoi = null;
            foreach (object item in lvChoNgoi.Items)
            {
                chongoi += item.ToString().Replace("ListViewItem:","") + " ";
            }

            if (rdSinhVien.Checked == true)
            {
                vephim = new SinhVienFactory(tenphim, hour, chongoi, sophong);
            }
            else if (rdNormal.Checked == true)
            {

            }
            else if (rdGolden.Checked == true)
            {

            }
            else if (rdDiamond.Checked == true)
            {

            }
            else if (rdPlatinum.Checked == true)
            {
                vephim = new PlatinumFactory(tenphim, hour, chongoi, sophong);
            }
            else
            {

            }

            MainUser mn = vephim.GetUserType();
            MessageBox.Show("Loại vé: " + mn.UserType + "\n\n" +
                            "Tên phim: " + mn.MovieNam + "\n\n" +
                            "Khuyến mãi: " + mn.Promotion + "\n\n" +
                            "Giờ chiếu: " + mn.Hour + "\n\n" +
                            "Phòng: " + mn.RoomNumber + "\n\n" +
                            "Chỗ ngồi: " + mn.SeatNumber,"Xuất vé");
        }
    }
}
