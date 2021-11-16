namespace Convertitore
{
    partial class languageform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(languageform));
            this.label1 = new System.Windows.Forms.Label();
            this.ita = new System.Windows.Forms.RadioButton();
            this.eng = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Language / Seleziona una lingua";
            // 
            // ita
            // 
            this.ita.AutoSize = true;
            this.ita.Checked = true;
            this.ita.Location = new System.Drawing.Point(16, 48);
            this.ita.Name = "ita";
            this.ita.Size = new System.Drawing.Size(59, 17);
            this.ita.TabIndex = 1;
            this.ita.TabStop = true;
            this.ita.Text = "Italiano";
            this.ita.UseVisualStyleBackColor = true;
            this.ita.CheckedChanged += new System.EventHandler(this.ita_CheckedChanged);
            // 
            // eng
            // 
            this.eng.AutoSize = true;
            this.eng.Location = new System.Drawing.Point(16, 71);
            this.eng.Name = "eng";
            this.eng.Size = new System.Drawing.Size(59, 17);
            this.eng.TabIndex = 2;
            this.eng.Text = "English";
            this.eng.UseVisualStyleBackColor = true;
            this.eng.CheckedChanged += new System.EventHandler(this.eng_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // languageform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 218);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.eng);
            this.Controls.Add(this.ita);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "languageform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.languageform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ita;
        private System.Windows.Forms.RadioButton eng;
        private System.Windows.Forms.Button button1;
    }
}