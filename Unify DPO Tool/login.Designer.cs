namespace Unify_DPO_Tool
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_benutzer_ein = new System.Windows.Forms.TextBox();
            this.tb_pw_ein = new System.Windows.Forms.TextBox();
            this.bt_login = new System.Windows.Forms.Button();
            this.bt_abenutzer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // tb_benutzer_ein
            // 
            resources.ApplyResources(this.tb_benutzer_ein, "tb_benutzer_ein");
            this.tb_benutzer_ein.Name = "tb_benutzer_ein";
            // 
            // tb_pw_ein
            // 
            resources.ApplyResources(this.tb_pw_ein, "tb_pw_ein");
            this.tb_pw_ein.Name = "tb_pw_ein";
            this.tb_pw_ein.UseSystemPasswordChar = true;
            this.tb_pw_ein.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_pw_ein_KeyPress);
            // 
            // bt_login
            // 
            resources.ApplyResources(this.bt_login, "bt_login");
            this.bt_login.Name = "bt_login";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // bt_abenutzer
            // 
            resources.ApplyResources(this.bt_abenutzer, "bt_abenutzer");
            this.bt_abenutzer.Name = "bt_abenutzer";
            this.bt_abenutzer.UseVisualStyleBackColor = true;
            this.bt_abenutzer.Click += new System.EventHandler(this.bt_abenutzer_Click);
            // 
            // login
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bt_abenutzer);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.tb_pw_ein);
            this.Controls.Add(this.tb_benutzer_ein);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_benutzer_ein;
        private System.Windows.Forms.TextBox tb_pw_ein;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Button bt_abenutzer;
    }
}