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

namespace Vocrefine_2
{
    public partial class ManageBox : UserControl
    {
        public delegate void CloseCreateNewEvent(object sender, EventArgs e);
        public CloseCreateNewEvent CloseMeFunction = null;

        string settingspath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Vocrefine 2\Settings\Settings.db";
        string appdatapath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Vocrefine 2\\Box\\";
        string boxName = "";

        public ManageBox(string boxNameFromRecent)
        {
            InitializeComponent();
            boxName = boxNameFromRecent;

            this.BackColor = DBAdapter.GetSettingsColorEntry(settingspath, "ManageBox");
            pnl_topboth.BackColor = DBAdapter.GetSettingsColorEntry(settingspath, "ManageBox");
            pnl_botboth.BackColor = DBAdapter.GetSettingsColorEntry(settingspath, "ManageBox");

            // Reset all Hover Colors
            pnl_Learn.BackColor = Color.White;
            pb_Learn.Image = Vocrefine_2.Properties.Resources.learn;
            lb_Learn.ForeColor = Color.FromArgb(13, 15, 16);
            lb_CloseWindow.ForeColor = Color.FromArgb(13, 15, 16);
            lb_Minimize.ForeColor = Color.FromArgb(13, 15, 16);

            pnl_Edit.BackColor = Color.White;
            pb_Edit.Image = Vocrefine_2.Properties.Resources.edit;
            lb_Edit.ForeColor = Color.FromArgb(13, 15, 16);

            pnl_Export.BackColor = Color.White;
            pb_Export.Image = Vocrefine_2.Properties.Resources.export;
            lb_Export.ForeColor = Color.FromArgb(13, 15, 16);

            pnl_Delete.BackColor = Color.White;
            pb_Delete.Image = Vocrefine_2.Properties.Resources.delete;
            lb_Delete.ForeColor = Color.FromArgb(13, 15, 16);

            pnl_Reset.BackColor = Color.White;
            pb_Reset.Image = Vocrefine_2.Properties.Resources.reset;
            lb_Reset.ForeColor = Color.FromArgb(13, 15, 16);
            lb_back.ForeColor = Color.FromArgb(13, 15, 16);

            pnl_DragBar_Right.BackColor = Color.Transparent;
            pnl_DragBar_Middle.BackColor = Color.Transparent;
            pnl_DragBar_Left.BackColor = Color.Transparent;
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
        /// Überprüft, ob über "Learn" gehovert wurde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_MouseEnter_Learn(object sender, EventArgs e)
        {
            pnl_Learn.BackColor = Color.Transparent;
            pb_Learn.Image = Vocrefine_2.Properties.Resources.learn_white;
            lb_Learn.ForeColor = Color.White;
            lb_CloseWindow.ForeColor = Color.White;
            lb_Minimize.ForeColor = Color.White;

            pnl_Edit.BackColor = Color.White;
            pb_Edit.Image = Vocrefine_2.Properties.Resources.edit;
            lb_Edit.ForeColor = Color.FromArgb(13, 15, 16);

            pnl_Export.BackColor = Color.White;
            pb_Export.Image = Vocrefine_2.Properties.Resources.export;
            lb_Export.ForeColor = Color.FromArgb(13, 15, 16);

            pnl_DragBar_Right.BackColor = Color.Transparent;
            pnl_DragBar_Middle.BackColor = Color.Transparent;
            pnl_DragBar_Left.BackColor = Color.Transparent;
        }
        /// <summary>
        /// Überprüft, ob über "Edit" gehovert wurde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_MouseEnter_Edit(object sender, EventArgs e)
        {
            pnl_Edit.BackColor = Color.Transparent;
            pb_Edit.Image = Vocrefine_2.Properties.Resources.edit_white;
            lb_Edit.ForeColor = Color.White;

            pnl_Reset.BackColor = Color.White;
            pb_Reset.Image = Vocrefine_2.Properties.Resources.reset;
            lb_Reset.ForeColor = Color.FromArgb(13, 15, 16);
            lb_back.ForeColor = Color.FromArgb(13, 15, 16);

            pnl_Delete.BackColor = Color.White;
            pb_Delete.Image = Vocrefine_2.Properties.Resources.delete;
            lb_Delete.ForeColor = Color.FromArgb(13, 15, 16);

            pnl_Export.BackColor = Color.White;
            pb_Export.Image = Vocrefine_2.Properties.Resources.export;
            lb_Export.ForeColor = Color.FromArgb(13, 15, 16);

            pnl_Learn.BackColor = Color.White;
            pb_Learn.Image = Vocrefine_2.Properties.Resources.learn;
            lb_Learn.ForeColor = Color.FromArgb(13, 15, 16);
            lb_CloseWindow.ForeColor = Color.FromArgb(13, 15, 16);
            lb_Minimize.ForeColor = Color.FromArgb(13, 15, 16);

            pnl_DragBar_Right.BackColor = Color.Transparent;
            pnl_DragBar_Middle.BackColor = Color.Transparent;
            pnl_DragBar_Left.BackColor = Color.Transparent;
        }
        /// <summary>
        /// Überprüft, ob über "Reset" gehovert wurde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_MouseEnter_Reset(object sender, EventArgs e)
        {
            pnl_Reset.BackColor = Miscellaneous.CustomColors.Red;
            pb_Reset.Image = Vocrefine_2.Properties.Resources.reset_white;
            lb_Reset.ForeColor = Color.White;
            lb_back.ForeColor = Color.White;

            pnl_Delete.BackColor = Color.White;
            pb_Delete.Image = Vocrefine_2.Properties.Resources.delete;
            lb_Delete.ForeColor = Color.FromArgb(13, 15, 16);

            pnl_Export.BackColor = Color.White;
            pb_Export.Image = Vocrefine_2.Properties.Resources.export;
            lb_Export.ForeColor = Color.FromArgb(13, 15, 16);

            pnl_Edit.BackColor = Color.White;
            pb_Edit.Image = Vocrefine_2.Properties.Resources.edit;
            lb_Edit.ForeColor = Color.FromArgb(13, 15, 16);

            pnl_DragBar_Right.BackColor = Color.Transparent;
            pnl_DragBar_Middle.BackColor = Color.Transparent;
            pnl_DragBar_Left.BackColor = Miscellaneous.CustomColors.Red;
        }
        /// <summary>
        /// Überprüft, ob über "Delete" gehovert wurde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_MouseEnter_Delete(object sender, EventArgs e)
        {
            pnl_Delete.BackColor = Miscellaneous.CustomColors.Red;
            pb_Delete.Image = Vocrefine_2.Properties.Resources.delete_white;
            lb_Delete.ForeColor = Color.White;

            pnl_Reset.BackColor = Color.White;
            pb_Reset.Image = Vocrefine_2.Properties.Resources.reset;
            lb_Reset.ForeColor = Color.FromArgb(13, 15, 16);
            lb_back.ForeColor = Color.FromArgb(13, 15, 16);

            pnl_Export.BackColor = Color.White;
            pb_Export.Image = Vocrefine_2.Properties.Resources.export;
            lb_Export.ForeColor = Color.FromArgb(13, 15, 16);

            pnl_Edit.BackColor = Color.White;
            pb_Edit.Image = Vocrefine_2.Properties.Resources.edit;
            lb_Edit.ForeColor = Color.FromArgb(13, 15, 16);

            pnl_DragBar_Right.BackColor = Color.Transparent;
            pnl_DragBar_Middle.BackColor = Color.Transparent;
            pnl_DragBar_Left.BackColor = Color.Transparent;
        }
        /// <summary>
        /// Überprüft, ob über "Export" gehovert wurde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_MouseEnter_Export(object sender, EventArgs e)
        {
            pnl_Export.BackColor = Color.Transparent;
            pb_Export.Image = Vocrefine_2.Properties.Resources.export_white;
            lb_Export.ForeColor = Color.White;

            pnl_Reset.BackColor = Color.White;
            pb_Reset.Image = Vocrefine_2.Properties.Resources.reset;
            lb_Reset.ForeColor = Color.FromArgb(13, 15, 16);
            lb_back.ForeColor = Color.FromArgb(13, 15, 16);

            pnl_Delete.BackColor = Color.White;
            pb_Delete.Image = Vocrefine_2.Properties.Resources.delete;
            lb_Delete.ForeColor = Color.FromArgb(13, 15, 16);

            pnl_Edit.BackColor = Color.White;
            pb_Edit.Image = Vocrefine_2.Properties.Resources.edit;
            lb_Edit.ForeColor = Color.FromArgb(13, 15, 16);

            pnl_Learn.BackColor = Color.White;
            pb_Learn.Image = Vocrefine_2.Properties.Resources.learn;
            lb_Learn.ForeColor = Color.FromArgb(13, 15, 16);
            lb_CloseWindow.ForeColor = Color.FromArgb(13, 15, 16);
            lb_Minimize.ForeColor = Color.FromArgb(13, 15, 16);

            pnl_DragBar_Right.BackColor = Color.Transparent;
            pnl_DragBar_Middle.BackColor = Color.Transparent;
            pnl_DragBar_Left.BackColor = Color.Transparent;
        }


        /// <summary>
        /// Löscht die uasgewählte Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_DeleteBox(object sender, EventArgs e)
        {
            if (MessageBox.Show("Soll die Box '" + boxName + "' wirklich gelöscht werden? " +
                "\nWenn sie bestätigen ist dieser Vorgang unumkehrbar! Sind sie sich sicher, dass sie fortfahren möchten?", "Löschen bestätigen", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string appdatapath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Vocrefine 2\Box\";
                string dbPath = appdatapath + boxName + ".db";

                File.Delete(dbPath);

                CloseMeFunction?.Invoke(this, null);
            }
        }
        /// <summary>
        /// Verschiebt alle Vokabeln in Fach 1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_ResetBox(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wenn eine Box zurückgesetzt wird, werden alle Vokabeln, die jemals eingetragen wurden in Fach 1 verschoben." +
                "\nSomit geht der gesamte Lernfortschritt verloren. Sind sie sich sicher, dass sie fortfahren möchten?", "Zurücksetzen bestätigen", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                string appdatapath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Vocrefine 2\Box\";
                string dbFilePath = appdatapath + boxName + ".db";

                SQLiteConnection connection = new SQLiteConnection("Data Source=" + dbFilePath + ";Version=3;");
                connection.Open();

                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "UPDATE Vocabulary SET class=1";
                command.ExecuteNonQuery();

                command.CommandText = "UPDATE Label SET value='never' WHERE name='lastLearned'";
                command.ExecuteNonQuery();

                command.CommandText = "UPDATE Label SET value='none' WHERE name='lastClass'";
                command.ExecuteNonQuery();

                command.Dispose();
                connection.Close();
            }
        }
        /// <summary>
        /// Exports the Database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_Export(object sender, EventArgs e)
        {
            SaveFileDialog sfd_ExportDatabase = new SaveFileDialog();
            sfd_ExportDatabase.Title = "Datei exportieren";
            sfd_ExportDatabase.Filter = "Vokabelbox Datei (*.vf2)|*.vf2";

            if (sfd_ExportDatabase.ShowDialog() == DialogResult.OK)
            {
                File.Copy(appdatapath + boxName + ".db", sfd_ExportDatabase.FileName, true);

                MessageBox.Show("Die Box '" + boxName + "' wurde erfolgreich exportiert!");
            }
        }
    }
}
