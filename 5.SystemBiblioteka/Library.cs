using _5.SystemBiblioteka.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.SystemBiblioteka
{
   public class Library
   {
      private List<Game> games;

      public Library()
      {
         games = new List<Game>();
      }

      public void AddGame(Game game)
      {
         if (!games.Contains(game))
         {
            games.Add(game);
         }
      }

      public void RemoveGame(Game game)
      {
         if(games.Contains(game))
         {
            games.Remove(game);
         }
      }

      public List<Game> GetAllGames()
      {
         return games;
      }

      public void ImportGamesFromFile()
      {
         games.Clear();
         using (StreamReader sr = new StreamReader(LibraryObject.filePath))
         {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
               string[] data = line.Split('|');
               Game g = new Game(int.Parse(data[0]), data[1], data[2], decimal.Parse(data[3]));
               AddGame(g);
            }
         }
      }

      public void SaveGamesToFile()
      {
         using (StreamWriter sw = new StreamWriter(LibraryObject.filePath))
         {
            foreach (Game game in games)
            {
               sw.WriteLine($"{game.AgeLimit}|{game.Title}|{game.Description}|{game.Price}");
            }
         }
      }

   }
}
