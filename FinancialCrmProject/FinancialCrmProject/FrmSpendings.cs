using FinancialCrmDb;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrmProject.Models;

namespace FinancialCrmProject
{
    public partial class FrmSpendings : Form
    {
        public FrmSpendings()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities5 db = new FinancialCrmDbEntities5();

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

        private void btnSettingsFrm_Click(object sender, EventArgs e)
        {
            FrmSettings settings = new FrmSettings();
            settings.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void btnSpendingList_Click(object sender, EventArgs e)
        {
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmSpendings_Load(object sender, EventArgs e)
        {
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;

            var categoryName = db.Categories
               .Select(c => new { c.CategoryId, c.CategoryName }).ToList();
            cmbSpendingCategory.DataSource = categoryName;
            cmbSpendingCategory.DisplayMember = "CategoryName";
            cmbSpendingCategory.ValueMember = "CategoryId";

        }

        private void btnCreateSpending_Click(object sender, EventArgs e)
        {
            string title = txtSpendingTitle.Text;
            decimal amount = decimal.Parse(txtSpendingAmount.Text);
            DateTime date = DateTime.Parse(txtSpendingDate.Text);
            int categoryName = int.Parse(cmbSpendingCategory.SelectedValue.ToString());

            Spendings spending = new Spendings();
            Categories categories = new Categories();
            spending.SpendingTitle = title;
            spending.SpendingAmount = amount;
            spending.SpendingDate = date;
            categories.CategoryId = categoryName;
            db.Spendings.Add(spending);
            db.SaveChanges();
            MessageBox.Show("Gider Eklendi", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnDeleteSpending_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtSpendingId.Text);
            var removeValue = db.Spendings.Find(id);
            db.Spendings.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Gider Silindi", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateSpending_Click(object sender, EventArgs e)
        {
            string title = txtSpendingTitle.Text;
            decimal amount = decimal.Parse(txtSpendingAmount.Text);
            DateTime date = DateTime.Parse(txtSpendingDate.Text);
            int categoryName = int.Parse(cmbSpendingCategory.SelectedValue.ToString());

            int id = int.Parse(txtSpendingId.Text);

            Spendings spending = new Spendings();
            Categories categories = new Categories();
            spending.SpendingTitle = title;
            spending.SpendingAmount = amount;
            spending.SpendingDate = date;
            categories.CategoryId = categoryName;
            db.Spendings.Add(spending);
            db.SaveChanges();
            MessageBox.Show("Giderler Güncellendi", "Giderler", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }
    }
}
