using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitas
{
   public class Mahasiswa
   {
      public string Nim { get; set; }
      public string Nama { get; set; }
      public string TempatLahir { get; set; }
      public DateTime? TanggalLahir { get; set; }
      public string WaktuKuliah { get; set; }
      public string Kelas { get; set; }

      public Mahasiswa(string nim, string nama, string tempatLahir, string tanggalLahir, string waktuKuliah, string kelas)
      {
         this.Nim = nim;
         this.Nama = nama;
         this.TempatLahir = tempatLahir;
         if (DateTime.TryParse(tanggalLahir, out DateTime tglLahir))
            this.TanggalLahir = tglLahir;
         this.WaktuKuliah = waktuKuliah;
         this.Kelas = kelas;
      }

      public override string ToString()
      {
         return $"{this.Nim,-20}{this.Nama,-20}{this.TempatLahir,-20}{(this.TanggalLahir.HasValue ? this.TanggalLahir.Value.ToShortDateString() : ""),-20}{this.WaktuKuliah,-20}{this.Kelas,-20}";
      }

   }
}
