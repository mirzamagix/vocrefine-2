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
    public partial class AddVocs : UserControl
    {
        string settingspath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Vocrefine 2\Settings\Settings.db";
        string appdatapath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Vocrefine 2\Box\";
        string dbFilePath;

        public AddVocs(string boxNameFromRecent)
        {
            InitializeComponent();

            dbFilePath = appdatapath + boxNameFromRecent + ".db";
            lb_AddVocs.Text = "Vokabeln hinzufügen zur Box: " + boxNameFromRecent;

            lb_AddVocs_ES.Text = DBAdapter.GetLabelEntry(dbFilePath, "nativeLanguage") + ":";
            lb_AddVocs_FS.Text = DBAdapter.GetLabelEntry(dbFilePath, "translationLanguage") + ":";

            this.BackColor = DBAdapter.GetSettingsColorEntry(settingspath, "AddVocs");
            pnl_addVocs.BackColor = DBAdapter.GetSettingsColorEntry(settingspath, "AddVocs");
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
        /// Prüft ob etwas eingegeben wurde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_IsFilled(object sender, EventArgs e)
        {
            AddVocsIsFilled();
        }

        /// <summary>
        /// Prüft, ob Benutzer etwas eingegeben hat
        /// </summary>
        private void AddVocsIsFilled()
        {
            if (tb_AddVocs_ES.Text != "" && tb_AddVocs_FS.Text != "")
            {
                btn_AddVocs_Add.Enabled = true;
                btn_AddVocs_Add.BackColor = Color.Green;
                btn_AddVocs_Add.ForeColor = Color.White;
            }
            else
            {
                btn_AddVocs_Add.Enabled = false;
                btn_AddVocs_Add.BackColor = Color.DarkGray;
                btn_AddVocs_Add.ForeColor = Color.Black;
            }
        }

        /// <summary>
        /// Vokabel hinzufügen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddVocs_Add_Click(object sender, EventArgs e)
        {
            AddVocableToList();
        }

        /// <summary>
        /// Mit Enter Vokabel bestätigen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_AddVocs_FS_KeyDown(object sender, KeyEventArgs e)
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
            Dictionary<string, string> VocabularyMap = new Dictionary<string, string>();
            VocabularyMap.Add(tb_AddVocs_ES.Text.Trim(), tb_AddVocs_FS.Text.Trim());

            if (!DBAdapter.AddVocabulary(dbFilePath, VocabularyMap, 1))
            {
                MessageBox.Show("Die Vokabel, die du eingegeben hast existiert bereits in deiner Box. Sie wurde übersprungen, sodass du wie gewohnt fortfahren kannst", "Nur zur Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            tb_AddVocs_ES.Text = "";
            tb_AddVocs_FS.Text = "";
            tb_AddVocs_ES.Focus();

            AddVocsIsFilled();
        }
    }
}