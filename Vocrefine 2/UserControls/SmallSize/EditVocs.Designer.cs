namespace Vocrefine_2
{
    partial class EditVocs
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
            this.flp_VocabList = new System.Windows.Forms.FlowLayoutPanel();
            this.lb_Title = new System.Windows.Forms.Label();
            this.gb_Info = new System.Windows.Forms.GroupBox();
            this.pnl_Info = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tb_Fremdsprache = new System.Windows.Forms.TextBox();
            this.tb_EigeneSprache = new System.Windows.Forms.TextBox();
            this.lb_title_FS = new System.Windows.Forms.Label();
            this.lb_title_ES = new System.Windows.Forms.Label();
            this.lb_Info_Title = new System.Windows.Forms.Label();
            this.btn_ChangeDirection = new System.Windows.Forms.Button();
            this.gb_Info.SuspendLayout();
            this.pnl_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_VocabList
            // 
            this.flp_VocabList.AutoScroll = true;
            this.flp_VocabList.BackColor = System.Drawing.Color.Thistle;
            this.flp_VocabList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flp_VocabList.Cursor = System.Windows.Forms.Cursors.Default;
            this.flp_VocabList.Location = new System.Drawing.Point(17, 59);
            this.flp_VocabList.Name = "flp_VocabList";
            this.flp_VocabList.Size = new System.Drawing.Size(725, 508);
            this.flp_VocabList.TabIndex = 24;
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Forte", 26.25F);
            this.lb_Title.Location = new System.Drawing.Point(23, 16);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(537, 38);
            this.lb_Title.TabIndex = 25;
            this.lb_Title.Text = "Vokabel zum bearbeiten auswählen";
            // 
            // gb_Info
            // 
            this.gb_Info.Controls.Add(this.pnl_Info);
            this.gb_Info.Controls.Add(this.lb_Info_Title);
            this.gb_Info.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.gb_Info.Location = new System.Drawing.Point(748, 46);
            this.gb_Info.Name = "gb_Info";
            this.gb_Info.Size = new System.Drawing.Size(508, 262);
            this.gb_Info.TabIndex = 27;
            this.gb_Info.TabStop = false;
            // 
            // pnl_Info
            // 
            this.pnl_Info.Controls.Add(this.btn_ChangeDirection);
            this.pnl_Info.Controls.Add(this.btn_delete);
            this.pnl_Info.Controls.Add(this.btn_save);
            this.pnl_Info.Controls.Add(this.tb_Fremdsprache);
            this.pnl_Info.Controls.Add(this.tb_EigeneSprache);
            this.pnl_Info.Controls.Add(this.lb_title_FS);
            this.pnl_Info.Controls.Add(this.lb_title_ES);
            this.pnl_Info.Location = new System.Drawing.Point(5, 47);
            this.pnl_Info.Name = "pnl_Info";
            this.pnl_Info.Size = new System.Drawing.Size(493, 209);
            this.pnl_Info.TabIndex = 2;
            this.pnl_Info.Visible = false;
            // 
            // btn_delete
            // 
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.Maroon;
            this.btn_delete.Location = new System.Drawing.Point(22, 141);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(145, 54);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "VOKABEL LÖSCHEN";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.act_DeleteVoc);
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Enabled = false;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(330, 141);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(145, 54);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "FERTIG & SPEICHERN";
            this.btn_save.UseMnemonic = false;
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.act_SaveVoc);
            // 
            // tb_Fremdsprache
            // 
            this.tb_Fremdsprache.BackColor = System.Drawing.Color.Thistle;
            this.tb_Fremdsprache.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_Fremdsprache.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.tb_Fremdsprache.Location = new System.Drawing.Point(22, 97);
            this.tb_Fremdsprache.Name = "tb_Fremdsprache";
            this.tb_Fremdsprache.Size = new System.Drawing.Size(453, 27);
            this.tb_Fremdsprache.TabIndex = 2;
            this.tb_Fremdsprache.TextChanged += new System.EventHandler(this.act_ChagedText);
            // 
            // tb_EigeneSprache
            // 
            this.tb_EigeneSprache.BackColor = System.Drawing.Color.Thistle;
            this.tb_EigeneSprache.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_EigeneSprache.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.tb_EigeneSprache.Location = new System.Drawing.Point(22, 36);
            this.tb_EigeneSprache.Name = "tb_EigeneSprache";
            this.tb_EigeneSprache.Size = new System.Drawing.Size(453, 27);
            this.tb_EigeneSprache.TabIndex = 1;
            this.tb_EigeneSprache.TextChanged += new System.EventHandler(this.act_ChagedText);
            // 
            // lb_title_FS
            // 
            this.lb_title_FS.AutoSize = true;
            this.lb_title_FS.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title_FS.Location = new System.Drawing.Point(25, 74);
            this.lb_title_FS.Name = "lb_title_FS";
            this.lb_title_FS.Size = new System.Drawing.Size(110, 20);
            this.lb_title_FS.TabIndex = 0;
            this.lb_title_FS.Text = "Fremdsprache:";
            // 
            // lb_title_ES
            // 
            this.lb_title_ES.AutoSize = true;
            this.lb_title_ES.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title_ES.Location = new System.Drawing.Point(25, 13);
            this.lb_title_ES.Name = "lb_title_ES";
            this.lb_title_ES.Size = new System.Drawing.Size(118, 20);
            this.lb_title_ES.TabIndex = 0;
            this.lb_title_ES.Text = "Eigene Sprache:";
            // 
            // lb_Info_Title
            // 
            this.lb_Info_Title.AutoSize = true;
            this.lb_Info_Title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Info_Title.Location = new System.Drawing.Point(8, 19);
            this.lb_Info_Title.Name = "lb_Info_Title";
            this.lb_Info_Title.Size = new System.Drawing.Size(270, 25);
            this.lb_Info_Title.TabIndex = 0;
            this.lb_Info_Title.Text = "Wählen sie eine Vokabel aus, ";
            // 
            // btn_ChangeDirection
            // 
            this.btn_ChangeDirection.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChangeDirection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangeDirection.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChangeDirection.Location = new System.Drawing.Point(174, 141);
            this.btn_ChangeDirection.Name = "btn_ChangeDirection";
            this.btn_ChangeDirection.Size = new System.Drawing.Size(150, 54);
            this.btn_ChangeDirection.TabIndex = 5;
            this.btn_ChangeDirection.Text = "VOKABELN VERTAUSCHEN";
            this.btn_ChangeDirection.UseVisualStyleBackColor = true;
            this.btn_ChangeDirection.Click += new System.EventHandler(this.act_ChangeDirection);
            // 
            // EditVocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.Controls.Add(this.gb_Info);
            this.Controls.Add(this.lb_Title);
            this.Controls.Add(this.flp_VocabList);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "EditVocs";
            this.Size = new System.Drawing.Size(1278, 582);
            this.gb_Info.ResumeLayout(false);
            this.gb_Info.PerformLayout();
            this.pnl_Info.ResumeLayout(false);
            this.pnl_Info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_VocabList;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.GroupBox gb_Info;
        private System.Windows.Forms.Label lb_Info_Title;
        private System.Windows.Forms.Panel pnl_Info;
        private System.Windows.Forms.Label lb_title_FS;
        private System.Windows.Forms.Label lb_title_ES;
        private System.Windows.Forms.TextBox tb_Fremdsprache;
        private System.Windows.Forms.TextBox tb_EigeneSprache;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_ChangeDirection;
    }
}
