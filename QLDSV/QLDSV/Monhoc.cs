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
    public partial class Monhoc : Form
    {
        int vitri = 0;
        public Monhoc()
        {
            InitializeComponent();
        }
        private void mONHOCBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void Monhoc_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            // yêu cầu không kiểm tra khóa ngoại nữa 
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            this.dIEMTableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'dS.DIEM' table. You can move, or remove it, as needed.
            this.dIEMTableAdapter.Fill(this.dS.DIEM);
            if (Program.mGroup == Program.NhomQuyen[1])
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnPhuchoi.Enabled = false;
                btnSua.Enabled = false;
                btnGhi.Enabled = false;
            }
            btnPhuchoi.Enabled = false;
            btnGhi.Enabled = false;
            btnRefresh.Enabled = false;
            groupBox1.Enabled = false;

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMH.Position;
            groupBox1.Enabled = true;
            bdsMH.AddNew();
            txtMaMH.Focus();

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = false;
            btnGhi.Enabled = btnPhuchoi.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (bdsDiem.Count > 0)
            {
                MessageBox.Show("Môn học có điểm nên không được xóa ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel);
                return;
            }
            String mamh = "";
            if (MessageBox.Show("Bạn có thật sự muốn xóa môn học này ?? ", "Xác nhận",
                       MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    mamh = ((DataRowView)bdsMH[bdsMH.Position])["MAMH"].ToString();// giữ lại để khi xóa bị lỗi thì ta sẽ quay về lại
                    bdsMH.Position = bdsMH.Find("MAMH", mamh);
                    bdsMH.RemoveCurrent(); // xóa tại chỗ 
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.dS.MONHOC); // ghi vào CSDL
                    //Đưa dữ liệu từ DataTable qLDSVDataSet.MONHOC  trong Project về table MONHOC
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa. Bạn hãy xóa lại\n" + ex.Message, "",
                        MessageBoxButtons.OK);
                    this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
                    bdsMH.Position = bdsMH.Find("MAMH", mamh);
                    return;
                }
            }

            if (bdsMH.Count == 0) btnXoa.Enabled = false;
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsMH.Position;
            txtMaMH.Enabled = false;
            groupBox1.Enabled = true;

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = false;
            btnGhi.Enabled = btnPhuchoi.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Mã môn học không được để trống!", "", MessageBoxButtons.OK);
                txtMaMH.Focus();
                return;
            }
            if (txtTenMH.Text.Trim() == "")
            {
                MessageBox.Show("Tên môn học không được để trống!", "", MessageBoxButtons.OK);
                txtTenMH.Focus();
                return;
            }
            if (txtMaMH.Enabled == true)
            {
                string strLenh = "SELECT COUNT(MAMH) FROM MONHOC WHERE MAMH='" + txtMaMH.Text + "'";

                Program.myReader = Program.ExecSqlDataReader(strLenh);
                Program.myReader.Read();
                int s = Program.myReader.GetInt32(0);
                if (s == 1)
                {
                    MessageBox.Show("Mã môn đã có", "", MessageBoxButtons.OK);
                    txtMaMH.Focus();
                    Program.myReader.Close();
                    return;
                }
                Program.myReader.Close();
            }
           

            try
            {
                bdsMH.EndEdit();
                bdsMH.ResetCurrentItem();
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Update(this.dS.MONHOC);
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);

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
            bdsMH.CancelEdit();
            if (btnThem.Enabled == false) bdsMH.Position = vitri;
            groupBox1.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnRefresh.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnPhuchoi.Enabled = false;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
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
    }
}
