using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Vocrefine_2
{
    public partial class LearnBox : UserControl
    {
        public delegate void CloseCreateNewEvent(object sender, EventArgs e);
        public CloseCreateNewEvent CloseMeFunction = null;

        string settingspath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Vocrefine 2\Settings\Settings.db";
        string appdatapath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Vocrefine 2\Box\";
        string dbFilePath;

        Dictionary<string, string>[] Fach = new Dictionary<string, string>[11];

        int currentClass = 1;       // Das aktuelle Fach
        string currentVoc = "";     // Die aktuelle Vokabel
        string transVoc = "";       // Die aktuelle Übersetzung der Vokabel
        bool direction = true;      // true = Eigene>Fremd
        bool wasRight = false;      // true = Die abgefrage Vokabel war richtig

        DateTime startWindow = new DateTime();

        public LearnBox(string boxNameFromRecent)
        {
            InitializeComponent();

            dbFilePath = appdatapath + boxNameFromRecent + ".db";
            lb_Title.Text = boxNameFromRecent;

            startWindow = DateTime.Now;

            lb_EigeneSprache.Text = DBAdapter.GetLabelEntry(dbFilePath, "nativeLanguage") + ":";
            lb_Fremdsprache.Text = DBAdapter.GetLabelEntry(dbFilePath, "translationLanguage") + ":";
            lb_DirectionEF.Text = DBAdapter.GetLabelEntry(dbFilePath, "nativeLanguage") + " > " + DBAdapter.GetLabelEntry(dbFilePath, "translationLanguage");
            lb_DirectionFE.Text = DBAdapter.GetLabelEntry(dbFilePath, "translationLanguage") + " > " + DBAdapter.GetLabelEntry(dbFilePath, "nativeLanguage");

            Fach[0] = DBAdapter.GetVocsByClass(dbFilePath, 0);
            Fach[1] = DBAdapter.GetVocsByClass(dbFilePath, 1);
            Fach[2] = DBAdapter.GetVocsByClass(dbFilePath, 2);
            Fach[3] = DBAdapter.GetVocsByClass(dbFilePath, 3);
            Fach[4] = DBAdapter.GetVocsByClass(dbFilePath, 4);
            Fach[5] = DBAdapter.GetVocsByClass(dbFilePath, 5);
            Fach[6] = DBAdapter.GetVocsByClass(dbFilePath, 6);
            Fach[7] = DBAdapter.GetVocsByClass(dbFilePath, 7);
            Fach[8] = DBAdapter.GetVocsByClass(dbFilePath, 8);
            Fach[9] = DBAdapter.GetVocsByClass(dbFilePath, 9);
            Fach[10] = DBAdapter.GetVocsByClass(dbFilePath, 10);

            if (DBAdapter.GetLabelEntry(dbFilePath, "lastClass") == "none")
            {
                if (!FindNewClass())
                {
                    MessageBox.Show("In der Ausgewählten Box sind keine Vokabeln enthalten. Gehe zu Hauptmenü > Vorhandene Box öffnen > Vokabeln verwalten um neue Vokabeln hinzufügen", "Keine Vokabeln gefunden", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CloseMeFunction?.Invoke(this, null);
                }
            }
            else
            {
                currentClass = Convert.ToInt32(DBAdapter.GetLabelEntry(dbFilePath, "lastClass"));
            }

            DBAdapter.UpdateLabel(dbFilePath, "lastClass", currentClass.ToString());

            NextExercise(); 
            UpdateClassVisibility();

            sts_info.BackColor = DBAdapter.GetSettingsColorEntry(settingspath, "LearnBox");
        }

        /// <summary>
        /// Exits the Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_CloseWindow_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Wenn du Vocrefine 2 beendest wird deine Statistik gelöscht! Dein Lernfortschritt bleibt natürlich erhalten und jederzeit abrufbereit.", 
                "Achtung!", 
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Switches both of the Input Boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lb_Switch_Click(object sender, EventArgs e)
        {
            int eKoordinateBox = tb_EigeneSprache.Location.X;
            int eKoordinateLabel = lb_EigeneSprache.Location.X;
            int fKoordinateBox = tb_Fremdsprache.Location.X;
            int fKoordinateLabel = lb_Fremdsprache.Location.X;

            lb_EigeneSprache.Location = new Point(fKoordinateLabel, 69);
            tb_EigeneSprache.Location = new Point(fKoordinateBox, 91);
            lb_Fremdsprache.Location = new Point(eKoordinateLabel, 69);
            tb_Fremdsprache.Location = new Point(eKoordinateBox, 91);
        }

        /// <summary>
        /// Dirction change
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_DirectionRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_DirectionRandom.Checked) pnl_Direction.Visible = false;
            else pnl_Direction.Visible = true;

            NextExercise();
        }

        /// <summary>
        /// Wenn Abfragerichtung manuell geändert wird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trb_Direction_ValueChanged(object sender, EventArgs e)
        {
            NextExercise();
        }

        /// <summary>
        /// Wenn Bemerkungen Ein-/Ausgeschaltet werden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cb_BemerkungenAnzeigen_CheckedChanged(object sender, EventArgs e)
        {
            NextExercise();
        }

        /// <summary>
        /// Updates the Class Display
        /// </summary>
        private void UpdateClassVisibility()
        {
            Button currentClassButton = null;
            Button currentItemsCount = null;

            btn_Class1.ForeColor = SystemColors.ControlText;
            btn_Class2.ForeColor = SystemColors.ControlText;
            btn_Class3.ForeColor = SystemColors.ControlText;
            btn_Class4.ForeColor = SystemColors.ControlText;
            btn_Class5.ForeColor = SystemColors.ControlText;
            btn_Class6.ForeColor = SystemColors.ControlText;
            btn_Class7.ForeColor = SystemColors.ControlText;
            btn_Class8.ForeColor = SystemColors.ControlText;
            btn_Class9.ForeColor = SystemColors.ControlText;
            btn_Class10.ForeColor = SystemColors.ControlText;

            btn_Class1_Count.ForeColor = SystemColors.ControlText;
            btn_Class2_Count.ForeColor = SystemColors.ControlText;
            btn_Class3_Count.ForeColor = SystemColors.ControlText;
            btn_Class4_Count.ForeColor = SystemColors.ControlText;
            btn_Class5_Count.ForeColor = SystemColors.ControlText;
            btn_Class6_Count.ForeColor = SystemColors.ControlText;
            btn_Class7_Count.ForeColor = SystemColors.ControlText;
            btn_Class8_Count.ForeColor = SystemColors.ControlText;
            btn_Class9_Count.ForeColor = SystemColors.ControlText;
            btn_Class10_Count.ForeColor = SystemColors.ControlText;

            switch (currentClass)
            {
                case 1:
                    currentClassButton = btn_Class1;
                    currentItemsCount = btn_Class1_Count;
                    break;
                case 2:
                    currentClassButton = btn_Class2;
                    currentItemsCount = btn_Class2_Count;
                    break;
                case 3:
                    currentClassButton = btn_Class3;
                    currentItemsCount = btn_Class3_Count;
                    break;
                case 4:
                    currentClassButton = btn_Class4;
                    currentItemsCount = btn_Class4_Count;
                    break;
                case 5:
                    currentClassButton = btn_Class5;
                    currentItemsCount = btn_Class5_Count;
                    break;
                case 6:
                    currentClassButton = btn_Class6;
                    currentItemsCount = btn_Class6_Count;
                    break;
                case 7:
                    currentClassButton = btn_Class7;
                    currentItemsCount = btn_Class7_Count;
                    break;
                case 8:
                    currentClassButton = btn_Class8;
                    currentItemsCount = btn_Class8_Count;
                    break;
                case 9:
                    currentClassButton = btn_Class9;
                    currentItemsCount = btn_Class9_Count;
                    break;
                case 10:
                    currentClassButton = btn_Class10;
                    currentItemsCount = btn_Class10_Count;
                    break;
            }

            currentClassButton.ForeColor = Color.Teal;
            currentItemsCount.ForeColor = Color.Teal;

            btn_Class1_Count.Text = Fach[1].Count().ToString();
            btn_Class2_Count.Text = Fach[2].Count().ToString();
            btn_Class3_Count.Text = Fach[3].Count().ToString();
            btn_Class4_Count.Text = Fach[4].Count().ToString();
            btn_Class5_Count.Text = Fach[5].Count().ToString();
            btn_Class6_Count.Text = Fach[6].Count().ToString();
            btn_Class7_Count.Text = Fach[7].Count().ToString();
            btn_Class8_Count.Text = Fach[8].Count().ToString();
            btn_Class9_Count.Text = Fach[9].Count().ToString();
            btn_Class10_Count.Text = Fach[10].Count().ToString();

            int countAll = 0;
            foreach (Dictionary<string, string> dic in Fach)
            {
                countAll += dic.Count();
            }
            gb_Fächer.Text = "Fächerübersicht (" + countAll.ToString() + " Vokabeln)";
        }

        /// <summary>
        /// Gives the next exercise
        /// </summary>
        private void NextExercise()
        {
            UpdateClassVisibility();

            // Abfragerichtung bestimmen
            if (cb_DirectionRandom.Checked)
            {
                if (currentClass == 1 || currentClass == 3 || currentClass == 5 || currentClass == 7 || currentClass == 9) direction = true;
                else if (currentClass == 2 || currentClass == 4 || currentClass == 6 || currentClass == 8 || currentClass == 10) direction = false;
            }
            else
            {
                if (trb_Direction.Value == 1) direction = true;
                else direction = false;
            }

            // Holt die benötigten Vokabeln mit Übersetzung
            Random rnd = new Random();
            currentVoc = Fach[currentClass].Keys.ToList()[rnd.Next(0, Fach[currentClass].Count - 1)];
            transVoc = (Fach[currentClass])[currentVoc];

            // Startet Ausgabe
            if (direction)
            {
                tb_Fremdsprache.Text = "";
                tb_Fremdsprache.Focus();
                tb_EigeneSprache.Text = currentVoc;
                if (!cb_BemerkungenAnzeigen.Checked) tb_EigeneSprache.Text = Regex.Replace(tb_EigeneSprache.Text, @"\[.*?\]", "").Trim();

                tb_EigeneSprache.Text = string.Join(" | ", tb_EigeneSprache.Text.Split('|'));
                tb_EigeneSprache.ReadOnly = true;
                tb_Fremdsprache.ReadOnly = false;
            }
            else
            {
                tb_EigeneSprache.Text = "";
                tb_EigeneSprache.Focus();
                tb_Fremdsprache.Text = transVoc;
                if (!cb_BemerkungenAnzeigen.Checked) tb_Fremdsprache.Text = Regex.Replace(tb_Fremdsprache.Text, @"\[.*?\]", "").Trim();

                tb_Fremdsprache.Text = string.Join(" | ", tb_Fremdsprache.Text.Split('|'));
                tb_Fremdsprache.ReadOnly = true;
                tb_EigeneSprache.ReadOnly = false; ;
            }
        }

        /// <summary>
        /// Findet zum Anwendungsstart das richtige Fach
        /// </summary>
        /// <returns></returns>
        private bool FindNewClass()
        {
            currentClass = 10;
            while (Fach[currentClass].Count == 0)
            {
                currentClass--;

                if (currentClass == 0)
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Wenn auf en "Weiter" Buton geklickt wurde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Continue_Click(object sender, EventArgs e)
        {
            act_Continue();
        }

        /// <summary>
        /// Fügt der Statistik einen Wert hinzu
        /// </summary>
        /// <param name="vocWasRight"></param>
        private void StatsAddEntry(bool vocWasRight)
        {
            double actualAllValue = Convert.ToDouble(lb_StatsAll.Text) + 1;
            lb_StatsAll.Text = actualAllValue.ToString();

            string contentLabel = lb_StatsRight.Text;
            if (contentLabel != "0") contentLabel = contentLabel.Split(' ')[0];
            double actualRightValue = Convert.ToDouble(contentLabel.Trim());

            if (vocWasRight)
            {
                actualRightValue++;
            }
            else
            {
                int actualWrongValue = Convert.ToInt32(lb_StatsWrong.Text);
                lb_StatsWrong.Text = (actualWrongValue + 1).ToString();
            }

            double percentage = (actualRightValue / actualAllValue) * 100;
            int realPercentage = Convert.ToInt32(percentage);

            lb_StatsRight.Text = actualRightValue.ToString() + " (" + realPercentage.ToString() + "%)";
        }

        /// <summary>
        /// Findet das nächste Fach
        /// </summary>
        /// <returns></returns>
        private bool FindNextClass()
        {
            if (Fach[currentClass].Count > 0) return true;
            return false;
        }

        /// <summary>
        /// Wenn der benutzer auf WEITER klickt
        /// </summary>
        private void act_Continue()
        {
            if (btn_Continue.Text == "BESTÄTIGEN")
            {
                // Abfragerichtung bestimmen
                if (direction)
                {
                    string writtenAnswer = tb_Fremdsprache.Text;
                    string withoutComment = Regex.Replace(transVoc, @"\[.*?\]", "").Trim();

                    if (!cb_GrossKleinSchreibung.Checked) withoutComment = withoutComment.ToLower();
                    if (!cb_GrossKleinSchreibung.Checked) writtenAnswer = writtenAnswer.ToLower();

                    // Aufteilung in mehrere Bedeutungen für das selbe Wort
                    if (withoutComment.Split(Miscellaneous._multipleMeaningSeperator).Contains(writtenAnswer)) wasRight = true;
                    else wasRight = false;

                    tb_Fremdsprache.Text = string.Join(" | ", withoutComment.Split('|'));
                }
                else
                {
                    string writtenAnswer = tb_EigeneSprache.Text;
                    string withoutComment = Regex.Replace(currentVoc, @"\[.*?\]", "").Trim();

                    if (!cb_GrossKleinSchreibung.Checked) withoutComment = withoutComment.ToLower();
                    if (!cb_GrossKleinSchreibung.Checked) writtenAnswer = writtenAnswer.ToLower();

                    // Aufteilung in mehrere Bedeutungen für das selbe Wort
                    if (withoutComment.Split(Miscellaneous._multipleMeaningSeperator).Contains(writtenAnswer)) wasRight = true;
                    else wasRight = false;

                    tb_EigeneSprache.Text = string.Join(" | ", withoutComment.Split('|'));
                }

                // Farbe ändern
                if (wasRight)
                {
                    tb_EigeneSprache.ForeColor = Color.Green;
                    tb_Fremdsprache.ForeColor = Color.Green;
                    btn_Continue.ForeColor = Color.Green;
                }
                else
                {
                    tb_EigeneSprache.ForeColor = Color.Red;
                    tb_Fremdsprache.ForeColor = Color.Red;
                    btn_Continue.ForeColor = Color.Red;

                    btn_Vertippt.Visible = true;
                }

                gb_Optionen.Enabled = false;
                btn_Continue.Text = "WEITER";
            }
            else if (btn_Continue.Text == "WEITER")
            {
                DBAdapter.UpdateLabel(dbFilePath, "lastLearned", DateTime.Today.ToString("d"));

                // Alte Vokabel Verwaltung
                if (wasRight)
                {
                    StatsAddEntry(true);

                    if (currentClass != 10)
                    {
                        Fach[currentClass].Remove(currentVoc);
                        Fach[currentClass + 1].Add(currentVoc, transVoc);
                        DBAdapter.ChangeVocableClass(dbFilePath, currentVoc, currentClass + 1);
                    }
                    else
                    {
                        Fach[currentClass].Remove(currentVoc);
                        Fach[0].Add(currentVoc, transVoc);
                        DBAdapter.ChangeVocableClass(dbFilePath, currentVoc, 0);
                    }

                    UpdateClassVisibility();
                }
                else
                {
                    StatsAddEntry(false);

                    if (cb_BackToOne.Checked)
                    {
                        Fach[currentClass].Remove(currentVoc);
                        Fach[1].Add(currentVoc, transVoc);
                        DBAdapter.ChangeVocableClass(dbFilePath, currentVoc, 1);
                    }

                    UpdateClassVisibility();
                }

                btn_Vertippt.Visible = false;
                btn_Continue.ForeColor = SystemColors.ControlText;
                btn_Continue.Text = "BESTÄTIGEN";
                gb_Optionen.Enabled = true;
                tb_EigeneSprache.ForeColor = SystemColors.ControlText;
                tb_Fremdsprache.ForeColor = SystemColors.ControlText;

                // Nächste Vokabel
                int countCurrentClass = Fach[currentClass].Count();

                if (countCurrentClass > 0)
                {
                    NextExercise();
                }
                else
                {
                    if (currentClass == 1)
                    {
                        FindNewClass();
                        DBAdapter.UpdateLabel(dbFilePath, "lastClass", currentClass.ToString());

                        if (MessageBox.Show("Du hast die Box nun einmal durchgelernt. Es ist empfohlen in regelmäßigen Abständen zu lernen. Möchtest du weiter lernen?", "Weiter lernen?",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            NextExercise();
                        }
                        else
                        {
                            CloseMeFunction?.Invoke(this, null);
                        }
                    }
                    else
                    {
                        while (!FindNextClass())
                        {
                            currentClass--;

                            if (currentClass == 0)
                            {
                                FindNewClass();
                                DBAdapter.UpdateLabel(dbFilePath, "lastClass", currentClass.ToString());

                                if (MessageBox.Show("Du hast die Box nun einmal durchgelernt. Es ist empfohlen in regelmäßigen Abständen zu lernen. Möchtest du weiter lernen?", "Weiter lernen?",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    NextExercise();
                                }
                                else
                                {
                                    CloseMeFunction?.Invoke(this, null);
                                }
                            }
                        }

                        NextExercise();
                    }
                }
            }
        }

        /// <summary>
        /// Wenn der Benutzer sich vertippt hat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Vertippt_Click(object sender, EventArgs e)
        {
            tb_EigeneSprache.ForeColor = Color.Green;
            tb_Fremdsprache.ForeColor = Color.Green;
            btn_Continue.ForeColor = Color.Green;

            wasRight = true;
            btn_Vertippt.Visible = false;
        }

        /// <summary>
        /// Enter Eingabe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_EigeneSprache_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                act_Continue();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tmr_Stopwatch_Tick(object sender, EventArgs e)
        {
            DateTime nowTime = DateTime.Now;
            TimeSpan duration = nowTime - startWindow;

            if (duration.Hours.ToString().Length == 1) lb_Time_Hours.Text = "0" + duration.Hours.ToString();
            else lb_Time_Hours.Text = duration.Hours.ToString();
            if (duration.Minutes.ToString().Length == 1) lb_Time_Minutes.Text = "0" + duration.Minutes.ToString();
            else lb_Time_Minutes.Text = duration.Minutes.ToString();
            if (duration.Seconds.ToString().Length == 1) lb_Time_Seconds.Text = "0" + duration.Seconds.ToString();
            else lb_Time_Seconds.Text = duration.Seconds.ToString();
        }
    }
}
