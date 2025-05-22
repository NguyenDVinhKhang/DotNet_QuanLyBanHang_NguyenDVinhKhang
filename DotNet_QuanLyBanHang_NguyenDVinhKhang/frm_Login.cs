using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNet_QuanLyBanHang_NguyenDVinhKhang
{
    public partial class frm_Login : Form
    {
        public event EventHandler LoginSuccess;
        public frm_Login()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDN_Click(object sender, EventArgs e)
        {
            string user = txtTenDN.Text.Trim();
            string pass = txtMK.Text.Trim();
            string query = $"SELECT COUNT(*) FROM [USER] WHERE UserName='{user}' AND Password='{pass}'";

            SqlServerConnection db = new SqlServerConnection();
            int count = db.ExecuteScalar(query);

            if (count > 0)
            {
                LoginSuccess?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}