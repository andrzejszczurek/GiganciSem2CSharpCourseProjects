using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.PrzegladarkaInternetowa
{
   public class Ulubione
   {
      public string Url;
      public string Title;

      public Ulubione(string url, string title)
      {
         Title = title;
         Url = url;
      }

      public override string ToString()
      {
         return Title;
      }

      public static List<Ulubione> OdczytajUlubioneZPliku(string path)
      {
         List<Ulubione> ulubione = new List<Ulubione>();

         using (StreamReader sr = new StreamReader(path))
         {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
               string[] dane = line.Split('|');
               Ulubione u = new Ulubione(dane[1], dane[0]);
               ulubione.Add(u);
            }
         }
         return ulubione;
      }

      public static void ZapiszUlubioneDoPliku(Ulubione ulubione, string path)
      {
         using (StreamWriter sr = new StreamWriter(path, true))
         {
            string strona = $"{ulubione.Title}|{ulubione.Url}";
            sr.WriteLine(strona);
         }
      }

   }
}
