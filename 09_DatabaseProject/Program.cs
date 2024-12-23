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

            //C# dilinde SQL yapılarını kullanmamızı sağlayan bir çerçevedir

            Console.WriteLine("***** C# Veritabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("1- Kategoriler");
            Console.WriteLine("2    - Ürünler");
            Console.WriteLine("3- Siparişler");
            Console.WriteLine("4- Çıkış Yap");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("------------------------------------------");

            //SQL Bağlantısını kuruyoruz.
            SqlConnection connection = new SqlConnection("Data Source=MB\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            connection.Open();  //bağlantıyı açıyoruz

            //Bir sorgu oluşturduk, bu bize tüm TblCategory değerlerini connection ile bağladığımız veritabanından getirecek
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);  //c# sorguyla sql arasında bir köprü görevi görür

            DataTable dataTable = new DataTable(); //verileri geçici belleğe almamızı sağlar.
            adapter.Fill(dataTable); //
            connection.Close(); //bağlantıyı kapattık

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
