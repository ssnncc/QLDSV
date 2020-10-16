using QLDSV.Model;
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
    public partial class Diem : Form
    {
        String maKhoa = "";
        public Diem()
        {
            InitializeComponent();
        }

        private void Diem_Load(object sender, EventArgs e)
        {

            this.dS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
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
            txtMaMH.Text = cmbTenMH.SelectedValue.ToString();
        }

        private void cmbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenLop.SelectedValue != null)
            {
                txtMaLop.Text = cmbTenLop.SelectedValue.ToString();
            }
        }

        private void cmbTenMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenMH.SelectedValue != null)
            {
                txtMaMH.Text = cmbTenMH.SelectedValue.ToString();
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
                    //txtMaLop.Text = cmbTenLop.SelectedValue.ToString();
                }
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cmbKhoa.Enabled = true;
            panel1.Enabled = true;
            btnBD.Enabled = true;
            btnGhi.Enabled = false;
        }
        private List<BangdiemView> bangDiemViews;
        private List<BangdiemView> GetData()
        {
            SqlCommand sqlCommand = Program.conn.CreateCommand();
            if (Program.conn.State == ConnectionState.Closed)
            {
                Program.conn.Open();

            }
            sqlCommand.CommandText = "DanhSachSinhVien";//Chứa chuỗi try vấn cần thực thi
            sqlCommand.CommandType = CommandType.StoredProcedure;//Xác minh cần thực hiện truy vấn hay gọi SP

            sqlCommand.Parameters.Add(new SqlParameter("MALOP", txtMaLop.Text));
            sqlCommand.Parameters.Add(new SqlParameter("LAN", Convert.ToInt32(cmbLanThi.SelectedIndex + 1)));
            sqlCommand.Parameters.Add(new SqlParameter("MAMH", txtMaMH.Text));
            //Danh sách tham số được sử dụng trong truy vấn 
            var result = sqlCommand.ExecuteReader();

            var tmps = new List<BangdiemView>();
            while (result.Read())
            {
                tmps.Add(new BangdiemView
                {
                    Diem = Convert.ToDecimal(result["DIEM"]),
                    HoTen = result["HOTEN"].ToString(),
                    MASV = result["MASV"].ToString()

                });
            }
            result.Close();
            return tmps;

        }
        private void RefreshBangDiem()
        {
            bangDiemViews = GetData();
            dgrSinhVien.DataSource = bangDiemViews;

        }


        private void btnBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ( cmbLanThi.SelectedIndex < 0) return;

            btnGhi.Enabled = true;
            RefreshBangDiem();

        }
        private void dgrSinhVien_KeyPress(object sender, KeyPressEventArgs e)
        {
            var text = sender as TextBox;

            if (text == null) return;

            if (!string.IsNullOrEmpty(text.Text) && e.KeyChar == '.')
            {
                if (text.Text.Contains('.'))
                {
                    e.Handled = true;
                }
                else e.Handled = false;
            }
            else
            {
                if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                    if (char.IsDigit(e.KeyChar))
                    {
                        var temp = Convert.ToDecimal(text.Text + e.KeyChar);
                        if (temp < 0 || temp > 10)
                        {
                            e.Handled = true;
                        }
                    }

                }
                else e.Handled = true;
            }
        }


        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            int LANTHI = cmbLanThi.SelectedIndex + 1;

            string MAMH = txtMaMH.Text;
            List<BangdiemView> LstDiem = new List<BangdiemView>();
            for (int i = 0; i < dgrSinhVien.RowCount; i++)
            {
                string masv = dgrSinhVien.Rows[i].Cells[0].Value.ToString();
                decimal diem = Convert.ToDecimal(dgrSinhVien.Rows[i].Cells[2].Value);
                BangdiemView bangdiem = new BangdiemView();
                bangdiem.MASV = masv;
                bangdiem.Diem = diem;
                LstDiem.Add(bangdiem);
            }
            var databangdiem = GetData();

            SqlCommand sqlCommand = Program.conn.CreateCommand();
            for (int i = 0; i < LstDiem.Count; i++)
            {

                if (databangdiem[i].Diem != LstDiem[i].Diem)
                {
                    if (databangdiem[i].Diem == -1)
                    {
                        string sql = "INSERT INTO [dbo].[DIEM] (MASV,MAMH,LAN,DIEM) VALUES('" + LstDiem[i].MASV + "','" + MAMH + "','" + LANTHI + "','" + bangDiemViews[i].Diem + "');";
                        sqlCommand.CommandText = sql;
                        sqlCommand.ExecuteNonQuery();
                    }
                    else
                    {
                        string sql = "update [dbo].[DIEM] set DIEM='" + bangDiemViews[i].Diem + "' where MASV='" + LstDiem[i].MASV + "' and LAN='" + LANTHI + "' and MAMH='" + MAMH + "';";
                        sqlCommand.CommandText = sql;
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            btnBD.Enabled = true;
            btnGhi.Enabled = false;
        }

       
    }
}
