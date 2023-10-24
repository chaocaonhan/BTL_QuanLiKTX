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
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void btnQanLiPhong_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanLiPhong Obj = new FormQuanLiPhong();
            Obj.ShowDialog();
            this.Close();
        }

        private void btnQuanLiSV_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormQuanLiSinhVien Obj = new FormQuanLiSinhVien();
            Obj.ShowDialog();
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
    }
}
