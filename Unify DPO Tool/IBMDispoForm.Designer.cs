namespace Unify_DPO_Tool
{
    partial class IBMDispoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IBMDispoForm));
            this.beenden = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.cb_dispo_extern_auswahl = new System.Windows.Forms.ComboBox();
            this.lb_ausgabe = new System.Windows.Forms.ListBox();
            this.bt_copy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // beenden
            // 
            this.beenden.Location = new System.Drawing.Point(72, 87);
            this.beenden.Name = "beenden";
            this.beenden.Size = new System.Drawing.Size(75, 23);
            this.beenden.TabIndex = 0;
            this.beenden.Text = "OK";
            this.beenden.UseVisualStyleBackColor = true;
            this.beenden.Click += new System.EventHandler(this.beenden_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IBM Dispo (GER):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "IBM Bundesbank Hotline:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(146, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(85, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "+498005116352";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(146, 35);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(85, 13);
            this.linkLabel2.TabIndex = 4;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "+493415607549";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "IBM Dispo (AUT):";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(146, 58);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(85, 13);
            this.linkLabel3.TabIndex = 6;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "+498005116353";
            this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel3_LinkClicked);
            // 
            // cb_dispo_extern_auswahl
            // 
            this.cb_dispo_extern_auswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dispo_extern_auswahl.FormattingEnabled = true;
            this.cb_dispo_extern_auswahl.Location = new System.Drawing.Point(247, 13);
            this.cb_dispo_extern_auswahl.MaxDropDownItems = 25;
            this.cb_dispo_extern_auswahl.Name = "cb_dispo_extern_auswahl";
            this.cb_dispo_extern_auswahl.Size = new System.Drawing.Size(447, 21);
            this.cb_dispo_extern_auswahl.TabIndex = 8;
            this.cb_dispo_extern_auswahl.SelectedIndexChanged += new System.EventHandler(this.cb_dispo_extern_auswahl_SelectedIndexChanged);
            // 
            // lb_ausgabe
            // 
            this.lb_ausgabe.FormattingEnabled = true;
            this.lb_ausgabe.Location = new System.Drawing.Point(247, 40);
            this.lb_ausgabe.Name = "lb_ausgabe";
            this.lb_ausgabe.Size = new System.Drawing.Size(447, 238);
            this.lb_ausgabe.TabIndex = 7;
            // 
            // bt_copy
            // 
            this.bt_copy.Location = new System.Drawing.Point(12, 139);
            this.bt_copy.Name = "bt_copy";
            this.bt_copy.Size = new System.Drawing.Size(229, 23);
            this.bt_copy.TabIndex = 9;
            this.bt_copy.Text = "markiertes (->) in Zwischenablage";
            this.bt_copy.UseVisualStyleBackColor = true;
            this.bt_copy.Click += new System.EventHandler(this.bt_copy_Click);
            // 
            // IBMDispoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 291);
            this.Controls.Add(this.bt_copy);
            this.Controls.Add(this.cb_dispo_extern_auswahl);
            this.Controls.Add(this.lb_ausgabe);
            this.Controls.Add(this.linkLabel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.beenden);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IBMDispoForm";
            this.ShowInTaskbar = false;
            this.Text = "DPO Tool - IBM Dispo Rufnummern";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button beenden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.ComboBox cb_dispo_extern_auswahl;
        private System.Windows.Forms.ListBox lb_ausgabe;
        private System.Windows.Forms.Button bt_copy;
    }
}