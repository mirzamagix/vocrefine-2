namespace Vocrefine_2
{
    partial class ManageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageBox));
            this.pnl_Learn = new System.Windows.Forms.Panel();
            this.pnl_DragBar_Right = new System.Windows.Forms.Panel();
            this.lb_Minimize = new System.Windows.Forms.Label();
            this.lb_CloseWindow = new System.Windows.Forms.Label();
            this.lb_Learn = new System.Windows.Forms.Label();
            this.pb_Learn = new System.Windows.Forms.PictureBox();
            this.pnl_topboth = new System.Windows.Forms.Panel();
            this.pnl_Edit = new System.Windows.Forms.Panel();
            this.pnl_DragBar_Middle = new System.Windows.Forms.Panel();
            this.lb_Edit = new System.Windows.Forms.Label();
            this.pb_Edit = new System.Windows.Forms.PictureBox();
            this.pnl_Reset = new System.Windows.Forms.Panel();
            this.pnl_DragBar_Left = new System.Windows.Forms.Panel();
            this.lb_back = new System.Windows.Forms.Label();
            this.lb_Reset = new System.Windows.Forms.Label();
            this.pb_Reset = new System.Windows.Forms.PictureBox();
            this.pnl_botboth = new System.Windows.Forms.Panel();
            this.pnl_Export = new System.Windows.Forms.Panel();
            this.lb_Export = new System.Windows.Forms.Label();
            this.pb_Export = new System.Windows.Forms.PictureBox();
            this.pnl_Delete = new System.Windows.Forms.Panel();
            this.lb_Delete = new System.Windows.Forms.Label();
            this.pb_Delete = new System.Windows.Forms.PictureBox();
            this.ttp_Info = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_Learn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Learn)).BeginInit();
            this.pnl_topboth.SuspendLayout();
            this.pnl_Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Edit)).BeginInit();
            this.pnl_Reset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Reset)).BeginInit();
            this.pnl_botboth.SuspendLayout();
            this.pnl_Export.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Export)).BeginInit();
            this.pnl_Delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Delete)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Learn
            // 
            this.pnl_Learn.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Learn.Controls.Add(this.pnl_DragBar_Right);
            this.pnl_Learn.Controls.Add(this.lb_Minimize);
            this.pnl_Learn.Controls.Add(this.lb_CloseWindow);
            this.pnl_Learn.Controls.Add(this.lb_Learn);
            this.pnl_Learn.Controls.Add(this.pb_Learn);
            this.pnl_Learn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnl_Learn.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Learn.Location = new System.Drawing.Point(851, 0);
            this.pnl_Learn.Name = "pnl_Learn";
            this.pnl_Learn.Size = new System.Drawing.Size(427, 718);
            this.pnl_Learn.TabIndex = 9;
            this.pnl_Learn.MouseEnter += new System.EventHandler(this.act_MouseEnter_Learn);
            // 
            // pnl_DragBar_Right
            // 
            this.pnl_DragBar_Right.BackColor = System.Drawing.Color.Transparent;
            this.pnl_DragBar_Right.Location = new System.Drawing.Point(0, 3);
            this.pnl_DragBar_Right.Name = "pnl_DragBar_Right";
            this.pnl_DragBar_Right.Size = new System.Drawing.Size(366, 30);
            this.pnl_DragBar_Right.TabIndex = 10;
            this.pnl_DragBar_Right.MouseEnter += new System.EventHandler(this.act_MouseEnter_Learn);
            // 
            // lb_Minimize
            // 
            this.lb_Minimize.AutoSize = true;
            this.lb_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.lb_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_Minimize.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Minimize.ForeColor = System.Drawing.Color.White;
            this.lb_Minimize.Location = new System.Drawing.Point(372, 9);
            this.lb_Minimize.Name = "lb_Minimize";
            this.lb_Minimize.Size = new System.Drawing.Size(17, 19);
            this.lb_Minimize.TabIndex = 9;
            this.lb_Minimize.Text = "_";
            this.ttp_Info.SetToolTip(this.lb_Minimize, "Fenster minimieren");
            // 
            // lb_CloseWindow
            // 
            this.lb_CloseWindow.AutoSize = true;
            this.lb_CloseWindow.BackColor = System.Drawing.Color.Transparent;
            this.lb_CloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_CloseWindow.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CloseWindow.ForeColor = System.Drawing.Color.White;
            this.lb_CloseWindow.Location = new System.Drawing.Point(395, 9);
            this.lb_CloseWindow.Name = "lb_CloseWindow";
            this.lb_CloseWindow.Size = new System.Drawing.Size(20, 19);
            this.lb_CloseWindow.TabIndex = 8;
            this.lb_CloseWindow.Text = "X";
            this.ttp_Info.SetToolTip(this.lb_CloseWindow, "Vocrefine 2 BEENDEN");
            this.lb_CloseWindow.Click += new System.EventHandler(this.lb_CloseWindow_Click);
            // 
            // lb_Learn
            // 
            this.lb_Learn.AutoSize = true;
            this.lb_Learn.BackColor = System.Drawing.Color.Transparent;
            this.lb_Learn.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb_Learn.Font = new System.Drawing.Font("Eras Bold ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Learn.ForeColor = System.Drawing.Color.White;
            this.lb_Learn.Location = new System.Drawing.Point(91, 427);
            this.lb_Learn.Name = "lb_Learn";
            this.lb_Learn.Size = new System.Drawing.Size(251, 99);
            this.lb_Learn.TabIndex = 6;
            this.lb_Learn.Text = "VOKABELN IM\r\nKARTEIKASTEN\r\nLERNEN";
            this.lb_Learn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_Learn
            // 
            this.pb_Learn.Image = global::Vocrefine_2.Properties.Resources.learn_white;
            this.pb_Learn.Location = new System.Drawing.Point(106, 204);
            this.pb_Learn.Name = "pb_Learn";
            this.pb_Learn.Size = new System.Drawing.Size(220, 220);
            this.pb_Learn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Learn.TabIndex = 7;
            this.pb_Learn.TabStop = false;
            // 
            // pnl_topboth
            // 
            this.pnl_topboth.BackColor = System.Drawing.Color.White;
            this.pnl_topboth.Controls.Add(this.pnl_Edit);
            this.pnl_topboth.Controls.Add(this.pnl_Reset);
            this.pnl_topboth.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_topboth.Location = new System.Drawing.Point(0, 0);
            this.pnl_topboth.Name = "pnl_topboth";
            this.pnl_topboth.Size = new System.Drawing.Size(851, 360);
            this.pnl_topboth.TabIndex = 10;
            // 
            // pnl_Edit
            // 
            this.pnl_Edit.Controls.Add(this.pnl_DragBar_Middle);
            this.pnl_Edit.Controls.Add(this.lb_Edit);
            this.pnl_Edit.Controls.Add(this.pb_Edit);
            this.pnl_Edit.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnl_Edit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Edit.Location = new System.Drawing.Point(426, 0);
            this.pnl_Edit.Name = "pnl_Edit";
            this.pnl_Edit.Size = new System.Drawing.Size(425, 360);
            this.pnl_Edit.TabIndex = 1;
            this.pnl_Edit.MouseEnter += new System.EventHandler(this.act_MouseEnter_Edit);
            // 
            // pnl_DragBar_Middle
            // 
            this.pnl_DragBar_Middle.BackColor = System.Drawing.Color.Transparent;
            this.pnl_DragBar_Middle.Location = new System.Drawing.Point(0, 3);
            this.pnl_DragBar_Middle.Name = "pnl_DragBar_Middle";
            this.pnl_DragBar_Middle.Size = new System.Drawing.Size(425, 30);
            this.pnl_DragBar_Middle.TabIndex = 7;
            this.pnl_DragBar_Middle.MouseEnter += new System.EventHandler(this.act_MouseEnter_Edit);
            // 
            // lb_Edit
            // 
            this.lb_Edit.AutoSize = true;
            this.lb_Edit.BackColor = System.Drawing.Color.Transparent;
            this.lb_Edit.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb_Edit.Font = new System.Drawing.Font("Eras Bold ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Edit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.lb_Edit.Location = new System.Drawing.Point(72, 278);
            this.lb_Edit.Name = "lb_Edit";
            this.lb_Edit.Size = new System.Drawing.Size(281, 24);
            this.lb_Edit.TabIndex = 4;
            this.lb_Edit.Text = "VOKABELN VERWALTEN";
            this.lb_Edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_Edit
            // 
            this.pb_Edit.Image = ((System.Drawing.Image)(resources.GetObject("pb_Edit.Image")));
            this.pb_Edit.Location = new System.Drawing.Point(102, 43);
            this.pb_Edit.Name = "pb_Edit";
            this.pb_Edit.Size = new System.Drawing.Size(220, 220);
            this.pb_Edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Edit.TabIndex = 5;
            this.pb_Edit.TabStop = false;
            // 
            // pnl_Reset
            // 
            this.pnl_Reset.BackColor = System.Drawing.Color.White;
            this.pnl_Reset.Controls.Add(this.pnl_DragBar_Left);
            this.pnl_Reset.Controls.Add(this.lb_back);
            this.pnl_Reset.Controls.Add(this.lb_Reset);
            this.pnl_Reset.Controls.Add(this.pb_Reset);
            this.pnl_Reset.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnl_Reset.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Reset.Location = new System.Drawing.Point(0, 0);
            this.pnl_Reset.Name = "pnl_Reset";
            this.pnl_Reset.Size = new System.Drawing.Size(426, 360);
            this.pnl_Reset.TabIndex = 0;
            this.pnl_Reset.Click += new System.EventHandler(this.act_ResetBox);
            this.pnl_Reset.MouseEnter += new System.EventHandler(this.act_MouseEnter_Reset);
            // 
            // pnl_DragBar_Left
            // 
            this.pnl_DragBar_Left.BackColor = System.Drawing.Color.Transparent;
            this.pnl_DragBar_Left.Location = new System.Drawing.Point(98, 3);
            this.pnl_DragBar_Left.Name = "pnl_DragBar_Left";
            this.pnl_DragBar_Left.Size = new System.Drawing.Size(328, 30);
            this.pnl_DragBar_Left.TabIndex = 6;
            this.pnl_DragBar_Left.MouseEnter += new System.EventHandler(this.act_MouseEnter_Reset);
            // 
            // lb_back
            // 
            this.lb_back.AutoSize = true;
            this.lb_back.BackColor = System.Drawing.Color.Transparent;
            this.lb_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_back.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.lb_back.Location = new System.Drawing.Point(14, 9);
            this.lb_back.Name = "lb_back";
            this.lb_back.Size = new System.Drawing.Size(70, 19);
            this.lb_back.TabIndex = 5;
            this.lb_back.Text = "< Fertig";
            this.ttp_Info.SetToolTip(this.lb_back, "Zurück zum Hauptmenü");
            // 
            // lb_Reset
            // 
            this.lb_Reset.AutoSize = true;
            this.lb_Reset.BackColor = System.Drawing.Color.Transparent;
            this.lb_Reset.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb_Reset.Font = new System.Drawing.Font("Eras Bold ITC", 15.75F);
            this.lb_Reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.lb_Reset.Location = new System.Drawing.Point(94, 278);
            this.lb_Reset.Name = "lb_Reset";
            this.lb_Reset.Size = new System.Drawing.Size(237, 24);
            this.lb_Reset.TabIndex = 2;
            this.lb_Reset.Text = "BOX ZURÜCKSETZEN";
            this.lb_Reset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Reset.Click += new System.EventHandler(this.act_ResetBox);
            // 
            // pb_Reset
            // 
            this.pb_Reset.Image = ((System.Drawing.Image)(resources.GetObject("pb_Reset.Image")));
            this.pb_Reset.Location = new System.Drawing.Point(101, 43);
            this.pb_Reset.Name = "pb_Reset";
            this.pb_Reset.Size = new System.Drawing.Size(220, 220);
            this.pb_Reset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Reset.TabIndex = 3;
            this.pb_Reset.TabStop = false;
            this.pb_Reset.Click += new System.EventHandler(this.act_ResetBox);
            // 
            // pnl_botboth
            // 
            this.pnl_botboth.BackColor = System.Drawing.Color.White;
            this.pnl_botboth.Controls.Add(this.pnl_Export);
            this.pnl_botboth.Controls.Add(this.pnl_Delete);
            this.pnl_botboth.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_botboth.Location = new System.Drawing.Point(0, 360);
            this.pnl_botboth.Name = "pnl_botboth";
            this.pnl_botboth.Size = new System.Drawing.Size(851, 358);
            this.pnl_botboth.TabIndex = 11;
            // 
            // pnl_Export
            // 
            this.pnl_Export.Controls.Add(this.lb_Export);
            this.pnl_Export.Controls.Add(this.pb_Export);
            this.pnl_Export.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnl_Export.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Export.Location = new System.Drawing.Point(426, 0);
            this.pnl_Export.Name = "pnl_Export";
            this.pnl_Export.Size = new System.Drawing.Size(425, 358);
            this.pnl_Export.TabIndex = 1;
            this.pnl_Export.Click += new System.EventHandler(this.act_Export);
            this.pnl_Export.MouseEnter += new System.EventHandler(this.act_MouseEnter_Export);
            // 
            // lb_Export
            // 
            this.lb_Export.AutoSize = true;
            this.lb_Export.BackColor = System.Drawing.Color.Transparent;
            this.lb_Export.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb_Export.Font = new System.Drawing.Font("Eras Bold ITC", 15.75F);
            this.lb_Export.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.lb_Export.Location = new System.Drawing.Point(128, 280);
            this.lb_Export.Name = "lb_Export";
            this.lb_Export.Size = new System.Drawing.Size(175, 48);
            this.lb_Export.TabIndex = 4;
            this.lb_Export.Text = "BOX ALS DATEI\r\nEXPORTIEREN";
            this.lb_Export.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Export.Click += new System.EventHandler(this.act_Export);
            // 
            // pb_Export
            // 
            this.pb_Export.Image = ((System.Drawing.Image)(resources.GetObject("pb_Export.Image")));
            this.pb_Export.Location = new System.Drawing.Point(102, 50);
            this.pb_Export.Name = "pb_Export";
            this.pb_Export.Size = new System.Drawing.Size(220, 220);
            this.pb_Export.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Export.TabIndex = 5;
            this.pb_Export.TabStop = false;
            this.pb_Export.Click += new System.EventHandler(this.act_Export);
            // 
            // pnl_Delete
            // 
            this.pnl_Delete.Controls.Add(this.lb_Delete);
            this.pnl_Delete.Controls.Add(this.pb_Delete);
            this.pnl_Delete.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnl_Delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Delete.Location = new System.Drawing.Point(0, 0);
            this.pnl_Delete.Name = "pnl_Delete";
            this.pnl_Delete.Size = new System.Drawing.Size(426, 358);
            this.pnl_Delete.TabIndex = 0;
            this.pnl_Delete.Click += new System.EventHandler(this.act_DeleteBox);
            this.pnl_Delete.MouseEnter += new System.EventHandler(this.act_MouseEnter_Delete);
            // 
            // lb_Delete
            // 
            this.lb_Delete.AutoSize = true;
            this.lb_Delete.BackColor = System.Drawing.Color.Transparent;
            this.lb_Delete.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb_Delete.Font = new System.Drawing.Font("Eras Bold ITC", 15.75F);
            this.lb_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.lb_Delete.Location = new System.Drawing.Point(129, 280);
            this.lb_Delete.Name = "lb_Delete";
            this.lb_Delete.Size = new System.Drawing.Size(166, 24);
            this.lb_Delete.TabIndex = 2;
            this.lb_Delete.Text = "BOX LÖSCHEN";
            this.lb_Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Delete.Click += new System.EventHandler(this.act_DeleteBox);
            // 
            // pb_Delete
            // 
            this.pb_Delete.Image = ((System.Drawing.Image)(resources.GetObject("pb_Delete.Image")));
            this.pb_Delete.Location = new System.Drawing.Point(101, 46);
            this.pb_Delete.Name = "pb_Delete";
            this.pb_Delete.Size = new System.Drawing.Size(220, 220);
            this.pb_Delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Delete.TabIndex = 3;
            this.pb_Delete.TabStop = false;
            this.pb_Delete.Click += new System.EventHandler(this.act_DeleteBox);
            // 
            // ManageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnl_botboth);
            this.Controls.Add(this.pnl_topboth);
            this.Controls.Add(this.pnl_Learn);
            this.Name = "ManageBox";
            this.Size = new System.Drawing.Size(1278, 718);
            this.pnl_Learn.ResumeLayout(false);
            this.pnl_Learn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Learn)).EndInit();
            this.pnl_topboth.ResumeLayout(false);
            this.pnl_Edit.ResumeLayout(false);
            this.pnl_Edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Edit)).EndInit();
            this.pnl_Reset.ResumeLayout(false);
            this.pnl_Reset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Reset)).EndInit();
            this.pnl_botboth.ResumeLayout(false);
            this.pnl_Export.ResumeLayout(false);
            this.pnl_Export.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Export)).EndInit();
            this.pnl_Delete.ResumeLayout(false);
            this.pnl_Delete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Delete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pnl_Learn;
        private System.Windows.Forms.Panel pnl_topboth;
        private System.Windows.Forms.Panel pnl_Reset;
        private System.Windows.Forms.Panel pnl_botboth;
        private System.Windows.Forms.Panel pnl_Delete;
        private System.Windows.Forms.Panel pnl_Export;
        public System.Windows.Forms.PictureBox pb_Reset;
        public System.Windows.Forms.Label lb_Reset;
        public System.Windows.Forms.Label lb_Delete;
        public System.Windows.Forms.PictureBox pb_Delete;
        public System.Windows.Forms.Label lb_Edit;
        public System.Windows.Forms.PictureBox pb_Edit;
        public System.Windows.Forms.Label lb_Learn;
        public System.Windows.Forms.PictureBox pb_Learn;
        public System.Windows.Forms.Label lb_Export;
        public System.Windows.Forms.PictureBox pb_Export;
        public System.Windows.Forms.Label lb_Minimize;
        private System.Windows.Forms.Label lb_CloseWindow;
        public System.Windows.Forms.Label lb_back;
        public System.Windows.Forms.Panel pnl_DragBar_Left;
        public System.Windows.Forms.Panel pnl_DragBar_Right;
        public System.Windows.Forms.Panel pnl_DragBar_Middle;
        private System.Windows.Forms.ToolTip ttp_Info;
        public System.Windows.Forms.Panel pnl_Edit;
    }
}
