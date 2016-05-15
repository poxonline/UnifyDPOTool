namespace Unify_DPO_Tool
{
    partial class vorDefTexte_aendern
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vorDefTexte_aendern));
            this.speichern = new System.Windows.Forms.Button();
            this.abbrechen = new System.Windows.Forms.Button();
            this.VorDefText = new System.Windows.Forms.RichTextBox();
            this.hinweis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // speichern
            // 
            this.speichern.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.speichern.Location = new System.Drawing.Point(12, 222);
            this.speichern.Name = "speichern";
            this.speichern.Size = new System.Drawing.Size(75, 23);
            this.speichern.TabIndex = 1;
            this.speichern.Text = "Speichern";
            this.speichern.UseVisualStyleBackColor = true;
            this.speichern.Click += new System.EventHandler(this.speichern_Click);
            // 
            // abbrechen
            // 
            this.abbrechen.Location = new System.Drawing.Point(370, 222);
            this.abbrechen.Name = "abbrechen";
            this.abbrechen.Size = new System.Drawing.Size(75, 23);
            this.abbrechen.TabIndex = 2;
            this.abbrechen.Text = "Abbrechen";
            this.abbrechen.UseVisualStyleBackColor = true;
            this.abbrechen.Click += new System.EventHandler(this.abbrechen_Click);
            // 
            // VorDefText
            // 
            this.VorDefText.Location = new System.Drawing.Point(4, 12);
            this.VorDefText.Name = "VorDefText";
            this.VorDefText.Size = new System.Drawing.Size(441, 178);
            this.VorDefText.TabIndex = 3;
            this.VorDefText.Text = "";
            // 
            // hinweis
            // 
            this.hinweis.AutoSize = true;
            this.hinweis.Location = new System.Drawing.Point(12, 193);
            this.hinweis.Name = "hinweis";
            this.hinweis.Size = new System.Drawing.Size(417, 13);
            this.hinweis.TabIndex = 4;
            this.hinweis.Text = "Hinweis: Ein neuer Punkt im Dropdown Menü wird durch einen Zeilenumbruch erkannt." +
    "";
            // 
            // vorDefTexte_aendern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 257);
            this.Controls.Add(this.hinweis);
            this.Controls.Add(this.VorDefText);
            this.Controls.Add(this.abbrechen);
            this.Controls.Add(this.speichern);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "vorDefTexte_aendern";
            this.Text = "Vordefinierte Texte ändern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button speichern;
        private System.Windows.Forms.Button abbrechen;
        private System.Windows.Forms.RichTextBox VorDefText;
        private System.Windows.Forms.Label hinweis;
    }
}