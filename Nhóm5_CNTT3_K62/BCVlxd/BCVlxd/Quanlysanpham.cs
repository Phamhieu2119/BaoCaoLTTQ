using connectdatabase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCVlxd
{
    public partial class Quanlysanpham : Form
    {
        ProcessDataBase pd = new ProcessDataBase();
        private Main mainForm;
        public Quanlysanpham()
        {
            InitializeComponent();
        }
        public Quanlysanpham(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            pd.capNhat("select * from Quanlysanphamkho order by Makho asc , Mavattu asc , Ngaynhap asc");
        }
        private void Quanlysanpham_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pd.docbang("select * from Quanlysanphamkho order by Makho asc , Mavattu asc , Ngaynhap asc");
            dataGridView1.Columns[0].HeaderText = "Mã hoá đơn";
            dataGridView1.Columns[1].HeaderText = "Mã kho";
            dataGridView1.Columns[2].HeaderText = "Mã vật tư";
            dataGridView1.Columns[3].HeaderText = "Ngày nhập";
            dataGridView1.Columns[4].HeaderText = "Sơ lượng nhập";
            dataGridView1.Columns[5].HeaderText = "Số lượng tồn kho";
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.showQlySanpham();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pd.capNhat("Delete Quanlysanphamkho where Ngaynhap = '" + dataGridView1.CurrentRow.Cells[3].Value.ToString() + "' and Mahoadon = N'"
                + dataGridView1.CurrentRow.Cells[0].Value.ToString()+"' and Makho = N'"+ dataGridView1.CurrentRow.Cells[1].Value.ToString()+
                "' and Mavattu = N'"+ dataGridView1.CurrentRow.Cells[2].Value.ToString()+"'");
            dataGridView1.DataSource = pd.docbang("select * from Quanlysanphamkho");
        }
    }
}
