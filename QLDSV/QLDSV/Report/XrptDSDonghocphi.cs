using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class XrptDSDonghocphi : DevExpress.XtraReports.UI.XtraReport
    {
        public XrptDSDonghocphi(String malop, String nienkhoa, int hocky)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sp_DsDongHocPhi_ReportTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sp_DsDongHocPhi_ReportTableAdapter.Fill(ds1.sp_DsDongHocPhi_Report, malop, nienkhoa, hocky);
        }

    }
}
