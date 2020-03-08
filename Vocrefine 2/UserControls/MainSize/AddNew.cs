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
    public partial class AddNew : UserControl
    {
        public AddNew()
        {
            InitializeComponent();

            string settingspath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Vocrefine 2\Settings\Settings.db";
            this.BackColor = DBAdapter.GetSettingsColorEntry(settingspath, "AddNew");
        }

        // Hover change
        private void act_MouseEnter_CreateNew(object sender, EventArgs e)
        {
            pnl_Background_CreateNew.BackColor = Color.Transparent;
            pb_CreateNew.Image = Vocrefine_2.Properties.Resources.erstellen_white;
            lb_CreateNew.ForeColor = Color.White;
            lb_CloseWindow.ForeColor = Color.White;
            lb_Minimize.ForeColor = Color.White;
            pnl_DragBar_Left.BackColor = Color.Transparent;

            pnl_Background_Import.BackColor = SystemColors.Control;
            pb_import.Image = Vocrefine_2.Properties.Resources.import;
            lb_Import.ForeColor = Color.FromArgb(13, 15, 16);
            lb_back.ForeColor = Color.FromArgb(13, 15, 16);
            pnl_DragBar_Right.BackColor = Color.Transparent;
        }
        private void act_MouseEnter_Import(object sender, EventArgs e)
        {
            pnl_Background_Import.BackColor = Color.Transparent;
            pb_import.Image = Vocrefine_2.Properties.Resources.import_white;
            lb_Import.ForeColor = Color.White;
            lb_back.ForeColor = Color.White;
            pnl_DragBar_Right.BackColor = Color.Transparent;

            pnl_Background_CreateNew.BackColor = SystemColors.Control;
            pb_CreateNew.Image = Vocrefine_2.Properties.Resources.erstellen;
            lb_CreateNew.ForeColor = Color.FromArgb(13, 15, 16);
            lb_CloseWindow.ForeColor = Color.FromArgb(13, 15, 16);
            lb_Minimize.ForeColor = Color.FromArgb(13, 15, 16);
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
        /// Importierung von Dateien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_import(object sender, EventArgs e)
        {
            OpenFileDialog ofd_CopyFile = new OpenFileDialog();
            ofd_CopyFile.Title = "Datei importieren";
            ofd_CopyFile.Filter = "Vokabelbox Datei (*.vf2)|*.vf2";

            if (ofd_CopyFile.ShowDialog() == DialogResult.OK)
            {
                string[] parts = ofd_CopyFile.FileName.Split('\\');
                string copyname = parts[parts.Length - 1];
                string appdatapath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Vocrefine 2\\Box\\";
                File.Copy(ofd_CopyFile.FileName, appdatapath + copyname, true);

                MessageBox.Show("Die Box \"" + copyname.Substring(0, copyname.Length - 4) + "\" wurde erfolgreich importiert!");
            }
        }
    }
}
