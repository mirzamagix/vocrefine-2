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
        public static char _multipleMeaningSeperator = '|';

        public class CustomColors
        {
            // Windows
            public static Color FrontPage { get; } = Color.DarkOrange;
            public static Color AddNew { get; } = Color.Green;
            public static Color CreateNew { get; } = Color.Green;
            public static Color SelectBox { get; } = Color.FromArgb(0, 126, 167);
            public static Color ManageBox { get; } = Color.FromArgb(0, 126, 167);
            public static Color EditVocs { get; } = Color.FromArgb(245, 229, 252);
            public static Color AddVocs { get; } = Color.FromArgb(252, 239, 249);
            public static Color EditBoxSettings { get; } = Color.FromArgb(1, 22, 39);
            public static Color LearnBox { get; } = Color.FromArgb(0, 126, 167);
            public static Color SettingsWindow { get; } = Color.FromArgb(65, 226, 186);


            // Other ones
            public static Color Red { get; } = Color.DarkRed; //Color.FromArgb(214, 64, 69);
        }

        /// <summary>
        /// Removes spaces before and after the desired character.
        /// </summary>
        /// <param name="tb_es"></param>
        /// <param name="tb_fs"></param>
        public static void DoThisSpaceStuff(ref TextBox tb_es, ref TextBox tb_fs)
        {
            string[] es = tb_es.Text.Split(_multipleMeaningSeperator).Select(email => email.Trim()).ToArray();
            string[] fs = tb_fs.Text.Split(_multipleMeaningSeperator).Select(email => email.Trim()).ToArray();

            tb_es.Text = string.Join(_multipleMeaningSeperator.ToString(), es);
            tb_fs.Text = string.Join(_multipleMeaningSeperator.ToString(), fs);
        }
    }
}
