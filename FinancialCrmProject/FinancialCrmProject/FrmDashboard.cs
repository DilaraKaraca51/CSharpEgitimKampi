using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrmProject;
using FinancialCrmProject.Models;

namespace FinancialCrmDb
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities5 db = new FinancialCrmDbEntities5();
        int count = 0;
        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            var totalBalance = db.Banks.Sum(x => x.BankBalance);
            lblTotalBalance.Text = totalBalance.ToString() + " ₺";

            var lastBankProcessAmount = db.BankProcesses.OrderByDescending(x=>x.BankId).Take(1).Select(y => y.Amount).FirstOrDefault();
            lblLastBankProcessAmount.Text = lastBankProcessAmount.ToString() + "t";

            // Chart1

            var bankData = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance,
            }).ToList();

            chart1.Series.Clear();
            var series = chart1.Series.Add("Bankalar");
            foreach (var item in bankData)
            {
                series.Points.AddXY(item.BankTitle, item.BankBalance);
            }


            // Chart2

            var billData = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount
            }).ToList();

            chart2.Series.Clear();
            var series2 = chart2.Series.Add("Faturalar");
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            foreach (var item in billData)
            {
                series2.Points.AddXY(item.BillTitle, item.BillAmount);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            if (count % 4 == 1)
            {
                var elektrik = db.Bills.Where(x => x.BillTitle == "Elektrik Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Elektrik Faturası";
                lblBillAmount.Text = elektrik.ToString() + " ₺";
            }

            if (count % 4 == 2)
            {
                var dogalgaz = db.Bills.Where(x => x.BillTitle == "Doğalgaz Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Doğalgaz Faturası";
                lblBillAmount.Text = dogalgaz.ToString() + " ₺";
            }

            if (count % 4 == 3)
            {
                var su = db.Bills.Where(x => x.BillTitle == "Su Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "Su Faturası";
                lblBillAmount.Text = su.ToString() + " ₺";
            }

            if (count % 4 == 0)
            {
                var internet = db.Bills.Where(x => x.BillTitle == "İnternet Faturası").Select(y => y.BillAmount).FirstOrDefault();
                lblBillTitle.Text = "İnternet Faturası";
                lblBillAmount.Text = internet.ToString() + " ₺";
            }
        }


        // Yan Panel Butonları

        //1
        private void btnBanksForm_Click_1(object sender, EventArgs e)
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
        private void btnBankProcessFrm_Click(object sender, EventArgs e)
        {
            FrmBankProcesses bankProcesses = new FrmBankProcesses();
            bankProcesses.Show();
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
