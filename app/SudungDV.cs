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
    public partial class SudungDV : Form
    {
        public SudungDV()
        {
            InitializeComponent();
        }
        public void Show_TreeView()
        {
            tv_khach.Nodes.Clear();
            var query_cha = (from kh in db.Khaches
                             select kh);
            List<Khach> khg = new List<Khach>();
            khg = query_cha.ToList<Khach>();
            for (int i = 0; i < khg.Count - 1; i++)
            {
                tv_khach.Nodes.Add(khg[i].CMT, khg[i].Hoten);
                string cmt = khg[i].CMT;
                var query_con = (from tp in db.ThuePs
                                 where tp.CMT == cmt && tp.Ngaydi == null
                                 select tp);
                List<ThueP> tpg = new List<ThueP>();
                tpg = query_con.ToList<ThueP>();
                for (int j = 0; j < tpg.Count - 1; j++)
                {
                    var query = (from ph in db.Phongs
                                 where ph.MaP == tpg[j].MaP
                                 select ph);
                    List<Phong> phong = new List<Phong>();
                    phong = query.ToList<Phong>();
                    tv_khach.Nodes[i].Nodes.Add(phong[0].MaP, phong[0].TenP);
                }
            }
        }
        public void Show_DV()
        {
            var query = (from n in db.Dichvus
                         select n);
            dichvuBindingSource.DataSource = query.ToList<Dichvu>();
        }
        QLTPDataContext db;
     
        private void SudungDV_Load(object sender, EventArgs e)
        {
            db = new QLTPDataContext();
            Show_TreeView();
            Show_DV();
        }
        public void Show_theokh()
        {
            var query = (from n in db.SDDVs
                         where n.CMT == tv_khach.SelectedNode.Name
                         select n);
            sDDVBindingSource.DataSource = query.ToList();
        }
        public void Show_theoph()
        {
            var query = (from n in db.SDDVs
                         where n.CMT == tv_khach.SelectedNode.Parent.Name && n.MaP == tv_khach.SelectedNode.Name
                         select n);
            sDDVBindingSource.DataSource = query.ToList();
        }
        private void tv_khach_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tv_khach.SelectedNode.Level == 0)
            {
                Show_theokh();
            }
            else
            {
                Show_theoph();
            }
        }

        public bool ktra_sluong(string sl)
        {
            int a;
            if (int.TryParse(sl, out a) == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void lock_control(bool gt)
        {
            btn_them.Enabled = gt;
            btn_sua.Enabled = gt;
            btn_xoa.Enabled = gt;
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            if (tv_khach.SelectedNode.Level == 0)
            {
                MessageBox.Show("Bạn phải chọn phòng muốn sử dụng dịch vụ", "Thông báo");
            }
                else
            {
                if (btn_them.Text == "Thêm")
                {
                    btn_them.Text = "Lưu";
                    var query = (from n in  db.SDDVs
                                 where n.CMT == tv_khach.SelectedNode.Parent.Name.ToString() && n.MaDV == dichvuDataGridView.CurrentRow.Cells[0].Value.ToString() && n.MaP == tv_khach.SelectedNode.Name.ToString()
                                 select n).SingleOrDefault();
                    if(query == null)
                    {
                        sDDVBindingSource.AddNew();
                        sDDVDataGridView.BeginEdit(true);
                        lock_control(false);
                        btn_them.Enabled = true;
                        string input = "";
                        while (ktra_sluong(input) == false)
                        {
                            input = Microsoft.VisualBasic.Interaction.InputBox("Nhập vào số lượng dịch vụ.(Phải là một số nguyên)", "Số lượng");
                        }
                        sDDVDataGridView.CurrentRow.Cells[3].Value = input;
                        sDDVDataGridView.CurrentRow.Cells[1].Value = tv_khach.SelectedNode.Parent.Name.ToString();
                        sDDVDataGridView.CurrentRow.Cells[2].Value = dichvuDataGridView.CurrentRow.Cells[0].Value.ToString();
                        sDDVDataGridView.CurrentRow.Cells[4].Value = DateTime.Now.Date;
                        sDDVDataGridView.CurrentRow.Cells[5].Value = tv_khach.SelectedNode.Name.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Dịch vụ này đã được sử dụng trước đó. Vui lòng chọn sửa để thêm số lượng");
                        btn_them.Text = "Thêm";
                        lock_control(true);
                    }
                }
                else
                {
                    sDDVBindingSource.EndEdit();
                    try
                    {
                        SDDV dv = new SDDV();
                        dv.CMT = tv_khach.SelectedNode.Parent.Name.ToString();
                        dv.MaDV = dichvuDataGridView.CurrentRow.Cells[0].Value.ToString();
                        dv.MaP = tv_khach.SelectedNode.Name.ToString();
                        dv.NgaySD = DateTime.Now.Date;
                        dv.Soluong = int.Parse(sDDVDataGridView.CurrentRow.Cells[3].Value.ToString());
                        db.SDDVs.InsertOnSubmit(dv);
                        db.SubmitChanges();
                        MessageBox.Show("Thêm dịch vụ mới thành công", "Thêm dịch vụ");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lưu lỗi");
                    }
                    btn_them.Text = "Thêm";
                    lock_control(true);
                }
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn xóa ?", "Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                var query = (from n in db.SDDVs
                             where n.MaHDDV == int.Parse(sDDVDataGridView.CurrentRow.Cells[0].Value.ToString())
                             select n).SingleOrDefault();
                if (query != null)
                {
                    db.SDDVs.DeleteOnSubmit(query);
                    db.SubmitChanges();
                    sDDVBindingSource.RemoveCurrent();
                    MessageBox.Show("Xóa thành công", "Xóa");
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //if (tv_khach.SelectedNode.Level == 0)
            //{
            //    MessageBox.Show("Bạn phải chọn phòng muốn sử dụng dịch vụ", "Thông báo");
            //}
            //else
            //{
                if (btn_sua.Text == "Sửa")
                {
                    btn_sua.Text = "Lưu";
                    lock_control(false);
                    btn_sua.Enabled = true;
                }
                else
                {
                    try
                    {
                        SDDV dv = db.SDDVs.FirstOrDefault(s => s.MaHDDV == int.Parse(sDDVDataGridView.CurrentRow.Cells[0].Value.ToString()));
                        dv.Soluong = int.Parse(sDDVDataGridView.CurrentRow.Cells[3].Value.ToString());
                        db.SubmitChanges();
                        MessageBox.Show("Sửa thành công", "Sửa");
                    }
                    catch( Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi");
                    }
                    btn_sua.Text = "Sửa";
                    lock_control(true);
                }
            //}
        }
    }
}
