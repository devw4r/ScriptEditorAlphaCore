namespace ScriptEditor.DataFinderForms
{
    partial class FormFinderGeneric
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
            this.OlvListView = new BrightIdeasSoftware.ObjectListView();
            this.PnlBack = new System.Windows.Forms.Panel();
            this.PnlSearch = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblSeparator = new System.Windows.Forms.Label();
            this.BtnIgnore = new System.Windows.Forms.Button();
            this.BtnNone = new System.Windows.Forms.Button();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OlvListView)).BeginInit();
            this.PnlBack.SuspendLayout();
            this.PnlSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OlvListView
            // 
            //this.OlvListView.CellEditUseWholeCell = false;
            this.OlvListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OlvListView.FullRowSelect = true;
            this.OlvListView.GridLines = true;
            this.OlvListView.HasCollapsibleGroups = false;
            this.OlvListView.HideSelection = false;
            this.OlvListView.Location = new System.Drawing.Point(0, 54);
            this.OlvListView.MultiSelect = false;
            this.OlvListView.Name = "OlvListView";
            this.OlvListView.ShowGroups = false;
            this.OlvListView.Size = new System.Drawing.Size(796, 348);
            this.OlvListView.TabIndex = 0;
            this.OlvListView.UseCompatibleStateImageBehavior = false;
            this.OlvListView.UseFiltering = true;
            this.OlvListView.View = System.Windows.Forms.View.Details;
            this.OlvListView.VirtualMode = false;
            // 
            // PnlBack
            // 
            this.PnlBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlBack.Controls.Add(this.OlvListView);
            this.PnlBack.Controls.Add(this.PnlSearch);
            this.PnlBack.Controls.Add(this.panel1);
            this.PnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlBack.Location = new System.Drawing.Point(0, 0);
            this.PnlBack.Name = "PnlBack";
            this.PnlBack.Size = new System.Drawing.Size(800, 450);
            this.PnlBack.TabIndex = 1;
            // 
            // PnlSearch
            // 
            this.PnlSearch.Controls.Add(this.label1);
            this.PnlSearch.Controls.Add(this.TxtSearch);
            this.PnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSearch.Location = new System.Drawing.Point(0, 0);
            this.PnlSearch.Name = "PnlSearch";
            this.PnlSearch.Size = new System.Drawing.Size(796, 54);
            this.PnlSearch.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filter:";
            // 
            // TxtSearch
            // 
            this.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSearch.Location = new System.Drawing.Point(10, 26);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(310, 20);
            this.TxtSearch.TabIndex = 2;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblSeparator);
            this.panel1.Controls.Add(this.BtnIgnore);
            this.panel1.Controls.Add(this.BtnNone);
            this.panel1.Controls.Add(this.BtnSelect);
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 44);
            this.panel1.TabIndex = 4;
            // 
            // LblSeparator
            // 
            this.LblSeparator.BackColor = System.Drawing.Color.DimGray;
            this.LblSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.LblSeparator.Location = new System.Drawing.Point(0, 0);
            this.LblSeparator.Name = "LblSeparator";
            this.LblSeparator.Size = new System.Drawing.Size(796, 2);
            this.LblSeparator.TabIndex = 4;
            // 
            // BtnIgnore
            // 
            this.BtnIgnore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIgnore.Location = new System.Drawing.Point(408, 11);
            this.BtnIgnore.Name = "BtnIgnore";
            this.BtnIgnore.Size = new System.Drawing.Size(90, 23);
            this.BtnIgnore.TabIndex = 3;
            this.BtnIgnore.Text = "Select Ignore";
            this.BtnIgnore.UseVisualStyleBackColor = true;
            this.BtnIgnore.Click += new System.EventHandler(this.BtnIgnore_Click);
            // 
            // BtnNone
            // 
            this.BtnNone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNone.Location = new System.Drawing.Point(504, 11);
            this.BtnNone.Name = "BtnNone";
            this.BtnNone.Size = new System.Drawing.Size(90, 23);
            this.BtnNone.TabIndex = 2;
            this.BtnNone.Text = "Select None";
            this.BtnNone.UseVisualStyleBackColor = true;
            this.BtnNone.Click += new System.EventHandler(this.BtnNone_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSelect.Location = new System.Drawing.Point(600, 11);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(90, 23);
            this.BtnSelect.TabIndex = 1;
            this.BtnSelect.Text = "Select";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(696, 11);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(90, 23);
            this.BtnCancel.TabIndex = 0;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FormFinderGeneric
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlBack);
            this.DoubleBuffered = true;
            this.Name = "FormFinderGeneric";
            this.Text = "FormFinderGeneric";
            ((System.ComponentModel.ISupportInitialize)(this.OlvListView)).EndInit();
            this.PnlBack.ResumeLayout(false);
            this.PnlSearch.ResumeLayout(false);
            this.PnlSearch.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView OlvListView;
        private System.Windows.Forms.Panel PnlBack;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Panel PnlSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnIgnore;
        private System.Windows.Forms.Button BtnNone;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Label LblSeparator;
    }
}