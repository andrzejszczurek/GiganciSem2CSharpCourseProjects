namespace _3.SzyfrCezara
{
   partial class SzyfrCezara
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
         this.tbDoZakodowania = new System.Windows.Forms.TextBox();
         this.tbZakodowany = new System.Windows.Forms.TextBox();
         this.numUpDown = new System.Windows.Forms.NumericUpDown();
         this.btnKoduj = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).BeginInit();
         this.SuspendLayout();
         // 
         // tbDoZakodowania
         // 
         this.tbDoZakodowania.Location = new System.Drawing.Point(12, 50);
         this.tbDoZakodowania.Multiline = true;
         this.tbDoZakodowania.Name = "tbDoZakodowania";
         this.tbDoZakodowania.Size = new System.Drawing.Size(178, 267);
         this.tbDoZakodowania.TabIndex = 0;
         // 
         // tbZakodowany
         // 
         this.tbZakodowany.Location = new System.Drawing.Point(309, 50);
         this.tbZakodowany.Multiline = true;
         this.tbZakodowany.Name = "tbZakodowany";
         this.tbZakodowany.Size = new System.Drawing.Size(178, 267);
         this.tbZakodowany.TabIndex = 0;
         // 
         // numUpDown
         // 
         this.numUpDown.Location = new System.Drawing.Point(217, 185);
         this.numUpDown.Name = "numUpDown";
         this.numUpDown.Size = new System.Drawing.Size(64, 20);
         this.numUpDown.TabIndex = 1;
         // 
         // btnKoduj
         // 
         this.btnKoduj.Location = new System.Drawing.Point(217, 125);
         this.btnKoduj.Name = "btnKoduj";
         this.btnKoduj.Size = new System.Drawing.Size(62, 23);
         this.btnKoduj.TabIndex = 2;
         this.btnKoduj.Text = "Koduj";
         this.btnKoduj.UseVisualStyleBackColor = true;
         this.btnKoduj.Click += new System.EventHandler(this.btnKoduj_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(47, 34);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(115, 13);
         this.label1.TabIndex = 3;
         this.label1.Text = "Tekst do zakodowania";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(348, 34);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(100, 13);
         this.label2.TabIndex = 4;
         this.label2.Text = "Tekst zakodowania";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(214, 169);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(67, 13);
         this.label3.TabIndex = 3;
         this.label3.Text = "Przesunięcie";
         // 
         // SzyfrCezara
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(502, 335);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btnKoduj);
         this.Controls.Add(this.numUpDown);
         this.Controls.Add(this.tbZakodowany);
         this.Controls.Add(this.tbDoZakodowania);
         this.Name = "SzyfrCezara";
         this.Text = "Szyfr cezara";
         ((System.ComponentModel.ISupportInitialize)(this.numUpDown)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.TextBox tbDoZakodowania;
      private System.Windows.Forms.TextBox tbZakodowany;
      private System.Windows.Forms.NumericUpDown numUpDown;
      private System.Windows.Forms.Button btnKoduj;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label3;
   }
}

