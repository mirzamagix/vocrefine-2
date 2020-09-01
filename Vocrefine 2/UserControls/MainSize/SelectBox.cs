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
    public partial class SelectBox : UserControl
    {
        public delegate void CloseCreateNewEvent(object sender, EventArgs e);
        public CloseCreateNewEvent CloseMeFunction = null;
        
        string selectedElement = "";

        Button lastSelected = new Button();

        public SelectBox()
        {
            InitializeComponent();

            DirectoryInfo ParentDirectory = new System.IO.DirectoryInfo(Miscellaneous.GenealValues.APPDATA_PATH);
            foreach (FileInfo f in ParentDirectory.GetFiles())
            {
                Button b = addButton(f.Name.Substring(0, f.Name.Length - 3));
                b.Click += new EventHandler(act_ClickOnElement);
                flp_MyItems.Controls.Add(b);
            }

            lb_Info_Title.Text = "Wählen sie eine Box aus, \num Informationen zu sehen";
        }

        /// <summary>
        /// Creates the needed Button
        /// </summary>
        /// <param name="sName"></param>
        /// <returns></returns>
        Button addButton(string sName)
        {
            Button b = new Button();
            b.BackColor = Color.White;
            b.FlatStyle = FlatStyle.Flat;
            // Segoe UI Semibold; 18pt; style=Bold
            b.Font = new Font("Segoe UI Semibold", 16, FontStyle.Bold);
            b.ForeColor = Color.FromArgb(13, 15, 16);
            b.TextAlign = ContentAlignment.MiddleLeft;
            b.Text = sName;
            b.Size = new Size(595, 55);

            return b;
        }

        /// <summary>
        /// If Clicked on a Element
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_ClickOnElement(object sender, EventArgs e)
        {
            lastSelected.BackColor = Color.White;
            lastSelected.ForeColor = Color.Black;
            ((Button)sender).BackColor = SystemColors.Control;
            ((Button)sender).ForeColor = Miscellaneous.CustomColors.SelectBox;
            lastSelected = ((Button)sender);
            selectedElement = ((Button)sender).Text;
            lb_name.Text = selectedElement;

            getInformations(selectedElement);

            if (pnl_continue.BackColor == Color.Gray) pnl_continue.BackColor = Miscellaneous.CustomColors.SelectBox;
        }

        /// <summary>
        /// Gets informations from a database
        /// </summary>
        /// <param name="sName">Name of the database</param>
        private void getInformations(string sName)
        {
            lb_Info_Title.Text = "INFORMATIONEN ZUR AUSGEWÄHLTEN BOX:";
            pnl_Info.Visible = true;

            string dbFilePath = Miscellaneous.GenealValues.APPDATA_PATH + sName + ".db";

            lb_ES.Text = DBAdapter.GetLabelEntry(dbFilePath, "nativeLanguage");
            lb_FS.Text = DBAdapter.GetLabelEntry(dbFilePath, "translationLanguage");
            lb_createdAt.Text = DBAdapter.GetLabelEntry(dbFilePath, "thisCreated");

            string lastLearned = DBAdapter.GetLabelEntry(dbFilePath, "lastLearned");
            if (lastLearned != "never") lb_lastLearned.Text = lastLearned;
            else lb_lastLearned.Text = "Noch nicht gelernt";
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
        /// Weiter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_Continue(object sender, EventArgs e)
        {
            if (pnl_continue.BackColor == Miscellaneous.CustomColors.SelectBox)
            {
                CloseMeFunction?.Invoke(this, null);
            }
        }
    }
}
