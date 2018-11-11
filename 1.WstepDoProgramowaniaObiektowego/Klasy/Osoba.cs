using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WstepDoProgramowaniaObiektowego.Klasy
{
   public class Osoba // definicja klasy składa się z modyfikatora dostępu, słowa kluczowego class oraz nazwy.
      // klasy nazywamy z dużej litery
   {
      // zmienne w klasie nazywamy polami - opisują one właściwości klasy, czyli definiują jej stan
      // przed zmiennymi mogę znajdować się modyfikatory dostępu. 
      // Jeżeli nie zdefiniujemy modyfikatora to każde pole jest domyślnie prywatne

      public string imie; // publiczne pole - mamy do niego dostęp z poza klasy

      public string nazwisko;

      private decimal zarobki; // prywatne pole - dostęp mają tylko elementy wewnątrz klasy (konstruktory, metody, klasy zagnieżdzone)


      // konstruktor - należy go rozumieć jako specjalną metodę w klasie, która nie ma typu zwracanego
      // oraz nazywa się tak samo jak klasa. 
      // Jest on wywoływany podczas tworzenia obiektu klasy
      // zazwyczaj wykorzystujemy go do ustawienia jakiś startowych wartości dla kasy.
      public Osoba() // konstruktor bezparametrowy
      {

      }

      public Osoba(string i, string n, decimal z) // konstruktor parametrowy. 
         // Przyjmuje on wartości dla naszych pól w klasie i ustawia ich wartości.
      {
         imie = i;
         nazwisko = n;
         zarobki = z;
      }


      // Klasy mogą posiadać także metody, które opisują ich zachowanie/
      // metody takżę mogą mieć modyfikatory dostępu. 
      // Jeżeli nie zdefiniujemy modyfikatora to każda metoda jest domyślnie prywatna.
      public void WpiszDane() // Wypisuje do konsoli wartości pól
      {
         Console.WriteLine($"Osoba {imie} {nazwisko} zarabia {zarobki}");
      }

   }
}
