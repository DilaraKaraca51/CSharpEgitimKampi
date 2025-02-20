using FinancialCrmDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrmProject
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) // Koyu Tema
            {
                this.BackColor = System.Drawing.Color.Black;
                this.ForeColor = System.Drawing.Color.White;
            }
            else if (comboBox1.SelectedIndex == 1) // Açık Tema
            {
                this.BackColor = System.Drawing.Color.White;
                this.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.google.com");
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }

        private void btnBillsFrm_Click(object sender, EventArgs e)
        {
            FrmBilling bills = new FrmBilling();
            bills.Show();
            this.Hide();
        }

        private void btnSpendingsFrm_Click(object sender, EventArgs e)
        {
            FrmSpendings spendings = new FrmSpendings();
            spendings.Show();
            this.Hide();
        }

        private void btnBankProcessFrm_Click(object sender, EventArgs e)
        {

            FrmBankProcesses bankProcesses = new FrmBankProcesses();
            bankProcesses.Show();
            this.Hide();
        }

        private void btnDashboardFrm_Click(object sender, EventArgs e)
        {
            FrmDashboard dashboard = new FrmDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }
    }
}
