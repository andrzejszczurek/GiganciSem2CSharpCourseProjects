using _5.SystemBiblioteka.Forms;
using _5.SystemBiblioteka.Model;
using System;
using System.Windows.Forms;

namespace _5.SystemBiblioteka.Forms
{
   public partial class MainWindowForm : Form
   {
      private LibraryManager _manager;

      private LoginForm _loginForm;

      private bool CzyTrwaWylogowywanie;

      public MainWindowForm(User user, LoginForm loginForm)
      {
         InitializeComponent();
         lblUserInfo.Text = user.Name;
         _manager = new LibraryManager(user); // tworzymy obiekt managera
         _loginForm = loginForm;
         _manager.ImportUserElementsFromFile(); // pobieramy wszystkie wpisy aktualnie zalogowane użytkownika

         // pobieramy wszystkie elementy z managera i ustawiamy na liście
         lbElements.DataSource = _manager.GetAllElements();
      }


      private void btnAdd_Click(object sender, EventArgs e)
      {
         ElementDetailsForm form = new ElementDetailsForm(_manager);
         form.ShowDialog();
         lbElements.DataSource = null;
         lbElements.DataSource = _manager.GetAllElements();
      }


      private void btnDelete_Click(object sender, EventArgs e)
      {
         _manager.RemoveGame(lbElements.SelectedItem as Element);
         lbElements.DataSource = null;
         lbElements.DataSource = _manager.GetAllElements();
      }


      private void btnDetails_Click(object sender, EventArgs e)
      {
         // pobieramy z listboxa aktualnie zaznaczony element
         // pobrany element jest typu 'object', więc rzutujemy go na element
         Element element = lbElements.SelectedItem as Element;

         // jeżeli nie było żadnego elmentu na liście albo żaden nie był zaznaczony
         // to w zmiennej element będzie null.

         if (element == null)
         {
            // jeżeli nie ma elemnetu to nie otwieramy szczegółów;
            MessageBox.Show("Nie wybrano żadnego elementu");
            return;
         }

         // tworzymy nowy formularz szczegółów i przekazujemy do niego zaznaczony element,
         ElementDetailsForm form = new ElementDetailsForm(element);
         form.ShowDialog();
      }

      private void btnLogout_Click(object sender, EventArgs e)
      {
         CzyTrwaWylogowywanie = true;
         Close();
         _loginForm.Controls["lblValidation"].Visible = false;
         _loginForm.Show();
      }

      private void Form_Closing(object sender, FormClosingEventArgs e)
      {
         if (!CzyTrwaWylogowywanie)
         {
            Application.Exit();
         }
      }
   }
}
