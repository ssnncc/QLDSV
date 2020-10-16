namespace QLDSV.Report
{
    partial class Phieudiem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMaSV = new System.Windows.Forms.ComboBox();
            this.bdsSV = new System.Windows.Forms.BindingSource(this.components);
            this.bdsLOP = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV.DS();
            this.cmbLop = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lOPTableAdapter = new QLDSV.DSTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new QLDSV.DSTableAdapters.TableAdapterManager();
            this.sINHVIENTableAdapter = new QLDSV.DSTableAdapters.SINHVIENTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbKhoa);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cmbMaSV);
            this.panel1.Controls.Add(this.cmbLop);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnIn);
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 274);
            this.panel1.TabIndex = 1;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DisplayMember = "TENLOP";
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(235, 54);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(435, 27);
            this.cmbKhoa.TabIndex = 25;
            this.cmbKhoa.ValueMember = "MALOP";
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Khoa";
            // 
            // cmbMaSV
            // 
            this.cmbMaSV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsSV, "MASV", true));
            this.cmbMaSV.DataSource = this.bdsSV;
            this.cmbMaSV.DisplayMember = "MASV";
            this.cmbMaSV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaSV.FormattingEnabled = true;
            this.cmbMaSV.Location = new System.Drawing.Point(235, 134);
            this.cmbMaSV.Name = "cmbMaSV";
            this.cmbMaSV.Size = new System.Drawing.Size(201, 27);
            this.cmbMaSV.TabIndex = 23;
            this.cmbMaSV.ValueMember = "MASV";
            // 
            // bdsSV
            // 
            this.bdsSV.DataMember = "FK_SINHVIEN_LOP";
            this.bdsSV.DataSource = this.bdsLOP;
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
            // cmbLop
            // 
            this.cmbLop.DataSource = this.bdsLOP;
            this.cmbLop.DisplayMember = "TENLOP";
            this.cmbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLop.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.Location = new System.Drawing.Point(235, 95);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(435, 27);
            this.cmbLop.TabIndex = 22;
            this.cmbLop.ValueMember = "MALOP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(61, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = "Lớp";
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Location = new System.Drawing.Point(235, 182);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(79, 34);
            this.btnIn.TabIndex = 19;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(591, 182);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(79, 34);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mã sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "PHIẾU ĐIỂM";
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
            this.tableAdapterManager.SINHVIENTableAdapter = this.sINHVIENTableAdapter;
            this.tableAdapterManager.UpdateOrder = QLDSV.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // Phieudiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Phieudiem";
            this.Text = "Phieudiem";
            this.Load += new System.EventHandler(this.Phieudiem_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMaSV;
        private System.Windows.Forms.ComboBox cmbLop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DS dS;
        private System.Windows.Forms.BindingSource bdsLOP;
        private DSTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsSV;
    }
}