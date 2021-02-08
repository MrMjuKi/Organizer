
namespace Organizer_Forms
{
    partial class fDodajUczestnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDodajUczestnika));
            this.lImie = new System.Windows.Forms.Label();
            this.lRelacja = new System.Windows.Forms.Label();
            this.txtNr_tel = new System.Windows.Forms.TextBox();
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtRelacja = new System.Windows.Forms.TextBox();
            this.dtpData_ur = new System.Windows.Forms.DateTimePicker();
            this.lData_ur = new System.Windows.Forms.Label();
            this.lNr_Tel = new System.Windows.Forms.Label();
            this.bDodaj = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lImie
            // 
            this.lImie.AutoSize = true;
            this.lImie.BackColor = System.Drawing.Color.Transparent;
            this.lImie.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lImie.ForeColor = System.Drawing.Color.DimGray;
            this.lImie.Location = new System.Drawing.Point(14, 63);
            this.lImie.Name = "lImie";
            this.lImie.Size = new System.Drawing.Size(162, 25);
            this.lImie.TabIndex = 0;
            this.lImie.Text = "Imię i nazwisko";
            // 
            // lRelacja
            // 
            this.lRelacja.AutoSize = true;
            this.lRelacja.BackColor = System.Drawing.Color.Transparent;
            this.lRelacja.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lRelacja.ForeColor = System.Drawing.Color.DimGray;
            this.lRelacja.Location = new System.Drawing.Point(14, 250);
            this.lRelacja.Name = "lRelacja";
            this.lRelacja.Size = new System.Drawing.Size(86, 25);
            this.lRelacja.TabIndex = 2;
            this.lRelacja.Text = "Relacja";
            this.lRelacja.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNr_tel
            // 
            this.txtNr_tel.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNr_tel.Location = new System.Drawing.Point(385, 192);
            this.txtNr_tel.Multiline = true;
            this.txtNr_tel.Name = "txtNr_tel";
            this.txtNr_tel.Size = new System.Drawing.Size(200, 29);
            this.txtNr_tel.TabIndex = 3;
            // 
            // txtImie
            // 
            this.txtImie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtImie.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtImie.Location = new System.Drawing.Point(194, 59);
            this.txtImie.Multiline = true;
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(200, 29);
            this.txtImie.TabIndex = 5;
            // 
            // txtRelacja
            // 
            this.txtRelacja.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtRelacja.Location = new System.Drawing.Point(385, 312);
            this.txtRelacja.Multiline = true;
            this.txtRelacja.Name = "txtRelacja";
            this.txtRelacja.Size = new System.Drawing.Size(200, 29);
            this.txtRelacja.TabIndex = 6;
            // 
            // dtpData_ur
            // 
            this.dtpData_ur.CustomFormat = "dd/MM/yyyy";
            this.dtpData_ur.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpData_ur.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dtpData_ur.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpData_ur.Location = new System.Drawing.Point(385, 259);
            this.dtpData_ur.Name = "dtpData_ur";
            this.dtpData_ur.Size = new System.Drawing.Size(200, 29);
            this.dtpData_ur.TabIndex = 7;
            // 
            // lData_ur
            // 
            this.lData_ur.AutoSize = true;
            this.lData_ur.BackColor = System.Drawing.Color.Transparent;
            this.lData_ur.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lData_ur.ForeColor = System.Drawing.Color.DimGray;
            this.lData_ur.Location = new System.Drawing.Point(14, 197);
            this.lData_ur.Name = "lData_ur";
            this.lData_ur.Size = new System.Drawing.Size(161, 25);
            this.lData_ur.TabIndex = 8;
            this.lData_ur.Text = "Data urodzenia";
            // 
            // lNr_Tel
            // 
            this.lNr_Tel.AutoSize = true;
            this.lNr_Tel.BackColor = System.Drawing.Color.Transparent;
            this.lNr_Tel.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lNr_Tel.ForeColor = System.Drawing.Color.DimGray;
            this.lNr_Tel.Location = new System.Drawing.Point(14, 130);
            this.lNr_Tel.Name = "lNr_Tel";
            this.lNr_Tel.Size = new System.Drawing.Size(164, 25);
            this.lNr_Tel.TabIndex = 9;
            this.lNr_Tel.Text = "Numer telefonu";
            // 
            // bDodaj
            // 
            this.bDodaj.BackColor = System.Drawing.SystemColors.Control;
            this.bDodaj.Font = new System.Drawing.Font("Yu Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bDodaj.ForeColor = System.Drawing.Color.Gray;
            this.bDodaj.Location = new System.Drawing.Point(317, 379);
            this.bDodaj.Name = "bDodaj";
            this.bDodaj.Size = new System.Drawing.Size(200, 69);
            this.bDodaj.TabIndex = 10;
            this.bDodaj.Text = "Dodaj znajomego";
            this.bDodaj.UseVisualStyleBackColor = false;
            this.bDodaj.Click += new System.EventHandler(this.bDodaj_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lImie);
            this.panel1.Controls.Add(this.lData_ur);
            this.panel1.Controls.Add(this.lNr_Tel);
            this.panel1.Controls.Add(this.txtImie);
            this.panel1.Controls.Add(this.lRelacja);
            this.panel1.Location = new System.Drawing.Point(191, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 402);
            this.panel1.TabIndex = 11;
            // 
            // fDodajUczestnika
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(830, 563);
            this.Controls.Add(this.bDodaj);
            this.Controls.Add(this.dtpData_ur);
            this.Controls.Add(this.txtRelacja);
            this.Controls.Add(this.txtNr_tel);
            this.Controls.Add(this.panel1);
            this.Name = "fDodajUczestnika";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodawanie znajomego";
            this.Load += new System.EventHandler(this.fDodajUczestnika_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lImie;
        private System.Windows.Forms.Label lRelacja;
        private System.Windows.Forms.TextBox txtNr_tel;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtRelacja;
        private System.Windows.Forms.DateTimePicker dtpData_ur;
        private System.Windows.Forms.Label lData_ur;
        private System.Windows.Forms.Label lNr_Tel;
        private System.Windows.Forms.Button bDodaj;
        private System.Windows.Forms.Panel panel1;
    }
}