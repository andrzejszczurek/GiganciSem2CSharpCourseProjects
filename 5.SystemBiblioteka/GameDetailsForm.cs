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
   public partial class GameDetailsForm : Form
   {
      public GameDetailsForm()
      {
         InitializeComponent();
      }

      private void btnClear_Click(object sender, EventArgs e)
      {
         tbDescription.Text = "";
         tbPrice.Text = "";
         tbTitle.Text = "";
      }

      private void btnSave_Click(object sender, EventArgs e)
      {
         string description = tbDescription.Text;
         string price = tbPrice.Text;
         string title = tbTitle.Text;
         Game game = new Game(0, title, description, decimal.Parse(price));
         game.SaveToFile();
         MessageBox.Show("Zapisano gre!");
      }
   }
}
