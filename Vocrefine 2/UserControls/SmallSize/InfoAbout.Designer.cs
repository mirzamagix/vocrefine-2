namespace Vocrefine_2
{
    partial class InfoAbout
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
            this.linkl_Homepage = new System.Windows.Forms.LinkLabel();
            this.lb_Copyright = new System.Windows.Forms.Label();
            this.lb_FirstRelease = new System.Windows.Forms.Label();
            this.lb_RecentRelease = new System.Windows.Forms.Label();
            this.lb_Version = new System.Windows.Forms.Label();
            this.lb_DevelopedBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkl_Homepage
            // 
            this.linkl_Homepage.AutoSize = true;
            this.linkl_Homepage.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.linkl_Homepage.Location = new System.Drawing.Point(16, 111);
            this.linkl_Homepage.Name = "linkl_Homepage";
            this.linkl_Homepage.Size = new System.Drawing.Size(190, 17);
            this.linkl_Homepage.TabIndex = 7;
            this.linkl_Homepage.TabStop = true;
            this.linkl_Homepage.Text = "Homepage: www.mirza-can.de/";
            this.linkl_Homepage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Copyright
            // 
            this.lb_Copyright.AutoSize = true;
            this.lb_Copyright.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Copyright.Location = new System.Drawing.Point(16, 34);
            this.lb_Copyright.Name = "lb_Copyright";
            this.lb_Copyright.Size = new System.Drawing.Size(125, 17);
            this.lb_Copyright.TabIndex = 2;
            this.lb_Copyright.Text = "( C ) Copyright 2019";
            // 
            // lb_FirstRelease
            // 
            this.lb_FirstRelease.AutoSize = true;
            this.lb_FirstRelease.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_FirstRelease.Location = new System.Drawing.Point(16, 91);
            this.lb_FirstRelease.Name = "lb_FirstRelease";
            this.lb_FirstRelease.Size = new System.Drawing.Size(147, 17);
            this.lb_FirstRelease.TabIndex = 3;
            this.lb_FirstRelease.Text = "First release: 12.12.2019";
            // 
            // lb_RecentRelease
            // 
            this.lb_RecentRelease.AutoSize = true;
            this.lb_RecentRelease.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RecentRelease.Location = new System.Drawing.Point(16, 72);
            this.lb_RecentRelease.Name = "lb_RecentRelease";
            this.lb_RecentRelease.Size = new System.Drawing.Size(192, 17);
            this.lb_RecentRelease.TabIndex = 4;
            this.lb_RecentRelease.Text = "Most recent update: 29.12.2019";
            // 
            // lb_Version
            // 
            this.lb_Version.AutoSize = true;
            this.lb_Version.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Version.Location = new System.Drawing.Point(16, 53);
            this.lb_Version.Name = "lb_Version";
            this.lb_Version.Size = new System.Drawing.Size(95, 17);
            this.lb_Version.TabIndex = 5;
            this.lb_Version.Text = "Version: 1.1.0.0";
            // 
            // lb_DevelopedBy
            // 
            this.lb_DevelopedBy.AutoSize = true;
            this.lb_DevelopedBy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DevelopedBy.Location = new System.Drawing.Point(16, 15);
            this.lb_DevelopedBy.Name = "lb_DevelopedBy";
            this.lb_DevelopedBy.Size = new System.Drawing.Size(159, 17);
            this.lb_DevelopedBy.TabIndex = 6;
            this.lb_DevelopedBy.Text = "Developed by Mirza Polat";
            // 
            // InfoAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkl_Homepage);
            this.Controls.Add(this.lb_Copyright);
            this.Controls.Add(this.lb_FirstRelease);
            this.Controls.Add(this.lb_RecentRelease);
            this.Controls.Add(this.lb_Version);
            this.Controls.Add(this.lb_DevelopedBy);
            this.Name = "InfoAbout";
            this.Size = new System.Drawing.Size(445, 154);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkl_Homepage;
        private System.Windows.Forms.Label lb_Copyright;
        private System.Windows.Forms.Label lb_FirstRelease;
        private System.Windows.Forms.Label lb_RecentRelease;
        private System.Windows.Forms.Label lb_Version;
        private System.Windows.Forms.Label lb_DevelopedBy;
    }
}
