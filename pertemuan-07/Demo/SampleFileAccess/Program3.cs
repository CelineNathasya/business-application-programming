using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SampleFileAccess
{
   public class Program3
   {
      static void Main(string[] args)
      {
         List<Mahasiswa> listDataMahasiswa = new List<Mahasiswa>()
         {
            new Mahasiswa("201110001", "Syamsul", "Medan", "10/10/2001", "Pagi", "A"),
            new Mahasiswa("201110002", "David", "Medan", "11/10/2001", "Pagi", "A"),
            new Mahasiswa("201110003", "Tina", "Medan", "12/10/2001", "Pagi", "A"),
            new Mahasiswa("201110004", "Carin", "Medan", "13/10/2001", "Pagi", "A"),
            new Mahasiswa("201110005", "Sean", "Medan", "14/10/2001", "Pagi", "A"),
         };
         string namafileOutput = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\Output.txt";
         try
         {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nim;Nama;TempatLahir;TanggalLahir;WaktuKuliah;Kelas");
            foreach (Mahasiswa item in listDataMahasiswa)
            {
               sb.AppendLine($"{item.Nim};{item.Nama};{item.TempatLahir};{(item.TanggalLahir.HasValue ? item.TanggalLahir.Value.ToShortDateString() : "")};{item.WaktuKuliah};{item.Kelas}");
            }
            File.WriteAllText(namafileOutput, sb.ToString());
            Console.WriteLine($"File {Path.GetFileName(namafileOutput)} Created Successfully.");
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Error: {ex.Message}");
         }
      }
   }
}
