namespace GUI_QL_TRASUA
{
    partial class DonHang
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
            this.dataGridView_DonHang = new System.Windows.Forms.DataGridView();
            this.panel_tinhnang = new System.Windows.Forms.Panel();
            this.cbo_makh = new System.Windows.Forms.ComboBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_tonggia = new System.Windows.Forms.TextBox();
            this.txt_ngaylap = new System.Windows.Forms.TextBox();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.txt_madh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DonHang)).BeginInit();
            this.panel_tinhnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_DonHang
            // 
            this.dataGridView_DonHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_DonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DonHang.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_DonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DonHang.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_DonHang.Name = "dataGridView_DonHang";
            this.dataGridView_DonHang.RowHeadersWidth = 51;
            this.dataGridView_DonHang.RowTemplate.Height = 29;
            this.dataGridView_DonHang.Size = new System.Drawing.Size(923, 530);
            this.dataGridView_DonHang.TabIndex = 10;
            // 
            // panel_tinhnang
            // 
            this.panel_tinhnang.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_tinhnang.Controls.Add(this.cbo_makh);
            this.panel_tinhnang.Controls.Add(this.btn_sua);
            this.panel_tinhnang.Controls.Add(this.btn_xoa);
            this.panel_tinhnang.Controls.Add(this.btn_them);
            this.panel_tinhnang.Controls.Add(this.txt_tonggia);
            this.panel_tinhnang.Controls.Add(this.txt_ngaylap);
            this.panel_tinhnang.Controls.Add(this.txt_makh);
            this.panel_tinhnang.Controls.Add(this.txt_madh);
            this.panel_tinhnang.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_tinhnang.Location = new System.Drawing.Point(920, 0);
            this.panel_tinhnang.Name = "panel_tinhnang";
            this.panel_tinhnang.Size = new System.Drawing.Size(256, 530);
            this.panel_tinhnang.TabIndex = 15;
            // 
            // cbo_makh
            // 
            this.cbo_makh.FormattingEnabled = true;
            this.cbo_makh.Location = new System.Drawing.Point(37, 217);
            this.cbo_makh.Name = "cbo_makh";
            this.cbo_makh.Size = new System.Drawing.Size(183, 28);
            this.cbo_makh.TabIndex = 19;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Black;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sua.ForeColor = System.Drawing.Color.Orange;
            this.btn_sua.Location = new System.Drawing.Point(37, 417);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(183, 38);
            this.btn_sua.TabIndex = 18;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Black;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_xoa.ForeColor = System.Drawing.Color.Orange;
            this.btn_xoa.Location = new System.Drawing.Point(37, 364);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(183, 38);
            this.btn_xoa.TabIndex = 17;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Black;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_them.ForeColor = System.Drawing.Color.Orange;
            this.btn_them.Location = new System.Drawing.Point(37, 311);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(183, 38);
            this.btn_them.TabIndex = 16;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            // 
            // txt_tonggia
            // 
            this.txt_tonggia.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tonggia.Location = new System.Drawing.Point(37, 168);
            this.txt_tonggia.Name = "txt_tonggia";
            this.txt_tonggia.PlaceholderText = "Tổng giá";
            this.txt_tonggia.Size = new System.Drawing.Size(183, 32);
            this.txt_tonggia.TabIndex = 15;
            // 
            // txt_ngaylap
            // 
            this.txt_ngaylap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ngaylap.Location = new System.Drawing.Point(37, 121);
            this.txt_ngaylap.Name = "txt_ngaylap";
            this.txt_ngaylap.PlaceholderText = "Ngày lập";
            this.txt_ngaylap.Size = new System.Drawing.Size(183, 32);
            this.txt_ngaylap.TabIndex = 14;
            // 
            // txt_makh
            // 
            this.txt_makh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_makh.Location = new System.Drawing.Point(37, 74);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.PlaceholderText = "Mã khách hàng";
            this.txt_makh.Size = new System.Drawing.Size(183, 32);
            this.txt_makh.TabIndex = 13;
            // 
            // txt_madh
            // 
            this.txt_madh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_madh.Location = new System.Drawing.Point(37, 27);
            this.txt_madh.Name = "txt_madh";
            this.txt_madh.PlaceholderText = "Mã đơn hàng";
            this.txt_madh.Size = new System.Drawing.Size(183, 32);
            this.txt_madh.TabIndex = 12;
            // 
            // DonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 530);
            this.Controls.Add(this.dataGridView_DonHang);
            this.Controls.Add(this.panel_tinhnang);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DonHang";
            this.Text = "DonHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DonHang)).EndInit();
            this.panel_tinhnang.ResumeLayout(false);
            this.panel_tinhnang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView_DonHang;
        private Panel panel_tinhnang;
        private ComboBox cbo_makh;
        private Button btn_sua;
        private Button btn_xoa;
        private Button btn_them;
        private TextBox txt_tonggia;
        private TextBox txt_ngaylap;
        private TextBox txt_makh;
        private TextBox txt_madh;
    }
}