namespace Unify_DPO_Tool
{
    partial class workgroup_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(workgroup_form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_workgauswahl = new System.Windows.Forms.ComboBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_workgroup = new System.Windows.Forms.TextBox();
            this.bt_anlegen = new System.Windows.Forms.Button();
            this.bt_speichern = new System.Windows.Forms.Button();
            this.bt_del = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID (automatisch):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Workgroup:";
            // 
            // cb_workgauswahl
            // 
            this.cb_workgauswahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_workgauswahl.FormattingEnabled = true;
            this.cb_workgauswahl.Location = new System.Drawing.Point(12, 12);
            this.cb_workgauswahl.Name = "cb_workgauswahl";
            this.cb_workgauswahl.Size = new System.Drawing.Size(225, 21);
            this.cb_workgauswahl.TabIndex = 2;
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(106, 44);
            this.tb_id.Margin = new System.Windows.Forms.Padding(0);
            this.tb_id.Name = "tb_id";
            this.tb_id.ReadOnly = true;
            this.tb_id.Size = new System.Drawing.Size(100, 20);
            this.tb_id.TabIndex = 3;
            // 
            // tb_workgroup
            // 
            this.tb_workgroup.Location = new System.Drawing.Point(106, 70);
            this.tb_workgroup.Margin = new System.Windows.Forms.Padding(0);
            this.tb_workgroup.Name = "tb_workgroup";
            this.tb_workgroup.Size = new System.Drawing.Size(100, 20);
            this.tb_workgroup.TabIndex = 4;
            // 
            // bt_anlegen
            // 
            this.bt_anlegen.Location = new System.Drawing.Point(0, 116);
            this.bt_anlegen.Name = "bt_anlegen";
            this.bt_anlegen.Size = new System.Drawing.Size(75, 23);
            this.bt_anlegen.TabIndex = 5;
            this.bt_anlegen.Text = "Anlegen";
            this.bt_anlegen.UseVisualStyleBackColor = true;
            this.bt_anlegen.Click += new System.EventHandler(this.bt_anlegen_Click);
            // 
            // bt_speichern
            // 
            this.bt_speichern.Location = new System.Drawing.Point(81, 116);
            this.bt_speichern.Name = "bt_speichern";
            this.bt_speichern.Size = new System.Drawing.Size(75, 23);
            this.bt_speichern.TabIndex = 6;
            this.bt_speichern.Text = "Speichern";
            this.bt_speichern.UseVisualStyleBackColor = true;
            this.bt_speichern.Click += new System.EventHandler(this.bt_speichern_Click);
            // 
            // bt_del
            // 
            this.bt_del.Location = new System.Drawing.Point(162, 116);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(75, 23);
            this.bt_del.TabIndex = 7;
            this.bt_del.Text = "Löschen";
            this.bt_del.UseVisualStyleBackColor = true;
            this.bt_del.Click += new System.EventHandler(this.bt_del_Click);
            // 
            // workgroup_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 142);
            this.Controls.Add(this.bt_del);
            this.Controls.Add(this.bt_speichern);
            this.Controls.Add(this.bt_anlegen);
            this.Controls.Add(this.tb_workgroup);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.cb_workgauswahl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "workgroup_form";
            this.Text = "DPO Tool Workgroups";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_workgauswahl;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_workgroup;
        private System.Windows.Forms.Button bt_anlegen;
        private System.Windows.Forms.Button bt_speichern;
        private System.Windows.Forms.Button bt_del;
    }
}