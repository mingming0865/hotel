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
    public partial class TimkiemPhong : Form
    {
        public TimkiemPhong()
        {
            InitializeComponent();
        }
        QLTPDataContext db = new QLTPDataContext();
        private void TimkiemPhong_Load(object sender, EventArgs e)
        {
            
            
            
        }
            List<Phong> list = new List<Phong>();
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Timkiem_Click(object sender, EventArgs e)
        {
            if (cb_loaip.Checked == true && cb_tinhtrang.Checked == false)
            {
                var query1 = (from phong in db.Phongs
                             where phong.LoaiP == cbb_loai.Text
                             select phong);
                list = query1.ToList<Phong>();
            }
            else if (cb_loaip.Checked == true && cb_tinhtrang.Checked == true)
            {
                var query2 = (from phong in db.Phongs
                              where phong.LoaiP == cbb_loai.Text && phong.Tinhtrang == cbb_tinhtrang.Text
                             select phong);
                list = query2.ToList<Phong>();
            }
            else 
            {
                var query3 = (from phong in db.Phongs
                              where phong.Tinhtrang == cbb_tinhtrang.Text
                              select phong);
                list = query3.ToList<Phong>();
            }
            phongBindingSource.DataSource = list;
        }

        
    }
}
