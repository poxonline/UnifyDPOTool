namespace Unify_DPO_Tool
{
    partial class dispo_tel_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dispo_tel_form));
            this.bt_loeschen = new System.Windows.Forms.Button();
            this.bt_speichern = new System.Windows.Forms.Button();
            this.bt_anlegen = new System.Windows.Forms.Button();
            this.tb_Beschreibung = new System.Windows.Forms.TextBox();
            this.tb_rufnummer = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.lb_beschreibung = new System.Windows.Forms.Label();
            this.lb_rufnummer = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.cb_tel_auswahl = new System.Windows.Forms.ComboBox();
            this.cb_dispo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bt_loeschen
            // 
            this.bt_loeschen.Location = new System.Drawing.Point(305, 117);
            this.bt_loeschen.Name = "bt_loeschen";
            this.bt_loeschen.Size = new System.Drawing.Size(110, 23);
            this.bt_loeschen.TabIndex = 29;
            this.bt_loeschen.Text = "Löschen";
            this.bt_loeschen.UseVisualStyleBackColor = true;
            this.bt_loeschen.Click += new System.EventHandler(this.bt_loeschen_Click);
            // 
            // bt_speichern
            // 
            this.bt_speichern.Location = new System.Drawing.Point(305, 91);
            this.bt_speichern.Name = "bt_speichern";
            this.bt_speichern.Size = new System.Drawing.Size(110, 23);
            this.bt_speichern.TabIndex = 28;
            this.bt_speichern.Text = "Speichern";
            this.bt_speichern.UseVisualStyleBackColor = true;
            this.bt_speichern.Click += new System.EventHandler(this.bt_speichern_Click);
            // 
            // bt_anlegen
            // 
            this.bt_anlegen.Location = new System.Drawing.Point(305, 66);
            this.bt_anlegen.Name = "bt_anlegen";
            this.bt_anlegen.Size = new System.Drawing.Size(110, 23);
            this.bt_anlegen.TabIndex = 27;
            this.bt_anlegen.Text = "Anlegen";
            this.bt_anlegen.UseVisualStyleBackColor = true;
            this.bt_anlegen.Click += new System.EventHandler(this.bt_anlegen_Click);
            // 
            // tb_Beschreibung
            // 
            this.tb_Beschreibung.Location = new System.Drawing.Point(104, 94);
            this.tb_Beschreibung.Name = "tb_Beschreibung";
            this.tb_Beschreibung.Size = new System.Drawing.Size(170, 20);
            this.tb_Beschreibung.TabIndex = 26;
            // 
            // tb_rufnummer
            // 
            this.tb_rufnummer.Location = new System.Drawing.Point(104, 120);
            this.tb_rufnummer.Name = "tb_rufnummer";
            this.tb_rufnummer.Size = new System.Drawing.Size(170, 20);
            this.tb_rufnummer.TabIndex = 25;
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(104, 66);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(37, 20);
            this.tb_id.TabIndex = 24;
            // 
            // lb_beschreibung
            // 
            this.lb_beschreibung.AutoSize = true;
            this.lb_beschreibung.Location = new System.Drawing.Point(12, 97);
            this.lb_beschreibung.Name = "lb_beschreibung";
            this.lb_beschreibung.Size = new System.Drawing.Size(75, 13);
            this.lb_beschreibung.TabIndex = 23;
            this.lb_beschreibung.Text = "Beschreibung:";
            // 
            // lb_rufnummer
            // 
            this.lb_rufnummer.AutoSize = true;
            this.lb_rufnummer.Location = new System.Drawing.Point(12, 123);
            this.lb_rufnummer.Name = "lb_rufnummer";
            this.lb_rufnummer.Size = new System.Drawing.Size(64, 13);
            this.lb_rufnummer.TabIndex = 22;
            this.lb_rufnummer.Text = "Rufnummer:";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(12, 69);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(21, 13);
            this.lb_id.TabIndex = 21;
            this.lb_id.Text = "ID:";
            // 
            // cb_tel_auswahl
            // 
            this.cb_tel_auswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tel_auswahl.FormattingEnabled = true;
            this.cb_tel_auswahl.Location = new System.Drawing.Point(12, 12);
            this.cb_tel_auswahl.MaxDropDownItems = 20;
            this.cb_tel_auswahl.Name = "cb_tel_auswahl";
            this.cb_tel_auswahl.Size = new System.Drawing.Size(403, 21);
            this.cb_tel_auswahl.TabIndex = 20;
            this.cb_tel_auswahl.SelectedIndexChanged += new System.EventHandler(this.cb_tel_auswahl_SelectedIndexChanged);
            // 
            // cb_dispo
            // 
            this.cb_dispo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dispo.FormattingEnabled = true;
            this.cb_dispo.Location = new System.Drawing.Point(15, 157);
            this.cb_dispo.MaxDropDownItems = 20;
            this.cb_dispo.Name = "cb_dispo";
            this.cb_dispo.Size = new System.Drawing.Size(259, 21);
            this.cb_dispo.TabIndex = 30;
            // 
            // dispo_tel_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 216);
            this.Controls.Add(this.cb_dispo);
            this.Controls.Add(this.bt_loeschen);
            this.Controls.Add(this.bt_speichern);
            this.Controls.Add(this.bt_anlegen);
            this.Controls.Add(this.tb_Beschreibung);
            this.Controls.Add(this.tb_rufnummer);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lb_beschreibung);
            this.Controls.Add(this.lb_rufnummer);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.cb_tel_auswahl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dispo_tel_form";
            this.Text = "Unify DPO - Dispo Rufnummern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_loeschen;
        private System.Windows.Forms.Button bt_speichern;
        private System.Windows.Forms.Button bt_anlegen;
        private System.Windows.Forms.TextBox tb_Beschreibung;
        private System.Windows.Forms.TextBox tb_rufnummer;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.Label lb_beschreibung;
        private System.Windows.Forms.Label lb_rufnummer;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.ComboBox cb_tel_auswahl;
        private System.Windows.Forms.ComboBox cb_dispo;
    }
}