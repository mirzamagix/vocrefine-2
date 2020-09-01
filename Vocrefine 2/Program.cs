using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vocrefine_2
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region Creating non existent Directories and Files
            if (!Directory.Exists(Miscellaneous.GenealValues.APPDATA_PATH)) Directory.CreateDirectory(Miscellaneous.GenealValues.APPDATA_PATH);

            if (!Directory.Exists(Path.GetDirectoryName(Miscellaneous.GenealValues.SETTINGS_FILE_PATH)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Miscellaneous.GenealValues.SETTINGS_FILE_PATH));

                DBAdapter.CreateSettingsDatabase(Miscellaneous.GenealValues.SETTINGS_FILE_PATH);
                DBAdapter.AddSettingsColor(Miscellaneous.GenealValues.SETTINGS_FILE_PATH, "FrontPage", Miscellaneous.CustomColors.FrontPage);
                DBAdapter.AddSettingsColor(Miscellaneous.GenealValues.SETTINGS_FILE_PATH, "AddNew", Miscellaneous.CustomColors.AddNew);
                DBAdapter.AddSettingsColor(Miscellaneous.GenealValues.SETTINGS_FILE_PATH, "CreateNew", Miscellaneous.CustomColors.CreateNew);
                DBAdapter.AddSettingsColor(Miscellaneous.GenealValues.SETTINGS_FILE_PATH, "SelectBox", Miscellaneous.CustomColors.SelectBox);
                DBAdapter.AddSettingsColor(Miscellaneous.GenealValues.SETTINGS_FILE_PATH, "ManageBox", Miscellaneous.CustomColors.ManageBox);
                DBAdapter.AddSettingsColor(Miscellaneous.GenealValues.SETTINGS_FILE_PATH, "AddVocs", Miscellaneous.CustomColors.AddVocs);
                DBAdapter.AddSettingsColor(Miscellaneous.GenealValues.SETTINGS_FILE_PATH, "EditVocs", Miscellaneous.CustomColors.EditVocs);
                DBAdapter.AddSettingsColor(Miscellaneous.GenealValues.SETTINGS_FILE_PATH, "LearnBox", Miscellaneous.CustomColors.LearnBox);
                DBAdapter.AddSettingsColor(Miscellaneous.GenealValues.SETTINGS_FILE_PATH, "EditBoxSetiings", Miscellaneous.CustomColors.EditBoxSettings);
            }
            else
            {
                Miscellaneous.CustomColors.GetUpdatedColors();
            }
            #endregion

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }
    }
}
