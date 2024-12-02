namespace GUI_QL_TRASUA
{
    partial class Login
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
            txt_username = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_password = new TextBox();
            btn_dangnhap = new Button();
            pictureBox1 = new PictureBox();
            btn_dangky = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 45F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(64, 26);
            label1.Name = "label1";
            label1.Padding = new Padding(10);
            label1.Size = new Size(460, 120);
            label1.TabIndex = 1;
            label1.Text = "Đăng Nhập";
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txt_username.ForeColor = SystemColors.HotTrack;
            txt_username.Location = new Point(29, 224);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(654, 41);
            txt_username.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 168);
            label2.Name = "label2";
            label2.Size = new Size(132, 35);
            label2.TabIndex = 3;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(29, 286);
            label3.Name = "label3";
            label3.Size = new Size(125, 35);
            label3.TabIndex = 5;
            label3.Text = "Password:";
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txt_password.ForeColor = SystemColors.HotTrack;
            txt_password.Location = new Point(29, 342);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(654, 41);
            txt_password.TabIndex = 4;
            // 
            // btn_dangnhap
            // 
            btn_dangnhap.BackColor = Color.Black;
            btn_dangnhap.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_dangnhap.ForeColor = Color.Orange;
            btn_dangnhap.Image = Properties.Resources.profile;
            btn_dangnhap.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dangnhap.Location = new Point(29, 416);
            btn_dangnhap.Name = "btn_dangnhap";
            btn_dangnhap.Padding = new Padding(20, 0, 20, 0);
            btn_dangnhap.Size = new Size(264, 82);
            btn_dangnhap.TabIndex = 6;
            btn_dangnhap.Text = "Đăng Nhập";
            btn_dangnhap.TextAlign = ContentAlignment.MiddleRight;
            btn_dangnhap.UseVisualStyleBackColor = false;
            btn_dangnhap.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.latte_art;
            pictureBox1.Location = new Point(555, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 128);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // btn_dangky
            // 
            btn_dangky.BackColor = Color.Black;
            btn_dangky.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btn_dangky.ForeColor = Color.Orange;
            btn_dangky.Image = Properties.Resources.profile;
            btn_dangky.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dangky.Location = new Point(419, 416);
            btn_dangky.Name = "btn_dangky";
            btn_dangky.Padding = new Padding(20, 0, 20, 0);
            btn_dangky.Size = new Size(264, 82);
            btn_dangky.TabIndex = 11;
            btn_dangky.Text = "Đăng Ký";
            btn_dangky.TextAlign = ContentAlignment.MiddleRight;
            btn_dangky.UseVisualStyleBackColor = false;
            btn_dangky.Click += btn_dangky_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(326, 454);
            panel1.Name = "panel1";
            panel1.Size = new Size(59, 7);
            panel1.TabIndex = 10;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Skyline;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(724, 530);
            Controls.Add(btn_dangky);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(btn_dangnhap);
            Controls.Add(label3);
            Controls.Add(txt_password);
            Controls.Add(label2);
            Controls.Add(txt_username);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txt_username;
        private Label label2;
        private Label label3;
        private TextBox txt_password;
        private Button btn_dangnhap;
        private PictureBox pictureBox1;
        private Button btn_dangky;
        private Panel panel1;
    }
}