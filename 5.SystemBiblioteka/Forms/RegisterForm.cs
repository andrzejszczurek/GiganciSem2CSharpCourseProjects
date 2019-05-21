using _5.SystemBiblioteka.Model;
using System;
using System.IO;
using System.Windows.Forms;

namespace _5.SystemBiblioteka.Forms
{
   public partial class RegisterForm : Form
   {
      public RegisterForm()
      {
         InitializeComponent();
      }

      private void btnRegister_Click(object sender, EventArgs e)
      {
         string filePath = AppContext.BaseDirectory + @"Database\Users.txt";

         // najpierw sprawdzamy czy wszystkie texbox są uzupełnione
         if (!SprawdzCzyWszystkiePolaUzupelnione())
         {
            PokazKomunikatWalidacji("Nie wszystkie pola są usupełnione.");
            return;
         }

         // potem sprawdzamy czy hasło nie jest za krótkie...
         if (tbPassword.Text.Length < 4)
         {
            PokazKomunikatWalidacji("Hasło za krótkie. Wymagane min 5 znaków.");
            return;
         }

         //  ..i czy powtórzone hasło jest takie samo jak hasło
         if (tbPassword.Text != tbRepeatPassword.Text)
         {
            PokazKomunikatWalidacji("Niezgodne hasła.");
            return;
         }

         // na koniec sprawdzamy czy nie istnieje juz czasem w naszej bazie uzytkownik o takim samym loginie i nazwie
         using (StreamReader sr = new StreamReader(filePath))
         {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
               string[] data = line.Split('|');
               // pobieramy nazwe i login
               string name = data[1];
               string login = data[2];

               // sprawdzamy czy pobrany użytkownik z pliku nie ma przypadkiem wybranego 
               // przez nas loginu lub nazwy

               if (name == tbName.Text || login == tbLogin.Text)
               {
                  // jeżeli tak to komunikat
                  PokazKomunikatWalidacji("Istnieje już taki użytkownik.");
                  // i kończymy sprawdzanie
                  return;
               }
            }
         }

         // jeżeli doszliśmy tutaj to możemy zapisać nowego użytkownika do pliku
         // W tym celu tworzymy nowy obiekt 'User' po to aby nadał się identyfikator użytkownikowi
         User user = new User(tbLogin.Text, tbPassword.Text, tbName.Text);

         // Następnie dopisujemy użytkownika do pliku z Users.txt
         using (StreamWriter sw = new StreamWriter(filePath, true))
         {
            sw.WriteLine($"{user.Id}|{user.Name}|{user.Login}|{user.Password}");
         }

         MessageBox.Show($"Poprawnie zarejestrowano nowego użytkownika: {user.Name}");
         Close();
      }

      private void PokazKomunikatWalidacji(string tresc)
      {
         lblWalidacje.Text = tresc;
         lblWalidacje.Visible = true;
      }

      private bool SprawdzCzyWszystkiePolaUzupelnione()
      {
         if (string.IsNullOrEmpty(tbName.Text) || string.IsNullOrWhiteSpace(tbName.Text)
         || string.IsNullOrEmpty(tbLogin.Text) || string.IsNullOrWhiteSpace(tbLogin.Text)
         || string.IsNullOrEmpty(tbPassword.Text) || string.IsNullOrWhiteSpace(tbPassword.Text)
         || string.IsNullOrEmpty(tbRepeatPassword.Text) || string.IsNullOrWhiteSpace(tbRepeatPassword.Text))
         {
            return false;
         }
         return true;
      }

   }
}
