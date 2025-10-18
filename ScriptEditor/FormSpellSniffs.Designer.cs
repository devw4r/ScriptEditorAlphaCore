namespace ScriptEditor
{
    partial class FormSpellSniffs
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
            this.lvSpellSniffs = new System.Windows.Forms.ListView();
            this.InitialCastsCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InitialDelayMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InitialDelayAvg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InitialDelayMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RepeatCastsCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RepeatDelayMin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RepeatDelayAvg = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RepeatDelayMax = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvSpellSniffs
            // 
            this.lvSpellSniffs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.InitialCastsCount,
            this.InitialDelayMin,
            this.InitialDelayAvg,
            this.InitialDelayMax,
            this.RepeatCastsCount,
            this.RepeatDelayMin,
            this.RepeatDelayAvg,
            this.RepeatDelayMax});
            this.lvSpellSniffs.FullRowSelect = true;
            this.lvSpellSniffs.GridLines = true;
            this.lvSpellSniffs.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSpellSniffs.HideSelection = false;
            this.lvSpellSniffs.Location = new System.Drawing.Point(12, 35);
            this.lvSpellSniffs.Name = "lvSpellSniffs";
            this.lvSpellSniffs.Size = new System.Drawing.Size(735, 265);
            this.lvSpellSniffs.TabIndex = 0;
            this.lvSpellSniffs.UseCompatibleStateImageBehavior = false;
            this.lvSpellSniffs.View = System.Windows.Forms.View.Details;
            this.lvSpellSniffs.SelectedIndexChanged += new System.EventHandler(this.lvSpellSniffs_SelectedIndexChanged);
            this.lvSpellSniffs.DoubleClick += new System.EventHandler(this.lvSpellSniffs_DoubleClick);
            // 
            // InitialCastsCount
            // 
            this.InitialCastsCount.Text = "Initial casts";
            this.InitialCastsCount.Width = 80;
            // 
            // InitialDelayMin
            // 
            this.InitialDelayMin.Text = "Min. initial delay";
            this.InitialDelayMin.Width = 90;
            // 
            // InitialDelayAvg
            // 
            this.InitialDelayAvg.Text = "Avg. initial delay";
            this.InitialDelayAvg.Width = 90;
            // 
            // InitialDelayMax
            // 
            this.InitialDelayMax.Text = "Max. initial delay";
            this.InitialDelayMax.Width = 90;
            // 
            // RepeatCastsCount
            // 
            this.RepeatCastsCount.Text = "Repeat casts";
            this.RepeatCastsCount.Width = 80;
            // 
            // RepeatDelayMin
            // 
            this.RepeatDelayMin.Text = "Min. repeat delay";
            this.RepeatDelayMin.Width = 100;
            // 
            // RepeatDelayAvg
            // 
            this.RepeatDelayAvg.Text = "Avg. repeat delay";
            this.RepeatDelayAvg.Width = 100;
            // 
            // RepeatDelayMax
            // 
            this.RepeatDelayMax.Text = "Max. repeat delay";
            this.RepeatDelayMax.Width = 100;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(591, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(672, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(269, 13);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Sniffs for spell Armageddon used by creature Ragnaros.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(416, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Note: zero values will not be used.";
            // 
            // FormSpellSniffs
            // 
            this.ClientSize = new System.Drawing.Size(760, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvSpellSniffs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSpellSniffs";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Spell sniffs";
            this.Shown += new System.EventHandler(this.FormSpellSniffs_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvSpellSniffs;
        private System.Windows.Forms.ColumnHeader InitialCastsCount;
        private System.Windows.Forms.ColumnHeader InitialDelayMin;
        private System.Windows.Forms.ColumnHeader InitialDelayAvg;
        private System.Windows.Forms.ColumnHeader InitialDelayMax;
        private System.Windows.Forms.ColumnHeader RepeatCastsCount;
        private System.Windows.Forms.ColumnHeader RepeatDelayMin;
        private System.Windows.Forms.ColumnHeader RepeatDelayAvg;
        private System.Windows.Forms.ColumnHeader RepeatDelayMax;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label1;
    }
}