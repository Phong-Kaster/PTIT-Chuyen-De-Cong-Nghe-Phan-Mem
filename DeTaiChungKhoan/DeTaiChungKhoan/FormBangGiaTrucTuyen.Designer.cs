
namespace DeTaiChungKhoan
{
    partial class FormBangGiaTrucTuyen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBangGiaTrucTuyen));
            this.chungKhoanDataSet = new DeTaiChungKhoan.ChungKhoanDataSet();
            this.bangGiaTrucTuyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bangGiaTrucTuyenTableAdapter = new DeTaiChungKhoan.ChungKhoanDataSetTableAdapters.BangGiaTrucTuyenTableAdapter();
            this.tableAdapterManager = new DeTaiChungKhoan.ChungKhoanDataSetTableAdapters.TableAdapterManager();
            this.bangGiaTrucTuyenDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chungKhoanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangGiaTrucTuyenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangGiaTrucTuyenDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // chungKhoanDataSet
            // 
            this.chungKhoanDataSet.DataSetName = "ChungKhoanDataSet";
            this.chungKhoanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangGiaTrucTuyenBindingSource
            // 
            this.bangGiaTrucTuyenBindingSource.DataMember = "BangGiaTrucTuyen";
            this.bangGiaTrucTuyenBindingSource.DataSource = this.chungKhoanDataSet;
            // 
            // bangGiaTrucTuyenTableAdapter
            // 
            this.bangGiaTrucTuyenTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BangGiaTrucTuyenTableAdapter = this.bangGiaTrucTuyenTableAdapter;
            this.tableAdapterManager.LenhDatTableAdapter = null;
            this.tableAdapterManager.LenhKhopTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DeTaiChungKhoan.ChungKhoanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bangGiaTrucTuyenDataGridView
            // 
            this.bangGiaTrucTuyenDataGridView.AutoGenerateColumns = false;
            this.bangGiaTrucTuyenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangGiaTrucTuyenDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.bangGiaTrucTuyenDataGridView.DataSource = this.bangGiaTrucTuyenBindingSource;
            this.bangGiaTrucTuyenDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bangGiaTrucTuyenDataGridView.Location = new System.Drawing.Point(0, 0);
            this.bangGiaTrucTuyenDataGridView.Name = "bangGiaTrucTuyenDataGridView";
            this.bangGiaTrucTuyenDataGridView.ReadOnly = true;
            this.bangGiaTrucTuyenDataGridView.RowHeadersWidth = 56;
            this.bangGiaTrucTuyenDataGridView.RowTemplate.Height = 24;
            this.bangGiaTrucTuyenDataGridView.Size = new System.Drawing.Size(1100, 401);
            this.bangGiaTrucTuyenDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaCoPhieu";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Cổ Phiếu";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "GiaMua1";
            this.dataGridViewTextBoxColumn2.HeaderText = "Giá Mua 1";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 80;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SoLuongMua1";
            this.dataGridViewTextBoxColumn3.HeaderText = "Lượng Mua 1";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 95;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GiaMua2";
            this.dataGridViewTextBoxColumn4.HeaderText = "Giá Mua 2";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SoLuongMua2";
            this.dataGridViewTextBoxColumn5.HeaderText = "Lượng Mua 2";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 95;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GiaMua3";
            this.dataGridViewTextBoxColumn6.HeaderText = "Giá Mua 3";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "SoLuongMua3";
            this.dataGridViewTextBoxColumn7.HeaderText = "Lượng Mua 3";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 95;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "GiaBan1";
            this.dataGridViewTextBoxColumn8.HeaderText = "Giá Bán 1";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "SoLuongBan1";
            this.dataGridViewTextBoxColumn9.HeaderText = "Lượng Bán 1";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 95;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "GiaBan2";
            this.dataGridViewTextBoxColumn10.HeaderText = "Giá Bán 2";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 80;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "SoLuongBan2";
            this.dataGridViewTextBoxColumn11.HeaderText = "Lượng Bán 2";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 95;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "GiaBan3";
            this.dataGridViewTextBoxColumn12.HeaderText = "Giá Bán 3";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 80;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "SoLuongBan3";
            this.dataGridViewTextBoxColumn13.HeaderText = "Lượng Bán 3";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 95;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "GiaKhop";
            this.dataGridViewTextBoxColumn14.HeaderText = "Giá Khớp";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 70;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "SoLuongKhop";
            this.dataGridViewTextBoxColumn15.HeaderText = "Lượng Khớp";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 90;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "TongSo";
            this.dataGridViewTextBoxColumn16.HeaderText = "Tổng Số";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 70;
            // 
            // FormBangGiaTrucTuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 401);
            this.Controls.Add(this.bangGiaTrucTuyenDataGridView);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FormBangGiaTrucTuyen.IconOptions.Image")));
            this.Name = "FormBangGiaTrucTuyen";
            this.Text = "Bảng Giá Trực Tuyến";
            this.Load += new System.EventHandler(this.FormBangGiaTrucTuyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chungKhoanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangGiaTrucTuyenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangGiaTrucTuyenDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChungKhoanDataSet chungKhoanDataSet;
        private System.Windows.Forms.BindingSource bangGiaTrucTuyenBindingSource;
        private ChungKhoanDataSetTableAdapters.BangGiaTrucTuyenTableAdapter bangGiaTrucTuyenTableAdapter;
        private ChungKhoanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView bangGiaTrucTuyenDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
    }
}