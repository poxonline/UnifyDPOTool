namespace Unify_DPO_Tool
{
    partial class gruppeaendern
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gruppeaendern));
            this.speichern = new System.Windows.Forms.Button();
            this.abbrechen = new System.Windows.Forms.Button();
            this.dataNetzplan = new System.Windows.Forms.RadioButton();
            this.dataSLA = new System.Windows.Forms.RadioButton();
            this.data = new System.Windows.Forms.RadioButton();
            this.voice = new System.Windows.Forms.RadioButton();
            this.uc = new System.Windows.Forms.RadioButton();
            this.security = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // speichern
            // 
            this.speichern.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.speichern.Location = new System.Drawing.Point(12, 150);
            this.speichern.Name = "speichern";
            this.speichern.Size = new System.Drawing.Size(75, 23);
            this.speichern.TabIndex = 0;
            this.speichern.Text = "Speichern";
            this.speichern.UseVisualStyleBackColor = true;
            this.speichern.Click += new System.EventHandler(this.speichern_Click);
            // 
            // abbrechen
            // 
            this.abbrechen.Location = new System.Drawing.Point(165, 150);
            this.abbrechen.Name = "abbrechen";
            this.abbrechen.Size = new System.Drawing.Size(75, 23);
            this.abbrechen.TabIndex = 1;
            this.abbrechen.Text = "Abbrechen";
            this.abbrechen.UseVisualStyleBackColor = true;
            this.abbrechen.Click += new System.EventHandler(this.abbrechen_Click);
            // 
            // dataNetzplan
            // 
            this.dataNetzplan.AutoSize = true;
            this.dataNetzplan.Location = new System.Drawing.Point(12, 12);
            this.dataNetzplan.Name = "dataNetzplan";
            this.dataNetzplan.Size = new System.Drawing.Size(228, 17);
            this.dataNetzplan.TabIndex = 2;
            this.dataNetzplan.TabStop = true;
            this.dataNetzplan.Text = "SSD DEU Data Netzpläne+Remotesupport";
            this.dataNetzplan.UseVisualStyleBackColor = true;
            // 
            // dataSLA
            // 
            this.dataSLA.AutoSize = true;
            this.dataSLA.Location = new System.Drawing.Point(12, 35);
            this.dataSLA.Name = "dataSLA";
            this.dataSLA.Size = new System.Drawing.Size(174, 17);
            this.dataSLA.TabIndex = 3;
            this.dataSLA.TabStop = true;
            this.dataSLA.Text = "SSD DEU Data SLA Controlling";
            this.dataSLA.UseVisualStyleBackColor = true;
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(12, 58);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(147, 17);
            this.data.TabIndex = 4;
            this.data.TabStop = true;
            this.data.Text = "SSD DEU Data Allgemein";
            this.data.UseVisualStyleBackColor = true;
            // 
            // voice
            // 
            this.voice.AutoSize = true;
            this.voice.Location = new System.Drawing.Point(12, 81);
            this.voice.Name = "voice";
            this.voice.Size = new System.Drawing.Size(103, 17);
            this.voice.TabIndex = 5;
            this.voice.TabStop = true;
            this.voice.Text = "SSD DEU Voice";
            this.voice.UseVisualStyleBackColor = true;
            // 
            // uc
            // 
            this.uc.AutoSize = true;
            this.uc.Location = new System.Drawing.Point(12, 104);
            this.uc.Name = "uc";
            this.uc.Size = new System.Drawing.Size(91, 17);
            this.uc.TabIndex = 6;
            this.uc.TabStop = true;
            this.uc.Text = "SSD DEU UC";
            this.uc.UseVisualStyleBackColor = true;
            // 
            // security
            // 
            this.security.AutoSize = true;
            this.security.Location = new System.Drawing.Point(12, 127);
            this.security.Name = "security";
            this.security.Size = new System.Drawing.Size(114, 17);
            this.security.TabIndex = 7;
            this.security.TabStop = true;
            this.security.Text = "SSD DEU Security";
            this.security.UseVisualStyleBackColor = true;
            // 
            // gruppeaendern
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 176);
            this.Controls.Add(this.security);
            this.Controls.Add(this.uc);
            this.Controls.Add(this.voice);
            this.Controls.Add(this.data);
            this.Controls.Add(this.dataSLA);
            this.Controls.Add(this.dataNetzplan);
            this.Controls.Add(this.abbrechen);
            this.Controls.Add(this.speichern);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "gruppeaendern";
            this.ShowInTaskbar = false;
            this.Text = "Gruppe ändern";
            this.Load += new System.EventHandler(this.gruppeaendern_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button speichern;
        private System.Windows.Forms.Button abbrechen;
        private System.Windows.Forms.RadioButton dataNetzplan;
        private System.Windows.Forms.RadioButton dataSLA;
        private System.Windows.Forms.RadioButton data;
        private System.Windows.Forms.RadioButton voice;
        private System.Windows.Forms.RadioButton uc;
        private System.Windows.Forms.RadioButton security;
    }
}