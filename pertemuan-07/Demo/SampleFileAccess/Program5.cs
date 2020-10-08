using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace SampleFileAccess
{
   public class Program5
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Program5");
         string namafile = @".\..\..\sampleJSON.txt";
         try
         {
            if (File.Exists(namafile))
            {
               string fileContent = string.Empty;
               using (FileStream fs = new FileStream(namafile, FileMode.Open, FileAccess.Read))
               {
                  using (StreamReader reader = new StreamReader(fs))
                  {
                     fileContent = reader.ReadToEnd();
                  }
               }
               if (fileContent.Length > 0)
               {
                  List<Mahasiswa> listDataMahasiswa = JsonConvert.DeserializeObject<List<Mahasiswa>>(fileContent);
                  Console.WriteLine(new string('-', 6 * 20));
                  Console.WriteLine($"{"Nim", -20}{"Nama", -20}{"Tempat Lahir", -20}{"Tanggal Lahir", -20}{"Waktu Kuliah", -20}{"Kelas", -20}");
                  Console.WriteLine(new string('-', 6 * 20));
                  foreach (Mahasiswa item in listDataMahasiswa)
                  {
                     Console.WriteLine(item);
                  }
                  Console.WriteLine(new string('-', 6 * 20));
               }
            }
         }
         catch (Exception ex)
         {
            Console.WriteLine($"Error: {ex.Message}");
         }
      }
   }
}
