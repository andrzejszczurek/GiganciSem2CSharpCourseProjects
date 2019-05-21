using System;

namespace _5.SystemBiblioteka.Model
{
   /// <summary>
   /// Klasa przechowująca dane użytkownika aplikacji
   /// </summary>
   public class User
   {
      public Guid Id;

      public string Login;

      public string Password;

      public string Name;

      /// <summary>
      /// Konstruktor do rejestracji nowego uczestnika
      /// </summary>
      public User(string login, string password, string name)
      {
         Id = Guid.NewGuid(); // Tworząc nowego użytkownika tworzymy dla niego unikalny identyfikator
         Login = login;
         Password = password;
         Name = name;
      }

      /// <summary>
      /// Konstruktor do tworzenia uczestnika z istniejących danych
      /// </summary>
      public User(Guid id, string login, string password, string name)
      {
         Id = id;
         Login = login;
         Password = password;
         Name = name;
      }
   }
}
