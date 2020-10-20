using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using static System.Console;

// step by step working with database dengan cara .NET Framework Data Provider (Connected Approach)
// 1. connect to db [memerlukan connectionstring, berupa string,
//    bisa dideploy dengan helper dari object connectionstringbuilder]
// 2. lakukan operasi [CRUD]
// 3. close connection

// misalkan dicontoh ini, kita ingin membaca isi database (tabel addressbook)

namespace ConsoleApp1
{
   public class Program2
   {
      static void Main(string[] args)
      {

         // object connectionstringbuilder to help us create connectionstring
         SqlConnectionStringBuilder connStringBuilder = null;

         try
         {

            // create connectionstring via connectionstringbuilder object
            connStringBuilder = new SqlConnectionStringBuilder()
            {
               DataSource = @".\sql2019express",
               InitialCatalog = "db_addressbook",
               IntegratedSecurity = true
            };

            // create connection - with using - auto close
            using (SqlConnection conn = new SqlConnection(connStringBuilder.ToString()))
            {
               conn.Open(); // open connection
               // create command object to send sql statement to DBMS
               using (SqlCommand cmd = new SqlCommand())
               {
                  // set command object to use active connection object
                  cmd.Connection = conn;
                  // set sql statement to read all data from addressbook table
                  cmd.CommandText = @"select nama, kota from addressbook";
                  // to read, we need sqldatareader object
                  SqlDataReader reader = cmd.ExecuteReader();
                  if (reader.HasRows)
                  {
                     WriteLine(new string('-', 50));
                     WriteLine($"{"Nama",-30} {"Kota"}");
                     WriteLine(new string('-', 50));
                     while (reader.Read()) // read the data from sqldatareader object
                     {
                        string nama = reader["nama"].ToString();
                        string kota = reader["kota"].ToString();
                        WriteLine($"{nama, -30} {kota}");
                     }
                     WriteLine(new string('-', 50));
                  }
               }
            }
            WriteLine("Done.");

         }
         catch (Exception ex)
         {
            WriteLine($"Error: {ex.Message}");
         }
         ReadKey();
      }
   }
}
