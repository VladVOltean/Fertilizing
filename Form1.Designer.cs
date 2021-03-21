namespace fertilizare
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adaugaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acvariuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.substantaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereAcvariuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergereSubstanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dozariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istoricStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugaDozareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeDozareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editeazaDozareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTest = new System.Windows.Forms.Label();
            this.adaugaUtilizatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utilizator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parola";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugaToolStripMenuItem,
            this.dozariToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(415, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adaugaToolStripMenuItem
            // 
            this.adaugaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acvariuToolStripMenuItem,
            this.substantaToolStripMenuItem,
            this.adaugaUtilizatorToolStripMenuItem,
            this.stergereAcvariuToolStripMenuItem,
            this.stergereSubstanteToolStripMenuItem});
            this.adaugaToolStripMenuItem.Name = "adaugaToolStripMenuItem";
            this.adaugaToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.adaugaToolStripMenuItem.Text = "Date";
            // 
            // acvariuToolStripMenuItem
            // 
            this.acvariuToolStripMenuItem.Name = "acvariuToolStripMenuItem";
            this.acvariuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.acvariuToolStripMenuItem.Text = "Adauga Acvariu";
            this.acvariuToolStripMenuItem.Click += new System.EventHandler(this.acvariuToolStripMenuItem_Click);
            // 
            // substantaToolStripMenuItem
            // 
            this.substantaToolStripMenuItem.Name = "substantaToolStripMenuItem";
            this.substantaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.substantaToolStripMenuItem.Text = "Adauga Substante";
            this.substantaToolStripMenuItem.Click += new System.EventHandler(this.substantaToolStripMenuItem_Click);
            // 
            // stergereAcvariuToolStripMenuItem
            // 
            this.stergereAcvariuToolStripMenuItem.Name = "stergereAcvariuToolStripMenuItem";
            this.stergereAcvariuToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.stergereAcvariuToolStripMenuItem.Text = "Stergere Acvariu";
            this.stergereAcvariuToolStripMenuItem.Click += new System.EventHandler(this.stergereAcvariuToolStripMenuItem_Click);
            // 
            // stergereSubstanteToolStripMenuItem
            // 
            this.stergereSubstanteToolStripMenuItem.Name = "stergereSubstanteToolStripMenuItem";
            this.stergereSubstanteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.stergereSubstanteToolStripMenuItem.Text = "Stergere Substante";
            this.stergereSubstanteToolStripMenuItem.Click += new System.EventHandler(this.stergereSubstanteToolStripMenuItem_Click);
            // 
            // dozariToolStripMenuItem
            // 
            this.dozariToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.istoricStripMenuItem,
            this.adaugaDozareToolStripMenuItem,
            this.stergeDozareToolStripMenuItem,
            this.editeazaDozareToolStripMenuItem});
            this.dozariToolStripMenuItem.Name = "dozariToolStripMenuItem";
            this.dozariToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.dozariToolStripMenuItem.Text = "Dozare";
            // 
            // istoricStripMenuItem
            // 
            this.istoricStripMenuItem.Name = "istoricStripMenuItem";
            this.istoricStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.istoricStripMenuItem.Text = "Istoric dozari";
            this.istoricStripMenuItem.Click += new System.EventHandler(this.istoricStripMenuItem_Click);
            // 
            // adaugaDozareToolStripMenuItem
            // 
            this.adaugaDozareToolStripMenuItem.Name = "adaugaDozareToolStripMenuItem";
            this.adaugaDozareToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.adaugaDozareToolStripMenuItem.Text = "Adauga dozare";
            this.adaugaDozareToolStripMenuItem.Click += new System.EventHandler(this.adaugaDozareToolStripMenuItem_Click);
            // 
            // stergeDozareToolStripMenuItem
            // 
            this.stergeDozareToolStripMenuItem.Name = "stergeDozareToolStripMenuItem";
            this.stergeDozareToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.stergeDozareToolStripMenuItem.Text = "Sterge dozare";
            this.stergeDozareToolStripMenuItem.Click += new System.EventHandler(this.stergeDozareToolStripMenuItem_Click);
            // 
            // editeazaDozareToolStripMenuItem
            // 
            this.editeazaDozareToolStripMenuItem.Name = "editeazaDozareToolStripMenuItem";
            this.editeazaDozareToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.editeazaDozareToolStripMenuItem.Text = "Editeaza dozare";
            this.editeazaDozareToolStripMenuItem.Click += new System.EventHandler(this.editeazaDozareToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(58, 24);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(113, 100);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(253, 22);
            this.textBoxUser.TabIndex = 3;
            // 
            // textBoxParola
            // 
            this.textBoxParola.Location = new System.Drawing.Point(113, 173);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.Size = new System.Drawing.Size(253, 22);
            this.textBoxParola.TabIndex = 4;
            this.textBoxParola.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Acces aplicatie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(28, 51);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(0, 17);
            this.labelTest.TabIndex = 6;
            // 
            // adaugaUtilizatorToolStripMenuItem
            // 
            this.adaugaUtilizatorToolStripMenuItem.Name = "adaugaUtilizatorToolStripMenuItem";
            this.adaugaUtilizatorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.adaugaUtilizatorToolStripMenuItem.Text = "Adauga Utilizator";
            this.adaugaUtilizatorToolStripMenuItem.Click += new System.EventHandler(this.adaugaUtilizatorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 326);
            this.ControlBox = false;
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Fertilizare";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adaugaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acvariuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem substantaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dozariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istoricStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaDozareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeDozareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.ToolStripMenuItem editeazaDozareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereAcvariuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergereSubstanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugaUtilizatorToolStripMenuItem;
    }
}

