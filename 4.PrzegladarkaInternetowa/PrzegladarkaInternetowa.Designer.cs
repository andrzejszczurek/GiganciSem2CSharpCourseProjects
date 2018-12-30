namespace _4.PrzegladarkaInternetowa
{
   partial class PrzegladarkaInternetowa
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
         this.webBrowser = new System.Windows.Forms.WebBrowser();
         this.btnPoprzednia = new System.Windows.Forms.Button();
         this.btnDalej = new System.Windows.Forms.Button();
         this.btnStop = new System.Windows.Forms.Button();
         this.btnRefresh = new System.Windows.Forms.Button();
         this.brnDodajDoUlubionych = new System.Windows.Forms.Button();
         this.tbAdres = new System.Windows.Forms.TextBox();
         this.btnGo = new System.Windows.Forms.Button();
         this.cbUlubione = new System.Windows.Forms.ComboBox();
         this.SuspendLayout();
         // 
         // webBrowser
         // 
         this.webBrowser.Location = new System.Drawing.Point(12, 65);
         this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
         this.webBrowser.Name = "webBrowser";
         this.webBrowser.Size = new System.Drawing.Size(776, 373);
         this.webBrowser.TabIndex = 0;
         this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser_DocumentNavigated);
         // 
         // btnPoprzednia
         // 
         this.btnPoprzednia.Location = new System.Drawing.Point(12, 12);
         this.btnPoprzednia.Name = "btnPoprzednia";
         this.btnPoprzednia.Size = new System.Drawing.Size(33, 21);
         this.btnPoprzednia.TabIndex = 1;
         this.btnPoprzednia.Text = "<";
         this.btnPoprzednia.UseVisualStyleBackColor = true;
         this.btnPoprzednia.Click += new System.EventHandler(this.btnPoprzednia_Click);
         // 
         // btnDalej
         // 
         this.btnDalej.Location = new System.Drawing.Point(51, 12);
         this.btnDalej.Name = "btnDalej";
         this.btnDalej.Size = new System.Drawing.Size(34, 21);
         this.btnDalej.TabIndex = 2;
         this.btnDalej.Text = ">";
         this.btnDalej.UseVisualStyleBackColor = true;
         this.btnDalej.Click += new System.EventHandler(this.btnDalej_Click);
         // 
         // btnStop
         // 
         this.btnStop.Location = new System.Drawing.Point(120, 12);
         this.btnStop.Name = "btnStop";
         this.btnStop.Size = new System.Drawing.Size(86, 21);
         this.btnStop.TabIndex = 3;
         this.btnStop.Text = "Zatrzymaj";
         this.btnStop.UseVisualStyleBackColor = true;
         this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
         // 
         // btnRefresh
         // 
         this.btnRefresh.Location = new System.Drawing.Point(212, 12);
         this.btnRefresh.Name = "btnRefresh";
         this.btnRefresh.Size = new System.Drawing.Size(86, 21);
         this.btnRefresh.TabIndex = 4;
         this.btnRefresh.Text = "Odśwież";
         this.btnRefresh.UseVisualStyleBackColor = true;
         this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
         // 
         // brnDodajDoUlubionych
         // 
         this.brnDodajDoUlubionych.Location = new System.Drawing.Point(319, 12);
         this.brnDodajDoUlubionych.Name = "brnDodajDoUlubionych";
         this.brnDodajDoUlubionych.Size = new System.Drawing.Size(124, 21);
         this.brnDodajDoUlubionych.TabIndex = 5;
         this.brnDodajDoUlubionych.Text = "Dodaj do ulubionych";
         this.brnDodajDoUlubionych.UseVisualStyleBackColor = true;
         this.brnDodajDoUlubionych.Click += new System.EventHandler(this.brnDodajDoUlubionych_Click);
         // 
         // tbAdres
         // 
         this.tbAdres.Location = new System.Drawing.Point(12, 39);
         this.tbAdres.Name = "tbAdres";
         this.tbAdres.Size = new System.Drawing.Size(776, 20);
         this.tbAdres.TabIndex = 6;
         // 
         // btnGo
         // 
         this.btnGo.Location = new System.Drawing.Point(682, 12);
         this.btnGo.Name = "btnGo";
         this.btnGo.Size = new System.Drawing.Size(106, 21);
         this.btnGo.TabIndex = 5;
         this.btnGo.Text = "Idź";
         this.btnGo.UseVisualStyleBackColor = true;
         this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
         // 
         // cbUlubione
         // 
         this.cbUlubione.FormattingEnabled = true;
         this.cbUlubione.Location = new System.Drawing.Point(463, 12);
         this.cbUlubione.Name = "cbUlubione";
         this.cbUlubione.Size = new System.Drawing.Size(213, 21);
         this.cbUlubione.TabIndex = 7;
         this.cbUlubione.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
         // 
         // PrzegladarkaInternetowa
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(800, 450);
         this.Controls.Add(this.cbUlubione);
         this.Controls.Add(this.tbAdres);
         this.Controls.Add(this.btnGo);
         this.Controls.Add(this.brnDodajDoUlubionych);
         this.Controls.Add(this.btnRefresh);
         this.Controls.Add(this.btnStop);
         this.Controls.Add(this.btnDalej);
         this.Controls.Add(this.btnPoprzednia);
         this.Controls.Add(this.webBrowser);
         this.Name = "PrzegladarkaInternetowa";
         this.Text = "Przeglądarka internetowa";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.WebBrowser webBrowser;
      private System.Windows.Forms.Button btnPoprzednia;
      private System.Windows.Forms.Button btnDalej;
      private System.Windows.Forms.Button btnStop;
      private System.Windows.Forms.Button btnRefresh;
      private System.Windows.Forms.Button brnDodajDoUlubionych;
      private System.Windows.Forms.TextBox tbAdres;
      private System.Windows.Forms.Button btnGo;
      private System.Windows.Forms.ComboBox cbUlubione;
   }
}

