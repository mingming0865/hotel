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
using System.Data.SqlClient;

namespace Hoang_Duc_Hung___Do_an_ki_thuat_lap_trinh
{
    public partial class QL_Traphong : Form
    {
        public QL_Traphong()
        {
            InitializeComponent();
        }
        QLTPDataContext db = new QLTPDataContext();
        private void QL_Traphong_Load(object sender, EventArgs e)
        {
            btn_trap.Enabled = false;
            btn_ttoan.Enabled = false;
            panel1.Visible = false;
        }

        public void Show_Phong(string map)
        {
            List<Phong> phong = new List<Phong>();
            var query = (from n in db.Phongs
                         where n.MaP == map
                         select n);
            phong = query.ToList<Phong>();
            phongBindingSource.DataSource = phong;
        }
        public void Show_Khach(string ten)
        {
            List<Khach> khach = new List<Khach>();
            var query = (from n in db.Khaches
                         where n.Hoten.Contains(ten)
                         select n);
            khach = query.ToList<Khach>();
            khachBindingSource.DataSource = khach;
        }

        public void Show_ThueP(string cmt)
        {
            List<ThueP> thue = new List<ThueP>();
            var query = (from n in db.ThuePs
                         where n.CMT == cmt && n.Ngaydi == null
                         select n);
            thue = query.ToList<ThueP>();
            thuePBindingSource.DataSource = thue;
        }
        private void btn_timtenkh_Click(object sender, EventArgs e)
        {
            Show_Khach(txt_input.Text);
        }

        private void khachDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Show_ThueP(cMTTextBox.Text);;
        }

        private void thuePDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Show_Phong(thuePDataGridView.CurrentRow.Cells[2].Value.ToString());
                btn_trap.Enabled = true;
            }
            catch
            {

            }
        }

        private void btn_trap_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn trả phòng " + txt_tenp.Text+ " không?","Trả phòng",MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                ThueP tra = db.ThuePs.FirstOrDefault(s => s.MaHD == int.Parse(thuePDataGridView.CurrentRow.Cells[0].Value.ToString()));
                tra.Ngaydi = DateTime.Now.Date;
                thuePDataGridView.CurrentRow.Cells[4].Value = DateTime.Now.Date;
                Phong phong = db.Phongs.FirstOrDefault(s => s.TenP == txt_tenp.Text);
                phong.Tinhtrang = "Trống";
                try
                {
                    db.SubmitChanges();
                    thuePBindingSource.MoveNext();
                }
                catch { }
            }
            btn_ttoan.Enabled = true;
        }
        
        Hoadonphong crhoadon = new Hoadonphong();
        Hoadondichvu crhdondv = new Hoadondichvu();
        private void btn_ttoan_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder ctring;
            ctring = new SqlConnectionStringBuilder(Properties.Settings.Default.QLTPConnectionString2);
            //truyền parametter cho hóa đơn dịch vụ
            crhdondv.SetParameterValue(0, khachDataGridView.CurrentRow.Cells[0].Value.ToString());
            crhdondv.SetParameterValue(1, thuePDataGridView.CurrentRow.Cells[3].Value.ToString());
            crhdondv.SetParameterValue(2, thuePDataGridView.CurrentRow.Cells[2].Value.ToString());
            // truyền parametter cho hóa đơn phòng
            crhoadon.SetParameterValue(0, khachDataGridView.CurrentRow.Cells[0].Value.ToString());
            CrystalDecisions.CrystalReports.Engine.Tables tables = crhoadon.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table table in tables)
            {
                CrystalDecisions.Shared.TableLogOnInfo tableLogOnInfo = table.LogOnInfo;
                tableLogOnInfo.ConnectionInfo.ServerName = ctring.DataSource;
                tableLogOnInfo.ConnectionInfo.IntegratedSecurity = ctring.IntegratedSecurity;
                tableLogOnInfo.ConnectionInfo.DatabaseName = ctring.InitialCatalog;
                table.ApplyLogOnInfo(tableLogOnInfo);
            }
            
            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void btn_inhdp_Click(object sender, EventArgs e)
        {
            crhoadon.PrintToPrinter(1, false, 1, 1);
        }

        private void btn_hdonphong_Click(object sender, EventArgs e)
        {
            this.crystalReportViewer1.ReportSource = crhoadon;
        }

        private void btn_hdondvu_Click(object sender, EventArgs e)
        {
            this.crystalReportViewer1.ReportSource = crhdondv;
        }
    }
}
