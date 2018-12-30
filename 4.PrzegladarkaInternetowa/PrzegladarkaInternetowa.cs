using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.PrzegladarkaInternetowa
{
   public partial class PrzegladarkaInternetowa : Form
   {
      private List<Ulubione> ulubioneList;
      string filePath;

      public PrzegladarkaInternetowa()
      {
         InitializeComponent();
         filePath = AppDomain.CurrentDomain.BaseDirectory + @"..\..\Ulubione.txt";
         ulubioneList = new List<Ulubione>();
         ulubioneList = Ulubione.OdczytajUlubioneZPliku(filePath);
         OdswiezListeUlubionych();
      }

      private void btnGo_Click(object sender, EventArgs e)
      {
         if (!string.IsNullOrWhiteSpace(tbAdres.Text) && !string.IsNullOrEmpty(tbAdres.Text))
         {
            webBrowser.Navigate(tbAdres.Text);
         }
      }

      private void btnPoprzednia_Click(object sender, EventArgs e)
      {
         webBrowser.GoBack();
      }

      private void btnDalej_Click(object sender, EventArgs e)
      {
         webBrowser.GoForward();
      }

      private void btnStop_Click(object sender, EventArgs e)
      {
         webBrowser.Stop();
      }

      private void btnRefresh_Click(object sender, EventArgs e)
      {
         webBrowser.Refresh();
      }

      private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
      {
         Ulubione ulubione = cbUlubione.SelectedItem as Ulubione;
         tbAdres.Text = ulubione.Title;
         webBrowser.Navigate(ulubione.Url);
      }

      private void webBrowser_DocumentNavigated(object sender, WebBrowserNavigatedEventArgs e)
      {
         tbAdres.Text = webBrowser.Url.ToString();
         if (webBrowser.CanGoForward)
         {
            btnDalej.Enabled = true;
         }
         else
         {
            btnDalej.Enabled = false;
         }

         if (webBrowser.CanGoBack)
         {
            btnPoprzednia.Enabled = true;
         }
         else
         {
            btnPoprzednia.Enabled = false;
         }
      }

      private void brnDodajDoUlubionych_Click(object sender, EventArgs e)
      {
         string url = tbAdres.Text;
         string tytul = webBrowser.Document.Title;
         Ulubione u = new Ulubione(url, tytul);
         Ulubione.ZapiszUlubioneDoPliku(u, filePath);
         OdswiezListeUlubionych();
      }

      private void OdswiezListeUlubionych()
      {
         cbUlubione.DataSource = null;
         cbUlubione.DataSource = ulubioneList;
      }
   }
}
