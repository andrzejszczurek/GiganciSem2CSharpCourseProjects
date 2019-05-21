using System;

namespace _5.SystemBiblioteka.Model
{
   public class Element : LibraryObject
   {
      public decimal Price;

      public string Description;

      public int AgeLimit;

      public string Title;


      public Element(Guid userId, int ageLimit, string title, string description, decimal price)
         : base(userId)
      {
         AgeLimit = ageLimit;
         Title = title;
         Price = price;
         Description = description;
      }

      public override string ToString()
      {
         return Title + $" - {Price}.00zł" ;
      }

   }
}
