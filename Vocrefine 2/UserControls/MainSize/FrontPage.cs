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
    public partial class FrontPage : UserControl
    {
        public delegate void CloseCreateNewEvent(object sender, EventArgs e);
        public CloseCreateNewEvent CloseMeFunction = null;

        public FrontPage()
        {
            InitializeComponent(); 
            
            this.BackColor = Miscellaneous.CustomColors.FrontPage;
        }

        // Hover change
        private void act_MouseEnter_OpenExisting(object sender, EventArgs e)
        {
            pnl_Background_OpenExisting.BackColor = Color.Transparent;
            lb_OpenExisting.ForeColor = Color.White;
            pb_OpenExisting.Image = Vocrefine_2.Properties.Resources.Ordner_white;
            lb_CloseWindow.ForeColor = Color.White;
            lb_Minimize.ForeColor = Color.White;
            lb_AboutInfo.ForeColor = Color.White;
            pb_Settings.Image = Vocrefine_2.Properties.Resources.settings_white;
            pnl_DragBar_Left.BackColor = Color.Transparent;

            pnl_Background_AddNew.BackColor = SystemColors.Control;
            lb_AddNew.ForeColor = Color.FromArgb(13, 15, 16);
            pb_AddNew.Image = Vocrefine_2.Properties.Resources.Hinzufuegen;
            pnl_DragBar_Right.BackColor = Color.Transparent;
        }
        private void act_MouseEnter_AddNew(object sender, EventArgs e)
        {
            pnl_Background_AddNew.BackColor = Color.Transparent;
            lb_AddNew.ForeColor = Color.White;
            pb_AddNew.Image = Vocrefine_2.Properties.Resources.Hinzufuegen_white;
            pnl_DragBar_Right.BackColor = Color.Transparent;

            pnl_Background_OpenExisting.BackColor = SystemColors.Control;
            lb_OpenExisting.ForeColor = Color.FromArgb(13, 15, 16);
            pb_OpenExisting.Image = Vocrefine_2.Properties.Resources.Ordner;
            lb_CloseWindow.ForeColor = Color.FromArgb(13, 15, 16);
            lb_Minimize.ForeColor = Color.FromArgb(13, 15, 16);
            lb_AboutInfo.ForeColor = Color.FromArgb(13, 15, 16);
            pb_Settings.Image = Vocrefine_2.Properties.Resources.settings;
            pnl_DragBar_Left.BackColor = Color.Transparent;
        }

        /// <summary>
        /// Closes the Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_CloseWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Wenn keine Box vorhanden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_Click_OpenExisting(object sender, EventArgs e)
        {
            if (new DirectoryInfo(Miscellaneous.GenealValues.APPDATA_PATH).GetFiles().Length != 0) CloseMeFunction?.Invoke(this, null);
            else MessageBox.Show(
                "Du hast noch keine Box erstellt. Gehe zu 'Neue Box hinzufügen' um eine Box hinzuzufügen.", 
                "Keine Box vorhanden", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Warning);
        }
    }
}
