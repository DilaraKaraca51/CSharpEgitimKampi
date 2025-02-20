namespace FinancialCrmProject
{
    partial class FrmBankProcesses
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSettingsFrm = new System.Windows.Forms.Button();
            this.btnDashboardFrm = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnSpendingsFrm = new System.Windows.Forms.Button();
            this.btnBillsFrm = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBillList = new System.Windows.Forms.Button();
            this.btnCreateBill = new System.Windows.Forms.Button();
            this.btnDeleteBill = new System.Windows.Forms.Button();
            this.btnUpdateBill = new System.Windows.Forms.Button();
            this.txtBankId = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtProcessType = new System.Windows.Forms.TextBox();
            this.txtBankProcessDescription = new System.Windows.Forms.TextBox();
            this.txtBankProcessId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 35);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Banka Formu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnSettingsFrm);
            this.panel1.Controls.Add(this.btnDashboardFrm);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnSpendingsFrm);
            this.panel1.Controls.Add(this.btnBillsFrm);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 369);
            this.panel1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(239, 213);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(570, 152);
            this.panel4.TabIndex = 5;
            // 
            // btnLogOut
            // 
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(35, 307);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(168, 35);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Çıkış Yap";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSettingsFrm
            // 
            this.btnSettingsFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettingsFrm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSettingsFrm.ForeColor = System.Drawing.Color.White;
            this.btnSettingsFrm.Location = new System.Drawing.Point(35, 266);
            this.btnSettingsFrm.Name = "btnSettingsFrm";
            this.btnSettingsFrm.Size = new System.Drawing.Size(168, 35);
            this.btnSettingsFrm.TabIndex = 6;
            this.btnSettingsFrm.Text = "Ayarlar";
            this.btnSettingsFrm.UseVisualStyleBackColor = true;
            this.btnSettingsFrm.Click += new System.EventHandler(this.btnSettingsFrm_Click);
            // 
            // btnDashboardFrm
            // 
            this.btnDashboardFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboardFrm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboardFrm.ForeColor = System.Drawing.Color.White;
            this.btnDashboardFrm.Location = new System.Drawing.Point(35, 225);
            this.btnDashboardFrm.Name = "btnDashboardFrm";
            this.btnDashboardFrm.Size = new System.Drawing.Size(168, 35);
            this.btnDashboardFrm.TabIndex = 5;
            this.btnDashboardFrm.Text = "Dashboard";
            this.btnDashboardFrm.UseVisualStyleBackColor = true;
            this.btnDashboardFrm.Click += new System.EventHandler(this.btnDashboardFrm_Click);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(35, 184);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(168, 35);
            this.button5.TabIndex = 4;
            this.button5.Text = "Banka Hareketleri";
            this.button5.UseVisualStyleBackColor = true;
