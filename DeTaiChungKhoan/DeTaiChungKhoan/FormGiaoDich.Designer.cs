
namespace DeTaiChungKhoan
{
    partial class FormGiaoDich
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaCoPhieu = new DevExpress.XtraEditors.TextEdit();
            this.cbLoaiGiaoDich = new System.Windows.Forms.ComboBox();
            this.btnGiaoDich = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.txtGiaDat = new DevExpress.XtraEditors.SpinEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLenhDat = new System.Windows.Forms.Button();
            this.btnBangGiaTrucTuyen = new System.Windows.Forms.Button();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCoPhieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaDat.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Cổ Phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(362, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại Giao Dịch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(752, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(752, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá Đặt";
            // 
            // txtMaCoPhieu
            // 
            this.txtMaCoPhieu.EditValue = "Panther";
            this.txtMaCoPhieu.Location = new System.Drawing.Point(544, 68);
            this.txtMaCoPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCoPhieu.Name = "txtMaCoPhieu";
            this.txtMaCoPhieu.Size = new System.Drawing.Size(135, 24);
            this.txtMaCoPhieu.TabIndex = 4;
            // 
            // cbLoaiGiaoDich
            // 
            this.cbLoaiGiaoDich.FormattingEnabled = true;
            this.cbLoaiGiaoDich.Items.AddRange(new object[] {
            "M",
            "B"});
            this.cbLoaiGiaoDich.Location = new System.Drawing.Point(544, 152);
            this.cbLoaiGiaoDich.Name = "cbLoaiGiaoDich";
            this.cbLoaiGiaoDich.Size = new System.Drawing.Size(135, 24);
            this.cbLoaiGiaoDich.TabIndex = 8;
            // 
            // btnGiaoDich
            // 
            this.btnGiaoDich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(194)))), ((int)(((byte)(73)))));
            this.btnGiaoDich.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaoDich.ForeColor = System.Drawing.Color.White;
            this.btnGiaoDich.Location = new System.Drawing.Point(289, 244);
            this.btnGiaoDich.Name = "btnGiaoDich";
            this.btnGiaoDich.Size = new System.Drawing.Size(170, 43);
            this.btnGiaoDich.TabIndex = 9;
            this.btnGiaoDich.Text = "Đặt Lệnh";
            this.btnGiaoDich.UseVisualStyleBackColor = false;
            this.btnGiaoDich.Click += new System.EventHandler(this.btnGiaoDich_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(74)))), ((int)(((byte)(69)))));
            this.button2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1025, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 43);
            this.button2.TabIndex = 10;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.EditValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtSoLuong.Location = new System.Drawing.Point(903, 74);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoLuong.Properties.DisplayFormat.FormatString = "n0";
            this.txtSoLuong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoLuong.Properties.EditFormat.FormatString = "n0";
            this.txtSoLuong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoLuong.Properties.Increment = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtSoLuong.Size = new System.Drawing.Size(169, 26);
            this.txtSoLuong.TabIndex = 14;
            // 
            // txtGiaDat
            // 
            this.txtGiaDat.EditValue = new decimal(new int[] {
            26000,
            0,
            0,
            0});
            this.txtGiaDat.Location = new System.Drawing.Point(903, 143);
            this.txtGiaDat.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaDat.Name = "txtGiaDat";
            this.txtGiaDat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtGiaDat.Properties.DisplayFormat.FormatString = "n0";
            this.txtGiaDat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtGiaDat.Properties.EditFormat.FormatString = "n0";
            this.txtGiaDat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtGiaDat.Properties.Increment = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtGiaDat.Size = new System.Drawing.Size(169, 26);
            this.txtGiaDat.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLenhDat);
            this.groupBox1.Controls.Add(this.btnBangGiaTrucTuyen);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtGiaDat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnGiaoDich);
            this.groupBox1.Controls.Add(this.txtMaCoPhieu);
            this.groupBox1.Controls.Add(this.cbLoaiGiaoDich);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1924, 341);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong Tin";
            // 
            // btnLenhDat
            // 
            this.btnLenhDat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(179)))), ((int)(((byte)(179)))));
            this.btnLenhDat.Font = new System.Drawing.Font("Tahoma", 9.969231F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLenhDat.ForeColor = System.Drawing.Color.White;
            this.btnLenhDat.Location = new System.Drawing.Point(760, 244);
            this.btnLenhDat.Name = "btnLenhDat";
            this.btnLenhDat.Size = new System.Drawing.Size(230, 43);
            this.btnLenhDat.TabIndex = 17;
            this.btnLenhDat.Text = "Lệnh Đặt";
            this.btnLenhDat.UseVisualStyleBackColor = false;
            this.btnLenhDat.Visible = false;
            this.btnLenhDat.Click += new System.EventHandler(this.btnLenhDat_Click);
            // 
            // btnBangGiaTrucTuyen
            // 
            this.btnBangGiaTrucTuyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(119)))), ((int)(((byte)(46)))));
            this.btnBangGiaTrucTuyen.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBangGiaTrucTuyen.ForeColor = System.Drawing.Color.White;
            this.btnBangGiaTrucTuyen.Location = new System.Drawing.Point(505, 244);
            this.btnBangGiaTrucTuyen.Name = "btnBangGiaTrucTuyen";
            this.btnBangGiaTrucTuyen.Size = new System.Drawing.Size(230, 43);
            this.btnBangGiaTrucTuyen.TabIndex = 16;
            this.btnBangGiaTrucTuyen.Text = "Bảng Giá Trực Tuyến";
            this.btnBangGiaTrucTuyen.UseVisualStyleBackColor = false;
            this.btnBangGiaTrucTuyen.Visible = false;
            this.btnBangGiaTrucTuyen.Click += new System.EventHandler(this.btnBangGiaTrucTuyen_Click);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // FormGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 551);
            this.Controls.Add(this.groupBox1);
            this.IsMdiContainer = true;
            this.Name = "FormGiaoDich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao Dịch";
            this.Load += new System.EventHandler(this.FormGiaoDich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtMaCoPhieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaDat.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtMaCoPhieu;
        private System.Windows.Forms.ComboBox cbLoaiGiaoDich;
        private System.Windows.Forms.Button btnGiaoDich;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraEditors.SpinEdit txtSoLuong;
        private DevExpress.XtraEditors.SpinEdit txtGiaDat;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.Button btnBangGiaTrucTuyen;
        private System.Windows.Forms.Button btnLenhDat;
    }
}