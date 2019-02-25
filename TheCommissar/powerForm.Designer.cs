namespace TheCommissar
{
    partial class powerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(powerForm));
            this.powerCancelButton = new System.Windows.Forms.Button();
            this.addPowerButton = new System.Windows.Forms.Button();
            this.selectedPowerDetailLabel = new System.Windows.Forms.Label();
            this.powerSelectBox = new System.Windows.Forms.ListBox();
            this.powerDisciplineLabel = new System.Windows.Forms.Label();
            this.powerKeywordsLabel = new System.Windows.Forms.Label();
            this.powerMultiLabel = new System.Windows.Forms.Label();
            this.powerRangeLabel = new System.Windows.Forms.Label();
            this.powerDurationLabel = new System.Windows.Forms.Label();
            this.powerActivationLabel = new System.Windows.Forms.Label();
            this.powerDNLabel = new System.Windows.Forms.Label();
            this.powerBPCostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // powerCancelButton
            // 
            this.powerCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.powerCancelButton.Location = new System.Drawing.Point(463, 411);
            this.powerCancelButton.Name = "powerCancelButton";
            this.powerCancelButton.Size = new System.Drawing.Size(109, 23);
            this.powerCancelButton.TabIndex = 8;
            this.powerCancelButton.Text = "Cancel";
            this.powerCancelButton.UseVisualStyleBackColor = true;
            // 
            // addPowerButton
            // 
            this.addPowerButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addPowerButton.Location = new System.Drawing.Point(303, 411);
            this.addPowerButton.Name = "addPowerButton";
            this.addPowerButton.Size = new System.Drawing.Size(109, 23);
            this.addPowerButton.TabIndex = 7;
            this.addPowerButton.Text = "Add Power";
            this.addPowerButton.UseVisualStyleBackColor = true;
            // 
            // selectedPowerDetailLabel
            // 
            this.selectedPowerDetailLabel.AutoSize = true;
            this.selectedPowerDetailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedPowerDetailLabel.Location = new System.Drawing.Point(297, 15);
            this.selectedPowerDetailLabel.Name = "selectedPowerDetailLabel";
            this.selectedPowerDetailLabel.Size = new System.Drawing.Size(139, 13);
            this.selectedPowerDetailLabel.TabIndex = 6;
            this.selectedPowerDetailLabel.Text = "Selected Power Details";
            // 
            // powerSelectBox
            // 
            this.powerSelectBox.FormattingEnabled = true;
            this.powerSelectBox.Items.AddRange(new object[] {
            "Assail",
            "Boil Blood",
            "Chameleon",
            "Compel",
            "Conceal Phenomena",
            "Conceal/Reveal",
            "Create Flame",
            "Crush",
            "Dull Pain",
            "Embolden/Horrify",
            "Empower/Enervate",
            "Enfeeble",
            "Enhance/Drain",
            "Fiery Form",
            "Flash Bang ",
            "Flight",
            "Fog the Mind",
            "Force Field",
            "Forewarning",
            "Fortune",
            "Glimpse the Future",
            "Gout of Flame",
            "Inflict Pain",
            "Jam Mechanism",
            "Levitation",
            "Life Leech",
            "Living Lightning",
            "Mind Probe",
            "Molten Beam",
            "Omens of Doom",
            "Orb",
            "Phantom Form",
            "Phantom Grip",
            "Prophetic Visions",
            "Protect/Jinx",
            "Psychic Shriek",
            "Psyniscience",
            "Puppet Master",
            "Quicken/Delay",
            "Regenerate",
            "Scry",
            "Shockwave",
            "Shove",
            "Smite",
            "Soul Shrivel",
            "Spontaneous Cumbustion",
            "Telepathy",
            "Terrify",
            "Touch of Corruption",
            "Voices",
            "Waking Nightmare",
            "Wall of Flame"});
            this.powerSelectBox.Location = new System.Drawing.Point(12, 15);
            this.powerSelectBox.Name = "powerSelectBox";
            this.powerSelectBox.Size = new System.Drawing.Size(279, 420);
            this.powerSelectBox.Sorted = true;
            this.powerSelectBox.TabIndex = 5;
            this.powerSelectBox.SelectedIndexChanged += new System.EventHandler(this.powerSelectBox_SelectedIndexChanged);
            // 
            // powerDisciplineLabel
            // 
            this.powerDisciplineLabel.AutoSize = true;
            this.powerDisciplineLabel.Location = new System.Drawing.Point(300, 40);
            this.powerDisciplineLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.powerDisciplineLabel.Name = "powerDisciplineLabel";
            this.powerDisciplineLabel.Size = new System.Drawing.Size(55, 13);
            this.powerDisciplineLabel.TabIndex = 130;
            this.powerDisciplineLabel.Text = "Discipline:";
            // 
            // powerKeywordsLabel
            // 
            this.powerKeywordsLabel.AutoSize = true;
            this.powerKeywordsLabel.Location = new System.Drawing.Point(300, 215);
            this.powerKeywordsLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.powerKeywordsLabel.Name = "powerKeywordsLabel";
            this.powerKeywordsLabel.Size = new System.Drawing.Size(56, 13);
            this.powerKeywordsLabel.TabIndex = 129;
            this.powerKeywordsLabel.Text = "Keywords:";
            // 
            // powerMultiLabel
            // 
            this.powerMultiLabel.AutoSize = true;
            this.powerMultiLabel.Location = new System.Drawing.Point(300, 190);
            this.powerMultiLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.powerMultiLabel.Name = "powerMultiLabel";
            this.powerMultiLabel.Size = new System.Drawing.Size(66, 13);
            this.powerMultiLabel.TabIndex = 128;
            this.powerMultiLabel.Text = "Multi-Target:";
            // 
            // powerRangeLabel
            // 
            this.powerRangeLabel.AutoSize = true;
            this.powerRangeLabel.Location = new System.Drawing.Point(300, 165);
            this.powerRangeLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.powerRangeLabel.Name = "powerRangeLabel";
            this.powerRangeLabel.Size = new System.Drawing.Size(42, 13);
            this.powerRangeLabel.TabIndex = 127;
            this.powerRangeLabel.Text = "Range:";
            // 
            // powerDurationLabel
            // 
            this.powerDurationLabel.AutoSize = true;
            this.powerDurationLabel.Location = new System.Drawing.Point(300, 140);
            this.powerDurationLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.powerDurationLabel.Name = "powerDurationLabel";
            this.powerDurationLabel.Size = new System.Drawing.Size(50, 13);
            this.powerDurationLabel.TabIndex = 126;
            this.powerDurationLabel.Text = "Duration:";
            // 
            // powerActivationLabel
            // 
            this.powerActivationLabel.AutoSize = true;
            this.powerActivationLabel.Location = new System.Drawing.Point(300, 115);
            this.powerActivationLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.powerActivationLabel.Name = "powerActivationLabel";
            this.powerActivationLabel.Size = new System.Drawing.Size(57, 13);
            this.powerActivationLabel.TabIndex = 125;
            this.powerActivationLabel.Text = "Activation:";
            // 
            // powerDNLabel
            // 
            this.powerDNLabel.AutoSize = true;
            this.powerDNLabel.Location = new System.Drawing.Point(300, 90);
            this.powerDNLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.powerDNLabel.Name = "powerDNLabel";
            this.powerDNLabel.Size = new System.Drawing.Size(29, 13);
            this.powerDNLabel.TabIndex = 124;
            this.powerDNLabel.Text = "DN: ";
            // 
            // powerBPCostLabel
            // 
            this.powerBPCostLabel.AutoSize = true;
            this.powerBPCostLabel.Location = new System.Drawing.Point(300, 65);
            this.powerBPCostLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.powerBPCostLabel.Name = "powerBPCostLabel";
            this.powerBPCostLabel.Size = new System.Drawing.Size(48, 13);
            this.powerBPCostLabel.TabIndex = 123;
            this.powerBPCostLabel.Text = "BP Cost:";
            // 
            // powerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.powerDisciplineLabel);
            this.Controls.Add(this.powerKeywordsLabel);
            this.Controls.Add(this.powerMultiLabel);
            this.Controls.Add(this.powerRangeLabel);
            this.Controls.Add(this.powerDurationLabel);
            this.Controls.Add(this.powerActivationLabel);
            this.Controls.Add(this.powerDNLabel);
            this.Controls.Add(this.powerBPCostLabel);
            this.Controls.Add(this.powerCancelButton);
            this.Controls.Add(this.addPowerButton);
            this.Controls.Add(this.selectedPowerDetailLabel);
            this.Controls.Add(this.powerSelectBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "powerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Psychic Power";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button powerCancelButton;
        private System.Windows.Forms.Button addPowerButton;
        private System.Windows.Forms.Label selectedPowerDetailLabel;
        private System.Windows.Forms.ListBox powerSelectBox;
        private System.Windows.Forms.Label powerDisciplineLabel;
        private System.Windows.Forms.Label powerKeywordsLabel;
        private System.Windows.Forms.Label powerMultiLabel;
        private System.Windows.Forms.Label powerRangeLabel;
        private System.Windows.Forms.Label powerDurationLabel;
        private System.Windows.Forms.Label powerActivationLabel;
        private System.Windows.Forms.Label powerDNLabel;
        private System.Windows.Forms.Label powerBPCostLabel;
    }
}