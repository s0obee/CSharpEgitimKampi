using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud --> Create - Read - Update - Delete

            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****");
            Console.WriteLine();

            Console.WriteLine("-------------------------------------");

            #region Kategori Ekleme İşlemi

            //Console.Write("Eklemek İstediğiniz Kategori Adi ..: ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-AB9O2GFR\\SQLEXPRESS;initial Catalog=EgitimKampiDB;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into tblCatagory (categoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori Başarıyla Eklendi ..: ");

            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Eklemek İstediğiniz Ürün Adı ..: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatı ..: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-AB9O2GFR\\SQLEXPRESS;initial Catalog=EgitimKampiDB;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into tblProduct (productName, productPrice, productStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Ürün Eklemesi Başarılı");




            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-AB9O2GFR\\SQLEXPRESS;initial Catalog=EgitimKampiDB;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From tblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //adapter.Fill(dt);

            //foreach (DataRow dr in dt.Rows) 
            //{
            //    foreach (var item in dr.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İŞlemi

            //Console.Write("Silinecek Değer ..: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-AB9O2GFR\\SQLEXPRESS;initial Catalog=EgitimKampiDB;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From tblProduct Where ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme İşlemi Tamamlandı ..: ");
            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün Id ..: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı ..: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürün Fiyatı ..: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=LAPTOP-AB9O2GFR\\SQLEXPRESS;initial Catalog=EgitimKampiDB;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Update tblProduct Set ProductName = @productName,ProductPrice = @productPrice Where ProductId = @productId", connection);
           
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Güncelleme İşlemi Tamamlandı ..: ");

            #endregion

            Console.Read();
        }
    }
}
