namespace HomeAssistantShortcuts
{
    partial class AddDialogForm
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
            System.Windows.Forms.Label labelShortcut;
            System.Windows.Forms.Label labelPaths;
            System.Windows.Forms.Button buttonCancel;
            System.Windows.Forms.Label labelPayload;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDialogForm));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxShortcut = new System.Windows.Forms.TextBox();
            this.comboBoxPaths = new System.Windows.Forms.ComboBox();
            this.textBoxPayload = new System.Windows.Forms.TextBox();
            this.cbEntities = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.error_label = new System.Windows.Forms.Label();
            labelShortcut = new System.Windows.Forms.Label();
            labelPaths = new System.Windows.Forms.Label();
            buttonCancel = new System.Windows.Forms.Button();
            labelPayload = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelShortcut
            // 
            labelShortcut.AutoSize = true;
            labelShortcut.Location = new System.Drawing.Point(18, 23);
            labelShortcut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelShortcut.Name = "labelShortcut";
            labelShortcut.Size = new System.Drawing.Size(74, 20);
            labelShortcut.TabIndex = 1;
            labelShortcut.Text = "Shortcut:";
            // 
            // labelPaths
            // 
            labelPaths.AutoSize = true;
            labelPaths.Location = new System.Drawing.Point(18, 65);
            labelPaths.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelPaths.Name = "labelPaths";
            labelPaths.Size = new System.Drawing.Size(65, 20);
            labelPaths.TabIndex = 3;
            labelPaths.Text = "Service:";
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            buttonCancel.Location = new System.Drawing.Point(333, 861);
            buttonCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(112, 35);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelPayload
            // 
            labelPayload.AutoSize = true;
            labelPayload.Location = new System.Drawing.Point(18, 186);
            labelPayload.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelPayload.Name = "labelPayload";
            labelPayload.Size = new System.Drawing.Size(69, 20);
            labelPayload.TabIndex = 7;
            labelPayload.Text = "Payload:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 108);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(53, 20);
            label1.TabIndex = 8;
            label1.Text = "Entity:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(454, 861);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(112, 35);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "OK";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxShortcut
            // 
            this.textBoxShortcut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxShortcut.Location = new System.Drawing.Point(117, 18);
            this.textBoxShortcut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxShortcut.Name = "textBoxShortcut";
            this.textBoxShortcut.ShortcutsEnabled = false;
            this.textBoxShortcut.Size = new System.Drawing.Size(448, 26);
            this.textBoxShortcut.TabIndex = 0;
            this.textBoxShortcut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxShortcut_KeyDown);
            // 
            // comboBoxPaths
            // 
            this.comboBoxPaths.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPaths.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPaths.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPaths.DisplayMember = "ServicePathDisplay";
            this.comboBoxPaths.Enabled = false;
            this.comboBoxPaths.FormattingEnabled = true;
            this.comboBoxPaths.Location = new System.Drawing.Point(117, 60);
            this.comboBoxPaths.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxPaths.Name = "comboBoxPaths";
            this.comboBoxPaths.Size = new System.Drawing.Size(448, 28);
            this.comboBoxPaths.TabIndex = 2;
            this.comboBoxPaths.ValueMember = "ServicePath";
            this.comboBoxPaths.SelectedIndexChanged += new System.EventHandler(this.comboBoxPaths_SelectedIndexChanged);
            // 
            // textBoxPayload
            // 
            this.textBoxPayload.AcceptsReturn = true;
            this.textBoxPayload.AcceptsTab = true;
            this.textBoxPayload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPayload.Location = new System.Drawing.Point(22, 229);
            this.textBoxPayload.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPayload.Multiline = true;
            this.textBoxPayload.Name = "textBoxPayload";
            this.textBoxPayload.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPayload.Size = new System.Drawing.Size(542, 510);
            this.textBoxPayload.TabIndex = 4;
            this.textBoxPayload.TextChanged += new System.EventHandler(this.textBoxPayload_TextChanged);
            // 
            // cbEntities
            // 
            this.cbEntities.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEntities.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbEntities.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbEntities.DisplayMember = "EntityId";
            this.cbEntities.Enabled = false;
            this.cbEntities.FormattingEnabled = true;
            this.cbEntities.Location = new System.Drawing.Point(116, 105);
            this.cbEntities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbEntities.Name = "cbEntities";
            this.cbEntities.Size = new System.Drawing.Size(448, 28);
            this.cbEntities.TabIndex = 9;
            this.cbEntities.ValueMember = "EntityId";
            this.cbEntities.SelectedIndexChanged += new System.EventHandler(this.cbEntities_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(470, 179);
            this.button1.MinimumSize = new System.Drawing.Size(0, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add entity";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Location = new System.Drawing.Point(18, 753);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(0, 20);
            this.error_label.TabIndex = 11;
            // 
            // AddDialogForm
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = buttonCancel;
            this.ClientSize = new System.Drawing.Size(585, 915);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbEntities);
            this.Controls.Add(label1);
            this.Controls.Add(labelPayload);
            this.Controls.Add(buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxPayload);
            this.Controls.Add(labelPaths);
            this.Controls.Add(this.comboBoxPaths);
            this.Controls.Add(labelShortcut);
            this.Controls.Add(this.textBoxShortcut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDialogForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Shortcut";
            this.Shown += new System.EventHandler(this.AddDialogForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxShortcut;
        private System.Windows.Forms.ComboBox comboBoxPaths;
        private System.Windows.Forms.TextBox textBoxPayload;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ComboBox cbEntities;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label error_label;
    }
}