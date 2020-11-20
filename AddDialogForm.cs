#nullable enable
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeAssistantShortcuts.Helper;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HomeAssistantShortcuts
{
    public partial class AddDialogForm : Form
    {
        private readonly ServerConnection _connection;
        private readonly Shortcut _shortcut;
        private EntityState _selectedEntity;

        public AddDialogForm(ServerConnection connection, Shortcut? shortcut = null)
        {
            InitializeComponent();
            this._connection = connection;
            this._shortcut = shortcut ?? new Shortcut();
            SyncButtonStatuses();
        }

        public async Task LoadServices()
        {
            var services = await _connection.ListServices();
            comboBoxPaths.Items.AddRange(services.ToArray());
            comboBoxPaths.Enabled = true;

            if (_shortcut.Path != "")
            {
                comboBoxPaths.SelectedValue = _shortcut.Path;
            }
            SyncButtonStatuses();
        }

        private void SyncButtonStatuses()
        {
            buttonAdd.Enabled = _shortcut.KeyCode > 0 && _shortcut.Payload.IsValidJson() && !string.IsNullOrEmpty(_shortcut.Path);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Shortcuts.Add(_shortcut);
            Properties.Settings.Default.Save();
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddDialogForm_Shown(object sender, EventArgs e)
        {
            _ = LoadServices();
        }

        private void textBoxShortcut_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;

            _shortcut.SetFromEvent(e);
            RenderShortcut();
            SyncButtonStatuses();
        }

        private void RenderShortcut()
        {
            var label = _shortcut?.KeyLabel;
            textBoxShortcut.Text = string.IsNullOrEmpty(label) ? "<not set>" : label;
        }

        private void textBoxPayload_TextChanged(object sender, EventArgs e)
        {
            _shortcut.Payload = textBoxPayload.Text;
            var valid = _shortcut.Payload.IsValidWithError();
            if(valid.Key)
            {
                error_label.Text = null;
                error_label.Visible= false;
                SyncButtonStatuses();
            }
            else
            {
                error_label.Visible = true;
                error_label.Text = valid.Value;
            }
        }

        private void comboBoxPaths_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (Service)comboBoxPaths.SelectedItem;
            if(selected == null) return;
            var path = selected.ServicePath;
            _shortcut.Path = path;

            FillExampleValues(selected);
            if (path != null)
            {
                var domain = path.Split('/')[0];
                GetEntities(domain);

            }
            SyncButtonStatuses();
        }

        private void FillExampleValues(Service selected)
        {
            var exampleData = $"{{";
            foreach (var selectedField in selected.Fields)
            {
                if(selectedField.Value.Example.IsValidJson())
                    exampleData += $"\"{selectedField.Key}\": {selectedField.Value.Example},\n";
                else
                    exampleData += $"\"{selectedField.Key}\": \"{selectedField.Value.Example}\",\n";
            }

            exampleData += "}";
            textBoxPayload.Text = exampleData.BeautifieJsonString();
        }

        private async Task GetEntities(string domain)
        {
            var json = textBoxPayload.Text;
            var parsed = JToken.Parse(json);
            if(parsed["entity_id"] != null)
            {
                var states = await _connection.Get<EntityState>("states");
                var entities = states.Where(x => x.Domain == domain);
                cbEntities.Items.AddRange(entities.ToArray());
                cbEntities.Enabled = true;
            }
            else
            {
                cbEntities.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var json = textBoxPayload.Text;
            var parsed = JToken.Parse(json);
            parsed["entity_id"] = _selectedEntity.EntityId;
            textBoxPayload.Text = parsed.ToString(Formatting.Indented);
            //    var insertText = _selectedEntity.EntityId;
            //var selectionIndex = textBoxPayload.SelectionStart;
            //textBoxPayload.Text = textBoxPayload.Text.Insert(selectionIndex, insertText);
            //textBoxPayload.SelectionStart = selectionIndex + insertText.Length;
        }

        private void cbEntities_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedEntity = (EntityState) cbEntities.SelectedItem;
            button1.Enabled = _selectedEntity != null;
        }
    }
}
