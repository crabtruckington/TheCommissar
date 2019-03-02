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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cyberneticsForm));
            this.augSelectBox = new System.Windows.Forms.ListBox();
            this.augDetailsLabel = new System.Windows.Forms.Label();
            this.augCancelButton = new System.Windows.Forms.Button();
            this.addAugButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // augSelectBox
            // 
            this.augSelectBox.FormattingEnabled = true;
            this.augSelectBox.Items.AddRange(new object[] {
            "Auger Array",
            "Auger Eye",
            "Augmetic Arms",
            "Augmetic Legs (Pair)",
            "Augmetic Respirator",
            "Augmetic Viscera",
            "Autodogmatic Cortex",
            "Ballistic Mechadendrite",
            "Bionic Reconstruction",
            "Cardioproxy",
            "Cortex Implant",
            "Exploration Mechadendrite",
            "Eyes of the Crone",
            "Heart of Vaul",
            "Iron Gob",
            "Iron Gutz",
            "Medicae Mechadendrite",
            "Mind Impulse Unit",
            "Neuroplastic Psychosectemy",
            "Night\'s Eye",
            "Optical Mechadendrite",
            "Pict Recorder Eye",
            "Rebuilt Cranium",
            "Reflex Catalyst",
            "Reticule Eye",
            "Servo-Arm Mechadendrite",
            "Sinew Armature",
            "Sub-Dermal Armor",
            "Telescopic Eye",
            "Utility Mechadendrite",
            "Weapon Implant"});
            this.augSelectBox.Location = new System.Drawing.Point(12, 12);
            this.augSelectBox.Name = "augSelectBox";
            this.augSelectBox.Size = new System.Drawing.Size(279, 420);
            this.augSelectBox.Sorted = true;
            this.augSelectBox.TabIndex = 1;
            this.augSelectBox.SelectedIndexChanged += new System.EventHandler(this.augSelectBox_SelectedIndexChanged);
            // 
            // augDetailsLabel
            // 
            this.augDetailsLabel.Location = new System.Drawing.Point(298, 12);
            this.augDetailsLabel.Name = "augDetailsLabel";
            this.augDetailsLabel.Size = new System.Drawing.Size(268, 384);
            this.augDetailsLabel.TabIndex = 3;
            this.augDetailsLabel.Text = "augDetailsLabel";
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
            this.Controls.Add(this.augSelectBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cyberneticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Augments and Cybernetics";
            this.Load += new System.EventHandler(this.cyberneticsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox augSelectBox;
        private System.Windows.Forms.Label augDetailsLabel;
        private System.Windows.Forms.Button augCancelButton;
        private System.Windows.Forms.Button addAugButton;
    }
}