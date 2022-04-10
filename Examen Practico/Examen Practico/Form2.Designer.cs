
namespace Examen_Practico
{
    partial class Form2
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
            this.listBoxQuotes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxQuotes
            // 
            this.listBoxQuotes.BackColor = System.Drawing.Color.Indigo;
            this.listBoxQuotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxQuotes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBoxQuotes.FormattingEnabled = true;
            this.listBoxQuotes.Location = new System.Drawing.Point(12, 13);
            this.listBoxQuotes.Name = "listBoxQuotes";
            this.listBoxQuotes.Size = new System.Drawing.Size(763, 418);
            this.listBoxQuotes.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.listBoxQuotes);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxQuotes;
    }
}