using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrmDb;
using FinancialCrmProject.Models;

namespace FinancialCrmProject
{
    public partial class FrmBankProcesses : Form
    {
        public FrmBankProcesses()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities5 db = new FinancialCrmDbEntities5();
        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.BankProcesses.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmBankProcesses_Load(object sender, EventArgs e)
        {
            var values = db.BankProcesses.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {
            string title = txtBankProcessDescription.Text;
            string type = txtProcessType.Text;
            decimal amount = decimal.Parse(txtAmount.Text);
            int bankId = int.Parse(txtBankId.Text);
            DateTime date = DateTime.Parse(txtDate.Text);

            BankProcesses Processes = new BankProcesses();
            Processes.Description= title;
            Processes.ProcessDate = date;
            Processes.ProcessType = type;
            db.BankProcesses.Add(Processes);
            db.SaveChanges();
            MessageBox.Show("Banka Hesap Bilgileri Eklendi", "Banka", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.BankProcesses.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnDeleteBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBankProcessId.Text);
            var removeValue = db.BankProcesses.Find(id);
            db.BankProcesses.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Banka Hesap Bilgileri Silindi", "Banka", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.BankProcesses.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            string title = txtBankProcessDescription.Text;
            string type = txtProcessType.Text;
            decimal amount = decimal.Parse(txtAmount.Text);
            int bankId = int.Parse(txtBankId.Text);
            DateTime date = DateTime.Parse(txtDate.Text);

            int id = int.Parse(txtBankProcessId.Text);

            BankProcesses Processes = new BankProcesses();
            Processes.Description= title;
            Processes.ProcessDate = date;
            Processes.ProcessType = type;
            db.BankProcesses.Add(Processes);
            db.SaveChanges();
            MessageBox.Show("Banka Hesap Bilgileri Güncellendi", "Banka", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values2 = db.BankProcesses.ToList();
            dataGridView1.DataSource = values2;
        }

        //1
        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBanks frm = new FrmBanks();
            frm.Show();
            this.Hide();
        }
        //2
        private void btnBillsFrm_Click(object sender, EventArgs e)
        {
            FrmBilling bills = new FrmBilling();
            bills.Show();
            this.Hide();
        }

        //3
        private void btnSpendingsFrm_Click(object sender, EventArgs e)
        {
            FrmSpendings spendings = new FrmSpendings();
            spendings.Show();
            this.Hide();
        }

        //4
        private void btnDashboardFrm_Click(object sender, EventArgs e)
        {
            FrmDashboard dashboard = new FrmDashboard();
            dashboard.Show();
            this.Hide();
        }

        //5
        private void btnSettingsFrm_Click(object sender, EventArgs e)
        {
            FrmSettings settings = new FrmSettings();
            settings.Show();
            this.Hide();
        }
        //6
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

       
    }
}
