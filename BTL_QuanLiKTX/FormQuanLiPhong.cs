using ConnectDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLiKTX
{
    public partial class FormQuanLiPhong : Form
    {
        ProcessDataBase pd = new ProcessDataBase();
        string SqlConnection;
        public FormQuanLiPhong()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormThemSV Obj = new FormThemSV();
            Obj.Show();
        }

        private void btnQuanLiSV_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanLiSinhVien Obj=new FormQuanLiSinhVien();
            Obj.ShowDialog();
            this.Close();
        }

        private void btnHomeClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuanLiHoaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanLiHoaDon Obj = new FormQuanLiHoaDon();
            Obj.ShowDialog();
            this.Close();
        }

        private void btnQuanLiThietBi_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanLiThietBi Obj = new FormQuanLiThietBi();
            Obj.ShowDialog();
            this.Close();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormThongKe Obj = new FormThongKe();
            Obj.ShowDialog();
            this.Close();
        }

        private void FormQuanLiPhong_Load(object sender, EventArgs e)
        {
            dataGridViewDanhSachPhong.DataSource = pd.DocBang("Select * from Phong");
        }

        
    }
}
