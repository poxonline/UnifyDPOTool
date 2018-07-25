namespace Unify_DPO_Tool
{
    partial class ChangelogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangelogForm));
            this.lb_legende = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_aenderungen = new System.Windows.Forms.Label();
            this.gb_aenderungen = new System.Windows.Forms.GroupBox();
            this.cb_legende = new System.Windows.Forms.GroupBox();
            this.gb_aenderungen.SuspendLayout();
            this.cb_legende.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_legende
            // 
            this.lb_legende.AutoSize = true;
            this.lb_legende.Location = new System.Drawing.Point(6, 16);
            this.lb_legende.Name = "lb_legende";
            this.lb_legende.Size = new System.Drawing.Size(178, 39);
            this.lb_legende.TabIndex = 0;
            this.lb_legende.Text = "+ = neue(s) Feature/Funktion\r\n*  = Bugfix\r\n-  = Feature/Funktion wurde entfernt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // lb_aenderungen
            // 
            this.lb_aenderungen.AutoSize = true;
            this.lb_aenderungen.Location = new System.Drawing.Point(6, 16);
            this.lb_aenderungen.Name = "lb_aenderungen";
            this.lb_aenderungen.Size = new System.Drawing.Size(281, 39);
            this.lb_aenderungen.TabIndex = 2;
            this.lb_aenderungen.Text = "Version 0.0.10.2:\r\n+ Changelog hinzugefügt\r\n+ Strg + C zum kopieren funktioniert " +
    "in den Dispo Fenstern";
            // 
            // gb_aenderungen
            // 
            this.gb_aenderungen.Controls.Add(this.lb_aenderungen);
            this.gb_aenderungen.Location = new System.Drawing.Point(13, 13);
            this.gb_aenderungen.Name = "gb_aenderungen";
            this.gb_aenderungen.Size = new System.Drawing.Size(290, 152);
            this.gb_aenderungen.TabIndex = 3;
            this.gb_aenderungen.TabStop = false;
            this.gb_aenderungen.Text = "Änderungen";
            // 
            // cb_legende
            // 
            this.cb_legende.Controls.Add(this.lb_legende);
            this.cb_legende.Location = new System.Drawing.Point(309, 13);
            this.cb_legende.Name = "cb_legende";
            this.cb_legende.Size = new System.Drawing.Size(189, 65);
            this.cb_legende.TabIndex = 4;
            this.cb_legende.TabStop = false;
            this.cb_legende.Text = "Legende";
            // 
            // ChangelogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 177);
            this.Controls.Add(this.cb_legende);
            this.Controls.Add(this.gb_aenderungen);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(535, 216);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(535, 216);
            this.Name = "ChangelogForm";
            this.Text = "Unify DPO - Changelog";
            this.gb_aenderungen.ResumeLayout(false);
            this.gb_aenderungen.PerformLayout();
            this.cb_legende.ResumeLayout(false);
            this.cb_legende.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_legende;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_aenderungen;
        private System.Windows.Forms.GroupBox gb_aenderungen;
        private System.Windows.Forms.GroupBox cb_legende;
    }
}