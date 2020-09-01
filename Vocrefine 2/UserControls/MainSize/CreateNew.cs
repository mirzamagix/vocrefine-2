using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SQLite;
using System.Text.RegularExpressions;

namespace Vocrefine_2
{
    public partial class CreateNew : UserControl
    {
        public delegate void CloseCreateNewEvent(object sender, EventArgs e);
        public CloseCreateNewEvent CloseMeFunction = null;

        string s_NameDerBox = "";
        string s_EigeneSprache = "";
        string s_Fremdsprache = "";

        Dictionary<string, string> VocabularyMap = new Dictionary<string, string>();

        public CreateNew()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Beendet die Anwendung
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_CloseWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /// <summary>
        /// Überprüft, ob genug Text eingegeben wurde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_IsFilled(object sender, EventArgs e)
        {
            if (tb_Name.Text.Trim() == "") pnl_save.BackColor = Color.Gray;
            else
            {
                if (comb_EigeneSprache.Text == "Manuell eingeben >>" && tb_EigeneSprache.Text == "") pnl_save.BackColor = Color.Gray;
                else
                {
                    if (comb_Fremdsprache.Text == "Manuell eingeben >>" && tb_Fremdsprache.Text == "") pnl_save.BackColor = Color.Gray;
                    else
                    {
                        pnl_save.BackColor = Miscellaneous.CustomColors.CreateNew;
                    }
                }
            }

            if (comb_EigeneSprache.Text != "Manuell eingeben >>" && comb_EigeneSprache.Text == comb_Fremdsprache.Text) pnl_save.BackColor = Color.Gray;

            if (comb_EigeneSprache.Text == "Manuell eingeben >>") tb_EigeneSprache.Enabled = true;
            else
            {
                tb_EigeneSprache.Enabled = false;
                tb_EigeneSprache.Text = "";
            }

            if (comb_Fremdsprache.Text == "Manuell eingeben >>") tb_Fremdsprache.Enabled = true;
            else
            {
                tb_Fremdsprache.Enabled = false;
                tb_Fremdsprache.Text = "";
            }

            if (sender is ComboBox) tb_Name.Focus();
        }
        /// <summary>
        /// Ruft AddVocsIsFilled auf
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_AddVocs_isFilled(object sender, EventArgs e)
        {
            AddVocsIsFilled();
        }
        /// <summary>
        /// Überprüft, ob AddVocs Felder ausgefüllt sind
        /// </summary>
        private void AddVocsIsFilled()
        {
            if (tb_AddVocs_ES.Text != "" && tb_AddVocs_FS.Text != "")
            {
                btn_AddVocs_Add.Enabled = true;
                btn_AddVocs_Add.BackColor = Miscellaneous.CustomColors.CreateNew;
            }
            else
            {
                btn_AddVocs_Add.Enabled = false;
                btn_AddVocs_Add.BackColor = Color.DarkGray;
            }
        }


