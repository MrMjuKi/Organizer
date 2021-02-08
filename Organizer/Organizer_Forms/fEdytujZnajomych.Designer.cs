
namespace Organizer_Forms
{
    partial class fEdytujZnajomych
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fEdytujZnajomych));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.imie_txt = new System.Windows.Forms.TextBox();
            this.relacja_txt = new System.Windows.Forms.TextBox();
            this.tel_txt = new System.Windows.Forms.TextBox();
            this.lImie = new System.Windows.Forms.Label();
            this.lData_ur = new System.Windows.Forms.Label();
            this.lNr_Tel = new System.Windows.Forms.Label();
            this.lRelacja = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.DateTimePicker1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.imie_txt);
            this.panel1.Controls.Add(this.relacja_txt);
            this.panel1.Controls.Add(this.tel_txt);
            this.panel1.Controls.Add(this.lImie);
            this.panel1.Controls.Add(this.lData_ur);
            this.panel1.Controls.Add(this.lNr_Tel);
            this.panel1.Controls.Add(this.lRelacja);
            this.panel1.Location = new System.Drawing.Point(49, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(696, 348);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Location = new System.Drawing.Point(502, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 41);
            this.button2.TabIndex = 27;
            this.button2.Text = "Usuń osobę";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.DateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePicker1.Location = new System.Drawing.Point(230, 184);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.DateTimePicker1.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Location = new System.Drawing.Point(153, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(277, 41);
            this.button1.TabIndex = 25;
            this.button1.Text = "Zapisz zmiany";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(464, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 204);
            this.listBox1.TabIndex = 24;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // imie_txt
            // 
            this.imie_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imie_txt.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imie_txt.Location = new System.Drawing.Point(230, 58);
            this.imie_txt.Multiline = true;
            this.imie_txt.Name = "imie_txt";
            this.imie_txt.Size = new System.Drawing.Size(200, 35);
            this.imie_txt.TabIndex = 18;
            // 
            // relacja_txt
            // 
            this.relacja_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.relacja_txt.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.relacja_txt.Location = new System.Drawing.Point(230, 233);
            this.relacja_txt.Multiline = true;
            this.relacja_txt.Name = "relacja_txt";
            this.relacja_txt.Size = new System.Drawing.Size(200, 33);
            this.relacja_txt.TabIndex = 16;
            // 
            // tel_txt
            // 
            this.tel_txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tel_txt.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tel_txt.Location = new System.Drawing.Point(230, 131);
            this.tel_txt.Multiline = true;
            this.tel_txt.Name = "tel_txt";
            this.tel_txt.Size = new System.Drawing.Size(200, 35);
            this.tel_txt.TabIndex = 15;
            // 
            // lImie
            // 
            this.lImie.AutoSize = true;
            this.lImie.BackColor = System.Drawing.Color.Transparent;
            this.lImie.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lImie.ForeColor = System.Drawing.Color.DimGray;
            this.lImie.Location = new System.Drawing.Point(36, 70);
            this.lImie.Name = "lImie";
            this.lImie.Size = new System.Drawing.Size(162, 25);
            this.lImie.TabIndex = 10;
            this.lImie.Text = "Imię i nazwisko";
            // 
            // lData_ur
            // 
            this.lData_ur.AutoSize = true;
            this.lData_ur.BackColor = System.Drawing.Color.Transparent;
            this.lData_ur.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lData_ur.ForeColor = System.Drawing.Color.DimGray;
            this.lData_ur.Location = new System.Drawing.Point(36, 188);
            this.lData_ur.Name = "lData_ur";
            this.lData_ur.Size = new System.Drawing.Size(161, 25);
            this.lData_ur.TabIndex = 13;
            this.lData_ur.Text = "Data urodzenia";
            // 
            // lNr_Tel
            // 
            this.lNr_Tel.AutoSize = true;
            this.lNr_Tel.BackColor = System.Drawing.Color.Transparent;
            this.lNr_Tel.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lNr_Tel.ForeColor = System.Drawing.Color.DimGray;
            this.lNr_Tel.Location = new System.Drawing.Point(36, 131);
            this.lNr_Tel.Name = "lNr_Tel";
            this.lNr_Tel.Size = new System.Drawing.Size(164, 25);
            this.lNr_Tel.TabIndex = 14;
            this.lNr_Tel.Text = "Numer telefonu";
            // 
            // lRelacja
            // 
            this.lRelacja.AutoSize = true;
            this.lRelacja.BackColor = System.Drawing.Color.Transparent;
            this.lRelacja.Font = new System.Drawing.Font("Yu Gothic Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lRelacja.ForeColor = System.Drawing.Color.DimGray;
            this.lRelacja.Location = new System.Drawing.Point(36, 233);
            this.lRelacja.Name = "lRelacja";
            this.lRelacja.Size = new System.Drawing.Size(86, 25);
            this.lRelacja.TabIndex = 12;
            this.lRelacja.Text = "Relacja";
            // 
            // fEdytujZnajomych
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.Controls.Add(this.panel1);
            this.Name = "fEdytujZnajomych";
            this.Text = "fEdytujZnajomych";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lImie;
        private System.Windows.Forms.Label lData_ur;
        private System.Windows.Forms.Label lNr_Tel;
        private System.Windows.Forms.Label lRelacja;
        private System.Windows.Forms.TextBox imie_txt;
        private System.Windows.Forms.TextBox relacja_txt;
        private System.Windows.Forms.TextBox tel_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        private System.Windows.Forms.Button button2;
    }
}