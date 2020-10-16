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
    public partial class DSDonghocphi : Form
    {
        public DSDonghocphi()
        {
            InitializeComponent();
        }

        private void DSDonghocphi_Load(object sender, EventArgs e)
        {
            this.dS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.dS.LOP);
            
           
            cmbHocKy.SelectedIndex = 0;

        }

        private void cmbTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            String malop = cmbTenLop.SelectedValue.ToString();
            String nienkhoa = txtNienKhoa.Text;
            int hocky = Int32.Parse(cmbHocKy.SelectedItem.ToString());
            XrptDSDonghocphi rpt = new XrptDSDonghocphi(malop, nienkhoa, hocky);
            rpt.lblLOP.Text = cmbTenLop.Text;
            rpt.lblNIENKHOA.Text = nienkhoa;
            rpt.lblHOCKY.Text = cmbHocKy.SelectedItem.ToString();
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
