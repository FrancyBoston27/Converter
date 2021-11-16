namespace Convertitore
{
    partial class home
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.benevnuto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dieciAsedici = new System.Windows.Forms.RadioButton();
            this.dieciAotto = new System.Windows.Forms.RadioButton();
            this.dieciAdue = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.descrizione = new System.Windows.Forms.Label();
            this.inizia = new System.Windows.Forms.Button();
            this.languageButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // benevnuto
            // 
            this.benevnuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.benevnuto, "benevnuto");
            this.benevnuto.Name = "benevnuto";
            this.benevnuto.Click += new System.EventHandler(this.benvenuto_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dieciAsedici);
            this.groupBox1.Controls.Add(this.dieciAotto);
            this.groupBox1.Controls.Add(this.dieciAdue);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // dieciAsedici
            // 
            resources.ApplyResources(this.dieciAsedici, "dieciAsedici");
            this.dieciAsedici.Name = "dieciAsedici";
            this.dieciAsedici.TabStop = true;
            this.dieciAsedici.UseVisualStyleBackColor = true;
            this.dieciAsedici.CheckedChanged += new System.EventHandler(this.dieciAsedici_CheckedChanged);
            // 
            // dieciAotto
            // 
            resources.ApplyResources(this.dieciAotto, "dieciAotto");
            this.dieciAotto.Name = "dieciAotto";
            this.dieciAotto.TabStop = true;
            this.dieciAotto.UseVisualStyleBackColor = true;
            this.dieciAotto.CheckedChanged += new System.EventHandler(this.dieciAotto_CheckedChanged);
            // 
            // dieciAdue
            // 
            resources.ApplyResources(this.dieciAdue, "dieciAdue");
            this.dieciAdue.Name = "dieciAdue";
            this.dieciAdue.TabStop = true;
            this.dieciAdue.UseVisualStyleBackColor = true;
            this.dieciAdue.CheckedChanged += new System.EventHandler(this.dieciAdue_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.descrizione);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // descrizione
            // 
            resources.ApplyResources(this.descrizione, "descrizione");
            this.descrizione.Name = "descrizione";
            this.descrizione.Click += new System.EventHandler(this.descrizione_Click);
            // 
            // inizia
            // 
            resources.ApplyResources(this.inizia, "inizia");
            this.inizia.Name = "inizia";
            this.inizia.UseVisualStyleBackColor = true;
            this.inizia.Click += new System.EventHandler(this.inizia_Click);
            // 
            // languageButton
            // 
            resources.ApplyResources(this.languageButton, "languageButton");
            this.languageButton.Name = "languageButton";
            this.languageButton.UseVisualStyleBackColor = true;
            this.languageButton.Click += new System.EventHandler(this.languageButton_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Name = "label3";
            // 
            // home
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.languageButton);
            this.Controls.Add(this.inizia);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.benevnuto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "home";
            this.Load += new System.EventHandler(this.home_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label benevnuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton dieciAdue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label descrizione;
        private System.Windows.Forms.Button inizia;
        private System.Windows.Forms.RadioButton dieciAotto;
        private System.Windows.Forms.RadioButton dieciAsedici;
        private System.Windows.Forms.Button languageButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

