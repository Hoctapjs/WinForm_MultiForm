namespace GUI_QL_TRASUA
{
    partial class KhuyenMai
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
            this.txt_makm = new System.Windows.Forms.TextBox();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.txt_tenkm = new System.Windows.Forms.TextBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_ngaybd = new System.Windows.Forms.TextBox();
            this.txt_ngaykt = new System.Windows.Forms.TextBox();
            this.txt_heso = new System.Windows.Forms.TextBox();
            this.dataGridView_KhuyenMai = new System.Windows.Forms.DataGridView();
            this.panel_tinhnang = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KhuyenMai)).BeginInit();
            this.panel_tinhnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_makm
            // 
            this.txt_makm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_makm.Location = new System.Drawing.Point(36, 23);
            this.txt_makm.Name = "txt_makm";
            this.txt_makm.PlaceholderText = "Mã khuyến mãi";
            this.txt_makm.Size = new System.Drawing.Size(183, 32);
            this.txt_makm.TabIndex = 1;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Black;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sua.ForeColor = System.Drawing.Color.Orange;
            this.btn_sua.Image = global::GUI_QL_TRASUA.Properties.Resources.update_small;
            this.btn_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sua.Location = new System.Drawing.Point(36, 364);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_sua.Size = new System.Drawing.Size(183, 38);
            this.btn_sua.TabIndex = 8;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Black;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_xoa.ForeColor = System.Drawing.Color.Orange;
            this.btn_xoa.Image = global::GUI_QL_TRASUA.Properties.Resources.remove_small;
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.Location = new System.Drawing.Point(36, 311);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_xoa.Size = new System.Drawing.Size(183, 38);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // txt_tenkm
            // 
            this.txt_tenkm.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tenkm.Location = new System.Drawing.Point(36, 70);
            this.txt_tenkm.Name = "txt_tenkm";
            this.txt_tenkm.PlaceholderText = "Tên khuyến mãi";
            this.txt_tenkm.Size = new System.Drawing.Size(183, 32);
            this.txt_tenkm.TabIndex = 2;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Black;
            this.btn_them.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_them.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_them.ForeColor = System.Drawing.Color.Orange;
            this.btn_them.Image = global::GUI_QL_TRASUA.Properties.Resources.add_small;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.Location = new System.Drawing.Point(36, 258);
            this.btn_them.Name = "btn_them";
            this.btn_them.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btn_them.Size = new System.Drawing.Size(183, 38);
            this.btn_them.TabIndex = 6;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // txt_ngaybd
            // 
            this.txt_ngaybd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ngaybd.Location = new System.Drawing.Point(36, 117);
            this.txt_ngaybd.Name = "txt_ngaybd";
            this.txt_ngaybd.PlaceholderText = "Ngày bắt đầu";
            this.txt_ngaybd.Size = new System.Drawing.Size(183, 32);
            this.txt_ngaybd.TabIndex = 3;
            // 
            // txt_ngaykt
            // 
            this.txt_ngaykt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ngaykt.Location = new System.Drawing.Point(36, 164);
            this.txt_ngaykt.Name = "txt_ngaykt";
            this.txt_ngaykt.PlaceholderText = "Ngày kết thúc";
            this.txt_ngaykt.Size = new System.Drawing.Size(183, 32);
            this.txt_ngaykt.TabIndex = 4;
            // 
            // txt_heso
            // 
            this.txt_heso.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_heso.Location = new System.Drawing.Point(36, 211);
            this.txt_heso.Name = "txt_heso";
            this.txt_heso.PlaceholderText = "Phần trăm";
            this.txt_heso.Size = new System.Drawing.Size(183, 32);
            this.txt_heso.TabIndex = 5;
            // 
            // dataGridView_KhuyenMai
            // 
            this.dataGridView_KhuyenMai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_KhuyenMai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_KhuyenMai.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_KhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KhuyenMai.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_KhuyenMai.Name = "dataGridView_KhuyenMai";
            this.dataGridView_KhuyenMai.RowHeadersWidth = 51;
            this.dataGridView_KhuyenMai.RowTemplate.Height = 29;
            this.dataGridView_KhuyenMai.Size = new System.Drawing.Size(921, 530);
            this.dataGridView_KhuyenMai.TabIndex = 14;
            this.dataGridView_KhuyenMai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_KhuyenMai_CellClick);
            // 
            // panel_tinhnang
            // 
            this.panel_tinhnang.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_tinhnang.Controls.Add(this.txt_makm);
            this.panel_tinhnang.Controls.Add(this.btn_sua);
            this.panel_tinhnang.Controls.Add(this.btn_xoa);
            this.panel_tinhnang.Controls.Add(this.txt_tenkm);
            this.panel_tinhnang.Controls.Add(this.btn_them);
            this.panel_tinhnang.Controls.Add(this.txt_ngaybd);
            this.panel_tinhnang.Controls.Add(this.txt_ngaykt);
            this.panel_tinhnang.Controls.Add(this.txt_heso);
            this.panel_tinhnang.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_tinhnang.Location = new System.Drawing.Point(920, 0);
            this.panel_tinhnang.Name = "panel_tinhnang";
            this.panel_tinhnang.Size = new System.Drawing.Size(256, 530);
            this.panel_tinhnang.TabIndex = 15;
            // 
            // KhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 530);
            this.Controls.Add(this.dataGridView_KhuyenMai);
            this.Controls.Add(this.panel_tinhnang);
            this.Name = "KhuyenMai";
            this.Text = "KhuyenMai";
            this.Load += new System.EventHandler(this.KhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KhuyenMai)).EndInit();
            this.panel_tinhnang.ResumeLayout(false);
            this.panel_tinhnang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TextBox txt_makm;
        private Button btn_sua;
        private Button btn_xoa;
        private TextBox txt_tenkm;
        private Button btn_them;
        private TextBox txt_ngaybd;
        private TextBox txt_ngaykt;
        private TextBox txt_heso;
        private DataGridView dataGridView_KhuyenMai;
        private Panel panel_tinhnang;
    }
}