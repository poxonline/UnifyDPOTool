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
            this.tb_sBeschreibung = new System.Windows.Forms.TextBox();
            this.tb_sname = new System.Windows.Forms.TextBox();
            this.tb_Text = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.cb_auswahl = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // tb_sBeschreibung
            // 
            this.tb_sBeschreibung.Location = new System.Drawing.Point(76, 121);
            this.tb_sBeschreibung.Name = "tb_sBeschreibung";
            this.tb_sBeschreibung.Size = new System.Drawing.Size(205, 20);
            this.tb_sBeschreibung.TabIndex = 0;
            // 
            // tb_sname
            // 
            this.tb_sname.Location = new System.Drawing.Point(76, 95);
            this.tb_sname.Name = "tb_sname";
            this.tb_sname.Size = new System.Drawing.Size(369, 20);
            this.tb_sname.TabIndex = 1;
            // 
            // tb_Text
            // 
            this.tb_Text.Location = new System.Drawing.Point(76, 69);
            this.tb_Text.Name = "tb_Text";
            this.tb_Text.Size = new System.Drawing.Size(369, 20);
            this.tb_Text.TabIndex = 2;
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(76, 43);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(35, 20);
            this.tb_id.TabIndex = 3;
            // 
            // cb_auswahl
            // 
            this.cb_auswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_auswahl.FormattingEnabled = true;
            this.cb_auswahl.Location = new System.Drawing.Point(76, 16);
            this.cb_auswahl.Name = "cb_auswahl";
            this.cb_auswahl.Size = new System.Drawing.Size(369, 21);
            this.cb_auswahl.TabIndex = 4;
            // 
            // vorDefTexte_aendern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 200);
            this.Controls.Add(this.cb_auswahl);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_Text);
            this.Controls.Add(this.tb_sname);
            this.Controls.Add(this.tb_sBeschreibung);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "vorDefTexte_aendern";
            this.Text = "Vordefinierte Texte ändern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_sBeschreibung;
        private System.Windows.Forms.TextBox tb_sname;
        private System.Windows.Forms.TextBox tb_Text;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.ComboBox cb_auswahl;

    }
}