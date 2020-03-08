namespace Vocrefine_2
{
    partial class AddNew
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
            this.pnl_Background_CreateNew = new System.Windows.Forms.Panel();
            this.pnl_DragBar_Right = new System.Windows.Forms.Panel();
            this.lb_Minimize = new System.Windows.Forms.Label();
            this.lb_CloseWindow = new System.Windows.Forms.Label();
            this.lb_CreateNew = new System.Windows.Forms.Label();
            this.pb_CreateNew = new System.Windows.Forms.PictureBox();
            this.pnl_Background_Import = new System.Windows.Forms.Panel();
            this.pnl_DragBar_Left = new System.Windows.Forms.Panel();
            this.lb_back = new System.Windows.Forms.Label();
            this.pb_import = new System.Windows.Forms.PictureBox();
            this.lb_Import = new System.Windows.Forms.Label();
            this.ttp_Info = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_Background_CreateNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CreateNew)).BeginInit();
            this.pnl_Background_Import.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_import)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Background_CreateNew
            // 
            this.pnl_Background_CreateNew.BackColor = System.Drawing.Color.White;
            this.pnl_Background_CreateNew.Controls.Add(this.pnl_DragBar_Right);
            this.pnl_Background_CreateNew.Controls.Add(this.lb_Minimize);
            this.pnl_Background_CreateNew.Controls.Add(this.lb_CloseWindow);
            this.pnl_Background_CreateNew.Controls.Add(this.lb_CreateNew);
            this.pnl_Background_CreateNew.Controls.Add(this.pb_CreateNew);
            this.pnl_Background_CreateNew.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnl_Background_CreateNew.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Background_CreateNew.Location = new System.Drawing.Point(638, 0);
            this.pnl_Background_CreateNew.Name = "pnl_Background_CreateNew";
            this.pnl_Background_CreateNew.Size = new System.Drawing.Size(640, 718);
            this.pnl_Background_CreateNew.TabIndex = 4;
            this.pnl_Background_CreateNew.MouseEnter += new System.EventHandler(this.act_MouseEnter_CreateNew);
            // 
            // pnl_DragBar_Right
            // 
            this.pnl_DragBar_Right.BackColor = System.Drawing.Color.Transparent;
            this.pnl_DragBar_Right.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnl_DragBar_Right.Location = new System.Drawing.Point(0, 3);
            this.pnl_DragBar_Right.Name = "pnl_DragBar_Right";
            this.pnl_DragBar_Right.Size = new System.Drawing.Size(578, 30);
            this.pnl_DragBar_Right.TabIndex = 6;
            this.pnl_DragBar_Right.MouseEnter += new System.EventHandler(this.act_MouseEnter_CreateNew);
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
            this.lb_Minimize.TabIndex = 5;
            this.lb_Minimize.Text = "_";
            this.ttp_Info.SetToolTip(this.lb_Minimize, "Fenster minimieren");
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
            // lb_CreateNew
            // 
            this.lb_CreateNew.AutoSize = true;
            this.lb_CreateNew.BackColor = System.Drawing.Color.Transparent;
            this.lb_CreateNew.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb_CreateNew.Font = new System.Drawing.Font("Eras Bold ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CreateNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.lb_CreateNew.Location = new System.Drawing.Point(222, 426);
            this.lb_CreateNew.Name = "lb_CreateNew";
            this.lb_CreateNew.Size = new System.Drawing.Size(184, 66);
            this.lb_CreateNew.TabIndex = 0;
            this.lb_CreateNew.Text = "NEUE BOX\r\nERSTELLEN";
            this.lb_CreateNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_CreateNew
            // 
            this.pb_CreateNew.Cursor = System.Windows.Forms.Cursors.Default;
            this.pb_CreateNew.Image = global::Vocrefine_2.Properties.Resources.erstellen;
            this.pb_CreateNew.Location = new System.Drawing.Point(163, 154);
            this.pb_CreateNew.Name = "pb_CreateNew";
            this.pb_CreateNew.Size = new System.Drawing.Size(303, 307);
            this.pb_CreateNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_CreateNew.TabIndex = 1;
            this.pb_CreateNew.TabStop = false;
            // 
            // pnl_Background_Import
            // 
            this.pnl_Background_Import.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Background_Import.Controls.Add(this.pnl_DragBar_Left);
            this.pnl_Background_Import.Controls.Add(this.lb_back);
            this.pnl_Background_Import.Controls.Add(this.pb_import);
            this.pnl_Background_Import.Controls.Add(this.lb_Import);
            this.pnl_Background_Import.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnl_Background_Import.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Background_Import.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnl_Background_Import.Location = new System.Drawing.Point(0, 0);
            this.pnl_Background_Import.Name = "pnl_Background_Import";
            this.pnl_Background_Import.Size = new System.Drawing.Size(641, 718);
            this.pnl_Background_Import.TabIndex = 5;
            this.pnl_Background_Import.Click += new System.EventHandler(this.act_import);
            this.pnl_Background_Import.MouseEnter += new System.EventHandler(this.act_MouseEnter_Import);
            // 
            // pnl_DragBar_Left
            // 
            this.pnl_DragBar_Left.BackColor = System.Drawing.Color.Transparent;
            this.pnl_DragBar_Left.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnl_DragBar_Left.Location = new System.Drawing.Point(96, 3);
            this.pnl_DragBar_Left.Name = "pnl_DragBar_Left";
            this.pnl_DragBar_Left.Size = new System.Drawing.Size(542, 30);
            this.pnl_DragBar_Left.TabIndex = 5;
            this.pnl_DragBar_Left.MouseEnter += new System.EventHandler(this.act_MouseEnter_Import);
            // 
            // lb_back
            // 
            this.lb_back.AutoSize = true;
            this.lb_back.BackColor = System.Drawing.Color.Transparent;
            this.lb_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_back.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_back.ForeColor = System.Drawing.Color.White;
            this.lb_back.Location = new System.Drawing.Point(11, 8);
            this.lb_back.Name = "lb_back";
            this.lb_back.Size = new System.Drawing.Size(79, 19);
            this.lb_back.TabIndex = 4;
            this.lb_back.Text = "< Zurück";
            this.ttp_Info.SetToolTip(this.lb_back, "Zurück zum Hauptmenü");
            // 
            // pb_import
            // 
            this.pb_import.Cursor = System.Windows.Forms.Cursors.Default;
            this.pb_import.Image = global::Vocrefine_2.Properties.Resources.import_white;
            this.pb_import.Location = new System.Drawing.Point(195, 159);
            this.pb_import.Name = "pb_import";
            this.pb_import.Size = new System.Drawing.Size(256, 256);
            this.pb_import.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_import.TabIndex = 3;
            this.pb_import.TabStop = false;
            this.pb_import.Click += new System.EventHandler(this.act_import);
            // 
            // lb_Import
            // 
            this.lb_Import.AutoSize = true;
            this.lb_Import.BackColor = System.Drawing.Color.Transparent;
            this.lb_Import.Cursor = System.Windows.Forms.Cursors.Default;
            this.lb_Import.Font = new System.Drawing.Font("Eras Bold ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Import.ForeColor = System.Drawing.Color.White;
            this.lb_Import.Location = new System.Drawing.Point(210, 431);
            this.lb_Import.Name = "lb_Import";
            this.lb_Import.Size = new System.Drawing.Size(227, 66);
            this.lb_Import.TabIndex = 2;
            this.lb_Import.Text = "EXTERNE BOX\r\nIMPORTIEREN";
            this.lb_Import.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Import.Click += new System.EventHandler(this.act_import);
            // 
            // AddNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnl_Background_CreateNew);
            this.Controls.Add(this.pnl_Background_Import);
            this.Name = "AddNew";
            this.Size = new System.Drawing.Size(1278, 718);
            this.pnl_Background_CreateNew.ResumeLayout(false);
            this.pnl_Background_CreateNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_CreateNew)).EndInit();
            this.pnl_Background_Import.ResumeLayout(false);
            this.pnl_Background_Import.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_import)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_CloseWindow;
        private System.Windows.Forms.Panel pnl_Background_Import;
        private System.Windows.Forms.PictureBox pb_import;
        private System.Windows.Forms.Label lb_Import;
        public System.Windows.Forms.Panel pnl_Background_CreateNew;
        public System.Windows.Forms.Label lb_CreateNew;
        public System.Windows.Forms.PictureBox pb_CreateNew;
        public System.Windows.Forms.Label lb_back;
        public System.Windows.Forms.Label lb_Minimize;
        public System.Windows.Forms.Panel pnl_DragBar_Right;
        public System.Windows.Forms.Panel pnl_DragBar_Left;
        private System.Windows.Forms.ToolTip ttp_Info;
    }
}
