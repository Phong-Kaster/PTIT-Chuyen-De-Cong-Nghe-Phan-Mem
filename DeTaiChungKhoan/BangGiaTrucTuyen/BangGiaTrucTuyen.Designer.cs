
namespace BangGiaTrucTuyen
{
    partial class BangGiaTrucTuyen
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
            this.chungKhoanDataSet1 = new BangGiaTrucTuyen.ChungKhoanDataSet();
            this.bangGiaTrucTuyenBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bangGiaTrucTuyenTableAdapter1 = new BangGiaTrucTuyen.ChungKhoanDataSetTableAdapters.BangGiaTrucTuyenTableAdapter();
            this.tableAdapterManager1 = new BangGiaTrucTuyen.ChungKhoanDataSetTableAdapters.TableAdapterManager();
            this.bangGiaTrucTuyenDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chungKhoanDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangGiaTrucTuyenBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangGiaTrucTuyenDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chungKhoanDataSet1
            // 
            this.chungKhoanDataSet1.DataSetName = "ChungKhoanDataSet";
            this.chungKhoanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bangGiaTrucTuyenBindingSource1
            // 
            this.bangGiaTrucTuyenBindingSource1.DataMember = "BangGiaTrucTuyen";
            this.bangGiaTrucTuyenBindingSource1.DataSource = this.chungKhoanDataSet1;
            // 
            // bangGiaTrucTuyenTableAdapter1
            // 
            this.bangGiaTrucTuyenTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.BangGiaTrucTuyenTableAdapter = this.bangGiaTrucTuyenTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = BangGiaTrucTuyen.ChungKhoanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bangGiaTrucTuyenDataGridView1
            // 
            this.bangGiaTrucTuyenDataGridView1.AutoGenerateColumns = false;
            this.bangGiaTrucTuyenDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangGiaTrucTuyenDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28,
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30,
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32});
            this.bangGiaTrucTuyenDataGridView1.DataSource = this.bangGiaTrucTuyenBindingSource1;
            this.bangGiaTrucTuyenDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bangGiaTrucTuyenDataGridView1.Location = new System.Drawing.Point(0, 0);
            this.bangGiaTrucTuyenDataGridView1.Name = "bangGiaTrucTuyenDataGridView1";
            this.bangGiaTrucTuyenDataGridView1.RowHeadersWidth = 56;
            this.bangGiaTrucTuyenDataGridView1.RowTemplate.Height = 24;
            this.bangGiaTrucTuyenDataGridView1.Size = new System.Drawing.Size(762, 504);
            this.bangGiaTrucTuyenDataGridView1.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "MaCoPhieu";
            this.dataGridViewTextBoxColumn17.HeaderText = "MaCoPhieu";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 135;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "GiaMua3";
            this.dataGridViewTextBoxColumn18.HeaderText = "GiaMua3";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 135;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "SoLuongMua3";
            this.dataGridViewTextBoxColumn19.HeaderText = "SoLuongMua3";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 135;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "GiaMua2";
            this.dataGridViewTextBoxColumn20.HeaderText = "GiaMua2";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 135;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "SoLuongMua2";
            this.dataGridViewTextBoxColumn21.HeaderText = "SoLuongMua2";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 135;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "GiaMua1";
            this.dataGridViewTextBoxColumn22.HeaderText = "GiaMua1";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 135;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "SoLuongMua1";
            this.dataGridViewTextBoxColumn23.HeaderText = "SoLuongMua1";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 135;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "GiaBan1";
            this.dataGridViewTextBoxColumn24.HeaderText = "GiaBan1";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 135;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "SoLuongBan1";
            this.dataGridViewTextBoxColumn25.HeaderText = "SoLuongBan1";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Width = 135;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "GiaBan2";
            this.dataGridViewTextBoxColumn26.HeaderText = "GiaBan2";
            this.dataGridViewTextBoxColumn26.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.Width = 135;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "SoLuongBan2";
            this.dataGridViewTextBoxColumn27.HeaderText = "SoLuongBan2";
            this.dataGridViewTextBoxColumn27.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.Width = 135;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "GiaBan3";
            this.dataGridViewTextBoxColumn28.HeaderText = "GiaBan3";
            this.dataGridViewTextBoxColumn28.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Width = 135;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "SoLuongBan3";
            this.dataGridViewTextBoxColumn29.HeaderText = "SoLuongBan3";
            this.dataGridViewTextBoxColumn29.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.Width = 135;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "GiaKhop";
            this.dataGridViewTextBoxColumn30.HeaderText = "GiaKhop";
            this.dataGridViewTextBoxColumn30.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.Width = 135;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.DataPropertyName = "SoLuongKhop";
            this.dataGridViewTextBoxColumn31.HeaderText = "SoLuongKhop";
            this.dataGridViewTextBoxColumn31.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.Width = 135;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.DataPropertyName = "TongSo";
            this.dataGridViewTextBoxColumn32.HeaderText = "TongSo";
            this.dataGridViewTextBoxColumn32.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.Width = 135;
            // 
            // BangGiaTrucTuyen
            // 
            this.ClientSize = new System.Drawing.Size(762, 504);
            this.Controls.Add(this.bangGiaTrucTuyenDataGridView1);
            this.Name = "BangGiaTrucTuyen";
            this.Load += new System.EventHandler(this.BangGiaTrucTuyen_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.chungKhoanDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangGiaTrucTuyenBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bangGiaTrucTuyenDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BangGiaTrucTuyen.ChungKhoanDataSet chungKhoanDataSet;
        private System.Windows.Forms.BindingSource bangGiaTrucTuyenBindingSource;
        private BangGiaTrucTuyen.ChungKhoanDataSetTableAdapters.BangGiaTrucTuyenTableAdapter bangGiaTrucTuyenTableAdapter;
        private BangGiaTrucTuyen.ChungKhoanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
        private BangGiaTrucTuyen.ChungKhoanDataSet chungKhoanDataSet1;
        private System.Windows.Forms.BindingSource bangGiaTrucTuyenBindingSource1;
        private BangGiaTrucTuyen.ChungKhoanDataSetTableAdapters.BangGiaTrucTuyenTableAdapter bangGiaTrucTuyenTableAdapter1;
        private BangGiaTrucTuyen.ChungKhoanDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView bangGiaTrucTuyenDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
    }
}