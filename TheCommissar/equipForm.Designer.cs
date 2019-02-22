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
            this.equipCancelButton = new System.Windows.Forms.Button();
            this.addEquipButton = new System.Windows.Forms.Button();
            this.selectedEquipLabel = new System.Windows.Forms.Label();
            this.equipSelectBox = new System.Windows.Forms.ListBox();
            this.equipDamageLabel = new System.Windows.Forms.Label();
            this.equipArmorRatingLabel = new System.Windows.Forms.Label();
            this.equipKeywordsLabel = new System.Windows.Forms.Label();
            this.equipValueLabel = new System.Windows.Forms.Label();
            this.equipTraitsLabel = new System.Windows.Forms.Label();
            this.equipSalvoLabel = new System.Windows.Forms.Label();
            this.equipRangeLabel = new System.Windows.Forms.Label();
            this.equipAPLabel = new System.Windows.Forms.Label();
            this.equipBoxFilter = new System.Windows.Forms.ComboBox();
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
            this.selectedEquipLabel.Location = new System.Drawing.Point(297, 15);
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
            this.equipSelectBox.TabIndex = 131;
            this.equipSelectBox.SelectedIndexChanged += new System.EventHandler(this.equipSelectBox_SelectedIndexChanged);
            // 
            // equipDamageLabel
            // 
            this.equipDamageLabel.AutoSize = true;
            this.equipDamageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipDamageLabel.Location = new System.Drawing.Point(300, 40);
            this.equipDamageLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.equipDamageLabel.Name = "equipDamageLabel";
            this.equipDamageLabel.Size = new System.Drawing.Size(53, 13);
            this.equipDamageLabel.TabIndex = 142;
            this.equipDamageLabel.Text = "Damage: ";
            // 
            // equipArmorRatingLabel
            // 
            this.equipArmorRatingLabel.AutoSize = true;
            this.equipArmorRatingLabel.Location = new System.Drawing.Point(300, 140);
            this.equipArmorRatingLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.equipArmorRatingLabel.Name = "equipArmorRatingLabel";
            this.equipArmorRatingLabel.Size = new System.Drawing.Size(71, 13);
            this.equipArmorRatingLabel.TabIndex = 141;
            this.equipArmorRatingLabel.Text = "Armor Rating:";
            // 
            // equipKeywordsLabel
            // 
            this.equipKeywordsLabel.AutoSize = true;
            this.equipKeywordsLabel.Location = new System.Drawing.Point(300, 190);
            this.equipKeywordsLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.equipKeywordsLabel.Name = "equipKeywordsLabel";
            this.equipKeywordsLabel.Size = new System.Drawing.Size(56, 13);
            this.equipKeywordsLabel.TabIndex = 140;
            this.equipKeywordsLabel.Text = "Keywords:";
            // 
            // equipValueLabel
            // 
            this.equipValueLabel.AutoSize = true;
            this.equipValueLabel.Location = new System.Drawing.Point(300, 165);
            this.equipValueLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.equipValueLabel.Name = "equipValueLabel";
            this.equipValueLabel.Size = new System.Drawing.Size(37, 13);
            this.equipValueLabel.TabIndex = 139;
            this.equipValueLabel.Text = "Value:";
            // 
            // equipTraitsLabel
            // 
            this.equipTraitsLabel.AutoSize = true;
            this.equipTraitsLabel.Location = new System.Drawing.Point(300, 215);
            this.equipTraitsLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.equipTraitsLabel.Name = "equipTraitsLabel";
            this.equipTraitsLabel.Size = new System.Drawing.Size(39, 13);
            this.equipTraitsLabel.TabIndex = 138;
            this.equipTraitsLabel.Text = "Traits: ";
            // 
            // equipSalvoLabel
            // 
            this.equipSalvoLabel.AutoSize = true;
            this.equipSalvoLabel.Location = new System.Drawing.Point(300, 115);
            this.equipSalvoLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.equipSalvoLabel.Name = "equipSalvoLabel";
            this.equipSalvoLabel.Size = new System.Drawing.Size(40, 13);
            this.equipSalvoLabel.TabIndex = 137;
            this.equipSalvoLabel.Text = "Salvo: ";
            // 
            // equipRangeLabel
            // 
            this.equipRangeLabel.AutoSize = true;
            this.equipRangeLabel.Location = new System.Drawing.Point(300, 90);
            this.equipRangeLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.equipRangeLabel.Name = "equipRangeLabel";
            this.equipRangeLabel.Size = new System.Drawing.Size(45, 13);
            this.equipRangeLabel.TabIndex = 136;
            this.equipRangeLabel.Text = "Range: ";
            // 
            // equipAPLabel
            // 
            this.equipAPLabel.AutoSize = true;
            this.equipAPLabel.Location = new System.Drawing.Point(300, 65);
            this.equipAPLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.equipAPLabel.Name = "equipAPLabel";
            this.equipAPLabel.Size = new System.Drawing.Size(27, 13);
            this.equipAPLabel.TabIndex = 135;
            this.equipAPLabel.Text = "AP: ";
            // 
            // equipBoxFilter
            // 
            this.equipBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipBoxFilter.FormattingEnabled = true;
            this.equipBoxFilter.Items.AddRange(new object[] {
            "All",
            "Ranged Weapons",
            "Melee Weapons",
            "Armor"});
            this.equipBoxFilter.Location = new System.Drawing.Point(12, 12);
            this.equipBoxFilter.Name = "equipBoxFilter";
            this.equipBoxFilter.Size = new System.Drawing.Size(279, 21);
            this.equipBoxFilter.TabIndex = 143;
            this.equipBoxFilter.SelectedIndexChanged += new System.EventHandler(this.equipBoxFilter_SelectedIndexChanged);
            // 
            // equipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.equipBoxFilter);
            this.Controls.Add(this.equipDamageLabel);
            this.Controls.Add(this.equipArmorRatingLabel);
            this.Controls.Add(this.equipKeywordsLabel);
            this.Controls.Add(this.equipValueLabel);
            this.Controls.Add(this.equipTraitsLabel);
            this.Controls.Add(this.equipSalvoLabel);
            this.Controls.Add(this.equipRangeLabel);
            this.Controls.Add(this.equipAPLabel);
            this.Controls.Add(this.equipCancelButton);
            this.Controls.Add(this.addEquipButton);
            this.Controls.Add(this.selectedEquipLabel);
            this.Controls.Add(this.equipSelectBox);
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
        private System.Windows.Forms.Label equipDamageLabel;
        private System.Windows.Forms.Label equipArmorRatingLabel;
        private System.Windows.Forms.Label equipKeywordsLabel;
        private System.Windows.Forms.Label equipValueLabel;
        private System.Windows.Forms.Label equipTraitsLabel;
        private System.Windows.Forms.Label equipSalvoLabel;
        private System.Windows.Forms.Label equipRangeLabel;
        private System.Windows.Forms.Label equipAPLabel;
        private System.Windows.Forms.ComboBox equipBoxFilter;
    }
}