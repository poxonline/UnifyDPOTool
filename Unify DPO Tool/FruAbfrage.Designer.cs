namespace Unify_DPO_Tool
{
    partial class FruAbfrage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FruAbfrage));
            this.bt_abfrage = new System.Windows.Forms.Button();
            this.bt_schliesen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.erg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_abfrage
            // 
            this.bt_abfrage.Location = new System.Drawing.Point(12, 68);
            this.bt_abfrage.Name = "bt_abfrage";
            this.bt_abfrage.Size = new System.Drawing.Size(75, 23);
            this.bt_abfrage.TabIndex = 2;
            this.bt_abfrage.Text = "Abfrage";
            this.bt_abfrage.UseVisualStyleBackColor = true;
            this.bt_abfrage.Click += new System.EventHandler(this.bt_abfrage_Click);
            // 
            // bt_schliesen
            // 
            this.bt_schliesen.Location = new System.Drawing.Point(110, 68);
            this.bt_schliesen.Name = "bt_schliesen";
            this.bt_schliesen.Size = new System.Drawing.Size(75, 23);
            this.bt_schliesen.TabIndex = 3;
            this.bt_schliesen.Text = "Schließen";
            this.bt_schliesen.UseVisualStyleBackColor = true;
            this.bt_schliesen.Click += new System.EventHandler(this.bt_schliesen_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Postleitzahl (DEU):";
            // 
            // erg
            // 
            this.erg.AutoSize = true;
            this.erg.Location = new System.Drawing.Point(12, 39);
            this.erg.Name = "erg";
            this.erg.Size = new System.Drawing.Size(51, 13);
            this.erg.TabIndex = 5;
            this.erg.Text = "Ergebnis:";
            // 
            // FruAbfrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 102);
            this.Controls.Add(this.erg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_schliesen);
            this.Controls.Add(this.bt_abfrage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FruAbfrage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRU Abfrage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_abfrage;
        private System.Windows.Forms.Button bt_schliesen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label erg;
    }
}