using CSharpEgitimKampi501.Dtos;
using Dapper;
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

namespace CSharpEgitimKampi501
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Server=DESKTOP-82HPLIB\\SQLEXPRESS; initial Catalog=EgitimKampi501Db; integrated security=true");

        private async void btnList_Click(object sender, EventArgs e)
        {
            string query = "Select * From TblProduct ";
            var values = await connection.QueryAsync<ResultProductDto>(query);
            dataGridView1.DataSource = values;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            string query = "Insert into TblProduct(ProductName, ProductStock, ProductPrice,ProductCategory) values (@productName,@productStock, @productPrice, @productCategory)";
            var parameters = new DynamicParameters();
            parameters.Add("productName", txtProductName.Text);
            parameters.Add("ProductStock", txtProductStock.Text);
            parameters.Add("productPrice", txtProductPrice.Text);
            parameters.Add("productCategory", txtProductCategory.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Eklendi");
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "Delete from TblProduct where ProductId = @productId";
            var parameters = new DynamicParameters();
            parameters.Add("productId", txtProductId.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Silindi");
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update TblProduct set ProductName=@productName, ProductStock=@productStock, ProductPrice=@productPrice,ProductCategory=@productCategory where ProductId=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("productName", txtProductName.Text);
            parameters.Add("ProductStock", txtProductStock.Text);
            parameters.Add("productPrice", txtProductPrice.Text);
            parameters.Add("productCategory", txtProductCategory.Text);
            parameters.Add("productId", txtProductId.Text);
            await connection.ExecuteAsync(query, parameters);
            MessageBox.Show("Güncellendi", "Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string query1 = "Select Count(*) From TblProduct";
            var productTotalCount = await connection.QueryFirstOrDefaultAsync<int>(query1);
            lblTotalProductPrice.Text = productTotalCount.ToString();

            string query2 = "select ProductName from TblProduct where ProductPrice=(Select Max (ProductPrice) From TblProduct)";
            var maxPriceProductName = await connection.QueryFirstOrDefaultAsync<string>(query2);
            lblMaxPriceProductCount.Text = maxPriceProductName.ToString();

            string query3 = "select count(Distinct(ProductCategory))From TblProduct";
            var distinctProductCount=await connection.QueryFirstOrDefaultAsync<int>(query3);
            lblDistinctProductCategory.Text = distinctProductCount.ToString();
        }

       
    }
}
