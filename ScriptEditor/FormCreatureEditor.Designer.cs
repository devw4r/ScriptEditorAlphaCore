namespace ScriptEditor
{
    partial class FormCreatureEditor
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
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.lblEntry = new System.Windows.Forms.Label();
            this.btnLookup = new System.Windows.Forms.Button();
            this.tcCreature = new System.Windows.Forms.TabControl();
            this.tabDisplay = new System.Windows.Forms.TabPage();
            this.lblMountDisplayIDinvalid = new System.Windows.Forms.Label();
            this.lblMountDisplayId = new System.Windows.Forms.Label();
            this.textMountDisplayId = new System.Windows.Forms.TextBox();
            this.lblDisplayID4invalid = new System.Windows.Forms.Label();
            this.lblDisplayID3invalid = new System.Windows.Forms.Label();
            this.lblDisplayID2invalid = new System.Windows.Forms.Label();
            this.lblDisplayID1invalid = new System.Windows.Forms.Label();
            this.lblDisplayID4 = new System.Windows.Forms.Label();
            this.lblDisplayID3 = new System.Windows.Forms.Label();
            this.lblDisplayID2 = new System.Windows.Forms.Label();
            this.lblDisplayId1 = new System.Windows.Forms.Label();
            this.txtDisplayId4 = new System.Windows.Forms.TextBox();
            this.txtDisplayId3 = new System.Windows.Forms.TextBox();
            this.txtDisplayId2 = new System.Windows.Forms.TextBox();
            this.txtDisplayId1 = new System.Windows.Forms.TextBox();
            this.lblSubname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSubname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabStats = new System.Windows.Forms.TabPage();
            this.tabFlags = new System.Windows.Forms.TabPage();
            this.Spawns = new System.Windows.Forms.TabPage();
            this.tcCreature.SuspendLayout();
            this.tabDisplay.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEntry
            // 
            this.txtEntry.Location = new System.Drawing.Point(49, 12);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(100, 20);
            this.txtEntry.TabIndex = 0;
            this.txtEntry.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEntry_KeyUp);
            // 
            // lblEntry
            // 
            this.lblEntry.AutoSize = true;
            this.lblEntry.Location = new System.Drawing.Point(12, 15);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(31, 13);
            this.lblEntry.TabIndex = 1;
            this.lblEntry.Text = "Entry";
            // 
            // btnLookup
            // 
            this.btnLookup.Location = new System.Drawing.Point(155, 10);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(75, 23);
            this.btnLookup.TabIndex = 2;
            this.btnLookup.Text = "Lookup";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // tcCreature
            // 
            this.tcCreature.Controls.Add(this.tabDisplay);
            this.tcCreature.Controls.Add(this.tabStats);
            this.tcCreature.Controls.Add(this.tabFlags);
            this.tcCreature.Controls.Add(this.Spawns);
            this.tcCreature.Enabled = false;
            this.tcCreature.Location = new System.Drawing.Point(12, 39);
            this.tcCreature.Name = "tcCreature";
            this.tcCreature.SelectedIndex = 0;
            this.tcCreature.Size = new System.Drawing.Size(776, 399);
            this.tcCreature.TabIndex = 3;
            // 
            // tabDisplay
            // 
            this.tabDisplay.Controls.Add(this.lblMountDisplayIDinvalid);
            this.tabDisplay.Controls.Add(this.lblMountDisplayId);
            this.tabDisplay.Controls.Add(this.textMountDisplayId);
            this.tabDisplay.Controls.Add(this.lblDisplayID4invalid);
            this.tabDisplay.Controls.Add(this.lblDisplayID3invalid);
            this.tabDisplay.Controls.Add(this.lblDisplayID2invalid);
            this.tabDisplay.Controls.Add(this.lblDisplayID1invalid);
            this.tabDisplay.Controls.Add(this.lblDisplayID4);
            this.tabDisplay.Controls.Add(this.lblDisplayID3);
            this.tabDisplay.Controls.Add(this.lblDisplayID2);
            this.tabDisplay.Controls.Add(this.lblDisplayId1);
            this.tabDisplay.Controls.Add(this.txtDisplayId4);
            this.tabDisplay.Controls.Add(this.txtDisplayId3);
            this.tabDisplay.Controls.Add(this.txtDisplayId2);
            this.tabDisplay.Controls.Add(this.txtDisplayId1);
            this.tabDisplay.Controls.Add(this.lblSubname);
            this.tabDisplay.Controls.Add(this.lblName);
            this.tabDisplay.Controls.Add(this.txtSubname);
            this.tabDisplay.Controls.Add(this.txtName);
            this.tabDisplay.Location = new System.Drawing.Point(4, 22);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tabDisplay.Size = new System.Drawing.Size(768, 373);
            this.tabDisplay.TabIndex = 0;
            this.tabDisplay.Text = "Display";
            this.tabDisplay.UseVisualStyleBackColor = true;
            // 
            // lblMountDisplayIDinvalid
            // 
            this.lblMountDisplayIDinvalid.AutoSize = true;
            this.lblMountDisplayIDinvalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMountDisplayIDinvalid.ForeColor = System.Drawing.Color.Red;
            this.lblMountDisplayIDinvalid.Location = new System.Drawing.Point(207, 223);
            this.lblMountDisplayIDinvalid.Name = "lblMountDisplayIDinvalid";
            this.lblMountDisplayIDinvalid.Size = new System.Drawing.Size(44, 13);
            this.lblMountDisplayIDinvalid.TabIndex = 18;
            this.lblMountDisplayIDinvalid.Text = "invalid";
            this.lblMountDisplayIDinvalid.Visible = false;
            // 
            // lblMountDisplayId
            // 
            this.lblMountDisplayId.AutoSize = true;
            this.lblMountDisplayId.Location = new System.Drawing.Point(12, 223);
            this.lblMountDisplayId.Name = "lblMountDisplayId";
            this.lblMountDisplayId.Size = new System.Drawing.Size(88, 13);
            this.lblMountDisplayId.TabIndex = 17;
            this.lblMountDisplayId.Text = "Mount Display ID";
            // 
            // textMountDisplayId
            // 
            this.textMountDisplayId.Location = new System.Drawing.Point(104, 220);
            this.textMountDisplayId.Name = "textMountDisplayId";
            this.textMountDisplayId.Size = new System.Drawing.Size(97, 20);
            this.textMountDisplayId.TabIndex = 16;
            // 
            // lblDisplayID4invalid
            // 
            this.lblDisplayID4invalid.AutoSize = true;
            this.lblDisplayID4invalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayID4invalid.ForeColor = System.Drawing.Color.Red;
            this.lblDisplayID4invalid.Location = new System.Drawing.Point(207, 176);
            this.lblDisplayID4invalid.Name = "lblDisplayID4invalid";
            this.lblDisplayID4invalid.Size = new System.Drawing.Size(44, 13);
            this.lblDisplayID4invalid.TabIndex = 15;
            this.lblDisplayID4invalid.Text = "invalid";
            this.lblDisplayID4invalid.Visible = false;
            // 
            // lblDisplayID3invalid
            // 
            this.lblDisplayID3invalid.AutoSize = true;
            this.lblDisplayID3invalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayID3invalid.ForeColor = System.Drawing.Color.Red;
            this.lblDisplayID3invalid.Location = new System.Drawing.Point(207, 150);
            this.lblDisplayID3invalid.Name = "lblDisplayID3invalid";
            this.lblDisplayID3invalid.Size = new System.Drawing.Size(44, 13);
            this.lblDisplayID3invalid.TabIndex = 14;
            this.lblDisplayID3invalid.Text = "invalid";
            this.lblDisplayID3invalid.Visible = false;
            // 
            // lblDisplayID2invalid
            // 
            this.lblDisplayID2invalid.AutoSize = true;
            this.lblDisplayID2invalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayID2invalid.ForeColor = System.Drawing.Color.Red;
            this.lblDisplayID2invalid.Location = new System.Drawing.Point(207, 124);
            this.lblDisplayID2invalid.Name = "lblDisplayID2invalid";
            this.lblDisplayID2invalid.Size = new System.Drawing.Size(44, 13);
            this.lblDisplayID2invalid.TabIndex = 13;
            this.lblDisplayID2invalid.Text = "invalid";
            this.lblDisplayID2invalid.Visible = false;
            // 
            // lblDisplayID1invalid
            // 
            this.lblDisplayID1invalid.AutoSize = true;
            this.lblDisplayID1invalid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayID1invalid.ForeColor = System.Drawing.Color.Red;
            this.lblDisplayID1invalid.Location = new System.Drawing.Point(207, 98);
            this.lblDisplayID1invalid.Name = "lblDisplayID1invalid";
            this.lblDisplayID1invalid.Size = new System.Drawing.Size(44, 13);
            this.lblDisplayID1invalid.TabIndex = 12;
            this.lblDisplayID1invalid.Text = "invalid";
            this.lblDisplayID1invalid.Visible = false;
            // 
            // lblDisplayID4
            // 
            this.lblDisplayID4.AutoSize = true;
            this.lblDisplayID4.Location = new System.Drawing.Point(36, 176);
            this.lblDisplayID4.Name = "lblDisplayID4";
            this.lblDisplayID4.Size = new System.Drawing.Size(64, 13);
            this.lblDisplayID4.TabIndex = 11;
            this.lblDisplayID4.Text = "Display ID 4";
            // 
            // lblDisplayID3
            // 
            this.lblDisplayID3.AutoSize = true;
            this.lblDisplayID3.Location = new System.Drawing.Point(36, 150);
            this.lblDisplayID3.Name = "lblDisplayID3";
            this.lblDisplayID3.Size = new System.Drawing.Size(64, 13);
            this.lblDisplayID3.TabIndex = 10;
            this.lblDisplayID3.Text = "Display ID 3";
            // 
            // lblDisplayID2
            // 
            this.lblDisplayID2.AutoSize = true;
            this.lblDisplayID2.Location = new System.Drawing.Point(36, 124);
            this.lblDisplayID2.Name = "lblDisplayID2";
            this.lblDisplayID2.Size = new System.Drawing.Size(64, 13);
            this.lblDisplayID2.TabIndex = 9;
            this.lblDisplayID2.Text = "Display ID 2";
            // 
            // lblDisplayId1
            // 
            this.lblDisplayId1.AutoSize = true;
            this.lblDisplayId1.Location = new System.Drawing.Point(36, 98);
            this.lblDisplayId1.Name = "lblDisplayId1";
            this.lblDisplayId1.Size = new System.Drawing.Size(64, 13);
            this.lblDisplayId1.TabIndex = 8;
            this.lblDisplayId1.Text = "Display ID 1";
            // 
            // txtDisplayId4
            // 
            this.txtDisplayId4.Location = new System.Drawing.Point(104, 173);
            this.txtDisplayId4.Name = "txtDisplayId4";
            this.txtDisplayId4.Size = new System.Drawing.Size(97, 20);
            this.txtDisplayId4.TabIndex = 7;
            // 
            // txtDisplayId3
            // 
            this.txtDisplayId3.Location = new System.Drawing.Point(104, 147);
            this.txtDisplayId3.Name = "txtDisplayId3";
            this.txtDisplayId3.Size = new System.Drawing.Size(97, 20);
            this.txtDisplayId3.TabIndex = 6;
            // 
            // txtDisplayId2
            // 
            this.txtDisplayId2.Location = new System.Drawing.Point(104, 121);
            this.txtDisplayId2.Name = "txtDisplayId2";
            this.txtDisplayId2.Size = new System.Drawing.Size(97, 20);
            this.txtDisplayId2.TabIndex = 5;
            // 
            // txtDisplayId1
            // 
            this.txtDisplayId1.Location = new System.Drawing.Point(104, 95);
            this.txtDisplayId1.Name = "txtDisplayId1";
            this.txtDisplayId1.Size = new System.Drawing.Size(97, 20);
            this.txtDisplayId1.TabIndex = 4;
            // 
            // lblSubname
            // 
            this.lblSubname.AutoSize = true;
            this.lblSubname.Location = new System.Drawing.Point(48, 49);
            this.lblSubname.Name = "lblSubname";
            this.lblSubname.Size = new System.Drawing.Size(52, 13);
            this.lblSubname.TabIndex = 3;
            this.lblSubname.Text = "Subname";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(65, 23);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // txtSubname
            // 
            this.txtSubname.Location = new System.Drawing.Point(104, 46);
            this.txtSubname.Name = "txtSubname";
            this.txtSubname.Size = new System.Drawing.Size(233, 20);
            this.txtSubname.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(104, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 20);
            this.txtName.TabIndex = 0;
            // 
            // tabStats
            // 
            this.tabStats.Location = new System.Drawing.Point(4, 22);
            this.tabStats.Name = "tabStats";
            this.tabStats.Padding = new System.Windows.Forms.Padding(3);
            this.tabStats.Size = new System.Drawing.Size(768, 373);
            this.tabStats.TabIndex = 1;
            this.tabStats.Text = "Stats";
            this.tabStats.UseVisualStyleBackColor = true;
            // 
            // tabFlags
            // 
            this.tabFlags.Location = new System.Drawing.Point(4, 22);
            this.tabFlags.Name = "tabFlags";
            this.tabFlags.Size = new System.Drawing.Size(768, 373);
            this.tabFlags.TabIndex = 2;
            this.tabFlags.Text = "Flags";
            this.tabFlags.UseVisualStyleBackColor = true;
            // 
            // Spawns
            // 
            this.Spawns.Location = new System.Drawing.Point(4, 22);
            this.Spawns.Name = "Spawns";
            this.Spawns.Padding = new System.Windows.Forms.Padding(3);
            this.Spawns.Size = new System.Drawing.Size(768, 373);
            this.Spawns.TabIndex = 3;
            this.Spawns.Text = "Spawns";
            this.Spawns.UseVisualStyleBackColor = true;
            // 
            // FormCreatureEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcCreature);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.lblEntry);
            this.Controls.Add(this.txtEntry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCreatureEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Creature Editor";
            this.Load += new System.EventHandler(this.FormCreatureEditor_Load);
            this.tcCreature.ResumeLayout(false);
            this.tabDisplay.ResumeLayout(false);
            this.tabDisplay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.Label lblEntry;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.TabControl tcCreature;
        private System.Windows.Forms.TabPage tabDisplay;
        private System.Windows.Forms.TabPage tabStats;
        private System.Windows.Forms.TabPage tabFlags;
        private System.Windows.Forms.Label lblSubname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSubname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDisplayID4invalid;
        private System.Windows.Forms.Label lblDisplayID3invalid;
        private System.Windows.Forms.Label lblDisplayID2invalid;
        private System.Windows.Forms.Label lblDisplayID1invalid;
        private System.Windows.Forms.Label lblDisplayID4;
        private System.Windows.Forms.Label lblDisplayID3;
        private System.Windows.Forms.Label lblDisplayID2;
        private System.Windows.Forms.Label lblDisplayId1;
        private System.Windows.Forms.TextBox txtDisplayId4;
        private System.Windows.Forms.TextBox txtDisplayId3;
        private System.Windows.Forms.TextBox txtDisplayId2;
        private System.Windows.Forms.TextBox txtDisplayId1;
        private System.Windows.Forms.TabPage Spawns;
        private System.Windows.Forms.Label lblMountDisplayIDinvalid;
        private System.Windows.Forms.Label lblMountDisplayId;
        private System.Windows.Forms.TextBox textMountDisplayId;
    }
}