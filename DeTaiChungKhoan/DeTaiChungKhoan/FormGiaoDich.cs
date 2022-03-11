using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeTaiChungKhoan
{
    public partial class FormGiaoDich : Form
    {
        public FormGiaoDich()
        {
            InitializeComponent();
        }

        /**
         * @author Phong-Kaster
         * kiểm tra xem form đã tồn tại trong bộ nhớ chưa ?
         */
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        /**
         * @author Phong-Kaster
         * Step 1: chọn sẵn lệnh là M - ứng với số 0. Lệnh bán là B - ứng với số 1
         * Step 2: kiểm tra xem FormBangGiaTrucTuyen đã có chưa ? Nếu chưa thì 
         * khai báo & gọi nó
         */
        private void FormGiaoDich_Load(object sender, EventArgs e)
        {
            /*Step 1*/
            cbLoaiGiaoDich.SelectedIndex = 0;

            /*Step 2*/
            
        }

        /**
         * @author Phong-Kaster
         * kiểm tra dữ liệu đầu vào
         * đúng hết thì trả về true
         * sai thì trả về false
         */
        private bool kiemTraDuLieuDauVao()
        {
            if( txtMaCoPhieu.Text == "")
            {

                MessageBox.Show("Hãy nhập mã cổ phiểu", "Thông báo", MessageBoxButtons.OK);
                txtMaCoPhieu.Focus();
                return false;
            }

            if (txtSoLuong.Value < 100 || (txtSoLuong.Value) % 100 != 0)
            {
                MessageBox.Show("Số lượng tối thiểu là 100 và chia hết cho 100 ", "Thông báo", MessageBoxButtons.OK);
                txtSoLuong.Focus();
                return false;
            }

            if ( txtGiaDat.Value < 0 )
            {
                MessageBox.Show("Giá đặt tối thiểu là 1", "Thông báo", MessageBoxButtons.OK);
                txtGiaDat.Focus();
                return false;
            }

            return true;
        }

        /**
         * @author Phong-Kaster
         * cài đặt lại các giá trị về ban đầu
         */
        private void reset()
        {
            txtMaCoPhieu.Text = "";
            txtSoLuong.Value = 0;
            txtGiaDat.Value = 0;
        }


        /**
         * @author Phong-Kaster
         * Step 1: kiểm tra dữ liệu đầu vào
         * Step 2: khai báo & gọi các dữ liệu cần thiết
         * Step 3: xử lý dữ liệu với sp_KhopLenhLien
         * Step 4: làm mới các ô nhập dữ liệu để chờ phiên giao dịch mới
         */
        private void btnGiaoDich_Click(object sender, EventArgs e)
        {
            /*Step 1*/

            //this.btnGiaoDich.Enabled = false;
            bool ketQua = kiemTraDuLieuDauVao();
            if( ketQua == false )
            {
                return;
            }


            /*Step 2*/
            string maCoPhieu = txtMaCoPhieu.Text.Trim();
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            string loaiGiaoDich = (string)cbLoaiGiaoDich.SelectedItem;
            
            int soLuong = (int)txtSoLuong.Value;
            float giaDat = (float)txtGiaDat.Value;
            
            /**Step 3*/
            try
            {
                Program.KetNoi();
                string query = "EXEC sp_KhopLenhLienTuc '"+maCoPhieu+"', '" + today + "', '"+loaiGiaoDich+"', " + soLuong + ", " + giaDat;
                Program.myReader = Program.ExecSqlDataReader(query);
                if( Program.myReader == null )
                {
                    return;
                }
                Program.myReader.Read();
                Program.myReader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            /**Step 4*/
            // Không đặt message box ở đây để tránh lỗi bị treo máy
            reset();

        }

        private void button2_Click(object sender, EventArgs e)
        {
             this.Close();
        }
        /**
         * @author Phong-Kaster
         * mở bảng giá trực tuyến
         */
        private void btnBangGiaTrucTuyen_Click(object sender, EventArgs e)
        {
            Form f = this.CheckExists(typeof(FormBangGiaTrucTuyen));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormBangGiaTrucTuyen form = new FormBangGiaTrucTuyen();
                form.MdiParent = this;
                form.Show();
            }
        }
        /**
         * @author Phong-Kaster
         * mở form lệnh đặt
         */
        private void btnLenhDat_Click(object sender, EventArgs e)
        {
           
            Form f = this.CheckExists(typeof(FormLenhDat));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormLenhDat form = new FormLenhDat();
                form.MdiParent = this;
                form.Show();
            }
        }
    }
}
