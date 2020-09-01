using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vocrefine_2.UserControls.MainSize
{
    public partial class VocabularyImporter : Form
    {
        string dbFilePath;

        public VocabularyImporter(string filepath)
        {
            InitializeComponent();

            dbFilePath = filepath;
        }

        private void btn_import_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Datei auswählen";
            ofd.Filter = "Textdatei (.txt) | *.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Dictionary<string, string> failures = new Dictionary<string, string>();

                var lines = File.ReadLines(ofd.FileName);
                foreach (var line in lines)
                {
                    string[] words = line.Split('#').Select(email => email.Trim()).ToArray();

                    if (words.Length == 2)
                    {
                        string es = words[0];
                        string fs = words[1];

                        Miscellaneous.DoThisSpaceStuffWithStrings(ref es, ref fs);

                        Dictionary<string, string> VocabularyMap = new Dictionary<string, string>();
                        VocabularyMap.Add(es.Trim(), fs.Trim());

                        if (!DBAdapter.AddVocabulary(dbFilePath, VocabularyMap, 1))
                            failures.Add(es, fs);
                    }
                }

                if (failures.Count > 0)
                {
                    string report = "Einige deiner Wörter wurden übersprungen, da sie bereits in dieser Box existieren: \n";

                    foreach (string key in failures.Keys)
                    {
                        report += "\n" + key + " <> " + failures[key];
                    }

                    MessageBox.Show(report, "Übersprungene Wörter");
                }
            }
        }
    }
}
