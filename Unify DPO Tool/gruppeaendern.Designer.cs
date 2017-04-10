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
            this.cb_groupwahlfest = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // speichern
            // 
            this.speichern.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.speichern.Location = new System.Drawing.Point(12, 67);
            this.speichern.Name = "speichern";
            this.speichern.Size = new System.Drawing.Size(75, 23);
            this.speichern.TabIndex = 0;
            this.speichern.Text = "Speichern";
            this.speichern.UseVisualStyleBackColor = true;
            this.speichern.Click += new System.EventHandler(this.speichern_Click);
            // 
            // abbrechen
            // 
            this.abbrechen.Location = new System.Drawing.Point(269, 67);
            this.abbrechen.Name = "abbrechen";
            this.abbrechen.Size = new System.Drawing.Size(75, 23);
            this.abbrechen.TabIndex = 1;
            this.abbrechen.Text = "Abbrechen";
            this.abbrechen.UseVisualStyleBackColor = true;
            this.abbrechen.Click += new System.EventHandler(this.abbrechen_Click);
            // 
            // cb_groupwahlfest
            // 
            this.cb_groupwahlfest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_groupwahlfest.FormattingEnabled = true;
            this.cb_groupwahlfest.Location = new System.Drawing.Point(12, 23);
            this.cb_groupwahlfest.Name = "cb_groupwahlfest";
            this.cb_groupwahlfest.Size = new System.Drawing.Size(332, 21);
            this.cb_groupwahlfest.TabIndex = 2;
            // 
            // gruppeaendern
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 100);
            this.Controls.Add(this.cb_groupwahlfest);
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

        }

        #endregion

        private System.Windows.Forms.Button speichern;
        private System.Windows.Forms.Button abbrechen;
        private System.Windows.Forms.ComboBox cb_groupwahlfest;
    }
}