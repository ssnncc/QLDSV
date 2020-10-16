namespace QLDSV.Report
{
    partial class DSSV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label tENLOPLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaLop = new DevExpress.XtraEditors.TextEdit();
            this.cmbTenLop = new System.Windows.Forms.ComboBox();
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.btThoat = new System.Windows.Forms.Button();
            this.btIn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.lOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            mALOPLabel = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Location = new System.Drawing.Point(230, 115);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(59, 17);
            mALOPLabel.TabIndex = 9;
            mALOPLabel.Text = "Mã Lớp:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Location = new System.Drawing.Point(230, 73);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(65, 17);
            tENLOPLabel.TabIndex = 8;
            tENLOPLabel.Text = "Tên Lớp:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(mALOPLabel);
            this.panel1.Controls.Add(this.txtMaLop);
            this.panel1.Controls.Add(tENLOPLabel);
            this.panel1.Controls.Add(this.cmbTenLop);
            this.panel1.Controls.Add(this.btThoat);
            this.panel1.Controls.Add(this.btIn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmbKhoa);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 202);
            this.panel1.TabIndex = 2;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Location = new System.Drawing.Point(308, 114);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(429, 22);
            this.txtMaLop.TabIndex = 10;
            // 
            // cmbTenLop
            // 
            this.cmbTenLop.DataSource = this.bdsLOP;
            this.cmbTenLop.DisplayMember = "TENLOP";
            this.cmbTenLop.FormattingEnabled = true;
            this.cmbTenLop.Location = new System.Drawing.Point(308, 73);
            this.cmbTenLop.Name = "cmbTenLop";
            this.cmbTenLop.Size = new System.Drawing.Size(429, 24);
            this.cmbTenLop.TabIndex = 9;
            this.cmbTenLop.ValueMember = "MALOP";
            this.cmbTenLop.SelectedIndexChanged += new System.EventHandler(this.cmbTenLop_SelectedIndexChanged);
            // 
            // bdsLOP
            // 
            this.bdsLOP.DataMember = "LOP";
            this.bdsLOP.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(626, 151);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(111, 23);
            this.btThoat.TabIndex = 8;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btIn
            // 
            this.btIn.Location = new System.Drawing.Point(308, 151);
            this.btIn.Name = "btIn";
            this.btIn.Size = new System.Drawing.Size(133, 23);
            this.btIn.TabIndex = 7;
            this.btIn.Text = "In DSSV";
            this.btIn.UseVisualStyleBackColor = true;
            this.btIn.Click += new System.EventHandler(this.btIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Khoa:";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(308, 29);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(429, 24);
            this.cmbKhoa.TabIndex = 2;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 542);
            this.Controls.Add(this.panel1);
            this.Name = "DSSV";
            this.Text = "DSSV";
            this.Load += new System.EventHandler(this.DSSV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.TextEdit txtMaLop;
        private System.Windows.Forms.ComboBox cmbTenLop;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsLOP;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
    }
}