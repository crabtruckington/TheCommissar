namespace TheCommissar
{
    partial class equipForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(equipForm));
            this.equipCancelButton = new System.Windows.Forms.Button();
            this.addEquipButton = new System.Windows.Forms.Button();
            this.selectedEquipLabel = new System.Windows.Forms.Label();
            this.equipSelectBox = new System.Windows.Forms.ListBox();
            this.equipDetailsLabel = new System.Windows.Forms.Label();
            this.equipBoxFilter = new System.Windows.Forms.ComboBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.equipSearchBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // equipCancelButton
            // 
            this.equipCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.equipCancelButton.Location = new System.Drawing.Point(463, 411);
            this.equipCancelButton.Name = "equipCancelButton";
            this.equipCancelButton.Size = new System.Drawing.Size(109, 23);
            this.equipCancelButton.TabIndex = 134;
            this.equipCancelButton.Text = "Cancel";
            this.equipCancelButton.UseVisualStyleBackColor = true;
            // 
            // addEquipButton
            // 
            this.addEquipButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addEquipButton.Location = new System.Drawing.Point(303, 411);
            this.addEquipButton.Name = "addEquipButton";
            this.addEquipButton.Size = new System.Drawing.Size(109, 23);
            this.addEquipButton.TabIndex = 133;
            this.addEquipButton.Text = "Add Equipment";
            this.addEquipButton.UseVisualStyleBackColor = true;
            this.addEquipButton.Click += new System.EventHandler(this.addEquipButton_Click);
            // 
            // selectedEquipLabel
            // 
            this.selectedEquipLabel.AutoSize = true;
            this.selectedEquipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedEquipLabel.Location = new System.Drawing.Point(297, 42);
            this.selectedEquipLabel.Name = "selectedEquipLabel";
            this.selectedEquipLabel.Size = new System.Drawing.Size(163, 13);
            this.selectedEquipLabel.TabIndex = 132;
            this.selectedEquipLabel.Text = "Selected Equipment Details";
            // 
            // equipSelectBox
            // 
            this.equipSelectBox.FormattingEnabled = true;
            this.equipSelectBox.Location = new System.Drawing.Point(12, 41);
            this.equipSelectBox.Name = "equipSelectBox";
            this.equipSelectBox.Size = new System.Drawing.Size(279, 394);
            this.equipSelectBox.Sorted = true;
            this.equipSelectBox.TabIndex = 131;
            this.equipSelectBox.SelectedIndexChanged += new System.EventHandler(this.equipSelectBox_SelectedIndexChanged);
            // 
            // equipDetailsLabel
            // 
            this.equipDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipDetailsLabel.Location = new System.Drawing.Point(300, 67);
            this.equipDetailsLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.equipDetailsLabel.Name = "equipDetailsLabel";
            this.equipDetailsLabel.Size = new System.Drawing.Size(271, 329);
            this.equipDetailsLabel.TabIndex = 142;
            this.equipDetailsLabel.Text = "equipDetailsLabel";
            // 
            // equipBoxFilter
            // 
            this.equipBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipBoxFilter.FormattingEnabled = true;
            this.equipBoxFilter.Items.AddRange(new object[] {
            "All",
            "Ranged Weapons",
            "Melee Weapons",
            "Armor",
            "Tools and Ammo"});
            this.equipBoxFilter.Location = new System.Drawing.Point(12, 12);
            this.equipBoxFilter.Name = "equipBoxFilter";
            this.equipBoxFilter.Size = new System.Drawing.Size(279, 21);
            this.equipBoxFilter.TabIndex = 143;
            this.equipBoxFilter.SelectedIndexChanged += new System.EventHandler(this.equipBoxFilter_SelectedIndexChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(297, 15);
            this.searchLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(44, 13);
            this.searchLabel.TabIndex = 144;
            this.searchLabel.Text = "Search:";
            // 
            // equipSearchBox
            // 
            this.equipSearchBox.Location = new System.Drawing.Point(347, 13);
            this.equipSearchBox.Name = "equipSearchBox";
            this.equipSearchBox.Size = new System.Drawing.Size(224, 20);
            this.equipSearchBox.TabIndex = 145;
            this.equipSearchBox.TextChanged += new System.EventHandler(this.equipSearchBox_TextChanged);
            // 
            // equipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.equipSearchBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.equipBoxFilter);
            this.Controls.Add(this.equipDetailsLabel);
            this.Controls.Add(this.equipCancelButton);
            this.Controls.Add(this.addEquipButton);
            this.Controls.Add(this.selectedEquipLabel);
            this.Controls.Add(this.equipSelectBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "equipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Equipment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button equipCancelButton;
        private System.Windows.Forms.Button addEquipButton;
        private System.Windows.Forms.Label selectedEquipLabel;
        private System.Windows.Forms.ListBox equipSelectBox;
        private System.Windows.Forms.Label equipDetailsLabel;
        private System.Windows.Forms.ComboBox equipBoxFilter;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox equipSearchBox;
    }
}