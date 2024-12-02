namespace GUI_QL_TRASUA
{
    partial class DangKy
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
            btn_dangky = new Button();
            label1 = new Label();
            label2 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            label3 = new Label();
            btn_dangnhap = new Button();
            panel1 = new Panel();
            txt_repassword = new TextBox();
            label4 = new Label();
            txt_tennhanvien = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btn_dangky
            // 
            btn_dangky.BackColor = Color.Black;
            btn_dangky.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_dangky.ForeColor = Color.Orange;
            btn_dangky.Image = Properties.Resources.profile;
            btn_dangky.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dangky.Location = new Point(12, 526);
            btn_dangky.Name = "btn_dangky";
            btn_dangky.Padding = new Padding(20, 0, 20, 0);
            btn_dangky.Size = new Size(276, 95);
            btn_dangky.TabIndex = 0;
            btn_dangky.Text = "Đăng Ký";
            btn_dangky.TextAlign = ContentAlignment.MiddleRight;
            btn_dangky.UseVisualStyleBackColor = false;
            btn_dangky.Click += btn_dangky_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(12, 212);
            label1.Name = "label1";
            label1.Size = new Size(132, 35);
            label1.TabIndex = 1;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(12, 314);
            label2.Name = "label2";
            label2.Size = new Size(125, 35);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.ForeColor = SystemColors.HotTrack;
            txt_username.Location = new Point(12, 260);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(700, 41);
            txt_username.TabIndex = 3;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.ForeColor = SystemColors.HotTrack;
            txt_password.Location = new Point(12, 362);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(700, 41);
            txt_password.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 35F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(251, 25);
            label3.Name = "label3";
            label3.Size = new Size(248, 78);
            label3.TabIndex = 5;
            label3.Text = "Đăng Ký";
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.BackColor = Color.Black;
            btn_dangnhap.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_dangnhap.ForeColor = Color.Orange;
            btn_dangnhap.Image = Properties.Resources.profile;
            btn_dangnhap.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dangnhap.Location = new Point(436, 526);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Padding = new Padding(20, 0, 20, 0);
            btn_dangnhap.Size = new Size(276, 95);
            btn_dangnhap.TabIndex = 6;
            btn_dangnhap.Text = "Đăng Nhập";
            btn_dangnhap.TextAlign = ContentAlignment.MiddleRight;
            btn_dangnhap.UseVisualStyleBackColor = false;
            btn_dangnhap.Click += btn_dangnhap_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(328, 570);
            panel1.Name = "panel1";
            panel1.Size = new Size(59, 7);
            panel1.TabIndex = 11;
            // 
            // txt_repassword
            // 
            txt_repassword.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txt_repassword.ForeColor = SystemColors.HotTrack;
            txt_repassword.Location = new Point(12, 464);
            txt_repassword.Name = "txt_repassword";
            txt_repassword.Size = new Size(700, 41);
            txt_repassword.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(12, 416);
            label4.Name = "label4";
            label4.Size = new Size(162, 35);
            label4.TabIndex = 12;
            label4.Text = "Re_Password:";
            // 
            // txt_tennhanvien
            // 
            txt_tennhanvien.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txt_tennhanvien.ForeColor = SystemColors.HotTrack;
            txt_tennhanvien.Location = new Point(12, 158);
            txt_tennhanvien.Name = "txt_tennhanvien";
            txt_tennhanvien.Size = new Size(700, 41);
            txt_tennhanvien.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(12, 110);
            label5.Name = "label5";
            label5.Size = new Size(176, 35);
            label5.TabIndex = 14;
            label5.Text = "Tên Nhân Viên";
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Skyline;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(724, 633);
            Controls.Add(txt_tennhanvien);
            Controls.Add(label5);
            Controls.Add(txt_repassword);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(btn_dangnhap);
            Controls.Add(label3);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_dangky);
            DoubleBuffered = true;
            Name = "DangKy";
            Text = "DangKy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_dangky;
        private Label label1;
        private Label label2;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label label3;
        private Button btn_dangnhap;
        private Panel panel1;
        private TextBox txt_repassword;
        private Label label4;
        private TextBox txt_tennhanvien;
        private Label label5;
    }
}