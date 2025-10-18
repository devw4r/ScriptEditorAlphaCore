namespace ScriptEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiEditors = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiScripts = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreatureEvents = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreatureSpells = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiConditions = new System.Windows.Forms.ToolStripMenuItem();
            this.waypointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFinders = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAreaFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCreatureFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEventFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFactionFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFactionTemplateFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGameObjectFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiItemFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiQuestFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSpellFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTaxiFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTextFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlags = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlagsGeneric = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiFlagsGameObjectUF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlagsGameObjectDynUF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlagsUnitUF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlagsUnitDynamicUF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlagsNpcUF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlagsPlayerUF = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFlagsSpellMechanic = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LoadingBar = new System.Windows.Forms.ToolStripProgressBar();
            this.LoadingStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.BtnWaypoints = new System.Windows.Forms.Button();
            this.BtnScriptEditor = new System.Windows.Forms.Button();
            this.BtnEventEditor = new System.Windows.Forms.Button();
            this.BtnSpellEditor = new System.Windows.Forms.Button();
            this.BtnConditionsEditor = new System.Windows.Forms.Button();
            this.BtnCreatureEditor = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Enabled = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditors,
            this.tsmiFinders,
            this.tsmiHelpers});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(581, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiEditors
            // 
            this.tsmiEditors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiScripts,
            this.tsmiCreatureEvents,
            this.tsmiCreatureSpells,
            this.tsmiConditions,
            this.waypointsToolStripMenuItem});
            this.tsmiEditors.Name = "tsmiEditors";
            this.tsmiEditors.Size = new System.Drawing.Size(55, 20);
            this.tsmiEditors.Text = "Editors";
            // 
            // tsmiScripts
            // 
            this.tsmiScripts.Name = "tsmiScripts";
            this.tsmiScripts.Size = new System.Drawing.Size(180, 22);
            this.tsmiScripts.Text = "Scripts";
            this.tsmiScripts.Click += new System.EventHandler(this.ScriptEditor_Click);
            // 
            // tsmiCreatureEvents
            // 
            this.tsmiCreatureEvents.Name = "tsmiCreatureEvents";
            this.tsmiCreatureEvents.Size = new System.Drawing.Size(180, 22);
            this.tsmiCreatureEvents.Text = "Events";
            this.tsmiCreatureEvents.Click += new System.EventHandler(this.EventEditor_Click);
            // 
            // tsmiCreatureSpells
            // 
            this.tsmiCreatureSpells.Name = "tsmiCreatureSpells";
            this.tsmiCreatureSpells.Size = new System.Drawing.Size(180, 22);
            this.tsmiCreatureSpells.Text = "Spells";
            this.tsmiCreatureSpells.Click += new System.EventHandler(this.CreatureSpellEditor_Click);
            // 
            // tsmiConditions
            // 
            this.tsmiConditions.Name = "tsmiConditions";
            this.tsmiConditions.Size = new System.Drawing.Size(180, 22);
            this.tsmiConditions.Text = "Conditions";
            this.tsmiConditions.Click += new System.EventHandler(this.ConditionEditor_Click);
            // 
            // waypointsToolStripMenuItem
            // 
            this.waypointsToolStripMenuItem.Name = "waypointsToolStripMenuItem";
            this.waypointsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.waypointsToolStripMenuItem.Text = "Waypoints";
            this.waypointsToolStripMenuItem.Click += new System.EventHandler(this.Waypoints_Click);
            // 
            // tsmiFinders
            // 
            this.tsmiFinders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAreaFinder,
            this.tsmiCreatureFinder,
            this.tsmiEventFinder,
            this.tsmiFactionFinder,
            this.tsmiFactionTemplateFinder,
            this.tsmiGameObjectFinder,
            this.tsmiItemFinder,
            this.tsmiQuestFinder,
            this.tsmiSpellFinder,
            this.tsmiTaxiFinder,
            this.tsmiTextFinder});
            this.tsmiFinders.Name = "tsmiFinders";
            this.tsmiFinders.Size = new System.Drawing.Size(57, 20);
            this.tsmiFinders.Text = "Finders";
            // 
            // tsmiAreaFinder
            // 
            this.tsmiAreaFinder.Name = "tsmiAreaFinder";
            this.tsmiAreaFinder.Size = new System.Drawing.Size(169, 22);
            this.tsmiAreaFinder.Tag = "Areas";
            this.tsmiAreaFinder.Text = "Areas";
            this.tsmiAreaFinder.Click += new System.EventHandler(this.Finders_Click);
            // 
            // tsmiCreatureFinder
            // 
            this.tsmiCreatureFinder.Name = "tsmiCreatureFinder";
            this.tsmiCreatureFinder.Size = new System.Drawing.Size(169, 22);
            this.tsmiCreatureFinder.Tag = "Creatures";
            this.tsmiCreatureFinder.Text = "Creature";
            this.tsmiCreatureFinder.Click += new System.EventHandler(this.Finders_Click);
            // 
            // tsmiEventFinder
            // 
            this.tsmiEventFinder.Name = "tsmiEventFinder";
            this.tsmiEventFinder.Size = new System.Drawing.Size(169, 22);
            this.tsmiEventFinder.Tag = "Events";
            this.tsmiEventFinder.Text = "Events";
            this.tsmiEventFinder.Click += new System.EventHandler(this.Finders_Click);
            // 
            // tsmiFactionFinder
            // 
            this.tsmiFactionFinder.Name = "tsmiFactionFinder";
            this.tsmiFactionFinder.Size = new System.Drawing.Size(169, 22);
            this.tsmiFactionFinder.Tag = "Factions";
            this.tsmiFactionFinder.Text = "Factions";
            this.tsmiFactionFinder.Click += new System.EventHandler(this.Finders_Click);
            // 
            // tsmiFactionTemplateFinder
            // 
            this.tsmiFactionTemplateFinder.Name = "tsmiFactionTemplateFinder";
            this.tsmiFactionTemplateFinder.Size = new System.Drawing.Size(169, 22);
            this.tsmiFactionTemplateFinder.Tag = "FactionTemplates";
            this.tsmiFactionTemplateFinder.Text = "Faction Templates";
            this.tsmiFactionTemplateFinder.Click += new System.EventHandler(this.Finders_Click);
            // 
            // tsmiGameObjectFinder
            // 
            this.tsmiGameObjectFinder.Name = "tsmiGameObjectFinder";
            this.tsmiGameObjectFinder.Size = new System.Drawing.Size(169, 22);
            this.tsmiGameObjectFinder.Tag = "GameObjects";
            this.tsmiGameObjectFinder.Text = "Game Objects";
            this.tsmiGameObjectFinder.Click += new System.EventHandler(this.Finders_Click);
            // 
            // tsmiItemFinder
            // 
            this.tsmiItemFinder.Name = "tsmiItemFinder";
            this.tsmiItemFinder.Size = new System.Drawing.Size(169, 22);
            this.tsmiItemFinder.Tag = "Items";
            this.tsmiItemFinder.Text = "Items";
            this.tsmiItemFinder.Click += new System.EventHandler(this.Finders_Click);
            // 
            // tsmiQuestFinder
            // 
            this.tsmiQuestFinder.Name = "tsmiQuestFinder";
            this.tsmiQuestFinder.Size = new System.Drawing.Size(169, 22);
            this.tsmiQuestFinder.Tag = "Quests";
            this.tsmiQuestFinder.Text = "Quests";
            this.tsmiQuestFinder.Click += new System.EventHandler(this.Finders_Click);
            // 
            // tsmiSpellFinder
            // 
            this.tsmiSpellFinder.Name = "tsmiSpellFinder";
            this.tsmiSpellFinder.Size = new System.Drawing.Size(169, 22);
            this.tsmiSpellFinder.Tag = "Spells";
            this.tsmiSpellFinder.Text = "Spells";
            this.tsmiSpellFinder.Click += new System.EventHandler(this.Finders_Click);
            // 
            // tsmiTaxiFinder
            // 
            this.tsmiTaxiFinder.Name = "tsmiTaxiFinder";
            this.tsmiTaxiFinder.Size = new System.Drawing.Size(169, 22);
            this.tsmiTaxiFinder.Tag = "Taxis";
            this.tsmiTaxiFinder.Text = "Taxis";
            this.tsmiTaxiFinder.Click += new System.EventHandler(this.Finders_Click);
            // 
            // tsmiTextFinder
            // 
            this.tsmiTextFinder.Name = "tsmiTextFinder";
            this.tsmiTextFinder.Size = new System.Drawing.Size(169, 22);
            this.tsmiTextFinder.Tag = "BroadcastTexts";
            this.tsmiTextFinder.Text = "Broadcast Texts";
            this.tsmiTextFinder.Click += new System.EventHandler(this.Finders_Click);
            // 
            // tsmiHelpers
            // 
            this.tsmiHelpers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFlags});
            this.tsmiHelpers.Name = "tsmiHelpers";
            this.tsmiHelpers.Size = new System.Drawing.Size(59, 20);
            this.tsmiHelpers.Text = "Helpers";
            // 
            // tsmiFlags
            // 
            this.tsmiFlags.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFlagsGeneric,
            this.toolStripSeparator1,
            this.tsmiFlagsGameObjectUF,
            this.tsmiFlagsGameObjectDynUF,
            this.tsmiFlagsUnitUF,
            this.tsmiFlagsUnitDynamicUF,
            this.tsmiFlagsNpcUF,
            this.tsmiFlagsPlayerUF,
            this.tsmiFlagsSpellMechanic});
            this.tsmiFlags.Name = "tsmiFlags";
            this.tsmiFlags.Size = new System.Drawing.Size(101, 22);
            this.tsmiFlags.Text = "Flags";
            // 
            // tsmiFlagsGeneric
            // 
            this.tsmiFlagsGeneric.Name = "tsmiFlagsGeneric";
            this.tsmiFlagsGeneric.Size = new System.Drawing.Size(218, 22);
            this.tsmiFlagsGeneric.Tag = "GenericFlags";
            this.tsmiFlagsGeneric.Text = "Generic";
            this.tsmiFlagsGeneric.Click += new System.EventHandler(this.FlagHelper_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(215, 6);
            // 
            // tsmiFlagsGameObjectUF
            // 
            this.tsmiFlagsGameObjectUF.Name = "tsmiFlagsGameObjectUF";
            this.tsmiFlagsGameObjectUF.Size = new System.Drawing.Size(218, 22);
            this.tsmiFlagsGameObjectUF.Tag = "GameObjectFlags";
            this.tsmiFlagsGameObjectUF.Text = "Game Object Flags (UF)";
            this.tsmiFlagsGameObjectUF.Click += new System.EventHandler(this.FlagHelper_Click);
            // 
            // tsmiFlagsGameObjectDynUF
            // 
            this.tsmiFlagsGameObjectDynUF.Name = "tsmiFlagsGameObjectDynUF";
            this.tsmiFlagsGameObjectDynUF.Size = new System.Drawing.Size(218, 22);
            this.tsmiFlagsGameObjectDynUF.Tag = "GameObjectDynamicFlags";
            this.tsmiFlagsGameObjectDynUF.Text = "Game Object Dynamic (UF)";
            this.tsmiFlagsGameObjectDynUF.Click += new System.EventHandler(this.FlagHelper_Click);
            // 
            // tsmiFlagsUnitUF
            // 
            this.tsmiFlagsUnitUF.Name = "tsmiFlagsUnitUF";
            this.tsmiFlagsUnitUF.Size = new System.Drawing.Size(218, 22);
            this.tsmiFlagsUnitUF.Tag = "UnitFlags";
            this.tsmiFlagsUnitUF.Text = "Unit (UF)";
            this.tsmiFlagsUnitUF.Click += new System.EventHandler(this.FlagHelper_Click);
            // 
            // tsmiFlagsUnitDynamicUF
            // 
            this.tsmiFlagsUnitDynamicUF.Name = "tsmiFlagsUnitDynamicUF";
            this.tsmiFlagsUnitDynamicUF.Size = new System.Drawing.Size(218, 22);
            this.tsmiFlagsUnitDynamicUF.Tag = "UnitDynamicFlags";
            this.tsmiFlagsUnitDynamicUF.Text = "Unit Dynamic (UF)";
            this.tsmiFlagsUnitDynamicUF.Click += new System.EventHandler(this.FlagHelper_Click);
            // 
            // tsmiFlagsNpcUF
            // 
            this.tsmiFlagsNpcUF.Name = "tsmiFlagsNpcUF";
            this.tsmiFlagsNpcUF.Size = new System.Drawing.Size(218, 22);
            this.tsmiFlagsNpcUF.Tag = "NpcFlags";
            this.tsmiFlagsNpcUF.Text = "Npc (UF)";
            this.tsmiFlagsNpcUF.Click += new System.EventHandler(this.FlagHelper_Click);
            // 
            // tsmiFlagsPlayerUF
            // 
            this.tsmiFlagsPlayerUF.Name = "tsmiFlagsPlayerUF";
            this.tsmiFlagsPlayerUF.Size = new System.Drawing.Size(218, 22);
            this.tsmiFlagsPlayerUF.Tag = "PlayerFlags";
            this.tsmiFlagsPlayerUF.Text = "Player (UF)";
            this.tsmiFlagsPlayerUF.Click += new System.EventHandler(this.FlagHelper_Click);
            // 
            // tsmiFlagsSpellMechanic
            // 
            this.tsmiFlagsSpellMechanic.Name = "tsmiFlagsSpellMechanic";
            this.tsmiFlagsSpellMechanic.Size = new System.Drawing.Size(218, 22);
            this.tsmiFlagsSpellMechanic.Tag = "SpellMechanicMask";
            this.tsmiFlagsSpellMechanic.Text = "Spell Mechanic Mask";
            this.tsmiFlagsSpellMechanic.Click += new System.EventHandler(this.FlagHelper_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadingBar,
            this.LoadingStatusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 244);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(581, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LoadingBar
            // 
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(100, 16);
            this.LoadingBar.Step = 11;
            // 
            // LoadingStatusText
            // 
            this.LoadingStatusText.BackColor = System.Drawing.SystemColors.Control;
            this.LoadingStatusText.Name = "LoadingStatusText";
            this.LoadingStatusText.Size = new System.Drawing.Size(62, 17);
            this.LoadingStatusText.Text = "Loading ...";
            // 
            // BtnWaypoints
            // 
            this.BtnWaypoints.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnWaypoints.Location = new System.Drawing.Point(160, 128);
            this.BtnWaypoints.Name = "BtnWaypoints";
            this.BtnWaypoints.Size = new System.Drawing.Size(129, 75);
            this.BtnWaypoints.TabIndex = 4;
            this.BtnWaypoints.Text = "Waypoints";
            this.BtnWaypoints.UseVisualStyleBackColor = true;
            this.BtnWaypoints.Click += new System.EventHandler(this.Waypoints_Click);
            // 
            // BtnScriptEditor
            // 
            this.BtnScriptEditor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnScriptEditor.Location = new System.Drawing.Point(25, 47);
            this.BtnScriptEditor.Name = "BtnScriptEditor";
            this.BtnScriptEditor.Size = new System.Drawing.Size(129, 75);
            this.BtnScriptEditor.TabIndex = 0;
            this.BtnScriptEditor.Text = "Scripts";
            this.BtnScriptEditor.UseVisualStyleBackColor = true;
            this.BtnScriptEditor.Click += new System.EventHandler(this.ScriptEditor_Click);
            // 
            // BtnEventEditor
            // 
            this.BtnEventEditor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnEventEditor.Location = new System.Drawing.Point(160, 47);
            this.BtnEventEditor.Name = "BtnEventEditor";
            this.BtnEventEditor.Size = new System.Drawing.Size(129, 75);
            this.BtnEventEditor.TabIndex = 1;
            this.BtnEventEditor.Text = "Events";
            this.BtnEventEditor.UseVisualStyleBackColor = true;
            this.BtnEventEditor.Click += new System.EventHandler(this.EventEditor_Click);
            // 
            // BtnSpellEditor
            // 
            this.BtnSpellEditor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnSpellEditor.Location = new System.Drawing.Point(295, 47);
            this.BtnSpellEditor.Name = "BtnSpellEditor";
            this.BtnSpellEditor.Size = new System.Drawing.Size(129, 75);
            this.BtnSpellEditor.TabIndex = 2;
            this.BtnSpellEditor.Text = "Spells";
            this.BtnSpellEditor.UseVisualStyleBackColor = true;
            this.BtnSpellEditor.Click += new System.EventHandler(this.CreatureSpellEditor_Click);
            // 
            // BtnConditionsEditor
            // 
            this.BtnConditionsEditor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnConditionsEditor.Location = new System.Drawing.Point(430, 47);
            this.BtnConditionsEditor.Name = "BtnConditionsEditor";
            this.BtnConditionsEditor.Size = new System.Drawing.Size(129, 75);
            this.BtnConditionsEditor.TabIndex = 3;
            this.BtnConditionsEditor.Text = "Conditions";
            this.BtnConditionsEditor.UseVisualStyleBackColor = true;
            this.BtnConditionsEditor.Click += new System.EventHandler(this.ConditionEditor_Click);
            // 
            // BtnCreatureEditor
            // 
            this.BtnCreatureEditor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnCreatureEditor.Location = new System.Drawing.Point(25, 128);
            this.BtnCreatureEditor.Name = "BtnCreatureEditor";
            this.BtnCreatureEditor.Size = new System.Drawing.Size(129, 75);
            this.BtnCreatureEditor.TabIndex = 7;
            this.BtnCreatureEditor.Text = "Creatures";
            this.BtnCreatureEditor.UseVisualStyleBackColor = true;
            this.BtnCreatureEditor.Click += new System.EventHandler(this.CreatureEditor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(581, 266);
            this.Controls.Add(this.BtnCreatureEditor);
            this.Controls.Add(this.BtnConditionsEditor);
            this.Controls.Add(this.BtnSpellEditor);
            this.Controls.Add(this.BtnEventEditor);
            this.Controls.Add(this.BtnScriptEditor);
            this.Controls.Add(this.BtnWaypoints);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlphaCore Developer Tools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditors;
        private System.Windows.Forms.ToolStripMenuItem tsmiScripts;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreatureEvents;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreatureSpells;
        private System.Windows.Forms.ToolStripMenuItem tsmiConditions;
        private System.Windows.Forms.ToolStripMenuItem tsmiFinders;
        private System.Windows.Forms.ToolStripMenuItem tsmiAreaFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiCreatureFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiEventFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiFactionFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiFactionTemplateFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiGameObjectFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiItemFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiQuestFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiSpellFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiTaxiFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiTextFinder;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpers;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlags;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsGeneric;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsGameObjectUF;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsGameObjectDynUF;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsUnitUF;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsUnitDynamicUF;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsNpcUF;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsPlayerUF;
        private System.Windows.Forms.ToolStripMenuItem tsmiFlagsSpellMechanic;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar LoadingBar;
        private System.Windows.Forms.ToolStripStatusLabel LoadingStatusText;
        private System.Windows.Forms.Button BtnWaypoints;
        private System.Windows.Forms.Button BtnScriptEditor;
        private System.Windows.Forms.Button BtnEventEditor;
        private System.Windows.Forms.Button BtnSpellEditor;
        private System.Windows.Forms.Button BtnConditionsEditor;
        private System.Windows.Forms.Button BtnCreatureEditor;
        private System.Windows.Forms.ToolStripMenuItem waypointsToolStripMenuItem;
    }
}