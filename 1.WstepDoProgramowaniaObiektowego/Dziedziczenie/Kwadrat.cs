using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WstepDoProgramowaniaObiektowego.Dziedziczenie
{
   public sealed class Kwadrat : Figura // klasa kwadrat dziedziczy po klasie Figura/
      // modyfikator sealed sprawia, że nie można dziedziczyć z tej klasy
      // to oznacza, że nabywa wszystkie właściwości klasy Figura.
      // Jeżeli właściwości w klasie figura są private to nadal nie mamy do nich dostępu
   {
      public double bokA;

      public Kwadrat(double a, string nazwa, string kolor) 
         : base(nazwa, kolor)
      {
         bokA = a;
      }

      public override void ObliczObwod() // nadpisujemy metodę z klasy bazowej. 
                                         // Teraz metoda oblicz obw może dostać prawidłową implementację, bo wiemy co to za figura
      {
         Console.WriteLine($"Obwód kwadratu o boku {bokA} to : {4 * bokA}");
      }

      public override void ObliczPole()
      {
         Console.WriteLine($"Pole kwadratu o boku {bokA} to : {bokA * bokA}");
      }

   }
}
