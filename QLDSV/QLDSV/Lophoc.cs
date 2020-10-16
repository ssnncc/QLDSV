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
    public partial class Lophoc : Form
    {
        int vitri = 0;
        String maKhoa = "";
        public Lophoc()
        {
            InitializeComponent();
        }
        private void Lophoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.dS.EnforceConstraints = false;

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
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
                }
            }
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLOP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

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
            //if (bdsSV.Count > 0)
            //{
            //    MessageBox.Show("Không thể xóa lớp đã có sinh viên? ", "Xác nhận",
            //           MessageBoxButtons.OKCancel);
            //    return;
            //}
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
                    this.lOPTableAdapter.Update(this.dS.LOP);
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
                string strLenh = "SELECT COUNT(MALOP)  FROM LINK0.QLDSV.dbo.LOP WHERE MALOP='" + txtMaLop.Text + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                int s = Program.myReader.GetInt32(0);
                if (s == 1)
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
                bdsLOP.EndEdit();
                bdsLOP.ResetCurrentItem();
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Update(this.dS.LOP);
                this.lOPTableAdapter.Fill(this.dS.LOP);

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

        private void btnPhuchoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLOP.CancelEdit();
            if (btnThem.Enabled == false) bdsLOP.Position = vitri;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhuchoi.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
