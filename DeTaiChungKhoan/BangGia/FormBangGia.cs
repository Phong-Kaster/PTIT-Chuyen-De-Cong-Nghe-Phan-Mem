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
    }
}