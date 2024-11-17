namespace GUI_QL_TRASUA
{
    partial class ChiTietDonHang
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
            this.dataGridView_ChiTietDonHang = new System.Windows.Forms.DataGridView();
            this.panel_tinhnang = new System.Windows.Forms.Panel();
            this.cbo_masp = new System.Windows.Forms.ComboBox();
            this.cbo_madh = new System.Windows.Forms.ComboBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_gia = new System.Windows.Forms.TextBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.txt_madh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChiTietDonHang)).BeginInit();
            this.panel_tinhnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_ChiTietDonHang
            // 
            this.dataGridView_ChiTietDonHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_ChiTietDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_ChiTietDonHang.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_ChiTietDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_ChiTietDonHang.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_ChiTietDonHang.Name = "dataGridView_ChiTietDonHang";
            this.dataGridView_ChiTietDonHang.RowHeadersWidth = 51;
            this.dataGridView_ChiTietDonHang.RowTemplate.Height = 29;
            this.dataGridView_ChiTietDonHang.Size = new System.Drawing.Size(920, 530);
            this.dataGridView_ChiTietDonHang.TabIndex = 10;
            this.dataGridView_ChiTietDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_ChiTietDonHang_CellClick);
            // 
            // panel_tinhnang
            // 
            this.panel_tinhnang.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_tinhnang.Controls.Add(this.cbo_masp);
            this.panel_tinhnang.Controls.Add(this.cbo_madh);
            this.panel_tinhnang.Controls.Add(this.btn_sua);
            this.panel_tinhnang.Controls.Add(this.btn_xoa);
            this.panel_tinhnang.Controls.Add(this.btn_them);
            this.panel_tinhnang.Controls.Add(this.txt_gia);
            this.panel_tinhnang.Controls.Add(this.txt_soluong);
            this.panel_tinhnang.Controls.Add(this.txt_masp);
            this.panel_tinhnang.Controls.Add(this.txt_madh);
            this.panel_tinhnang.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_tinhnang.Location = new System.Drawing.Point(920, 0);
            this.panel_tinhnang.Name = "panel_tinhnang";
            this.panel_tinhnang.Size = new System.Drawing.Size(256, 530);
            this.panel_tinhnang.TabIndex = 15;
            // 
            // cbo_masp
            // 
            this.cbo_masp.FormattingEnabled = true;
            this.cbo_masp.Location = new System.Drawing.Point(37, 91);
            this.cbo_masp.Name = "cbo_masp";
            this.cbo_masp.Size = new System.Drawing.Size(183, 28);
            this.cbo_masp.TabIndex = 21;
            // 
            // cbo_madh
            // 
            this.cbo_madh.FormattingEnabled = true;
            this.cbo_madh.Location = new System.Drawing.Point(37, 45);
            this.cbo_madh.Name = "cbo_madh";
            this.cbo_madh.Size = new System.Drawing.Size(183, 28);
            this.cbo_madh.TabIndex = 20;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Black;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sua.ForeColor = System.Drawing.Color.Orange;
            this.btn_sua.Location = new System.Drawing.Point(37, 447);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(183, 38);
            this.btn_sua.TabIndex = 19;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            this.btn_sua.Image = global::GUI_QL_TRASUA.Properties.Resources.update_small;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Black;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_xoa.ForeColor = System.Drawing.Color.Orange;
            this.btn_xoa.Location = new System.Drawing.Point(37, 394);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(183, 38);
            this.btn_xoa.TabIndex = 18;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            this.btn_xoa.Image = global::GUI_QL_TRASUA.Properties.Resources.remove_small;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Black;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_them.ForeColor = System.Drawing.Color.Orange;
            this.btn_them.Location = new System.Drawing.Point(37, 341);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(183, 38);
            this.btn_them.TabIndex = 17;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            this.btn_them.Image = global::GUI_QL_TRASUA.Properties.Resources.add_small;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // txt_gia
            // 
            this.txt_gia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_gia.Location = new System.Drawing.Point(37, 287);
            this.txt_gia.Name = "txt_gia";
            this.txt_gia.PlaceholderText = "Giá";
            this.txt_gia.Size = new System.Drawing.Size(183, 32);
            this.txt_gia.TabIndex = 16;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_soluong.Location = new System.Drawing.Point(37, 237);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.PlaceholderText = "Số lượng";
            this.txt_soluong.Size = new System.Drawing.Size(183, 32);
            this.txt_soluong.TabIndex = 15;
            // 
            // txt_masp
            // 
            this.txt_masp.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_masp.Location = new System.Drawing.Point(37, 187);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.PlaceholderText = "Mã sản phẩm";
            this.txt_masp.Size = new System.Drawing.Size(183, 32);
            this.txt_masp.TabIndex = 14;
            // 
            // txt_madh
            // 
            this.txt_madh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_madh.Location = new System.Drawing.Point(37, 137);
            this.txt_madh.Name = "txt_madh";
            this.txt_madh.PlaceholderText = "Mã đơn hàng";
            this.txt_madh.Size = new System.Drawing.Size(183, 32);
            this.txt_madh.TabIndex = 13;
            // 
            // ChiTietDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 530);
            this.Controls.Add(this.dataGridView_ChiTietDonHang);
            this.Controls.Add(this.panel_tinhnang);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChiTietDonHang";
            this.Text = "ChiTietDonHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_ChiTietDonHang)).EndInit();
            this.panel_tinhnang.ResumeLayout(false);
            this.panel_tinhnang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView_ChiTietDonHang;
        private Panel panel_tinhnang;
        private ComboBox cbo_masp;
        private ComboBox cbo_madh;
        private Button btn_sua;
        private Button btn_xoa;
        private Button btn_them;
        private TextBox txt_gia;
        private TextBox txt_soluong;
        private TextBox txt_masp;
        private TextBox txt_madh;
    }
}