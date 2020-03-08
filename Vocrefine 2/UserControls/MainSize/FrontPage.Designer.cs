namespace Vocrefine_2
{
    partial class FrontPage
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
            this.components = new System.ComponentModel.Container();
            this.pnl_Background_OpenExisting = new System.Windows.Forms.Panel();
            this.pb_Settings = new System.Windows.Forms.PictureBox();
            this.pnl_DragBar_Right = new System.Windows.Forms.Panel();
            this.lb_Minimize = new System.Windows.Forms.Label();
            this.lb_AboutInfo = new System.Windows.Forms.Label();
            this.lb_CloseWindow = new System.Windows.Forms.Label();
            this.pb_OpenExisting = new System.Windows.Forms.PictureBox();
            this.lb_OpenExisting = new System.Windows.Forms.Label();
            this.pnl_Background_AddNew = new System.Windows.Forms.Panel();
            this.pnl_DragBar_Left = new System.Windows.Forms.Panel();
            this.lb_AddNew = new System.Windows.Forms.Label();
            this.pb_AddNew = new System.Windows.Forms.PictureBox();
            this.ttp_Info = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_Background_OpenExisting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Settings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_OpenExisting)).BeginInit();
            this.pnl_Background_AddNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AddNew)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Background_OpenExisting
            // 
            this.pnl_Background_OpenExisting.BackColor = System.Drawing.Color.White;
            this.pnl_Background_OpenExisting.Controls.Add(this.pb_Settings);
            this.pnl_Background_OpenExisting.Controls.Add(this.pnl_DragBar_Right);
            this.pnl_Background_OpenExisting.Controls.Add(this.lb_Minimize);
            this.pnl_Background_OpenExisting.Controls.Add(this.lb_AboutInfo);
            this.pnl_Background_OpenExisting.Controls.Add(this.lb_CloseWindow);
            this.pnl_Background_OpenExisting.Controls.Add(this.pb_OpenExisting);
            this.pnl_Background_OpenExisting.Controls.Add(this.lb_OpenExisting);
            this.pnl_Background_OpenExisting.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnl_Background_OpenExisting.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Background_OpenExisting.Location = new System.Drawing.Point(638, 0);
            this.pnl_Background_OpenExisting.Name = "pnl_Background_OpenExisting";
            this.pnl_Background_OpenExisting.Size = new System.Drawing.Size(640, 718);
            this.pnl_Background_OpenExisting.TabIndex = 2;
            this.pnl_Background_OpenExisting.Click += new System.EventHandler(this.act_Click_OpenExisting);
            this.pnl_Background_OpenExisting.MouseEnter += new System.EventHandler(this.act_MouseEnter_OpenExisting);
            // 
            // pb_Settings
            // 
            this.pb_Settings.BackColor = System.Drawing.Color.Transparent;
            this.pb_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Settings.Image = global::Vocrefine_2.Properties.Resources.settings;
            this.pb_Settings.Location = new System.Drawing.Point(535, 9);
            this.pb_Settings.Name = "pb_Settings";
            this.pb_Settings.Size = new System.Drawing.Size(19, 19);
            this.pb_Settings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Settings.TabIndex = 6;
            this.pb_Settings.TabStop = false;
            this.ttp_Info.SetToolTip(this.pb_Settings, "Einstellungen");
            // 
            // pnl_DragBar_Right
            // 
            this.pnl_DragBar_Right.BackColor = System.Drawing.Color.Transparent;
            this.pnl_DragBar_Right.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnl_DragBar_Right.Location = new System.Drawing.Point(0, 3);
            this.pnl_DragBar_Right.Name = "pnl_DragBar_Right";
            this.pnl_DragBar_Right.Size = new System.Drawing.Size(529, 30);
            this.pnl_DragBar_Right.TabIndex = 5;
            this.pnl_DragBar_Right.MouseEnter += new System.EventHandler(this.act_MouseEnter_OpenExisting);
            // 
            // lb_Minimize
            // 
            this.lb_Minimize.AutoSize = true;
            this.lb_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.lb_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_Minimize.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.lb_Minimize.Location = new System.Drawing.Point(584, 8);
            this.lb_Minimize.Name = "lb_Minimize";
            this.lb_Minimize.Size = new System.Drawing.Size(17, 19);
            this.lb_Minimize.TabIndex = 4;
            this.lb_Minimize.Text = "_";
            this.ttp_Info.SetToolTip(this.lb_Minimize, "Fenster minimieren");
            // 
            // lb_AboutInfo
            // 
            this.lb_AboutInfo.AutoSize = true;
            this.lb_AboutInfo.BackColor = System.Drawing.Color.Transparent;
            this.lb_AboutInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_AboutInfo.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AboutInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.lb_AboutInfo.Location = new System.Drawing.Point(561, 8);
            this.lb_AboutInfo.Name = "lb_AboutInfo";
            this.lb_AboutInfo.Size = new System.Drawing.Size(17, 19);
            this.lb_AboutInfo.TabIndex = 3;
            this.lb_AboutInfo.Text = "?";
            this.ttp_Info.SetToolTip(this.lb_AboutInfo, "Credits & About");
            // 
            // lb_CloseWindow
            // 
            this.lb_CloseWindow.AutoSize = true;
            this.lb_CloseWindow.BackColor = System.Drawing.Color.Transparent;
            this.lb_CloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_CloseWindow.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CloseWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.lb_CloseWindow.Location = new System.Drawing.Point(607, 8);
            this.lb_CloseWindow.Name = "lb_CloseWindow";
            this.lb_CloseWindow.Size = new System.Drawing.Size(20, 19);
            this.lb_CloseWindow.TabIndex = 2;
            this.lb_CloseWindow.Text = "X";
            this.ttp_Info.SetToolTip(this.lb_CloseWindow, "Vocrefine 2 BEENDEN");
            this.lb_CloseWindow.Click += new System.EventHandler(this.lb_CloseWindow_Click);
            // 
            // pb_OpenExisting
            // 
            this.pb_OpenExisting.Cursor = System.Windows.Forms.Cursors.Default;
            this.pb_OpenExisting.Image = global::Vocrefine_2.Properties.Resources.Ordner;
            this.pb_OpenExisting.Location = new System.Drawing.Point(183, 167);
            this.pb_OpenExisting.Name = "pb_OpenExisting";
            this.pb_OpenExisting.Size = new System.Drawing.Size(256, 256);
            this.pb_OpenExisting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_OpenExisting.TabIndex = 1;
            this.pb_OpenExisting.TabStop = false;
            this.pb_OpenExisting.Click += new System.EventHandler(this.act_Click_OpenExisting);
            // 
            // lb_OpenExisting
            // 
            this.lb_OpenExisting.AutoSize = true;
            this.lb_OpenExisting.BackColor = System.Drawing.Color.Transparent;
            this.lb_OpenExisting.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb_OpenExisting.Font = new System.Drawing.Font("Eras Bold ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_OpenExisting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.lb_OpenExisting.Location = new System.Drawing.Point(159, 426);
            this.lb_OpenExisting.Name = "lb_OpenExisting";
            this.lb_OpenExisting.Size = new System.Drawing.Size(311, 66);
            this.lb_OpenExisting.TabIndex = 0;
            this.lb_OpenExisting.Text = "VORHANDENE BOX\r\nÖFFNEN";
            this.lb_OpenExisting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_OpenExisting.Click += new System.EventHandler(this.act_Click_OpenExisting);
            // 
            // pnl_Background_AddNew
            // 
            this.pnl_Background_AddNew.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Background_AddNew.Controls.Add(this.pnl_DragBar_Left);
            this.pnl_Background_AddNew.Controls.Add(this.lb_AddNew);
            this.pnl_Background_AddNew.Controls.Add(this.pb_AddNew);
            this.pnl_Background_AddNew.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnl_Background_AddNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Background_AddNew.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_Background_AddNew.Location = new System.Drawing.Point(0, 0);
            this.pnl_Background_AddNew.Name = "pnl_Background_AddNew";
            this.pnl_Background_AddNew.Size = new System.Drawing.Size(641, 718);
            this.pnl_Background_AddNew.TabIndex = 3;
            this.pnl_Background_AddNew.MouseEnter += new System.EventHandler(this.act_MouseEnter_AddNew);
            // 
            // pnl_DragBar_Left
            // 
            this.pnl_DragBar_Left.BackColor = System.Drawing.Color.Transparent;
            this.pnl_DragBar_Left.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnl_DragBar_Left.Location = new System.Drawing.Point(3, 3);
            this.pnl_DragBar_Left.Name = "pnl_DragBar_Left";
            this.pnl_DragBar_Left.Size = new System.Drawing.Size(635, 30);
            this.pnl_DragBar_Left.TabIndex = 4;
            this.pnl_DragBar_Left.MouseEnter += new System.EventHandler(this.act_MouseEnter_AddNew);
            // 
            // lb_AddNew
            // 
            this.lb_AddNew.AutoSize = true;
            this.lb_AddNew.BackColor = System.Drawing.Color.Transparent;
            this.lb_AddNew.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb_AddNew.Font = new System.Drawing.Font("Eras Bold ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AddNew.ForeColor = System.Drawing.Color.White;
            this.lb_AddNew.Location = new System.Drawing.Point(198, 426);
            this.lb_AddNew.Name = "lb_AddNew";
            this.lb_AddNew.Size = new System.Drawing.Size(241, 66);
            this.lb_AddNew.TabIndex = 2;
            this.lb_AddNew.Text = "NEUE BOX \r\nHINZUFÜEGEN";
            this.lb_AddNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_AddNew
            // 
            this.pb_AddNew.BackColor = System.Drawing.Color.Transparent;
            this.pb_AddNew.Cursor = System.Windows.Forms.Cursors.Default;
            this.pb_AddNew.Image = global::Vocrefine_2.Properties.Resources.Hinzufuegen_white;
            this.pb_AddNew.Location = new System.Drawing.Point(152, 120);
            this.pb_AddNew.Name = "pb_AddNew";
            this.pb_AddNew.Size = new System.Drawing.Size(350, 350);
            this.pb_AddNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_AddNew.TabIndex = 3;
            this.pb_AddNew.TabStop = false;
            // 
            // FrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnl_Background_OpenExisting);
            this.Controls.Add(this.pnl_Background_AddNew);
            this.Name = "FrontPage";
            this.Size = new System.Drawing.Size(1278, 718);
            this.pnl_Background_OpenExisting.ResumeLayout(false);
            this.pnl_Background_OpenExisting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Settings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_OpenExisting)).EndInit();
            this.pnl_Background_AddNew.ResumeLayout(false);
            this.pnl_Background_AddNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_AddNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_CloseWindow;
        public System.Windows.Forms.Panel pnl_Background_AddNew;
        public System.Windows.Forms.Label lb_AddNew;
        public System.Windows.Forms.PictureBox pb_AddNew;
        public System.Windows.Forms.Label lb_Minimize;
        public System.Windows.Forms.Panel pnl_Background_OpenExisting;
        public System.Windows.Forms.PictureBox pb_OpenExisting;
        public System.Windows.Forms.Label lb_OpenExisting;
        public System.Windows.Forms.Panel pnl_DragBar_Right;
        public System.Windows.Forms.Panel pnl_DragBar_Left;
        private System.Windows.Forms.ToolTip ttp_Info;
        public System.Windows.Forms.Label lb_AboutInfo;
        public System.Windows.Forms.PictureBox pb_Settings;
    }
}
