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
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_auswahl = new System.Windows.Forms.Label();
            this.lb_text = new System.Windows.Forms.Label();
            this.lb_Sachnummer = new System.Windows.Forms.Label();
            this.lb_sBeschreibung = new System.Windows.Forms.Label();
            this.cb_workgroup = new System.Windows.Forms.ComboBox();
            this.lb_workgroup = new System.Windows.Forms.Label();
            this.tb_hinweis = new System.Windows.Forms.TextBox();
            this.bt_anlegen = new System.Windows.Forms.Button();
            this.bt_speichern = new System.Windows.Forms.Button();
            this.bt_loeschen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_sBeschreibung
            // 
            this.tb_sBeschreibung.Location = new System.Drawing.Point(120, 121);
            this.tb_sBeschreibung.Name = "tb_sBeschreibung";
            this.tb_sBeschreibung.Size = new System.Drawing.Size(205, 20);
            this.tb_sBeschreibung.TabIndex = 0;
            // 
            // tb_sname
            // 
            this.tb_sname.Location = new System.Drawing.Point(120, 95);
            this.tb_sname.Name = "tb_sname";
            this.tb_sname.Size = new System.Drawing.Size(205, 20);
            this.tb_sname.TabIndex = 1;
            // 
            // tb_Text
            // 
            this.tb_Text.Location = new System.Drawing.Point(120, 69);
            this.tb_Text.Name = "tb_Text";
            this.tb_Text.Size = new System.Drawing.Size(396, 20);
            this.tb_Text.TabIndex = 2;
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(120, 46);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(35, 20);
            this.tb_id.TabIndex = 3;
            // 
            // cb_auswahl
            // 
            this.cb_auswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_auswahl.FormattingEnabled = true;
            this.cb_auswahl.Location = new System.Drawing.Point(120, 16);
            this.cb_auswahl.Name = "cb_auswahl";
            this.cb_auswahl.Size = new System.Drawing.Size(325, 21);
            this.cb_auswahl.TabIndex = 4;
            this.cb_auswahl.SelectedIndexChanged += new System.EventHandler(this.cb_auswahl_SelectedIndexChanged);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(12, 46);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(21, 13);
            this.lb_id.TabIndex = 5;
            this.lb_id.Text = "ID:";
            // 
            // lb_auswahl
            // 
            this.lb_auswahl.AutoSize = true;
            this.lb_auswahl.Location = new System.Drawing.Point(12, 19);
            this.lb_auswahl.Name = "lb_auswahl";
            this.lb_auswahl.Size = new System.Drawing.Size(102, 13);
            this.lb_auswahl.TabIndex = 6;
            this.lb_auswahl.Text = "Bereits vorhandene:";
            // 
            // lb_text
            // 
            this.lb_text.AutoSize = true;
            this.lb_text.Location = new System.Drawing.Point(12, 72);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(31, 13);
            this.lb_text.TabIndex = 7;
            this.lb_text.Text = "Text:";
            // 
            // lb_Sachnummer
            // 
            this.lb_Sachnummer.AutoSize = true;
            this.lb_Sachnummer.Location = new System.Drawing.Point(12, 98);
            this.lb_Sachnummer.Name = "lb_Sachnummer";
            this.lb_Sachnummer.Size = new System.Drawing.Size(72, 13);
            this.lb_Sachnummer.TabIndex = 8;
            this.lb_Sachnummer.Text = "Sachnummer:";
            // 
            // lb_sBeschreibung
            // 
            this.lb_sBeschreibung.AutoSize = true;
            this.lb_sBeschreibung.Location = new System.Drawing.Point(12, 124);
            this.lb_sBeschreibung.Name = "lb_sBeschreibung";
            this.lb_sBeschreibung.Size = new System.Drawing.Size(75, 13);
            this.lb_sBeschreibung.TabIndex = 9;
            this.lb_sBeschreibung.Text = "Beschreibung:";
            // 
            // cb_workgroup
            // 
            this.cb_workgroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_workgroup.FormattingEnabled = true;
            this.cb_workgroup.Location = new System.Drawing.Point(120, 147);
            this.cb_workgroup.Name = "cb_workgroup";
            this.cb_workgroup.Size = new System.Drawing.Size(205, 21);
            this.cb_workgroup.TabIndex = 10;
            // 
            // lb_workgroup
            // 
            this.lb_workgroup.AutoSize = true;
            this.lb_workgroup.Location = new System.Drawing.Point(12, 150);
            this.lb_workgroup.Name = "lb_workgroup";
            this.lb_workgroup.Size = new System.Drawing.Size(63, 13);
            this.lb_workgroup.TabIndex = 11;
            this.lb_workgroup.Text = "Workgroup:";
            // 
            // tb_hinweis
            // 
            this.tb_hinweis.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_hinweis.Location = new System.Drawing.Point(12, 174);
            this.tb_hinweis.Multiline = true;
            this.tb_hinweis.Name = "tb_hinweis";
            this.tb_hinweis.ReadOnly = true;
            this.tb_hinweis.Size = new System.Drawing.Size(498, 64);
            this.tb_hinweis.TabIndex = 12;
            this.tb_hinweis.Text = "Hinweise:\r\n- Workgroupp ALL ist immer sichtbar\r\n- Andere Workgroups sind nur bei " +
    "aktiver Auswahl sichtbar\r\n- Beim neu anlegen werden die IDs automatisch erzeugt";
            // 
            // bt_anlegen
            // 
            this.bt_anlegen.Location = new System.Drawing.Point(379, 92);
            this.bt_anlegen.Name = "bt_anlegen";
            this.bt_anlegen.Size = new System.Drawing.Size(131, 23);
            this.bt_anlegen.TabIndex = 13;
            this.bt_anlegen.Text = "Anlegen";
            this.bt_anlegen.UseVisualStyleBackColor = true;
            this.bt_anlegen.Click += new System.EventHandler(this.bt_anlegen_Click);
            // 
            // bt_speichern
            // 
            this.bt_speichern.Location = new System.Drawing.Point(379, 121);
            this.bt_speichern.Name = "bt_speichern";
            this.bt_speichern.Size = new System.Drawing.Size(131, 23);
            this.bt_speichern.TabIndex = 14;
            this.bt_speichern.Text = "Bearbeitung speichern";
            this.bt_speichern.UseVisualStyleBackColor = true;
            this.bt_speichern.Click += new System.EventHandler(this.bt_speichern_Click);
            // 
            // bt_loeschen
            // 
            this.bt_loeschen.Location = new System.Drawing.Point(379, 150);
            this.bt_loeschen.Name = "bt_loeschen";
            this.bt_loeschen.Size = new System.Drawing.Size(131, 23);
            this.bt_loeschen.TabIndex = 15;
            this.bt_loeschen.Text = "Löschen";
            this.bt_loeschen.UseVisualStyleBackColor = true;
            this.bt_loeschen.Click += new System.EventHandler(this.bt_loeschen_Click);
            // 
            // vorDefTexte_aendern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 247);
            this.Controls.Add(this.bt_loeschen);
            this.Controls.Add(this.bt_speichern);
            this.Controls.Add(this.bt_anlegen);
            this.Controls.Add(this.tb_hinweis);
            this.Controls.Add(this.lb_workgroup);
            this.Controls.Add(this.cb_workgroup);
            this.Controls.Add(this.lb_sBeschreibung);
            this.Controls.Add(this.lb_Sachnummer);
            this.Controls.Add(this.lb_text);
            this.Controls.Add(this.lb_auswahl);
            this.Controls.Add(this.lb_id);
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
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_auswahl;
        private System.Windows.Forms.Label lb_text;
        private System.Windows.Forms.Label lb_Sachnummer;
        private System.Windows.Forms.Label lb_sBeschreibung;
        private System.Windows.Forms.ComboBox cb_workgroup;
        private System.Windows.Forms.Label lb_workgroup;
        private System.Windows.Forms.TextBox tb_hinweis;
        private System.Windows.Forms.Button bt_anlegen;
        private System.Windows.Forms.Button bt_speichern;
        private System.Windows.Forms.Button bt_loeschen;

    }
}