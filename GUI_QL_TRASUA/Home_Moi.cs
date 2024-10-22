﻿using DOAN_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI_QL_TRASUA
{
    public partial class Home_Moi : Form
    {
        public Home_Moi(string username1, string quyen1)
        {
            InitializeComponent();
            username = username1;
            quyen = quyen1;
        }

        string username;
        string quyen;

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Form3 form3 = new Form3();

            //form3.TopLevel = false;
            //form3.FormBorderStyle = FormBorderStyle.None;
            //form3.Dock = DockStyle.Fill;

            //panel2.Controls.Clear();
            //panel2.Controls.Add(form3);
            //form3.Show();

            NhanVien nhanvien = new NhanVien(username, quyen);
            nhanvien.TopLevel = false;
            nhanvien.FormBorderStyle = FormBorderStyle.None;
            nhanvien.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(nhanvien);
            nhanvien.Show();

        }

        private void Home_Moi_Load(object sender, EventArgs e)
        {
            lbl_username.Text = username;
            lbl_quyen.Text = quyen;

            menuNhanVienToolStripMenuItem.Visible = false;
            menuSanPhamToolStripMenuItem.Visible = false;
            menuThongKeToolStripMenuItem.Visible = false;

            if (quyen == "Admin")
            {
                menuNhanVienToolStripMenuItem.Visible = true;
                menuSanPhamToolStripMenuItem.Visible = true;
                menuThongKeToolStripMenuItem.Visible = true;
            }
        }

        private void menuSanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SanPhamMoi sanphammoi = new SanPhamMoi();
            sanphammoi.TopLevel = false;
            sanphammoi.FormBorderStyle = FormBorderStyle.None;
            sanphammoi.Dock = DockStyle.Fill;

            panel1.Controls.Clear();
            panel1.Controls.Add(sanphammoi);
            sanphammoi.Show();
        }
    }
}