using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WstepDoProgramowaniaObiektowego.Dziedziczenie;
using WstepDoProgramowaniaObiektowego.Klasy;

namespace WstepDoProgramowaniaObiektowego
{
   class Program
   {
      static void Main(string[] args)
      {
         // PODSTAWY 

         // Tworzymy zmienną na obiekt naszej klasy
         Osoba mojaOsoba;

         // tworzymy nowy obiekt typu Osoba i przypisujemy go do zmiennej
         mojaOsoba = new Osoba(); // obiekty tworzymy za pomocą słowa kluczowego 'new'
         mojaOsoba.imie = "Jan";
         mojaOsoba.nazwisko = "Kowalski"; // ustawiamy własności publicznym polą klasy
         // nie mamy dostępu do zarobkow ponieważ są prywatne


         // tworzymy kolejny obiekt typu Osoba, tym razem korzystając z konstruktora z parametrami
         Osoba mojaOsoba2 = new Osoba("Michał", "Nowak", 2500m);

         mojaOsoba.WpiszDane(); // wywołujemy metodę zdefiniowaną w klasie Osoba 

         // DZIEDZICZENIE

         Kolo kolo = new Kolo(5.6, "k1", "Niebieski");
         kolo.ObliczObwod();
         kolo.ObliczPole();
         Kwadrat kwadrat = new Kwadrat(5, "kw1", "Czerwony");
         kwadrat.ObliczObwod();
         kwadrat.ObliczPole();

         // POLIMORFIZM
         // czyli inaczej wielopostaciowość
         // ponieważ nasz kwadrat dziedziczy z klasy figura można powiedzieć, że jest on figurą
         // co zresztą ma sens : Kwadrad jest figurą

         Figura figura = new Kwadrat(10, "kw2", "żółty");

         figura.ObliczPole(); // teraz wywołując metodę ObliczPole() kompilator wie, że nasza figura to kwadrat 
         //i sprawdzi najpierw czy w klasie Kwadrat metoda ta nie jest czasem nadpisana, jeżeli jest to wykona jej wersję z klasy kWADRAT.
         //Gdyby w klasie kwadrat nie było implementacji metody ObliczPole(), wtedy została by wykonan jej wersja z klasy bazowej.

         Console.ReadKey();
      }
   }
}
