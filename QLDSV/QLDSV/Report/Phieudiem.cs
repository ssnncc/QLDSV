using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV.Report
{
    public partial class Phieudiem : Form
    {
        String maKhoa = "";
        public Phieudiem()
        {
            InitializeComponent();
        }

        private void Phieudiem_Load(object sender, EventArgs e)
        {
            this.dS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            maKhoa = ((DataRowView)bdsLOP[0])["MAKH"].ToString();//set  mặc định txtMaKhoa
                                                                 // biding data từ data table vào combobox chi nhánh
            cmbKhoa.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";

            // lệnh này quan trọng... phải bỏ vào. ==> để cho combo box chạy đúng.
            cmbKhoa.SelectedIndex = 1;

            // nếu login vào là khoa cntt, thì combox sẽ hiện khoa cntt
            // nếu login vào là khoa vt, thì combox sẽ hiện khoa vt
            cmbKhoa.SelectedIndex = Program.mKhoa;
            if (Program.mGroup == Program.NhomQuyen[0])
            {
                cmbKhoa.Enabled = true;
            }
            else
            {
                cmbKhoa.Enabled = false;
            }

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue != null)
            {
                if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                    return; // Hệ thống chưa chọn đã chạy => Kết thúc
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
                    dS.EnforceConstraints = false;
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (cmbMaSV.Text.Equals(""))
            {
                MessageBox.Show("Mã sinh viên rỗng !!!");
                return;
            }
            Xrpt_Phieudiem rpt = new Xrpt_Phieudiem(cmbMaSV.Text);
            try
            {
                string strLenh = "EXEC SP_THONGTINSV_ReportPhieuDiem '" + cmbMaSV.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                rpt.lblHoTen.Text = Program.myReader.GetString(0);
                rpt.lblLop.Text = Program.myReader.GetString(2);
                Program.myReader.Close();
                ReportPrintTool print = new ReportPrintTool(rpt);
                print.ShowPreviewDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show("- Không tìm thấy dữ liệu, xem lại mã sinh viên đã nhập \n - Hoặc sinh viên đã nghỉ học \n" + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Program.myReader.Close();
            }
        }
    }
}
