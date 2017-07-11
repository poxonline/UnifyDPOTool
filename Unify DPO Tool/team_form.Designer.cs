namespace Unify_DPO_Tool
{
    partial class team_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(team_form));
            this.cb_teamauswahl = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_anzeige_name = new System.Windows.Forms.TextBox();
            this.tb_hotliner = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_modmail = new System.Windows.Forms.TextBox();
            this.tb_zusatztext = new System.Windows.Forms.TextBox();
            this.tb_lastedit = new System.Windows.Forms.TextBox();
            this.cb_workgroupauswahl = new System.Windows.Forms.ComboBox();
            this.lb_autohinweis = new System.Windows.Forms.Label();
            this.bt_anlegen = new System.Windows.Forms.Button();
            this.bt_speichern = new System.Windows.Forms.Button();
            this.bt_loeschen = new System.Windows.Forms.Button();
            this.lb_info = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_teamauswahl
            // 
            this.cb_teamauswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_teamauswahl.FormattingEnabled = true;
            this.cb_teamauswahl.Location = new System.Drawing.Point(12, 12);
            this.cb_teamauswahl.MaxDropDownItems = 25;
            this.cb_teamauswahl.Name = "cb_teamauswahl";
            this.cb_teamauswahl.Size = new System.Drawing.Size(271, 21);
            this.cb_teamauswahl.TabIndex = 0;
            this.cb_teamauswahl.SelectedIndexChanged += new System.EventHandler(this.cb_teamauswahl_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Team ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "(Anzeige-)Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Workgroup:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hotline Rufnummer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "E-Mail:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "MoD E-Mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Zusatztext:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Last Edit:";
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(147, 49);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(136, 20);
            this.tb_id.TabIndex = 9;
            // 
            // tb_anzeige_name
            // 
            this.tb_anzeige_name.Location = new System.Drawing.Point(147, 79);
            this.tb_anzeige_name.Name = "tb_anzeige_name";
            this.tb_anzeige_name.Size = new System.Drawing.Size(136, 20);
            this.tb_anzeige_name.TabIndex = 10;
            // 
            // tb_hotliner
            // 
            this.tb_hotliner.Location = new System.Drawing.Point(147, 135);
            this.tb_hotliner.Name = "tb_hotliner";
            this.tb_hotliner.Size = new System.Drawing.Size(136, 20);
            this.tb_hotliner.TabIndex = 11;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(147, 162);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(136, 20);
            this.tb_email.TabIndex = 12;
            // 
            // tb_modmail
            // 
            this.tb_modmail.Location = new System.Drawing.Point(147, 187);
            this.tb_modmail.Name = "tb_modmail";
            this.tb_modmail.Size = new System.Drawing.Size(136, 20);
            this.tb_modmail.TabIndex = 13;
            // 
            // tb_zusatztext
            // 
            this.tb_zusatztext.Location = new System.Drawing.Point(147, 215);
            this.tb_zusatztext.Name = "tb_zusatztext";
            this.tb_zusatztext.Size = new System.Drawing.Size(136, 20);
            this.tb_zusatztext.TabIndex = 14;
            // 
            // tb_lastedit
            // 
            this.tb_lastedit.Enabled = false;
            this.tb_lastedit.Location = new System.Drawing.Point(147, 241);
            this.tb_lastedit.Name = "tb_lastedit";
            this.tb_lastedit.ReadOnly = true;
            this.tb_lastedit.Size = new System.Drawing.Size(136, 20);
            this.tb_lastedit.TabIndex = 15;
            // 
            // cb_workgroupauswahl
            // 
            this.cb_workgroupauswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_workgroupauswahl.FormattingEnabled = true;
            this.cb_workgroupauswahl.Location = new System.Drawing.Point(147, 106);
            this.cb_workgroupauswahl.Name = "cb_workgroupauswahl";
            this.cb_workgroupauswahl.Size = new System.Drawing.Size(136, 21);
            this.cb_workgroupauswahl.TabIndex = 16;
            // 
            // lb_autohinweis
            // 
            this.lb_autohinweis.AutoSize = true;
            this.lb_autohinweis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.23F);
            this.lb_autohinweis.Location = new System.Drawing.Point(69, 52);
            this.lb_autohinweis.Name = "lb_autohinweis";
            this.lb_autohinweis.Size = new System.Drawing.Size(70, 13);
            this.lb_autohinweis.TabIndex = 17;
            this.lb_autohinweis.Text = "(automatisch)";
            // 
            // bt_anlegen
            // 
            this.bt_anlegen.Location = new System.Drawing.Point(12, 294);
            this.bt_anlegen.Name = "bt_anlegen";
            this.bt_anlegen.Size = new System.Drawing.Size(75, 23);
            this.bt_anlegen.TabIndex = 18;
            this.bt_anlegen.Text = "Anlegen";
            this.bt_anlegen.UseVisualStyleBackColor = true;
            this.bt_anlegen.Click += new System.EventHandler(this.bt_anlegen_Click);
            // 
            // bt_speichern
            // 
            this.bt_speichern.Location = new System.Drawing.Point(106, 294);
            this.bt_speichern.Name = "bt_speichern";
            this.bt_speichern.Size = new System.Drawing.Size(75, 23);
            this.bt_speichern.TabIndex = 19;
            this.bt_speichern.Text = "Speichern";
            this.bt_speichern.UseVisualStyleBackColor = true;
            this.bt_speichern.Click += new System.EventHandler(this.bt_speichern_Click);
            // 
            // bt_loeschen
            // 
            this.bt_loeschen.Location = new System.Drawing.Point(208, 294);
            this.bt_loeschen.Name = "bt_loeschen";
            this.bt_loeschen.Size = new System.Drawing.Size(75, 23);
            this.bt_loeschen.TabIndex = 20;
            this.bt_loeschen.Text = "Löschen";
            this.bt_loeschen.UseVisualStyleBackColor = true;
            this.bt_loeschen.Click += new System.EventHandler(this.bt_loeschen_Click);
            // 
            // lb_info
            // 
            this.lb_info.AutoSize = true;
            this.lb_info.Location = new System.Drawing.Point(12, 269);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(265, 13);
            this.lb_info.TabIndex = 21;
            this.lb_info.Text = "Info: Es werden im Client maximal 20 Teams angezeigt!";
            // 
            // team_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 329);
            this.Controls.Add(this.lb_info);
            this.Controls.Add(this.bt_loeschen);
            this.Controls.Add(this.bt_speichern);
            this.Controls.Add(this.bt_anlegen);
            this.Controls.Add(this.lb_autohinweis);
            this.Controls.Add(this.cb_workgroupauswahl);
            this.Controls.Add(this.tb_lastedit);
            this.Controls.Add(this.tb_zusatztext);
            this.Controls.Add(this.tb_modmail);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_hotliner);
            this.Controls.Add(this.tb_anzeige_name);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_teamauswahl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "team_form";
            this.Text = "Unify DPO Tool - Teams";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_teamauswahl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_anzeige_name;
        private System.Windows.Forms.TextBox tb_hotliner;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_modmail;
        private System.Windows.Forms.TextBox tb_zusatztext;
        private System.Windows.Forms.TextBox tb_lastedit;
        private System.Windows.Forms.ComboBox cb_workgroupauswahl;
        private System.Windows.Forms.Label lb_autohinweis;
        private System.Windows.Forms.Button bt_anlegen;
        private System.Windows.Forms.Button bt_speichern;
        private System.Windows.Forms.Button bt_loeschen;
        private System.Windows.Forms.Label lb_info;
    }
}