
namespace DEV_Form
{
    partial class FM_CUSTOMER
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustCode = new System.Windows.Forms.TextBox();
            this.chkCustOnly = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnCSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoPump = new System.Windows.Forms.RadioButton();
            this.rdoCut = new System.Windows.Forms.RadioButton();
            this.rdoACar = new System.Windows.Forms.RadioButton();
            this.rdoSCar = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCus = new System.Windows.Forms.DataGridView();
            this.btnAddC = new System.Windows.Forms.Button();
            this.btnDeleteC = new System.Windows.Forms.Button();
            this.btnSaveC = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCus)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "거래처 코드";
            // 
            // txtCustCode
            // 
            this.txtCustCode.Location = new System.Drawing.Point(107, 27);
            this.txtCustCode.Name = "txtCustCode";
            this.txtCustCode.Size = new System.Drawing.Size(158, 27);
            this.txtCustCode.TabIndex = 9;
            // 
            // chkCustOnly
            // 
            this.chkCustOnly.AutoSize = true;
            this.chkCustOnly.Location = new System.Drawing.Point(12, 85);
            this.chkCustOnly.Name = "chkCustOnly";
            this.chkCustOnly.Size = new System.Drawing.Size(126, 24);
            this.chkCustOnly.TabIndex = 16;
            this.chkCustOnly.Text = "고객사만 검색";
            this.chkCustOnly.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "거래처 명";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(363, 27);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(158, 27);
            this.txtCustName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(941, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "~";
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(771, 27);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(164, 27);
            this.dtpStart.TabIndex = 12;
            this.dtpStart.Value = new System.DateTime(2021, 5, 25, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(691, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "출시 일자";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(967, 27);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(162, 27);
            this.dtpEnd.TabIndex = 13;
            this.dtpEnd.Value = new System.DateTime(2021, 5, 25, 0, 0, 0, 0);
            // 
            // btnCSearch
            // 
            this.btnCSearch.Location = new System.Drawing.Point(693, 79);
            this.btnCSearch.Name = "btnCSearch";
            this.btnCSearch.Size = new System.Drawing.Size(72, 34);
            this.btnCSearch.TabIndex = 17;
            this.btnCSearch.Text = "조회";
            this.btnCSearch.UseVisualStyleBackColor = true;
            this.btnCSearch.Click += new System.EventHandler(this.btnCSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnCSearch);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCustCode);
            this.groupBox1.Controls.Add(this.chkCustOnly);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCustName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpStart);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpEnd);
            this.groupBox1.Location = new System.Drawing.Point(26, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1161, 144);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "거래처 조회";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoPump);
            this.groupBox2.Controls.Add(this.rdoCut);
            this.groupBox2.Controls.Add(this.rdoACar);
            this.groupBox2.Controls.Add(this.rdoSCar);
            this.groupBox2.Location = new System.Drawing.Point(184, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 56);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "종목";
            // 
            // rdoPump
            // 
            this.rdoPump.AutoSize = true;
            this.rdoPump.Location = new System.Drawing.Point(350, 15);
            this.rdoPump.Name = "rdoPump";
            this.rdoPump.Size = new System.Drawing.Size(110, 24);
            this.rdoPump.TabIndex = 18;
            this.rdoPump.Text = "펌프 압축기";
            this.rdoPump.UseVisualStyleBackColor = true;
            this.rdoPump.CheckedChanged += new System.EventHandler(this.rdoPump_CheckedChanged);
            // 
            // rdoCut
            // 
            this.rdoCut.AutoSize = true;
            this.rdoCut.Location = new System.Drawing.Point(254, 16);
            this.rdoCut.Name = "rdoCut";
            this.rdoCut.Size = new System.Drawing.Size(90, 24);
            this.rdoCut.TabIndex = 18;
            this.rdoCut.Text = "절삭가공";
            this.rdoCut.UseVisualStyleBackColor = true;
            this.rdoCut.CheckedChanged += new System.EventHandler(this.rdoCut_CheckedChanged);
            // 
            // rdoACar
            // 
            this.rdoACar.AutoSize = true;
            this.rdoACar.Location = new System.Drawing.Point(138, 16);
            this.rdoACar.Name = "rdoACar";
            this.rdoACar.Size = new System.Drawing.Size(110, 24);
            this.rdoACar.TabIndex = 18;
            this.rdoACar.Text = "자동차 부품";
            this.rdoACar.UseVisualStyleBackColor = true;
            this.rdoACar.CheckedChanged += new System.EventHandler(this.rdoACar_CheckedChanged);
            // 
            // rdoSCar
            // 
            this.rdoSCar.AutoSize = true;
            this.rdoSCar.Location = new System.Drawing.Point(22, 16);
            this.rdoSCar.Name = "rdoSCar";
            this.rdoSCar.Size = new System.Drawing.Size(110, 24);
            this.rdoSCar.TabIndex = 18;
            this.rdoSCar.Text = "상용차 부품";
            this.rdoSCar.UseVisualStyleBackColor = true;
            this.rdoSCar.CheckedChanged += new System.EventHandler(this.rdoSCar_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCus);
            this.groupBox3.Controls.Add(this.btnAddC);
            this.groupBox3.Controls.Add(this.btnDeleteC);
            this.groupBox3.Controls.Add(this.btnSaveC);
            this.groupBox3.Location = new System.Drawing.Point(26, 167);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1161, 522);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "거래처 정보";
            // 
            // dgvCus
            // 
            this.dgvCus.AllowUserToAddRows = false;
            this.dgvCus.AllowUserToDeleteRows = false;
            this.dgvCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCus.Location = new System.Drawing.Point(16, 67);
            this.dgvCus.Name = "dgvCus";
            this.dgvCus.RowHeadersWidth = 51;
            this.dgvCus.RowTemplate.Height = 29;
            this.dgvCus.Size = new System.Drawing.Size(1134, 443);
            this.dgvCus.TabIndex = 23;
            this.dgvCus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCus_CellContentClick);
            // 
            // btnAddC
            // 
            this.btnAddC.Location = new System.Drawing.Point(12, 26);
            this.btnAddC.Name = "btnAddC";
            this.btnAddC.Size = new System.Drawing.Size(89, 34);
            this.btnAddC.TabIndex = 22;
            this.btnAddC.Text = "추가";
            this.btnAddC.UseVisualStyleBackColor = true;
            this.btnAddC.Click += new System.EventHandler(this.btnAddC_Click);
            // 
            // btnDeleteC
            // 
            this.btnDeleteC.Location = new System.Drawing.Point(107, 26);
            this.btnDeleteC.Name = "btnDeleteC";
            this.btnDeleteC.Size = new System.Drawing.Size(89, 34);
            this.btnDeleteC.TabIndex = 20;
            this.btnDeleteC.Text = "삭제";
            this.btnDeleteC.UseVisualStyleBackColor = true;
            this.btnDeleteC.Click += new System.EventHandler(this.btnDeleteC_Click);
            // 
            // btnSaveC
            // 
            this.btnSaveC.Location = new System.Drawing.Point(202, 26);
            this.btnSaveC.Name = "btnSaveC";
            this.btnSaveC.Size = new System.Drawing.Size(89, 34);
            this.btnSaveC.TabIndex = 21;
            this.btnSaveC.Text = "저장";
            this.btnSaveC.UseVisualStyleBackColor = true;
            this.btnSaveC.Click += new System.EventHandler(this.btnSaveC_Click);
            // 
            // FM_CUSTOMER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 701);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FM_CUSTOMER";
            this.Text = "FM_CUSTOMER";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FM_CUSTOMER_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustCode;
        private System.Windows.Forms.CheckBox chkCustOnly;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnCSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoSCar;
        private System.Windows.Forms.RadioButton rdoACar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoPump;
        private System.Windows.Forms.RadioButton rdoCut;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCus;
        private System.Windows.Forms.Button btnAddC;
        private System.Windows.Forms.Button btnDeleteC;
        private System.Windows.Forms.Button btnSaveC;
    }
}