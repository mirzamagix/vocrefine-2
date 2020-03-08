namespace Vocrefine_2
{
    partial class CreateNew
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
            this.lb_save = new System.Windows.Forms.Label();
            this.pnl_topside = new System.Windows.Forms.Panel();
            this.pnl_CaptionBar = new System.Windows.Forms.Panel();
            this.pnl_DragBar = new System.Windows.Forms.Panel();
            this.lb_CloseWindow = new System.Windows.Forms.Label();
            this.lb_back = new System.Windows.Forms.Label();
            this.lb_Minimize = new System.Windows.Forms.Label();
            this.comb_Fremdsprache = new System.Windows.Forms.ComboBox();
            this.comb_EigeneSprache = new System.Windows.Forms.ComboBox();
            this.lb_Warnung = new System.Windows.Forms.Label();
            this.pnl_addVocs = new System.Windows.Forms.Panel();
            this.btn_AddVocs_Add = new System.Windows.Forms.Button();
            this.lb_AddNew_Warnung = new System.Windows.Forms.Label();
            this.lb_AddVocs_Switch = new System.Windows.Forms.Label();
            this.lb_AddVocs_FS = new System.Windows.Forms.Label();
            this.lb_AddVocs_ES = new System.Windows.Forms.Label();
            this.tb_AddVocs_FS = new System.Windows.Forms.TextBox();
            this.tb_AddVocs_ES = new System.Windows.Forms.TextBox();
            this.lb_AddVocs = new System.Windows.Forms.Label();
            this.tb_Fremdsprache = new System.Windows.Forms.TextBox();
            this.lb_Fremdsprache = new System.Windows.Forms.Label();
            this.tb_EigeneSprache = new System.Windows.Forms.TextBox();
            this.lb_EigeneSprache = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_Title = new System.Windows.Forms.Label();
            this.pnl_save = new System.Windows.Forms.Panel();
            this.ttp_Info = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_topside.SuspendLayout();
            this.pnl_CaptionBar.SuspendLayout();
            this.pnl_addVocs.SuspendLayout();
            this.pnl_save.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_save
            // 
            this.lb_save.AutoSize = true;
            this.lb_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_save.Font = new System.Drawing.Font("Eras Bold ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_save.ForeColor = System.Drawing.Color.White;
            this.lb_save.Location = new System.Drawing.Point(557, 29);
            this.lb_save.Name = "lb_save";
            this.lb_save.Size = new System.Drawing.Size(160, 40);
            this.lb_save.TabIndex = 0;
            this.lb_save.Text = "WEITER";
            this.lb_save.Click += new System.EventHandler(this.act_saveBox);
            // 
            // pnl_topside
            // 
            this.pnl_topside.Controls.Add(this.pnl_CaptionBar);
            this.pnl_topside.Controls.Add(this.comb_Fremdsprache);
            this.pnl_topside.Controls.Add(this.comb_EigeneSprache);
            this.pnl_topside.Controls.Add(this.lb_Warnung);
            this.pnl_topside.Controls.Add(this.pnl_addVocs);
            this.pnl_topside.Controls.Add(this.tb_Fremdsprache);
            this.pnl_topside.Controls.Add(this.lb_Fremdsprache);
            this.pnl_topside.Controls.Add(this.tb_EigeneSprache);
            this.pnl_topside.Controls.Add(this.lb_EigeneSprache);
            this.pnl_topside.Controls.Add(this.tb_Name);
            this.pnl_topside.Controls.Add(this.lb_Name);
            this.pnl_topside.Controls.Add(this.lb_Title);
            this.pnl_topside.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnl_topside.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_topside.Location = new System.Drawing.Point(0, 0);
            this.pnl_topside.Name = "pnl_topside";
            this.pnl_topside.Size = new System.Drawing.Size(1278, 618);
            this.pnl_topside.TabIndex = 1;
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
            this.lb_CloseWindow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
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
            this.lb_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.lb_back.Location = new System.Drawing.Point(12, 10);
            this.lb_back.Name = "lb_back";
            this.lb_back.Size = new System.Drawing.Size(79, 19);
            this.lb_back.TabIndex = 18;
            this.lb_back.Text = "< Zurück";
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
            // comb_Fremdsprache
            // 
            this.comb_Fremdsprache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comb_Fremdsprache.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_Fremdsprache.ForeColor = System.Drawing.SystemColors.Highlight;
            this.comb_Fremdsprache.FormattingEnabled = true;
            this.comb_Fremdsprache.Items.AddRange(new object[] {
            "Manuell eingeben >>",
            "Albanisch (Toskisch)",
            "Arabisch",
            "Armenisch",
            "Aseri (Aserbaidschanisch)",
            "Bosnisch",
            "Bulgarisch",
            "Chinesisch",
            "Dänisch",
            "Dari (Neupersisch)",
            "Deutsch",
            "Englisch",
            "Estnisch",
            "Finnisch",
            "Flämisch",
            "Französisch",
            "Georgisch",
            "Gilbertesisch",
            "Griechisch",
            "Hebräisch (Iwrith)",
            "Hindi",
            "Irisch",
            "Isländisch",
            "Italienisch",
            "Japanisch",
            "Kasachisch",
            "Katalanisch",
            "Khmer",
            "Kirgiesisch",
            "Koreanisch",
            "Kroatisch",
            "Kurdisch",
            "Laotisch",
            "Latain",
            "Lettisch",
            "Litauisch",
            "Makedonisch",
            "Maltesisch",
            "Moldauisch",
            "Mongolisch",
            "Neugriechisch",
            "Niederländisch",
            "Norwegisch",
            "Persisch",
            "Polnisch",
            "Portugiesisch",
            "Quechua (Indianersprache)",
            "Rumänisch",
            "Russisch",
            "Schwedisch",
            "Serbisch",
            "Singhalesisch",
            "Slowakisch",
            "Slowenisch",
            "Spanisch",
            "Tadschiekisch",
            "Thailändisch",
            "Tschechisch",
            "Türkisch",
            "Turkmenisch",
            "Ukrainisch",
            "Ungarisch",
            "Urdu",
            "Usbekisch",
            "Vietnamesisch"});
            this.comb_Fremdsprache.Location = new System.Drawing.Point(202, 245);
            this.comb_Fremdsprache.Name = "comb_Fremdsprache";
            this.comb_Fremdsprache.Size = new System.Drawing.Size(222, 29);
            this.comb_Fremdsprache.TabIndex = 17;
            this.comb_Fremdsprache.Text = "Manuell eingeben >>";
            this.comb_Fremdsprache.TextChanged += new System.EventHandler(this.act_IsFilled);
            // 
            // comb_EigeneSprache
            // 
            this.comb_EigeneSprache.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comb_EigeneSprache.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comb_EigeneSprache.ForeColor = System.Drawing.SystemColors.Highlight;
            this.comb_EigeneSprache.FormattingEnabled = true;
            this.comb_EigeneSprache.Items.AddRange(new object[] {
            "Manuell eingeben >>",
            "Albanisch (Toskisch)",
            "Arabisch",
            "Armenisch",
            "Aseri (Aserbaidschanisch)",
            "Bosnisch",
            "Bulgarisch",
            "Chinesisch",
            "Dänisch",
            "Dari (Neupersisch)",
            "Deutsch",
            "Englisch",
            "Estnisch",
            "Finnisch",
            "Flämisch",
            "Französisch",
            "Georgisch",
            "Gilbertesisch",
            "Griechisch",
            "Hebräisch (Iwrith)",
            "Hindi",
            "Irisch",
            "Isländisch",
            "Italienisch",
            "Japanisch",
            "Kasachisch",
            "Katalanisch",
            "Khmer",
            "Kirgiesisch",
            "Koreanisch",
            "Kroatisch",
            "Kurdisch",
            "Laotisch",
            "Latain",
            "Lettisch",
            "Litauisch",
            "Makedonisch",
            "Maltesisch",
            "Moldauisch",
            "Mongolisch",
            "Neugriechisch",
            "Niederländisch",
            "Norwegisch",
            "Persisch",
            "Polnisch",
            "Portugiesisch",
            "Quechua (Indianersprache)",
            "Rumänisch",
            "Russisch",
            "Schwedisch",
            "Serbisch",
            "Singhalesisch",
            "Slowakisch",
            "Slowenisch",
            "Spanisch",
            "Tadschiekisch",
            "Thailändisch",
            "Tschechisch",
            "Türkisch",
            "Turkmenisch",
            "Ukrainisch",
            "Ungarisch",
            "Urdu",
            "Usbekisch",
            "Vietnamesisch"});
            this.comb_EigeneSprache.Location = new System.Drawing.Point(202, 195);
            this.comb_EigeneSprache.Name = "comb_EigeneSprache";
            this.comb_EigeneSprache.Size = new System.Drawing.Size(222, 29);
            this.comb_EigeneSprache.TabIndex = 17;
            this.comb_EigeneSprache.Text = "Manuell eingeben >>";
            this.comb_EigeneSprache.TextChanged += new System.EventHandler(this.act_IsFilled);
            // 
            // lb_Warnung
            // 
            this.lb_Warnung.AutoSize = true;
            this.lb_Warnung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_Warnung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Warnung.Location = new System.Drawing.Point(44, 103);
            this.lb_Warnung.Name = "lb_Warnung";
            this.lb_Warnung.Size = new System.Drawing.Size(380, 15);
            this.lb_Warnung.TabIndex = 14;
            this.lb_Warnung.Text = "ACHTUNG: Diese Angaben können später nicht mehr geändert werden";
            this.lb_Warnung.Click += new System.EventHandler(this.lb_AddVocs_Switch_Click);
            // 
            // pnl_addVocs
            // 
            this.pnl_addVocs.Controls.Add(this.btn_AddVocs_Add);
            this.pnl_addVocs.Controls.Add(this.lb_AddNew_Warnung);
            this.pnl_addVocs.Controls.Add(this.lb_AddVocs_Switch);
            this.pnl_addVocs.Controls.Add(this.lb_AddVocs_FS);
            this.pnl_addVocs.Controls.Add(this.lb_AddVocs_ES);
            this.pnl_addVocs.Controls.Add(this.tb_AddVocs_FS);
            this.pnl_addVocs.Controls.Add(this.tb_AddVocs_ES);
            this.pnl_addVocs.Controls.Add(this.lb_AddVocs);
            this.pnl_addVocs.Location = new System.Drawing.Point(16, 319);
            this.pnl_addVocs.Name = "pnl_addVocs";
            this.pnl_addVocs.Size = new System.Drawing.Size(1244, 234);
            this.pnl_addVocs.TabIndex = 14;
            this.pnl_addVocs.Visible = false;
            // 
            // btn_AddVocs_Add
            // 
            this.btn_AddVocs_Add.BackColor = System.Drawing.Color.DarkGray;
            this.btn_AddVocs_Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddVocs_Add.Enabled = false;
            this.btn_AddVocs_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_AddVocs_Add.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddVocs_Add.ForeColor = System.Drawing.Color.White;
            this.btn_AddVocs_Add.Location = new System.Drawing.Point(971, 173);
            this.btn_AddVocs_Add.Name = "btn_AddVocs_Add";
            this.btn_AddVocs_Add.Size = new System.Drawing.Size(241, 37);
            this.btn_AddVocs_Add.TabIndex = 15;
            this.btn_AddVocs_Add.Text = "VOKABEL HINZUFÜGEN";
            this.ttp_Info.SetToolTip(this.btn_AddVocs_Add, "Vokabeln hinzufügen");
            this.btn_AddVocs_Add.UseVisualStyleBackColor = false;
            this.btn_AddVocs_Add.Click += new System.EventHandler(this.btn_AddVocs_Add_Click);
            // 
            // lb_AddNew_Warnung
            // 
            this.lb_AddNew_Warnung.AutoSize = true;
            this.lb_AddNew_Warnung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_AddNew_Warnung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AddNew_Warnung.Location = new System.Drawing.Point(28, 54);
            this.lb_AddNew_Warnung.Name = "lb_AddNew_Warnung";
            this.lb_AddNew_Warnung.Size = new System.Drawing.Size(438, 30);
            this.lb_AddNew_Warnung.TabIndex = 14;
            this.lb_AddNew_Warnung.Text = "Sie können später jeder Zeit änderungen an der Vokabelliste vornehmen.\r\nBemerkung" +
    "en oder Komentare in eckigen Klammern hinter die Vokabel schreiben.";
            this.lb_AddNew_Warnung.Click += new System.EventHandler(this.lb_AddVocs_Switch_Click);
            // 
            // lb_AddVocs_Switch
            // 
            this.lb_AddVocs_Switch.AutoSize = true;
            this.lb_AddVocs_Switch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_AddVocs_Switch.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AddVocs_Switch.Location = new System.Drawing.Point(604, 141);
            this.lb_AddVocs_Switch.Name = "lb_AddVocs_Switch";
            this.lb_AddVocs_Switch.Size = new System.Drawing.Size(35, 22);
            this.lb_AddVocs_Switch.TabIndex = 14;
            this.lb_AddVocs_Switch.Text = "< >";
            this.lb_AddVocs_Switch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ttp_Info.SetToolTip(this.lb_AddVocs_Switch, "Eingabefelder vertauschen");
            this.lb_AddVocs_Switch.Click += new System.EventHandler(this.lb_AddVocs_Switch_Click);
            // 
            // lb_AddVocs_FS
            // 
            this.lb_AddVocs_FS.AutoSize = true;
            this.lb_AddVocs_FS.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AddVocs_FS.Location = new System.Drawing.Point(658, 113);
            this.lb_AddVocs_FS.Name = "lb_AddVocs_FS";
            this.lb_AddVocs_FS.Size = new System.Drawing.Size(135, 22);
            this.lb_AddVocs_FS.TabIndex = 13;
            this.lb_AddVocs_FS.Text = "Fremdsprache:";
            // 
            // lb_AddVocs_ES
            // 
            this.lb_AddVocs_ES.AutoSize = true;
            this.lb_AddVocs_ES.Font = new System.Drawing.Font("Eras Medium ITC", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AddVocs_ES.Location = new System.Drawing.Point(34, 113);
            this.lb_AddVocs_ES.Name = "lb_AddVocs_ES";
            this.lb_AddVocs_ES.Size = new System.Drawing.Size(144, 22);
            this.lb_AddVocs_ES.TabIndex = 12;
            this.lb_AddVocs_ES.Text = "Eigene Sprache:";
            // 
            // tb_AddVocs_FS
            // 
            this.tb_AddVocs_FS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AddVocs_FS.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_AddVocs_FS.Location = new System.Drawing.Point(652, 138);
            this.tb_AddVocs_FS.MaxLength = 60;
            this.tb_AddVocs_FS.Name = "tb_AddVocs_FS";
            this.tb_AddVocs_FS.Size = new System.Drawing.Size(560, 29);
            this.tb_AddVocs_FS.TabIndex = 11;
            this.tb_AddVocs_FS.TextChanged += new System.EventHandler(this.act_AddVocs_isFilled);
            this.tb_AddVocs_FS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.act_AddVocsKeyDown);
            // 
            // tb_AddVocs_ES
            // 
            this.tb_AddVocs_ES.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AddVocs_ES.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_AddVocs_ES.Location = new System.Drawing.Point(28, 138);
            this.tb_AddVocs_ES.MaxLength = 60;
            this.tb_AddVocs_ES.Name = "tb_AddVocs_ES";
            this.tb_AddVocs_ES.Size = new System.Drawing.Size(560, 29);
            this.tb_AddVocs_ES.TabIndex = 10;
            this.tb_AddVocs_ES.TextChanged += new System.EventHandler(this.act_AddVocs_isFilled);
            this.tb_AddVocs_ES.KeyDown += new System.Windows.Forms.KeyEventHandler(this.act_AddVocsKeyDown);
            // 
            // lb_AddVocs
            // 
            this.lb_AddVocs.AutoSize = true;
            this.lb_AddVocs.Font = new System.Drawing.Font("Forte", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_AddVocs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.lb_AddVocs.Location = new System.Drawing.Point(21, 13);
            this.lb_AddVocs.Name = "lb_AddVocs";
            this.lb_AddVocs.Size = new System.Drawing.Size(414, 38);
            this.lb_AddVocs.TabIndex = 8;
            this.lb_AddVocs.Text = "Erste Vokabeln hinzufügen";
            // 
            // tb_Fremdsprache
            // 
            this.tb_Fremdsprache.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Fremdsprache.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_Fremdsprache.Location = new System.Drawing.Point(430, 245);
            this.tb_Fremdsprache.MaxLength = 30;
            this.tb_Fremdsprache.Name = "tb_Fremdsprache";
            this.tb_Fremdsprache.Size = new System.Drawing.Size(798, 29);
            this.tb_Fremdsprache.TabIndex = 13;
            this.tb_Fremdsprache.TextChanged += new System.EventHandler(this.act_IsFilled);
            // 
            // lb_Fremdsprache
            // 
            this.lb_Fremdsprache.AutoSize = true;
            this.lb_Fremdsprache.Font = new System.Drawing.Font("Eras Medium ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Fremdsprache.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.lb_Fremdsprache.Location = new System.Drawing.Point(50, 246);
            this.lb_Fremdsprache.Name = "lb_Fremdsprache";
            this.lb_Fremdsprache.Size = new System.Drawing.Size(146, 24);
            this.lb_Fremdsprache.TabIndex = 12;
            this.lb_Fremdsprache.Text = "Fremdsprache:";
            // 
            // tb_EigeneSprache
            // 
            this.tb_EigeneSprache.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_EigeneSprache.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_EigeneSprache.Location = new System.Drawing.Point(430, 195);
            this.tb_EigeneSprache.MaxLength = 30;
            this.tb_EigeneSprache.Name = "tb_EigeneSprache";
            this.tb_EigeneSprache.Size = new System.Drawing.Size(798, 29);
            this.tb_EigeneSprache.TabIndex = 11;
            this.tb_EigeneSprache.TextChanged += new System.EventHandler(this.act_IsFilled);
            // 
            // lb_EigeneSprache
            // 
            this.lb_EigeneSprache.AutoSize = true;
            this.lb_EigeneSprache.Font = new System.Drawing.Font("Eras Medium ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_EigeneSprache.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.lb_EigeneSprache.Location = new System.Drawing.Point(37, 196);
            this.lb_EigeneSprache.Name = "lb_EigeneSprache";
            this.lb_EigeneSprache.Size = new System.Drawing.Size(159, 24);
            this.lb_EigeneSprache.TabIndex = 10;
            this.lb_EigeneSprache.Text = "Eigene Sprache:";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_Name.Location = new System.Drawing.Point(202, 145);
            this.tb_Name.MaxLength = 30;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(1026, 29);
            this.tb_Name.TabIndex = 9;
            this.tb_Name.TextChanged += new System.EventHandler(this.act_IsFilled);
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Font = new System.Drawing.Font("Eras Medium ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.lb_Name.Location = new System.Drawing.Point(93, 146);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(103, 24);
            this.lb_Name.TabIndex = 8;
            this.lb_Name.Text = "Boxname:";
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Font = new System.Drawing.Font("Forte", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.lb_Title.Location = new System.Drawing.Point(37, 66);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(306, 38);
            this.lb_Title.TabIndex = 7;
            this.lb_Title.Text = "Neue Box erstellen";
            // 
            // pnl_save
            // 
            this.pnl_save.BackColor = System.Drawing.Color.Gray;
            this.pnl_save.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_save.Controls.Add(this.lb_save);
            this.pnl_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnl_save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_save.Location = new System.Drawing.Point(0, 618);
            this.pnl_save.Name = "pnl_save";
            this.pnl_save.Size = new System.Drawing.Size(1278, 100);
            this.pnl_save.TabIndex = 0;
            this.pnl_save.Click += new System.EventHandler(this.act_saveBox);
            // 
            // CreateNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnl_topside);
            this.Controls.Add(this.pnl_save);
            this.Name = "CreateNew";
            this.Size = new System.Drawing.Size(1278, 718);
            this.pnl_topside.ResumeLayout(false);
            this.pnl_topside.PerformLayout();
            this.pnl_CaptionBar.ResumeLayout(false);
            this.pnl_CaptionBar.PerformLayout();
            this.pnl_addVocs.ResumeLayout(false);
            this.pnl_addVocs.PerformLayout();
            this.pnl_save.ResumeLayout(false);
            this.pnl_save.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_topside;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.TextBox tb_Fremdsprache;
        private System.Windows.Forms.Label lb_Fremdsprache;
        private System.Windows.Forms.TextBox tb_EigeneSprache;
        private System.Windows.Forms.Label lb_EigeneSprache;
        private System.Windows.Forms.Panel pnl_addVocs;
        private System.Windows.Forms.Label lb_AddVocs;
        private System.Windows.Forms.TextBox tb_AddVocs_FS;
        private System.Windows.Forms.TextBox tb_AddVocs_ES;
        private System.Windows.Forms.Label lb_AddVocs_FS;
        private System.Windows.Forms.Label lb_AddVocs_ES;
        private System.Windows.Forms.Label lb_AddVocs_Switch;
        private System.Windows.Forms.Button btn_AddVocs_Add;
        private System.Windows.Forms.Label lb_Warnung;
        private System.Windows.Forms.Label lb_AddNew_Warnung;
        private System.Windows.Forms.Label lb_save;
        private System.Windows.Forms.Panel pnl_save;
        private System.Windows.Forms.ToolTip ttp_Info;
        private System.Windows.Forms.ComboBox comb_EigeneSprache;
        private System.Windows.Forms.ComboBox comb_Fremdsprache;
        private System.Windows.Forms.Panel pnl_CaptionBar;
        public System.Windows.Forms.Panel pnl_DragBar;
        private System.Windows.Forms.Label lb_CloseWindow;
        public System.Windows.Forms.Label lb_back;
        public System.Windows.Forms.Label lb_Minimize;
    }
}
