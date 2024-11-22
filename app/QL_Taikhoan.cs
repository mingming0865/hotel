using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;

namespace Hoang_Duc_Hung___Do_an_ki_thuat_lap_trinh
{
    public partial class QL_Taikhoan : Form
    {
        public QL_Taikhoan()
        {
            InitializeComponent();
        }
        QLTPDataContext db;

        private void anhien(bool gt)
        {
            txt_tk.Enabled = gt;
            txt_ten.Enabled = gt;
            txt_mk.Enabled = gt;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (btn_them.Text == "Thêm tài khoản")
            {
                btn_them.Text = "Lưu lại";
                anhien(true);
                taikhoanBindingSource.AddNew();
                taikhoanDataGridView.BeginEdit(true);
                txt_tk.Focus();
            }
            else
            {
                var tkhoan = (from Taikhoan in db.Taikhoans
                              where Taikhoan.Acc == txt_tk.Text.Trim()
                              select Taikhoan).SingleOrDefault();
                if (tkhoan == null)
                {
                    taikhoanBindingSource.EndEdit();
                    Taikhoan tk = new Taikhoan();
                    tk.Acc = txt_tk.Text;
                    tk.Pass = txt_mk.Text;
                    tk.TenND = txt_ten.Text;
                    db.Taikhoans.InsertOnSubmit(tk);
                    db.SubmitChanges();
                    MessageBox.Show("Tạo tài khoản thành công");
                    btn_them.Text = "Thêm tài khoản";
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại");
                    txt_tk.Focus();
                }

            }
        }

        private void QL_Taikhoan_Load(object sender, EventArgs e)
        {
            db = new QLTPDataContext();
            List<Taikhoan> list = new List<Taikhoan>();
            var query = (from n in db.Taikhoans
                         select n);
            list = query.ToList<Taikhoan>();
            taikhoanBindingSource.DataSource = list;
            anhien(false);
            taikhoanDataGridView.ReadOnly = true;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (btn_sua.Text == "Sửa tài khoản")
            {
                btn_sua.Text = "Lưu lại";
                anhien(true);
                txt_tk.Enabled = false;
            }
            else
            {
                Taikhoan tk = db.Taikhoans.FirstOrDefault(s => s.Acc == txt_tk.Text);
                tk.Pass = txt_mk.Text;
                tk.TenND = txt_ten.Text;
                db.SubmitChanges();
                anhien(false);
                MessageBox.Show("Sửa thành công!");
                btn_sua.Text = "Sửa tài khoản";
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa ?", "Xóa tài khoản", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                var query = (from n in db.Taikhoans
                             where n.Acc == txt_tk.Text
                             select n).SingleOrDefault();
                if (query != null)
                {
                    db.Taikhoans.DeleteOnSubmit(query);
                    db.SubmitChanges();
                    taikhoanBindingSource.RemoveCurrent();
                    MessageBox.Show("Xóa thành công", "Xóa tài khoản");
                }
            }
        }
    }
}
