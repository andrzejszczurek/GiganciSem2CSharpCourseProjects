using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.WygaszaczEkranu
{
   public partial class WygaszaczEkranu : Form
   {
      int x, y;
      string[] obrazki;
      int iloscObrazkow;
      int numerObrazka;

      public WygaszaczEkranu()
      {
         InitializeComponent();
         BackgroundImageLayout = ImageLayout.Stretch;
         DoubleBuffered = true;
         WindowState = FormWindowState.Minimized;
         FormBorderStyle = FormBorderStyle.None;
         iloscObrazkow = 0;
         numerObrazka = 0;
      }

      private void WygaszaczEkranu_Load(object sender, EventArgs e)
      {
         x = Cursor.Position.X;
         y = Cursor.Position.Y;
         string folder = AppDomain.CurrentDomain.BaseDirectory + @"..\..\obrazki";
         try
         {
            obrazki = Directory.GetFiles(folder);
         }
         catch (Exception)
         {
            MessageBox.Show("Błąd w trakcie pobierania obrazków");
            Application.Exit();
         }

         iloscObrazkow = obrazki.Length;

         if (iloscObrazkow == 0)
         {
            MessageBox.Show("Brak obrazków dla wygaszacza");
            Application.Exit();
         }

         BackgroundImage = Image.FromFile(obrazki[numerObrazka]);
         Cursor.Hide();
         WindowState = FormWindowState.Maximized;
         timer.Start();
      }

      private void MouseMoved(object sender, MouseEventArgs e)
      {
         if (e.X != x || e.Y != y)
         {
            Application.Exit();
         }
      }

      private void MouseClicked(object sender, MouseEventArgs e)
      {
         Application.Exit();
      }

      private void KeyPressed(object sender, KeyEventArgs e)
      {
         Application.Exit();
      }

      private void Timer_Tick(object sender, EventArgs e)
      {
         try
         {
            BackgroundImage = Image.FromFile(obrazki[numerObrazka++]);
            if (numerObrazka >= iloscObrazkow)
            {
               numerObrazka = 0;
            }
         }
         catch (Exception)
         {
            MessageBox.Show("Błąd podczas pobierania pliku");
         }
      }
   }
}

