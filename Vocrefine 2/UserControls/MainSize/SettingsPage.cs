﻿using System;
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
    public partial class SettingsPage : UserControl
    {
        public SettingsPage()
        {
            InitializeComponent();

            pnl_ColorPreview_FrontPage.BackColor = Miscellaneous.CustomColors.FrontPage;
            pnl_ColorPreview_AddNew.BackColor = Miscellaneous.CustomColors.AddNew;
            pnl_ColorPreview_CreateNew.BackColor = Miscellaneous.CustomColors.CreateNew;
            pnl_ColorPreview_SelectBox.BackColor = Miscellaneous.CustomColors.SelectBox;
            pnl_ColorPreview_ManageBox.BackColor = Miscellaneous.CustomColors.ManageBox;
            pnl_ColorPreview_AddVocs.BackColor = Miscellaneous.CustomColors.AddVocs;
            pnl_ColorPreview_EditVocs.BackColor = Miscellaneous.CustomColors.EditVocs;
            pnl_ColorPreview_LearnBox.BackColor = Miscellaneous.CustomColors.LearnBox;
        }

        /// <summary>
        /// Beendet das Programm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_CloseWindow_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void act_ClickOnAnyColorChange(object sender, EventArgs e)
        {
            if (clrd_ColorPick.ShowDialog() == DialogResult.OK)
            {
                ((Panel)sender).BackColor = clrd_ColorPick.Color;

                pnl_continue.BackColor = Color.Green;
            }
        }

        private void pnl_continue_Click(object sender, EventArgs e)
        {
            if (pnl_continue.BackColor == Color.Green)
            {
                DBAdapter.UpdateSettingsColor(Miscellaneous.GenealValues.SETTINGS_FILE_PATH, "FrontPage", pnl_ColorPreview_FrontPage.BackColor);
                DBAdapter.UpdateSettingsColor(Miscellaneous.GenealValues.SETTINGS_FILE_PATH, "AddNew", pnl_ColorPreview_AddNew.BackColor);
                DBAdapter.UpdateSettingsColor(Miscellaneous.GenealValues.SETTINGS_FILE_PATH, "CreateNew", pnl_ColorPreview_CreateNew.BackColor);
                DBAdapter.UpdateSettingsColor(Miscellaneous.GenealValues.SETTINGS_FILE_PATH, "SelectBox", pnl_ColorPreview_SelectBox.BackColor);
                DBAdapter.UpdateSettingsColor(Miscellaneous.GenealValues.SETTINGS_FILE_PATH, "ManageBox", pnl_ColorPreview_ManageBox.BackColor);
                DBAdapter.UpdateSettingsColor(Miscellaneous.GenealValues.SETTINGS_FILE_PATH, "AddVocs", pnl_ColorPreview_AddVocs.BackColor);
                DBAdapter.UpdateSettingsColor(Miscellaneous.GenealValues.SETTINGS_FILE_PATH, "EditVocs", pnl_ColorPreview_EditVocs.BackColor);
                DBAdapter.UpdateSettingsColor(Miscellaneous.GenealValues.SETTINGS_FILE_PATH, "LearnBox", pnl_ColorPreview_LearnBox.BackColor);

                Application.Restart();
            }
        }

        private void lb_Color_Reset_Click(object sender, EventArgs e)
        {
            pnl_ColorPreview_FrontPage.BackColor = Miscellaneous.CustomColors.FrontPage;
            pnl_ColorPreview_AddNew.BackColor = Miscellaneous.CustomColors.AddNew;
            pnl_ColorPreview_CreateNew.BackColor = Miscellaneous.CustomColors.CreateNew;
            pnl_ColorPreview_SelectBox.BackColor = Miscellaneous.CustomColors.SelectBox;
            pnl_ColorPreview_ManageBox.BackColor = Miscellaneous.CustomColors.ManageBox;
            pnl_ColorPreview_AddVocs.BackColor = Miscellaneous.CustomColors.AddVocs;
            pnl_ColorPreview_EditVocs.BackColor = Miscellaneous.CustomColors.EditVocs;
            pnl_ColorPreview_LearnBox.BackColor = Miscellaneous.CustomColors.LearnBox;

            pnl_continue.BackColor = Color.Green;
        }
    }
}
