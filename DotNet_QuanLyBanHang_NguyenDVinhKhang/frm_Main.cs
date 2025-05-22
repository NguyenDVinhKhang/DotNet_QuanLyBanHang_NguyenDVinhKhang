using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotNet_QuanLyBanHang_NguyenDVinhKhang
{
    public partial class frm_Main : Form
    {
        private frm_Login loginForm;
        private frm_SanPham sanPhamForm;
        private bool isLoginSuccess = false;
        public frm_Main()
        {
            InitializeComponent();
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            menuStrip1.Enabled = false;

            loginForm = new frm_Login();
            loginForm.MdiParent = this;
            loginForm.LoginSuccess += LoginForm_LoginSuccess;
            loginForm.FormClosed += LoginForm_FormClosed;
            loginForm.Show();
        }

        private void LoginForm_LoginSuccess(object sender, EventArgs e)
        {
            menuStrip1.Enabled = true;
            isLoginSuccess = true;
            loginForm.Close();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!isLoginSuccess)
            {
                Application.Exit();
            }
        }

        private void themSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sanPhamForm == null || sanPhamForm.IsDisposed)
            {
                sanPhamForm = new frm_SanPham();
                sanPhamForm.MdiParent = this;
                sanPhamForm.Show();
            }
            else
            {
                sanPhamForm.Activate();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
