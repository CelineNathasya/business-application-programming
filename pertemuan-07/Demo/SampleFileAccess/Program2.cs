using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SampleFileAccess
{
   public class Program2
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Program2");
         string namafile = @".\..\..\sample.txt";
         try
         {
            if (File.Exists(namafile))
            {
               string[] fileContent = File.ReadAllLines(namafile);
               if (fileContent.Length > 0)
               {
                  string header = fileContent[0];
                  string[] arrHeader = header.Split(';');
                  Console.WriteLine(new string('-', arrHeader.Length * 20));
                  foreach (string item in arrHeader)
                  {
                     Console.Write($"{item,-20}");
                  }
                  Console.WriteLine();
                  Console.WriteLine(new StringBuilder().Insert(0, "-", arrHeader.Length * 20).ToString());
                  List<Mahasiswa> listDataMahasiswa = new List<Mahasiswa>();
                  foreach (string line in fileContent.Skip(1))
                  {
                     string[] arrline = line.Split(';');
                     string nim = arrline[0].Trim();
                     string nama = arrline[1].Trim();
                     string tempatLahir = arrline[2].Trim();
                     string tanggalLahir = arrline[3].Trim();
                     string waktuKuliah = arrline[4].Trim();
                     string kelas = arrline[5].Trim();
                     Mahasiswa mhs = new Mahasiswa(nim, nama, tempatLahir, tanggalLahir, waktuKuliah, kelas);
                     listDataMahasiswa.Add(mhs);
                     Console.WriteLine(mhs);
                  }
                  Console.WriteLine(new string('-', arrHeader.Length * 20));
                  int countMahasiswaPagi =
                     (from item in listDataMahasiswa
                      where item.WaktuKuliah.Equals("pagi", StringComparison.CurrentCultureIgnoreCase)
                      select item).Count();
                  int countMahasiswaSore =
                     listDataMahasiswa.Where(item => item.WaktuKuliah.Equals("sore", StringComparison.CurrentCultureIgnoreCase)).Count();
                  Console.WriteLine($"Banyak Mahasiswa Kelas Pagi: {countMahasiswaPagi}");
                  Console.WriteLine($"Banyak Mahasiswa Kelas Sore: {countMahasiswaSore}");
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
