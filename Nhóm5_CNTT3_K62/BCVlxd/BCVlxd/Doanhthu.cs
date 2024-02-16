using connectdatabase;
using Guna.Charts.WinForms;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace BCVlxd
{
    public partial class Doanhthu : UserControl
    {
        ProcessDataBase pd = new ProcessDataBase();
        private Main mainForm;
        private bool check1 = false;
        private bool check2 = false;
        private bool check3 = false;
        public Doanhthu()
        {
            InitializeComponent();
        }
        public Doanhthu(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            pd.capNhat("update TienNhapKhoHang set TongTienNhap = a.Tien from TienNhapKhoHang as t join (select distinct month(n.Ngaynhap) as Thang,  sum(n.TongTien) as Tien from Nhapkho as n group by month(n.Ngaynhap)) as a on t.Thang = a.Thang");
            pd.capNhat("update TienXuatKhoHang set TongTienXuat = a.Tien from TienXuatKhoHang as t join (select distinct month(n.Ngayxuat) as Thang,  sum(n.TongTien) as Tien from Xuatkho as n group by month(n.Ngayxuat)) as a on t.Thang = a.Thang");

        }
        private void bd1()
        {
            pd.ketnoi();
            // Tạo đối tượng SqlCommand
            SqlCommand cmd = new SqlCommand("SELECT Thang, TongTienNhap FROM TienNhapKhoHang", pd.Con);

            // Thực thi lệnh SQL
            cmd.ExecuteNonQuery();

            // Lấy dữ liệu từ bảng
            SqlDataReader reader = cmd.ExecuteReader();

            // Duyệt qua các hàng dữ liệu
            while (reader.Read())
            {
                // Lấy dữ liệu cho biểu đồ
                // Tháng
                int thang = Convert.ToInt32(reader["Thang"]);
                // Tổng tiền
                int tongTien = Convert.ToInt32(reader["TongTienNhap"]);

                // Truyền dữ liệu vào biểu đồ
                // Trục x
                chart1.Series["Series1"].Points.AddXY(thang, tongTien);
            }

            // Đóng đối tượng SqlDataReader
            reader.Close();
        }
        private void bd2()
        {
            pd.ketnoi();
            // Tạo đối tượng SqlCommand
            SqlCommand cmd = new SqlCommand("SELECT Thang, TongTienXuat FROM TienXuatKhoHang", pd.Con);

            // Thực thi lệnh SQL
            cmd.ExecuteNonQuery();

            // Lấy dữ liệu từ bảng
            SqlDataReader reader = cmd.ExecuteReader();

            // Duyệt qua các hàng dữ liệu
            while (reader.Read())
            {
                // Lấy dữ liệu cho biểu đồ
                // Tháng
                int thang = Convert.ToInt32(reader["Thang"]);
                // Tổng tiền
                int tongTien = Convert.ToInt32(reader["TongTienXuat"]);

                // Truyền dữ liệu vào biểu đồ
                // Trục x
                chart2.Series["Series2"].Points.AddXY(thang, tongTien);
            }

            // Đóng đối tượng SqlDataReader
            reader.Close();
        }
        private void Doanhthu_Load(object sender, EventArgs e)
        {
            bd1();
            bd2();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            check1 = true;
            // Khai báo biến tổng tiền
            int tongTien = 0;
            pd.ketnoi();
            // Tạo đối tượng SqlCommand
            SqlCommand cmd = new SqlCommand("SELECT SUM(TongTienNhap) AS TongTien FROM TienNhapKhoHang", pd.Con);

            // Thực thi lệnh SQL
            cmd.ExecuteNonQuery();

            // Lấy dữ liệu từ bảng
            SqlDataReader reader = cmd.ExecuteReader();

            // Duyệt qua các hàng dữ liệu
            if (reader.Read())
            {
                // Lấy tổng tiền
                tongTien = Convert.ToInt32(reader["TongTien"]);
            }

            // Đóng đối tượng SqlDataReader
            reader.Close();

            // Gán tổng tiền cho gunalabel
            lbNhapkho.Text = tongTien.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            check2 = true;
            // Khai báo biến tổng tiền
            int tongTien = 0;
            pd.ketnoi();
            // Tạo đối tượng SqlCommand
            SqlCommand cmd = new SqlCommand("SELECT SUM(TongTienXuat) AS TongTien FROM TienXuatKhoHang", pd.Con);

            // Thực thi lệnh SQL
            cmd.ExecuteNonQuery();

            // Lấy dữ liệu từ bảng
            SqlDataReader reader = cmd.ExecuteReader();

            // Duyệt qua các hàng dữ liệu
            if (reader.Read())
            {
                // Lấy tổng tiền
                tongTien = Convert.ToInt32(reader["TongTien"]);
            }

            // Đóng đối tượng SqlDataReader
            reader.Close();

            // Gán tổng tiền cho gunalabel
            lbXuatkho.Text = tongTien.ToString();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            check3 = true;
            // Khai báo biến tổng tiền
            int tongTien = 0;
            pd.ketnoi();
            // Tạo đối tượng SqlCommand
            SqlCommand cmd = new SqlCommand("SELECT SUM(a.Total) AS TongTien FROM (SELECT SUM(c.soluong * b.Tb) AS Total FROM Chitietkhohang AS c JOIN (SELECT q.Makho, q.Mavattu, AVG(q.Gianhap) AS Tb    FROM Quanlysanphamkho AS q  GROUP BY q.Makho, q.Mavattu) AS b ON c.Makho = b.Makho AND c.Mavattu = b.Mavattu) as a", pd.Con);

            // Thực thi lệnh SQL
            cmd.ExecuteNonQuery();

            // Lấy dữ liệu từ bảng
            SqlDataReader reader = cmd.ExecuteReader();

            // Duyệt qua các hàng dữ liệu
            if (reader.Read())
            {
                // Lấy tổng tiền
                tongTien = Convert.ToInt32(reader["TongTien"]);
            }

            // Đóng đối tượng SqlDataReader
            reader.Close();

            // Gán tổng tiền cho gunalabel
            lbSpkho.Text = tongTien.ToString();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if(check1 == false)
            {
                MessageBox.Show("Chưa tính tổng tiền nhập!");

            }else if(check2 == false)
            {
                MessageBox.Show("Chưa tính tổng tiền xuất!");
            }else if(check3 == false)
            {
                MessageBox.Show("Chưa tính tiền hàng trong kho !");
            }
            else
            {
                int tiennhap = int.Parse(lbNhapkho.Text);
                int tienxuat = int.Parse(lbXuatkho.Text);
                int spkho = int.Parse(lbSpkho.Text);
                int doanhthu = tienxuat - (tiennhap - spkho);
                lbDoanhthu.Text = Convert.ToString(doanhthu);
            }
            
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            mainForm.showquanlysanpham();
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
