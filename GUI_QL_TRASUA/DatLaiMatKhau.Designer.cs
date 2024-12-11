namespace GUI_QL_TRASUA
{
    partial class DatLaiMatKhau
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_tennguoidung = new TextBox();
            txt_matkhaucu = new TextBox();
            txt_matkhaumoi = new TextBox();
            btn_doimatkhau = new Button();
            label4 = new Label();
            btn_dangnhap = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(42, 108);
            label1.Name = "label1";
            label1.Size = new Size(198, 35);
            label1.TabIndex = 0;
            label1.Text = "Tên Người Dùng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(42, 228);
            label2.Name = "label2";
            label2.Size = new Size(157, 35);
            label2.TabIndex = 1;
            label2.Text = "Mật Khẩu Cũ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(42, 348);
            label3.Name = "label3";
            label3.Size = new Size(171, 35);
            label3.TabIndex = 2;
            label3.Text = "Mật Khẩu Mới";
            // 
            // txt_tennguoidung
            // 
            txt_tennguoidung.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txt_tennguoidung.Location = new Point(42, 165);
            txt_tennguoidung.Name = "txt_tennguoidung";
            txt_tennguoidung.Size = new Size(558, 41);
            txt_tennguoidung.TabIndex = 3;
            // 
            // txt_matkhaucu
            // 
            txt_matkhaucu.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txt_matkhaucu.Location = new Point(42, 285);
            txt_matkhaucu.Name = "txt_matkhaucu";
            txt_matkhaucu.Size = new Size(558, 41);
            txt_matkhaucu.TabIndex = 4;
            // 
            // txt_matkhaumoi
            // 
            txt_matkhaumoi.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txt_matkhaumoi.Location = new Point(42, 405);
            txt_matkhaumoi.Name = "txt_matkhaumoi";
            txt_matkhaumoi.Size = new Size(558, 41);
            txt_matkhaumoi.TabIndex = 5;
            // 
            // btn_doimatkhau
            // 
            btn_doimatkhau.BackColor = Color.Black;
            btn_doimatkhau.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_doimatkhau.ForeColor = Color.Orange;
            btn_doimatkhau.Image = Properties.Resources.reset_password;
            btn_doimatkhau.ImageAlign = ContentAlignment.MiddleLeft;
            btn_doimatkhau.Location = new Point(325, 480);
            btn_doimatkhau.Name = "btn_doimatkhau";
            btn_doimatkhau.Padding = new Padding(15, 0, 15, 0);
            btn_doimatkhau.Size = new Size(275, 90);
            btn_doimatkhau.TabIndex = 6;
            btn_doimatkhau.Text = "Đổi Mật Khẩu";
            btn_doimatkhau.TextAlign = ContentAlignment.MiddleRight;
            btn_doimatkhau.UseVisualStyleBackColor = false;
            btn_doimatkhau.Click += btn_doimatkhau_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(166, 29);
            label4.Name = "label4";
            label4.Size = new Size(342, 57);
            label4.TabIndex = 7;
            label4.Text = "Đặt Lại Mật Khẩu";
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.BackColor = Color.Black;
            btn_dangnhap.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_dangnhap.ForeColor = Color.Orange;
            btn_dangnhap.Image = Properties.Resources.profile;
            btn_dangnhap.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dangnhap.Location = new Point(41, 480);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Padding = new Padding(20, 0, 20, 0);
            btn_dangnhap.Size = new Size(264, 90);
            btn_dangnhap.TabIndex = 8;
            btn_dangnhap.Text = "Đăng Nhập";
            btn_dangnhap.TextAlign = ContentAlignment.MiddleRight;
            btn_dangnhap.UseVisualStyleBackColor = false;
            btn_dangnhap.Click += btn_dangnhap_Click;
            // 
            // DatLaiMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Skyline;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(647, 596);
            Controls.Add(btn_dangnhap);
            Controls.Add(label4);
            Controls.Add(btn_doimatkhau);
            Controls.Add(txt_matkhaumoi);
            Controls.Add(txt_matkhaucu);
            Controls.Add(txt_tennguoidung);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "DatLaiMatKhau";
            Text = "DatLaiMatKhau";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_tennguoidung;
        private TextBox txt_matkhaucu;
        private TextBox txt_matkhaumoi;
        private Button btn_doimatkhau;
        private Label label4;
        private Button btn_dangnhap;
    }
}