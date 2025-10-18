using System;
using System.Windows.Forms;
using System.Collections.Generic;

using BrightIdeasSoftware;

namespace ScriptEditor.DataFinderForms
{
    public partial class FormFinderGeneric : Form
    {
        public int ReturnValue;

        public FormFinderGeneric()
        {
            InitializeComponent();
        }

        public void Fill<T>(IList<T> items)
        {
            Text = $"{typeof(T).Name} Finder";
            
            Generator.GenerateColumns(OlvListView, items);

            foreach (OLVColumn c in OlvListView.Columns)
                c.MinimumWidth = 100;

            OlvListView.SetObjects(items);
            OlvListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtSearch.Text))
                OlvListView.ModelFilter = null;
            else
                OlvListView.ModelFilter = new TextMatchFilter(OlvListView, TxtSearch.Text);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnNone_Click(object sender, EventArgs e)
        {
            ReturnValue = 0;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnIgnore_Click(object sender, EventArgs e)
        {
            ReturnValue = -1;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (OlvListView.SelectedObject is null)
            {
                MessageBox.Show("Invalid selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(OlvListView.SelectedItem.SubItems[0].Text, out ReturnValue))
            {
                MessageBox.Show("Invalid selection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
