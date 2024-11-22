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
    public partial class QL_ThuePhong : Form
    {
        public QL_ThuePhong()
        {
            InitializeComponent();
        }
        QLTPDataContext db = new QLTPDataContext();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void ShowPhong()
        {
            List<Phong> list = new List<Phong>();
            var query = (from n in db.Phongs
                         where n.Tinhtrang == "Trống"
                         select n);
            list = query.ToList<Phong>();
            phongBindingSource.DataSource = list;
        }

        public void ShowKhach()
        {
            List<Khach> list = new List<Khach>();
            var query = (from n in db.Khaches
                         select n);
            list = query.ToList<Khach>();
            khachBindingSource.DataSource = list;
        }
        private void QL_ThuePhong_Load(object sender, EventArgs e)
        {
            ShowPhong();
            ShowKhach();
            btn_chonp.Enabled = false;
                btn_thue.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Phong> list = new List<Phong>();
            var query2 = (from phong in db.Phongs
                          where phong.LoaiP == cbb_loaip.Text && phong.Tinhtrang == "Trống"
                          select phong);
            list = query2.ToList<Phong>();
            phongBindingSource.DataSource = list;
        }

        private void khachDataGridView_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btn_chonk_Click(object sender, EventArgs e)
        {
            thuePBindingSource.AddNew();
            thuePDataGridView.CurrentRow.Cells[1].Value = khachDataGridView.CurrentRow.Cells[0].Value.ToString();
            btn_chonk.Enabled = false;
            btn_chonp.Enabled = true;
        }

        private void btn_chonp_Click(object sender, EventArgs e)
        {
            //btn_chonp.Enabled = false;
            btn_thue.Enabled = true;
            try
            {
                if (thuePDataGridView.CurrentRow.Cells[2].Value != null)
                {
                    thuePBindingSource.AddNew();
                    thuePDataGridView.CurrentRow.Cells[1].Value = khachDataGridView.CurrentRow.Cells[0].Value.ToString();
                }
                thuePDataGridView.CurrentRow.Cells[2].Value = phongDataGridView.CurrentRow.Cells[0].Value.ToString();
                thuePDataGridView.CurrentRow.Cells[3].Value = DateTime.Now.Date;
            }
            catch
            {
                MessageBox.Show("Chưa chọn khách hàng", "Thông báo");
            }
            finally
            {
                phongBindingSource.RemoveCurrent();
            }
        }

        private void btn_thue_Click(object sender, EventArgs e)
        {

            if (txt_tennv.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nhân viên", "Lỗi");
            }
            else
            {
                for (int i = 0; i < thuePDataGridView.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = thuePDataGridView.Rows[i];
                    thuePDataGridView.Rows[i].Cells[5].Value = txt_tennv.Text;
                    ThueP thuep = new ThueP();
                    thuep.CMT = row.Cells[1].Value.ToString();
                    thuep.MaP = row.Cells[2].Value.ToString();
                    thuep.Ngayden = DateTime.Now.Date;
                    thuep.TenNV = txt_tennv.Text;
                    db.ThuePs.InsertOnSubmit(thuep);
                    Phong phong = db.Phongs.FirstOrDefault(s => s.MaP == row.Cells[2].Value.ToString());
                    phong.Tinhtrang = "Có khách";
                }
            }
            try
            {
                db.SubmitChanges();
                MessageBox.Show("Thuê phòng thành công", "Thuê phòng");
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý", "Thuê phòng");
            }
            finally
            {
                btn_chonk.Enabled = true;
                btn_thue.Enabled = false;
                thuePBindingSource.DataSource = null;
                txt_tennv.Text = "";
            }
        }

        private void btn_themk_Click(object sender, EventArgs e)
        {
            if (btn_themk.Text == "Thêm khách")
            {
                btn_chonk.Enabled = false;
                
                btn_themk.Text = "Cập nhật bảng";
                QL_Khach khach = new QL_Khach();
                khach.ShowDialog();
            }
            else
            {
                khachBindingSource.DataSource = null;
                ShowKhach();
                btn_themk.Text = "Thêm khách";
                btn_chonk.Enabled = true;
            }
        }

        private void txt_cmt_TextChanged(object sender, EventArgs e)
        {
            var query = (from n in db.Khaches
                         where n.CMT.Contains(txt_cmt.Text)
                         select n);
            khachBindingSource.DataSource = query.ToList<Khach>();
        }
    }
}
