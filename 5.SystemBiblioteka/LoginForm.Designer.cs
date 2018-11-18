namespace _5.SystemBiblioteka
{
   partial class LoginForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.lblLogin = new System.Windows.Forms.Label();
         this.lblPassword = new System.Windows.Forms.Label();
         this.lblValidation = new System.Windows.Forms.Label();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.textBox2 = new System.Windows.Forms.TextBox();
         this.btnLogin = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lblLogin
         // 
         this.lblLogin.AutoSize = true;
         this.lblLogin.Location = new System.Drawing.Point(50, 33);
         this.lblLogin.Name = "lblLogin";
         this.lblLogin.Size = new System.Drawing.Size(36, 13);
         this.lblLogin.TabIndex = 0;
         this.lblLogin.Text = "Login:";
         // 
         // lblPassword
         // 
         this.lblPassword.AutoSize = true;
         this.lblPassword.Location = new System.Drawing.Point(50, 70);
         this.lblPassword.Name = "lblPassword";
         this.lblPassword.Size = new System.Drawing.Size(36, 13);
         this.lblPassword.TabIndex = 0;
         this.lblPassword.Text = "Hasło";
         // 
         // lblValidation
         // 
         this.lblValidation.AutoSize = true;
         this.lblValidation.ForeColor = System.Drawing.Color.Red;
         this.lblValidation.Location = new System.Drawing.Point(62, 149);
         this.lblValidation.Name = "lblValidation";
         this.lblValidation.Size = new System.Drawing.Size(144, 13);
         this.lblValidation.TabIndex = 0;
         this.lblValidation.Text = "Login lub hasło niepoprawne";
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(92, 30);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(100, 20);
         this.textBox1.TabIndex = 1;
         // 
         // textBox2
         // 
         this.textBox2.Location = new System.Drawing.Point(92, 67);
         this.textBox2.Name = "textBox2";
         this.textBox2.Size = new System.Drawing.Size(100, 20);
         this.textBox2.TabIndex = 2;
         // 
         // btnLogin
         // 
         this.btnLogin.Location = new System.Drawing.Point(85, 104);
         this.btnLogin.Name = "btnLogin";
         this.btnLogin.Size = new System.Drawing.Size(95, 42);
         this.btnLogin.TabIndex = 3;
         this.btnLogin.Text = "Zaloguj";
         this.btnLogin.UseVisualStyleBackColor = true;
         // 
         // LoginForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(253, 179);
         this.Controls.Add(this.btnLogin);
         this.Controls.Add(this.textBox2);
         this.Controls.Add(this.textBox1);
         this.Controls.Add(this.lblValidation);
         this.Controls.Add(this.lblPassword);
         this.Controls.Add(this.lblLogin);
         this.Name = "LoginForm";
         this.Text = "Logowanie";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblLogin;
      private System.Windows.Forms.Label lblPassword;
      private System.Windows.Forms.Label lblValidation;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.TextBox textBox2;
      private System.Windows.Forms.Button btnLogin;
   }
}

