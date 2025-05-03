namespace PresentationLayer
{
    partial class ThanhToanControl
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
            this.panelSide = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelProds = new System.Windows.Forms.FlowLayoutPanel();
            this.panelThanToan = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.panelThanToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSide
            // 
            this.panelSide.AutoScroll = true;
            this.panelSide.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSide.ForeColor = System.Drawing.Color.Transparent;
            this.panelSide.Location = new System.Drawing.Point(859, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(441, 800);
            this.panelSide.TabIndex = 0;
            this.panelSide.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSide_Paint);
            // 
            // flowLayoutPanelProds
            // 
            this.flowLayoutPanelProds.AutoScroll = true;
            this.flowLayoutPanelProds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelProds.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelProds.Name = "flowLayoutPanelProds";
            this.flowLayoutPanelProds.Size = new System.Drawing.Size(859, 800);
            this.flowLayoutPanelProds.TabIndex = 1;
            this.flowLayoutPanelProds.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelProds_Paint);
            // 
            // panelThanToan
            // 
            this.panelThanToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(89)))), ((int)(((byte)(52)))));
            this.panelThanToan.Controls.Add(this.txtSoDienThoai);
            this.panelThanToan.Controls.Add(this.btnRefresh);
            this.panelThanToan.Controls.Add(this.btnSearch);
            this.panelThanToan.Controls.Add(this.label2);
            this.panelThanToan.Controls.Add(this.txtSearch);
            this.panelThanToan.Controls.Add(this.btnThanhToan);
            this.panelThanToan.Controls.Add(this.lblTongTien);
            this.panelThanToan.Controls.Add(this.label1);
            this.panelThanToan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelThanToan.Location = new System.Drawing.Point(0, 635);
            this.panelThanToan.Name = "panelThanToan";
            this.panelThanToan.Size = new System.Drawing.Size(859, 165);
            this.panelThanToan.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(477, 82);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(107, 45);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Reset";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(804, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Beige;
            this.label2.Location = new System.Drawing.Point(474, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(554, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(244, 22);
            this.txtSearch.TabIndex = 3;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(140)))), ((int)(((byte)(98)))));
            this.btnThanhToan.FlatAppearance.BorderSize = 0;
            this.btnThanhToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan.ForeColor = System.Drawing.Color.Beige;
            this.btnThanhToan.Location = new System.Drawing.Point(281, 82);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(115, 45);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.ForeColor = System.Drawing.Color.Beige;
            this.lblTongTien.Location = new System.Drawing.Point(314, 27);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(44, 16);
            this.lblTongTien.TabIndex = 1;
            this.lblTongTien.Text = "label2";
            this.lblTongTien.Click += new System.EventHandler(this.lblTongTien_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Beige;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tổng tiền";
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(120, 93);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(128, 22);
            this.txtSoDienThoai.TabIndex = 7;
            // 
            // ThanhToanControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelThanToan);
            this.Controls.Add(this.flowLayoutPanelProds);
            this.Controls.Add(this.panelSide);
            this.Name = "ThanhToanControl";
            this.Size = new System.Drawing.Size(1300, 800);
            this.Load += new System.EventHandler(this.ThanhToanControl_Load);
            this.panelThanToan.ResumeLayout(false);
            this.panelThanToan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelSide;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelProds;
        private System.Windows.Forms.Panel panelThanToan;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtSoDienThoai;
    }
}
