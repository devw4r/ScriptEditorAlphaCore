using System;
using System.Windows.Forms;
using System.Globalization;
using System.Reflection;
using IniParser;
using IniParser.Model;
using MySqlConnector;

namespace ScriptEditor
{
    static class Program
    {
        // MySQL connection data.
        public static string connString = "Server=localhost;Database=%s;Port=3306;Uid=root;Pwd=pwd;";
        public static string mysqlUser = "root";
        public static string mysqlPass = "pwd";
        public static string mysqlHost = "localhost";
        public static string mysqlPort = "3306";
        public static string txtMysqlWorldDb = "alpha_world";
        public static string txtMysqlDbcDb = "alpha_dbc";
        public static string txtMysqlSniffsDB = "sniffs_combined5";
        public static bool SniffsInstalled = false;

        public static MySqlConnection MySqlWorldConnection;
        public static MySqlConnection MySqlDbcConnection;
        public static MySqlConnection MySqlSniffsConnection;

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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoadConfig();

            // Apply locale settings.
            SetDefaultCulture(new CultureInfo(locale));

            // Start the main form.
            Application.Run(new Form1());


        }

        private static void LoadConfig()
        {
            if (System.IO.File.Exists(@"config.ini"))
            {

                var parser = new FileIniDataParser();
                IniData data = parser.ReadFile(@"config.ini");

                mysqlUser = data.Global["User"];
                mysqlPass = data.Global["Pass"];
                mysqlHost = data.Global["Host"];
                mysqlPort = data.Global["Port"];
                txtMysqlWorldDb = data.Global["WorldDB"];
                txtMysqlDbcDb = data.Global["DbcDB"];
                locale = data.Global["Locale"];

                highlight = bool.Parse(data.Global["Highlight"]);
            }
            else
            {
                mysqlUser = "root";
                mysqlPass = "pwd";
                mysqlHost = "localhost";
                mysqlPort = "3306";
                txtMysqlWorldDb = "alpha_world";
                txtMysqlDbcDb = "alpha_dbc";
                locale = "en-US";
                highlight = false;

                IniData data = new IniData();
                data.Global["User"] = mysqlUser;
                data.Global["Pass"] = mysqlPass;
                data.Global["Host"] = mysqlHost;
                data.Global["Port"] = mysqlPort;
                data.Global["Locale"] = locale;
                data.Global["WorldDB"] = txtMysqlWorldDb;
                data.Global["DbcDB"] = txtMysqlDbcDb;
                data.Global["Highlight"] = highlight.ToString();

                var parser = new FileIniDataParser();
                parser.WriteFile(@"config.ini", data);
                MessageBox.Show("A new config.ini file with default values has been created in the program's directory. If database connection fails please review it and change values if needed.");
            }

            connString = "Server=" + mysqlHost + ";Database={0};Port=" + mysqlPort + ";Uid=" + mysqlUser + ";Pwd=" + mysqlPass + ";";
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
