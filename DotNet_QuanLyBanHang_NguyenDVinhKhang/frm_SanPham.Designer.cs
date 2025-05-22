namespace DotNet_QuanLyBanHang_NguyenDVinhKhang
{
    partial class frm_SanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboDM = new System.Windows.Forms.ComboBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtTenSp = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.dtpNgaySX = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.dANHMUCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Muc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ma SP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ten SP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Don Gia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngay SX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(763, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ảnh Sản Phẩm";
            // 
            // cboDM
            // 
            this.cboDM.FormattingEnabled = true;
            this.cboDM.Location = new System.Drawing.Point(198, 28);
            this.cboDM.Name = "cboDM";
            this.cboDM.Size = new System.Drawing.Size(386, 25);
            this.cboDM.TabIndex = 6;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(198, 80);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(386, 23);
            this.txtMaSP.TabIndex = 7;
            // 
            // txtTenSp
            // 
            this.txtTenSp.Location = new System.Drawing.Point(198, 132);
            this.txtTenSp.Name = "txtTenSp";
            this.txtTenSp.Size = new System.Drawing.Size(386, 23);
            this.txtTenSp.TabIndex = 8;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(198, 184);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(386, 23);
            this.txtDonGia.TabIndex = 9;
            // 
            // dtpNgaySX
            // 
            this.dtpNgaySX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySX.Location = new System.Drawing.Point(198, 234);
            this.dtpNgaySX.Name = "dtpNgaySX";
            this.dtpNgaySX.Size = new System.Drawing.Size(178, 23);
            this.dtpNgaySX.TabIndex = 10;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(86, 288);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(125, 33);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(251, 288);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(125, 33);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(416, 288);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 33);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(12, 346);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(976, 204);
            this.dgvSanPham.TabIndex = 14;
            // 
            // dANHMUCBindingSource
            // 
            this.dANHMUCBindingSource.DataMember = "DANHMUC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DotNet_QuanLyBanHang_NguyenDVinhKhang.Properties.Resources.add_photo3;
            this.pictureBox1.Location = new System.Drawing.Point(657, 27);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(320, 180);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpNgaySX);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtTenSp);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.cboDM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_SanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Sản Phẩm";
            this.Load += new System.EventHandler(this.frm_SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANHMUCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboDM;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtTenSp;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.DateTimePicker dtpNgaySX;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource dANHMUCBindingSource;
    }
}