//            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnSpendingsFrm
            // 
            this.btnSpendingsFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendingsFrm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpendingsFrm.ForeColor = System.Drawing.Color.White;
            this.btnSpendingsFrm.Location = new System.Drawing.Point(35, 143);
            this.btnSpendingsFrm.Name = "btnSpendingsFrm";
            this.btnSpendingsFrm.Size = new System.Drawing.Size(168, 35);
            this.btnSpendingsFrm.TabIndex = 3;
            this.btnSpendingsFrm.Text = "Giderler";
            this.btnSpendingsFrm.UseVisualStyleBackColor = true;
            this.btnSpendingsFrm.Click += new System.EventHandler(this.btnSpendingsFrm_Click);
            // 
            // btnBillsFrm
            // 
            this.btnBillsFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillsFrm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillsFrm.ForeColor = System.Drawing.Color.White;
            this.btnBillsFrm.Location = new System.Drawing.Point(35, 102);
            this.btnBillsFrm.Name = "btnBillsFrm";
            this.btnBillsFrm.Size = new System.Drawing.Size(168, 35);
            this.btnBillsFrm.TabIndex = 2;
            this.btnBillsFrm.Text = "Faturalar";
            this.btnBillsFrm.UseVisualStyleBackColor = true;
            this.btnBillsFrm.Click += new System.EventHandler(this.btnBillsFrm_Click);
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.White;
            this.btnBanksForm.Location = new System.Drawing.Point(35, 61);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(168, 35);
            this.btnBanksForm.TabIndex = 1;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = true;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(35, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Kategoriler";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtDate);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnBillList);
            this.panel3.Controls.Add(this.btnCreateBill);
            this.panel3.Controls.Add(this.btnDeleteBill);
            this.panel3.Controls.Add(this.btnUpdateBill);
            this.panel3.Controls.Add(this.txtBankId);
            this.panel3.Controls.Add(this.txtAmount);
            this.panel3.Controls.Add(this.txtProcessType);
            this.panel3.Controls.Add(this.txtBankProcessDescription);
            this.panel3.Controls.Add(this.txtBankProcessId);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(239, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(570, 210);
            this.panel3.TabIndex = 4;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDate.Location = new System.Drawing.Point(113, 148);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(433, 23);
            this.txtDate.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(59, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = "Tarih:";
            // 
            // btnBillList
            // 
            this.btnBillList.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillList.Location = new System.Drawing.Point(113, 173);
            this.btnBillList.Name = "btnBillList";
            this.btnBillList.Size = new System.Drawing.Size(111, 31);
            this.btnBillList.TabIndex = 17;
            this.btnBillList.Text = "Listele";
            this.btnBillList.UseVisualStyleBackColor = true;
            this.btnBillList.Click += new System.EventHandler(this.btnBillList_Click);
            // 
            // btnCreateBill
            // 
            this.btnCreateBill.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateBill.Location = new System.Drawing.Point(222, 173);
            this.btnCreateBill.Name = "btnCreateBill";
            this.btnCreateBill.Size = new System.Drawing.Size(111, 31);
            this.btnCreateBill.TabIndex = 18;
            this.btnCreateBill.Text = "Ekle";
            this.btnCreateBill.UseVisualStyleBackColor = true;
            this.btnCreateBill.Click += new System.EventHandler(this.btnCreateBill_Click);
            // 
            // btnDeleteBill
            // 
            this.btnDeleteBill.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteBill.Location = new System.Drawing.Point(329, 173);
            this.btnDeleteBill.Name = "btnDeleteBill";
            this.btnDeleteBill.Size = new System.Drawing.Size(111, 31);
            this.btnDeleteBill.TabIndex = 19;
            this.btnDeleteBill.Text = "Sil";
            this.btnDeleteBill.UseVisualStyleBackColor = true;
            this.btnDeleteBill.Click += new System.EventHandler(this.btnDeleteBill_Click);
            // 
            // btnUpdateBill
            // 
            this.btnUpdateBill.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateBill.Location = new System.Drawing.Point(438, 173);
            this.btnUpdateBill.Name = "btnUpdateBill";
            this.btnUpdateBill.Size = new System.Drawing.Size(111, 31);
            this.btnUpdateBill.TabIndex = 20;
            this.btnUpdateBill.Text = "Güncelle";
            this.btnUpdateBill.UseVisualStyleBackColor = true;
            this.btnUpdateBill.Click += new System.EventHandler(this.btnUpdateBill_Click);
            // 
            // txtBankId
            // 
            this.txtBankId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtBankId.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBankId.Location = new System.Drawing.Point(113, 121);
            this.txtBankId.Name = "txtBankId";
            this.txtBankId.Size = new System.Drawing.Size(433, 23);
            this.txtBankId.TabIndex = 16;
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtAmount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAmount.Location = new System.Drawing.Point(113, 95);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(433, 23);
            this.txtAmount.TabIndex = 15;
            // 
            // txtProcessType
            // 
            this.txtProcessType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtProcessType.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtProcessType.Location = new System.Drawing.Point(113, 68);
            this.txtProcessType.Name = "txtProcessType";
            this.txtProcessType.Size = new System.Drawing.Size(433, 23);
            this.txtProcessType.TabIndex = 14;
            // 
            // txtBankProcessDescription
            // 
            this.txtBankProcessDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtBankProcessDescription.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBankProcessDescription.Location = new System.Drawing.Point(113, 39);
            this.txtBankProcessDescription.Name = "txtBankProcessDescription";
            this.txtBankProcessDescription.Size = new System.Drawing.Size(433, 23);
            this.txtBankProcessDescription.TabIndex = 13;
            // 
            // txtBankProcessId
            // 
            this.txtBankProcessId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtBankProcessId.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBankProcessId.Location = new System.Drawing.Point(113, 10);
            this.txtBankProcessId.Name = "txtBankProcessId";
            this.txtBankProcessId.Size = new System.Drawing.Size(433, 23);
            this.txtBankProcessId.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(12, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Gelen Banka:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(59, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ücret:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Gelen/Giden: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(35, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Açıklama:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(38, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "Banka Id:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(242, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(567, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // FrmBankProcesses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(810, 399);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBankProcesses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBankProcess";
            this.Load += new System.EventHandler(this.FrmBankProcesses_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSettingsFrm;
        private System.Windows.Forms.Button btnDashboardFrm;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnSpendingsFrm;
        private System.Windows.Forms.Button btnBillsFrm;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBankId;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtProcessType;
        private System.Windows.Forms.TextBox txtBankProcessDescription;
        private System.Windows.Forms.TextBox txtBankProcessId;
        private System.Windows.Forms.Button btnBillList;
        private System.Windows.Forms.Button btnCreateBill;
        private System.Windows.Forms.Button btnDeleteBill;
        private System.Windows.Forms.Button btnUpdateBill;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDate;
    }
}