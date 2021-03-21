namespace fertilizare.Data_acces_Layer
{
    partial class EditeazaDozari
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
            this.dataGridViewDozari = new System.Windows.Forms.DataGridView();
            this.buttonAfisare = new System.Windows.Forms.Button();
            this.buttonEditare = new System.Windows.Forms.Button();
            this.buttonIesire = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDozari)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabel Dozari";
            // 
            // dataGridViewDozari
            // 
            this.dataGridViewDozari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDozari.Location = new System.Drawing.Point(48, 73);
            this.dataGridViewDozari.Name = "dataGridViewDozari";
            this.dataGridViewDozari.RowHeadersWidth = 51;
            this.dataGridViewDozari.RowTemplate.Height = 24;
            this.dataGridViewDozari.Size = new System.Drawing.Size(696, 265);
            this.dataGridViewDozari.TabIndex = 1;
            // 
            // buttonAfisare
            // 
            this.buttonAfisare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAfisare.Location = new System.Drawing.Point(48, 371);
            this.buttonAfisare.Name = "buttonAfisare";
            this.buttonAfisare.Size = new System.Drawing.Size(123, 29);
            this.buttonAfisare.TabIndex = 2;
            this.buttonAfisare.Text = "Afisare";
            this.buttonAfisare.UseVisualStyleBackColor = true;
            this.buttonAfisare.Click += new System.EventHandler(this.buttonAfisare_Click);
            // 
            // buttonEditare
            // 
            this.buttonEditare.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditare.Location = new System.Drawing.Point(324, 371);
            this.buttonEditare.Name = "buttonEditare";
            this.buttonEditare.Size = new System.Drawing.Size(123, 29);
            this.buttonEditare.TabIndex = 3;
            this.buttonEditare.Text = "Editare";
            this.buttonEditare.UseVisualStyleBackColor = true;
            this.buttonEditare.Click += new System.EventHandler(this.buttonEditare_Click);
            // 
            // buttonIesire
            // 
            this.buttonIesire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIesire.Location = new System.Drawing.Point(621, 371);
            this.buttonIesire.Name = "buttonIesire";
            this.buttonIesire.Size = new System.Drawing.Size(123, 29);
            this.buttonIesire.TabIndex = 4;
            this.buttonIesire.Text = "Iesire";
            this.buttonIesire.UseVisualStyleBackColor = true;
            this.buttonIesire.Click += new System.EventHandler(this.buttonIesire_Click);
            // 
            // EditareDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonIesire);
            this.Controls.Add(this.buttonEditare);
            this.Controls.Add(this.buttonAfisare);
            this.Controls.Add(this.dataGridViewDozari);
            this.Controls.Add(this.label1);
            this.Name = "EditareDate";
            this.Text = "EditareDate";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDozari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewDozari;
        private System.Windows.Forms.Button buttonAfisare;
        private System.Windows.Forms.Button buttonEditare;
        private System.Windows.Forms.Button buttonIesire;
    }
}