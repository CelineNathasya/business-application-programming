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

// misalkan dicontoh ini, kita ingin mengupdate isi database (tabel addressbook)
// dan pada contoh kali ini kita akan memanfaatkan transaction untuk menjaga integritas data
// [berhasil semua atau gagal semua]

namespace ConsoleApp1
{
   public class Program4
   {
      static void Main()
      {
         // connectionstring
         string connString = @"Server=.\sql2019express; Database=db_addressbook; Trusted_Connection=true";

         // object connection
         SqlConnection conn = null;

         // object transaction
         SqlTransaction trans = null;


         try
         {
            // 1. create connection to db via connectionstring dan koneksinya harus dibuka
            conn = new SqlConnection(connString);

            conn.Open(); // buka koneksi ke database dari program anda

            trans = conn.BeginTransaction(); // operasi dijaga dengan menambahkan transaction

            // 2. lakukan operasi yang diinginkan [CRUD]
            // data pada saat ini :
            // (Budi, Medan)
            // (Iwan, Medan)
            // (Robert, Medan)
            // (Susan, Medan)
            // (Susanna, Medan)
            // (Tina, Binjai)
            // (Tasya, Binjai)
            // (Tini, Binjai)
            // (Tifanny, Binjai)
            // (Tika, Binjai)
            // misalkan pada contoh ini, kita ingin delete data ke tabel addressbook
            // misalkan kita ingin menghapus semua data yang berasal dari kota binjai dari tabel addressbook
            // untuk melakukan delete kita butuh object Command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn; // set agar command memanfaatkan koneksi ke db yang ada
            cmd.Transaction = trans; // set agar command memanfaatkan trans yang ada

            int recCount = 0;

            // set sql statement untuk melakukan operasi delete data ke tabel addressbook
            // delete semua data yang berasal dari kota binjai
            // pada contoh ini kita menggunakan sql prepared statement
            cmd.CommandText = @"delete from addressbook where kota = @kota";
            cmd.Parameters.AddWithValue("@kota", "Binjai"); // provide parameter data kota yang akan dihapus
            recCount = cmd.ExecuteNonQuery(); // eksekusi sql statement ke DBMS

            trans.Commit(); // kukuhkan perubahan

            Console.WriteLine($"{recCount} Record data berhasil didelete dari database.");

            // 3. tutup koneksi ke database jika sudah selesai digunakan
            conn.Close();

            Console.WriteLine("Done.");

         }
         catch (SqlException)
         {
            // rollback semua perubahan jika ada terjadi kesalahan saat melakukan operasi update
            if (trans != null) trans.Rollback();
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Error: {ex.Message}");
         }
         Console.ReadKey();
      }
   }
}
