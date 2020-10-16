using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Report
{
    public partial class Xrpt_DSSV : DevExpress.XtraReports.UI.XtraReport
    {
        public Xrpt_DSSV(String malop)
        {
            InitializeComponent();
            ds2.EnforceConstraints = false;
            this.dSSV_REPORTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dSSV_REPORTTableAdapter.Fill(ds2.DSSV_REPORT,malop);
        }

    }
}
