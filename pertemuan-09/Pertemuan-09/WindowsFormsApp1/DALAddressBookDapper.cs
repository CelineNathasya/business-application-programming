using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
   public class DALAddressBookDapper : IDisposable
   {

      private bool disposedValue;

      SqlConnection conn = null;

      public DALAddressBookDapper()
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

      public IEnumerable<AddressBook> QueryData(string namaQuery)
      {
         IEnumerable<AddressBook> listData = null;
         try
         {
            listData = conn.Query<AddressBook>("select * from addressbook where deleted = 0 and nama like @nama order by no",
                                                new { nama = $"{namaQuery}%" });
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
            conn.Execute(@"insert into addressbook (nama, alamat, kota, kodepos, nomorhp, keterangan, picture, createddate) 
                           values (@nama, @alamat, @kota, @kodepos, @nomorhp, @keterangan, @picture, @createddate)",
                           item, transaction: trans);
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
            conn.Execute(@"update addressbook set nama = @nama, alamat = @alamat, kota = @kota, kodepos = @kodepos, nomorhp = @nomorhp, 
                           keterangan = @keterangan, picture = @picture, updateddate = @updateddate where no = @no",
                           item, transaction: trans);
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
            conn.Execute(@"update addressbook set deleted = 1 where no = @no",
                           new { no }, transaction: trans);
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
      // ~DALAddressBookDapper()
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
