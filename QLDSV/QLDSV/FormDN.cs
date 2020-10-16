using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class FormDN : Form
    {
        public FormDN()
        {
            InitializeComponent();
        }

        private void FormDN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ds_PM.V_DS_PHANMANH' table. You can move, or remove it, as needed.
            this.v_DS_PHANMANHTableAdapter.Fill(this.ds_PM.V_DS_PHANMANH);
            cmbCN.SelectedIndex = 1;//Loại bỏ cái phân mảnh ảo
            cmbCN.SelectedIndex = 0;

        }

        private void cmbCN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCN.SelectedValue != null)
            {
                Program.servername = cmbCN.SelectedValue.ToString();//Lấy giá trị từ cmb
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtTK.Text.Trim() == "" || txtMK.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu trống", "Lỗi đăng nhập", MessageBoxButtons.OK);
                txtMK.Focus();
                return;
            }
            Program.mlogin = txtTK.Text;
            Program.password = txtMK.Text;
            if (Program.KetNoi() == 0) return;
            Program.mKhoa = cmbCN.SelectedIndex;
            Program.bds_dspm = bds_dsPM;

            Program.mloginDN = Program.mlogin;
            Program.passwordDN = Program.password;

            string strLenh = "EXEC SP_DANGNHAP '" + Program.mlogin + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;//Truy vấn ko đc, kết thúc ct
            Program.mKhoa = cmbCN.SelectedIndex;
            if (Program.myReader.Read())//Đọc 1 dòng
            {
                Program.username = Program.myReader.GetString(0);     // Đọc dữ liệu cột đầu tiên (user)
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show("Login bạn nhập không có quyền truy cập dữ liệu\n Bạn xem lại username, password", "", MessageBoxButtons.OK);
                    return;
                }
                Program.mHoten = Program.myReader.GetString(1); //Đọc dữ liệu cột thứ 2
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();
                Program.conn.Close();
            }

            // truy cập vào from Main  (frm đăng nhập --> frm Main)
            Program.frmChinh = new Main();

            Program.frmChinh.MaGV.Text = " Mã giảng viên : " + Program.username;
            Program.frmChinh.HoTen.Text = " Họ tên : " + Program.mHoten;
            Program.frmChinh.Khoa.Text = " Nhóm : " + Program.mGroup;

            MessageBox.Show("Đăng nhập thành công.", " ", MessageBoxButtons.OK);

            // frmChinh hien
            Program.frmChinh.Show();
            // frmDN ẩn
            Program.formDN.Visible = false;
            Program.frmChinh.enableButton();//set hiện các btn : điêm, Lop, MonHOc
            
            if (Program.mGroup == "PKTOAN")
            {
                Program.frmChinh.unEnableButton();// Không cho phòng kế toán làm việc với lớp, điểm,...
                Program.frmChinh.barButtonHP.Enabled = true;
                Program.frmChinh.barButtonDSDHP.Enabled = true;
                Program.frmChinh.barBtnTaologin.Enabled = true;
            }
            if (Program.mGroup == "KHOA")
            {
                Program.frmChinh.barButtonHP.Enabled = false;
                Program.frmChinh.barButtonDSDHP.Enabled = false;
            }
            if (Program.mGroup == "PGV")
            {
                Program.frmChinh.barButtonHP.Enabled = false;
                Program.frmChinh.barButtonDSDHP.Enabled = false;
            }
        }
       //SelectedIndexChanged: đây là 1 biến cố khi ta chọn 1 gtri mới trong ds, khi nó chạy sẽ lấy ra đc server name mới

    }
}
