using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vocrefine_2
{
    public class Miscellaneous
    {
        public class GenealValues
        {
            public static string SETTINGS_FILE_PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Vocrefine 2\Settings\Settings.db";
            public static string APPDATA_PATH = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Vocrefine 2\Box\";
        }

        public class BoxValues
        {
            public static char MULTIPLE_MEANING_SEPERATOR = '|';
        }
        
        public class CustomColors
        {
            // Windows
            public static Color FrontPage { get; set; } = Color.DarkOrange;
            public static Color AddNew { get; set; } = Color.Green;
            public static Color CreateNew { get; set; } = Color.Green;
            public static Color SelectBox { get; set; } = Color.FromArgb(0, 126, 167);
            public static Color ManageBox { get; set; } = Color.FromArgb(0, 126, 167);
            public static Color EditVocs { get; set; } = Color.FromArgb(245, 229, 252);
            public static Color AddVocs { get; set; } = Color.FromArgb(252, 239, 249);
            public static Color EditBoxSettings { get; set; } = Color.FromArgb(1, 22, 39);
            public static Color LearnBox { get; set; } = Color.FromArgb(0, 126, 167);
            public static Color SettingsWindow { get; set; } = Color.FromArgb(65, 226, 186);

            // Other ones
            public static Color Red { get; set; } = Color.DarkRed;

            public static void GetUpdatedColors()
            {
                FrontPage = DBAdapter.GetSettingsColorEntry(GenealValues.SETTINGS_FILE_PATH, "FrontPage");
                AddNew = DBAdapter.GetSettingsColorEntry(GenealValues.SETTINGS_FILE_PATH, "AddNew");
                CreateNew = DBAdapter.GetSettingsColorEntry(GenealValues.SETTINGS_FILE_PATH, "CreateNew");
                SelectBox = DBAdapter.GetSettingsColorEntry(GenealValues.SETTINGS_FILE_PATH, "SelectBox");
                ManageBox = DBAdapter.GetSettingsColorEntry(GenealValues.SETTINGS_FILE_PATH, "ManageBox");
                EditVocs = DBAdapter.GetSettingsColorEntry(GenealValues.SETTINGS_FILE_PATH, "EditVocs");
                AddVocs = DBAdapter.GetSettingsColorEntry(GenealValues.SETTINGS_FILE_PATH, "AddVocs");
                LearnBox = DBAdapter.GetSettingsColorEntry(GenealValues.SETTINGS_FILE_PATH, "LearnBox");
                EditBoxSettings = DBAdapter.GetSettingsColorEntry(GenealValues.SETTINGS_FILE_PATH, "EditBoxSetiings");
            }
        }

        /// <summary>
        /// Removes spaces before and after the desired character.
        /// </summary>
        /// <param name="tb_es"></param>
        /// <param name="tb_fs"></param>
        public static void DoThisSpaceStuff(ref TextBox tb_es, ref TextBox tb_fs)
        {
            string[] es = tb_es.Text.Split(BoxValues.MULTIPLE_MEANING_SEPERATOR).Select(email => email.Trim()).ToArray();
            string[] fs = tb_fs.Text.Split(BoxValues.MULTIPLE_MEANING_SEPERATOR).Select(email => email.Trim()).ToArray();

            tb_es.Text = string.Join(BoxValues.MULTIPLE_MEANING_SEPERATOR.ToString(), es);
            tb_fs.Text = string.Join(BoxValues.MULTIPLE_MEANING_SEPERATOR.ToString(), fs);
        }
    }
}
