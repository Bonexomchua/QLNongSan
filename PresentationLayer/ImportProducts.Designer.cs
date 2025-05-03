namespace PresentationLayer
{
    partial class ImportProducts
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
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.lblLoaiSanPham = new System.Windows.Forms.Label();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.lblGiaLai = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cbbTenSP = new System.Windows.Forms.ComboBox();
            this.cbbLoaiSP = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.cbbDonVi = new System.Windows.Forms.ComboBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtGiaLai = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnAddPic = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.AutoSize = true;
            this.lblTenSanPham.Location = new System.Drawing.Point(51, 44);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(96, 16);
            this.lblTenSanPham.TabIndex = 0;
            this.lblTenSanPham.Text = "Tên Sản Phẩm";
            // 
            // lblLoaiSanPham
            // 
            this.lblLoaiSanPham.AutoSize = true;
            this.lblLoaiSanPham.Location = new System.Drawing.Point(51, 108);
            this.lblLoaiSanPham.Name = "lblLoaiSanPham";
            this.lblLoaiSanPham.Size = new System.Drawing.Size(95, 16);
            this.lblLoaiSanPham.TabIndex = 1;
            this.lblLoaiSanPham.Text = "Loại sản phẩm";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(51, 176);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(60, 16);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "Số lượng";
            // 
            // lblDonVi
            // 
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Location = new System.Drawing.Point(51, 251);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(44, 16);
            this.lblDonVi.TabIndex = 3;
            this.lblDonVi.Text = "Đơn vị";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(356, 44);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(53, 16);
            this.lblDonGia.TabIndex = 4;
            this.lblDonGia.Text = "Đơn giá";
            // 
            // lblGiaLai
            // 
            this.lblGiaLai.AutoSize = true;
            this.lblGiaLai.Location = new System.Drawing.Point(356, 108);
            this.lblGiaLai.Name = "lblGiaLai";
            this.lblGiaLai.Size = new System.Drawing.Size(49, 16);
            this.lblGiaLai.TabIndex = 5;
            this.lblGiaLai.Text = "Giá Lãi";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(408, 320);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(116, 40);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Xác nhận";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cbbTenSP
            // 
            this.cbbTenSP.FormattingEnabled = true;
            this.cbbTenSP.Location = new System.Drawing.Point(153, 41);
            this.cbbTenSP.Name = "cbbTenSP";
            this.cbbTenSP.Size = new System.Drawing.Size(169, 24);
            this.cbbTenSP.TabIndex = 11;
            // 
            // cbbLoaiSP
            // 
            this.cbbLoaiSP.FormattingEnabled = true;
            this.cbbLoaiSP.Location = new System.Drawing.Point(152, 105);
            this.cbbLoaiSP.Name = "cbbLoaiSP";
            this.cbbLoaiSP.Size = new System.Drawing.Size(169, 24);
            this.cbbLoaiSP.TabIndex = 12;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(152, 176);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(170, 22);
            this.txtSoLuong.TabIndex = 13;
            // 
            // cbbDonVi
            // 
            this.cbbDonVi.FormattingEnabled = true;
            this.cbbDonVi.Location = new System.Drawing.Point(152, 251);
            this.cbbDonVi.Name = "cbbDonVi";
            this.cbbDonVi.Size = new System.Drawing.Size(170, 24);
            this.cbbDonVi.TabIndex = 14;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(429, 41);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(171, 22);
            this.txtDonGia.TabIndex = 15;
            // 
            // txtGiaLai
            // 
            this.txtGiaLai.Location = new System.Drawing.Point(429, 105);
            this.txtGiaLai.Name = "txtGiaLai";
            this.txtGiaLai.Size = new System.Drawing.Size(171, 22);
            this.txtGiaLai.TabIndex = 16;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAddPic
            // 
            this.btnAddPic.Location = new System.Drawing.Point(552, 195);
            this.btnAddPic.Name = "btnAddPic";
            this.btnAddPic.Size = new System.Drawing.Size(118, 42);
            this.btnAddPic.TabIndex = 20;
            this.btnAddPic.Text = "Thêm ảnh";
            this.btnAddPic.UseVisualStyleBackColor = true;
            this.btnAddPic.Click += new System.EventHandler(this.btnAddPic_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(362, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // ImportProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 384);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddPic);
            this.Controls.Add(this.txtGiaLai);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.cbbDonVi);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.cbbLoaiSP);
            this.Controls.Add(this.cbbTenSP);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblGiaLai);
            this.Controls.Add(this.lblDonGia);
            this.Controls.Add(this.lblDonVi);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.lblLoaiSanPham);
            this.Controls.Add(this.lblTenSanPham);
            this.Name = "ImportProducts";
            this.Text = "ImportProducts";
            this.Load += new System.EventHandler(this.ImportProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.Label lblLoaiSanPham;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Label lblGiaLai;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cbbTenSP;
        private System.Windows.Forms.ComboBox cbbLoaiSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.ComboBox cbbDonVi;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtGiaLai;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnAddPic;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}