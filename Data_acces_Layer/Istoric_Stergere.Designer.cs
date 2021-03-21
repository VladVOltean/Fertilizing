namespace fertilizare.Data_acces_Layer
{
    partial class Istoric_Stergere
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
            this.comboBoxAcvariu = new System.Windows.Forms.ComboBox();
            this.comboBoxData = new System.Windows.Forms.ComboBox();
            this.buttonIesire = new System.Windows.Forms.Button();
            this.listBoxDozari = new System.Windows.Forms.ListBox();
            this.checkedListBoxDozare = new System.Windows.Forms.CheckedListBox();
            this.buttonSterge = new System.Windows.Forms.Button();
            this.buttonRenunta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecteaza acvariul";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecteaza data dozarii";
            // 
            // comboBoxAcvariu
            // 
            this.comboBoxAcvariu.FormattingEnabled = true;
            this.comboBoxAcvariu.Location = new System.Drawing.Point(399, 45);
            this.comboBoxAcvariu.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAcvariu.Name = "comboBoxAcvariu";
            this.comboBoxAcvariu.Size = new System.Drawing.Size(405, 28);
            this.comboBoxAcvariu.TabIndex = 4;
            this.comboBoxAcvariu.SelectionChangeCommitted += new System.EventHandler(this.comboBoxAcvariu_SelectionChangeCommitted);
            // 
            // comboBoxData
            // 
            this.comboBoxData.FormattingEnabled = true;
            this.comboBoxData.Location = new System.Drawing.Point(399, 113);
            this.comboBoxData.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxData.Name = "comboBoxData";
            this.comboBoxData.Size = new System.Drawing.Size(405, 28);
            this.comboBoxData.TabIndex = 5;
            this.comboBoxData.SelectionChangeCommitted += new System.EventHandler(this.comboBoxData_SelectionChangeCommitted);
            // 
            // buttonIesire
            // 
            this.buttonIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIesire.Location = new System.Drawing.Point(668, 485);
            this.buttonIesire.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIesire.Name = "buttonIesire";
            this.buttonIesire.Size = new System.Drawing.Size(161, 33);
            this.buttonIesire.TabIndex = 7;
            this.buttonIesire.Text = "Iesire";
            this.buttonIesire.UseVisualStyleBackColor = true;
            this.buttonIesire.Click += new System.EventHandler(this.buttonIesire_Click);
            // 
            // listBoxDozari
            // 
            this.listBoxDozari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxDozari.FormattingEnabled = true;
            this.listBoxDozari.ItemHeight = 20;
            this.listBoxDozari.Location = new System.Drawing.Point(43, 259);
            this.listBoxDozari.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDozari.Name = "listBoxDozari";
            this.listBoxDozari.Size = new System.Drawing.Size(377, 204);
            this.listBoxDozari.TabIndex = 9;
            // 
            // checkedListBoxDozare
            // 
            this.checkedListBoxDozare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxDozare.FormattingEnabled = true;
            this.checkedListBoxDozare.Location = new System.Drawing.Point(476, 259);
            this.checkedListBoxDozare.Name = "checkedListBoxDozare";
            this.checkedListBoxDozare.Size = new System.Drawing.Size(377, 193);
            this.checkedListBoxDozare.TabIndex = 10;
            // 
            // buttonSterge
            // 
            this.buttonSterge.Location = new System.Drawing.Point(43, 485);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(161, 33);
            this.buttonSterge.TabIndex = 13;
            this.buttonSterge.Text = "Sterge";
            this.buttonSterge.UseVisualStyleBackColor = true;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // buttonRenunta
            // 
            this.buttonRenunta.Location = new System.Drawing.Point(355, 485);
            this.buttonRenunta.Name = "buttonRenunta";
            this.buttonRenunta.Size = new System.Drawing.Size(161, 33);
            this.buttonRenunta.TabIndex = 14;
            this.buttonRenunta.Text = "Renunta";
            this.buttonRenunta.UseVisualStyleBackColor = true;
            this.buttonRenunta.Click += new System.EventHandler(this.buttonRenunta_Click);
            // 
            // Istoric_Stergere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 568);
            this.Controls.Add(this.buttonRenunta);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.checkedListBoxDozare);
            this.Controls.Add(this.listBoxDozari);
            this.Controls.Add(this.buttonIesire);
            this.Controls.Add(this.comboBoxData);
            this.Controls.Add(this.comboBoxAcvariu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Istoric_Stergere";
            this.Text = "IstoricDozari";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxAcvariu;
        private System.Windows.Forms.ComboBox comboBoxData;
        private System.Windows.Forms.Button buttonIesire;
        private System.Windows.Forms.ListBox listBoxDozari;
        private System.Windows.Forms.CheckedListBox checkedListBoxDozare;
        private System.Windows.Forms.Button buttonSterge;
        private System.Windows.Forms.Button buttonRenunta;
    }
}