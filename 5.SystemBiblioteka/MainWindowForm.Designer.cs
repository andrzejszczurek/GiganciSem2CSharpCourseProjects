namespace _5.SystemBiblioteka
{
   partial class MainWindowForm
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
         this.lblTitle = new System.Windows.Forms.Label();
         this.lbGames = new System.Windows.Forms.ListBox();
         this.btnAdd = new System.Windows.Forms.Button();
         this.btnDelete = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lblTitle
         // 
         this.lblTitle.AutoSize = true;
         this.lblTitle.Location = new System.Drawing.Point(79, 9);
         this.lblTitle.Name = "lblTitle";
         this.lblTitle.Size = new System.Drawing.Size(73, 13);
         this.lblTitle.TabIndex = 0;
         this.lblTitle.Text = "Biblioteka gier";
         // 
         // lbGames
         // 
         this.lbGames.FormattingEnabled = true;
         this.lbGames.Location = new System.Drawing.Point(12, 25);
         this.lbGames.Name = "lbGames";
         this.lbGames.Size = new System.Drawing.Size(209, 251);
         this.lbGames.TabIndex = 1;
         // 
         // btnAdd
         // 
         this.btnAdd.Location = new System.Drawing.Point(45, 296);
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.Size = new System.Drawing.Size(147, 33);
         this.btnAdd.TabIndex = 3;
         this.btnAdd.Text = "Dodaj grę";
         this.btnAdd.UseVisualStyleBackColor = true;
         // 
         // btnDelete
         // 
         this.btnDelete.Location = new System.Drawing.Point(45, 344);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(147, 33);
         this.btnDelete.TabIndex = 4;
         this.btnDelete.Text = "Usuń grę";
         this.btnDelete.UseVisualStyleBackColor = true;
         // 
         // MainWindowForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(233, 410);
         this.Controls.Add(this.btnDelete);
         this.Controls.Add(this.btnAdd);
         this.Controls.Add(this.lbGames);
         this.Controls.Add(this.lblTitle);
         this.Name = "MainWindowForm";
         this.Text = "Główne okno";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblTitle;
      private System.Windows.Forms.ListBox lbGames;
      private System.Windows.Forms.Button btnAdd;
      private System.Windows.Forms.Button btnDelete;
   }
}