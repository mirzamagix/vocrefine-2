namespace Vocrefine_2
{
    partial class SelectBox
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
            this.lb_continue = new System.Windows.Forms.Label();
            this.pnl_continue = new System.Windows.Forms.Panel();
            this.pnl_DragBar = new System.Windows.Forms.Panel();
            this.lb_Minimize = new System.Windows.Forms.Label();
            this.lb_back = new System.Windows.Forms.Label();
            this.lb_CloseWindow = new System.Windows.Forms.Label();
            this.pnl_CaptionBar = new System.Windows.Forms.Panel();
            this.flp_MyItems = new System.Windows.Forms.FlowLayoutPanel();
            this.gb_Info = new System.Windows.Forms.GroupBox();
            this.pnl_Info = new System.Windows.Forms.Panel();
            this.lb_title_nameBox = new System.Windows.Forms.Label();
            this.lb_title_lastLearned = new System.Windows.Forms.Label();
            this.lb_lastLearned = new System.Windows.Forms.Label();
            this.lb_title_createdAt = new System.Windows.Forms.Label();
            this.lb_createdAt = new System.Windows.Forms.Label();
            this.lb_title_FS = new System.Windows.Forms.Label();
            this.lb_FS = new System.Windows.Forms.Label();
            this.lb_title_ES = new System.Windows.Forms.Label();
            this.lb_ES = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_Info_Title = new System.Windows.Forms.Label();
            this.lb_SelectBox = new System.Windows.Forms.Label();
            this.lb_Warnung = new System.Windows.Forms.Label();
            this.pnl_continue.SuspendLayout();
            this.pnl_CaptionBar.SuspendLayout();
            this.gb_Info.SuspendLayout();
            this.pnl_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_continue
            // 
            this.lb_continue.AutoSize = true;
            this.lb_continue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_continue.Font = new System.Drawing.Font("Eras Bold ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_continue.ForeColor = System.Drawing.Color.White;
            this.lb_continue.Location = new System.Drawing.Point(381, 31);
            this.lb_continue.Name = "lb_continue";
            this.lb_continue.Size = new System.Drawing.Size(549, 40);
            this.lb_continue.TabIndex = 0;
            this.lb_continue.Text = "MIT DIESER BOX FORFAHREN";
            this.lb_continue.Click += new System.EventHandler(this.act_Continue);
            // 
            // pnl_continue
            // 
            this.pnl_continue.BackColor = System.Drawing.Color.Gray;
            this.pnl_continue.Controls.Add(this.lb_continue);
            this.pnl_continue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_continue.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_continue.Location = new System.Drawing.Point(0, 618);
            this.pnl_continue.Name = "pnl_continue";
            this.pnl_continue.Size = new System.Drawing.Size(1278, 100);
            this.pnl_continue.TabIndex = 2;
            this.pnl_continue.Click += new System.EventHandler(this.act_Continue);
            // 
            // pnl_DragBar
            // 
            this.pnl_DragBar.Location = new System.Drawing.Point(97, 3);
            this.pnl_DragBar.Name = "pnl_DragBar";
            this.pnl_DragBar.Size = new System.Drawing.Size(1122, 30);
            this.pnl_DragBar.TabIndex = 20;
            // 
            // lb_Minimize
            // 
            this.lb_Minimize.AutoSize = true;
            this.lb_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.lb_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_Minimize.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.lb_Minimize.Location = new System.Drawing.Point(1225, 10);
            this.lb_Minimize.Name = "lb_Minimize";
            this.lb_Minimize.Size = new System.Drawing.Size(17, 19);
            this.lb_Minimize.TabIndex = 19;
            this.lb_Minimize.Text = "_";
            // 
            // lb_back
            // 
            this.lb_back.AutoSize = true;
            this.lb_back.BackColor = System.Drawing.Color.Transparent;
            this.lb_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_back.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.lb_back.Location = new System.Drawing.Point(12, 10);
            this.lb_back.Name = "lb_back";
            this.lb_back.Size = new System.Drawing.Size(79, 19);
            this.lb_back.TabIndex = 18;
            this.lb_back.Text = "< Zurück";
            // 
            // lb_CloseWindow
            // 
            this.lb_CloseWindow.AutoSize = true;
            this.lb_CloseWindow.BackColor = System.Drawing.Color.Transparent;
            this.lb_CloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_CloseWindow.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CloseWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.lb_CloseWindow.Location = new System.Drawing.Point(1248, 10);
            this.lb_CloseWindow.Name = "lb_CloseWindow";
            this.lb_CloseWindow.Size = new System.Drawing.Size(20, 19);
            this.lb_CloseWindow.TabIndex = 17;
            this.lb_CloseWindow.Text = "X";
            this.lb_CloseWindow.Click += new System.EventHandler(this.lb_CloseWindow_Click);
            // 
            // pnl_CaptionBar
            // 
            this.pnl_CaptionBar.Controls.Add(this.pnl_DragBar);
            this.pnl_CaptionBar.Controls.Add(this.lb_CloseWindow);
            this.pnl_CaptionBar.Controls.Add(this.lb_back);
            this.pnl_CaptionBar.Controls.Add(this.lb_Minimize);
            this.pnl_CaptionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_CaptionBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_CaptionBar.Name = "pnl_CaptionBar";
            this.pnl_CaptionBar.Size = new System.Drawing.Size(1278, 36);
            this.pnl_CaptionBar.TabIndex = 22;
            // 
            // flp_MyItems
            // 
            this.flp_MyItems.AutoScroll = true;
            this.flp_MyItems.BackColor = System.Drawing.SystemColors.Control;
            this.flp_MyItems.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flp_MyItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.flp_MyItems.Location = new System.Drawing.Point(16, 116);
            this.flp_MyItems.Name = "flp_MyItems";
            this.flp_MyItems.Size = new System.Drawing.Size(620, 486);
            this.flp_MyItems.TabIndex = 23;
            // 
            // gb_Info
            // 
            this.gb_Info.Controls.Add(this.pnl_Info);
            this.gb_Info.Controls.Add(this.lb_Info_Title);
            this.gb_Info.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.gb_Info.Location = new System.Drawing.Point(651, 105);
            this.gb_Info.Name = "gb_Info";
            this.gb_Info.Size = new System.Drawing.Size(610, 497);
            this.gb_Info.TabIndex = 26;
            this.gb_Info.TabStop = false;
            // 
            // pnl_Info
            // 
            this.pnl_Info.Controls.Add(this.lb_title_nameBox);
            this.pnl_Info.Controls.Add(this.lb_title_lastLearned);
            this.pnl_Info.Controls.Add(this.lb_lastLearned);
            this.pnl_Info.Controls.Add(this.lb_title_createdAt);
            this.pnl_Info.Controls.Add(this.lb_createdAt);
            this.pnl_Info.Controls.Add(this.lb_title_FS);
            this.pnl_Info.Controls.Add(this.lb_FS);
            this.pnl_Info.Controls.Add(this.lb_title_ES);
            this.pnl_Info.Controls.Add(this.lb_ES);
            this.pnl_Info.Controls.Add(this.lb_name);
            this.pnl_Info.Location = new System.Drawing.Point(11, 48);
            this.pnl_Info.Name = "pnl_Info";
            this.pnl_Info.Size = new System.Drawing.Size(580, 166);
            this.pnl_Info.TabIndex = 1;
            this.pnl_Info.Visible = false;
            // 
            // lb_title_nameBox
            // 
            this.lb_title_nameBox.AutoSize = true;
            this.lb_title_nameBox.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title_nameBox.Location = new System.Drawing.Point(14, 15);
            this.lb_title_nameBox.Name = "lb_title_nameBox";
            this.lb_title_nameBox.Size = new System.Drawing.Size(111, 20);
            this.lb_title_nameBox.TabIndex = 0;
            this.lb_title_nameBox.Text = "Name der Box:";
            // 
            // lb_title_lastLearned
            // 
            this.lb_title_lastLearned.AutoSize = true;
            this.lb_title_lastLearned.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title_lastLearned.Location = new System.Drawing.Point(14, 127);
            this.lb_title_lastLearned.Name = "lb_title_lastLearned";
            this.lb_title_lastLearned.Size = new System.Drawing.Size(142, 20);
            this.lb_title_lastLearned.TabIndex = 0;
            this.lb_title_lastLearned.Text = "Zuletzt gelernt am: ";
            // 
            // lb_lastLearned
            // 
            this.lb_lastLearned.AutoSize = true;
            this.lb_lastLearned.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_lastLearned.Location = new System.Drawing.Point(164, 127);
            this.lb_lastLearned.Name = "lb_lastLearned";
            this.lb_lastLearned.Size = new System.Drawing.Size(85, 20);
            this.lb_lastLearned.TabIndex = 0;
            this.lb_lastLearned.Text = "lastLearned";
            // 
            // lb_title_createdAt
            // 
            this.lb_title_createdAt.AutoSize = true;
            this.lb_title_createdAt.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title_createdAt.Location = new System.Drawing.Point(14, 99);
            this.lb_title_createdAt.Name = "lb_title_createdAt";
            this.lb_title_createdAt.Size = new System.Drawing.Size(118, 20);
            this.lb_title_createdAt.TabIndex = 0;
            this.lb_title_createdAt.Text = "Box erstellt am: ";
            // 
            // lb_createdAt
            // 
            this.lb_createdAt.AutoSize = true;
            this.lb_createdAt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_createdAt.Location = new System.Drawing.Point(164, 99);
            this.lb_createdAt.Name = "lb_createdAt";
            this.lb_createdAt.Size = new System.Drawing.Size(74, 20);
            this.lb_createdAt.TabIndex = 0;
            this.lb_createdAt.Text = "createdAt";
            // 
            // lb_title_FS
            // 
            this.lb_title_FS.AutoSize = true;
            this.lb_title_FS.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title_FS.Location = new System.Drawing.Point(14, 71);
            this.lb_title_FS.Name = "lb_title_FS";
            this.lb_title_FS.Size = new System.Drawing.Size(110, 20);
            this.lb_title_FS.TabIndex = 0;
            this.lb_title_FS.Text = "Fremdsprache:";
            // 
            // lb_FS
            // 
            this.lb_FS.AutoSize = true;
            this.lb_FS.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FS.Location = new System.Drawing.Point(164, 71);
            this.lb_FS.Name = "lb_FS";
            this.lb_FS.Size = new System.Drawing.Size(20, 20);
            this.lb_FS.TabIndex = 0;
            this.lb_FS.Text = "fs";
            // 
            // lb_title_ES
            // 
            this.lb_title_ES.AutoSize = true;
            this.lb_title_ES.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title_ES.Location = new System.Drawing.Point(14, 43);
            this.lb_title_ES.Name = "lb_title_ES";
            this.lb_title_ES.Size = new System.Drawing.Size(118, 20);
            this.lb_title_ES.TabIndex = 0;
            this.lb_title_ES.Text = "Eigene Sprache:";
            // 
            // lb_ES
            // 
            this.lb_ES.AutoSize = true;
            this.lb_ES.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ES.Location = new System.Drawing.Point(164, 43);
            this.lb_ES.Name = "lb_ES";
            this.lb_ES.Size = new System.Drawing.Size(23, 20);
            this.lb_ES.TabIndex = 0;
            this.lb_ES.Text = "es";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_name.Location = new System.Drawing.Point(164, 15);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(46, 20);
            this.lb_name.TabIndex = 0;
            this.lb_name.Text = "name";
            // 
            // lb_Info_Title
            // 
            this.lb_Info_Title.AutoSize = true;
            this.lb_Info_Title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Info_Title.Location = new System.Drawing.Point(6, 20);
            this.lb_Info_Title.Name = "lb_Info_Title";
            this.lb_Info_Title.Size = new System.Drawing.Size(419, 25);
            this.lb_Info_Title.TabIndex = 0;
            this.lb_Info_Title.Text = "INFORMATIONEN ZUR AUSGEWÄHLTEN BOX:";
            // 
            // lb_SelectBox
            // 
            this.lb_SelectBox.AutoSize = true;
            this.lb_SelectBox.Font = new System.Drawing.Font("Forte", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SelectBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.lb_SelectBox.Location = new System.Drawing.Point(24, 54);
            this.lb_SelectBox.Name = "lb_SelectBox";
            this.lb_SelectBox.Size = new System.Drawing.Size(431, 38);
            this.lb_SelectBox.TabIndex = 27;
            this.lb_SelectBox.Text = "Vorhandene Box auswählen";
            // 
            // lb_Warnung
            // 
            this.lb_Warnung.AutoSize = true;
            this.lb_Warnung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_Warnung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Warnung.Location = new System.Drawing.Point(28, 92);
            this.lb_Warnung.Name = "lb_Warnung";
            this.lb_Warnung.Size = new System.Drawing.Size(346, 15);
            this.lb_Warnung.TabIndex = 28;
            this.lb_Warnung.Text = "Wählen sie mit einem Klick die Box aus, die sie öffnenn möchten";
            // 
            // SelectBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lb_Warnung);
            this.Controls.Add(this.lb_SelectBox);
            this.Controls.Add(this.flp_MyItems);
            this.Controls.Add(this.gb_Info);
            this.Controls.Add(this.pnl_CaptionBar);
            this.Controls.Add(this.pnl_continue);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "SelectBox";
            this.Size = new System.Drawing.Size(1278, 718);
            this.pnl_continue.ResumeLayout(false);
            this.pnl_continue.PerformLayout();
            this.pnl_CaptionBar.ResumeLayout(false);
            this.pnl_CaptionBar.PerformLayout();
            this.gb_Info.ResumeLayout(false);
            this.gb_Info.PerformLayout();
            this.pnl_Info.ResumeLayout(false);
            this.pnl_Info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lb_continue;
        public System.Windows.Forms.Panel pnl_continue;
        public System.Windows.Forms.Panel pnl_DragBar;
        public System.Windows.Forms.Label lb_Minimize;
        public System.Windows.Forms.Label lb_back;
        private System.Windows.Forms.Label lb_CloseWindow;
        private System.Windows.Forms.Panel pnl_CaptionBar;
        private System.Windows.Forms.FlowLayoutPanel flp_MyItems;
        private System.Windows.Forms.GroupBox gb_Info;
        private System.Windows.Forms.Label lb_SelectBox;
        private System.Windows.Forms.Label lb_Warnung;
        private System.Windows.Forms.Label lb_Info_Title;
        private System.Windows.Forms.Label lb_title_FS;
        private System.Windows.Forms.Label lb_title_ES;
        private System.Windows.Forms.Label lb_title_nameBox;
        private System.Windows.Forms.Label lb_title_lastLearned;
        private System.Windows.Forms.Label lb_title_createdAt;
        private System.Windows.Forms.Label lb_lastLearned;
        private System.Windows.Forms.Label lb_ES;
        private System.Windows.Forms.Label lb_FS;
        private System.Windows.Forms.Label lb_createdAt;
        private System.Windows.Forms.Panel pnl_Info;
        public System.Windows.Forms.Label lb_name;
    }
}
