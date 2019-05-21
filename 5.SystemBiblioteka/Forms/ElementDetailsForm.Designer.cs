namespace _5.SystemBiblioteka.Forms
{
   partial class ElementDetailsForm
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
         this.lblPrice = new System.Windows.Forms.Label();
         this.lblDescription = new System.Windows.Forms.Label();
         this.tbDescription = new System.Windows.Forms.TextBox();
         this.tbTitle = new System.Windows.Forms.TextBox();
         this.tbPrice = new System.Windows.Forms.TextBox();
         this.btnClear = new System.Windows.Forms.Button();
         this.btnSave = new System.Windows.Forms.Button();
         this.tbAgeLimit = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.SuspendLayout();
         // 
         // lblTitle
         // 
         this.lblTitle.AutoSize = true;
         this.lblTitle.Location = new System.Drawing.Point(47, 9);
         this.lblTitle.Name = "lblTitle";
         this.lblTitle.Size = new System.Drawing.Size(32, 13);
         this.lblTitle.TabIndex = 0;
         this.lblTitle.Text = "Tytuł";
         // 
         // lblPrice
         // 
         this.lblPrice.AutoSize = true;
         this.lblPrice.Location = new System.Drawing.Point(47, 65);
         this.lblPrice.Name = "lblPrice";
         this.lblPrice.Size = new System.Drawing.Size(32, 13);
         this.lblPrice.TabIndex = 0;
         this.lblPrice.Text = "Cena";
         // 
         // lblDescription
         // 
         this.lblDescription.AutoSize = true;
         this.lblDescription.Location = new System.Drawing.Point(51, 87);
         this.lblDescription.Name = "lblDescription";
         this.lblDescription.Size = new System.Drawing.Size(28, 13);
         this.lblDescription.TabIndex = 0;
         this.lblDescription.Text = "Opis";
         // 
         // tbDescription
         // 
         this.tbDescription.Location = new System.Drawing.Point(85, 84);
         this.tbDescription.Multiline = true;
         this.tbDescription.Name = "tbDescription";
         this.tbDescription.Size = new System.Drawing.Size(197, 86);
         this.tbDescription.TabIndex = 1;
         // 
         // tbTitle
         // 
         this.tbTitle.Location = new System.Drawing.Point(85, 6);
         this.tbTitle.Name = "tbTitle";
         this.tbTitle.Size = new System.Drawing.Size(187, 20);
         this.tbTitle.TabIndex = 2;
         // 
         // tbPrice
         // 
         this.tbPrice.Location = new System.Drawing.Point(85, 58);
         this.tbPrice.Name = "tbPrice";
         this.tbPrice.Size = new System.Drawing.Size(75, 20);
         this.tbPrice.TabIndex = 3;
         // 
         // btnClear
         // 
         this.btnClear.Location = new System.Drawing.Point(12, 176);
         this.btnClear.Name = "btnClear";
         this.btnClear.Size = new System.Drawing.Size(117, 41);
         this.btnClear.TabIndex = 4;
         this.btnClear.Text = "Wyczyść";
         this.btnClear.UseVisualStyleBackColor = true;
         this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
         // 
         // btnSave
         // 
         this.btnSave.Location = new System.Drawing.Point(160, 176);
         this.btnSave.Name = "btnSave";
         this.btnSave.Size = new System.Drawing.Size(122, 41);
         this.btnSave.TabIndex = 5;
         this.btnSave.Text = "Zapisz";
         this.btnSave.UseVisualStyleBackColor = true;
         this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
         // 
         // tbAgeLimit
         // 
         this.tbAgeLimit.Location = new System.Drawing.Point(85, 32);
         this.tbAgeLimit.Name = "tbAgeLimit";
         this.tbAgeLimit.Size = new System.Drawing.Size(100, 20);
         this.tbAgeLimit.TabIndex = 6;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(1, 32);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(78, 13);
         this.label1.TabIndex = 7;
         this.label1.Text = "Minimalny wiek";
         // 
         // GameDetailsForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(294, 227);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.tbAgeLimit);
         this.Controls.Add(this.btnSave);
         this.Controls.Add(this.btnClear);
         this.Controls.Add(this.tbPrice);
         this.Controls.Add(this.tbTitle);
         this.Controls.Add(this.tbDescription);
         this.Controls.Add(this.lblDescription);
         this.Controls.Add(this.lblPrice);
         this.Controls.Add(this.lblTitle);
         this.Name = "GameDetailsForm";
         this.Text = "GameDetailsForm";
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblTitle;
      private System.Windows.Forms.Label lblPrice;
      private System.Windows.Forms.Label lblDescription;
      private System.Windows.Forms.TextBox tbDescription;
      private System.Windows.Forms.TextBox tbTitle;
      private System.Windows.Forms.TextBox tbPrice;
      private System.Windows.Forms.Button btnClear;
      private System.Windows.Forms.Button btnSave;
      private System.Windows.Forms.TextBox tbAgeLimit;
      private System.Windows.Forms.Label label1;
   }
}