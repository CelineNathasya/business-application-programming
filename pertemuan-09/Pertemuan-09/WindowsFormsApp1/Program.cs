using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         //Application.Run(new FrmAddressBook1());
         //Application.Run(new FrmAddressBook2());
         //Application.Run(new FrmAddressBook3());
         //Application.Run(new FrmAddressBook4());
         Application.Run(new FrmAddressBook5());
      }
   }
}
