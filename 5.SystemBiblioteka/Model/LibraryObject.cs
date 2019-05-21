using System;

namespace _5.SystemBiblioteka.Model
{
   public abstract class LibraryObject
   {
      public Guid UserId; // identyfikator użytkownika który dodał wpis

      public LibraryObject(Guid userId)
      {
         UserId = userId;
      }

   }
}
