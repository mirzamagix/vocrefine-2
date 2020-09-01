namespace Vocrefine_2
{
    partial class EditBoxSettings
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
            this.lb_Title = new System.Windows.Forms.Label();
            this.tb_Fremdsprache = new System.Windows.Forms.TextBox();
            this.lb_Fremdsprache = new System.Windows.Forms.Label();
            this.tb_EigeneSprache = new System.Windows.Forms.TextBox();
            this.lb_EigeneSprache = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Forte", 26.25F);
            this.lb_Title.ForeColor = System.Drawing.Color.Black;
            this.lb_Title.Location = new System.Drawing.Point(46, 31);
            this.lb_Title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(894, 77);
            this.lb_Title.TabIndex = 26;
            this.lb_Title.Text = "Box Eigenschaften verwalten";
            // 
            // tb_Fremdsprache
            // 
            this.tb_Fremdsprache.BackColor = System.Drawing.Color.LightCoral;
            this.tb_Fremdsprache.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Fremdsprache.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Fremdsprache.ForeColor = System.Drawing.Color.Black;
            this.tb_Fremdsprache.Location = new System.Drawing.Point(424, 381);
            this.tb_Fremdsprache.Margin = new System.Windows.Forms.Padding(10);
            this.tb_Fremdsprache.MaxLength = 30;
            this.tb_Fremdsprache.Name = "tb_Fremdsprache";
            this.tb_Fremdsprache.Size = new System.Drawing.Size(2050, 50);
            this.tb_Fremdsprache.TabIndex = 32;
            this.tb_Fremdsprache.Text = "s";
            this.tb_Fremdsprache.TextChanged += new System.EventHandler(this.tb_Fremdsprache_TextChanged);
            // 
            // lb_Fremdsprache
            // 
            this.lb_Fremdsprache.AutoSize = true;
            this.lb_Fremdsprache.Font = new System.Drawing.Font("Eras Medium ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Fremdsprache.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.lb_Fremdsprache.Location = new System.Drawing.Point(120, 383);
            this.lb_Fremdsprache.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_Fremdsprache.Name = "lb_Fremdsprache";
            this.lb_Fremdsprache.Size = new System.Drawing.Size(298, 49);
            this.lb_Fremdsprache.TabIndex = 31;
            this.lb_Fremdsprache.Text = "Fremdsprache:";
            // 
            // tb_EigeneSprache
            // 
            this.tb_EigeneSprache.BackColor = System.Drawing.Color.LightCoral;
            this.tb_EigeneSprache.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_EigeneSprache.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EigeneSprache.ForeColor = System.Drawing.Color.Black;
            this.tb_EigeneSprache.Location = new System.Drawing.Point(424, 285);
            this.tb_EigeneSprache.Margin = new System.Windows.Forms.Padding(10);
            this.tb_EigeneSprache.MaxLength = 30;
            this.tb_EigeneSprache.Name = "tb_EigeneSprache";
            this.tb_EigeneSprache.Size = new System.Drawing.Size(2050, 50);
            this.tb_EigeneSprache.TabIndex = 30;
            this.tb_EigeneSprache.Text = "s";
            this.tb_EigeneSprache.TextChanged += new System.EventHandler(this.tb_Fremdsprache_TextChanged);
            // 
            // lb_EigeneSprache
            // 
            this.lb_EigeneSprache.AutoSize = true;
            this.lb_EigeneSprache.Font = new System.Drawing.Font("Eras Medium ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EigeneSprache.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.lb_EigeneSprache.Location = new System.Drawing.Point(94, 287);
            this.lb_EigeneSprache.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_EigeneSprache.Name = "lb_EigeneSprache";
            this.lb_EigeneSprache.Size = new System.Drawing.Size(319, 49);
            this.lb_EigeneSprache.TabIndex = 29;
            this.lb_EigeneSprache.Text = "Eigene Sprache:";
            // 
            // tb_Name
            // 
            this.tb_Name.BackColor = System.Drawing.Color.LightCoral;
            this.tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.ForeColor = System.Drawing.Color.Black;
            this.tb_Name.Location = new System.Drawing.Point(424, 188);
            this.tb_Name.Margin = new System.Windows.Forms.Padding(10);
            this.tb_Name.MaxLength = 30;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(2050, 50);
            this.tb_Name.TabIndex = 28;
            this.tb_Name.Text = "s";
            this.tb_Name.TextChanged += new System.EventHandler(this.tb_Fremdsprache_TextChanged);
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Eras Medium ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.lb_Name.Location = new System.Drawing.Point(206, 190);
            this.lb_Name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(206, 49);
            this.lb_Name.TabIndex = 27;
            this.lb_Name.Text = "Boxname:";
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(1818, 448);
            this.btn_save.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(658, 88);
            this.btn_save.TabIndex = 33;
            this.btn_save.Text = "SPEICHERN & NEUSTART";
            this.btn_save.UseMnemonic = false;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // EditBoxSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_Fremdsprache);
            this.Controls.Add(this.lb_Fremdsprache);
            this.Controls.Add(this.tb_EigeneSprache);
            this.Controls.Add(this.lb_EigeneSprache);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lb_Name);
            this.Controls.Add(this.lb_Title);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "EditBoxSettings";
            this.Size = new System.Drawing.Size(2556, 1119);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.TextBox tb_Fremdsprache;
        private System.Windows.Forms.Label lb_Fremdsprache;
        private System.Windows.Forms.TextBox tb_EigeneSprache;
        private System.Windows.Forms.Label lb_EigeneSprache;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.TextBox tb_Name;
    }
}
