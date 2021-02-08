
namespace Organizer_Forms
{
    partial class fWyswWynikWyszukZdarzPoDacie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fWyswWynikWyszukZdarzPoDacie));
            this.checkedListBoxZdarzOddzn = new System.Windows.Forms.CheckedListBox();
            this.listBoxZdarzStand = new System.Windows.Forms.ListBox();
            this.labelData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkedListBoxZdarzOddzn
            // 
            this.checkedListBoxZdarzOddzn.CheckOnClick = true;
            this.checkedListBoxZdarzOddzn.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkedListBoxZdarzOddzn.FormattingEnabled = true;
            this.checkedListBoxZdarzOddzn.HorizontalScrollbar = true;
            this.checkedListBoxZdarzOddzn.Location = new System.Drawing.Point(108, 105);
            this.checkedListBoxZdarzOddzn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBoxZdarzOddzn.Name = "checkedListBoxZdarzOddzn";
            this.checkedListBoxZdarzOddzn.Size = new System.Drawing.Size(304, 74);
            this.checkedListBoxZdarzOddzn.TabIndex = 7;
            this.checkedListBoxZdarzOddzn.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxZdarzOddzn_SelectedIndexChanged);
            // 
            // listBoxZdarzStand
            // 
            this.listBoxZdarzStand.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxZdarzStand.FormattingEnabled = true;
            this.listBoxZdarzStand.HorizontalScrollbar = true;
            this.listBoxZdarzStand.ItemHeight = 26;
            this.listBoxZdarzStand.Location = new System.Drawing.Point(108, 233);
            this.listBoxZdarzStand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxZdarzStand.Name = "listBoxZdarzStand";
            this.listBoxZdarzStand.Size = new System.Drawing.Size(304, 186);
            this.listBoxZdarzStand.Sorted = true;
            this.listBoxZdarzStand.TabIndex = 6;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelData.Location = new System.Drawing.Point(117, 31);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(100, 26);
            this.labelData.TabIndex = 5;
            this.labelData.Text = "labelData";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(451, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // fWyswWynikWyszukZdarzPoDacie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(612, 532);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxZdarzOddzn);
            this.Controls.Add(this.listBoxZdarzStand);
            this.Controls.Add(this.labelData);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fWyswWynikWyszukZdarzPoDacie";
            this.Text = "fWyswWynikWyszukZdarzPoDacie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox checkedListBoxZdarzOddzn;
        private System.Windows.Forms.ListBox listBoxZdarzStand;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label label1;
    }
}