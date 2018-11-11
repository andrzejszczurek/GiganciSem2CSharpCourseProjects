using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WstepDoProgramowaniaObiektowego.Dziedziczenie
{
   public abstract class Figura // to będzie klasa bazowa dla naszych figur
      // słowko abstract oznacza, że nie można tworzyć obiektów takiej klasy
      // będzie ona zawierała właściwości wspólne dla wszystkich klas konkretnych figur
      // domyślnie każda klasa dziedziczy z klasy Object
   {
      protected string _nazwa; // modyfikator protected oznacza, że pole jest niewidoczne z poza klasy,
                              // ale jest widoczne dla klas które dziedziczą po tej klasie

      protected string _kolor;


      public Figura(string nazwa, string kolor)
      {
         _nazwa = kolor;
         _kolor = kolor;
      }

      public virtual void ObliczPole() // metody oznaczone jako virtual mogą zostać nadpisane w klasach potomnych
         // oznacza to, że zystają one nową implementacje
      {
         Console.WriteLine("Klasa figura, nie można obliczyć pola, bo nie wiem jaką figurą jestem");
      }

      public virtual void ObliczObwod()
      {
         Console.WriteLine("Klasa figura, nie można obliczyć obwodu, bo nie wiem jaką figurą jestem");
      }
   }
}
