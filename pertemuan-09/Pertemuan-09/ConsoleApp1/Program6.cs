using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// step by step working with database dengan cara ADO.NET DataSet (Disconnected Approach)
// 1. connect to db [memerlukan connectionstring, berupa string,
//    bisa dideploy dengan helper dari object connectionstringbuilder]
// 2. create dataadapter object,
// 3. create commandbuilder object,
// 4. create dataset object,
// 5. fill data dan dataschema ke dataset berdasarkan data di DBMS via dataadapter object
// 6. working with dataset (insert, select, update, delete)
// 7. update perubahan pada dataset ke DBMS via dataadapter object dengan memanggil method update
// 8. close connection

namespace ConsoleApp1
{
   public class Program6
   {
      static void Main()
      {

         // connectionstring
         string connString = @"Server=.\sql2019express; Database=db_addressbook; Trusted_Connection=true";

         string sqlCommand = @"select * from addressbook";

         SqlConnection conn = null;

         SqlDataAdapter da = null;

         SqlCommandBuilder cmdBuilder = null;

         SqlCommand cmd = null;

         DataSet ds = null;

         try
         {

            // create aktive connection
            conn = new SqlConnection(connString);

            // open connection to db
            conn.Open();

            // create dataset object
            ds = new DataSet();

            // create command object
            cmd = new SqlCommand(sqlCommand, conn);

            // create data adapter object via cmd object
            da = new SqlDataAdapter(cmd);

            // create commandbuilder to auto generate insert, update and delete command for dataadapter
            cmdBuilder = new SqlCommandBuilder(da);

            // get table schema from table addressbook
            da.FillSchema(ds, SchemaType.Source, "addressbook");
            // load data to dataset, source table from table addressbook
            da.Fill(ds, "addressbook");

            // display all data
            Console.WriteLine("mula-mula:");
            if (ds?.Tables["addressbook"]?.Rows.Count > 0)
            {
               foreach (DataRow dr in ds.Tables["addressbook"].Rows)
               {
                  Console.WriteLine($"{dr["nama"], -20} {dr["kota"]}");
               }
            }
            Console.WriteLine();

            // insert new data

            var newRow = ds.Tables["addressbook"].NewRow();
            newRow["nama"] = "Tina";
            newRow["kota"] = "Binjai";

            var anotherNewRow = ds.Tables["addressbook"].NewRow();
            anotherNewRow["nama"] = "Tiara";
            anotherNewRow["kota"] = "Binjai";

            ds.Tables["addressbook"].Rows.Add(newRow);
            ds.Tables["addressbook"].Rows.Add(anotherNewRow);

            // display perubahan data
            Console.WriteLine("perubahan (after insert):");
            if (ds?.Tables["addressbook"]?.Rows.Count > 0)
            {
               foreach (DataRow dr in ds.Tables["addressbook"].Rows)
               {
                  Console.WriteLine($"{dr["nama"],-20} {dr["kota"]}");
               }
            }
            Console.WriteLine();

            //update
            //misal mau update data dengan nama Robert, ubah kota dari Medan menjadi Berastagi

            // cari data yang mao diedit
            DataRow rowEdit = ds.Tables["addressbook"].Select("Nama = 'Tiara'").FirstOrDefault();

            if (rowEdit != null)
            {
               // mulai edit
               rowEdit.BeginEdit();
               rowEdit["kota"] = "Berastagi";
               rowEdit.EndEdit();
               // akhiri pengeditan
            }

            // display perubahan data
            Console.WriteLine("perubahan (after update):");
            if (ds?.Tables["addressbook"]?.Rows.Count > 0)
            {
               foreach (DataRow dr in ds.Tables["addressbook"].Rows)
               {
                  Console.WriteLine($"{dr["nama"],-20} {dr["kota"]}");
               }
            }
            Console.WriteLine();

            // delete
            // misal kita ingin menghapus data dengan nama iwan

            // get row yang akan dihapus
            // cari data yang mao dihapus
            // misal kita ingin menghapus data dengan nama Tina
            var rowToDelete = ds.Tables["addressbook"].Select("Nama = 'Tina'").FirstOrDefault();
            if (rowToDelete != null)
            {
               ds.Tables["addressbook"].Rows.Remove(rowToDelete);
            }

            // display perubahan data
            Console.WriteLine("perubahan (after delete):");
            if (ds?.Tables["addressbook"]?.Rows.Count > 0)
            {
               foreach (DataRow dr in ds.Tables["addressbook"].Rows)
               {
                  Console.WriteLine($"{dr["nama"],-20} {dr["kota"]}");
               }
            }
            Console.WriteLine();

            // kukuhkan semua perubahan ke database
            da.Update(ds.Tables["addressbook"]);


            Console.WriteLine("Done.");

         }
         catch (Exception ex)
         {
            Console.WriteLine($"Error: {ex.Message}");
         }
         finally
         {
            // bersih-bersih
            if (ds != null) ds.Dispose();
            if (cmdBuilder != null) cmdBuilder.Dispose();
            if (da != null) da.Dispose();
            if (cmd != null) cmd.Dispose();
            if (conn != null) conn.Close();
         }
         Console.ReadKey();
      }
   }
}
