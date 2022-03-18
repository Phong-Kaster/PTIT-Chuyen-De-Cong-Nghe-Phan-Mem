using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Windows.Forms;

namespace BangGia
{
    public partial class FormBangGia : DevExpress.XtraEditors.XtraForm
    {
        private int changeCount = 0;
        private const String tableName = "BangGiaTrucTuyen";

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

        private String GetSQL()
        {
            return "select GiaMua1,SoLuongMua1," +
                "       GiaMua2,SoLuongMua2," +
                "       GiaMua3,SoLuongMua3," +
                "       GiaKhop,SoLuongKhop," +
                "       GiaBan1,SoLuongBan1," +
                "       GiaBan2,SoLuongBan2," +
                "       GiaBan3,SoLuongBan3," +
                "       TongSo, MaCoPhieu" +
                " from dbo.BangGiaTrucTuyen";
        }

        public FormBangGia()
        {
            InitializeComponent();
        }

        private void bangGiaTrucTuyenBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bangGiaTrucTuyenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.chungKhoanDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'chungKhoanDataSet.BangGiaTrucTuyen' table. You can move, or remove it, as needed.
            this.bangGiaTrucTuyenTableAdapter.Fill(this.chungKhoanDataSet.BangGiaTrucTuyen);
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
                this.bangGiaTrucTuyenDataGridView.AutoGenerateColumns = false;
                this.bangGiaTrucTuyenDataGridView.DataSource = dataToWatch;
                this.bangGiaTrucTuyenDataGridView.DataMember = tableName;
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
