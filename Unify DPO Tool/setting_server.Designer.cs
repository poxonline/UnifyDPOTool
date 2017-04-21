namespace Unify_DPO_Tool
{
    partial class setting_server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setting_server));
            this.tb_server = new System.Windows.Forms.TextBox();
            this.lb_server = new System.Windows.Forms.Label();
            this.bt_test = new System.Windows.Forms.Button();
            this.bt_schliessen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_server
            // 
            this.tb_server.Location = new System.Drawing.Point(177, 10);
            this.tb_server.Name = "tb_server";
            this.tb_server.Size = new System.Drawing.Size(171, 20);
            this.tb_server.TabIndex = 0;
            // 
            // lb_server
            // 
            this.lb_server.AutoSize = true;
            this.lb_server.Location = new System.Drawing.Point(13, 13);
            this.lb_server.Name = "lb_server";
            this.lb_server.Size = new System.Drawing.Size(158, 13);
            this.lb_server.TabIndex = 1;
            this.lb_server.Text = "Hostname/IP Datenbankserver:";
            // 
            // bt_test
            // 
            this.bt_test.Location = new System.Drawing.Point(177, 36);
            this.bt_test.Name = "bt_test";
            this.bt_test.Size = new System.Drawing.Size(108, 23);
            this.bt_test.TabIndex = 2;
            this.bt_test.Text = "Verbindung testen";
            this.bt_test.UseVisualStyleBackColor = true;
            this.bt_test.Click += new System.EventHandler(this.bt_test_Click);
            // 
            // bt_schliessen
            // 
            this.bt_schliessen.Location = new System.Drawing.Point(12, 36);
            this.bt_schliessen.Name = "bt_schliessen";
            this.bt_schliessen.Size = new System.Drawing.Size(108, 23);
            this.bt_schliessen.TabIndex = 3;
            this.bt_schliessen.Text = "Schließen";
            this.bt_schliessen.UseVisualStyleBackColor = true;
            this.bt_schliessen.Click += new System.EventHandler(this.bt_schliessen_Click);
            // 
            // setting_server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 88);
            this.Controls.Add(this.bt_schliessen);
            this.Controls.Add(this.bt_test);
            this.Controls.Add(this.lb_server);
            this.Controls.Add(this.tb_server);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "setting_server";
            this.Text = "Unify DPO Tool - Einstellungen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_server;
        private System.Windows.Forms.Label lb_server;
        private System.Windows.Forms.Button bt_test;
        private System.Windows.Forms.Button bt_schliessen;
    }
}