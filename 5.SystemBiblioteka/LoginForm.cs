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
   public partial class LoginForm : Form
   {
      public LoginForm()
      {
         InitializeComponent();
         lblValidation.Visible = false;
      }

      private void btnLogin_Click(object sender, EventArgs e)
      {
         string login = tbLogin.Text;
         string password = tbPassword.Text;

         if (!IsValueCorrect(login) && !IsValueCorrect(password))
         {
            lblValidation.Visible = true;
            tbLogin.Text = "";
            tbPassword.Text = "";
         }
         else
         {
            MainWindowForm form = new MainWindowForm();
            form.Show();
            Hide();
         }
      }

      private bool IsValueCorrect(string value)
      {
         return !string.IsNullOrEmpty(value) && !string.IsNullOrWhiteSpace(value);
      }

   }
}
