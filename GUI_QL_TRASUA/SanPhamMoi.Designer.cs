namespace GUI_QL_TRASUA
{
    partial class SanPhamMoi
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_tinhnang = new System.Windows.Forms.Panel();
            this.cbo_kichthuoc = new System.Windows.Forms.ComboBox();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.txt_topping = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.panel_tinhnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(906, 670);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel_tinhnang
            // 
            this.panel_tinhnang.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_tinhnang.Controls.Add(this.cbo_kichthuoc);
            this.panel_tinhnang.Controls.Add(this.txt_tensp);
            this.panel_tinhnang.Controls.Add(this.txt_gia);
            this.panel_tinhnang.Controls.Add(this.txt_masp);
            this.panel_tinhnang.Controls.Add(this.btn_sua);
            this.panel_tinhnang.Controls.Add(this.txt_topping);
            this.panel_tinhnang.Controls.Add(this.btn_them);
            this.panel_tinhnang.Controls.Add(this.btn_xoa);
            this.panel_tinhnang.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_tinhnang.Location = new System.Drawing.Point(904, 0);
            this.panel_tinhnang.Name = "panel_tinhnang";
            this.panel_tinhnang.Size = new System.Drawing.Size(256, 670);
            this.panel_tinhnang.TabIndex = 13;
            // 
            // cbo_kichthuoc
            // 
            this.cbo_kichthuoc.FormattingEnabled = true;
            this.cbo_kichthuoc.Items.AddRange(new object[] {
            "Lớn",
            "Vừa",
            "Nhỏ"});
            this.cbo_kichthuoc.Location = new System.Drawing.Point(34, 14);
            this.cbo_kichthuoc.Name = "cbo_kichthuoc";
            this.cbo_kichthuoc.Size = new System.Drawing.Size(183, 28);
            this.cbo_kichthuoc.TabIndex = 11;
            // 
            // txt_tensp
            // 
            this.txt_tensp.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tensp.Location = new System.Drawing.Point(34, 62);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.PlaceholderText = "Tên sản phẩm";
            this.txt_tensp.Size = new System.Drawing.Size(183, 32);
            this.txt_tensp.TabIndex = 2;
            // 
            // txt_gia
            // 
            this.txt_gia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_gia.Location = new System.Drawing.Point(34, 114);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.PlaceholderText = "Giá";
            this.txt_gia.Size = new System.Drawing.Size(183, 32);
            this.txt_gia.TabIndex = 3;
            // 
            // txt_masp
            // 
            this.txt_masp.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_masp.Location = new System.Drawing.Point(34, 218);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.PlaceholderText = "Mã sản phẩm";
            this.txt_masp.Size = new System.Drawing.Size(183, 32);
            this.txt_masp.TabIndex = 1;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Black;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sua.ForeColor = System.Drawing.Color.Orange;
            this.btn_sua.Location = new System.Drawing.Point(34, 386);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(183, 38);
            this.btn_sua.TabIndex = 8;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            // 
            // txt_topping
            // 
            this.txt_topping.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_topping.Location = new System.Drawing.Point(34, 166);
            this.txt_topping.Name = "txt_topping";
            this.txt_topping.PlaceholderText = "Topping";
            this.txt_topping.Size = new System.Drawing.Size(183, 32);
            this.txt_topping.TabIndex = 5;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Black;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_them.ForeColor = System.Drawing.Color.Orange;
            this.btn_them.Location = new System.Drawing.Point(34, 270);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(183, 38);
            this.btn_them.TabIndex = 6;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Black;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_xoa.ForeColor = System.Drawing.Color.Orange;
            this.btn_xoa.Location = new System.Drawing.Point(34, 328);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(183, 38);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // SanPhamMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 670);
            this.Controls.Add(this.panel_tinhnang);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "SanPhamMoi";
            this.Text = "SanPhamMoi";
            this.Load += new System.EventHandler(this.SanPhamMoi_Load);
            this.panel_tinhnang.ResumeLayout(false);
            this.panel_tinhnang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel_tinhnang;
        private ComboBox cbo_kichthuoc;
        private TextBox txt_tensp;
        private TextBox txt_gia;
        private TextBox txt_masp;
        private Button btn_sua;
        private TextBox txt_topping;
        private Button btn_them;
        private Button btn_xoa;
    }
}