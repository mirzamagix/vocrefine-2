namespace Vocrefine_2.UserControls.MainSize
{
    partial class VocabularyImporter
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
            this.pb_example = new System.Windows.Forms.PictureBox();
            this.lb_heading = new System.Windows.Forms.Label();
            this.lb_text = new System.Windows.Forms.Label();
            this.btn_import = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_example)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_example
            // 
            this.pb_example.Image = global::Vocrefine_2.Properties.Resources.example_import_textfile;
            this.pb_example.Location = new System.Drawing.Point(852, 50);
            this.pb_example.Name = "pb_example";
            this.pb_example.Size = new System.Drawing.Size(656, 431);
            this.pb_example.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_example.TabIndex = 0;
            this.pb_example.TabStop = false;
            // 
            // lb_heading
            // 
            this.lb_heading.AutoSize = true;
            this.lb_heading.Font = new System.Drawing.Font("Eras Bold ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_heading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_heading.Location = new System.Drawing.Point(58, 109);
            this.lb_heading.Name = "lb_heading";
            this.lb_heading.Size = new System.Drawing.Size(664, 56);
            this.lb_heading.TabIndex = 1;
            this.lb_heading.Text = "Aus Textdatei importieren";
            // 
            // lb_text
            // 
            this.lb_text.AutoSize = true;
            this.lb_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_text.Location = new System.Drawing.Point(60, 184);
            this.lb_text.Name = "lb_text";
            this.lb_text.Size = new System.Drawing.Size(733, 93);
            this.lb_text.TabIndex = 2;
            this.lb_text.Text = "Wähle eine Textdatei aus um Wörter daraus zu importieren. \r\nBitte achte darauf, d" +
    "ass die Wörter in der Datei genau so \r\nangeordnet sind wie rechts abgebildet";
            // 
            // btn_import
            // 
            this.btn_import.BackColor = System.Drawing.Color.White;
            this.btn_import.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_import.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.btn_import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_import.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_import.Location = new System.Drawing.Point(228, 336);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(326, 75);
            this.btn_import.TabIndex = 3;
            this.btn_import.Text = "Datei auswählen";
            this.btn_import.UseVisualStyleBackColor = false;
            this.btn_import.Click += new System.EventHandler(this.btn_import_Click);
            // 
            // VocabularyImporter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1550, 520);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.lb_text);
            this.Controls.Add(this.lb_heading);
            this.Controls.Add(this.pb_example);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VocabularyImporter";
            this.Text = "Vokabeln importieren";
            ((System.ComponentModel.ISupportInitialize)(this.pb_example)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_example;
        private System.Windows.Forms.Label lb_heading;
        private System.Windows.Forms.Label lb_text;
        private System.Windows.Forms.Button btn_import;
    }
}