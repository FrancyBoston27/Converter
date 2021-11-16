namespace Convertitore
{
    partial class dieciAdueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dieciAdueForm));
            this.title = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.decimal1 = new System.Windows.Forms.Label();
            this.dex1 = new System.Windows.Forms.TextBox();
            this.binary1 = new System.Windows.Forms.Label();
            this.bin1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bin2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dex2 = new System.Windows.Forms.TextBox();
            this.calcola1 = new System.Windows.Forms.Button();
            this.calcola2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            resources.ApplyResources(this.title, "title");
            this.title.Name = "title";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // description
            // 
            resources.ApplyResources(this.description, "description");
            this.description.Name = "description";
            // 
            // decimal1
            // 
            resources.ApplyResources(this.decimal1, "decimal1");
            this.decimal1.Name = "decimal1";
            // 
            // dex1
            // 
            resources.ApplyResources(this.dex1, "dex1");
            this.dex1.Name = "dex1";
            this.dex1.TextChanged += new System.EventHandler(this.dex1_TextChanged);
            // 
            // binary1
            // 
            resources.ApplyResources(this.binary1, "binary1");
            this.binary1.Name = "binary1";
            // 
            // bin1
            // 
            resources.ApplyResources(this.bin1, "bin1");
            this.bin1.Name = "bin1";
            this.bin1.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // bin2
            // 
            resources.ApplyResources(this.bin2, "bin2");
            this.bin2.Name = "bin2";
            this.bin2.TextChanged += new System.EventHandler(this.bin2_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // dex2
            // 
            resources.ApplyResources(this.dex2, "dex2");
            this.dex2.Name = "dex2";
            this.dex2.ReadOnly = true;
            // 
            // calcola1
            // 
            resources.ApplyResources(this.calcola1, "calcola1");
            this.calcola1.Name = "calcola1";
            this.calcola1.UseVisualStyleBackColor = true;
            this.calcola1.Click += new System.EventHandler(this.calcola1_Click);
            // 
            // calcola2
            // 
            resources.ApplyResources(this.calcola2, "calcola2");
            this.calcola2.Name = "calcola2";
            this.calcola2.UseVisualStyleBackColor = true;
            this.calcola2.Click += new System.EventHandler(this.calcola2_Click);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // dieciAdueForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.calcola2);
            this.Controls.Add(this.calcola1);
            this.Controls.Add(this.dex2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bin2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bin1);
            this.Controls.Add(this.binary1);
            this.Controls.Add(this.dex1);
            this.Controls.Add(this.decimal1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "dieciAdueForm";
            this.Load += new System.EventHandler(this.dieciAdueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label decimal1;
        private System.Windows.Forms.TextBox dex1;
        private System.Windows.Forms.Label binary1;
        private System.Windows.Forms.TextBox bin1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bin2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dex2;
        private System.Windows.Forms.Button calcola1;
        private System.Windows.Forms.Button calcola2;
    }
}