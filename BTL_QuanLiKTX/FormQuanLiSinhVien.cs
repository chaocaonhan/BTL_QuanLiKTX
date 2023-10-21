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
    public partial class FormQuanLiSinhVien : Form
    {
        ProcessDataBase pd = new ProcessDataBase();
        string SqlConnection;
        public FormQuanLiSinhVien()
        {
            InitializeComponent();
        }

        private void FormQuanLiSinhVien_Load(object sender, EventArgs e)
        {
            dataGridViewDanhSachSinhVien.DataSource = pd.DocBang("Select * from SinhVien");
        }
        

        private void btnHomeClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnQuanLiThietBi_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanLiThietBi Obj = new FormQuanLiThietBi();
            Obj.ShowDialog();
            this.Close();
        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormThongKe Obj = new FormThongKe();
            Obj.ShowDialog();
            this.Close();
        }

        private void btnQanLiPhong_Click_1(object sender, EventArgs e)
        {
                this.Hide();
                FormQuanLiPhong Obj = new FormQuanLiPhong();
                Obj.ShowDialog();
                this.Close();
        }

        private void btnQuanLiHoaDon_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanLiHoaDon Obj = new FormQuanLiHoaDon();
            Obj.ShowDialog();
            this.Close();
        }
    }
}
