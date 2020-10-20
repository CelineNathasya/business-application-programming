using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

// step by step working with database dengan cara .NET Framework Data Provider (Connected Approach)
// 1. connect to db [memerlukan connectionstring, berupa string,
//    bisa dideploy dengan helper dari object connectionstringbuilder]
// 2. lakukan operasi [CRUD]
// 3. close connection


namespace ConsoleApp1
{
   class Program1
   {
      static void Main(string[] args)
      {
         // connectionstring
         string connString = @"Server=.\sql2019express; Database=db_addressbook; Trusted_Connection=true";

         // object connection
         SqlConnection conn = null;


         try
         {
            // 1. create connection to db via connectionstring dan koneksinya harus dibuka
            conn = new SqlConnection(connString);

            conn.Open(); // buka koneksi ke database dari program anda

            // 2. lakukan operasi yang diinginkan [CRUD]
            // misalkan pada contoh ini, kita ingin insert 5 data baru ke tabel addressbook
            // (Budi, Medan)
            // (Iwan, Medan)
            // (Robert, Medan)
            // (Susan, Medan)
            // (Susanna, Medan)

            List<(string, string)> listData = new List<(string, string)>
            {
               ("Budi", "Medan"),
               ("Iwan", "Medan"),
               ("Robert", "Medan"),
               ("Susan", "Medan"),
               ("Susanna", "Medan"),
            };

            // untuk melakukan operasi Insert, Update dan Delete kita butuh object Command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = System.Data.CommandType.Text;

            // contoh kali ini, kita menggunakan pure sql statement
            int recCount = 0;
            foreach (var (nama, kota) in listData)
            {
               cmd.CommandText = "insert into addressbook (nama, kota) values ('" + nama + "', '" + kota + "')";
               recCount += cmd.ExecuteNonQuery(); // untuk mengirimkan sql command ke DBMS untuk dieksekusi
            }

            Console.WriteLine($"{recCount} Record data berhasil ditambahkan ke database.");

            // tambah 5 data baru kembali
            // (Tina, Medan)
            // (Tasya, Medan)
            // (Tini, Medan)
            // (Tifanny, Medan)
            // (Tika, Medan)

            var listDataLainnya = new List<(string, string)>
            {
               ("Tina", "Medan"),
               ("Tasya", "Medan"),
               ("Tini", "Medan"),
               ("Tiffany", "Medan"),
               ("Tika", "Medan"),
            };

            // reset counter
            recCount = 0;

            // kali ini kita akan menggunakan prepared sql statement
            // kita siapkan sql statement dan parameternya
            cmd.CommandText = @"insert into addressbook (nama, kota) values (@nama, @kota)";
            SqlParameter param1 = new SqlParameter("@nama", typeof(string));
            SqlParameter param2 = new SqlParameter("@kota", typeof(string));
            cmd.Parameters.Add(param1);
            cmd.Parameters.Add(param2);
            // load dengan data dan kirim ke DBMS
            foreach (var (nama, kota) in listDataLainnya)
            {
               param1.Value = nama;
               param2.Value = kota;
               recCount += cmd.ExecuteNonQuery();
            }

            Console.WriteLine($"{recCount} Record data berhasil ditambahkan ke database.");

            // 3. tutup koneksi ke database jika sudah selesai digunakan
            conn.Close();

            Console.WriteLine("Done.");

         }
         catch (Exception ex)
         {
            Console.WriteLine($"Error: {ex.Message}");
         }
         Console.ReadKey();
      }
   }
}
