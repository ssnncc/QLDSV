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
    public partial class Sinhvien : Form
    {
        int vitri = 0;
        String maKhoa = "";

        const int Them = 0;
        public Sinhvien()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLOP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void Sinhvien_Load(object sender, EventArgs e)
        {
           
            this.dS.EnforceConstraints = false;

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dS.LOP);
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            // TODO: This line of code loads data into the 'dS.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dIEMTableAdapter.Fill(this.dS.DIEM);
            maKhoa = ((DataRowView)bdsLOP[0])["MAKH"].ToString();//set  mặc định txtMaKhoa
                                                                 // biding data từ data table vào combobox chi nhánh
            cmbKhoa.DataSource = Program.bds_dspm;  // sao chép bds_dspm đã load ở form đăng nhập  qua
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";

            // Xóa bỏ phân mảnh ảo, bỏ lệnh này vô. ==> để cho combo box chạy đúng.
            cmbKhoa.SelectedIndex = 1;

            // nếu login vào là khoa cntt, thì combox sẽ hiện khoa cntt
            // nếu login vào là khoa vt, thì combox sẽ hiện khoa vt
            cmbKhoa.SelectedIndex = Program.mKhoa;
            //Nhóm quyền PGV
            if (Program.mGroup == Program.NhomQuyen[0])
            {
                cmbKhoa.Enabled = true;  // bật tắt theo phân quyền
                btnPhuchoi.Enabled = false;
                btnGhi.Enabled = false;
                btnRefresh.Enabled = false;
            }
            else
            {
                cmbKhoa.Enabled = false;
            }
            //Nhóm quyền Khoa
            if (Program.mGroup == Program.NhomQuyen[1])
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnPhuchoi.Enabled = false;
                btnSua.Enabled = false;
                btnGhi.Enabled = false;
                btnThemSV.Enabled = false;
                btnXoaSV.Enabled = false;
                btnPhuchoiSV.Enabled = false;
                btnGhiSV.Enabled = false;
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
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                    //maKhoa = ((DataRowView)bdsLOP[0])["MAKH"].ToString();
                }
            }
        }


        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLOP.Position; //lấy vị trí lớp  
            bdsLOP.AddNew(); //thêm mới 1 hàng vào danh sách
            groupBox1.Enabled = true;
            txtMaLop.Focus();
            txtMaKhoa.Text = maKhoa;

            cmbKhoa.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = false;
            btnGhi.Enabled = btnPhuchoi.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsSV.Count > 0)//Count  trả về số bản ghi trong ds
            {
                MessageBox.Show("Không thể xóa lớp đã có sinh viên? ", "Xác nhận",
                       MessageBoxButtons.OKCancel);
                return;
            }
            String malop = "";

            if (MessageBox.Show("Bạn có thật sự muốn xóa lớp này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    malop = ((DataRowView)bdsLOP[bdsLOP.Position])["MALOP"].ToString();// giữ lại để khi xóa bị lỗi thì ta sẽ quay về lại
                    bdsLOP.Position = bdsLOP.Find("MALOP", malop);
                    MessageBox.Show(bdsLOP.Position + " ");
                    bdsLOP.RemoveCurrent(); //xóa đi hàng hiện tại ra khỏi dataSet
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.dS.LOP); //cập nhật data từ DataSet về DB thông qua TableAdapter.
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lớp đã có sinh viên không thể xóa \n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                    bdsLOP.Position = bdsLOP.Find("MALOP", malop);
                    return;
                }
            }

            if (bdsLOP.Count == 0) btnXoa.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLOP.Position;
            txtMaLop.Enabled = false;
            groupBox1.Enabled = true;
            cmbKhoa.Enabled = false;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = false;
            btnGhi.Enabled = btnPhuchoi.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaLop.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được để trống!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }
            if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp không được để trống!", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return;
            }
            if (txtMaLop.Enabled == true)
            {
               //Kiểm tra mã lớp tồn tại hay chưa.
                string strLenh1 = "SELECT COUNT(MALOP)  FROM LINK0.QLDSV.dbo.LOP WHERE MALOP= '" + txtMaLop.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(strLenh1);
                Program.myReader.Read();
                int s1 = Program.myReader.GetInt32(0);
                if (s1 == 1)
                {
                    MessageBox.Show("Mã lớp đã có", "", MessageBoxButtons.OK);
                    txtMaLop.Focus();
                    Program.myReader.Close();
                    return;
                }
                Program.myReader.Close();
            }
            try
            {
                bdsLOP.EndEdit(); //kết thúc quá trình chỉnh sửa dữ liệu và gửi về DataSet.
                bdsLOP.ResetCurrentItem();//đọc lại row hiện tại đang đứng và dữ liệu không còn ở dạng tạm nữa mà hiện thị dữ liệu đã chính thức ghi vào DataSet
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.dS.LOP);
                this.lOPTableAdapter.Fill(this.dS.LOP);//Tự động tải dữ liệu về

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi môn học.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = true;
            btnGhi.Enabled = btnPhuchoi.Enabled = false;

            groupBox1.Enabled = false;
        }

        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLOP.CancelEdit();
            //bỏ qua các dữ liệu đang chỉnh sửa trong row và trả con trỏ về row cuối cùng. Chỉ có tác dụng với lệnh AddNew và dữ liệu đang được hiệu chỉnh nhưng chưa ghi vào DataSet.
            if (btnThem.Enabled == false) bdsLOP.Position = vitri;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhuchoi.Enabled = false;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lOPTableAdapter.Fill(this.dS.LOP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lại :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnThemSV_Click(object sender, EventArgs e)
        {
            vitri = bdsSV.Position;
            cmbKhoa.Enabled  = false;
            //groupBox1.Enabled = true;
            bdsSV.AddNew();
            cmbKhoa.Enabled = false;
            btnThem.Enabled = btnXoa.Enabled = btnPhuchoi.Enabled = btnSua.Enabled = btnGhi.Enabled = btnRefresh.Enabled = groupBox1.Enabled = false;
        }

        private void btnXoaSV_Click(object sender, EventArgs e)
        {

            if (bdsDiem.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên đã có điểm? ", "Xác nhận",
                       MessageBoxButtons.OKCancel);
                return;
            }
            String masv = "";
            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên này ?? ", "Xác nhận",
                     MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    masv = ((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString();// giữ lại để khi xóa bị lỗi thì ta sẽ quay về lại
                                                                                   // bdsSV.Position = bdsSV.Find("MASV", masv);
                    bdsSV.RemoveCurrent();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.dS.LOP);
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh viên. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.lOPTableAdapter.Fill(this.dS.LOP);
                    //bdsSV.Position = bdsSV.Find("MASV", bdsSV);
                    return;
                }
                cmbKhoa.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnPhuchoi.Enabled = btnSua.Enabled = btnGhi.Enabled = btnRefresh.Enabled  = groupBox1.Enabled = false;
            }

            if (bdsSV.Count == 0) btnXoa.Enabled = false;
        }

        private void btnGhiSV_Click(object sender, EventArgs e)
        {
            int index = bdsSV.Count - 1;
            string maSV = this.gridView2.GetRowCellValue(index, "MASV").ToString();
            //Kiểm tra mã sinh viên đã tồn tại hay chưa.
            string strLenh = "SELECT COUNT(MASV)  FROM LINK0.QLDSV.dbo.SINHVIEN WHERE MASV= '" + maSV + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            int s2 = Program.myReader.GetInt32(0);
            if (s2 == 1)
            {
                MessageBox.Show("Mã sinh viên này đã có", "", MessageBoxButtons.OK);
                Program.myReader.Close();
                return;
            }
            Program.myReader.Close();

            try
            {
                bdsSV.EndEdit();
                bdsSV.ResetCurrentItem();
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.dS.LOP);
                cmbKhoa.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi sinh viên.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            groupBox1.Enabled = false;
        }

        private void btnRefreshSV_Click(object sender, EventArgs e)
        {
            try
            {
                this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lại :" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnPhuchoiSV_Click(object sender, EventArgs e)
        {
            bdsSV.CancelEdit();
            if (btnThem.Enabled == false) bdsSV.Position = vitri;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled =  true;
            btnThemSV.Enabled = btnXoaSV.Enabled = btnRefreshSV.Enabled = true;
            btnGhiSV.Enabled = btnPhuchoiSV.Enabled = false;
           
        }

        private void btnChuyenlop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //txtMaSV.Focus();
            groupBox2.Enabled = btnPhuchoi.Enabled = true;
            groupBox1.Enabled = btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnGhi.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!Hãy chọn sinh viên", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
                groupBox2.Enabled = btnGhi.Enabled = btnPhuchoi.Enabled = false;
                return;
            }
            if (txtMalopChuyen.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp không được thiếu!", "", MessageBoxButtons.OK);
                txtMaLop.Focus();
                return;
            }

            if (Program.KetNoi() == 0)
                MessageBox.Show("Lỗi kết nối về may chủ", "", MessageBoxButtons.OK);
            else
            {
                string strLenh = "SELECT COUNT(l.MALOP) FROM LINK0.QLDSV.dbo.LOP l WHERE l.MALOP='" + txtMalopChuyen.Text + "';";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                int s = Program.myReader.GetInt32(0);
                if (s == 0)
                {
                    MessageBox.Show("Mã lớp bạn muốn chuyển tới không tồn tại!", "", MessageBoxButtons.OK);
                    txtMalopChuyen.Focus();
                    Program.myReader.Close();
                    return;
                }
                Program.myReader.Close();
                try
                {
                    strLenh = "update LINK0.QLDSV.dbo.SINHVIEN Set MALOP='" + txtMalopChuyen.Text + "' where MASV= '" + txtMaSV.Text.Trim() + "';";
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = strLenh;
                    cmd.Connection = Program.conn;
                    cmd.ExecuteNonQuery();
                    bdsLOP.EndEdit();
                    bdsLOP.ResetCurrentItem();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.dS.LOP);
                    cmbKhoa.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chuyển lớp.\n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                groupBox2.Enabled = btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnChuyenlop.Enabled = true;
                btnGhi.Enabled = btnPhuchoi.Enabled = false;

                groupBox1.Enabled = false;
            }
        }
    }
}
