namespace GUI_QL_TRASUA
{
    partial class Home_Moi
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
            menuStrip1 = new MenuStrip();
            menuOrderToolStripMenuItem = new ToolStripMenuItem();
            menuCN_NhanVienToolStripMenuItem1 = new ToolStripMenuItem();
            menuXemKhachHangToolStripMenuItem = new ToolStripMenuItem();
            menuXemHoaDonToolStripMenuItem = new ToolStripMenuItem();
            menuXemChiTietHoaDonToolStripMenuItem = new ToolStripMenuItem();
            menuThoatToolStripMenuItem = new ToolStripMenuItem();
            menuNhanVienToolStripMenuItem = new ToolStripMenuItem();
            menuSanPhamToolStripMenuItem = new ToolStripMenuItem();
            menuThongKeToolStripMenuItem = new ToolStripMenuItem();
            menuKhuyenMaiToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label1 = new Label();
            lbl_username = new Label();
            lbl_quyen = new Label();
            label4 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuOrderToolStripMenuItem, menuCN_NhanVienToolStripMenuItem1, menuNhanVienToolStripMenuItem, menuSanPhamToolStripMenuItem, menuThongKeToolStripMenuItem, menuKhuyenMaiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(986, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuOrderToolStripMenuItem
            // 
            menuOrderToolStripMenuItem.ForeColor = Color.DarkBlue;
            menuOrderToolStripMenuItem.Name = "menuOrderToolStripMenuItem";
            menuOrderToolStripMenuItem.Size = new Size(75, 29);
            menuOrderToolStripMenuItem.Text = "Order";
            menuOrderToolStripMenuItem.Click += menuOrderToolStripMenuItem_Click;
            // 
            // menuCN_NhanVienToolStripMenuItem1
            // 
            menuCN_NhanVienToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { menuXemKhachHangToolStripMenuItem, menuXemHoaDonToolStripMenuItem, menuXemChiTietHoaDonToolStripMenuItem, menuThoatToolStripMenuItem });
            menuCN_NhanVienToolStripMenuItem1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            menuCN_NhanVienToolStripMenuItem1.ForeColor = Color.DarkBlue;
            menuCN_NhanVienToolStripMenuItem1.Name = "menuCN_NhanVienToolStripMenuItem1";
            menuCN_NhanVienToolStripMenuItem1.Size = new Size(161, 29);
            menuCN_NhanVienToolStripMenuItem1.Text = "Chức năng khác";
            // 
            // menuXemKhachHangToolStripMenuItem
            // 
            menuXemKhachHangToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            menuXemKhachHangToolStripMenuItem.Name = "menuXemKhachHangToolStripMenuItem";
            menuXemKhachHangToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D1;
            menuXemKhachHangToolStripMenuItem.Size = new Size(348, 30);
            menuXemKhachHangToolStripMenuItem.Text = "Xem Khách Hàng";
            menuXemKhachHangToolStripMenuItem.Click += menuXemKhachHangToolStripMenuItem_Click;
            // 
            // menuXemHoaDonToolStripMenuItem
            // 
            menuXemHoaDonToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            menuXemHoaDonToolStripMenuItem.Name = "menuXemHoaDonToolStripMenuItem";
            menuXemHoaDonToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D2;
            menuXemHoaDonToolStripMenuItem.Size = new Size(348, 30);
            menuXemHoaDonToolStripMenuItem.Text = "Xem Hóa Đơn";
            menuXemHoaDonToolStripMenuItem.Click += menuXemHoaDonToolStripMenuItem_Click;
            // 
            // menuXemChiTietHoaDonToolStripMenuItem
            // 
            menuXemChiTietHoaDonToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            menuXemChiTietHoaDonToolStripMenuItem.Name = "menuXemChiTietHoaDonToolStripMenuItem";
            menuXemChiTietHoaDonToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.D3;
            menuXemChiTietHoaDonToolStripMenuItem.Size = new Size(348, 30);
            menuXemChiTietHoaDonToolStripMenuItem.Text = "Xem Chi Tiết Hóa Đơn";
            menuXemChiTietHoaDonToolStripMenuItem.Click += menuXemChiTietHoaDonToolStripMenuItem_Click;
            // 
            // menuThoatToolStripMenuItem
            // 
            menuThoatToolStripMenuItem.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            menuThoatToolStripMenuItem.Name = "menuThoatToolStripMenuItem";
            menuThoatToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            menuThoatToolStripMenuItem.Size = new Size(348, 30);
            menuThoatToolStripMenuItem.Text = "Thoát";
            menuThoatToolStripMenuItem.Click += ThoatToolStripMenuItem_Click;
            // 
            // menuNhanVienToolStripMenuItem
            // 
            menuNhanVienToolStripMenuItem.ForeColor = Color.DarkBlue;
            menuNhanVienToolStripMenuItem.Name = "menuNhanVienToolStripMenuItem";
            menuNhanVienToolStripMenuItem.Size = new Size(115, 29);
            menuNhanVienToolStripMenuItem.Text = "Nhân Viên";
            menuNhanVienToolStripMenuItem.Click += NhanVienToolStripMenuItem_Click;
            // 
            // menuSanPhamToolStripMenuItem
            // 
            menuSanPhamToolStripMenuItem.ForeColor = Color.DarkBlue;
            menuSanPhamToolStripMenuItem.Name = "menuSanPhamToolStripMenuItem";
            menuSanPhamToolStripMenuItem.Size = new Size(110, 29);
            menuSanPhamToolStripMenuItem.Text = "Sản Phẩm";
            menuSanPhamToolStripMenuItem.Click += menuSanPhamToolStripMenuItem_Click;
            // 
            // menuThongKeToolStripMenuItem
            // 
            menuThongKeToolStripMenuItem.ForeColor = Color.DarkBlue;
            menuThongKeToolStripMenuItem.Name = "menuThongKeToolStripMenuItem";
            menuThongKeToolStripMenuItem.Size = new Size(106, 29);
            menuThongKeToolStripMenuItem.Text = "Thống Kê";
            menuThongKeToolStripMenuItem.Click += menuThongKeToolStripMenuItem_Click;
            // 
            // menuKhuyenMaiToolStripMenuItem
            // 
            menuKhuyenMaiToolStripMenuItem.ForeColor = Color.DarkBlue;
            menuKhuyenMaiToolStripMenuItem.Name = "menuKhuyenMaiToolStripMenuItem";
            menuKhuyenMaiToolStripMenuItem.Size = new Size(126, 29);
            menuKhuyenMaiToolStripMenuItem.Text = "Khuyến Mãi";
            menuKhuyenMaiToolStripMenuItem.Click += menuKhuyenMaiToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.White;
            panel1.Location = new Point(32, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(924, 516);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Image = Properties.Resources.user_small;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(32, 50);
            label1.Name = "label1";
            label1.Size = new Size(136, 28);
            label1.TabIndex = 2;
            label1.Text = "UserName:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.BackColor = Color.Transparent;
            lbl_username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_username.ForeColor = Color.White;
            lbl_username.Location = new Point(174, 50);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(137, 28);
            lbl_username.TabIndex = 3;
            lbl_username.Text = "nguyenvanteo";
            // 
            // lbl_quyen
            // 
            lbl_quyen.AutoSize = true;
            lbl_quyen.BackColor = Color.Transparent;
            lbl_quyen.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_quyen.ForeColor = Color.White;
            lbl_quyen.Location = new Point(755, 50);
            lbl_quyen.Name = "lbl_quyen";
            lbl_quyen.Size = new Size(83, 28);
            lbl_quyen.TabIndex = 5;
            lbl_quyen.Text = "ông chủ";
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Image = Properties.Resources.quyen_small;
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(656, 50);
            label4.Name = "label4";
            label4.Size = new Size(97, 28);
            label4.TabIndex = 4;
            label4.Text = "Quyền:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Home_Moi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Skyline;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(986, 642);
            Controls.Add(lbl_quyen);
            Controls.Add(label4);
            Controls.Add(lbl_username);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MainMenuStrip = menuStrip1;
            Name = "Home_Moi";
            Text = "Home_Moi";
            WindowState = FormWindowState.Maximized;
            Load += Home_Moi_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuCN_NhanVienToolStripMenuItem1;
        private ToolStripMenuItem menuXemKhachHangToolStripMenuItem;
        private ToolStripMenuItem menuXemHoaDonToolStripMenuItem;
        private ToolStripMenuItem menuXemChiTietHoaDonToolStripMenuItem;
        private ToolStripMenuItem menuThoatToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem menuNhanVienToolStripMenuItem;
        private ToolStripMenuItem menuSanPhamToolStripMenuItem;
        private ToolStripMenuItem menuThongKeToolStripMenuItem;
        private Label label1;
        private Label lbl_username;
        private Label lbl_quyen;
        private Label label4;
        private ToolStripMenuItem menuOrderToolStripMenuItem;
        private ToolStripMenuItem menuKhuyenMaiToolStripMenuItem;
    }
}