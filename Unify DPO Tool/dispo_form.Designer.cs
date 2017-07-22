namespace Unify_DPO_Tool
{
    partial class dispo_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dispo_form));
            this.cb_dispo_auswahl = new System.Windows.Forms.ComboBox();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_beschreibung = new System.Windows.Forms.Label();
            this.cb_FRU = new System.Windows.Forms.CheckBox();
            this.cb_email_normal = new System.Windows.Forms.CheckBox();
            this.cb_email_eskalation = new System.Windows.Forms.CheckBox();
            this.cb_partner = new System.Windows.Forms.CheckBox();
            this.lb_dispomail = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_Beschreibung = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.bt_anlegen = new System.Windows.Forms.Button();
            this.bt_speichern = new System.Windows.Forms.Button();
            this.bt_loeschen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_dispo_auswahl
            // 
            this.cb_dispo_auswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dispo_auswahl.FormattingEnabled = true;
            this.cb_dispo_auswahl.Location = new System.Drawing.Point(12, 12);
            this.cb_dispo_auswahl.MaxDropDownItems = 20;
            this.cb_dispo_auswahl.Name = "cb_dispo_auswahl";
            this.cb_dispo_auswahl.Size = new System.Drawing.Size(403, 21);
            this.cb_dispo_auswahl.TabIndex = 0;
            this.cb_dispo_auswahl.SelectedIndexChanged += new System.EventHandler(this.cb_dispo_auswahl_SelectedIndexChanged);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(12, 69);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(21, 13);
            this.lb_id.TabIndex = 1;
            this.lb_id.Text = "ID:";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(12, 96);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(38, 13);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "Name:";
            // 
            // lb_beschreibung
            // 
            this.lb_beschreibung.AutoSize = true;
            this.lb_beschreibung.Location = new System.Drawing.Point(12, 122);
            this.lb_beschreibung.Name = "lb_beschreibung";
            this.lb_beschreibung.Size = new System.Drawing.Size(75, 13);
            this.lb_beschreibung.TabIndex = 3;
            this.lb_beschreibung.Text = "Beschreibung:";
            // 
            // cb_FRU
            // 
            this.cb_FRU.AutoSize = true;
            this.cb_FRU.Location = new System.Drawing.Point(12, 173);
            this.cb_FRU.Name = "cb_FRU";
            this.cb_FRU.Size = new System.Drawing.Size(151, 17);
            this.cb_FRU.TabIndex = 8;
            this.cb_FRU.Text = "Werden DE FRU genutzt?";
            this.cb_FRU.UseVisualStyleBackColor = true;
            // 
            // cb_email_normal
            // 
            this.cb_email_normal.AutoSize = true;
            this.cb_email_normal.Location = new System.Drawing.Point(12, 196);
            this.cb_email_normal.Name = "cb_email_normal";
            this.cb_email_normal.Size = new System.Drawing.Size(193, 17);
            this.cb_email_normal.TabIndex = 9;
            this.cb_email_normal.Text = "Bei normaler Anfrage ASP(s) in CC?";
            this.cb_email_normal.UseVisualStyleBackColor = true;
            // 
            // cb_email_eskalation
            // 
            this.cb_email_eskalation.AutoSize = true;
            this.cb_email_eskalation.Location = new System.Drawing.Point(12, 219);
            this.cb_email_eskalation.Name = "cb_email_eskalation";
            this.cb_email_eskalation.Size = new System.Drawing.Size(162, 17);
            this.cb_email_eskalation.TabIndex = 10;
            this.cb_email_eskalation.Text = "Bei Eskalation ASP(s) in CC?";
            this.cb_email_eskalation.UseVisualStyleBackColor = true;
            // 
            // cb_partner
            // 
            this.cb_partner.AutoSize = true;
            this.cb_partner.Location = new System.Drawing.Point(12, 243);
            this.cb_partner.Name = "cb_partner";
            this.cb_partner.Size = new System.Drawing.Size(96, 17);
            this.cb_partner.TabIndex = 11;
            this.cb_partner.Text = "Partner Dispo?";
            this.cb_partner.UseVisualStyleBackColor = true;
            // 
            // lb_dispomail
            // 
            this.lb_dispomail.AutoSize = true;
            this.lb_dispomail.Location = new System.Drawing.Point(12, 146);
            this.lb_dispomail.Name = "lb_dispomail";
            this.lb_dispomail.Size = new System.Drawing.Size(39, 13);
            this.lb_dispomail.TabIndex = 12;
            this.lb_dispomail.Text = "E-Mail:";
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(104, 66);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(37, 20);
            this.tb_id.TabIndex = 13;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(104, 93);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(170, 20);
            this.tb_name.TabIndex = 14;
            // 
            // tb_Beschreibung
            // 
            this.tb_Beschreibung.Location = new System.Drawing.Point(104, 119);
            this.tb_Beschreibung.Name = "tb_Beschreibung";
            this.tb_Beschreibung.Size = new System.Drawing.Size(170, 20);
            this.tb_Beschreibung.TabIndex = 15;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(104, 145);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(170, 20);
            this.tb_email.TabIndex = 16;
            // 
            // bt_anlegen
            // 
            this.bt_anlegen.Location = new System.Drawing.Point(305, 91);
            this.bt_anlegen.Name = "bt_anlegen";
            this.bt_anlegen.Size = new System.Drawing.Size(110, 23);
            this.bt_anlegen.TabIndex = 17;
            this.bt_anlegen.Text = "Anlegen";
            this.bt_anlegen.UseVisualStyleBackColor = true;
            this.bt_anlegen.Click += new System.EventHandler(this.bt_anlegen_Click);
            // 
            // bt_speichern
            // 
            this.bt_speichern.Location = new System.Drawing.Point(305, 119);
            this.bt_speichern.Name = "bt_speichern";
            this.bt_speichern.Size = new System.Drawing.Size(110, 23);
            this.bt_speichern.TabIndex = 18;
            this.bt_speichern.Text = "Speichern";
            this.bt_speichern.UseVisualStyleBackColor = true;
            this.bt_speichern.Click += new System.EventHandler(this.bt_speichern_Click);
            // 
            // bt_loeschen
            // 
            this.bt_loeschen.Location = new System.Drawing.Point(305, 146);
            this.bt_loeschen.Name = "bt_loeschen";
            this.bt_loeschen.Size = new System.Drawing.Size(110, 23);
            this.bt_loeschen.TabIndex = 19;
            this.bt_loeschen.Text = "Löschen";
            this.bt_loeschen.UseVisualStyleBackColor = true;
            this.bt_loeschen.Click += new System.EventHandler(this.bt_loeschen_Click);
            // 
            // dispo_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 282);
            this.Controls.Add(this.bt_loeschen);
            this.Controls.Add(this.bt_speichern);
            this.Controls.Add(this.bt_anlegen);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_Beschreibung);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lb_dispomail);
            this.Controls.Add(this.cb_partner);
            this.Controls.Add(this.cb_email_eskalation);
            this.Controls.Add(this.cb_email_normal);
            this.Controls.Add(this.cb_FRU);
            this.Controls.Add(this.lb_beschreibung);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.cb_dispo_auswahl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(443, 321);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(443, 321);
            this.Name = "dispo_form";
            this.Text = "DPO Tool - Dispos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_dispomail;
        private System.Windows.Forms.CheckBox cb_partner;
        private System.Windows.Forms.CheckBox cb_email_eskalation;
        private System.Windows.Forms.CheckBox cb_email_normal;
        private System.Windows.Forms.CheckBox cb_FRU;
        private System.Windows.Forms.Label lb_beschreibung;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.ComboBox cb_dispo_auswahl;
        private System.Windows.Forms.Button bt_loeschen;
        private System.Windows.Forms.Button bt_speichern;
        private System.Windows.Forms.Button bt_anlegen;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_Beschreibung;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_id;
    }
}