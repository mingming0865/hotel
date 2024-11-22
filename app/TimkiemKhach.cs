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
    public partial class TimkiemKhach : Form
    {
        
        public TimkiemKhach()
        {
            InitializeComponent();
        }

        QLTPDataContext db;

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            if (rbt_cmt.Checked == true)
            {
                var query = (from n in db.Khaches
                             where n.CMT == txt_input.Text
                             select n);
                khachBindingSource.DataSource = query.ToList<Khach>();
            }
            else
            {
                var query = (from n in db.Khaches
                             where n.Hoten.Contains(txt_input.Text)
                             select n);
                khachBindingSource.DataSource = query.ToList<Khach>();
            }
        }

        private void TimkiemKhach_Load(object sender, EventArgs e)
        {
            db = new QLTPDataContext();
            
            
        }
    }
}
