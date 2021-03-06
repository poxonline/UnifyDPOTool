﻿namespace Unify_DPO_Tool
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
            this.cb_dispo_extern_auswahl = new System.Windows.Forms.ComboBox();
            this.lb_ausgabe = new System.Windows.Forms.ListBox();
            this.bt_copy = new System.Windows.Forms.Button();
            this.opencircuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // beenden
            // 
            this.beenden.Location = new System.Drawing.Point(77, 255);
            this.beenden.Name = "beenden";
            this.beenden.Size = new System.Drawing.Size(75, 23);
            this.beenden.TabIndex = 0;
            this.beenden.Text = "OK";
            this.beenden.UseVisualStyleBackColor = true;
            this.beenden.Click += new System.EventHandler(this.beenden_Click);
            // 
            // cb_dispo_extern_auswahl
            // 
            this.cb_dispo_extern_auswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dispo_extern_auswahl.FormattingEnabled = true;
            this.cb_dispo_extern_auswahl.Location = new System.Drawing.Point(247, 12);
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
            this.lb_ausgabe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_ausgabe_KeyDown);
            // 
            // bt_copy
            // 
            this.bt_copy.Location = new System.Drawing.Point(12, 197);
            this.bt_copy.Name = "bt_copy";
            this.bt_copy.Size = new System.Drawing.Size(229, 23);
            this.bt_copy.TabIndex = 9;
            this.bt_copy.Text = "markiertes (->) in Zwischenablage";
            this.bt_copy.UseVisualStyleBackColor = true;
            this.bt_copy.Click += new System.EventHandler(this.bt_copy_Click);
            // 
            // opencircuit
            // 
            this.opencircuit.Location = new System.Drawing.Point(12, 226);
            this.opencircuit.Name = "opencircuit";
            this.opencircuit.Size = new System.Drawing.Size(229, 23);
            this.opencircuit.TabIndex = 10;
            this.opencircuit.Text = "markiertes (->) in Circuit (Chrome) öffnen";
            this.opencircuit.UseVisualStyleBackColor = true;
            this.opencircuit.Click += new System.EventHandler(this.opencircuit_Click);
            // 
            // IBMDispoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 291);
            this.Controls.Add(this.opencircuit);
            this.Controls.Add(this.bt_copy);
            this.Controls.Add(this.cb_dispo_extern_auswahl);
            this.Controls.Add(this.lb_ausgabe);
            this.Controls.Add(this.beenden);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IBMDispoForm";
            this.ShowInTaskbar = false;
            this.Text = "DPO Tool - IBM Dispo Rufnummern";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button beenden;
        private System.Windows.Forms.ComboBox cb_dispo_extern_auswahl;
        private System.Windows.Forms.ListBox lb_ausgabe;
        private System.Windows.Forms.Button bt_copy;
        private System.Windows.Forms.Button opencircuit;
    }
}