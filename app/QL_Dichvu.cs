using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Linq;
using System.Threading.Tasks;
using System.Xml;
namespace Hoang_Duc_Hung___Do_an_ki_thuat_lap_trinh
{
    public partial class QL_Dichvu : Form
    {
        public QL_Dichvu()
        {
            InitializeComponent();
        }

        public void anhien(Boolean gt)
        {
            txt_ma.Enabled = gt;
            txt_ten.Enabled = gt;
            txt_gia.Enabled = gt;
            txt_dvt.Enabled = gt;
        }

        public void khoacn(Boolean gt)
        {
            btn_sua.Enabled = gt;
            btn_them.Enabled = gt;
            btn_xoa.Enabled = gt;
        }
        public bool ktra_gia(string gia)
        {
            int a;
            if (int.TryParse(txt_gia.Text, out a) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        QLTPDataContext db;
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (btn_them.Text == "Thêm")
            {
                btn_them.Text = "Lưu lại";
                anhien(true);
                dichvuBindingSource.AddNew();
                dichvuDataGridView.BeginEdit(true);
                khoacn(false);
                txt_ma.Focus();
                btn_them.Enabled = true;
            }
            else
            {
                if ((txt_gia.Text != "") && (txt_ma.Text != "") && (txt_ten.Text != "") && (txt_gia.Text != ""))
                {
                    if (ktra_gia(txt_gia.Text) == true)
                    {
                        Khach ktra = (from khach in db.Khaches
                                      where khach.CMT == txt_ma.Text.Trim()
                                      select khach).SingleOrDefault();
                        if (ktra == null)
                        {
                            dichvuBindingSource.EndEdit();
                            Dichvu dv = new Dichvu();
                            dv.MaDV = txt_ma.Text;
                            dv.TenDV = txt_ten.Text;
                            dv.GiaDV = Double.Parse(txt_gia.Text);
                            dv.DVT = txt_dvt.Text;
                            db.Dichvus.InsertOnSubmit(dv);
                            db.SubmitChanges();
                            anhien(false);
                            MessageBox.Show("Thành công!", "Thêm dịch vụ");
                            btn_them.Text = "Thêm";
                            khoacn(true);
                        }
                        else
                        {
                            MessageBox.Show("Mã dịch vụ đã tồn tại. Vui lòng kiểm tra lại");
                            txt_ma.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn phải nhập giá là một số nguyên", "Lỗi");
                        txt_gia.Text = "";
                        txt_gia.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn phải nhập đầy đủ dữ liệu vào", "Lỗi");
                }
            }
            
        }

        private void QL_Dichvu_Load(object sender, EventArgs e)
        {
            anhien(false);
            db = new QLTPDataContext();
            List<Dichvu> list = new List<Dichvu>();
            var query = (from n in db.Dichvus
                         select n);
            list = query.ToList<Dichvu>();
            dichvuBindingSource.DataSource = list;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (btn_sua.Text == "Sửa")
            {
                btn_sua.Text = "Lưu";
                anhien(true);
                txt_ma.Enabled = false;
                khoacn(false);
                btn_sua.Enabled = true;
            }
            else
            {
                if (ktra_gia(txt_gia.Text) == true)
                {
                    Dichvu dvs = db.Dichvus.FirstOrDefault(s => s.MaDV == txt_ma.Text);
                    dvs.TenDV = txt_ten.Text;
                    dvs.GiaDV = Double.Parse(txt_gia.Text);
                    dvs.DVT = txt_dvt.Text;
                    db.SubmitChanges();
                    anhien(false);
                    MessageBox.Show("Sửa thành công!");
                    btn_sua.Text = "Sửa";
                    khoacn(true);
                }
                else
                {
                    MessageBox.Show("Bạn phải nhập giá phòng là một số nguyên", "Lỗi");
                    txt_gia.Text = "";
                    txt_gia.Focus();
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa ?", "Xóa dịch vụ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                var query = (from n in db.SDDVs
                             where n.MaDV == txt_ma.Text
                             select n);
                if (query != null)
                {
                    db.SDDVs.DeleteAllOnSubmit(query);
                }
                Dichvu dv = (from dvu in db.Dichvus
                               where dvu.MaDV == txt_ma.Text
                               select dvu).SingleOrDefault();
                if (dv != null)
                {
                    db.Dichvus.DeleteOnSubmit(dv);
                    db.SubmitChanges();
                    dichvuBindingSource.RemoveCurrent();
                    MessageBox.Show("Xóa thành công", "Xóa dịch vụ");
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
