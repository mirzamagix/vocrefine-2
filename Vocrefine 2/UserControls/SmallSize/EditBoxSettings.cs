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

namespace Vocrefine_2
{
    public partial class EditBoxSettings : UserControl
    {
        string dbFilePath;

        public EditBoxSettings(string boxNameFromRecent)
        {
            InitializeComponent();

            dbFilePath = Miscellaneous.GenealValues.APPDATA_PATH + boxNameFromRecent + ".db";

            tb_Name.Text = boxNameFromRecent;
            tb_EigeneSprache.Text = DBAdapter.GetLabelEntry(dbFilePath, "nativeLanguage");
            tb_Fremdsprache.Text = DBAdapter.GetLabelEntry(dbFilePath, "translationLanguage");

            btn_save.Visible = false;
        }

        /// <summary>
        /// Wenn etwas an den Angaben vom Benutzer geändert wird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_Fremdsprache_TextChanged(object sender, EventArgs e)
        {
            btn_save.Visible = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DBAdapter.UpdateLabel(dbFilePath, "nativeLanguage", tb_EigeneSprache.Text);
            DBAdapter.UpdateLabel(dbFilePath, "translationLanguage", tb_Fremdsprache.Text);

            File.Move(dbFilePath, Miscellaneous.GenealValues.APPDATA_PATH + tb_Name.Text + ".db");

            Application.Restart();
        }
    }
}
