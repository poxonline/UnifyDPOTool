namespace Unify_DPO_Tool
{
    partial class dispo_asp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dispo_asp));
            this.clb_dispos = new System.Windows.Forms.CheckedListBox();
            this.tb_asp_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_asp_mail = new System.Windows.Forms.TextBox();
            this.tb_asp_tel = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cb_list_asp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_asp_id = new System.Windows.Forms.TextBox();
            this.bt_asp_hinzu = new System.Windows.Forms.Button();
            this.bt_speichern = new System.Windows.Forms.Button();
            this.bt_loeschen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clb_dispos
            // 
            this.clb_dispos.CheckOnClick = true;
            this.clb_dispos.FormattingEnabled = true;
            this.clb_dispos.Location = new System.Drawing.Point(12, 159);
            this.clb_dispos.Name = "clb_dispos";
            this.clb_dispos.Size = new System.Drawing.Size(248, 184);
            this.clb_dispos.TabIndex = 0;
            // 
            // tb_asp_name
            // 
            this.tb_asp_name.Location = new System.Drawing.Point(124, 69);
            this.tb_asp_name.Name = "tb_asp_name";
            this.tb_asp_name.Size = new System.Drawing.Size(136, 20);
            this.tb_asp_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rufnummer:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "E-Mailadresse:";
            // 
            // tb_asp_mail
            // 
            this.tb_asp_mail.Location = new System.Drawing.Point(124, 100);
            this.tb_asp_mail.Name = "tb_asp_mail";
            this.tb_asp_mail.Size = new System.Drawing.Size(136, 20);
            this.tb_asp_mail.TabIndex = 5;
            // 
            // tb_asp_tel
            // 
            this.tb_asp_tel.Location = new System.Drawing.Point(124, 127);
            this.tb_asp_tel.Name = "tb_asp_tel";
            this.tb_asp_tel.Size = new System.Drawing.Size(136, 20);
            this.tb_asp_tel.TabIndex = 6;
            // 
            // cb_list_asp
            // 
            this.cb_list_asp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_list_asp.FormattingEnabled = true;
            this.cb_list_asp.Location = new System.Drawing.Point(124, 12);
            this.cb_list_asp.MaxDropDownItems = 25;
            this.cb_list_asp.Name = "cb_list_asp";
            this.cb_list_asp.Size = new System.Drawing.Size(245, 21);
            this.cb_list_asp.TabIndex = 7;
            this.cb_list_asp.SelectedIndexChanged += new System.EventHandler(this.cb_list_asp_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ansprechpartner:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID:";
            // 
            // tb_asp_id
            // 
            this.tb_asp_id.Enabled = false;
            this.tb_asp_id.Location = new System.Drawing.Point(124, 39);
            this.tb_asp_id.Name = "tb_asp_id";
            this.tb_asp_id.ReadOnly = true;
            this.tb_asp_id.Size = new System.Drawing.Size(136, 20);
            this.tb_asp_id.TabIndex = 10;
            // 
            // bt_asp_hinzu
            // 
            this.bt_asp_hinzu.Location = new System.Drawing.Point(415, 46);
            this.bt_asp_hinzu.Name = "bt_asp_hinzu";
            this.bt_asp_hinzu.Size = new System.Drawing.Size(139, 23);
            this.bt_asp_hinzu.TabIndex = 11;
            this.bt_asp_hinzu.Text = "Hinzufügen";
            this.bt_asp_hinzu.UseVisualStyleBackColor = true;
            this.bt_asp_hinzu.Visible = false;
            // 
            // bt_speichern
            // 
            this.bt_speichern.Location = new System.Drawing.Point(415, 75);
            this.bt_speichern.Name = "bt_speichern";
            this.bt_speichern.Size = new System.Drawing.Size(139, 23);
            this.bt_speichern.TabIndex = 12;
            this.bt_speichern.Text = "Bearbeitung speichern";
            this.bt_speichern.UseVisualStyleBackColor = true;
            this.bt_speichern.Visible = false;
            // 
            // bt_loeschen
            // 
            this.bt_loeschen.Location = new System.Drawing.Point(415, 104);
            this.bt_loeschen.Name = "bt_loeschen";
            this.bt_loeschen.Size = new System.Drawing.Size(139, 23);
            this.bt_loeschen.TabIndex = 13;
            this.bt_loeschen.Text = "Löschen";
            this.bt_loeschen.UseVisualStyleBackColor = true;
            this.bt_loeschen.Visible = false;
            // 
            // dispo_asp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 355);
            this.Controls.Add(this.bt_loeschen);
            this.Controls.Add(this.bt_speichern);
            this.Controls.Add(this.bt_asp_hinzu);
            this.Controls.Add(this.tb_asp_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_list_asp);
            this.Controls.Add(this.tb_asp_tel);
            this.Controls.Add(this.tb_asp_mail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_asp_name);
            this.Controls.Add(this.clb_dispos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dispo_asp";
            this.Text = "Unify DPO - Dispo Ansprechpartner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_dispos;
        private System.Windows.Forms.TextBox tb_asp_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_asp_mail;
        private System.Windows.Forms.TextBox tb_asp_tel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cb_list_asp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_asp_id;
        private System.Windows.Forms.Button bt_asp_hinzu;
        private System.Windows.Forms.Button bt_speichern;
        private System.Windows.Forms.Button bt_loeschen;
    }
}