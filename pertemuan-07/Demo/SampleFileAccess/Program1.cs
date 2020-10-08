using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SampleFileAccess
{
   class Program1
   {
      static void Main(string[] args)
      {
         Console.WriteLine("Program1");
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
                  foreach (string line in fileContent.Skip(1))
                  {
                     string[] arrline = line.Split(';');
                     foreach (string item in arrline)
                     {
                        Console.Write($"{item,-20}");
                     }
                     Console.WriteLine();
                  }
                  Console.WriteLine(new string('-', arrHeader.Length * 20));
                  int countMahasiswaPagi = 0;
                  int countMahasiswaSore = 0;
                  foreach (string line in fileContent.Skip(1))
                  {
                     string[] arrline = line.Split(';');
                     string waktuKuliah = arrline[4].ToLower().Trim();
                     switch (waktuKuliah)
                     {
                        case "pagi":
                           ++countMahasiswaPagi;
                           break;
                        case "sore":
                           ++countMahasiswaSore;
                           break;
                     }
                  }
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
