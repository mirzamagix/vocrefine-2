namespace Vocrefine_2
{
    partial class AddVocs
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_addVocs = new System.Windows.Forms.Panel();
            this.btn_AddVocs_Add = new System.Windows.Forms.Button();
            this.lb_AddNew_Warnung = new System.Windows.Forms.Label();
            this.lb_AddVocs_Switch = new System.Windows.Forms.Label();
            this.lb_AddVocs_FS = new System.Windows.Forms.Label();
            this.lb_AddVocs_ES = new System.Windows.Forms.Label();
            this.tb_AddVocs_FS = new System.Windows.Forms.TextBox();
            this.tb_AddVocs_ES = new System.Windows.Forms.TextBox();
            this.lb_AddVocs = new System.Windows.Forms.Label();
            this.pnl_addVocs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_addVocs
            // 
            this.pnl_addVocs.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnl_addVocs.Controls.Add(this.btn_AddVocs_Add);
            this.pnl_addVocs.Controls.Add(this.lb_AddNew_Warnung);
            this.pnl_addVocs.Controls.Add(this.lb_AddVocs_Switch);
            this.pnl_addVocs.Controls.Add(this.lb_AddVocs_FS);
            this.pnl_addVocs.Controls.Add(this.lb_AddVocs_ES);
            this.pnl_addVocs.Controls.Add(this.tb_AddVocs_FS);
            this.pnl_addVocs.Controls.Add(this.tb_AddVocs_ES);
            this.pnl_addVocs.Controls.Add(this.lb_AddVocs);
            this.pnl_addVocs.Location = new System.Drawing.Point(3, 3);
            this.pnl_addVocs.Name = "pnl_addVocs";
            this.pnl_addVocs.Size = new System.Drawing.Size(1272, 234);
            this.pnl_addVocs.TabIndex = 15;
            // 
            // btn_AddVocs_Add
            // 
            this.btn_AddVocs_Add.BackColor = System.Drawing.Color.DarkGray;
            this.btn_AddVocs_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddVocs_Add.Enabled = false;
            this.btn_AddVocs_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddVocs_Add.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold);
            this.btn_AddVocs_Add.ForeColor = System.Drawing.Color.Black;
            this.btn_AddVocs_Add.Location = new System.Drawing.Point(907, 173);
            this.btn_AddVocs_Add.Name = "btn_AddVocs_Add";
            this.btn_AddVocs_Add.Size = new System.Drawing.Size(305, 37);
            this.btn_AddVocs_Add.TabIndex = 15;
            this.btn_AddVocs_Add.Text = "VOKABEL HINZUFÜGEN";
            this.btn_AddVocs_Add.UseVisualStyleBackColor = false;
            this.btn_AddVocs_Add.Click += new System.EventHandler(this.btn_AddVocs_Add_Click);
            // 
            // lb_AddNew_Warnung
            // 
            this.lb_AddNew_Warnung.AutoSize = true;
            this.lb_AddNew_Warnung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_AddNew_Warnung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AddNew_Warnung.Location = new System.Drawing.Point(28, 53);
            this.lb_AddNew_Warnung.Name = "lb_AddNew_Warnung";
            this.lb_AddNew_Warnung.Size = new System.Drawing.Size(438, 15);
            this.lb_AddNew_Warnung.TabIndex = 14;
            this.lb_AddNew_Warnung.Text = "Bemerkungen oder Komentare in eckigen Klammern hinter die Vokabel schreiben.";
            // 
            // lb_AddVocs_Switch
            // 
            this.lb_AddVocs_Switch.AutoSize = true;
            this.lb_AddVocs_Switch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_AddVocs_Switch.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AddVocs_Switch.Location = new System.Drawing.Point(604, 142);
            this.lb_AddVocs_Switch.Name = "lb_AddVocs_Switch";
            this.lb_AddVocs_Switch.Size = new System.Drawing.Size(35, 22);
            this.lb_AddVocs_Switch.TabIndex = 14;
            this.lb_AddVocs_Switch.Text = "< >";
            this.lb_AddVocs_Switch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_AddVocs_Switch.Click += new System.EventHandler(this.lb_AddVocs_Switch_Click);
            // 
            // lb_AddVocs_FS
            // 
            this.lb_AddVocs_FS.AutoSize = true;
            this.lb_AddVocs_FS.Font = new System.Drawing.Font("Eras Demi ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AddVocs_FS.Location = new System.Drawing.Point(658, 113);
            this.lb_AddVocs_FS.Name = "lb_AddVocs_FS";
            this.lb_AddVocs_FS.Size = new System.Drawing.Size(143, 23);
            this.lb_AddVocs_FS.TabIndex = 13;
            this.lb_AddVocs_FS.Text = "Fremdsprache:";
            // 
            // lb_AddVocs_ES
            // 
            this.lb_AddVocs_ES.AutoSize = true;
            this.lb_AddVocs_ES.Font = new System.Drawing.Font("Eras Demi ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AddVocs_ES.Location = new System.Drawing.Point(34, 113);
            this.lb_AddVocs_ES.Name = "lb_AddVocs_ES";
            this.lb_AddVocs_ES.Size = new System.Drawing.Size(155, 23);
            this.lb_AddVocs_ES.TabIndex = 12;
            this.lb_AddVocs_ES.Text = "Eigene Sprache:";
            // 
            // tb_AddVocs_FS
            // 
            this.tb_AddVocs_FS.BackColor = System.Drawing.Color.White;
            this.tb_AddVocs_FS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_AddVocs_FS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AddVocs_FS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_AddVocs_FS.Location = new System.Drawing.Point(652, 138);
            this.tb_AddVocs_FS.MaxLength = 60;
            this.tb_AddVocs_FS.Name = "tb_AddVocs_FS";
            this.tb_AddVocs_FS.Size = new System.Drawing.Size(560, 29);
            this.tb_AddVocs_FS.TabIndex = 11;
            this.tb_AddVocs_FS.TextChanged += new System.EventHandler(this.act_IsFilled);
            this.tb_AddVocs_FS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_AddVocs_FS_KeyDown);
            // 
            // tb_AddVocs_ES
            // 
            this.tb_AddVocs_ES.BackColor = System.Drawing.Color.White;
            this.tb_AddVocs_ES.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_AddVocs_ES.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AddVocs_ES.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_AddVocs_ES.Location = new System.Drawing.Point(28, 138);
            this.tb_AddVocs_ES.MaxLength = 60;
            this.tb_AddVocs_ES.Name = "tb_AddVocs_ES";
            this.tb_AddVocs_ES.Size = new System.Drawing.Size(560, 29);
            this.tb_AddVocs_ES.TabIndex = 10;
            this.tb_AddVocs_ES.TextChanged += new System.EventHandler(this.act_IsFilled);
            this.tb_AddVocs_ES.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_AddVocs_FS_KeyDown);
            // 
            // lb_AddVocs
            // 
            this.lb_AddVocs.AutoSize = true;
            this.lb_AddVocs.Font = new System.Drawing.Font("Forte", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AddVocs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.lb_AddVocs.Location = new System.Drawing.Point(20, 13);
            this.lb_AddVocs.Name = "lb_AddVocs";
            this.lb_AddVocs.Size = new System.Drawing.Size(452, 38);
            this.lb_AddVocs.TabIndex = 8;
            this.lb_AddVocs.Text = "Vokabeln zur Box hinzufügen";
            // 
            // AddVocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Controls.Add(this.pnl_addVocs);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "AddVocs";
            this.Size = new System.Drawing.Size(1278, 582);
            this.pnl_addVocs.ResumeLayout(false);
            this.pnl_addVocs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_addVocs;
        private System.Windows.Forms.Button btn_AddVocs_Add;
        private System.Windows.Forms.Label lb_AddNew_Warnung;
        private System.Windows.Forms.Label lb_AddVocs_Switch;
        private System.Windows.Forms.Label lb_AddVocs_FS;
        private System.Windows.Forms.Label lb_AddVocs_ES;
        private System.Windows.Forms.TextBox tb_AddVocs_FS;
        private System.Windows.Forms.TextBox tb_AddVocs_ES;
        private System.Windows.Forms.Label lb_AddVocs;
    }
}
