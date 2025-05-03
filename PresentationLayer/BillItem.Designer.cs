namespace PresentationLayer
{
    partial class BillItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblNgayThang = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnDetail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.Location = new System.Drawing.Point(167, 15);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(44, 16);
            this.lblNhanVien.TabIndex = 0;
            this.lblNhanVien.Text = "label1";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(32, 15);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(44, 16);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "label1";
            // 
            // lblNgayThang
            // 
            this.lblNgayThang.AutoSize = true;
            this.lblNgayThang.Location = new System.Drawing.Point(311, 15);
            this.lblNgayThang.Name = "lblNgayThang";
            this.lblNgayThang.Size = new System.Drawing.Size(44, 16);
            this.lblNgayThang.TabIndex = 0;
            this.lblNgayThang.Text = "label1";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(590, 15);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(44, 16);
            this.lblTongTien.TabIndex = 0;
            this.lblTongTien.Text = "label1";
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(788, 7);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(201, 32);
            this.btnDetail.TabIndex = 1;
            this.btnDetail.Text = "Xem chi tiết";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // BillItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblNgayThang);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.lblNhanVien);
            this.Name = "BillItem";
            this.Size = new System.Drawing.Size(1005, 49);
            this.Load += new System.EventHandler(this.BillItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblNgayThang;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnDetail;
    }
}
