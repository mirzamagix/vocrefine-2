using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vocrefine_2
{
    public partial class EditVocs : UserControl
    {
        Button lastNativeButton = null;
        Button lastTransButton = null;

        string settingspath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Vocrefine 2\Settings\Settings.db";
        string appdatapath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Vocrefine 2\Box\";
        string dbFilePath;

        Dictionary<string, string> Fach1 = new Dictionary<string, string>();
        Dictionary<string, string> Fach2 = new Dictionary<string, string>();
        Dictionary<string, string> Fach3 = new Dictionary<string, string>();
        Dictionary<string, string> Fach4 = new Dictionary<string, string>();
        Dictionary<string, string> Fach5 = new Dictionary<string, string>();
        Dictionary<string, string> Fach6 = new Dictionary<string, string>();
        Dictionary<string, string> Fach7 = new Dictionary<string, string>();
        Dictionary<string, string> Fach8 = new Dictionary<string, string>();
        Dictionary<string, string> Fach9 = new Dictionary<string, string>();
        Dictionary<string, string> Fach10 = new Dictionary<string, string>();

        int classNumber = 0;
        string currentVoc = "";

        public EditVocs(string boxNameFromRecent)
        {
            InitializeComponent();

            dbFilePath = appdatapath + boxNameFromRecent + ".db";

            Fach1 = DBAdapter.GetVocsByClass(dbFilePath, 1);
            Fach2 = DBAdapter.GetVocsByClass(dbFilePath, 2);
            Fach3 = DBAdapter.GetVocsByClass(dbFilePath, 3);
            Fach4 = DBAdapter.GetVocsByClass(dbFilePath, 4);
            Fach5 = DBAdapter.GetVocsByClass(dbFilePath, 5);
            Fach6 = DBAdapter.GetVocsByClass(dbFilePath, 6);
            Fach7 = DBAdapter.GetVocsByClass(dbFilePath, 7);
            Fach8 = DBAdapter.GetVocsByClass(dbFilePath, 8);
            Fach9 = DBAdapter.GetVocsByClass(dbFilePath, 9);
            Fach10 = DBAdapter.GetVocsByClass(dbFilePath, 10);

            UpdateElements();

            this.BackColor = DBAdapter.GetSettingsColorEntry(settingspath, "EditVocs");
            flp_VocabList.BackColor = DBAdapter.GetSettingsColorEntry(settingspath, "EditVocs");
            gb_Info.BackColor = DBAdapter.GetSettingsColorEntry(settingspath, "EditVocs");
            pnl_Info.BackColor = DBAdapter.GetSettingsColorEntry(settingspath, "EditVocs");
            tb_EigeneSprache.BackColor = DBAdapter.GetSettingsColorEntry(settingspath, "EditVocs");
            tb_Fremdsprache.BackColor = DBAdapter.GetSettingsColorEntry(settingspath, "EditVocs");
        }

        /// <summary>
        /// Synchronisiert Elemente im FlowLayoutPanel mit den Listen
        /// </summary>
        private void UpdateElements()
        {
            flp_VocabList.Controls.Clear();

            AddButtonsToList(Fach1, 1);
            AddButtonsToList(Fach2, 2);
            AddButtonsToList(Fach3, 3);
            AddButtonsToList(Fach4, 4);
            AddButtonsToList(Fach5, 5);
            AddButtonsToList(Fach6, 6);
            AddButtonsToList(Fach7, 7);
            AddButtonsToList(Fach8, 8);
            AddButtonsToList(Fach9, 9);
            AddButtonsToList(Fach10, 10);
        }

        /// <summary>
        /// Fügt Buttons hinzu
        /// </summary>
        /// <param name="Vocabulary"></param>
        private void AddButtonsToList(Dictionary<string, string> Vocabulary, int iClass)
        {
            Dictionary<string, string>.KeyCollection keyColl = Vocabulary.Keys;
            foreach (string sEigene in keyColl)
            {
                Button b = addButton("[" + iClass.ToString() + "] " + sEigene, sEigene);
                b.Click += new EventHandler(act_ClickOnNativeElement);
                flp_VocabList.Controls.Add(b);

                string sFremd = Vocabulary[sEigene];
                Button c = addButton(sFremd, iClass.ToString() + sEigene);
                c.Click += new EventHandler(act_ClickOnTranslationElement);
                flp_VocabList.Controls.Add(c);

                b.Tag = c;
                c.Tag = b;
            }
        }

        /// <summary>
        /// Synchronisiert Datenbank mit den Listen
        /// </summary>
        private void UpdateDatabase()
        {
            DBAdapter.DeleteAllVocables(dbFilePath);

            DBAdapter.AddVocabulary(dbFilePath, Fach1, 1);
            DBAdapter.AddVocabulary(dbFilePath, Fach2, 2);
            DBAdapter.AddVocabulary(dbFilePath, Fach3, 3);
            DBAdapter.AddVocabulary(dbFilePath, Fach4, 4);
            DBAdapter.AddVocabulary(dbFilePath, Fach5, 5);
            DBAdapter.AddVocabulary(dbFilePath, Fach6, 6);
            DBAdapter.AddVocabulary(dbFilePath, Fach7, 7);
            DBAdapter.AddVocabulary(dbFilePath, Fach8, 8);
            DBAdapter.AddVocabulary(dbFilePath, Fach9, 9);
            DBAdapter.AddVocabulary(dbFilePath, Fach10, 10);
        }

        /// <summary>
        /// Creates the needed Button
        /// </summary>
        /// <param name="sName"></param>
        /// <returns></returns>
        Button addButton(string sText, string sTag)
        {
            Button b = new Button();
            b.BackColor = DBAdapter.GetSettingsColorEntry(settingspath, "EditVocs");
            b.FlatStyle = FlatStyle.Flat;
            b.Font = new Font("Consolas", 9, FontStyle.Regular);
            b.ForeColor = SystemColors.ControlText;
            b.TextAlign = ContentAlignment.MiddleLeft;
            b.Text = sText;
            b.Tag = sTag;
            b.Size = new Size(345, 30);
            if (sText.Length > 45) b.Size = new Size(345, 40);

            return b;
        }

        /// <summary>
        /// If Clicked on a Native Element
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_ClickOnNativeElement(object sender, EventArgs e)
        {
            lastNativeButton = (Button)sender;
            lastTransButton = (Button)lastNativeButton.Tag;
            classNumber = Convert.ToInt32(((Button)sender).Text.Substring(1, 1));
            currentVoc = lastNativeButton.Text.Substring(4).Trim();
            string sTranslation = "";

            // Holt die Fremd-Vokabel
            switch (classNumber)
            {
                case 1:
                    sTranslation = Fach1[currentVoc];
                    break;
                case 2:
                    sTranslation = Fach2[currentVoc];
                    break;
                case 3:
                    sTranslation = Fach3[currentVoc];
                    break;
                case 4:
                    sTranslation = Fach4[currentVoc];
                    break;
                case 5:
                    sTranslation = Fach5[currentVoc];
                    break;
                case 6:
                    sTranslation = Fach6[currentVoc];
                    break;
                case 7:
                    sTranslation = Fach7[currentVoc];
                    break;
                case 8:
                    sTranslation = Fach8[currentVoc];
                    break;
                case 9:
                    sTranslation = Fach9[currentVoc];
                    break;
                case 10:
                    sTranslation = Fach10[currentVoc];
                    break;
            }

            tb_EigeneSprache.Text = currentVoc;
            tb_Fremdsprache.Text = sTranslation;

            lb_title_ES.Text = DBAdapter.GetLabelEntry(dbFilePath, "nativeLanguage") + ":";
            lb_title_FS.Text = DBAdapter.GetLabelEntry(dbFilePath, "translationLanguage") + ":";

            btn_save.Enabled = false;
            btn_save.ForeColor = Color.Gray;
            pnl_Info.Visible = true;
            lb_Info_Title.Text = "Vokabel bearbeiten:";
        }

        /// <summary>
        /// If Clicked on a Translation Element
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_ClickOnTranslationElement(object sender, EventArgs e)
        {
            lastTransButton = (Button)sender;
            lastNativeButton = (Button)lastTransButton.Tag;

            classNumber = Convert.ToInt32(lastNativeButton.Text.Substring(1, 1));
            currentVoc = lastNativeButton.Text.Substring(4).Trim();
            string sTranslation = ((Button)sender).Text;

            tb_EigeneSprache.Text = currentVoc;
            tb_Fremdsprache.Text = sTranslation;

            lb_title_ES.Text = DBAdapter.GetLabelEntry(dbFilePath, "nativeLanguage") + ":";
            lb_title_FS.Text = DBAdapter.GetLabelEntry(dbFilePath, "translationLanguage") + ":";

            btn_save.Enabled = false;
            btn_save.ForeColor = Color.Gray;
            pnl_Info.Visible = true;
            lb_Info_Title.Text = "Vokabel bearbeiten:";
        }

        /// <summary>
        /// Wenn etwas an den Vokabeln geändert wird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_ChagedText(object sender, EventArgs e)
        {
            btn_save.Enabled = true;
            btn_save.ForeColor = SystemColors.ControlText;
        }

        /// <summary>
        /// Löscht eine Vokabel Aus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_DeleteVoc(object sender, EventArgs e)
        {
            switch (classNumber)
            {
                case 1:
                    Fach1.Remove(currentVoc);
                    if (Fach1.Count == 0) DBAdapter.UpdateLabel(dbFilePath, "lastClass", "none");
                    break;
                case 2:
                    Fach2.Remove(currentVoc);
                    if (Fach2.Count == 0) DBAdapter.UpdateLabel(dbFilePath, "lastClass", "none");
                    break;
                case 3:
                    Fach3.Remove(currentVoc);
                    if (Fach3.Count == 0) DBAdapter.UpdateLabel(dbFilePath, "lastClass", "none");
                    break;
                case 4:
                    Fach4.Remove(currentVoc);
                    if (Fach4.Count == 0) DBAdapter.UpdateLabel(dbFilePath, "lastClass", "none");
                    break;
                case 5:
                    Fach5.Remove(currentVoc);
                    if (Fach5.Count == 0) DBAdapter.UpdateLabel(dbFilePath, "lastClass", "none");
                    break;
                case 6:
                    Fach6.Remove(currentVoc);
                    if (Fach6.Count == 0) DBAdapter.UpdateLabel(dbFilePath, "lastClass", "none");
                    break;
                case 7:
                    Fach7.Remove(currentVoc);
                    if (Fach7.Count == 0) DBAdapter.UpdateLabel(dbFilePath, "lastClass", "none");
                    break;
                case 8:
                    Fach8.Remove(currentVoc);
                    if (Fach8.Count == 0) DBAdapter.UpdateLabel(dbFilePath, "lastClass", "none");
                    break;
                case 9:
                    Fach9.Remove(currentVoc);
                    if (Fach9.Count == 0) DBAdapter.UpdateLabel(dbFilePath, "lastClass", "none");
                    break;
                case 10:
                    Fach10.Remove(currentVoc);
                    if (Fach10.Count == 0) DBAdapter.UpdateLabel(dbFilePath, "lastClass", "none");
                    break;
            }

            UpdateElements();
            UpdateDatabase();

            pnl_Info.Visible = false;
            lb_Info_Title.Text = "Wählen sie eine Vokabel aus, um sie zu bearbeiten";
        }

        /// <summary>
        /// Speichert die Änderungen an der Vokabel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_SaveVoc(object sender, EventArgs e)
        {
            Miscellaneous.DoThisSpaceStuff(ref tb_EigeneSprache, ref tb_Fremdsprache);

            switch (classNumber)
            {
                case 1:
                    Fach1.Remove(currentVoc);
                    Fach1.Add(tb_EigeneSprache.Text, tb_Fremdsprache.Text);
                    break;
                case 2:
                    Fach2.Remove(currentVoc);
                    Fach2.Add(tb_EigeneSprache.Text, tb_Fremdsprache.Text);
                    break;
                case 3:
                    Fach3.Remove(currentVoc);
                    Fach3.Add(tb_EigeneSprache.Text, tb_Fremdsprache.Text);
                    break;
                case 4:
                    Fach4.Remove(currentVoc);
                    Fach4.Add(tb_EigeneSprache.Text, tb_Fremdsprache.Text);
                    break;
                case 5:
                    Fach5.Remove(currentVoc);
                    Fach5.Add(tb_EigeneSprache.Text, tb_Fremdsprache.Text);
                    break;
                case 6:
                    Fach6.Remove(currentVoc);
                    Fach6.Add(tb_EigeneSprache.Text, tb_Fremdsprache.Text);
                    break;
                case 7:
                    Fach7.Remove(currentVoc);
                    Fach7.Add(tb_EigeneSprache.Text, tb_Fremdsprache.Text);
                    break;
                case 8:
                    Fach8.Remove(currentVoc);
                    Fach8.Add(tb_EigeneSprache.Text, tb_Fremdsprache.Text);
                    break;
                case 9:
                    Fach9.Remove(currentVoc);
                    Fach9.Add(tb_EigeneSprache.Text, tb_Fremdsprache.Text);
                    break;
                case 10:
                    Fach10.Remove(currentVoc);
                    Fach10.Add(tb_EigeneSprache.Text, tb_Fremdsprache.Text);
                    break;
            }

            //UpdateElements();
            lastNativeButton.Text = "[" + classNumber.ToString() + "] " + tb_EigeneSprache.Text;
            lastTransButton.Text = tb_Fremdsprache.Text;
            UpdateDatabase();

            pnl_Info.Visible = false;
            lb_Info_Title.Text = "Wählen sie eine Vokabel aus, um sie zu bearbeiten";
        }

        private void act_ChangeDirection(object sender, EventArgs e)
        {
            string _eigeneVokabel = tb_EigeneSprache.Text;
            string _fremdVokabel = tb_Fremdsprache.Text;

            tb_EigeneSprache.Text = _fremdVokabel;
            tb_Fremdsprache.Text = _eigeneVokabel;
        }
    }
}
