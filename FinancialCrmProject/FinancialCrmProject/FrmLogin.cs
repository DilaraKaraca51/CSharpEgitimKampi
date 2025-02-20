using FinancialCrmDb;
using FinancialCrmProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
//using FinancialCrmProject.Models;

namespace FinancialCrmProject
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities5 db = new FinancialCrmDbEntities5();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {

            string username = txtKullaniciAd.Text;
            string password = txtSifre.Text;

            string Username = "admin"; 
            string Password = "1234";

            if (Username == username && Password == password)
            {
                Users user = new Users();
                user.UserName = username;
                user.UserPassword = password;

                MessageBox.Show("Giriş Başarılı", "", MessageBoxButtons.OK);
                FrmDashboard dashboard = new FrmDashboard();
                dashboard.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

    }
}
