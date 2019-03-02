namespace TheCommissar
{
    partial class talentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(talentForm));
            this.talentSelectBox = new System.Windows.Forms.ListBox();
            this.selectedTalentLabel = new System.Windows.Forms.Label();
            this.bpCostLabel = new System.Windows.Forms.Label();
            this.addTalentButton = new System.Windows.Forms.Button();
            this.talentCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // talentSelectBox
            // 
            this.talentSelectBox.FormattingEnabled = true;
            this.talentSelectBox.Items.AddRange(new object[] {
            "Acts of Faith",
            "Augmetic",
            "Cybernetic Reconstruction",
            "Betrayer",
            "Chaos Familiar",
            "Bombardment",
            "Counterstrike",
            "Dedicant",
            "Devotees",
            "Dual Wielder",
            "Favored by the Warp",
            "Fearless",
            "Hammer Blow",
            "Hardy",
            "Hatred",
            "Heroic Charge",
            "Inspired Blessing",
            "Legacy of Sorrow",
            "Let the Galaxy Burn",
            "Loremaster",
            "Mark of Chaos",
            "Marksman",
            "Mastered Paths",
            "Mob Rule",
            "Peer",
            "Primaris Perspective",
            "Rite of Fear",
            "Rite of Magnometrics",
            "Rite of Pure Thought",
            "Shootier",
            "Sidestep",
            "Special Weapons Trooper",
            "Steel and Doom",
            "Storm of Death",
            "Superhuman Strength",
            "Superhuman Agility",
            "Superhuman Toughness",
            "Superhuman Intellect",
            "Superhuman Willpower",
            "Superhuman Fellowship",
            "Superhuman Initiative",
            "Superhuman Speed",
            "Supreme Presence",
            "The Emperor\'s Light",
            "Touched by Fate",
            "Trademark Weapon",
            "True Grit",
            "Uncanny Defence",
            "Uncanny Resilience",
            "Uncanny Soak",
            "Uncanny Shock",
            "Uncanny Speed",
            "Uncanny Wounds",
            "Uncanny Convinction",
            "Uncanny Corruption",
            "Uncanny Passive Awareness",
            "Uncanny Resolve",
            "Uncanny Influence",
            "Uncanny Wealth",
            "Unnatural Athletics",
            "Unnatural Awareness",
            "Unnatural Ballistic Skill",
            "Unnatural Cunning",
            "Unnatural Deception",
            "Unnatural Insight",
            "Unnatural Intimidation",
            "Unnatural Investigation",
            "Unnatural Leadership",
            "Unnatural Medicae",
            "Unnatural Persuasion",
            "Unnatural Pilot",
            "Unnatural Psychic Mastery",
            "Unnatural Scholar",
            "Unnatural Stealth",
            "Unnatural Survival",
            "Unnatural Tech",
            "Unnatural Weapon Skill",
            "Unquestioning Faith"});
            this.talentSelectBox.Location = new System.Drawing.Point(13, 13);
            this.talentSelectBox.Name = "talentSelectBox";
            this.talentSelectBox.Size = new System.Drawing.Size(279, 420);
            this.talentSelectBox.TabIndex = 0;
            this.talentSelectBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // selectedTalentLabel
            // 
            this.selectedTalentLabel.AutoSize = true;
            this.selectedTalentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedTalentLabel.Location = new System.Drawing.Point(298, 13);
            this.selectedTalentLabel.Name = "selectedTalentLabel";
            this.selectedTalentLabel.Size = new System.Drawing.Size(126, 13);
            this.selectedTalentLabel.TabIndex = 1;
            this.selectedTalentLabel.Text = "Selected Talent Cost";
            // 
            // bpCostLabel
            // 
            this.bpCostLabel.AutoSize = true;
            this.bpCostLabel.Location = new System.Drawing.Point(301, 44);
            this.bpCostLabel.Name = "bpCostLabel";
            this.bpCostLabel.Size = new System.Drawing.Size(0, 13);
            this.bpCostLabel.TabIndex = 2;
            // 
            // addTalentButton
            // 
            this.addTalentButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addTalentButton.Location = new System.Drawing.Point(304, 409);
            this.addTalentButton.Name = "addTalentButton";
            this.addTalentButton.Size = new System.Drawing.Size(109, 23);
            this.addTalentButton.TabIndex = 3;
            this.addTalentButton.Text = "Add Talent";
            this.addTalentButton.UseVisualStyleBackColor = true;
            // 
            // talentCancelButton
            // 
            this.talentCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.talentCancelButton.Location = new System.Drawing.Point(464, 409);
            this.talentCancelButton.Name = "talentCancelButton";
            this.talentCancelButton.Size = new System.Drawing.Size(109, 23);
            this.talentCancelButton.TabIndex = 4;
            this.talentCancelButton.Text = "Cancel";
            this.talentCancelButton.UseVisualStyleBackColor = true;
            // 
            // talentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.talentCancelButton);
            this.Controls.Add(this.addTalentButton);
            this.Controls.Add(this.bpCostLabel);
            this.Controls.Add(this.selectedTalentLabel);
            this.Controls.Add(this.talentSelectBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "talentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Talents";
            this.Load += new System.EventHandler(this.talentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox talentSelectBox;
        private System.Windows.Forms.Label selectedTalentLabel;
        private System.Windows.Forms.Label bpCostLabel;
        private System.Windows.Forms.Button addTalentButton;
        private System.Windows.Forms.Button talentCancelButton;
    }
}