using _5.SystemBiblioteka.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace _5.SystemBiblioteka
{
   public class LibraryManager
   {
      // ścieżka do naszej plikowej bazy danych
      public static string filePath = AppContext.BaseDirectory + @"Database\Biblioteka.txt";

      private List<Element> _elementy; // lista wszystkich elementów w bibliotece

      private User _currentUser;

      public LibraryManager(User user)
      {
         _elementy = new List<Element>();
         _currentUser = user;
      }

      // Metoda do dodawania nowego elementu
      public void AddElement(Element element)
      {
         if (!_elementy.Contains(element))
         {
            _elementy.Add(element);
         }
      }

      // metoda do usuwania istniejącego elementu
      public void RemoveGame(Element element)
      {
         if(_elementy.Contains(element))
         {
            _elementy.Remove(element);
         }
      }

      // zwraca wszystkie elementy
      public List<Element> GetAllElements()
      {
         return _elementy;
      }

      public Guid GetCurrentUseId()
      {
         return _currentUser.Id;
      }

      // Pobiera wszystkie elementy z pliku
      public void ImportUserElementsFromFile()
      {
         _elementy.Clear(); // najpier czyścimy listę elementów
         using (StreamReader sr = new StreamReader(filePath)) // otwieramy plik do odczytu
         {
            string line; // zmienna na pobraną z pliku linię
            while ((line = sr.ReadLine()) != null && line != string.Empty) // iterujemy po linikach w pliku dopóki jakieś istnieją
            {
               string[] data = line.Split('|'); // dzielimy pobraną linikę po ustalonym znaku, i otrzymujemy tablicę z danymi naszego elementu
               Guid userId = Guid.Parse(data[0]);

               // sprawdzamy czy aktualny element ma identyfikator taki jak zalogowany użytkownik
               if (userId == _currentUser.Id)
               {
                  // jeżeli tak to pobieramy pozostałe dane...
                  int ageLimit = int.Parse(data[1]);
                  string title = data[2];
                  string description = data[3];
                  decimal price = decimal.Parse(data[4]);

                  // ... tworzymy z nich element...
                  Element element = new Element(userId, ageLimit, title, description, price); // tworzymy obiekt elementu na podstawie danych
                  // ... i dodajemy go do listy.
                  AddElement(element); // dodajemy nowy utworzony element do listy
               }
            }
         }
      }

      // Zapisuje wszystkie elementy do pliku
      public void SaveGamesToFile()
      {
         using (StreamWriter sw = new StreamWriter(filePath, false)) // otwieramy plik do zapisu
         {
            foreach (Element el in _elementy) // iterujemy po wszystkich elementach na liście
            {
               // zapisujemy dane jednego elementu w osobnej lini oddzielone wybranym znakiem
               sw.WriteLine($"{el.UserId}|{el.AgeLimit}|{el.Title}|{el.Description}|{el.Price}");
            }
         }
      }

      // Dopisuje nowy element do pliku z danymi
      public void SaveToFile(Element el)
      {
         using (StreamWriter sw = new StreamWriter(filePath, true))
         {
            sw.WriteLine($"{el.UserId}|{el.AgeLimit}|{el.Title}|{el.Description}|{el.Price}");
         }
      }

   }
}
