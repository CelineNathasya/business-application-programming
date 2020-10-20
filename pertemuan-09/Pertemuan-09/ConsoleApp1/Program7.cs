using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Dapper;

// kali ini kita akan memanfaatkan DAPPER (Micro ORM yang dapat digunakan untuk .NET)
// librarynya bisa diinstall via nuget package manager
// https://www.nuget.org/packages/Dapper
// It is a three - step process.
// 1. Create an IDbConnection object.
// 2. Write a query to perform CRUD operations.
// 3. Pass query as a parameter in the Execute method.


namespace ConsoleApp1
{

   public class Program7
   {
      static void Main()
      {

         string connString = @"Data Source = .\sql2019express; Initial Catalog = db_addressbook; Integrated Security = True";

         try
         {
            IEnumerable<AddressBook> listData = null;
            using (IDbConnection conn = new SqlConnection(connString)) // step-1
            {
               conn.Execute("insert into addressbook (nama, kota) values (@nama, @kota)", new { nama = "Robin", kota = "Langkat" }); // step-3
               listData = conn.Query<AddressBook>("select no, nama, kota from addressbook"); // step-2
            }
            foreach (AddressBook item in listData)
            {
               Console.WriteLine($"{item.Nama, -20} {item.Kota}");
            }
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Error: {ex.Message}");
         }
         Console.ReadKey();
      }
   }

   class AddressBook
   {
      public int No { get; set; }
      public string Nama { get; set; }
      public string Kota { get; set; }
   }



}
