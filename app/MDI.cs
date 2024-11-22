using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;
using System.Data.SqlClient;

namespace Hoang_Duc_Hung___Do_an_ki_thuat_lap_trinh
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        QLTPDataContext db = new QLTPDataContext();
        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menuStrip1.Visible == true)
            {
                if (MessageBox.Show("Bạn có thực sự muốn đăng xuất và thoát khỏi hệ thống?", "Xóa phòng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private void btn_dnhap_Click(object sender, EventArgs e)
        {
            //Tạo truy vấn
            var ktradn = (from Taikhoan in db.Taikhoans
                         where Taikhoan.Acc == txt_tk.Text.Trim() && Taikhoan.Pass == txt_mk.Text
                         select Taikhoan).SingleOrDefault();
            if (ktradn == null) //Câu lệnh điều kiện ktras
            {
                MessageBox.Show("Tài khoản không đúng! Vui lòng nhập lại");
                txt_tk.Text = "";
                txt_mk.Text = ""; 
            }
            else
            {
                Taikhoan tk = db.Taikhoans.FirstOrDefault(s => s.Acc == txt_tk.Text);
                MessageBox.Show("Xin chào " + tk.TenND.ToString() + ". Bạn đã đăng nhập thành công");
                menuStrip1.Visible = true;
                if (txt_tk.Text == "admin")
                {
                    quảnLýTàiKhoảnToolStripMenuItem.Visible = true;
                }
                else
                {
                    quảnLýTàiKhoảnToolStripMenuItem.Visible = false;
                }
                panel1.Visible = false;
            }
        }

        private void quảnLýKháchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Khach khach = new QL_Khach();
            khach.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MDI_Load(object sender, EventArgs e)
        {
            
        }

        private void quảnLýTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Taikhoan tkhoan = new QL_Taikhoan();
            tkhoan.ShowDialog();
        }

        private void tìmKiếmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimkiemKhach timkhach = new TimkiemKhach();
            timkhach.ShowDialog();
        }

        private void tìmKiếmPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimkiemPhong timphong = new TimkiemPhong();
            timphong.ShowDialog();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Phong phong = new QL_Phong();
            phong.ShowDialog();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
                panel1.Visible = true;
                this.IsMdiContainer = false;
                menuStrip1.Visible = false;
                txt_mk.Text = "";
                txt_tk.Text = "";
        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Traphong tra = new QL_Traphong();
            tra.ShowDialog();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_mk_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_dnhap.PerformClick();
            }
        }

        private void thuêPhòngToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            QL_ThuePhong thue = new QL_ThuePhong();
            thue.ShowDialog();
        }

        private void aboutToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Thongtin about = new Thongtin();
            about.ShowDialog();
        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QL_Dichvu dichvu = new QL_Dichvu();
            dichvu.ShowDialog();
        }

        private void sửDụngDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SudungDV sdungdv = new SudungDV();
            sdungdv.ShowDialog();
        }
    }
}
