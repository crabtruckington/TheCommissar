namespace TheCommissar
{
    partial class cyberneticsForm
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
            this.augSelectBox = new System.Windows.Forms.ListBox();
            this.augHeaderLabel = new System.Windows.Forms.Label();
            this.augRaceLabel = new System.Windows.Forms.Label();
            this.augDetailsLabel = new System.Windows.Forms.Label();
            this.augCancelButton = new System.Windows.Forms.Button();
            this.addAugButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // augSelectBox
            // 
            this.augSelectBox.FormattingEnabled = true;
            this.augSelectBox.Items.AddRange(new object[] {
            "Bionic Reconstruction",
            "Augmetic Arms",
            "Auger Eye",
            "Night\'s Eye",
            "Pict Recorder Eye",
            "Reticule Eye",
            "Telescopic Eye",
            "Augmetic Legs (Pair)",
            "Augmetic Respirator",
            "Augmetic Viscera",
            "Auger Array",
            "Autodogmatic Cortex",
            "Cardioproxy",
            "Cortex Implant",
            "Ballistic Mechadendrite",
            "Exploration Mechadendrite",
            "Medicae Mechadendrite",
            "Optical Mechadendrite",
            "Servo-Arm Mechadendrite",
            "Utility Mechadendrite",
            "Mind Impulse Unit",
            "Neuroplastic Psychosectemy",
            "Reflex Catalyst",
            "Sinew Armature",
            "Sub-Dermal Armor",
            "Weapon Implant",
            "Iron Gob",
            "Iron Gutz",
            "Rebuilt Cranium",
            "Eyes of the Crone",
            "Heart of Vaul"});
            this.augSelectBox.Location = new System.Drawing.Point(12, 12);
            this.augSelectBox.Name = "augSelectBox";
            this.augSelectBox.Size = new System.Drawing.Size(279, 420);
            this.augSelectBox.TabIndex = 1;
            this.augSelectBox.SelectedIndexChanged += new System.EventHandler(this.augSelectBox_SelectedIndexChanged);
            // 
            // augHeaderLabel
            // 
            this.augHeaderLabel.AutoSize = true;
            this.augHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.augHeaderLabel.Location = new System.Drawing.Point(297, 12);
            this.augHeaderLabel.Name = "augHeaderLabel";
            this.augHeaderLabel.Size = new System.Drawing.Size(91, 13);
            this.augHeaderLabel.TabIndex = 2;
            this.augHeaderLabel.Text = "Implant Details";
            // 
            // augRaceLabel
            // 
            this.augRaceLabel.AutoSize = true;
            this.augRaceLabel.Location = new System.Drawing.Point(298, 39);
            this.augRaceLabel.Name = "augRaceLabel";
            this.augRaceLabel.Size = new System.Drawing.Size(36, 13);
            this.augRaceLabel.TabIndex = 3;
            this.augRaceLabel.Text = "Race:";
            // 
            // augDetailsLabel
            // 
            this.augDetailsLabel.AutoSize = true;
            this.augDetailsLabel.Location = new System.Drawing.Point(297, 65);
            this.augDetailsLabel.Name = "augDetailsLabel";
            this.augDetailsLabel.Size = new System.Drawing.Size(42, 13);
            this.augDetailsLabel.TabIndex = 4;
            this.augDetailsLabel.Text = "Details:";
            this.augDetailsLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // augCancelButton
            // 
            this.augCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.augCancelButton.Location = new System.Drawing.Point(457, 409);
            this.augCancelButton.Name = "augCancelButton";
            this.augCancelButton.Size = new System.Drawing.Size(109, 23);
            this.augCancelButton.TabIndex = 6;
            this.augCancelButton.Text = "Cancel";
            this.augCancelButton.UseVisualStyleBackColor = true;
            // 
            // addAugButton
            // 
            this.addAugButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addAugButton.Location = new System.Drawing.Point(297, 409);
            this.addAugButton.Name = "addAugButton";
            this.addAugButton.Size = new System.Drawing.Size(109, 23);
            this.addAugButton.TabIndex = 5;
            this.addAugButton.Text = "Add Augment";
            this.addAugButton.UseVisualStyleBackColor = true;
            // 
            // cyberneticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.augCancelButton);
            this.Controls.Add(this.addAugButton);
            this.Controls.Add(this.augDetailsLabel);
            this.Controls.Add(this.augRaceLabel);
            this.Controls.Add(this.augHeaderLabel);
            this.Controls.Add(this.augSelectBox);
            this.Name = "cyberneticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Augments and Cybernetics";
            this.Load += new System.EventHandler(this.cyberneticsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox augSelectBox;
        private System.Windows.Forms.Label augHeaderLabel;
        private System.Windows.Forms.Label augRaceLabel;
        private System.Windows.Forms.Label augDetailsLabel;
        private System.Windows.Forms.Button augCancelButton;
        private System.Windows.Forms.Button addAugButton;
    }
}