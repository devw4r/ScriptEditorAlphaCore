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
    public partial class FormCreatureEditor : Form
    {
        private CreatureInfo currentCreature;

        public FormCreatureEditor()
        {
            InitializeComponent();
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            using(FormCreatureFinder form = new FormCreatureFinder())
            {
                form.ShowDialog();
                if(form.DialogResult == DialogResult.OK)
                {
                    txtEntry.Text = form.ReturnValue.ToString();
                    UpdateForm();
                }
            }
        }

        private void UpdateForm()
        {
            if (uint.TryParse(txtEntry.Text, out uint entry))
            {
                currentCreature = GameData.CreatureInfoList.Find(x => x.Entry == entry);
                if (currentCreature.Name != "")
                {
                    txtName.Text = currentCreature.Name;
                    txtSubname.Text = currentCreature.Subname;
                    txtDisplayId1.Text = currentCreature.Display_id1.ToString();
                    txtDisplayId2.Text = currentCreature.Display_id2.ToString();
                    txtDisplayId3.Text = currentCreature.Display_id3.ToString();
                    txtDisplayId4.Text = currentCreature.Display_id4.ToString();
                    textMountDisplayId.Text = currentCreature.Mount_display_id.ToString();                    

                    CheckDisplayIds();
                    tcCreature.Enabled = true;
                }
                else
                {
                    tcCreature.Enabled = false;
                }

            }
        }

        private void CheckDisplayIds()
        {
            lblDisplayID1invalid.Visible = !GameData.CreatureDisplayIdList.Contains(currentCreature.Display_id1);
            lblDisplayID2invalid.Visible = !GameData.CreatureDisplayIdList.Contains(currentCreature.Display_id2);
            lblDisplayID3invalid.Visible = !GameData.CreatureDisplayIdList.Contains(currentCreature.Display_id3);
            lblDisplayID4invalid.Visible = !GameData.CreatureDisplayIdList.Contains(currentCreature.Display_id4);
            lblMountDisplayIDinvalid.Visible = !GameData.CreatureDisplayIdList.Contains(currentCreature.Mount_display_id);
        }

        private void txtEntry_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(txtEntry.Text, out int entry))
                {
                    UpdateForm();
                }

            }
        }

        public void CenterToParent(IWin32Window owner)
        {
            if (!(owner is Form f))
                return;

            StartPosition = FormStartPosition.Manual;
            Owner = f;
            Location = new Point(f.Location.X + (f.Width - Width) / 2, f.Location.Y + (f.Height - Height) / 2);
        }

        private void FormCreatureEditor_Load(object sender, EventArgs e)
        {
            if (Parent != null)
                CenterToParent();
        }
    }
}
