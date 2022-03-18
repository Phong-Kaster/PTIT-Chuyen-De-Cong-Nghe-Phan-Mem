using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeTaiChungKhoan
{
    public partial class FormLenhDat : DevExpress.XtraEditors.XtraForm
    {
        private int changeCount = 0;
        private const String tableName = "LenhDat";

        private SqlConnection connection = null;
        private SqlCommand command = null;
        private DataSet dataToWatch = null;

        private Boolean CanRequestNotifications()
        {
            try
            {
                SqlClientPermission perm = new SqlClientPermission(PermissionState.Unrestricted);
                perm.Demand();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        /*Tuyệt đối không dùng select * from dbo.LenhDat vì sẽ gây tràn bộ nhớ*/
        private String GetSQL()
        {
            return "select MaCoPhieu," +
                "           NgayDat," +
                "           LoaiGiaoDich, " +
                "           LoaiLenh," +
                "           SoLuong," +
                "           GiaDat," +
                "           TrangThai" +
                " from dbo.LenhDat";
        }

        public FormLenhDat()
        {
            InitializeComponent();
        }

        private void lenhDatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lenhDatBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chungKhoanDataSet);

        }

        private void FormLenhDat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chungKhoanDataSet.LenhDat' table. You can move, or remove it, as needed.
            this.lenhDatTableAdapter.Fill(this.chungKhoanDataSet.LenhDat);
            if (CanRequestNotifications() == true)
            {
                Program.KetNoi();
                BatDau();
            }
            else
            {
                MessageBox.Show("Bạn chưa kích hoạt dịch vụ Broker", "", MessageBoxButtons.OK);
            }
        }

        private void BatDau()
        {
            changeCount = 0;
            SqlDependency.Stop(Program.connectionString);
            try
            {
                SqlDependency.Start(Program.connectionString);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (connection == null)
            {
                connection = new SqlConnection(Program.connectionString);
                connection.Open();
            }
            if (command == null)
            {
                command = new SqlCommand(GetSQL(), connection);
            }

            if (dataToWatch == null)
            {
                dataToWatch = new DataSet();
            }

            GetData();
        }

        private void GetData()
        {
            dataToWatch.Clear();

            command.Notification = null;

            SqlDependency dependency = new SqlDependency(command);
            dependency.OnChange += dependency_OnChange;

            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(dataToWatch, tableName);
                this.lenhDatDataGridView.AutoGenerateColumns = false;
                this.lenhDatDataGridView.DataSource = dataToWatch;
                this.lenhDatDataGridView.DataMember = tableName;
            }
        }

        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            try
            {
                ISynchronizeInvoke i = (ISynchronizeInvoke)this;

                if (i.InvokeRequired)
                {
                    OnChangeEventHandler tempDelegate = new OnChangeEventHandler(dependency_OnChange);

                    object[] args = { sender, e };

                    i.BeginInvoke(tempDelegate, args);
                    return;
                }

                SqlDependency dependency = (SqlDependency)sender;

                dependency.OnChange -= dependency_OnChange;

                changeCount += 1;

                //this.panel.Items.Clear();
                //Console.WriteLine("Info:   " + e.Info.ToString());
                //Console.WriteLine("Source: " + e.Source.ToString());
                //Console.WriteLine("Type:   " + e.Type.ToString());

                GetData();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}