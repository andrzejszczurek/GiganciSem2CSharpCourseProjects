namespace _5.SystemBiblioteka.Forms
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
         this.lbElements = new System.Windows.Forms.ListBox();
         this.btnAdd = new System.Windows.Forms.Button();
         this.btnDelete = new System.Windows.Forms.Button();
         this.btnLogout = new System.Windows.Forms.Button();
         this.label1 = new System.Windows.Forms.Label();
         this.lblUserInfo = new System.Windows.Forms.Label();
         this.btnDetails = new System.Windows.Forms.Button();
         this.SuspendLayout();
         // 
         // lblTitle
         // 
         this.lblTitle.AutoSize = true;
         this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lblTitle.Location = new System.Drawing.Point(84, 41);
         this.lblTitle.Name = "lblTitle";
         this.lblTitle.Size = new System.Drawing.Size(89, 20);
         this.lblTitle.TabIndex = 0;
         this.lblTitle.Text = "Moje wpisy:";
         // 
         // lbElements
         // 
         this.lbElements.FormattingEnabled = true;
         this.lbElements.Location = new System.Drawing.Point(12, 64);
         this.lbElements.Name = "lbElements";
         this.lbElements.Size = new System.Drawing.Size(232, 212);
         this.lbElements.TabIndex = 1;
         // 
         // btnAdd
         // 
         this.btnAdd.Location = new System.Drawing.Point(13, 326);
         this.btnAdd.Name = "btnAdd";
         this.btnAdd.Size = new System.Drawing.Size(111, 33);
         this.btnAdd.TabIndex = 3;
         this.btnAdd.Text = "Dodaj";
         this.btnAdd.UseVisualStyleBackColor = true;
         this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
         // 
         // btnDelete
         // 
         this.btnDelete.Location = new System.Drawing.Point(124, 326);
         this.btnDelete.Name = "btnDelete";
         this.btnDelete.Size = new System.Drawing.Size(120, 33);
         this.btnDelete.TabIndex = 4;
         this.btnDelete.Text = "Usuń";
         this.btnDelete.UseVisualStyleBackColor = true;
         this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
         // 
         // btnLogout
         // 
         this.btnLogout.Location = new System.Drawing.Point(169, 4);
         this.btnLogout.Name = "btnLogout";
         this.btnLogout.Size = new System.Drawing.Size(75, 23);
         this.btnLogout.TabIndex = 5;
         this.btnLogout.Text = "Wyloguj";
         this.btnLogout.UseVisualStyleBackColor = true;
         this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(9, 9);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(91, 13);
         this.label1.TabIndex = 6;
         this.label1.Text = "Zalogowany jako:";
         // 
         // lblUserInfo
         // 
         this.lblUserInfo.AutoSize = true;
         this.lblUserInfo.Location = new System.Drawing.Point(96, 9);
         this.lblUserInfo.Name = "lblUserInfo";
         this.lblUserInfo.Size = new System.Drawing.Size(28, 13);
         this.lblUserInfo.TabIndex = 7;
         this.lblUserInfo.Text = "Test";
         // 
         // btnDetails
         // 
         this.btnDetails.Location = new System.Drawing.Point(12, 282);
         this.btnDetails.Name = "btnDetails";
         this.btnDetails.Size = new System.Drawing.Size(232, 37);
         this.btnDetails.TabIndex = 8;
         this.btnDetails.Text = "Szczegóły";
         this.btnDetails.UseVisualStyleBackColor = true;
         this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
         // 
         // MainWindowForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(253, 367);
         this.Controls.Add(this.btnDetails);
         this.Controls.Add(this.lblUserInfo);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.btnLogout);
         this.Controls.Add(this.btnDelete);
         this.Controls.Add(this.btnAdd);
         this.Controls.Add(this.lbElements);
         this.Controls.Add(this.lblTitle);
         this.Name = "MainWindowForm";
         this.Text = "Główne okno";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.Label lblTitle;
      private System.Windows.Forms.ListBox lbElements;
      private System.Windows.Forms.Button btnAdd;
      private System.Windows.Forms.Button btnDelete;
      private System.Windows.Forms.Button btnLogout;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label lblUserInfo;
      private System.Windows.Forms.Button btnDetails;
   }
}