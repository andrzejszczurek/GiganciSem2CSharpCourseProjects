using System;
using System.Windows.Forms;

namespace _3.SzyfrCezara
{
   public partial class SzyfrCezara : Form
   {
      public SzyfrCezara()
      {
         InitializeComponent();
      }

      private void btnKoduj_Click(object sender, EventArgs e)
      {
         char[] bufor = tbDoZakodowania.Text.ToCharArray();
         int przesuniecie = (int)numUpDown.Value;
         for (int i = 0; i < bufor.Length; i++)
         {
            char litera = bufor[i];

            if (litera == ' ' || litera == '?' || litera == '.' || litera == ',')
               continue;

            if (litera >= 'A' && litera <= 'Z')
            {
               litera = (char)(litera + przesuniecie);

               if (litera > 'Z')
               {
                  litera = (char)(litera - 26);
               }
               
               if(litera < 'A')
               {
                  litera = (char)(litera + 26);
               }
            }

            if (litera >= 'a' && litera <= 'z')
            {
               litera = (char)(litera + przesuniecie);

               if (litera > 'z')
               {
                  litera = (char)(litera - 26);
               }

               if (litera < 'a')
               {
                  litera = (char)(litera + 26);
               }
            }
            bufor[i] = litera;

            tbZakodowany.Text = new string(bufor);
         }
      }
   }
}
