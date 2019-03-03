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
            this.talentDetailsLabel = new System.Windows.Forms.Label();
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
            "Betrayer",
            "Bombardment",
            "Chaos Familiar",
            "Counterstrike",
            "Cybernetic Reconstruction",
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
            "Superhuman Agility",
            "Superhuman Fellowship",
            "Superhuman Initiative",
            "Superhuman Intellect",
            "Superhuman Speed",
            "Superhuman Strength",
            "Superhuman Toughness",
            "Superhuman Willpower",
            "Supreme Presence",
            "The Emperor\'s Light",
            "Touched by Fate",
            "Trademark Weapon",
            "True Grit",
            "Uncanny Convinction",
            "Uncanny Corruption",
            "Uncanny Defence",
            "Uncanny Influence",
            "Uncanny Passive Awareness",
            "Uncanny Resilience",
            "Uncanny Resolve",
            "Uncanny Shock",
            "Uncanny Soak",
            "Uncanny Speed",
            "Uncanny Wealth",
            "Uncanny Wounds",
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
            this.talentSelectBox.Sorted = true;
            this.talentSelectBox.TabIndex = 0;
            this.talentSelectBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // talentDetailsLabel
            // 
            this.talentDetailsLabel.Location = new System.Drawing.Point(301, 13);
            this.talentDetailsLabel.Name = "talentDetailsLabel";
            this.talentDetailsLabel.Size = new System.Drawing.Size(272, 382);
            this.talentDetailsLabel.TabIndex = 2;
            this.talentDetailsLabel.Text = "talentDetailsLabel";
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
            this.Controls.Add(this.talentDetailsLabel);
            this.Controls.Add(this.talentSelectBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "talentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Talents";
            this.Load += new System.EventHandler(this.talentForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox talentSelectBox;
        private System.Windows.Forms.Label talentDetailsLabel;
        private System.Windows.Forms.Button addTalentButton;
        private System.Windows.Forms.Button talentCancelButton;
    }
}