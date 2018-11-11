using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WstepDoProgramowaniaObiektowego.Dziedziczenie
{
   public class Kolo : Figura
   {
      public double promien;

      public Kolo(double r, string nazwa, string kolor) : base(nazwa, kolor) 
         // ponieważ klasa bazowa ma tylko konstruktor z parametrami to musimy go także wywołać
         // robimy to za pomocą słowa kluczowego base(), gdzie w nawiasi przekazujemy parametry
      {
         promien = r;
      }

      public override void ObliczObwod() // nadpisujemy metodę z klasy bazowej. 
         // Teraz metoda oblicz obw może dostać prawidłową implementację, bo wiemy co to za figura
      {
         Console.WriteLine($"Obwód koła o promieniu {promien} to : {2 * promien * Math.PI}");
      }

      public override void ObliczPole()
      {
         Console.WriteLine($"Pole koła o promieniu {promien} to : {promien * promien * Math.PI}");
      }
   }
}
