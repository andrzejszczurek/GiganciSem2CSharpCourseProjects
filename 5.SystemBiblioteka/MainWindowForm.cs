using _5.SystemBiblioteka.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.SystemBiblioteka
{
   public partial class MainWindowForm : Form
   {
      private Library myLibrary;

      public MainWindowForm()
      {
         InitializeComponent();
         myLibrary = new Library();
         myLibrary.ImportGamesFromFile();
         listGames.DataSource = myLibrary.GetAllGames();
      }

      private void btnAdd_Click(object sender, EventArgs e)
      {
         GameDetailsForm form = new GameDetailsForm();
         form.ShowDialog();
         myLibrary.ImportGamesFromFile();
         listGames.DataSource = null;
         listGames.DataSource = myLibrary.GetAllGames();
      }

      private void btnDelete_Click(object sender, EventArgs e)
      {
         myLibrary.RemoveGame(listGames.SelectedItem as Game);
         listGames.DataSource = null;
         listGames.DataSource = myLibrary.GetAllGames();
      }
   }
}
