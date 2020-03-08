using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Data.SQLite;

namespace Vocrefine_2
{
    public partial class MainWindow : Form
    {
        string settingspath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Vocrefine 2\Settings\Settings.db";

        FrontPage       frontPage;
        AddNew          addNew;
        CreateNew       createNew;
        SelectBox       selectBox;
        ManageBox       manageBox;
        EditBox         editBox;
        LearnBox        learnBox;
        SettingsPage    settingsPage;

        /// <summary>
        /// Prepares Drag Bar
        /// </summary>
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        /// <summary>
        /// Creates Rounded Edges
        /// </summary>
        /// <param name="nLeftRect"></param>
        /// <param name="nTopRect"></param>
        /// <param name="nRightRect"></param>
        /// <param name="nBottomRect"></param>
        /// <param name="nWidthEllipse"></param>
        /// <param name="nHeightEllipse"></param>
        /// <returns></returns>
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,      // x-coordinate of upper-left corner
            int nTopRect,       // y-coordinate of upper-left corner
            int nRightRect,     // x-coordinate of lower-right corner
            int nBottomRect,    // y-coordinate of lower-right corner
            int nWidthEllipse,  // height of ellipse
            int nHeightEllipse  // width of ellipse
        );

        /// <summary>
        /// Main Tasks
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));

            string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Vocrefine 2\Box\";
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            string settingsDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Vocrefine 2\Settings\";
            if (!Directory.Exists(settingsDirectoryPath))
            {
                Directory.CreateDirectory(settingsDirectoryPath);

                DBAdapter.CreateSettingsDatabase(settingspath);
                DBAdapter.AddSettingsColor(settingspath, "FrontPage", Color.DarkOrange);
                DBAdapter.AddSettingsColor(settingspath, "AddNew", Color.Green);
                DBAdapter.AddSettingsColor(settingspath, "CreateNew", Color.Green);
                DBAdapter.AddSettingsColor(settingspath, "SelectBox", Color.Teal);
                DBAdapter.AddSettingsColor(settingspath, "ManageBox", Color.Teal);
                DBAdapter.AddSettingsColor(settingspath, "AddVocs", Color.PaleTurquoise);
                DBAdapter.AddSettingsColor(settingspath, "EditVocs", Color.Thistle);
                DBAdapter.AddSettingsColor(settingspath, "LearnBox", Color.Teal);
            }

            frontPage = new FrontPage();

            frontPage.Dock = DockStyle.Fill;
            frontPage.pnl_Background_AddNew.Click           += new EventHandler(act_ShowAddNew);
            frontPage.pb_AddNew.Click                       += new EventHandler(act_ShowAddNew);
            frontPage.lb_AddNew.Click                       += new EventHandler(act_ShowAddNew);
            frontPage.CloseMeFunction                       += new FrontPage.CloseCreateNewEvent(act_ShowSelectBox);
            frontPage.lb_Minimize.Click                     += new EventHandler(act_Minimize);
            frontPage.lb_AboutInfo.Click                    += new EventHandler(act_ShowCredits);
            frontPage.pb_Settings.Click                     += new EventHandler(act_ShowSettings);

            frontPage.pnl_DragBar_Left.MouseDown            += new MouseEventHandler(act_DragBar);
            frontPage.pnl_DragBar_Right.MouseDown           += new MouseEventHandler(act_DragBar);

            // LOAD FIST USER CONTROL
            pnl_View.Controls.Add(frontPage);
        }
        

        /// <summary>
        /// Minimize the Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_Minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// Drag-Bar Function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_DragBar(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        /// <summary>
        /// Sets Screen to Front Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_ShowFrontPage(object sender, EventArgs e)
        {
            frontPage = new FrontPage();

            frontPage.Dock = DockStyle.Fill;
            frontPage.pnl_Background_AddNew.Click += new EventHandler(act_ShowAddNew);
            frontPage.pb_AddNew.Click += new EventHandler(act_ShowAddNew);
            frontPage.lb_AddNew.Click += new EventHandler(act_ShowAddNew);
            frontPage.CloseMeFunction += new FrontPage.CloseCreateNewEvent(act_ShowSelectBox);
            frontPage.lb_Minimize.Click += new EventHandler(act_Minimize);
            frontPage.lb_AboutInfo.Click += new EventHandler(act_ShowCredits);
            frontPage.pb_Settings.Click += new EventHandler(act_ShowSettings);

            frontPage.pnl_DragBar_Left.MouseDown += new MouseEventHandler(act_DragBar);
            frontPage.pnl_DragBar_Right.MouseDown += new MouseEventHandler(act_DragBar);

            pnl_View.Controls.Clear();
            pnl_View.Controls.Add(frontPage);
        }

        /// <summary>
        /// Starts "AddNew" Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_ShowAddNew(object sender, EventArgs e)
        {
            addNew = new AddNew();

            addNew.Dock = DockStyle.Fill;
            addNew.pnl_Background_CreateNew.Click += new EventHandler(act_ShowCreateNew);
            addNew.pb_CreateNew.Click += new EventHandler(act_ShowCreateNew);
            addNew.lb_CreateNew.Click += new EventHandler(act_ShowCreateNew);
            addNew.lb_back.Click += new EventHandler(act_ShowFrontPage);
            addNew.lb_Minimize.Click += new EventHandler(act_Minimize);

            addNew.pnl_DragBar_Left.MouseDown += new MouseEventHandler(act_DragBar);
            addNew.pnl_DragBar_Right.MouseDown += new MouseEventHandler(act_DragBar);

            pnl_View.Controls.Clear();
            pnl_View.Controls.Add(addNew);
        }

        /// <summary>
        /// Starts "CreateNew" Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_ShowCreateNew(object sender, EventArgs e)
        {
            createNew = new CreateNew();

            createNew.Dock = DockStyle.Fill;
            createNew.CloseMeFunction += new CreateNew.CloseCreateNewEvent(act_ShowFrontPage);
            createNew.lb_back.Click += new EventHandler(act_ShowAddNew);
            createNew.lb_Minimize.Click += new EventHandler(act_Minimize);

            createNew.pnl_DragBar.MouseDown += new MouseEventHandler(act_DragBar);

            pnl_View.Controls.Clear();
            pnl_View.Controls.Add(createNew);
        }

        /// <summary>
        /// Starts "SelectBox" Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_ShowSelectBox(object sender, EventArgs e)
        {
            selectBox = new SelectBox();

            selectBox.Dock = DockStyle.Fill;
            selectBox.lb_back.Click += new EventHandler(act_ShowFrontPage);
            selectBox.lb_Minimize.Click += new EventHandler(act_Minimize);
            selectBox.CloseMeFunction += new SelectBox.CloseCreateNewEvent(act_ShowManageBox);

            selectBox.pnl_DragBar.MouseDown += new MouseEventHandler(act_DragBar);

            pnl_View.Controls.Clear();
            pnl_View.Controls.Add(selectBox);
        }

        /// <summary>
        /// Starts "ManageBox" Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_ShowManageBox(object sender, EventArgs e)
        {
            manageBox = new ManageBox(selectBox.lb_name.Text);

            manageBox.Dock = DockStyle.Fill;
            manageBox.lb_back.Click += new EventHandler(act_ShowFrontPage);
            manageBox.lb_Minimize.Click += new EventHandler(act_Minimize);
            manageBox.CloseMeFunction += new ManageBox.CloseCreateNewEvent(act_ShowFrontPage);

            manageBox.pnl_Edit.Click += new EventHandler(act_ShowEditBox);
            manageBox.pb_Edit.Click += new EventHandler(act_ShowEditBox);
            manageBox.lb_Edit.Click += new EventHandler(act_ShowEditBox);

            manageBox.pnl_Learn.Click += new EventHandler(act_ShowLearnBox);
            manageBox.pb_Learn.Click += new EventHandler(act_ShowLearnBox);
            manageBox.lb_Learn.Click += new EventHandler(act_ShowLearnBox);

            manageBox.pnl_DragBar_Left.MouseDown += new MouseEventHandler(act_DragBar);
            manageBox.pnl_DragBar_Middle.MouseDown += new MouseEventHandler(act_DragBar);
            manageBox.pnl_DragBar_Right.MouseDown += new MouseEventHandler(act_DragBar);

            pnl_View.Controls.Clear();
            pnl_View.Controls.Add(manageBox);
        }

        /// <summary>
        /// Starts "EditBox" Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_ShowEditBox(object sender, EventArgs e)
        {
            editBox = new EditBox(selectBox.lb_name.Text);

            editBox.Dock = DockStyle.Fill;
            editBox.lb_back.Click += new EventHandler(act_ShowManageBox);
            editBox.lb_Minimize.Click += new EventHandler(act_Minimize);

            editBox.pnl_DragBar.MouseDown += new MouseEventHandler(act_DragBar);

            pnl_View.Controls.Clear();
            pnl_View.Controls.Add(editBox);
        }

        /// <summary>
        /// Starts "LearnBox" Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_ShowLearnBox(object sender, EventArgs e)
        {
            learnBox = new LearnBox(selectBox.lb_name.Text);

            learnBox.Dock = DockStyle.Fill;
            learnBox.lb_back.Click += new EventHandler(act_ShowManageBox);
            learnBox.lb_Minimize.Click += new EventHandler(act_Minimize);
            learnBox.CloseMeFunction += new LearnBox.CloseCreateNewEvent(act_ShowFrontPage);

            learnBox.pnl_DragBar.MouseDown += new MouseEventHandler(act_DragBar);

            pnl_View.Controls.Clear();
            pnl_View.Controls.Add(learnBox);
        }

        /// <summary>
        /// Shows Settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_ShowSettings(object sender, EventArgs e)
        {
            settingsPage = new SettingsPage();

            settingsPage.Dock = DockStyle.Fill;
            settingsPage.lb_back.Click += new EventHandler(act_ShowFrontPage);
            settingsPage.lb_Minimize.Click += new EventHandler(act_Minimize);

            settingsPage.pnl_DragBar.MouseDown += new MouseEventHandler(act_DragBar);

            pnl_View.Controls.Clear();
            pnl_View.Controls.Add(settingsPage);
        }

        /// <summary>
        /// Shows Information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void act_ShowCredits(object sender, EventArgs e)
        {
            InfoAbout infoAbout = new InfoAbout();
            infoAbout.Dock = DockStyle.Fill;

            Panel pnl_Fill = new Panel();
            pnl_Fill.Dock = DockStyle.Fill;
            pnl_Fill.Controls.Add(infoAbout);

            Form frmCredits = new Form();
            frmCredits.FormBorderStyle = FormBorderStyle.FixedSingle;
            frmCredits.MaximizeBox = false;
            frmCredits.MinimizeBox = false;
            frmCredits.ShowIcon = false;
            frmCredits.ShowInTaskbar = false;
            frmCredits.Size = new Size(460, 190);
            frmCredits.StartPosition = FormStartPosition.CenterScreen;
            frmCredits.Text = "Information & About";
            frmCredits.Controls.Add(pnl_Fill);

            frmCredits.Show();
        }
        
    }
}
