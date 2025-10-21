using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ScriptEditor
{
    public partial class FormWaypointEditor : Form
    {
        private List<Waypoint> waypoints = new List<Waypoint>();
        // Use the same form when viewing script.
        FormScriptEditor script_editor = null;
        private bool is_dirty = false;

        public FormWaypointEditor()
        {
            InitializeComponent();
        }

        private void btnLookup_Click(object sender, EventArgs e)
        {
            using (FormCreatureFinder form = new FormCreatureFinder())
            {
                DialogResult result = form.ShowDialog();
                if(result == DialogResult.OK)
                {
                    txtId.Text = form.ReturnValue.ToString();
                }
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            waypoints.Clear();

            if (int.TryParse(txtId.Text, out int creature_id))
            {
                string table = cbTable.Items[cbTable.SelectedIndex].ToString();                

                if (table == "creature_movement")
                {
                    waypoints = GameData.CreatureMovementList.FindAll(x => x.Id == creature_id);
                }
                else if (table == "creature_movement_special")
                {
                    waypoints = GameData.CreatureMovementSpecialList.FindAll(x => x.Id == creature_id);
                }
                else if (table == "creature_movement_template")
                {
                    waypoints = GameData.CreatureMovementTemplateList.FindAll(x => x.Id == creature_id);
                }

                if (waypoints.Count > 0)
                {
                    UpdateList();
                }
            }
        }

        private void WaypointEditor_Shown(object sender, EventArgs e)
        {
            cbTable.SelectedIndex = 0;
        }

        private void txtId_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnFind.PerformClick();
            }
        }

        private void lstWaypoints_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstWaypoints.SelectedItems.Count > 0)
            {
                Waypoint point = (Waypoint)lstWaypoints.SelectedItems[0].Tag;
                txtPoint.Text = point.Point.ToString();
                txtX.Text = point.Position_x.ToString();
                txtY.Text = point.Position_y.ToString();
                txtZ.Text = point.Position_z.ToString();
                txtO.Text = point.Orientation.ToString();
                txtWait.Text = point.Waittime.ToString();
                txtWander.Text = point.Wander_distance.ToString();
                txtScript.Text = point.Script_id.ToString();
            }
            else
            {
                foreach(Control c in Controls)
                {
                    if ((string)c.Tag == "clear") c.Text = string.Empty;
                }
            }

            if (lstWaypoints.SelectedItems.Count > 0)
            {
                if (lstWaypoints.Items.IndexOf(lstWaypoints.SelectedItems[0]) == 0)
                {
                    btnMoveDown.Enabled = true;
                    btnMoveUp.Enabled = false;
                }
                else if (lstWaypoints.Items.IndexOf(lstWaypoints.SelectedItems[0]) + 1 == lstWaypoints.Items.Count)
                {
                    btnMoveUp.Enabled = true;
                    btnMoveDown.Enabled = false;
                }
                else if (lstWaypoints.Items.IndexOf(lstWaypoints.SelectedItems[0]) > 0 && lstWaypoints.Items.IndexOf(lstWaypoints.SelectedItems[0]) < lstWaypoints.Items.Count -1)
                {
                    btnMoveUp.Enabled = true;
                    btnMoveDown.Enabled = true;
                }
            }
            else
            {
                btnMoveUp.Enabled = false;
                btnMoveDown.Enabled = false;
            }
        }

        private void btnEditScript_Click(object sender, EventArgs e)
        {
            uint script_id = 0;
            uint.TryParse(txtScript.Text, out script_id);
            if (script_id > 0)
            {
                if ((script_editor == null) || (script_editor.IsDisposed))
                {
                    script_editor = new FormScriptEditor();
                    script_editor.Show();
                }
                else
                    script_editor.Focus();

                script_editor.LoadScript(script_id, "creature_movement_scripts");
                script_editor.SelectFirstAction();
            }
        }

        private void btnAddPoint_Click(object sender, EventArgs e)
        {            
            if (uint.TryParse(txtId.Text, out uint creatureId))
            {
                Waypoint point;
                if (waypoints.Any())
                {
                    uint last_point = waypoints.Last().Point;
                    point = new Waypoint(creatureId, last_point + 1);
                }
                else
                {
                    point = new Waypoint(creatureId, 0);
                }

                waypoints.Add(point);
                UpdateList(waypoints.Count - 1);
                is_dirty = true;
            }
        }

        private void UpdateList(int selected = 0)
        {
            lstWaypoints.Items.Clear();

            foreach (Waypoint point in waypoints)
            {
                ListViewItem item = new ListViewItem();

                item.Text = point.Point.ToString();
                item.SubItems.Add(point.Position_x.ToString());
                item.SubItems.Add(point.Position_y.ToString());
                item.SubItems.Add(point.Position_z.ToString());
                item.SubItems.Add(point.Waittime.ToString());
                item.SubItems.Add(point.Script_id.ToString());
                item.Tag = point;

                lstWaypoints.Items.Add(item);

            }

            lstWaypoints.EnsureVisible(selected);
            lstWaypoints.Items[selected].Selected = true;
        }

        private void btnRemovePoint_Click(object sender, EventArgs e)
        {
            if(waypoints.Count > 0 && lstWaypoints.SelectedItems.Count > 0)
            {
                waypoints.Remove((Waypoint)lstWaypoints.SelectedItems[0].Tag);
                // Reindex points
                uint index = waypoints[0].Point;
                foreach(Waypoint point in waypoints)
                {
                    point.Point = index;
                    index += 1;
                }
                UpdateList();
                is_dirty = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(is_dirty)
            {
                if(MessageBox.Show("You have unsaved changes. Do you really want to close the editor without saving?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DialogResult = DialogResult.Cancel;
                    Close();
                }
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(is_dirty)
            {
                string query = GenerateQuery();
                if(Helpers.ShowSaveDialog(ref query) == DialogResult.OK)
                {
                    MySqlConnection conn = new MySqlConnection(Program.worldConnString);
                    MySqlCommand command = conn.CreateCommand();

                    command.CommandText = query;
                    try
                    {
                        conn.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Save Script", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("You have no unsaved changes.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private string GenerateQuery()
        {
            string table = cbTable.Items[cbTable.SelectedIndex].ToString();
            string query = "";
            
            if(table == "creature_movement_template")
            {
                query = string.Format("DELETE FROM {0} WHERE entry = {1};\n\n", table, txtId.Text);
                query += string.Format("INSERT INTO {0} (entry, point, position_x, position_y, position_z, orientation, waittime, wander_distance, script_id) VALUES\n", table);
            }
            else
            {
                query = string.Format("DELETE FROM {0} WHERE id = {1};\n\n", table, txtId.Text);
                query += string.Format("INSERT INTO {0} (id, point, position_x, position_y, position_z, orientation, waittime, wander_distance, script_id) VALUES\n", table);
            }

            int index = 0;

            foreach (Waypoint point in waypoints)
            {
                query += string.Format("({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})", point.Id, point.Point, point.Position_x, point.Position_y, point.Position_z, point.Orientation, point.Waittime, point.Wander_distance, point.Script_id);
                index++;
                if(index >= waypoints.Count)
                {
                    query += ";";
                }
                else
                {
                    query += ",\n";
                }
            }

            return query;
        }

        private void txtPoint_Leave(object sender, EventArgs e)
        {
            if (lstWaypoints.SelectedItems.Count == 0)
                return;

            Waypoint point = (Waypoint)lstWaypoints.SelectedItems[0].Tag;
            if (point.Point.ToString() != txtPoint.Text)
            {
                if (uint.TryParse(txtPoint.Text, out uint _val))
                {
                    point.Point = _val;
                    waypoints[lstWaypoints.SelectedIndices[0]] = point;
                    UpdateList(lstWaypoints.SelectedIndices[0]);
                    is_dirty = true;
                }
            }
        }

        private void txtX_Leave(object sender, EventArgs e)
        {
            if (lstWaypoints.SelectedItems.Count == 0)
                return;

            Waypoint point = (Waypoint)lstWaypoints.SelectedItems[0].Tag;
            if (point.Position_x.ToString() != txtX.Text)
            {
                if (float.TryParse(txtX.Text, out float _val))
                {
                    point.Position_x = _val;
                    waypoints[lstWaypoints.SelectedIndices[0]] = point;
                    UpdateList(lstWaypoints.SelectedIndices[0]);
                    is_dirty = true;
                }
            }
        }

        private void txtY_Leave(object sender, EventArgs e)
        {
            if (lstWaypoints.SelectedItems.Count == 0)
                return;

            Waypoint point = (Waypoint)lstWaypoints.SelectedItems[0].Tag;
            if (point.Position_y.ToString() != txtY.Text)
            {
                if (float.TryParse(txtY.Text, out float _val))
                {
                    point.Position_y = _val;
                    waypoints[lstWaypoints.SelectedIndices[0]] = point;
                    UpdateList(lstWaypoints.SelectedIndices[0]);
                    is_dirty = true;
                }
            }
        }

        private void txtZ_Leave(object sender, EventArgs e)
        {
            if (lstWaypoints.SelectedItems.Count == 0)
                return;

            Waypoint point = (Waypoint)lstWaypoints.SelectedItems[0].Tag;
            if (point.Position_z.ToString() != txtZ.Text)
            {
                if (float.TryParse(txtZ.Text, out float _val))
                {
                    point.Position_z = _val;
                    waypoints[lstWaypoints.SelectedIndices[0]] = point;
                    UpdateList(lstWaypoints.SelectedIndices[0]);
                    is_dirty = true;
                }
            }
        }

        private void txtO_Leave(object sender, EventArgs e)
        {
            if (lstWaypoints.SelectedItems.Count == 0)
                return;

            Waypoint point = (Waypoint)lstWaypoints.SelectedItems[0].Tag;
            if (point.Orientation.ToString() != txtO.Text)
            {
                if (float.TryParse(txtO.Text, out float _val))
                {
                    point.Orientation = _val;
                    waypoints[lstWaypoints.SelectedIndices[0]] = point;
                    UpdateList(lstWaypoints.SelectedIndices[0]);
                    is_dirty = true;
                }
            }
        }

        private void txtWait_Leave(object sender, EventArgs e)
        {
            if (lstWaypoints.SelectedItems.Count == 0)
                return;

            Waypoint point = (Waypoint)lstWaypoints.SelectedItems[0].Tag;
            if (point.Waittime.ToString() != txtWait.Text)
            {
                if (uint.TryParse(txtWait.Text, out uint _val))
                {
                    point.Waittime = _val;
                    waypoints[lstWaypoints.SelectedIndices[0]] = point;
                    UpdateList(lstWaypoints.SelectedIndices[0]);
                    is_dirty = true;
                }
            }
        }

        private void txtWander_Leave(object sender, EventArgs e)
        {
            if (lstWaypoints.SelectedItems.Count == 0)
                return;

            Waypoint point = (Waypoint)lstWaypoints.SelectedItems[0].Tag;
            if (point.Wander_distance.ToString() != txtWander.Text)
            {
                if (float.TryParse(txtWander.Text, out float _val))
                {
                    point.Wander_distance = _val;
                    waypoints[lstWaypoints.SelectedIndices[0]] = point;
                    UpdateList(lstWaypoints.SelectedIndices[0]);
                    is_dirty = true;
                }
            }
        }

        private void txtScript_Leave(object sender, EventArgs e)
        {
            if (lstWaypoints.SelectedItems.Count == 0)
                return;

            Waypoint point = (Waypoint)lstWaypoints.SelectedItems[0].Tag;
            if (point.Script_id.ToString() != txtScript.Text)
            {
                if (uint.TryParse(txtScript.Text, out uint _val))
                {
                    point.Script_id = _val;
                    waypoints[lstWaypoints.SelectedIndices[0]] = point;
                    UpdateList(lstWaypoints.SelectedIndices[0]);
                    is_dirty = true;
                }
            }
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (lstWaypoints.SelectedItems.Count == 0)
                return;

            int selected = lstWaypoints.Items.IndexOf(lstWaypoints.SelectedItems[0]);

            Waypoint firstPoint = waypoints[selected];
            Waypoint secondPoint = waypoints[selected - 1];
            waypoints[selected - 1] = firstPoint;
            waypoints[selected] = secondPoint;

            uint index = 1;
            foreach (Waypoint point in waypoints)
            {
                point.Point = index;
                index += 1;
            }

            UpdateList(selected - 1);

            is_dirty = true;
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (lstWaypoints.SelectedItems.Count == 0)
                return;

            int selected = lstWaypoints.Items.IndexOf(lstWaypoints.SelectedItems[0]);

            Waypoint firstPoint = waypoints[selected];
            Waypoint secondPoint = waypoints[selected + 1];
            waypoints[selected] = secondPoint;
            waypoints[selected + 1] = firstPoint;

            uint index = 1;
            foreach (Waypoint point in waypoints)
            {
                point.Point = index;
                index += 1;
            }

            UpdateList(selected + 1);

            is_dirty = true;
        }

        public void CenterToParent(IWin32Window owner)
        {
            if (!(owner is Form f))
                return;

            StartPosition = FormStartPosition.Manual;
            Owner = f;
            Location = new Point(f.Location.X + (f.Width - Width) / 2, f.Location.Y + (f.Height - Height) / 2);
        }

        private void FormWaypointEditor_Load(object sender, EventArgs e)
        {
            if (Parent != null)
                CenterToParent();
        }

        private void btnPort_Click(object sender, EventArgs e)
        {
            if (lstWaypoints.SelectedItems.Count == 0)
                return;

            int selected = lstWaypoints.Items.IndexOf(lstWaypoints.SelectedItems[0]);

            Waypoint firstPoint = waypoints[selected];
            Clipboard.SetText($".port {firstPoint.Position_x} {firstPoint.Position_y} {firstPoint.Position_z}");
        }
    }
}
