using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace SampleFileAccess
{
   public class Program4
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
         string namafileOutput = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\OutputJSON.txt";
         try
         {
            string jsonString = JsonConvert.SerializeObject(listDataMahasiswa, Formatting.Indented);
            using (FileStream fs = new FileStream(namafileOutput, FileMode.Create, FileAccess.Write))
            {
               using (StreamWriter writer = new StreamWriter(fs))
               {
                  writer.Write(jsonString);
               }
            }
            Console.WriteLine($"File {Path.GetFileName(namafileOutput)} Created Successfully.");
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Error: {ex.Message}");
         }
      }
   }
}
