namespace GUI_QL_TRASUA
{
    partial class SanPham
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
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.txt_topping = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.dataGridView_SanPham = new System.Windows.Forms.DataGridView();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.cbo_kichthuoc = new System.Windows.Forms.ComboBox();
            this.panel_tinhnang = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SanPham)).BeginInit();
            this.panel_tinhnang.SuspendLayout();
            this.SuspendLayout();
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
            // txt_tensp
            // 
            this.txt_tensp.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tensp.Location = new System.Drawing.Point(34, 62);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.PlaceholderText = "Tên sản phẩm";
            this.txt_tensp.Size = new System.Drawing.Size(183, 32);
            this.txt_tensp.TabIndex = 2;
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
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
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
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
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
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // dataGridView_SanPham
            // 
            this.dataGridView_SanPham.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_SanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_SanPham.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_SanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SanPham.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_SanPham.Name = "dataGridView_SanPham";
            this.dataGridView_SanPham.RowHeadersWidth = 51;
            this.dataGridView_SanPham.RowTemplate.Height = 29;
            this.dataGridView_SanPham.Size = new System.Drawing.Size(900, 530);
            this.dataGridView_SanPham.TabIndex = 10;
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
            this.panel_tinhnang.Location = new System.Drawing.Point(900, 0);
            this.panel_tinhnang.Name = "panel_tinhnang";
            this.panel_tinhnang.Size = new System.Drawing.Size(256, 530);
            this.panel_tinhnang.TabIndex = 12;
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1156, 530);
            this.Controls.Add(this.panel_tinhnang);
            this.Controls.Add(this.dataGridView_SanPham);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SanPham";
            this.Text = "SanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SanPham)).EndInit();
            this.panel_tinhnang.ResumeLayout(false);
            this.panel_tinhnang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private TextBox txt_masp;
        private TextBox txt_tensp;
        private TextBox txt_topping;
        private Button btn_them;
        private Button btn_xoa;
        private Button btn_sua;
        private DataGridView dataGridView_SanPham;
        private TextBox txt_gia;
        private ComboBox cbo_kichthuoc;
        private Panel panel_tinhnang;
    }
}