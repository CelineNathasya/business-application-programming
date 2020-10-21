using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class AddressBook
   {
      public int No { get; set; }
      public string Nama { get; set; }
      public string Alamat { get; set; }
      public string Kota { get; set; }
      public string KodePos { get; set; }
      public string NomorHP { get; set; }
      public string Keterangan { get; set; }
      public string Picture { get; set; }
      public DateTime? CreatedDate { get; set; }
      public DateTime? UpdatedDate { get; set; }
      public bool Deleted { get; set; }
   }
}
