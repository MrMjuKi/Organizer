namespace Organizer_Forms
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonWyszkPoDacie = new System.Windows.Forms.Button();
            this.dateTimePickerWyszukiwarka = new System.Windows.Forms.DateTimePicker();
            this.labelOpisPojutrze = new System.Windows.Forms.Label();
            this.labelOpisJutro = new System.Windows.Forms.Label();
            this.labelOpisDzisiaj = new System.Windows.Forms.Label();
            this.listBoxPojutrze = new System.Windows.Forms.ListBox();
            this.listBoxJutro = new System.Windows.Forms.ListBox();
            this.checkedListBoxJutro = new System.Windows.Forms.CheckedListBox();
            this.listBoxDzis = new System.Windows.Forms.ListBox();
            this.checkedListBoxPojutrze = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxDzis = new System.Windows.Forms.CheckedListBox();
            this.buttonWyszukaj = new System.Windows.Forms.Button();
            this.textBoxWyszukaj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Brown;
            this.button1.Location = new System.Drawing.Point(-1, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(303, 95);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dodaj wydarzenie";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.Brown;
            this.button2.Location = new System.Drawing.Point(-1, 192);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(305, 85);
            this.button2.TabIndex = 1;
            this.button2.Text = "Dodaj znajomego";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(179)))), ((int)(((byte)(159)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 793);
            this.panel1.TabIndex = 3;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightGray;
            this.button7.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.ForeColor = System.Drawing.Color.Brown;
            this.button7.Location = new System.Drawing.Point(-1, 626);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(305, 85);
            this.button7.TabIndex = 7;
            this.button7.Text = "Edytuj znajomych";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightGray;
            this.button6.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.ForeColor = System.Drawing.Color.Brown;
            this.button6.Location = new System.Drawing.Point(-1, 535);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(303, 84);
            this.button6.TabIndex = 6;
            this.button6.Text = "Edytuj miejsca";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightGray;
            this.button5.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.Color.Brown;
            this.button5.Location = new System.Drawing.Point(-1, 101);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(303, 84);
            this.button5.TabIndex = 5;
            this.button5.Text = "Dodaj zadanie";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGray;
            this.button3.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.Brown;
            this.button3.Location = new System.Drawing.Point(-1, 284);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(303, 80);
            this.button3.TabIndex = 4;
            this.button3.Text = "Dodaj miejsce";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonWyszkPoDacie
            // 
            this.buttonWyszkPoDacie.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWyszkPoDacie.ForeColor = System.Drawing.Color.Brown;
            this.buttonWyszkPoDacie.Location = new System.Drawing.Point(669, 47);
            this.buttonWyszkPoDacie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWyszkPoDacie.Name = "buttonWyszkPoDacie";
            this.buttonWyszkPoDacie.Size = new System.Drawing.Size(245, 63);
            this.buttonWyszkPoDacie.TabIndex = 28;
            this.buttonWyszkPoDacie.Text = "Wyszukaj ";
            this.buttonWyszkPoDacie.UseVisualStyleBackColor = true;
            this.buttonWyszkPoDacie.Click += new System.EventHandler(this.buttonWyszkPoDacie_Click);
            // 
            // dateTimePickerWyszukiwarka
            // 
            this.dateTimePickerWyszukiwarka.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerWyszukiwarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePickerWyszukiwarka.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerWyszukiwarka.Location = new System.Drawing.Point(335, 63);
            this.dateTimePickerWyszukiwarka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerWyszukiwarka.Name = "dateTimePickerWyszukiwarka";
            this.dateTimePickerWyszukiwarka.Size = new System.Drawing.Size(249, 45);
            this.dateTimePickerWyszukiwarka.TabIndex = 27;
            // 
            // labelOpisPojutrze
            // 
            this.labelOpisPojutrze.AutoSize = true;
            this.labelOpisPojutrze.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpisPojutrze.ForeColor = System.Drawing.Color.Maroon;
            this.labelOpisPojutrze.Location = new System.Drawing.Point(965, 182);
            this.labelOpisPojutrze.Name = "labelOpisPojutrze";
            this.labelOpisPojutrze.Size = new System.Drawing.Size(191, 26);
            this.labelOpisPojutrze.TabIndex = 26;
            this.labelOpisPojutrze.Text = "labelOpisPojutrze";
            this.labelOpisPojutrze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOpisJutro
            // 
            this.labelOpisJutro.AutoSize = true;
            this.labelOpisJutro.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpisJutro.ForeColor = System.Drawing.Color.Maroon;
            this.labelOpisJutro.Location = new System.Drawing.Point(704, 182);
            this.labelOpisJutro.Name = "labelOpisJutro";
            this.labelOpisJutro.Size = new System.Drawing.Size(157, 26);
            this.labelOpisJutro.TabIndex = 25;
            this.labelOpisJutro.Text = "labelOpisJutro";
            this.labelOpisJutro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOpisDzisiaj
            // 
            this.labelOpisDzisiaj.AutoSize = true;
            this.labelOpisDzisiaj.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelOpisDzisiaj.ForeColor = System.Drawing.Color.Maroon;
            this.labelOpisDzisiaj.Location = new System.Drawing.Point(413, 182);
            this.labelOpisDzisiaj.Name = "labelOpisDzisiaj";
            this.labelOpisDzisiaj.Size = new System.Drawing.Size(150, 26);
            this.labelOpisDzisiaj.TabIndex = 24;
            this.labelOpisDzisiaj.Text = "labelOpisDzis";
            this.labelOpisDzisiaj.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxPojutrze
            // 
            this.listBoxPojutrze.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxPojutrze.ForeColor = System.Drawing.Color.Maroon;
            this.listBoxPojutrze.FormattingEnabled = true;
            this.listBoxPojutrze.HorizontalScrollbar = true;
            this.listBoxPojutrze.ItemHeight = 26;
            this.listBoxPojutrze.Location = new System.Drawing.Point(933, 411);
            this.listBoxPojutrze.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxPojutrze.Name = "listBoxPojutrze";
            this.listBoxPojutrze.Size = new System.Drawing.Size(283, 186);
            this.listBoxPojutrze.Sorted = true;
            this.listBoxPojutrze.TabIndex = 23;
            // 
            // listBoxJutro
            // 
            this.listBoxJutro.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxJutro.ForeColor = System.Drawing.Color.Maroon;
            this.listBoxJutro.FormattingEnabled = true;
            this.listBoxJutro.HorizontalScrollbar = true;
            this.listBoxJutro.ItemHeight = 26;
            this.listBoxJutro.Location = new System.Drawing.Point(645, 411);
            this.listBoxJutro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxJutro.Name = "listBoxJutro";
            this.listBoxJutro.Size = new System.Drawing.Size(283, 186);
            this.listBoxJutro.Sorted = true;
            this.listBoxJutro.TabIndex = 22;
            // 
            // checkedListBoxJutro
            // 
            this.checkedListBoxJutro.CheckOnClick = true;
            this.checkedListBoxJutro.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedListBoxJutro.ForeColor = System.Drawing.Color.Maroon;
            this.checkedListBoxJutro.FormattingEnabled = true;
            this.checkedListBoxJutro.HorizontalScrollbar = true;
            this.checkedListBoxJutro.Location = new System.Drawing.Point(645, 249);
            this.checkedListBoxJutro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBoxJutro.Name = "checkedListBoxJutro";
            this.checkedListBoxJutro.Size = new System.Drawing.Size(283, 144);
            this.checkedListBoxJutro.TabIndex = 21;
            this.checkedListBoxJutro.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxJutro_SelectedIndexChanged);
            // 
            // listBoxDzis
            // 
            this.listBoxDzis.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxDzis.ForeColor = System.Drawing.Color.Maroon;
            this.listBoxDzis.FormattingEnabled = true;
            this.listBoxDzis.HorizontalScrollbar = true;
            this.listBoxDzis.ItemHeight = 26;
            this.listBoxDzis.Location = new System.Drawing.Point(353, 411);
            this.listBoxDzis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxDzis.Name = "listBoxDzis";
            this.listBoxDzis.Size = new System.Drawing.Size(283, 186);
            this.listBoxDzis.Sorted = true;
            this.listBoxDzis.TabIndex = 20;
            // 
            // checkedListBoxPojutrze
            // 
            this.checkedListBoxPojutrze.CheckOnClick = true;
            this.checkedListBoxPojutrze.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedListBoxPojutrze.ForeColor = System.Drawing.Color.Maroon;
            this.checkedListBoxPojutrze.FormattingEnabled = true;
            this.checkedListBoxPojutrze.HorizontalScrollbar = true;
            this.checkedListBoxPojutrze.Location = new System.Drawing.Point(933, 249);
            this.checkedListBoxPojutrze.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBoxPojutrze.Name = "checkedListBoxPojutrze";
            this.checkedListBoxPojutrze.Size = new System.Drawing.Size(283, 144);
            this.checkedListBoxPojutrze.TabIndex = 19;
            this.checkedListBoxPojutrze.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxPojutrze_SelectedIndexChanged);
            // 
            // checkedListBoxDzis
            // 
            this.checkedListBoxDzis.BackColor = System.Drawing.SystemColors.Window;
            this.checkedListBoxDzis.CheckOnClick = true;
            this.checkedListBoxDzis.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedListBoxDzis.ForeColor = System.Drawing.Color.Maroon;
            this.checkedListBoxDzis.FormattingEnabled = true;
            this.checkedListBoxDzis.HorizontalScrollbar = true;
            this.checkedListBoxDzis.Location = new System.Drawing.Point(353, 249);
            this.checkedListBoxDzis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBoxDzis.Name = "checkedListBoxDzis";
            this.checkedListBoxDzis.Size = new System.Drawing.Size(283, 144);
            this.checkedListBoxDzis.TabIndex = 18;
            this.checkedListBoxDzis.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxDzis_SelectedIndexChanged);
            // 
            // buttonWyszukaj
            // 
            this.buttonWyszukaj.BackColor = System.Drawing.Color.LightGray;
            this.buttonWyszukaj.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonWyszukaj.ForeColor = System.Drawing.Color.Brown;
            this.buttonWyszukaj.Location = new System.Drawing.Point(689, 62);
            this.buttonWyszukaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonWyszukaj.Name = "buttonWyszukaj";
            this.buttonWyszukaj.Size = new System.Drawing.Size(235, 55);
            this.buttonWyszukaj.TabIndex = 17;
            this.buttonWyszukaj.Text = "Wyszukaj";
            this.buttonWyszukaj.UseVisualStyleBackColor = false;
            this.buttonWyszukaj.Click += new System.EventHandler(this.buttonWyszukaj_Click);
            // 
            // textBoxWyszukaj
            // 
            this.textBoxWyszukaj.AcceptsTab = true;
            this.textBoxWyszukaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxWyszukaj.Location = new System.Drawing.Point(35, 62);
            this.textBoxWyszukaj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxWyszukaj.Name = "textBoxWyszukaj";
            this.textBoxWyszukaj.Size = new System.Drawing.Size(627, 55);
            this.textBoxWyszukaj.TabIndex = 16;
            this.textBoxWyszukaj.TextChanged += new System.EventHandler(this.textBoxWyszukaj_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(44, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 31);
            this.label1.TabIndex = 29;
            this.label1.Text = "Wyszukaj po nazwie zdarzenia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(44, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "Wyszukaj po dacie zdarzenia";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.dateTimePickerWyszukiwarka);
            this.panel2.Controls.Add(this.buttonWyszkPoDacie);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(303, 670);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 123);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.Controls.Add(this.textBoxWyszukaj);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.buttonWyszukaj);
            this.panel3.Location = new System.Drawing.Point(303, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 137);
            this.panel3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1241, 793);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelOpisPojutrze);
            this.Controls.Add(this.labelOpisJutro);
            this.Controls.Add(this.labelOpisDzisiaj);
            this.Controls.Add(this.listBoxPojutrze);
            this.Controls.Add(this.listBoxJutro);
            this.Controls.Add(this.checkedListBoxJutro);
            this.Controls.Add(this.listBoxDzis);
            this.Controls.Add(this.checkedListBoxPojutrze);
            this.Controls.Add(this.checkedListBoxDzis);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Organizer";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttonWyszkPoDacie;
        private System.Windows.Forms.DateTimePicker dateTimePickerWyszukiwarka;
        private System.Windows.Forms.Label labelOpisPojutrze;
        private System.Windows.Forms.Label labelOpisJutro;
        private System.Windows.Forms.Label labelOpisDzisiaj;
        private System.Windows.Forms.ListBox listBoxPojutrze;
        private System.Windows.Forms.ListBox listBoxJutro;
        private System.Windows.Forms.CheckedListBox checkedListBoxJutro;
        private System.Windows.Forms.ListBox listBoxDzis;
        private System.Windows.Forms.CheckedListBox checkedListBoxPojutrze;
        private System.Windows.Forms.CheckedListBox checkedListBoxDzis;
        private System.Windows.Forms.Button buttonWyszukaj;
        private System.Windows.Forms.TextBox textBoxWyszukaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}