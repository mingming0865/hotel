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

namespace Hoang_Duc_Hung___Do_an_ki_thuat_lap_trinh
{
    public partial class QL_Phong : Form
    {
        public QL_Phong()
        {
            InitializeComponent();
        }

        public void anhien(Boolean gt)
        {
            txt_map.Enabled = gt;
            txt_ten.Enabled = gt;
            txt_gia.Enabled = gt;
            cbb_loaip.Enabled = gt;
            cbb_tinhtrang.Enabled = gt;
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
                phongBindingSource.AddNew();
                phongDataGridView.BeginEdit(true);
                khoacn(false);
                txt_map.Focus();
                btn_them.Enabled = true;
            }
            else
            {
                if ((txt_gia.Text != "") && (txt_map.Text != "") && (txt_ten.Text != "") && (cbb_loaip.Text != "") && (cbb_tinhtrang.Text != ""))
                {
                    if (ktra_gia(txt_gia.Text) == true)
                    {
                        Khach ktra = (from khach in db.Khaches
                                      where khach.CMT == txt_map.Text.Trim()
                                      select khach).SingleOrDefault();
                        if (ktra == null)
                        {
                            phongBindingSource.EndEdit();
                            Phong phongs = new Phong();
                            phongs.MaP = txt_map.Text;
                            phongs.TenP = txt_ten.Text;
                            phongs.LoaiP = cbb_loaip.Text;
                            phongs.GiaP = int.Parse(txt_gia.Text);
                            phongs.Tinhtrang = cbb_tinhtrang.Text;
                            db.Phongs.InsertOnSubmit(phongs);
                            db.SubmitChanges();
                            anhien(false);
                            MessageBox.Show("Thành công!", "Thêm khách hàng");
                            btn_them.Text = "Thêm";
                            khoacn(true);
                        }
                        else
                        {
                            MessageBox.Show("Mã phòng đã tồn tại. Vui lòng kiểm tra lại");
                            txt_map.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn phải nhập giá phòng là một số nguyên", "Lỗi");
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

        private void QL_Phong_Load(object sender, EventArgs e)
        {
            anhien(false);
            db = new QLTPDataContext();
            List<Phong> list = new List<Phong>();
            var query = (from n in db.Phongs
                         select n);
            list = query.ToList<Phong>();
            phongBindingSource.DataSource = list;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (btn_sua.Text == "Sửa")
            {
                btn_sua.Text = "Lưu";
                anhien(true);
                txt_map.Enabled = false;
                khoacn(false);
                btn_sua.Enabled = true;
            }
            else
            {
                if (ktra_gia(txt_gia.Text) == true)
                {
                    Phong phongs = db.Phongs.FirstOrDefault(s => s.MaP == txt_map.Text);
                    phongs.TenP = txt_ten.Text;
                    phongs.LoaiP = cbb_loaip.Text;
                    phongs.GiaP = int.Parse(txt_gia.Text);
                    phongs.Tinhtrang = cbb_tinhtrang.Text;
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
            if (MessageBox.Show("Bạn có thực sự muốn xóa ?", "Xóa phòng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                var query = (from n in db.ThuePs
                               where n.MaP == txt_map.Text
                               select n);
                if (query != null) //Xóa trong bảng thuê phòng
                {
                    db.ThuePs.DeleteAllOnSubmit(query);
                }
                var dsdv = (from dv in db.SDDVs
                            where dv.MaP == txt_map.Text
                            select dv);
                if (dsdv != null) //Xóa bảng sử dụng dịch vụ
                {
                    db.SDDVs.DeleteAllOnSubmit(dsdv);
                }
                Phong phong = (from Phong in db.Phongs
                                 where Phong.MaP == txt_map.Text
                                 select Phong).SingleOrDefault();
                if (phong != null)
                {
                    db.Phongs.DeleteOnSubmit(phong);
                    db.SubmitChanges();
                    phongBindingSource.RemoveCurrent();
                    MessageBox.Show("Xóa thành công", "Xóa khách hàng");
                }
            }
        }
        private void txt_gia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
