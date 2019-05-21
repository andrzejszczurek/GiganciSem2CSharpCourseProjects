using _5.SystemBiblioteka.Model;
using System;
using System.IO;
using System.Windows.Forms;

namespace _5.SystemBiblioteka.Forms
{
   public partial class LoginForm : Form
   {
      private static readonly string _userFilePath = AppContext.BaseDirectory + @"Database\Users.txt";

      public LoginForm()
      {
         InitializeComponent();
         lblValidation.Visible = false;
      }


      private void btnLogin_Click(object sender, EventArgs e)
      {
         string login = tbLogin.Text;
         string password = tbPassword.Text;

         // sprawdzamy czy usupełniony login i hasło
         if (IsValueCorrect(login) && IsValueCorrect(password))
         {
            // sprawdzamy w pliku (bazie użytkowników) czy istnieje taki użytkownik o podanym loginie i haśle
            User user = PobierzUzytkownikaZBazy(login, password);
            // jeżeli w zmiennej user jest null to znaczy, że użytkownik nie stnieje,
            // jeżęli nie null to przechodzimy do głownego menu aplikacji
            if (user != null)
            {
               // przekazujemy aktualny formularz (słowo - this), oraz zalogowanego użytkownika do głownego formularza
               MainWindowForm form = new MainWindowForm(user, this);
               form.Show();
               Hide();
            }
         }
         // jeżeli dane nie poprawne to czyścimy textboxy i pokazujemy komunikat
         lblValidation.Visible = true;
         tbLogin.Text = "";
         tbPassword.Text = "";
      }


      private bool IsValueCorrect(string value)
      {
         return !string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value);
      }


      private User PobierzUzytkownikaZBazy(string a_login, string a_password)
      {
         // pobieramy uzytkowników zapisanych w pliku i tworzymy obiekty
         using (StreamReader sr = new StreamReader(_userFilePath)) // otwieramy plik do odczytu
         {
            string line;
            while ((line = sr.ReadLine()) != null) // iterujemy po wszystkich linikach w pliku
            {
               string[] data = line.Split('|'); // dzielimy linie na podstawie wybranego znaku
               Guid id = Guid.Parse(data[0]); // pierwszy element to identyfikator więc parsujemy na guid;
               string name = data[1];
               string login = data[2];
               string password = data[3];

               // sprawdzamy czy pobrany użytkownik ma podany przez nas login i hasło. 
               // Jeżeli tak to tworzymy obiekt user i go zwracamy

               if (login == a_login && password == a_password)
               {
                  User user = new User(id, login, password, name); // tworzymy obiekt uczestnika z pobranych danych
                  return user;
               }
            }
         }
         // jeżeli nie zwróciliśmy wcześniej użytkownika to znaczy,
         // że u nas w bazie nie istnieje użytkownik o podanym loginie i haśle
         // zwracamy wtedy nulla
         return null;
      }

      private void RegisterBtnClicked(object sender, EventArgs e)
      {
         RegisterForm registerForm = new RegisterForm();
         registerForm.ShowDialog();
      }


   }
}