        /// <summary>
        /// Führt AddVocableToList aus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddVocs_Add_Click(object sender, EventArgs e)
        {
            AddVocableToList();
        }
        /// <summary>
        /// Wird ausgefüht, wenn der Benutzer die Enter taste drückt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_AddVocsKeyDown(object sender, KeyEventArgs e)
        {
            if (tb_AddVocs_ES.Text != "" && tb_AddVocs_FS.Text != "")
            {
                if (e.KeyCode == Keys.Enter)
                {
                    AddVocableToList();

                    e.Handled = true;
                    e.SuppressKeyPress = true;
                }
            }
        }
        /// <summary>
        /// Fügt die Vokabel zur Liste hinzu
        /// </summary>
        private void AddVocableToList()
        {
            Miscellaneous.DoThisSpaceStuff(ref tb_AddVocs_ES, ref tb_AddVocs_FS);

            if (tb_AddVocs_ES.Text.Contains(" /") || tb_AddVocs_ES.Text.Contains("/ ") || tb_AddVocs_ES.Text.Contains(" / ") || tb_AddVocs_FS.Text.Contains(" /") || tb_AddVocs_FS.Text.Contains("/ ") || tb_AddVocs_FS.Text.Contains(" / "))
            {
                MessageBox.Show("Bitte setze keine leerzeichen vor und nach der Bedeutungtrennung", "Kann nicht gespeichert werden");
                return;
            }

            VocabularyMap.Add(tb_AddVocs_ES.Text.Trim(), tb_AddVocs_FS.Text.Trim());

            tb_AddVocs_ES.Text = "";
            tb_AddVocs_FS.Text = "";
            tb_AddVocs_ES.Focus();

            AddVocsIsFilled();
        }
        /// <summary>
        /// Vertauscht beide Textboxen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_AddVocs_Switch_Click(object sender, EventArgs e)
        {
            int eKoordinateBox = tb_AddVocs_ES.Location.X;
            int eKoordinateLabel = lb_AddVocs_ES.Location.X;
            int fKoordinateBox = tb_AddVocs_FS.Location.X;
            int fKoordinateLabel = lb_AddVocs_FS.Location.X;

            lb_AddVocs_ES.Location = new Point(fKoordinateLabel, 113);
            tb_AddVocs_ES.Location = new Point(fKoordinateBox, 138);
            lb_AddVocs_FS.Location = new Point(eKoordinateLabel, 113);
            tb_AddVocs_FS.Location = new Point(eKoordinateBox, 138);
        }


        /// <summary>
        /// Speichern der Datei
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_saveBox(object sender, EventArgs e)
        {
            if (pnl_save.BackColor == DBAdapter.GetSettingsColorEntry(Miscellaneous.GenealValues.SETTINGS_FILE_PATH, "CreateNew"))
            {
                if (!pnl_addVocs.Visible)
                {
                    if (!File.Exists(Miscellaneous.GenealValues.APPDATA_PATH + tb_Name.Text + ".db"))
                    {
                        tb_Name.Enabled = false;
                        tb_EigeneSprache.Enabled = false;
                        tb_Fremdsprache.Enabled = false;
                        comb_EigeneSprache.Enabled = false;
                        comb_Fremdsprache.Enabled = false;

                        s_NameDerBox = tb_Name.Text.Trim();

                        if (comb_EigeneSprache.Text == "Manuell eingeben >>") s_EigeneSprache = tb_EigeneSprache.Text.Trim();
                        else s_EigeneSprache = comb_EigeneSprache.Text;

                        if (comb_Fremdsprache.Text == "Manuell eingeben >>") s_Fremdsprache = tb_Fremdsprache.Text.Trim();
                        else s_Fremdsprache = comb_Fremdsprache.Text;

                        lb_AddVocs_ES.Text = s_EigeneSprache + " :";
                        lb_AddVocs_FS.Text = s_Fremdsprache + " :";
                        pnl_addVocs.Visible = true;
                        lb_Warnung.Visible = false;

                        lb_back.Visible = false;

                        lb_save.Text = "FERTIG";
                    }
                    else MessageBox.Show("Es existiert bereits eine Box mit dem Namen '" + tb_Name.Text + "' \nGehe zu Hauptmenü > Öffnen um deine Boxen zu verwalten", "Fehler aufgetreten", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string dbFilePath = Miscellaneous.GenealValues.APPDATA_PATH + s_NameDerBox + ".db";

                    DBAdapter.CreateDatabase(dbFilePath);
                    DBAdapter.AddLabel(dbFilePath, "nativeLanguage", s_EigeneSprache);
                    DBAdapter.AddLabel(dbFilePath, "translationLanguage", s_Fremdsprache);
                    DBAdapter.AddLabel(dbFilePath, "thisCreated", DateTime.Today.ToString("d"));
                    DBAdapter.AddLabel(dbFilePath, "lastLearned", "never");
                    DBAdapter.AddLabel(dbFilePath, "lastClass", "none");

                    DBAdapter.AddVocabulary(dbFilePath, VocabularyMap, 1);

                    CloseMeFunction?.Invoke(this, null);
                }
            }
        }
    }
}
