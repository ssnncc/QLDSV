using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class Dangky : Form
    {
        public Dangky()
        {
            InitializeComponent();
        }

        private void Dangky_Load(object sender, EventArgs e)
        {
             dS.EnforceConstraints = false; // tắt ràng buộc khóa ngoại
            // TODO: This line of code loads data into the 'dS.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);

            // biding data từ data table vào combobox chi nhánh
            cmbKhoa.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";

            // lệnh này quan trọng... phải bỏ vào. ==> để cho combo box chạy đúng.
            cmbKhoa.SelectedIndex = 1;

            // nếu login vào là khoa cntt, thì combox sẽ hiện khoa cntt
            // nếu login vào là khoa vt, thì combox sẽ hiện khoa vt
            cmbKhoa.SelectedIndex = Program.mKhoa;
            // khoa chỉ được quyền đăng ký cho khoa
            if (Program.mGroup == Program.NhomQuyen[1])
            {
                rdoKhoa.Checked = true;
                rdoPGV.Enabled = rdoPKeToan.Enabled = false;
            } // học phí chỉ được quyền đăng ký cho học phí
            else if (Program.mGroup == Program.NhomQuyen[2])
            {
                rdoPKeToan.Checked = true;
                rdoPGV.Enabled = rdoKhoa.Enabled = false;
            }

        }
        // 1: trùng, 0 : not trùng
        private void TaoTaiKhoan()
        {

            String login = txtLogin.Text;
            String pass = txtPass.Text;
            String user = (String)cmbMaGV.SelectedValue.ToString();
            String role = rdoKhoa.Checked ? Program.NhomQuyen[1] : (rdoPGV.Checked ? Program.NhomQuyen[0] : Program.NhomQuyen[2]);

            String subLenh = " EXEC    @return_value = [dbo].[SP_TAOLOGIN] " +

                            " @LGNAME = N'" + login + "', " +
                            " @PASS = N'" + pass + "', " +
                            " @USERNAME = N'" + user + "', " +
                            " @ROLE = N'" + role + "' ";


            // trường hợp tạo tài khoản cho pketoan thì phải dùng LINK1,LINK2 để link tới Site 3 tạo tài khoản cho pKeToan
            if (role == (Program.NhomQuyen[2]) && Program.servername == ((DataRowView)Program.bds_dspm[0])["TENSERVER"].ToString())
            {
                // site 1 ---> sử dụng LINK2
                subLenh = " EXEC    @return_value = LINK2.QLDSV.[dbo].[SP_TAOLOGIN] " +

                            " @LGNAME = N'" + login + "', " +
                            " @PASS = N'" + pass + "', " +
                            " @USERNAME = N'" + user + "', " +
                            " @ROLE = N'" + role + "' ";
            }
            else if (role == (Program.NhomQuyen[2]) && Program.servername == ((DataRowView)Program.bds_dspm[1])["TENSERVER"].ToString())

            {
                subLenh = " EXEC    @return_value = LINK1.QLDSV.[dbo].[SP_TAOLOGIN] " +

                           " @LGNAME = N'" + login + "', " +
                           " @PASS = N'" + pass + "', " +
                           " @USERNAME = N'" + user + "', " +
                           " @ROLE = N'" + role + "' ";
            }

            // trường hợp tạo tài khoản cho chỉ khoa và pgv

            String strLenh = " DECLARE @return_value int " + subLenh +
                         " SELECT  'Return Value' = @return_value ";

            int resultCheckLogin = CheckDataHelper(strLenh);

            if (resultCheckLogin == -1)
            {
                XtraMessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                this.Close();
            }
            if (resultCheckLogin == 1)
            {
                error.SetError(this.txtLogin, "Login bị trùng . Mời bạn nhập login khác !");
            }
            else if (resultCheckLogin == 2)
            {
                error.SetError(this.cmbMaGV, "Giảng viên đã có tài khoản rồi !");

            }
            else if (resultCheckLogin == 3)
            {
                XtraMessageBox.Show("Lỗi thực thi trong cơ sơ dữ liệu !", "", MessageBoxButtons.OK);
            }
            else if (resultCheckLogin == 0)
            {
                XtraMessageBox.Show("Tạo tài khoản thành công !", "", MessageBoxButtons.OK);

            }

            return;
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {

            bool check = this.ValidateInfo();
            if (check)
            {
                TaoTaiKhoan();

            }
            else
            {
                return;
            }
        }
        // true: ko empty, false : empty
        private Boolean isEmptyorNullTextEdits()
        {
            Boolean check = true;


            //check từng textedit

            if (string.IsNullOrEmpty(this.txtLogin.Text))
            {
                error.SetError(this.txtLogin, "Trường dữ liệu không được để trống !");
                check = false;
            }
            if (string.IsNullOrEmpty(this.txtPass.Text))
            {
                error.SetError(this.txtPass, "Trường dữ liệu không được để trống !");
                check = false;
            }

            if (string.IsNullOrEmpty(this.txtConfirm.Text))
            {
                error.SetError(this.txtConfirm, "Trường dữ liệu không được để trống !");
                check = false;
            }


            return check;
        }


        // true: ko empty, false : empty
        private Boolean isEmptyorNullRadioButtons()
        {
            //check từng radiobutton

            if (this.rdoKhoa.Checked || this.rdoPGV.Checked || this.rdoPKeToan.Checked)
            {
                return true;
            }

            error.SetError(this.pnRole, "Bạn chưa chọn nhóm quyền !");

            return false;

        }


        private bool ValidateInfo()
        {
            bool isValid = true;

            // xóa hết thông báo ở error
            error.Clear();


            // check khoảng trống ở textedit
            if (!isEmptyorNullTextEdits())
            {
                isValid = false;
            }


            // check khớp mật khẩu
            if (txtConfirm.Text != txtPass.Text)
            {
                this.error.SetError(txtConfirm, "Mật khẩu không khớp");
                isValid = false;
            }

            // check khoảng trống ở radiobutton
            if (!isEmptyorNullRadioButtons())
            {
                isValid = false;
            }

            // login không được chứa khoảng trống
            if (txtLogin.Text.Contains(" "))
            {
                this.error.SetError(txtLogin, "Tên login không được chứa khoảng trăng !");
                isValid = false;
            }


            return isValid;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dr = XtraMessageBox.Show("Bạn thật sự muốn hủy thao tác đăng ký tài khoản?",
                      "Xác thực", MessageBoxButtons.YesNo);

            if (dr == DialogResult.No)


            {
                return;
            }
            else if (dr == DialogResult.Yes)
            {
                this.Close();

            }
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue != null)
            {
                if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView") return; // Hệ thống chưa chọn đã chạy => Kết thúc
                Program.servername = cmbKhoa.SelectedValue.ToString();
                if (cmbKhoa.SelectedIndex != Program.mKhoa)
                {
                    Program.mlogin = Program.remotelogin;
                    Program.password = Program.remotepassword;
                }
                else
                {
                    Program.mlogin = Program.mloginDN;
                    Program.password = Program.passwordDN;
                }
                if (Program.KetNoi() == 0)
                    MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
                else
                {
                    this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.gIANGVIENTableAdapter.Fill(this.dS.GIANGVIEN);
                    cmbMaGV.DataSource = bdsGV;  // sao chép bds_dspm đã load ở form đăng nhập  qua
                    cmbMaGV.DisplayMember = "MAGV";
                    cmbMaGV.ValueMember = "MAGV";

                }
            }

            }
        public static int CheckDataHelper(String query)
        {
            SqlDataReader dataReader = Program.ExecSqlDataReader(query);

            // nếu null thì thoát luôn  ==> lỗi kết nối
            if (dataReader == null)
            {
                return -1;
            }
            dataReader.Read();
            int result = int.Parse(dataReader.GetValue(0).ToString());
            dataReader.Close();
            return result;
        }
    }
}
