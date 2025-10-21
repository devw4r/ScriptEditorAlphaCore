namespace ScriptEditor
{
    partial class FormWaypointEditor
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
            this.lstWaypoints = new System.Windows.Forms.ListView();
            this.point = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.x = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.z = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wait_time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.script_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnLookup = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.cbTable = new System.Windows.Forms.ComboBox();
            this.lblTable = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.txtO = new System.Windows.Forms.TextBox();
            this.txtWait = new System.Windows.Forms.TextBox();
            this.btnEditScript = new System.Windows.Forms.Button();
            this.txtScript = new System.Windows.Forms.TextBox();
            this.txtWander = new System.Windows.Forms.TextBox();
            this.lblPoint = new System.Windows.Forms.Label();
            this.lblPosition_X = new System.Windows.Forms.Label();
            this.lblPositionY = new System.Windows.Forms.Label();
            this.lblPositionZ = new System.Windows.Forms.Label();
            this.lblOrientation = new System.Windows.Forms.Label();
            this.lblWaitTime = new System.Windows.Forms.Label();
            this.lblWander = new System.Windows.Forms.Label();
            this.lblScriptId = new System.Windows.Forms.Label();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.btnRemovePoint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnPort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstWaypoints
            // 
            this.lstWaypoints.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.point,
            this.x,
            this.y,
            this.z,
            this.wait_time,
            this.script_id});
            this.lstWaypoints.FullRowSelect = true;
            this.lstWaypoints.GridLines = true;
            this.lstWaypoints.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstWaypoints.HideSelection = false;
            this.lstWaypoints.Location = new System.Drawing.Point(12, 47);
            this.lstWaypoints.MultiSelect = false;
            this.lstWaypoints.Name = "lstWaypoints";
            this.lstWaypoints.Size = new System.Drawing.Size(394, 367);
            this.lstWaypoints.TabIndex = 0;
            this.lstWaypoints.UseCompatibleStateImageBehavior = false;
            this.lstWaypoints.View = System.Windows.Forms.View.Details;
            this.lstWaypoints.SelectedIndexChanged += new System.EventHandler(this.lstWaypoints_SelectedIndexChanged);
            // 
            // point
            // 
            this.point.Text = "point";
            this.point.Width = 40;
            // 
            // x
            // 
            this.x.Text = "x";
            // 
            // y
            // 
            this.y.Text = "y";
            // 
            // z
            // 
            this.z.Text = "z";
            // 
            // wait_time
            // 
            this.wait_time.Text = "wait";
            this.wait_time.Width = 50;
            // 
            // script_id
            // 
            this.script_id.Text = "script";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(430, 12);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(164, 20);
            this.txtId.TabIndex = 1;
            this.txtId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtId_KeyUp);
            // 
            // btnLookup
            // 
            this.btnLookup.Location = new System.Drawing.Point(600, 11);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(92, 21);
            this.btnLookup.TabIndex = 2;
            this.btnLookup.Text = "Lookup";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(698, 12);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(92, 21);
            this.btnFind.TabIndex = 3;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cbTable
            // 
            this.cbTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTable.FormattingEnabled = true;
            this.cbTable.Items.AddRange(new object[] {
            "creature_movement",
            "creature_movement_special",
            "creature_movement_template"});
            this.cbTable.Location = new System.Drawing.Point(52, 12);
            this.cbTable.Name = "cbTable";
            this.cbTable.Size = new System.Drawing.Size(307, 21);
            this.cbTable.TabIndex = 4;
            // 
            // lblTable
            // 
            this.lblTable.AutoSize = true;
            this.lblTable.Location = new System.Drawing.Point(12, 15);
            this.lblTable.Name = "lblTable";
            this.lblTable.Size = new System.Drawing.Size(34, 13);
            this.lblTable.TabIndex = 5;
            this.lblTable.Text = "Table";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(365, 15);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(59, 13);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "Creature Id";
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(494, 45);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(100, 20);
            this.txtPoint.TabIndex = 7;
            this.txtPoint.Tag = "clear";
            this.txtPoint.Leave += new System.EventHandler(this.txtPoint_Leave);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(494, 71);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 20);
            this.txtX.TabIndex = 8;
            this.txtX.Tag = "clear";
            this.txtX.Leave += new System.EventHandler(this.txtX_Leave);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(494, 97);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 20);
            this.txtY.TabIndex = 9;
            this.txtY.Tag = "clear";
            this.txtY.Leave += new System.EventHandler(this.txtY_Leave);
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(494, 123);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(100, 20);
            this.txtZ.TabIndex = 10;
            this.txtZ.Tag = "clear";
            this.txtZ.Leave += new System.EventHandler(this.txtZ_Leave);
            // 
            // txtO
            // 
            this.txtO.Location = new System.Drawing.Point(494, 149);
            this.txtO.Name = "txtO";
            this.txtO.Size = new System.Drawing.Size(100, 20);
            this.txtO.TabIndex = 11;
            this.txtO.Tag = "clear";
            this.txtO.Leave += new System.EventHandler(this.txtO_Leave);
            // 
            // txtWait
            // 
            this.txtWait.Location = new System.Drawing.Point(494, 175);
            this.txtWait.Name = "txtWait";
            this.txtWait.Size = new System.Drawing.Size(100, 20);
            this.txtWait.TabIndex = 12;
            this.txtWait.Tag = "clear";
            this.txtWait.Leave += new System.EventHandler(this.txtWait_Leave);
            // 
            // btnEditScript
            // 
            this.btnEditScript.Location = new System.Drawing.Point(600, 227);
            this.btnEditScript.Name = "btnEditScript";
            this.btnEditScript.Size = new System.Drawing.Size(100, 23);
            this.btnEditScript.TabIndex = 13;
            this.btnEditScript.Text = "Edit";
            this.btnEditScript.UseVisualStyleBackColor = true;
            this.btnEditScript.Click += new System.EventHandler(this.btnEditScript_Click);
            // 
            // txtScript
            // 
            this.txtScript.Location = new System.Drawing.Point(494, 230);
            this.txtScript.Name = "txtScript";
            this.txtScript.Size = new System.Drawing.Size(100, 20);
            this.txtScript.TabIndex = 14;
            this.txtScript.Tag = "clear";
            this.txtScript.Leave += new System.EventHandler(this.txtScript_Leave);
            // 
            // txtWander
            // 
            this.txtWander.Location = new System.Drawing.Point(494, 204);
            this.txtWander.Name = "txtWander";
            this.txtWander.Size = new System.Drawing.Size(100, 20);
            this.txtWander.TabIndex = 15;
            this.txtWander.Tag = "clear";
            this.txtWander.Leave += new System.EventHandler(this.txtWander_Leave);
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Location = new System.Drawing.Point(457, 48);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(31, 13);
            this.lblPoint.TabIndex = 16;
            this.lblPoint.Text = "Point";
            // 
            // lblPosition_X
            // 
            this.lblPosition_X.AutoSize = true;
            this.lblPosition_X.Location = new System.Drawing.Point(434, 74);
            this.lblPosition_X.Name = "lblPosition_X";
            this.lblPosition_X.Size = new System.Drawing.Size(54, 13);
            this.lblPosition_X.TabIndex = 17;
            this.lblPosition_X.Text = "Position X";
            // 
            // lblPositionY
            // 
            this.lblPositionY.AutoSize = true;
            this.lblPositionY.Location = new System.Drawing.Point(434, 100);
            this.lblPositionY.Name = "lblPositionY";
            this.lblPositionY.Size = new System.Drawing.Size(54, 13);
            this.lblPositionY.TabIndex = 18;
            this.lblPositionY.Text = "Position Y";
            // 
            // lblPositionZ
            // 
            this.lblPositionZ.AutoSize = true;
            this.lblPositionZ.Location = new System.Drawing.Point(434, 126);
            this.lblPositionZ.Name = "lblPositionZ";
            this.lblPositionZ.Size = new System.Drawing.Size(54, 13);
            this.lblPositionZ.TabIndex = 19;
            this.lblPositionZ.Text = "Position Z";
            // 
            // lblOrientation
            // 
            this.lblOrientation.AutoSize = true;
            this.lblOrientation.Location = new System.Drawing.Point(430, 152);
            this.lblOrientation.Name = "lblOrientation";
            this.lblOrientation.Size = new System.Drawing.Size(58, 13);
            this.lblOrientation.TabIndex = 20;
            this.lblOrientation.Text = "Orientation";
            // 
            // lblWaitTime
            // 
            this.lblWaitTime.AutoSize = true;
            this.lblWaitTime.Location = new System.Drawing.Point(437, 178);
            this.lblWaitTime.Name = "lblWaitTime";
            this.lblWaitTime.Size = new System.Drawing.Size(51, 13);
            this.lblWaitTime.TabIndex = 21;
            this.lblWaitTime.Text = "Wait time";
            // 
            // lblWander
            // 
            this.lblWander.AutoSize = true;
            this.lblWander.Location = new System.Drawing.Point(412, 207);
            this.lblWander.Name = "lblWander";
            this.lblWander.Size = new System.Drawing.Size(76, 13);
            this.lblWander.TabIndex = 22;
            this.lblWander.Text = "Wander radius";
            // 
            // lblScriptId
            // 
            this.lblScriptId.AutoSize = true;
            this.lblScriptId.Location = new System.Drawing.Point(442, 233);
            this.lblScriptId.Name = "lblScriptId";
            this.lblScriptId.Size = new System.Drawing.Size(46, 13);
            this.lblScriptId.TabIndex = 23;
            this.lblScriptId.Text = "Script Id";
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Location = new System.Drawing.Point(12, 420);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(75, 23);
            this.btnAddPoint.TabIndex = 24;
            this.btnAddPoint.Text = "Add point";
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // btnRemovePoint
            // 
            this.btnRemovePoint.Location = new System.Drawing.Point(93, 420);
            this.btnRemovePoint.Name = "btnRemovePoint";
            this.btnRemovePoint.Size = new System.Drawing.Size(92, 23);
            this.btnRemovePoint.TabIndex = 25;
            this.btnRemovePoint.Text = "Remove point";
            this.btnRemovePoint.UseVisualStyleBackColor = true;
            this.btnRemovePoint.Click += new System.EventHandler(this.btnRemovePoint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(713, 420);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 26;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(632, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Enabled = false;
            this.btnMoveUp.Location = new System.Drawing.Point(250, 420);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(75, 23);
            this.btnMoveUp.TabIndex = 28;
            this.btnMoveUp.Text = "Move up";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Enabled = false;
            this.btnMoveDown.Location = new System.Drawing.Point(331, 420);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(75, 23);
            this.btnMoveDown.TabIndex = 29;
            this.btnMoveDown.Text = "Move down";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);
            // 
            // btnPort
            // 
            this.btnPort.Location = new System.Drawing.Point(415, 390);
            this.btnPort.Name = "btnPort";
            this.btnPort.Size = new System.Drawing.Size(128, 23);
            this.btnPort.TabIndex = 30;
            this.btnPort.Text = "Port Command";
            this.btnPort.UseVisualStyleBackColor = true;
            this.btnPort.Click += new System.EventHandler(this.btnPort_Click);
            // 
            // FormWaypointEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPort);
            this.Controls.Add(this.btnMoveDown);
            this.Controls.Add(this.btnMoveUp);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRemovePoint);
            this.Controls.Add(this.btnAddPoint);
            this.Controls.Add(this.lblScriptId);
            this.Controls.Add(this.lblWander);
            this.Controls.Add(this.lblWaitTime);
            this.Controls.Add(this.lblOrientation);
            this.Controls.Add(this.lblPositionZ);
            this.Controls.Add(this.lblPositionY);
            this.Controls.Add(this.lblPosition_X);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.txtWander);
            this.Controls.Add(this.txtScript);
            this.Controls.Add(this.btnEditScript);
            this.Controls.Add(this.txtWait);
            this.Controls.Add(this.txtO);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblTable);
            this.Controls.Add(this.cbTable);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lstWaypoints);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "FormWaypointEditor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Waypoint Editor";
            this.Load += new System.EventHandler(this.FormWaypointEditor_Load);
            this.Shown += new System.EventHandler(this.WaypointEditor_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstWaypoints;
        private System.Windows.Forms.ColumnHeader point;
        private System.Windows.Forms.ColumnHeader x;
        private System.Windows.Forms.ColumnHeader y;
        private System.Windows.Forms.ColumnHeader z;
        private System.Windows.Forms.ColumnHeader wait_time;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.ComboBox cbTable;
        private System.Windows.Forms.Label lblTable;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ColumnHeader script_id;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.TextBox txtO;
        private System.Windows.Forms.TextBox txtWait;
        private System.Windows.Forms.Button btnEditScript;
        private System.Windows.Forms.TextBox txtScript;
        private System.Windows.Forms.TextBox txtWander;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label lblPosition_X;
        private System.Windows.Forms.Label lblPositionY;
        private System.Windows.Forms.Label lblPositionZ;
        private System.Windows.Forms.Label lblOrientation;
        private System.Windows.Forms.Label lblWaitTime;
        private System.Windows.Forms.Label lblWander;
        private System.Windows.Forms.Label lblScriptId;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Button btnRemovePoint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnPort;
    }
}