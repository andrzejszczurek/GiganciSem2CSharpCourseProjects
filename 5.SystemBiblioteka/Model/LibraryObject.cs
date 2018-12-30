using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SystemBiblioteka.Model
{
   public abstract class LibraryObject
   {
      public decimal Price;
      public string Description;

      public static string filePath = AppDomain.CurrentDomain.BaseDirectory + @"../../Biblioteka.txt";

      public LibraryObject(decimal price, string description)
      {
         Price = price;
         Description = description;
      }

   }
}
