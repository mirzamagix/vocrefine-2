namespace Vocrefine_2
{
    partial class EditBox
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
            this.pnl_CaptionBar = new System.Windows.Forms.Panel();
            this.pnl_DragBar = new System.Windows.Forms.Panel();
            this.lb_CloseWindow = new System.Windows.Forms.Label();
            this.lb_back = new System.Windows.Forms.Label();
            this.lb_Minimize = new System.Windows.Forms.Label();
            this.pnl_Bottom = new System.Windows.Forms.Panel();
            this.pnl_EditBoxSettings = new System.Windows.Forms.Panel();
            this.lb_EditBoxSettings = new System.Windows.Forms.Label();
            this.pnl_EditVocs = new System.Windows.Forms.Panel();
            this.lb_EditVocs = new System.Windows.Forms.Label();
            this.pnl_AddVocs = new System.Windows.Forms.Panel();
            this.lb_AddVocs = new System.Windows.Forms.Label();
            this.pnl_View = new System.Windows.Forms.Panel();
            this.pnl_CaptionBar.SuspendLayout();
            this.pnl_Bottom.SuspendLayout();
            this.pnl_EditBoxSettings.SuspendLayout();
            this.pnl_EditVocs.SuspendLayout();
            this.pnl_AddVocs.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_CaptionBar
            // 
            this.pnl_CaptionBar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnl_CaptionBar.Controls.Add(this.pnl_DragBar);
            this.pnl_CaptionBar.Controls.Add(this.lb_CloseWindow);
            this.pnl_CaptionBar.Controls.Add(this.lb_back);
            this.pnl_CaptionBar.Controls.Add(this.lb_Minimize);
            this.pnl_CaptionBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_CaptionBar.Location = new System.Drawing.Point(0, 0);
            this.pnl_CaptionBar.Name = "pnl_CaptionBar";
            this.pnl_CaptionBar.Size = new System.Drawing.Size(1278, 36);
            this.pnl_CaptionBar.TabIndex = 23;
            // 
            // pnl_DragBar
            // 
            this.pnl_DragBar.Location = new System.Drawing.Point(97, 3);
            this.pnl_DragBar.Name = "pnl_DragBar";
            this.pnl_DragBar.Size = new System.Drawing.Size(1122, 30);
            this.pnl_DragBar.TabIndex = 20;
            // 
            // lb_CloseWindow
            // 
            this.lb_CloseWindow.AutoSize = true;
            this.lb_CloseWindow.BackColor = System.Drawing.Color.Transparent;
            this.lb_CloseWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_CloseWindow.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CloseWindow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_CloseWindow.Location = new System.Drawing.Point(1248, 10);
            this.lb_CloseWindow.Name = "lb_CloseWindow";
            this.lb_CloseWindow.Size = new System.Drawing.Size(20, 19);
            this.lb_CloseWindow.TabIndex = 17;
            this.lb_CloseWindow.Text = "X";
            this.lb_CloseWindow.Click += new System.EventHandler(this.lb_CloseWindow_Click);
            // 
            // lb_back
            // 
            this.lb_back.AutoSize = true;
            this.lb_back.BackColor = System.Drawing.Color.Transparent;
            this.lb_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_back.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_back.Location = new System.Drawing.Point(12, 10);
            this.lb_back.Name = "lb_back";
            this.lb_back.Size = new System.Drawing.Size(70, 19);
            this.lb_back.TabIndex = 18;
            this.lb_back.Text = "< Fertig";
            // 
            // lb_Minimize
            // 
            this.lb_Minimize.AutoSize = true;
            this.lb_Minimize.BackColor = System.Drawing.Color.Transparent;
            this.lb_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_Minimize.Font = new System.Drawing.Font("Eras Bold ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Minimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_Minimize.Location = new System.Drawing.Point(1225, 10);
            this.lb_Minimize.Name = "lb_Minimize";
            this.lb_Minimize.Size = new System.Drawing.Size(17, 19);
            this.lb_Minimize.TabIndex = 19;
            this.lb_Minimize.Text = "_";
            // 
            // pnl_Bottom
            // 
            this.pnl_Bottom.Controls.Add(this.pnl_EditBoxSettings);
            this.pnl_Bottom.Controls.Add(this.pnl_EditVocs);
            this.pnl_Bottom.Controls.Add(this.pnl_AddVocs);
            this.pnl_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Bottom.Location = new System.Drawing.Point(0, 618);
            this.pnl_Bottom.Name = "pnl_Bottom";
            this.pnl_Bottom.Size = new System.Drawing.Size(1278, 100);
            this.pnl_Bottom.TabIndex = 24;
            // 
            // pnl_EditBoxSettings
            // 
            this.pnl_EditBoxSettings.BackColor = System.Drawing.Color.LightCoral;
            this.pnl_EditBoxSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_EditBoxSettings.Controls.Add(this.lb_EditBoxSettings);
            this.pnl_EditBoxSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_EditBoxSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_EditBoxSettings.Location = new System.Drawing.Point(852, 0);
            this.pnl_EditBoxSettings.Name = "pnl_EditBoxSettings";
            this.pnl_EditBoxSettings.Size = new System.Drawing.Size(426, 100);
            this.pnl_EditBoxSettings.TabIndex = 2;
            this.pnl_EditBoxSettings.Click += new System.EventHandler(this.act_EditBoxSettings);
            // 
            // lb_EditBoxSettings
            // 
            this.lb_EditBoxSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_EditBoxSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_EditBoxSettings.Font = new System.Drawing.Font("Eras Bold ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EditBoxSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_EditBoxSettings.Location = new System.Drawing.Point(0, 0);
            this.lb_EditBoxSettings.Name = "lb_EditBoxSettings";
            this.lb_EditBoxSettings.Size = new System.Drawing.Size(424, 98);
            this.lb_EditBoxSettings.TabIndex = 2;
            this.lb_EditBoxSettings.Text = "EINSTELLUNGEN\r\nDER BOX";
            this.lb_EditBoxSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_EditBoxSettings.Click += new System.EventHandler(this.act_EditBoxSettings);
            // 
            // pnl_EditVocs
            // 
            this.pnl_EditVocs.BackColor = System.Drawing.Color.Thistle;
            this.pnl_EditVocs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_EditVocs.Controls.Add(this.lb_EditVocs);
            this.pnl_EditVocs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_EditVocs.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_EditVocs.Location = new System.Drawing.Point(426, 0);
            this.pnl_EditVocs.Name = "pnl_EditVocs";
            this.pnl_EditVocs.Size = new System.Drawing.Size(426, 100);
            this.pnl_EditVocs.TabIndex = 1;
            this.pnl_EditVocs.Click += new System.EventHandler(this.act_EditVocs);
            // 
            // lb_EditVocs
            // 
            this.lb_EditVocs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_EditVocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_EditVocs.Font = new System.Drawing.Font("Eras Bold ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EditVocs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_EditVocs.Location = new System.Drawing.Point(0, 0);
            this.lb_EditVocs.Name = "lb_EditVocs";
            this.lb_EditVocs.Size = new System.Drawing.Size(424, 98);
            this.lb_EditVocs.TabIndex = 2;
            this.lb_EditVocs.Text = "VOKABELN\r\nBEARBEITEN";
            this.lb_EditVocs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_EditVocs.Click += new System.EventHandler(this.act_EditVocs);
            // 
            // pnl_AddVocs
            // 
            this.pnl_AddVocs.BackColor = System.Drawing.Color.PaleTurquoise;
            this.pnl_AddVocs.Controls.Add(this.lb_AddVocs);
            this.pnl_AddVocs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_AddVocs.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_AddVocs.Location = new System.Drawing.Point(0, 0);
            this.pnl_AddVocs.Name = "pnl_AddVocs";
            this.pnl_AddVocs.Size = new System.Drawing.Size(426, 100);
            this.pnl_AddVocs.TabIndex = 0;
            this.pnl_AddVocs.Click += new System.EventHandler(this.act_AddVocs);
            // 
            // lb_AddVocs
            // 
            this.lb_AddVocs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_AddVocs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_AddVocs.Font = new System.Drawing.Font("Eras Bold ITC", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AddVocs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_AddVocs.Location = new System.Drawing.Point(0, 0);
            this.lb_AddVocs.Name = "lb_AddVocs";
            this.lb_AddVocs.Size = new System.Drawing.Size(426, 100);
            this.lb_AddVocs.TabIndex = 1;
            this.lb_AddVocs.Text = "VOKABELN\r\nHINZUFÜGEN";
            this.lb_AddVocs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_AddVocs.Click += new System.EventHandler(this.act_AddVocs);
            // 
            // pnl_View
            // 
            this.pnl_View.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_View.Location = new System.Drawing.Point(0, 36);
            this.pnl_View.Name = "pnl_View";
            this.pnl_View.Size = new System.Drawing.Size(1278, 582);
            this.pnl_View.TabIndex = 25;
            // 
            // EditBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnl_View);
            this.Controls.Add(this.pnl_Bottom);
            this.Controls.Add(this.pnl_CaptionBar);
            this.Name = "EditBox";
            this.Size = new System.Drawing.Size(1278, 718);
            this.pnl_CaptionBar.ResumeLayout(false);
            this.pnl_CaptionBar.PerformLayout();
            this.pnl_Bottom.ResumeLayout(false);
            this.pnl_EditBoxSettings.ResumeLayout(false);
            this.pnl_EditVocs.ResumeLayout(false);
            this.pnl_AddVocs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_CaptionBar;
        public System.Windows.Forms.Panel pnl_DragBar;
        private System.Windows.Forms.Label lb_CloseWindow;
        public System.Windows.Forms.Label lb_back;
        public System.Windows.Forms.Label lb_Minimize;
        private System.Windows.Forms.Panel pnl_Bottom;
        private System.Windows.Forms.Panel pnl_EditVocs;
        private System.Windows.Forms.Panel pnl_AddVocs;
        private System.Windows.Forms.Panel pnl_View;
        public System.Windows.Forms.Label lb_AddVocs;
        public System.Windows.Forms.Label lb_EditVocs;
        private System.Windows.Forms.Panel pnl_EditBoxSettings;
        public System.Windows.Forms.Label lb_EditBoxSettings;
    }
}
