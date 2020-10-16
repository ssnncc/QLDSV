namespace QLDSV.Report
{
    partial class BangdiemMH
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
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label mALOPLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.cmbTenMH = new System.Windows.Forms.ComboBox();
            this.bdsMH = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.cmbTenLop = new System.Windows.Forms.ComboBox();
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.cmbLanThi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.mONHOCTableAdapter = new QLDSV.DSTableAdapters.MONHOCTableAdapter();
            mAMHLabel = new System.Windows.Forms.Label();
            mALOPLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            this.SuspendLayout();
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mAMHLabel.Location = new System.Drawing.Point(118, 118);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(108, 19);
            mAMHLabel.TabIndex = 49;
            mAMHLabel.Text = "Tên Môn Học:";
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(118, 77);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(70, 19);
            mALOPLabel.TabIndex = 48;
            mALOPLabel.Text = "Tên Lớp:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtMaMH);
            this.panel1.Controls.Add(this.txtMaLop);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnIn);
            this.panel1.Controls.Add(this.cmbTenMH);
            this.panel1.Controls.Add(this.cmbTenLop);
            this.panel1.Controls.Add(mAMHLabel);
            this.panel1.Controls.Add(mALOPLabel);
            this.panel1.Controls.Add(this.cmbLanThi);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmbKhoa);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 252);
            this.panel1.TabIndex = 12;
            // 
            // txtMaMH
            // 
            this.txtMaMH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMH.Location = new System.Drawing.Point(736, 115);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(151, 27);
            this.txtMaMH.TabIndex = 55;
            // 
            // txtMaLop
            // 
            this.txtMaLop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLop.Location = new System.Drawing.Point(736, 74);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(151, 27);
            this.txtMaLop.TabIndex = 54;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(606, 202);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 30);
            this.btnThoat.TabIndex = 53;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(257, 202);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 30);
            this.btnIn.TabIndex = 52;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // cmbTenMH
            // 
            this.cmbTenMH.DataSource = this.bdsMH;
            this.cmbTenMH.DisplayMember = "TENMH";
            this.cmbTenMH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenMH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenMH.FormattingEnabled = true;
            this.cmbTenMH.Location = new System.Drawing.Point(257, 118);
            this.cmbTenMH.Name = "cmbTenMH";
            this.cmbTenMH.Size = new System.Drawing.Size(424, 27);
            this.cmbTenMH.TabIndex = 51;
            this.cmbTenMH.ValueMember = "MAMH";
            this.cmbTenMH.SelectedIndexChanged += new System.EventHandler(this.cmbTenMH_SelectedIndexChanged);
            // 
            // bdsMH
            // 
            this.bdsMH.DataMember = "MONHOC";
            this.bdsMH.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbTenLop
            // 
            this.cmbTenLop.DataSource = this.bdsLOP;
            this.cmbTenLop.DisplayMember = "TENLOP";
            this.cmbTenLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenLop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTenLop.FormattingEnabled = true;
            this.cmbTenLop.Location = new System.Drawing.Point(257, 77);
            this.cmbTenLop.Name = "cmbTenLop";
            this.cmbTenLop.Size = new System.Drawing.Size(424, 27);
            this.cmbTenLop.TabIndex = 50;
            this.cmbTenLop.ValueMember = "MALOP";
            this.cmbTenLop.SelectedIndexChanged += new System.EventHandler(this.cmbTenLop_SelectedIndexChanged);
            // 
            // bdsLOP
            // 
            this.bdsLOP.DataMember = "LOP";
            this.bdsLOP.DataSource = this.dS;
            // 
            // cmbLanThi
            // 
            this.cmbLanThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanThi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLanThi.FormattingEnabled = true;
            this.cmbLanThi.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbLanThi.Location = new System.Drawing.Point(257, 159);
            this.cmbLanThi.Name = "cmbLanThi";
            this.cmbLanThi.Size = new System.Drawing.Size(64, 27);
            this.cmbLanThi.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 46;
            this.label5.Text = "Lần Thi:";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DisplayMember = "MAMH";
            this.cmbKhoa.DropDownHeight = 123;
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.DropDownWidth = 123;
            this.cmbKhoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.IntegralHeight = false;
            this.cmbKhoa.Location = new System.Drawing.Point(257, 30);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(630, 27);
            this.cmbKhoa.TabIndex = 0;
            this.cmbKhoa.ValueMember = "MAMH";
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 1;
            this.label6.Text = "Khoa";
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
            this.tableAdapterManager.MONHOCTableAdapter = this.mONHOCTableAdapter;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // BangdiemMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 507);
            this.Controls.Add(this.panel1);
            this.Name = "BangdiemMH";
            this.Text = "BangdiemMH";
            this.Load += new System.EventHandler(this.BangdiemMH_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.ComboBox cmbTenMH;
        private System.Windows.Forms.ComboBox cmbTenLop;
        private System.Windows.Forms.ComboBox cmbLanThi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label6;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsLOP;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource bdsMH;
    }
}