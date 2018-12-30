using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SystemBiblioteka.Model
{
   public class Game : LibraryObject
   {
      public int AgeLimit;
      public string Title;

      public Game(int ageLimit, string title, string description, decimal price)
         : base(price, description)
      {
         AgeLimit = ageLimit;
         Title = title;
      }

      public override string ToString()
      {
         return Title;
      }

      public void SaveToFile()
      {
         using (StreamWriter sw = new StreamWriter(filePath))
         {
            sw.WriteLine($"{AgeLimit}|{Title}|{Description}|{Price}");
         }
      }


   }
}
