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
    public partial class EditBox : UserControl
    {
        string boxName = "";
        int currentPage = 1;

        public EditBox(string boxNameFromRecent)
        {
            InitializeComponent();

            boxName = boxNameFromRecent;

            AddVocs addVocs = new AddVocs(boxName);
            addVocs.Dock = DockStyle.Fill;

            pnl_View.Controls.Clear();
            pnl_View.Controls.Add(addVocs);

            pnl_AddVocs.BackColor = Miscellaneous.CustomColors.AddVocs;
            pnl_EditVocs.BackColor = Miscellaneous.CustomColors.EditVocs;
            pnl_CaptionBar.BackColor = Miscellaneous.CustomColors.AddVocs;
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
        /// Klick auf "HINZUFÜGEN"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_AddVocs(object sender, EventArgs e)
        {
            if (currentPage != 1)
            {
                AddVocs addVocs = new AddVocs(boxName);
                addVocs.Dock = DockStyle.Fill;

                pnl_View.Controls.Clear();
                pnl_View.Controls.Add(addVocs);

                pnl_AddVocs.BorderStyle = BorderStyle.None;
                pnl_EditVocs.BorderStyle = BorderStyle.FixedSingle;
                pnl_EditBoxSettings.BorderStyle = BorderStyle.FixedSingle;
                pnl_CaptionBar.BackColor = Miscellaneous.CustomColors.AddVocs;
                currentPage = 1;
            }
        }

        /// <summary>
        /// Klick auf "BEARBEITEN"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_EditVocs(object sender, EventArgs e)
        {
            if (currentPage != 2)
            {
                EditVocs editVocs = new EditVocs(boxName);
                editVocs.Dock = DockStyle.Fill;

                pnl_View.Controls.Clear();
                pnl_View.Controls.Add(editVocs);

                pnl_EditVocs.BorderStyle = BorderStyle.None;
                pnl_AddVocs.BorderStyle = BorderStyle.FixedSingle;
                pnl_EditBoxSettings.BorderStyle = BorderStyle.FixedSingle;
                pnl_CaptionBar.BackColor = Miscellaneous.CustomColors.EditVocs;
                currentPage = 2;
            }
        }

        /// <summary>
        /// Klick auf "EINSTALLUNGEN DER BOX"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_EditBoxSettings(object sender, EventArgs e)
        {
            if (currentPage != 3)
            {
                EditBoxSettings editSettings = new EditBoxSettings(boxName);
                editSettings.Dock = DockStyle.Fill;

                pnl_View.Controls.Clear();
                pnl_View.Controls.Add(editSettings);

                pnl_EditVocs.BorderStyle = BorderStyle.FixedSingle;
                pnl_AddVocs.BorderStyle = BorderStyle.FixedSingle;
                pnl_EditBoxSettings.BorderStyle = BorderStyle.None;
                pnl_CaptionBar.BackColor = Color.LightCoral;
                currentPage = 3;
            }
        }
    }
}
