namespace GUI_QL_TRASUA
{
    partial class KhachHang
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
            this.dataGridView_KhachHang = new System.Windows.Forms.DataGridView();
            this.panel_tinhnang = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_sodt = new System.Windows.Forms.TextBox();
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.txt_makh = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KhachHang)).BeginInit();
            this.panel_tinhnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_KhachHang
            // 
            this.dataGridView_KhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_KhachHang.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_KhachHang.Location = new System.Drawing.Point(0, -1);
            this.dataGridView_KhachHang.Name = "dataGridView_KhachHang";
            this.dataGridView_KhachHang.RowHeadersWidth = 51;
            this.dataGridView_KhachHang.RowTemplate.Height = 29;
            this.dataGridView_KhachHang.Size = new System.Drawing.Size(922, 536);
            this.dataGridView_KhachHang.TabIndex = 10;
            this.dataGridView_KhachHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_KhachHang_CellClick);
            // 
            // panel_tinhnang
            // 
            this.panel_tinhnang.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_tinhnang.Controls.Add(this.label4);
            this.panel_tinhnang.Controls.Add(this.label3);
            this.panel_tinhnang.Controls.Add(this.label2);
            this.panel_tinhnang.Controls.Add(this.label1);
            this.panel_tinhnang.Controls.Add(this.btn_sua);
            this.panel_tinhnang.Controls.Add(this.btn_xoa);
            this.panel_tinhnang.Controls.Add(this.btn_them);
            this.panel_tinhnang.Controls.Add(this.txt_diachi);
            this.panel_tinhnang.Controls.Add(this.txt_sodt);
            this.panel_tinhnang.Controls.Add(this.txt_tenkh);
            this.panel_tinhnang.Controls.Add(this.txt_makh);
            this.panel_tinhnang.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_tinhnang.Location = new System.Drawing.Point(920, 0);
            this.panel_tinhnang.Name = "panel_tinhnang";
            this.panel_tinhnang.Size = new System.Drawing.Size(256, 530);
            this.panel_tinhnang.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 28);
            this.label4.TabIndex = 19;
            this.label4.Text = "Địa Chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Số Điện Thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.Black;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sua.ForeColor = System.Drawing.Color.Orange;
            this.btn_sua.Location = new System.Drawing.Point(25, 480);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(206, 38);
            this.btn_sua.TabIndex = 15;
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
            this.btn_xoa.Location = new System.Drawing.Point(25, 427);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(206, 38);
            this.btn_xoa.TabIndex = 14;
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
            this.btn_them.Location = new System.Drawing.Point(25, 374);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(206, 38);
            this.btn_them.TabIndex = 13;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            this.btn_them.Image = global::GUI_QL_TRASUA.Properties.Resources.add_small;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            // 
            // txt_diachi
            // 
            this.txt_diachi.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_diachi.Location = new System.Drawing.Point(25, 320);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.PlaceholderText = "Địa chỉ";
            this.txt_diachi.Size = new System.Drawing.Size(206, 32);
            this.txt_diachi.TabIndex = 12;
            // 
            // txt_sodt
            // 
            this.txt_sodt.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_sodt.Location = new System.Drawing.Point(25, 236);
            this.txt_sodt.Name = "txt_sodt";
            this.txt_sodt.PlaceholderText = "Số điện thoại";
            this.txt_sodt.Size = new System.Drawing.Size(206, 32);
            this.txt_sodt.TabIndex = 11;
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tenkh.Location = new System.Drawing.Point(25, 152);
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.PlaceholderText = "Tên khách hàng";
            this.txt_tenkh.Size = new System.Drawing.Size(206, 32);
            this.txt_tenkh.TabIndex = 10;
            // 
            // txt_makh
            // 
            this.txt_makh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_makh.Location = new System.Drawing.Point(25, 68);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.PlaceholderText = "Mã khách hàng";
            this.txt_makh.Size = new System.Drawing.Size(206, 32);
            this.txt_makh.TabIndex = 9;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 530);
            this.Controls.Add(this.dataGridView_KhachHang);
            this.Controls.Add(this.panel_tinhnang);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "KhachHang";
            this.Text = "KhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_KhachHang)).EndInit();
            this.panel_tinhnang.ResumeLayout(false);
            this.panel_tinhnang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView_KhachHang;
        private Panel panel_tinhnang;
        private Button btn_sua;
        private Button btn_xoa;
        private Button btn_them;
        private TextBox txt_diachi;
        private TextBox txt_sodt;
        private TextBox txt_tenkh;
        private TextBox txt_makh;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}