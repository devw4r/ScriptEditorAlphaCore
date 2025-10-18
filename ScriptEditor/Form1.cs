using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptEditor
{
    public partial class Form1 : Form
    {
        private readonly BackgroundWorker LoadingWorker = new BackgroundWorker();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object _sender, EventArgs _e)
        {
            // Init BG worker.
            LoadingWorker.WorkerReportsProgress = true;
            LoadingWorker.DoWork += LoadingWorker_DoWork;
            LoadingWorker.RunWorkerCompleted += LoadingWorker_RunWorkerCompleted; ;
            LoadingWorker.ProgressChanged += LoadingWorker_ProgressChanged;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // World DB.
            if (!CheckDBConnection(Program.connString, Program.txtMysqlWorldDb, out Program.MySqlWorldConnection))
                throw new Exception($"Unable to open database connection for {Program.txtMysqlWorldDb}");

            // Dbc DB.
            if (!CheckDBConnection(Program.connString, Program.txtMysqlDbcDb, out Program.MySqlDbcConnection))
                throw new Exception($"Unable to open database connection for {Program.txtMysqlDbcDb}");

            // Sniffs DB.
            if (!CheckDBConnection(Program.connString, Program.txtMysqlSniffsDB, out Program.MySqlSniffsConnection))
                Program.SniffsInstalled = false;

            // Begin loading data.
            LoadingWorker.RunWorkerAsync();
        }

        private void LoadingWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                List<LoadingAction> loadingActions = new List<LoadingAction>
                {
                    new LoadingAction(() => GameData.LoadBroadcastTexts(Program.MySqlWorldConnection), "Loading broadcast texts ..."),
                    new LoadingAction(() => GameData.LoadQuests(Program.MySqlWorldConnection), "Loading quests ..."),
                    new LoadingAction(() => GameData.LoadGameObjects(Program.MySqlWorldConnection), "Loading game objects ..."),
                    new LoadingAction(() => GameData.LoadCreatures(Program.MySqlWorldConnection), "Loading creatures ..."),
                    new LoadingAction(() => GameData.LoadItems(Program.MySqlWorldConnection), "Loading items ..."),
                    new LoadingAction(() => GameData.LoadCondition(Program.MySqlWorldConnection), "Loading conditions ..."),
                    new LoadingAction(() => GameData.LoadAreas(Program.MySqlWorldConnection), "Loading areas ..."),
                    new LoadingAction(() => GameData.LoadCreatureSpells(Program.MySqlWorldConnection), "Loading creature spells ..."),
                    new LoadingAction(() => GameData.LoadCreatureMovement(Program.MySqlWorldConnection), "Loading creature movement ..."),
                    new LoadingAction(() => GameData.LoadCreatureMovementSpecial(Program.MySqlWorldConnection), "Loading creature movement special ..."),
                    new LoadingAction(() => GameData.LoadCreatureMovementTemplate(Program.MySqlWorldConnection), "Loading creature movement templates ..."),

                    new LoadingAction(() => GameData.LoadFactions(Program.MySqlDbcConnection), "Loading factions ..."),
                    new LoadingAction(() => GameData.LoadFactionTemplates(Program.MySqlDbcConnection), "Loading faction templates ..."),
                    new LoadingAction(() => GameData.LoadCreatureDisplayInfo(Program.MySqlDbcConnection), "Loading creature display info ..."),
                    new LoadingAction(() => GameData.LoadSpells(Program.MySqlDbcConnection), "Loading spells ..."),

                    new LoadingAction(() => GameData.LoadCreatureSpellsSniffs(Program.MySqlSniffsConnection), "Loading creature spell sniffs ...")
                };

                LoadingWorker.ReportProgress(0, new Action(() =>
                {
                    LoadingBar.Step = 1;
                    LoadingBar.Maximum = loadingActions.Count;
                }));

                foreach (LoadingAction _action in loadingActions)
                {
                    LoadingWorker.ReportProgress(0, new Action(() => LoadingStatusText.Text = _action.IndicatorText));
                    _action.Action();
                    LoadingWorker.ReportProgress(1);
                }

                e.Result = true;
            }
            catch (Exception ex)
            {
                e.Result = ex;
            }
        }

        private void LoadingWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage > 0)
                LoadingBar.PerformStep();

            if (e.UserState is Action a)
                a.Invoke();
        }

        private void LoadingWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result is Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

            LoadingBar.Visible = false;
            menuStrip1.Enabled = true;
            statusStrip1.Visible = false;           
        }

        private bool CheckDBConnection(string connString, string database, out MySqlConnection c)
        {
            c = new MySqlConnection(string.Format(connString, database));
            try
            {
                c.Open();

                if (!database.Equals(Program.txtMysqlSniffsDB))
                    return true;

                using (MySqlCommand command = c.CreateCommand())
                {
                    command.CommandText = "show tables";
                    using (MySqlDataReader reader = command.ExecuteReader())
                        while (reader.Read())
                            if (reader.GetString(0).ToLower() == "creature_spell_timers")
                                return true;
                }
            }
            catch { }

            c?.Dispose();
            return false;
        }

        private void ScriptEditor_Click(object sender, EventArgs e)
        {
            FormScriptEditor editor = new FormScriptEditor();
            editor.CenterToParent(this);
            editor.Show(this);
        }

        private void EventEditor_Click(object sender, EventArgs e)
        {
            FormEventEditor editor = new FormEventEditor();
            editor.CenterToParent(this);
            editor.Show(this);
        }

        private void CreatureSpellEditor_Click(object sender, EventArgs e)
        {
            FormCastsEditor editor = new FormCastsEditor();
            editor.CenterToParent(this);
            editor.Show(this);
        }

        private void ConditionEditor_Click(object sender, EventArgs e)
        {
            FormConditionFinder editor = new FormConditionFinder();
            editor.CenterToParent(this);
            editor.ShowStandalone(this);
            
        }

        private void Waypoints_Click(object sender, EventArgs e)
        {
            FormWaypointEditor form = new FormWaypointEditor();
            form.CenterToParent(this);
            form.Show(this);
        }

        private void CreatureEditor_Click(object sender, EventArgs e)
        {
            FormCreatureEditor form = new FormCreatureEditor();
            form.CenterToParent(this);
            form.Show(this);
        }

        private void Finders_Click(object sender, EventArgs e)
        {
            if (!(sender is ToolStripMenuItem tItem))
                return;

            if (!Enum.TryParse(tItem.Tag.ToString(), out Globals.Finders finder))
                return;

            Form form = null;
            switch (finder)
            {
                case Globals.Finders.Areas:
                    form = new FormAreaFinder();
                    break;
                case Globals.Finders.Events:
                    form = new FormEventFinder();
                    break;
                case Globals.Finders.Creatures:
                    form = new FormCreatureFinder();
                    break;
                case Globals.Finders.Factions:
                    form = new FormFactionFinder();
                    break;
                case Globals.Finders.FactionTemplates:
                    form = new FormFactionTemplateFinder();
                    break;
                case Globals.Finders.Items:
                    form = new FormEventFinder();
                    break;
                case Globals.Finders.GameObjects:
                    form = new FormGameObjectFinder();
                    break;
                case Globals.Finders.Quests:
                    form = new FormQuestFinder();
                    break;
                case Globals.Finders.Spells:
                    form = new FormSpellFinder();
                    break;
                case Globals.Finders.Taxis:
                    form = new FormTaxiFinder();
                    break;
                case Globals.Finders.BroadcastTexts:
                    form = new FormTaxiFinder();
                    break;
            }

            form?.ShowDialog(this);
        }

        private void FlagHelper_Click(object sender, EventArgs e)
        {
            if (!(sender is ToolStripMenuItem tItem))
                return;

            if (!Enum.TryParse(tItem.Tag.ToString(), out Globals.FlagHelpers fHelper))
                return;

            uint flags = 0;
            switch (fHelper)
            {
                case Globals.FlagHelpers.GenericFlags:
                    Helpers.ShowFlagInputDialog(this, ref flags, "Generic Flags", null);
                    break;
                case Globals.FlagHelpers.GameObjectDynamicFlags:
                    Helpers.ShowFlagInputDialog(this, ref flags, "Game Object Dynamic Flags (UF)", GameData.GameObjectDynFlagsList);
                    break;
                case Globals.FlagHelpers.GameObjectFlags:
                    Helpers.ShowFlagInputDialog(this, ref flags, "Game Object Flags (UF)", GameData.GameObjectFlagsList);
                    break;
                case Globals.FlagHelpers.UnitFlags:
                    Helpers.ShowFlagInputDialog(this, ref flags, "Unit Flags (UF)", GameData.UnitFieldFlagsList);
                    break;
                case Globals.FlagHelpers.UnitDynamicFlags:
                    Helpers.ShowFlagInputDialog(this, ref flags, "Unit Dynamic Flags (UF)", GameData.UnitDynamicFlagsList);
                    break;
                case Globals.FlagHelpers.SpellMechanicMask:
                    Helpers.ShowFlagInputDialog(this, ref flags, "Spell Mechanic Mask", GameData.SpellMechanicMaskList);
                    break;
                case Globals.FlagHelpers.PlayerFlags:
                    Helpers.ShowFlagInputDialog(this, ref flags, "Player Flags (UF)", GameData.PlayerFlagsList);
                    break;
                case Globals.FlagHelpers.NpcFlags:
                    Helpers.ShowFlagInputDialog(this, ref flags, "NPC Flags (UF)", GameData.UnitNpcFlagsList);
                    break;
            }
        }
    }
}
