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
    public partial class frm_SanPham : Form
    {
        public frm_SanPham()
        {
            InitializeComponent();
            dgvSanPham.CellClick += dgvSanPham_CellClick;
        }

        private void LoadData()
        {
            SqlServerConnection db = new SqlServerConnection();
            string query = "SELECT * FROM SANPHAM ORDER BY NgaySX DESC";
            DataTable dt = db.ExecuteQuery(query);

            if (dt != null)
            {
                dgvSanPham.DataSource = dt;

                pictureBox1.Image = Properties.Resources.add_photo3;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Width = 320;
                pictureBox1.Height = 180;
                pictureBox1.Location = new Point(657, 27);

            }
            else
            {
                MessageBox.Show("Lỗi khi tải dữ liệu!");
            }
        }

        private void LoadDanhMuc ()
        {
            SqlServerConnection db = new SqlServerConnection();
            string query = "SELECT * FROM DANHMUC";
            DataTable dt = db.ExecuteQuery(query);

            if (dt != null)
            {
                cboDM.DataSource = dt;
                cboDM.DisplayMember = "TenDMSP";
                cboDM.ValueMember = "MaDM";
                cboDM.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Lỗi khi tải dữ liệu!");
            }
        }
        private void frm_SanPham_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadDanhMuc();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

                bool isEmptyRow = true;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && !string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        isEmptyRow = false;
                        break;
                    }
                }

                if (isEmptyRow)
                {
                    ClearInput();
                    txtMaSP.Enabled = true;
                    return;
                }

                txtMaSP.Text = row.Cells["MaSP"].Value.ToString();
                cboDM.SelectedValue = row.Cells["MaDM"].Value.ToString();
                txtTenSp.Text = row.Cells["TenSP"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                dtpNgaySX.Value = Convert.ToDateTime(row.Cells["NgaySX"].Value);
                pictureBox1.ImageLocation = row.Cells["HinhAnh"].Value.ToString();

                txtMaSP.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlServerConnection db = new SqlServerConnection();
            string maSP = txtMaSP.Text.Trim();

            string checkQuery = $"SELECT COUNT(*) FROM SANPHAM WHERE MaSP='{maSP}'";
            int count = db.ExecuteScalar(checkQuery);
            if (count > 0)
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!");
                return;
            }

            string madm = cboDM.SelectedValue.ToString();
            string tenSP = txtTenSp.Text.Trim();
            string ngaySX = dtpNgaySX.Value.ToString("yyyy-MM-dd");
            string donGia = txtDonGia.Text.Trim();
            string hinhAnh = (pictureBox1.ImageLocation != null) ? pictureBox1.ImageLocation : "";

            string insertQuery = $"INSERT INTO SANPHAM (MaSP, MaDM, TenSP, NgaySX, DonGia, HinhAnh) " +
                                 $"VALUES ('{maSP}', '{madm}', N'{tenSP}', '{ngaySX}', {donGia}, '{hinhAnh}')";
            int result = db.ExecuteNonQuery(insertQuery);

            if (result > 0)
            {
                ClearInput();
                MessageBox.Show("Thêm thành công!");
            }    
            else
                MessageBox.Show("Thêm thất bại!");

            LoadData();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlServerConnection db = new SqlServerConnection();
            string maSP = txtMaSP.Text.Trim();
            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để sửa!");
                return;
            }

            string madm = cboDM.SelectedValue.ToString();
            string tenSP = txtTenSp.Text.Trim();
            string ngaySX = dtpNgaySX.Value.ToString("yyyy-MM-dd");
            string donGia = txtDonGia.Text.Trim();
            string hinhAnh = (pictureBox1.ImageLocation != null) ? pictureBox1.ImageLocation : "";

            string updateQuery = $"UPDATE SANPHAM SET MaDM='{madm}', TenSP=N'{tenSP}', NgaySX='{ngaySX}', " +
                                 $"DonGia={donGia}, HinhAnh='{hinhAnh}' WHERE MaSP='{maSP}'";
            int result = db.ExecuteNonQuery(updateQuery);

            if (result > 0)
            {
                ClearInput();
                MessageBox.Show("Sửa thành công!");
            }    
            else
                MessageBox.Show("Sửa thất bại!");

            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text.Trim();
            if (string.IsNullOrEmpty(maSP))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm để xóa!");
                return;
            }

            if (MessageBox.Show("Bạn có muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlServerConnection db = new SqlServerConnection();
                string deleteQuery = $"DELETE FROM SANPHAM WHERE MaSP='{maSP}'";
                int result = db.ExecuteNonQuery(deleteQuery);

                if (result > 0)
                {
                    ClearInput();
                    MessageBox.Show("Xóa thành công!");
                }    
                else
                    MessageBox.Show("Xóa thất bại!");

                LoadData();
            }
        }

        private void ClearInput()
        {
            txtMaSP.Text = "";
            cboDM.SelectedIndex = -1;
            txtTenSp.Text = "";
            dtpNgaySX.Value = DateTime.Now;
            txtDonGia.Text = "";
            pictureBox1.Image = Properties.Resources.add_photo3;
            txtMaSP.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }
    }
}
