
namespace DeTaiChungKhoan
{
    partial class FormLenhDat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLenhDat));
            this.chungKhoanDataSet = new DeTaiChungKhoan.ChungKhoanDataSet();
            this.lenhDatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lenhDatTableAdapter = new DeTaiChungKhoan.ChungKhoanDataSetTableAdapters.LenhDatTableAdapter();
            this.tableAdapterManager = new DeTaiChungKhoan.ChungKhoanDataSetTableAdapters.TableAdapterManager();
            this.lenhDatDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chungKhoanDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenhDatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenhDatDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // chungKhoanDataSet
            // 
            this.chungKhoanDataSet.DataSetName = "ChungKhoanDataSet";
            this.chungKhoanDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lenhDatBindingSource
            // 
            this.lenhDatBindingSource.DataMember = "LenhDat";
            this.lenhDatBindingSource.DataSource = this.chungKhoanDataSet;
            // 
            // lenhDatTableAdapter
            // 
            this.lenhDatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BangGiaTrucTuyenTableAdapter = null;
            this.tableAdapterManager.LenhDatTableAdapter = this.lenhDatTableAdapter;
            this.tableAdapterManager.LenhKhopTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DeTaiChungKhoan.ChungKhoanDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lenhDatDataGridView
            // 
            this.lenhDatDataGridView.AutoGenerateColumns = false;
            this.lenhDatDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lenhDatDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.lenhDatDataGridView.DataSource = this.lenhDatBindingSource;
            this.lenhDatDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lenhDatDataGridView.Location = new System.Drawing.Point(0, 0);
            this.lenhDatDataGridView.Name = "lenhDatDataGridView";
            this.lenhDatDataGridView.RowHeadersWidth = 56;
            this.lenhDatDataGridView.RowTemplate.Height = 24;
            this.lenhDatDataGridView.Size = new System.Drawing.Size(1005, 496);
            this.lenhDatDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaCoPhieu";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaCoPhieu";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 135;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NgayDat";
            this.dataGridViewTextBoxColumn2.HeaderText = "NgayDat";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 135;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LoaiGiaoDich";
            this.dataGridViewTextBoxColumn3.HeaderText = "LoaiGiaoDich";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 135;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "LoaiLenh";
            this.dataGridViewTextBoxColumn4.HeaderText = "LoaiLenh";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 135;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SoLuong";
            this.dataGridViewTextBoxColumn5.HeaderText = "SoLuong";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 135;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GiaDat";
            this.dataGridViewTextBoxColumn6.HeaderText = "GiaDat";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 135;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TrangThai";
            this.dataGridViewTextBoxColumn7.HeaderText = "TrangThai";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 135;
            // 
            // FormLenhDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 496);
            this.Controls.Add(this.lenhDatDataGridView);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FormLenhDat.IconOptions.Image")));
            this.Name = "FormLenhDat";
            this.Text = "Bảng Lệnh Đặt";
            this.Load += new System.EventHandler(this.FormLenhDat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chungKhoanDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenhDatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenhDatDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ChungKhoanDataSet chungKhoanDataSet;
        private System.Windows.Forms.BindingSource lenhDatBindingSource;
        private ChungKhoanDataSetTableAdapters.LenhDatTableAdapter lenhDatTableAdapter;
        private ChungKhoanDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView lenhDatDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}