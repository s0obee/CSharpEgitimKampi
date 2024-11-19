using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net

            Console.WriteLine("***** C# VERİTABANLI ÜRÜN KATEGORİ BİLGİ SİSTEMİ *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1- Kategoriler ..: ");
            Console.WriteLine("2- Ürünler ..: ");
            Console.WriteLine("3- Siparişler ..: ");
            Console.WriteLine("4- Çıkış Yap ..: ");
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Lütfen Getirmek İstediğiniz Tablo Numarasını Giriniz ..: ");
            tableNumber = Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data Source=LAPTOP-AB9O2GFR\\SQLEXPRESS;initial Catalog=EgitimKampiDB;integrated security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("Select * From tblCatagory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }


            Console.Read();
        }
    }
}
