using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
   public class DALAddressBook : IDisposable
   {

      private bool disposedValue;

      SqlConnection conn = null;

      public DALAddressBook()
      {
         try
         {
            conn = new SqlConnection(Parameter.connString);
            conn.Open();
         }
         catch (Exception)
         {
            throw;
         }
      }

      public List<AddressBook> QueryData(string namaQuery)
      {
         List<AddressBook> listData = null;
         try
         {
            using (var cmd = new SqlCommand("select * from addressbook where deleted = 0 and nama like @nama order by no", conn))
            {
               cmd.Parameters.Clear();
               cmd.Parameters.AddWithValue("@nama", $"{namaQuery}%");
               using (var reader = cmd.ExecuteReader())
               {
                  if (reader.HasRows)
                  {
                     listData = new List<AddressBook>();
                     while (reader.Read())
                     {
                        string no = reader["no"].ToString();
                        string nama = reader["nama"].ToString();
                        string alamat = reader["alamat"].ToString();
                        string kota = reader["kota"].ToString();
                        string kodePos = reader["kodepos"].ToString();
                        string nomorHP = reader["nomorhp"].ToString();
                        string keterangan = reader["keterangan"].ToString();
                        string picture = reader["picture"].ToString();
                        string strCreatedDate = reader["createddate"].ToString();
                        DateTime? createdDate = default;
                        if (DateTime.TryParse(strCreatedDate, out DateTime tgl1)) createdDate = tgl1;
                        string strUpdatedDate = reader["updateddate"].ToString();
                        DateTime? updatedDate = default;
                        if (DateTime.TryParse(strUpdatedDate, out DateTime tgl2)) updatedDate = tgl2;
                        listData.Add(new AddressBook
                        {
                           No = Convert.ToInt32(no),
                           Nama = nama,
                           Alamat = alamat,
                           Kota = kota,
                           KodePos = kodePos,
                           NomorHP = nomorHP,
                           Keterangan = keterangan,
                           Picture = picture,
                           CreatedDate = createdDate,
                           UpdatedDate = updatedDate
                        });
                     }
                  }
               }
            }
         }
         catch (Exception)
         {
            throw;
         }
         return listData;
      }

      public bool Save(AddressBook item)
      {
         bool result = false;
         SqlTransaction trans = null;
         try
         {
            trans = conn.BeginTransaction();
            using (var cmd = new SqlCommand())
            {
               cmd.Connection = conn;
               cmd.Transaction = trans;
               cmd.CommandText =
                  @"insert into addressbook (nama, alamat, kota, kodepos, nomorhp, keterangan, picture, createddate) 
                     values (@nama, @alamat, @kota, @kodepos, @nomorhp, @keterangan, @picture, @createddate)";
               cmd.Parameters.Clear();
               cmd.Parameters.AddWithValue("@nama", item.Nama);
               cmd.Parameters.AddWithValue("@alamat", item.Alamat);
               cmd.Parameters.AddWithValue("@kota", item.Kota);
               cmd.Parameters.AddWithValue("@kodepos", item.KodePos);
               cmd.Parameters.AddWithValue("@nomorhp", item.NomorHP);
               cmd.Parameters.AddWithValue("@keterangan", item.Keterangan);
               cmd.Parameters.AddWithValue("@picture", item.Picture);
               cmd.Parameters.AddWithValue("@createddate", item.CreatedDate.Value);
               cmd.ExecuteNonQuery();
            }
            trans.Commit();
            result = true;
         }
         catch (Exception)
         {
            if (trans != null) trans.Rollback();
            throw;
         }
         finally
         {
            if (trans != null) trans.Dispose();
         }
         return result;
      }

      public bool Update(AddressBook item)
      {
         bool result = false;
         SqlTransaction trans = null;
         try
         {
            trans = conn.BeginTransaction();
            using (var cmd = new SqlCommand())
            {
               cmd.Connection = conn;
               cmd.Transaction = trans;
               cmd.CommandText =
                  @"update addressbook set nama = @nama, alamat = @alamat, kota = @kota, kodepos = @kodepos, nomorhp = @nomorhp, 
                     keterangan = @keterangan, picture = @picture, updateddate = @updateddate where no = @no";
               cmd.Parameters.Clear();
               cmd.Parameters.AddWithValue("@No", item.No);
               cmd.Parameters.AddWithValue("@nama", item.Nama);
               cmd.Parameters.AddWithValue("@alamat", item.Alamat);
               cmd.Parameters.AddWithValue("@kota", item.Kota);
               cmd.Parameters.AddWithValue("@kodepos", item.KodePos);
               cmd.Parameters.AddWithValue("@nomorhp", item.NomorHP);
               cmd.Parameters.AddWithValue("@keterangan", item.Keterangan);
               cmd.Parameters.AddWithValue("@picture", item.Picture);
               cmd.Parameters.AddWithValue("@updateddate", item.UpdatedDate.Value);
               cmd.ExecuteNonQuery();
            }
            trans.Commit();
            result = true;
         }
         catch (Exception)
         {
            if (trans != null) trans.Rollback();
            throw;
         }
         finally
         {
            if (trans != null) trans.Dispose();
         }
         return result;
      }

      public bool Delete(int no)
      {
         bool result = false;
         SqlTransaction trans = null;
         try
         {
            trans = conn.BeginTransaction();
            using (var cmd = new SqlCommand())
            {
               cmd.Connection = conn;
               cmd.Transaction = trans;
               cmd.CommandText = @"update addressbook set deleted = 1 where no = @no";
               cmd.Parameters.Clear();
               cmd.Parameters.AddWithValue("@No", no);
               cmd.ExecuteNonQuery();
            }
            trans.Commit();
            result = true;
         }
         catch (Exception)
         {
            if (trans != null) trans.Rollback();
            throw;
         }
         finally
         {
            if (trans != null) trans.Dispose();
         }
         return result;
      }

      protected virtual void Dispose(bool disposing)
      {
         if (!disposedValue)
         {
            if (disposing)
            {
               // TODO: dispose managed state (managed objects)
               if (conn != null) conn.Close();
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            disposedValue = true;
         }
      }

      // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
      // ~DALAddressBook()
      // {
      //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
      //     Dispose(disposing: false);
      // }

      public void Dispose()
      {
         // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
         Dispose(disposing: true);
         GC.SuppressFinalize(this);
      }
   }
}
