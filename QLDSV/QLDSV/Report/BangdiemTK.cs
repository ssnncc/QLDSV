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
    public partial class BangdiemTK : Form
    {
        String maKhoa = "";
        public BangdiemTK()
        {
            InitializeComponent();
        }

        private void BangdiemTK_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
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
            txtMaLop.Text = cmbTenLop.SelectedValue.ToString();

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
                    //txtMaLop.Text = cmbTenLop.SelectedValue.ToString();
                }
            }
        }

        private void cmbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenLop.SelectedValue != null)
            {
                txtMaLop.Text = cmbTenLop.SelectedValue.ToString();

            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            Xrpt_BangDiemTongKet rpt = new Xrpt_BangDiemTongKet(cmbTenLop.SelectedValue.ToString());
            rpt.lblLOP.Text = cmbTenLop.Text;
            int width = rpt.xrPivotGrid1.ActualWidth;
            int widthMainPage = width + 230;
            rpt.PageWidth = widthMainPage;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
