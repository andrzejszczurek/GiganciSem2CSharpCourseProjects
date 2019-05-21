namespace _5.SystemBiblioteka.Forms
{
   partial class RegisterForm
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
         this.lblRejestracja = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.btnRegister = new System.Windows.Forms.Button();
         this.lblWalidacje = new System.Windows.Forms.Label();
         this.tbName = new System.Windows.Forms.TextBox();
         this.tbLogin = new System.Windows.Forms.TextBox();
         this.tbPassword = new System.Windows.Forms.TextBox();
         this.tbRepeatPassword = new System.Windows.Forms.TextBox();
         this.SuspendLayout();
         // 
         // lblRejestracja
         // 
         this.lblRejestracja.AutoSize = true;
         this.lblRejestracja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblRejestracja.Location = new System.Drawing.Point(69, 9);
         this.lblRejestracja.Name = "lblRejestracja";
         this.lblRejestracja.Size = new System.Drawing.Size(89, 20);
         this.lblRejestracja.TabIndex = 0;
         this.lblRejestracja.Text = "Rejestracja";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(48, 39);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(40, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "Nazwa";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(55, 65);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(33, 13);
         this.label2.TabIndex = 2;
         this.label2.Text = "Login";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(52, 91);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(36, 13);
         this.label3.TabIndex = 2;
         this.label3.Text = "Hasło";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(13, 118);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(75, 13);
         this.label4.TabIndex = 2;
         this.label4.Text = "Powtórz hasło";
         // 
         // btnRegister
         // 
         this.btnRegister.Location = new System.Drawing.Point(73, 169);
         this.btnRegister.Name = "btnRegister";
         this.btnRegister.Size = new System.Drawing.Size(85, 42);
         this.btnRegister.TabIndex = 3;
         this.btnRegister.Text = "Zarejestruj";
         this.btnRegister.UseVisualStyleBackColor = true;
         this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
         // 
         // lblWalidacje
         // 
         this.lblWalidacje.AutoSize = true;
         this.lblWalidacje.ForeColor = System.Drawing.Color.Maroon;
         this.lblWalidacje.Location = new System.Drawing.Point(12, 138);
         this.lblWalidacje.Name = "lblWalidacje";
         this.lblWalidacje.Size = new System.Drawing.Size(97, 13);
         this.lblWalidacje.TabIndex = 2;
         this.lblWalidacje.Text = "Niepoprawne dane";
         // 
         // tbName
         // 
         this.tbName.Location = new System.Drawing.Point(94, 36);
         this.tbName.Name = "tbName";
         this.tbName.Size = new System.Drawing.Size(100, 20);
         this.tbName.TabIndex = 4;
         // 
         // tbLogin
         // 
         this.tbLogin.Location = new System.Drawing.Point(94, 62);
         this.tbLogin.Name = "tbLogin";
         this.tbLogin.Size = new System.Drawing.Size(100, 20);
         this.tbLogin.TabIndex = 5;
         // 
         // tbPassword
         // 
         this.tbPassword.Location = new System.Drawing.Point(94, 88);
         this.tbPassword.Name = "tbPassword";
         this.tbPassword.PasswordChar = '*';
         this.tbPassword.Size = new System.Drawing.Size(100, 20);
         this.tbPassword.TabIndex = 6;
         // 
         // tbRepeatPassword
         // 
         this.tbRepeatPassword.Location = new System.Drawing.Point(94, 115);
         this.tbRepeatPassword.Name = "tbRepeatPassword";
         this.tbRepeatPassword.PasswordChar = '*';
         this.tbRepeatPassword.Size = new System.Drawing.Size(100, 20);
         this.tbRepeatPassword.TabIndex = 7;
         // 
         // RegisterForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(230, 226);
         this.Controls.Add(this.tbRepeatPassword);
         this.Controls.Add(this.tbPassword);
         this.Controls.Add(this.tbLogin);
         this.Controls.Add(this.tbName);
         this.Controls.Add(this.btnRegister);
         this.Controls.Add(this.lblWalidacje);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.lblRejestracja);
         this.Name = "RegisterForm";
         this.Text = "RegisterForm";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblRejestracja;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Button btnRegister;
      private System.Windows.Forms.Label lblWalidacje;
      private System.Windows.Forms.TextBox tbName;
      private System.Windows.Forms.TextBox tbLogin;
      private System.Windows.Forms.TextBox tbPassword;
      private System.Windows.Forms.TextBox tbRepeatPassword;
   }
}