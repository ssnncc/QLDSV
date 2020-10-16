namespace QLDSV
{
    partial class FormDN
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
            System.Windows.Forms.Label KhoaLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbCN = new System.Windows.Forms.ComboBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.labelMK = new System.Windows.Forms.Label();
            this.labelTK = new System.Windows.Forms.Label();
            this.ds_PM = new QLDSV.ds_PM();
            this.bds_dsPM = new System.Windows.Forms.BindingSource(this.components);
            this.v_DS_PHANMANHTableAdapter = new QLDSV.ds_PMTableAdapters.V_DS_PHANMANHTableAdapter();
            this.tableAdapterManager = new QLDSV.ds_PMTableAdapters.TableAdapterManager();
            KhoaLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_PM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_dsPM)).BeginInit();
            this.SuspendLayout();
            // 
            // KhoaLabel
            // 
            KhoaLabel.AutoSize = true;
            KhoaLabel.Location = new System.Drawing.Point(90, 61);
            KhoaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            KhoaLabel.Name = "KhoaLabel";
            KhoaLabel.Size = new System.Drawing.Size(51, 17);
            KhoaLabel.TabIndex = 7;
            KhoaLabel.Text = "KHOA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(243, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "QUẢN LÝ ĐIỂM SINH VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.groupBox1.Controls.Add(KhoaLabel);
            this.groupBox1.Controls.Add(this.cmbCN);
            this.groupBox1.Controls.Add(this.txtMK);
            this.groupBox1.Controls.Add(this.txtTK);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.labelMK);
            this.groupBox1.Controls.Add(this.labelTK);
            this.groupBox1.Location = new System.Drawing.Point(45, 127);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(711, 294);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // cmbCN
            // 
            this.cmbCN.DataSource = this.bds_dsPM;
            this.cmbCN.DisplayMember = "TENCN";
            this.cmbCN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCN.FormattingEnabled = true;
            this.cmbCN.Location = new System.Drawing.Point(202, 57);
            this.cmbCN.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCN.Name = "cmbCN";
            this.cmbCN.Size = new System.Drawing.Size(397, 24);
            this.cmbCN.TabIndex = 8;
            this.cmbCN.ValueMember = "TENSERVER";
            this.cmbCN.SelectedIndexChanged += new System.EventHandler(this.cmbCN_SelectedIndexChanged);
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(202, 149);
            this.txtMK.Margin = new System.Windows.Forms.Padding(4);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(397, 22);
            this.txtMK.TabIndex = 7;
            this.txtMK.Text = "123";
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(202, 103);
            this.txtTK.Margin = new System.Windows.Forms.Padding(4);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(397, 22);
            this.txtTK.TabIndex = 6;
            this.txtTK.Text = "NHS";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Lavender;
            this.btnExit.Location = new System.Drawing.Point(512, 214);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 26);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "THOÁT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Lavender;
            this.btnLogin.Location = new System.Drawing.Point(202, 214);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(143, 26);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "ĐĂNG NHẬP";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // labelMK
            // 
            this.labelMK.AutoSize = true;
            this.labelMK.Location = new System.Drawing.Point(90, 152);
            this.labelMK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMK.Name = "labelMK";
            this.labelMK.Size = new System.Drawing.Size(79, 17);
            this.labelMK.TabIndex = 2;
            this.labelMK.Text = "MẬT KHẨU";
            // 
            // labelTK
            // 
            this.labelTK.AutoSize = true;
            this.labelTK.Location = new System.Drawing.Point(90, 106);
            this.labelTK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTK.Name = "labelTK";
            this.labelTK.Size = new System.Drawing.Size(82, 17);
            this.labelTK.TabIndex = 1;
            this.labelTK.Text = "TÀI KHOẢN";
            // 
            // ds_PM
            // 
            this.ds_PM.DataSetName = "ds_PM";
            this.ds_PM.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bds_dsPM
            // 
            this.bds_dsPM.DataMember = "V_DS_PHANMANH";
            this.bds_dsPM.DataSource = this.ds_PM;
            // 
            // v_DS_PHANMANHTableAdapter
            // 
            this.v_DS_PHANMANHTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.ds_PMTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // FormDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDN";
            this.Text = "ĐĂNG NHẬP";
            this.Load += new System.EventHandler(this.FormDN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ds_PM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_dsPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCN;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label labelMK;
        private System.Windows.Forms.Label labelTK;
        private ds_PM ds_PM;
        private System.Windows.Forms.BindingSource bds_dsPM;
        private ds_PMTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
        private ds_PMTableAdapters.TableAdapterManager tableAdapterManager;
    }
}