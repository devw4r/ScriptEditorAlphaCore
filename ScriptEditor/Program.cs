using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Reflection;

namespace ScriptEditor
{
    static class Program
    {
        // MySQL connection data.
        public static string worldConnString = "Server=localhost;Database=%s;Port=3306;Uid=root;Pwd=root;";
        public static string dbcConnString = "Server=localhost;Database=%s;Port=3306;Uid=root;Pwd=root;";
        public static string mysqlUser = "root";
        public static string mysqlPass = "root";
        public static string mysqlHost = "localhost";
        public static string mysqlPort = "3306";
        public static string mysqlWorldDb = "alpha_world";
        public static string mysqlDbcDb = "alpha_dbc";

        // Highlight non-default values.
        public static bool highlight = false;

        // Desired culture info.
        public static string locale = "en-US";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoadConfig();

            Console.WriteLine("Please wait while loading the database.\n");

            // Load content from the database.
            Console.WriteLine("Loading texts...");
            GameData.LoadBroadcastTexts(worldConnString);
            Console.WriteLine("Loading quests...");
            GameData.LoadQuests(worldConnString);
            Console.WriteLine("Loading gameobjects...");
            GameData.LoadGameObjects(worldConnString);
            Console.WriteLine("Loading creatures...");
            GameData.LoadCreatures(worldConnString);
            Console.WriteLine("Loading spells...");
            GameData.LoadSpells(dbcConnString);
            Console.WriteLine("Loading items...");
            GameData.LoadItems(worldConnString);
            Console.WriteLine("Loading conditions...");
            GameData.LoadCondition(worldConnString);
            Console.WriteLine("Loading areas...");
            GameData.LoadAreas(worldConnString);
            Console.WriteLine("Loading factions...");
            GameData.LoadFactions(dbcConnString);
            GameData.LoadFactionTemplates(dbcConnString);
            Console.WriteLine("Loading game events...");
            //GameData.LoadGameEvents(worldConnString);
            Console.WriteLine("Loading creature spells...");
            GameData.LoadCreatureSpells(worldConnString);
            Console.WriteLine("Loading creature movement ...");
            GameData.LoadCreatureMovement(worldConnString);
            Console.WriteLine("Loading creature movement special ...");
            GameData.LoadCreatureMovementSpecial(worldConnString);
            Console.WriteLine("Loading creature movement template ...");
            GameData.LoadCreatureMovementTemplate(worldConnString);

            // Apply locale settings.
            SetDefaultCulture(new CultureInfo(locale));

            // Start the main form.
            Application.Run(new Form1());
        }

        private static void LoadConfig()
        {
            if (!System.IO.File.Exists(@"config.ini"))
            {
                worldConnString = "Server=" + mysqlHost + ";Database=" + "alpha_world" + ";Port=" + mysqlPort + ";Uid=" + mysqlUser + ";Pwd=" + mysqlPass + ";";
                dbcConnString = "Server=" + mysqlHost + ";Database=" + "alpha_dbc" + ";Port=" + mysqlPort + ";Uid=" + mysqlUser + ";Pwd=" + mysqlPass + ";";
                MessageBox.Show("Your config file seems to have vanished into the nether! But worry not, i shall use my ultra-safe mind reading device to guess your database connection details. Surely nothing can go wrong, gnomish inventions are renowned for their safety after all!", "No config found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"config.ini");
            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains("User="))
                    mysqlUser = line.Replace("User=", "");
                else if (line.Contains("Pass="))
                    mysqlPass = line.Replace("Pass=", "");
                else if (line.Contains("Host="))
                    mysqlHost = line.Replace("Host=", "");
                else if (line.Contains("Port="))
                    mysqlPort = line.Replace("Port=", "");
                else if (line.Contains("WorldDB="))
                    mysqlWorldDb = line.Replace("WorldDB=", "");
                else if (line.Contains("DbcDB="))
                    mysqlWorldDb = line.Replace("DbcDB=", "");
                else if (line.Contains("Locale="))
                    locale = line.Replace("Locale=", "");
                else if (line.Contains("Highlight=true"))
                    highlight = true;
            }

            worldConnString = "Server=" + mysqlHost + ";Database=" + worldConnString + ";Port=" + mysqlPort + ";Uid=" + mysqlUser + ";Pwd=" + mysqlPass + ";";
            dbcConnString = "Server=" + mysqlHost + ";Database=" + dbcConnString + ";Port=" + mysqlPort + ";Uid=" + mysqlUser + ";Pwd=" + mysqlPass + ";";
        }

        static void SetDefaultCulture(CultureInfo culture)
        {
            Type type = typeof(CultureInfo);

            try
            {
                type.InvokeMember("s_userDefaultCulture",
                                    BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Static,
                                    null,
                                    culture,
                                    new object[] { culture });

                type.InvokeMember("s_userDefaultUICulture",
                                    BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Static,
                                    null,
                                    culture,
                                    new object[] { culture });
            }
            catch { }

            try
            {
                type.InvokeMember("m_userDefaultCulture",
                                    BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Static,
                                    null,
                                    culture,
                                    new object[] { culture });

                type.InvokeMember("m_userDefaultUICulture",
                                    BindingFlags.SetField | BindingFlags.NonPublic | BindingFlags.Static,
                                    null,
                                    culture,
                                    new object[] { culture });
            }
            catch { }
        }
    }
}
