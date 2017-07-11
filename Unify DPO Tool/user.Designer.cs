namespace Unify_DPO_Tool
{
    partial class user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(user));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_windowsk = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_passwort = new System.Windows.Forms.TextBox();
            this.bt_pw_setzen = new System.Windows.Forms.Button();
            this.cb_recht = new System.Windows.Forms.ComboBox();
            this.cb_userauswahl = new System.Windows.Forms.ComboBox();
            this.bt_user_anlegen = new System.Windows.Forms.Button();
            this.bt_schliessen = new System.Windows.Forms.Button();
            this.bt_user_loeschen = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Benutzer ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Windowskennung:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Recht:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Passwort:";
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(120, 47);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(62, 20);
            this.tb_id.TabIndex = 5;
            // 
            // tb_windowsk
            // 
            this.tb_windowsk.Location = new System.Drawing.Point(120, 76);
            this.tb_windowsk.Name = "tb_windowsk";
            this.tb_windowsk.Size = new System.Drawing.Size(155, 20);
            this.tb_windowsk.TabIndex = 6;
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(120, 102);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(155, 20);
            this.tb_name.TabIndex = 7;
            // 
            // tb_passwort
            // 
            this.tb_passwort.Location = new System.Drawing.Point(120, 151);
            this.tb_passwort.Name = "tb_passwort";
            this.tb_passwort.Size = new System.Drawing.Size(155, 20);
            this.tb_passwort.TabIndex = 8;
            this.tb_passwort.UseSystemPasswordChar = true;
            // 
            // bt_pw_setzen
            // 
            this.bt_pw_setzen.Location = new System.Drawing.Point(281, 151);
            this.bt_pw_setzen.Name = "bt_pw_setzen";
            this.bt_pw_setzen.Size = new System.Drawing.Size(75, 20);
            this.bt_pw_setzen.TabIndex = 9;
            this.bt_pw_setzen.Text = "PW setzen";
            this.bt_pw_setzen.UseVisualStyleBackColor = true;
            this.bt_pw_setzen.Click += new System.EventHandler(this.bt_pw_setzen_Click);
            // 
            // cb_recht
            // 
            this.cb_recht.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_recht.FormattingEnabled = true;
            this.cb_recht.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cb_recht.Location = new System.Drawing.Point(120, 126);
            this.cb_recht.Name = "cb_recht";
            this.cb_recht.Size = new System.Drawing.Size(121, 21);
            this.cb_recht.TabIndex = 10;
            // 
            // cb_userauswahl
            // 
            this.cb_userauswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_userauswahl.FormattingEnabled = true;
            this.cb_userauswahl.Location = new System.Drawing.Point(15, 13);
            this.cb_userauswahl.MaxDropDownItems = 25;
            this.cb_userauswahl.Name = "cb_userauswahl";
            this.cb_userauswahl.Size = new System.Drawing.Size(260, 21);
            this.cb_userauswahl.TabIndex = 11;
            this.cb_userauswahl.SelectedIndexChanged += new System.EventHandler(this.cb_userauswahl_SelectedIndexChanged);
            // 
            // bt_user_anlegen
            // 
            this.bt_user_anlegen.Location = new System.Drawing.Point(84, 191);
            this.bt_user_anlegen.Name = "bt_user_anlegen";
            this.bt_user_anlegen.Size = new System.Drawing.Size(98, 23);
            this.bt_user_anlegen.TabIndex = 12;
            this.bt_user_anlegen.Text = "Benutzer anlegen";
            this.bt_user_anlegen.UseVisualStyleBackColor = true;
            this.bt_user_anlegen.Click += new System.EventHandler(this.bt_user_anlegen_Click);
            // 
            // bt_schliessen
            // 
            this.bt_schliessen.Location = new System.Drawing.Point(5, 191);
            this.bt_schliessen.Name = "bt_schliessen";
            this.bt_schliessen.Size = new System.Drawing.Size(73, 23);
            this.bt_schliessen.TabIndex = 13;
            this.bt_schliessen.Text = "Schließen";
            this.bt_schliessen.UseVisualStyleBackColor = true;
            this.bt_schliessen.Click += new System.EventHandler(this.bt_schliessen_Click);
            // 
            // bt_user_loeschen
            // 
            this.bt_user_loeschen.Location = new System.Drawing.Point(292, 191);
            this.bt_user_loeschen.Name = "bt_user_loeschen";
            this.bt_user_loeschen.Size = new System.Drawing.Size(107, 23);
            this.bt_user_loeschen.TabIndex = 14;
            this.bt_user_loeschen.Text = "Benutzer löschen";
            this.bt_user_loeschen.UseVisualStyleBackColor = true;
            this.bt_user_loeschen.Click += new System.EventHandler(this.bt_user_loeschen_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(188, 191);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(98, 23);
            this.bt_edit.TabIndex = 15;
            this.bt_edit.Text = "Benutzer ändern";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 226);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.bt_user_loeschen);
            this.Controls.Add(this.bt_schliessen);
            this.Controls.Add(this.bt_user_anlegen);
            this.Controls.Add(this.cb_userauswahl);
            this.Controls.Add(this.cb_recht);
            this.Controls.Add(this.bt_pw_setzen);
            this.Controls.Add(this.tb_passwort);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_windowsk);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "user";
            this.Text = "UnifyDPOTool - Admin User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_windowsk;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_passwort;
        private System.Windows.Forms.Button bt_pw_setzen;
        private System.Windows.Forms.ComboBox cb_recht;
        private System.Windows.Forms.ComboBox cb_userauswahl;
        private System.Windows.Forms.Button bt_user_anlegen;
        private System.Windows.Forms.Button bt_schliessen;
        private System.Windows.Forms.Button bt_user_loeschen;
        private System.Windows.Forms.Button bt_edit;
    }
}