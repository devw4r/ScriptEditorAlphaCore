using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptEditor
{
    public partial class FormSpellSniffs : Form
    {
        public CreatureSpellsSniff SelectedSniff { get; set; }
        public uint Entry { get; set; }
        public uint SpellId { get; set; }
        public FormSpellSniffs()
        {
            InitializeComponent();
        }

        private void FormSpellSniffs_Shown(object sender, EventArgs e)
        {
            string spell = GameData.SpellInfoList.Find(x => x.ID == SpellId).Name;
            string creature = GameData.CreatureInfoList.Find(x => x.Entry == Entry / 10).Name;
            lblHeader.Text = string.Format("Sniffs for spell \"{0}\" used by creature \"{1}\"", spell, creature);

            List<CreatureSpellsSniff> list = GameData.CreatureSpellsSniffsList.FindAll(x => x.Entry == Entry / 10 && x.Spell_id == SpellId);

            foreach (CreatureSpellsSniff sniff in list)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = sniff.Initial_casts_count.ToString();
                lvi.SubItems.Add(sniff.Initial_delay_min.ToString());
                lvi.SubItems.Add(sniff.Initial_delay_average.ToString());
                lvi.SubItems.Add(sniff.Initial_delay_max.ToString());
                lvi.SubItems.Add(sniff.Repeat_casts_count.ToString());
                lvi.SubItems.Add(sniff.Repeat_delay_min.ToString());
                lvi.SubItems.Add(sniff.Repeat_delay_average.ToString());
                lvi.SubItems.Add(sniff.Repeat_delay_max.ToString());
                lvi.Tag = sniff;
                lvSpellSniffs.Items.Add(lvi);
            }
        }

        private void lvSpellSniffs_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedSniff = (CreatureSpellsSniff)lvSpellSniffs.SelectedItems[0].Tag;
        }

        private void lvSpellSniffs_DoubleClick(object sender, EventArgs e)
        {
            SelectedSniff = (CreatureSpellsSniff)lvSpellSniffs.SelectedItems[0].Tag;
            DialogResult = DialogResult.OK;
        }

        public void CenterToParent(IWin32Window owner)
        {
            if (!(owner is Form f))
                return;

            StartPosition = FormStartPosition.Manual;
            Owner = f;
            Location = new Point(f.Location.X + (f.Width - Width) / 2, f.Location.Y + (f.Height - Height) / 2);
        }
    }
}
