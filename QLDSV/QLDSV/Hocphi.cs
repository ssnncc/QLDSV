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
    public partial class Hocphi : Form
    {
        public Hocphi()
        {
            InitializeComponent();
        }
       

        private void Hocphi_Load_1(object sender, EventArgs e)
        {

            this.dS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            txtMaLop.Text = cmbTenLop.SelectedValue.ToString();
        }

        private void btnBD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaSV.Text.Equals(""))
            {
                MessageBox.Show("Không được để trống Mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (SqlConnection con = new SqlConnection(Program.connstr))
            {
                using (SqlCommand cmd = new SqlCommand("SP_THONGTINSV"))
                {
                    cmd.Connection = con;
                    con.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@MASV", SqlDbType.Char, 12).Value = txtMaSV.Text;

                    SqlParameter prmt = new SqlParameter();
                    prmt = cmd.Parameters.Add("RETURN_VALUE", SqlDbType.Int);
                    prmt.Direction = ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();
                    int check = (int)cmd.Parameters["return_value"].Value;
                    if (check == 1)
                    {
                        MessageBox.Show("Sinh viên đã nhập không tồn tại !! \n Hoặc Sinh viên đó đã nghỉ học !! ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    con.Close();
                }

            }

            string strLenh = "EXEC SP_THONGTINSV '" + txtMaSV.Text + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            txtHoTen.Text = Program.myReader.GetString(0);
            Program.myReader.Close();

            try
            {
                this.sP_HocphiTableAdapter.Fill(this.dS.SP_Hocphi, txtMaSV.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

       

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            using (SqlConnection con = new SqlConnection(Program.connstr))
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM HOCPHI where masv='000'", con);
                da.InsertCommand = new SqlCommand("[sp_InsertValueHP]", con);
                da.InsertCommand.CommandType = CommandType.StoredProcedure;

                da.InsertCommand.Parameters.Add("@MASV", SqlDbType.Char, 12, "masv");
                da.InsertCommand.Parameters.Add("@NIENKHOA", SqlDbType.NVarChar, 50, "nienkhoa");
                da.InsertCommand.Parameters.Add("@HOCKY", SqlDbType.Int, 10, "hocky");
                da.InsertCommand.Parameters.Add("@HOCPHI", SqlDbType.Int, 20, "hocphi");
                da.InsertCommand.Parameters.Add("@SOTIENDADONG", SqlDbType.Int, 20, "SOTIENDADONG");

                DataSet ds = new DataSet();
                da.Fill(ds, "HOCPHI");
                for (int i = 0; i < gridView1.RowCount; i++)
                {

                    DataRow newRow = ds.Tables["HOCPHI"].NewRow();
                    newRow["masv"] = txtMaSV.Text;

                    newRow["nienkhoa"] = gridView1.GetRowCellValue(i, "NIENKHOA").ToString();

                    int hocky = int.Parse(gridView1.GetRowCellValue(i, "HOCKY").ToString());
                    if (hocky > 0 && hocky < 4)
                    {
                        newRow["hocky"] = gridView1.GetRowCellValue(i, "HOCKY").ToString();
                    }
                    else
                    {
                        MessageBox.Show("Học kỳ chỉ có thể là 1, 2 hoặc 3 !! Vui lòng kiểm tra lại ");
                        return;
                    }
                    int hocphi = int.Parse(gridView1.GetRowCellValue(i, "HOCPHI").ToString());
                    if (hocphi < 0)
                    {
                        MessageBox.Show("Học phí phải lớn hơn 0 VND !! Vui lòng kiểm tra lại ");
                        return;
                    }
                    else
                    {
                        newRow["hocphi"] = gridView1.GetRowCellValue(i, "HOCPHI").ToString();
                    }
                    int sotiendadong = int.Parse(gridView1.GetRowCellValue(i, "SOTIENDADONG").ToString());
                    if (sotiendadong == hocphi || sotiendadong == 0)
                    {
                        newRow["SOTIENDADONG"] = gridView1.GetRowCellValue(i, "SOTIENDADONG").ToString();

                    }
                    else
                    {
                        MessageBox.Show("Số tiền đã đóng phải bằng học phí hoặc bằng 0 VNĐ !! Vui lòng kiểm tra lại ");
                        return;
                    }
                    ds.Tables["HOCPHI"].Rows.Add(newRow);
                }

                da.Update(ds, "HOCPHI");
                con.Close();
                btnGhi.Enabled = false;
                btnBD.Enabled = true;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void cmbTenLop_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (cmbTenLop.SelectedValue != null)
            {
                txtMaLop.Text = cmbTenLop.SelectedValue.ToString();
            }
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
