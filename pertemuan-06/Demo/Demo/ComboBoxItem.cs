﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
   public class ComboBoxItem
   {
      public string ColorName { get; set; }
      public int Red { get; set; }
      public int Green { get; set; }
      public int Blue { get; set; }
      public override string ToString()
      {
         return ColorName;
      }
   }
}
