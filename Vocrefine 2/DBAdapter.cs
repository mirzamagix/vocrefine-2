using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace Vocrefine_2
{
    static class DBAdapter
    {

        /// <summary>
        /// Opens Connection
        /// </summary>
        /// <param name="dbPath"></param>
        /// <returns></returns>
        private static SQLiteConnection openDBase(string dbPath)
        {
            SQLiteConnection connection = new SQLiteConnection("Data Source=" + dbPath + ";Version=3;");
            connection.Open();

            return connection;
        }

        // ----------------------

        /// <summary>
        /// Creates database with empty tables
        /// </summary>
        /// <param name="dbPath">Path</param>
        public static void CreateDatabase(string dbPath)
        {
            SQLiteConnection.CreateFile(dbPath);

            SQLiteConnection connection = openDBase(dbPath);
            SQLiteCommand command = new SQLiteCommand(connection);

            command.CommandText = @"CREATE TABLE IF NOT EXISTS [Vocabulary] (
                [class] INTEGER NOT NULL,
                [native] NVARCHAR(256) NOT NULL,
                [translation] NVARCHAR(256) NOT NULL
                )";
            command.ExecuteNonQuery();

            command.CommandText = @"CREATE TABLE IF NOT EXISTS [Label] (
                        [name] NVARCHAR(256) NOT NULL UNIQUE,
                        [value] NVARCHAR(256) NOT NULL
                        )";
            command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }

        /// <summary>
        /// Adds vocabulary to the Vocabulary table
        /// </summary>
        /// <param name="dbPath"></param>
        /// <param name="VocabularyMap"></param>
        public static bool AddVocabulary(string dbPath, Dictionary<string, string> VocabularyMap, int iClass)
        {
            SQLiteConnection connection = openDBase(dbPath);
            SQLiteCommand command = new SQLiteCommand(connection);

            // Liste mit Eigenen Vokabeln
            List<string> resultNative = new List<string>();
            command.CommandText = String.Format("SELECT * FROM Vocabulary WHERE class={0};", iClass.ToString());
            var readerNative = command.ExecuteReader();
            while (readerNative.Read())
            {
                resultNative.Add(Convert.ToString(readerNative["native"]));
            }
            readerNative.Close();

            // Liste mit Fremd Vokabeln
            List<string> resultTranslation = new List<string>();
            command.CommandText = String.Format("SELECT * FROM Vocabulary WHERE class={0};", iClass.ToString());
            var readerTranslation = command.ExecuteReader();
            while (readerTranslation.Read())
            {
                resultTranslation.Add(Convert.ToString(readerTranslation["translation"]));
            }
            readerTranslation.Close();

            bool doubleVocs = true;

            Dictionary<string, string>.KeyCollection keyColl = VocabularyMap.Keys;
            foreach (string sEigene in keyColl)
            {
                string sFremd = VocabularyMap[sEigene];

                if (!resultNative.Contains(sEigene) && !resultTranslation.Contains(sFremd))
                {
                    command.CommandText = String.Format("INSERT INTO Vocabulary (class, native, translation) VALUES ({0},'{1}', '{2}')", iClass, sEigene, sFremd);
                    command.ExecuteNonQuery();
                }
                else doubleVocs = false;
            }

            command.Dispose();
            connection.Close();

            return doubleVocs;
        }

        /// <summary>
        /// Adds value from a specific key
        /// </summary>
        /// <param name="dbPath"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public static void AddLabel(string dbPath, string name, string value)
        {
            SQLiteConnection connection = openDBase(dbPath);
            SQLiteCommand command = new SQLiteCommand(connection);

            command.CommandText = String.Format("INSERT INTO Label (name, value) VALUES ('{0}', '{1}')", name, value);
            command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }

        /// <summary>
        /// Updates value from a specific key
        /// </summary>
        /// <param name="dbPath"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public static void UpdateLabel(string dbPath, string name, string value)
        {
            SQLiteConnection connection = openDBase(dbPath);
            SQLiteCommand command = new SQLiteCommand(connection);

            command.CommandText = String.Format("UPDATE Label SET value='{0}' WHERE name='{1}'", value, name);
            command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }

        /// <summary>
        /// Gets a Label entry
        /// </summary>
        /// <param name="dbPath"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetLabelEntry(string dbPath, string key)
        {
            SQLiteConnection connection = openDBase(dbPath);
            SQLiteCommand command = new SQLiteCommand(connection);

            command.CommandText = "SELECT * FROM Label WHERE name='" + key + "';";

            string result = "";
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                result = Convert.ToString(reader["value"]);
            }

            command.Dispose();
            connection.Close();

            return result;
        }

        /// <summary>
        /// Gets all Vocables fron a specific class
        /// </summary>
        /// <param name="dbPath"></param>
        /// <param name="iClass"></param>
        /// <returns></returns>
        public static Dictionary<string, string> GetVocsByClass(string dbPath, int iClass)
        {
            SQLiteConnection connection = openDBase(dbPath);
            SQLiteCommand command = new SQLiteCommand(connection);

            Dictionary<string, string> results = new Dictionary<string, string>();

            command.CommandText = String.Format("SELECT * FROM Vocabulary WHERE class={0};", iClass.ToString());

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                results.Add(Convert.ToString(reader["native"]), Convert.ToString(reader["translation"]));
            }

            command.Dispose();
            connection.Close();

            return results;
        }

        /// <summary>
        /// Deletes all Vocable-Entries
        /// </summary>
        /// <param name="dbPath"></param>
        public static void DeleteAllVocables(string dbPath)
        {
            SQLiteConnection connection = openDBase(dbPath);
            SQLiteCommand command = new SQLiteCommand(connection);

            command.CommandText = "DELETE FROM Vocabulary";
            command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }

        /// <summary>
        /// Changes the class of any Vocable
        /// </summary>
        /// <param name="dbPath"></param>
        /// <param name="sVocable"></param>
        /// <param name="iClass"></param>
        public static void ChangeVocableClass(string dbPath, string sVocable, int iClass)
        {
            SQLiteConnection connection = openDBase(dbPath);
            SQLiteCommand command = new SQLiteCommand(connection);

            command.CommandText = String.Format("UPDATE Vocabulary SET class={0} WHERE native='{1}'", iClass, sVocable);
            command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }

        // -----------------------

        /// <summary>
        /// Creates Settings-Database with empty tables
        /// </summary>
        /// <param name="dbPath">Path</param>
        public static void CreateSettingsDatabase(string dbPath)
        {
            SQLiteConnection.CreateFile(dbPath);

            SQLiteConnection connection = openDBase(dbPath);
            SQLiteCommand command = new SQLiteCommand(connection);

            command.CommandText = @"CREATE TABLE IF NOT EXISTS [Color] (
                [colorFrom] NVARCHAR(256) NOT NULL,
                [r] INTEGER,
                [g] INTEGER,
                [b] INTEGER 
                )";
            command.ExecuteNonQuery();

            command.CommandText = @"CREATE TABLE IF NOT EXISTS [Label] (
                        [name] NVARCHAR(256) NOT NULL UNIQUE,
                        [value] NVARCHAR(256) NOT NULL
                        )";
            command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }

        /// <summary>
        /// Adds color setting
        /// </summary>
        /// <param name="dbPath"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public static void AddSettingsColor(string dbPath, string from, Color color)
        {
            SQLiteConnection connection = openDBase(dbPath);
            SQLiteCommand command = new SQLiteCommand(connection);

            command.CommandText = String.Format("INSERT INTO Color (colorFrom, r, g, b) VALUES ('{0}', {1}, {2}, {3})", from, color.R, color.G, color.B);
            command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }

        /// <summary>
        /// Updates color setting
        /// </summary>
        /// <param name="dbPath"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public static void UpdateSettingsColor(string dbPath, string from, Color color)
        {
            SQLiteConnection connection = openDBase(dbPath);
            SQLiteCommand command = new SQLiteCommand(connection);

            command.CommandText = String.Format("UPDATE Color SET r={0} WHERE colorFrom='{1}'", color.R, from);
            command.ExecuteNonQuery();

            command.CommandText = String.Format("UPDATE Color SET g={0} WHERE colorFrom='{1}'", color.G, from);
            command.ExecuteNonQuery();

            command.CommandText = String.Format("UPDATE Color SET b={0} WHERE colorFrom='{1}'", color.B, from);
            command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }

        /// <summary>
        /// Gets Color-Settings Entry
        /// </summary>
        /// <param name="dbPath"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static Color GetSettingsColorEntry(string dbPath, string from)
        {
            SQLiteConnection connection = openDBase(dbPath);
            SQLiteCommand command = new SQLiteCommand(connection);

            command.CommandText = "SELECT * FROM Color WHERE colorFrom='" + from + "';";

            List<int> results = new List<int>();
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                results.Add(Convert.ToInt32(reader["r"]));
                results.Add(Convert.ToInt32(reader["g"]));
                results.Add(Convert.ToInt32(reader["b"]));
            }

            command.Dispose();
            connection.Close();

            Color output = Color.FromArgb(results[0], results[1], results[2]);
            return output;
        }

        /// <summary>
        /// Adds Any Setting
        /// </summary>
        /// <param name="dbPath"></param>
        /// <param name="from"></param>
        /// <param name="value"></param>
        public static void AddSetting(string dbPath, string from, string value)
        {
            SQLiteConnection connection = openDBase(dbPath);
            SQLiteCommand command = new SQLiteCommand(connection);

            command.CommandText = String.Format("INSERT INTO Label (name, value) VALUES ('{0}', '{1}')", from, value);
            command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }

        /// <summary>
        /// Updates Any Setting
        /// </summary>
        /// <param name="dbPath"></param>
        /// <param name="from"></param>
        /// <param name="value"></param>
        public static void UpdateSetting(string dbPath, string from, string value)
        {
            SQLiteConnection connection = openDBase(dbPath);
            SQLiteCommand command = new SQLiteCommand(connection);

            command.CommandText = String.Format("UPDATE Label SET value='{0}' WHERE name='{1}'", value, from);
            command.ExecuteNonQuery();

            command.Dispose();
            connection.Close();
        }

        /// <summary>
        /// Gets Settings Entry
        /// </summary>
        /// <param name="dbPath"></param>
        /// <param name="from"></param>
        /// <returns></returns>
        public static string GetSetting(string dbPath, string from)
        {
            SQLiteConnection connection = openDBase(dbPath);
            SQLiteCommand command = new SQLiteCommand(connection);

            command.CommandText = String.Format("SELECT * FROM Label WHERE name='{0}';", from);

            List<string> results = new List<string>();
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                results.Add(Convert.ToString(reader["value"]));
            }

            command.Dispose();
            connection.Close();

            return results[0];
        }
    }
}
