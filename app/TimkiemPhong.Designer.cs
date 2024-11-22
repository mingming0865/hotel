namespace Hoang_Duc_Hung___Do_an_ki_thuat_lap_trinh
{
    partial class TimkiemPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gv_ketqua = new System.Windows.Forms.DataGridView();
            this.maPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhtrangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_tinhtrang = new System.Windows.Forms.CheckBox();
            this.cb_loaip = new System.Windows.Forms.CheckBox();
            this.cbb_tinhtrang = new System.Windows.Forms.ComboBox();
            this.cbb_loai = new System.Windows.Forms.ComboBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_Timkiem = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ketqua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gv_ketqua);
            this.groupBox2.Location = new System.Drawing.Point(17, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(850, 264);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết quả tìm kiếm";
            // 
            // gv_ketqua
            // 
            this.gv_ketqua.AutoGenerateColumns = false;
            this.gv_ketqua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_ketqua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_ketqua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPDataGridViewTextBoxColumn,
            this.tenPDataGridViewTextBoxColumn,
            this.loaiPDataGridViewTextBoxColumn,
            this.giaPDataGridViewTextBoxColumn,
            this.tinhtrangDataGridViewTextBoxColumn});
            this.gv_ketqua.DataSource = this.phongBindingSource;
            this.gv_ketqua.Location = new System.Drawing.Point(18, 24);
            this.gv_ketqua.Name = "gv_ketqua";
            this.gv_ketqua.Size = new System.Drawing.Size(794, 220);
            this.gv_ketqua.TabIndex = 0;
            // 
            // maPDataGridViewTextBoxColumn
            // 
            this.maPDataGridViewTextBoxColumn.DataPropertyName = "MaP";
            this.maPDataGridViewTextBoxColumn.HeaderText = "Mã phòng";
            this.maPDataGridViewTextBoxColumn.Name = "maPDataGridViewTextBoxColumn";
            // 
            // tenPDataGridViewTextBoxColumn
            // 
            this.tenPDataGridViewTextBoxColumn.DataPropertyName = "TenP";
            this.tenPDataGridViewTextBoxColumn.HeaderText = "Tên phòng";
            this.tenPDataGridViewTextBoxColumn.Name = "tenPDataGridViewTextBoxColumn";
            // 
            // loaiPDataGridViewTextBoxColumn
            // 
            this.loaiPDataGridViewTextBoxColumn.DataPropertyName = "LoaiP";
            this.loaiPDataGridViewTextBoxColumn.HeaderText = "Loại phòng";
            this.loaiPDataGridViewTextBoxColumn.Name = "loaiPDataGridViewTextBoxColumn";
            // 
            // giaPDataGridViewTextBoxColumn
            // 
            this.giaPDataGridViewTextBoxColumn.DataPropertyName = "GiaP";
            this.giaPDataGridViewTextBoxColumn.HeaderText = "Giá phòng";
            this.giaPDataGridViewTextBoxColumn.Name = "giaPDataGridViewTextBoxColumn";
            // 
            // tinhtrangDataGridViewTextBoxColumn
            // 
            this.tinhtrangDataGridViewTextBoxColumn.DataPropertyName = "Tinhtrang";
            this.tinhtrangDataGridViewTextBoxColumn.HeaderText = "Tình trạng";
            this.tinhtrangDataGridViewTextBoxColumn.Name = "tinhtrangDataGridViewTextBoxColumn";
            // 
            // phongBindingSource
            // 
            this.phongBindingSource.DataSource = typeof(Hoang_Duc_Hung___Do_an_ki_thuat_lap_trinh.Phong);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "TÌM KIẾM THÔNG TIN KHÁCH HÀNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_tinhtrang);
            this.groupBox1.Controls.Add(this.cb_loaip);
            this.groupBox1.Controls.Add(this.cbb_tinhtrang);
            this.groupBox1.Controls.Add(this.cbb_loai);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_Timkiem);
            this.groupBox1.Location = new System.Drawing.Point(17, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 142);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // cb_tinhtrang
            // 
            this.cb_tinhtrang.AutoSize = true;
            this.cb_tinhtrang.Location = new System.Drawing.Point(53, 84);
            this.cb_tinhtrang.Name = "cb_tinhtrang";
            this.cb_tinhtrang.Size = new System.Drawing.Size(196, 25);
            this.cb_tinhtrang.TabIndex = 6;
            this.cb_tinhtrang.Text = "Theo tình trạng phòng";
            this.cb_tinhtrang.UseVisualStyleBackColor = true;
            // 
            // cb_loaip
            // 
            this.cb_loaip.AutoSize = true;
            this.cb_loaip.Location = new System.Drawing.Point(53, 35);
            this.cb_loaip.Name = "cb_loaip";
            this.cb_loaip.Size = new System.Drawing.Size(151, 25);
            this.cb_loaip.TabIndex = 6;
            this.cb_loaip.Text = "Theo loại phòng";
            this.cb_loaip.UseVisualStyleBackColor = true;
            // 
            // cbb_tinhtrang
            // 
            this.cbb_tinhtrang.FormattingEnabled = true;
            this.cbb_tinhtrang.Items.AddRange(new object[] {
            "Trống",
            "Có khách"});
            this.cbb_tinhtrang.Location = new System.Drawing.Point(284, 82);
            this.cbb_tinhtrang.Name = "cbb_tinhtrang";
            this.cbb_tinhtrang.Size = new System.Drawing.Size(360, 29);
            this.cbb_tinhtrang.TabIndex = 5;
            // 
            // cbb_loai
            // 
            this.cbb_loai.FormattingEnabled = true;
            this.cbb_loai.Items.AddRange(new object[] {
            "Đơn thường",
            "Đôi thường",
            "Ba thường",
            "VIP đơn",
            "VIP đôi",
            "VIP ba"});
            this.cbb_loai.Location = new System.Drawing.Point(284, 33);
            this.cbb_loai.Name = "cbb_loai";
            this.cbb_loai.Size = new System.Drawing.Size(360, 29);
            this.cbb_loai.TabIndex = 5;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(690, 81);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(122, 37);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_Timkiem
            // 
            this.btn_Timkiem.Location = new System.Drawing.Point(690, 24);
            this.btn_Timkiem.Name = "btn_Timkiem";
            this.btn_Timkiem.Size = new System.Drawing.Size(122, 37);
            this.btn_Timkiem.TabIndex = 3;
            this.btn_Timkiem.Text = "Tìm kiếm";
            this.btn_Timkiem.UseVisualStyleBackColor = true;
            this.btn_Timkiem.Click += new System.EventHandler(this.btn_Timkiem_Click);
            // 
            // TimkiemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TimkiemPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimkiemPhong";
            this.Load += new System.EventHandler(this.TimkiemPhong_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_ketqua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phongBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gv_ketqua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_Timkiem;
        private System.Windows.Forms.BindingSource phongBindingSource;
        private System.Windows.Forms.ComboBox cbb_loai;
        private System.Windows.Forms.ComboBox cbb_tinhtrang;
        private System.Windows.Forms.CheckBox cb_tinhtrang;
        private System.Windows.Forms.CheckBox cb_loaip;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhtrangDataGridViewTextBoxColumn;
    }
}