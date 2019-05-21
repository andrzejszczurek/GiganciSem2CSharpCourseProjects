using _5.SystemBiblioteka.Model;
using System;
using System.Windows.Forms;

namespace _5.SystemBiblioteka.Forms
{
   public partial class ElementDetailsForm : Form
   {
      private LibraryManager _libraryManager;

      // ten konstruktor jest wywoływany gdy otwieramy formularz przy dodawaniu nowego elementu
      public ElementDetailsForm(LibraryManager libraryManager)
      {
         InitializeComponent();
         _libraryManager = libraryManager;
      }

      // ten konstruktor jest wywoływany gdy otwieramy formularz do podglądu istniejącego elementu
      public ElementDetailsForm(Element element)
      {
         InitializeComponent();

         // uzupełniamy texboxy danymi z przekazanego elementu
         tbTitle.Text = element.Title;
         tbAgeLimit.Text = element.AgeLimit.ToString();
         tbDescription.Text = element.Description;
         tbPrice.Text = element.Price.ToString();

         // ustawiamy textboxy tylko do odczytu
         tbTitle.ReadOnly = true;
         tbAgeLimit.ReadOnly = true;
         tbDescription.ReadOnly = true;
         tbPrice.ReadOnly = true;
      }

      private void btnClear_Click(object sender, EventArgs e)
      {
         tbDescription.Text = "";
         tbPrice.Text = "";
         tbTitle.Text = "";
         tbAgeLimit.Text = "";
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         string title = tbTitle.Text;
         string ageLimit = tbAgeLimit.Text;
         string description = tbDescription.Text;
         string price = tbPrice.Text;

         // sprawdzamy czy wszystkie tb uzupełnione
         if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(ageLimit) 
            || string.IsNullOrEmpty(description) || string.IsNullOrEmpty(price))
         {
            MessageBox.Show("Nie wszystkie dane zostały wprowadzone");
            return;
         }

         // próbujemy zamienić cene na liczbe typu decimal
         if (!decimal.TryParse(price, out decimal _price))
         {
            MessageBox.Show("Podana wartość dla ceny nie jest liczbą");
            return;
         }

         // próbujemy zamienić wiek na liczbe typu int
         if (!int.TryParse(ageLimit, out int _ageLimit))
         {
            MessageBox.Show("Podana wartość dla ceny nie jest liczbą");
            return;
         }

         // jeżeli wszystko poszło ok to tworzymy nowy element

         // w managerze mamy dane zalogowanego użytkownika,
         // więc pobieramy jego identyfikator za pomocą metody
         Guid userId = _libraryManager.GetCurrentUseId();

         Element element = new Element(userId, _ageLimit, title, description, _price);
         // zapisujemy element do pliku
         _libraryManager.SaveToFile(element);
         // oraz dodajemy do listy w managerze
         _libraryManager.AddElement(element);
         MessageBox.Show("Zapisano gre!");
         // zamykamy okno
         Close();
      }
   }
}
