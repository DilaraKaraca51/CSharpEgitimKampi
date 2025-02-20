namespace FinancialCrmProject
{
    partial class FrmSettings
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSettingsFrm = new System.Windows.Forms.Button();
            this.btnDashboardFrm = new System.Windows.Forms.Button();
            this.btnBankProcessFrm = new System.Windows.Forms.Button();
            this.btnSpendingsFrm = new System.Windows.Forms.Button();
            this.btnBillsFrm = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnCategoriesFrm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Koyu ",
            "Açık"});
            this.comboBox1.Location = new System.Drawing.Point(418, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(300, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tema Seçiniz:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(806, 35);
            this.panel4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ödeme Fatura Formu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnSettingsFrm);
            this.panel1.Controls.Add(this.btnDashboardFrm);
            this.panel1.Controls.Add(this.btnBankProcessFrm);
            this.panel1.Controls.Add(this.btnSpendingsFrm);
            this.panel1.Controls.Add(this.btnBillsFrm);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.btnCategoriesFrm);
            this.panel1.Location = new System.Drawing.Point(1, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 356);
            this.panel1.TabIndex = 6;
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
            // btnBankProcessFrm
            // 
            this.btnBankProcessFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankProcessFrm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBankProcessFrm.ForeColor = System.Drawing.Color.White;
            this.btnBankProcessFrm.Location = new System.Drawing.Point(35, 184);
            this.btnBankProcessFrm.Name = "btnBankProcessFrm";
            this.btnBankProcessFrm.Size = new System.Drawing.Size(168, 35);
            this.btnBankProcessFrm.TabIndex = 4;
            this.btnBankProcessFrm.Text = "Banka Hareketleri";
            this.btnBankProcessFrm.UseVisualStyleBackColor = true;
            this.btnBankProcessFrm.Click += new System.EventHandler(this.btnBankProcessFrm_Click);
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
            // btnCategoriesFrm
            // 
            this.btnCategoriesFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoriesFrm.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategoriesFrm.ForeColor = System.Drawing.Color.White;
            this.btnCategoriesFrm.Location = new System.Drawing.Point(35, 20);
            this.btnCategoriesFrm.Name = "btnCategoriesFrm";
            this.btnCategoriesFrm.Size = new System.Drawing.Size(168, 35);
            this.btnCategoriesFrm.TabIndex = 0;
            this.btnCategoriesFrm.Text = "Kategoriler";
            this.btnCategoriesFrm.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(300, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Yardım İçin Tıklayınız";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(810, 393);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSettings";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnSettingsFrm;
        private System.Windows.Forms.Button btnDashboardFrm;
        private System.Windows.Forms.Button btnBankProcessFrm;
        private System.Windows.Forms.Button btnSpendingsFrm;
        private System.Windows.Forms.Button btnBillsFrm;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button btnCategoriesFrm;
        private System.Windows.Forms.Label label2;
    }
}