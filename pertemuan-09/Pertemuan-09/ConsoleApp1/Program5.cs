using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Microsoft.SqlServer.Server;

namespace ConsoleApp1
{
   public class Program5
   {
      static void Main()
      {

         // connectionstring
         string connString = @"Server=.\sql2019express; Database=db_addressbook; Trusted_Connection=true";

         string sqlCommand = @"select * from addressbook";

         try
         {
            // object dataset
            DataSet ds;
            // create connection to db
            using (var conn = new SqlConnection(connString))
            {
               // create command to send sql statement to DBMS
               using (var cmd = new SqlCommand(sqlCommand, conn))
               {
                  // create dataadapter object to bridge connection between dataset and DBMS
                  using (var da = new SqlDataAdapter(cmd))
                  {
                     ds = new DataSet();
                     // fill dataset with data from DBMS
                     // dataset will become virtual database in client computer memory
                     da.Fill(ds, "addressbook");
                  }
               }
            }

            // cek if ds is not null and contains tables addressbook and has some data row
            if (ds?.Tables["addressbook"]?.Rows.Count > 0)
            {
               // loop all data in datatable addressbook
               foreach (DataRow dr in ds.Tables["addressbook"].Rows)
               {
                  Console.WriteLine($"{dr["nama"],-20} {dr["kota"]}");
               }
            }

         }
         catch (Exception ex)
         {
            Console.WriteLine($"Error: {ex.Message}");
         }
         Console.ReadKey();
      }
   }
}
