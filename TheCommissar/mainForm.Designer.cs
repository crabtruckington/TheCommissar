namespace TheCommissar
{
    partial class mainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.buildPointsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.core = new System.Windows.Forms.TabPage();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.removeTalentBtn = new System.Windows.Forms.Button();
            this.addTalentBtn = new System.Windows.Forms.Button();
            this.talentBox = new System.Windows.Forms.ListBox();
            this.talentLabel = new System.Windows.Forms.Label();
            this.archetypeSelect = new System.Windows.Forms.ComboBox();
            this.speciesSelect = new System.Windows.Forms.ComboBox();
            this.tierSelect = new System.Windows.Forms.ComboBox();
            this.tierLabel = new System.Windows.Forms.Label();
            this.attSpeedTotal = new System.Windows.Forms.Label();
            this.attInitiativeTotal = new System.Windows.Forms.Label();
            this.attFellowshipTotal = new System.Windows.Forms.Label();
            this.attWillpowerTotal = new System.Windows.Forms.Label();
            this.attIntellectTotal = new System.Windows.Forms.Label();
            this.attToughnessTotal = new System.Windows.Forms.Label();
            this.attAgilityTotal = new System.Windows.Forms.Label();
            this.attStrengthTotal = new System.Windows.Forms.Label();
            this.archetypeSelectLabel = new System.Windows.Forms.Label();
            this.speciesSelectLabel = new System.Windows.Forms.Label();
            this.raceLabel = new System.Windows.Forms.Label();
            this.attSpeed = new System.Windows.Forms.NumericUpDown();
            this.attInitiative = new System.Windows.Forms.NumericUpDown();
            this.attFellowship = new System.Windows.Forms.NumericUpDown();
            this.attWillpower = new System.Windows.Forms.NumericUpDown();
            this.attIntellect = new System.Windows.Forms.NumericUpDown();
            this.attToughness = new System.Windows.Forms.NumericUpDown();
            this.attAgility = new System.Windows.Forms.NumericUpDown();
            this.attStrength = new System.Windows.Forms.NumericUpDown();
            this.attSpeedLabel = new System.Windows.Forms.Label();
            this.attInitiativeLabel = new System.Windows.Forms.Label();
            this.attFellowshipLabel = new System.Windows.Forms.Label();
            this.attWillpowerLabel = new System.Windows.Forms.Label();
            this.attIntellectLabel = new System.Windows.Forms.Label();
            this.attToughnessLabel = new System.Windows.Forms.Label();
            this.attAgilityLabel = new System.Windows.Forms.Label();
            this.attStrengthLabel = new System.Windows.Forms.Label();
            this.attributesLabel = new System.Windows.Forms.Label();
            this.skills = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.summary = new System.Windows.Forms.TabPage();
            this.athleticsLabel = new System.Windows.Forms.Label();
            this.skillAthletics = new System.Windows.Forms.NumericUpDown();
            this.skillLabel = new System.Windows.Forms.Label();
            this.athleticsRatingLabel = new System.Windows.Forms.Label();
            this.athleticsBonusBox = new System.Windows.Forms.TextBox();
            this.skillRatingLabel = new System.Windows.Forms.Label();
            this.skillBonusLabel = new System.Windows.Forms.Label();
            this.awarenessBonusBox = new System.Windows.Forms.TextBox();
            this.awarenessRatingLabel = new System.Windows.Forms.Label();
            this.skillAwareness = new System.Windows.Forms.NumericUpDown();
            this.awarenessLabel = new System.Windows.Forms.Label();
            this.ballisticBonusBox = new System.Windows.Forms.TextBox();
            this.ballisticRatingLabel = new System.Windows.Forms.Label();
            this.skillBallstic = new System.Windows.Forms.NumericUpDown();
            this.ballisticLabel = new System.Windows.Forms.Label();
            this.cunningBonusBox = new System.Windows.Forms.TextBox();
            this.cunningRatingLabel = new System.Windows.Forms.Label();
            this.skillCunning = new System.Windows.Forms.NumericUpDown();
            this.cunningLabel = new System.Windows.Forms.Label();
            this.deceptionBonusBox = new System.Windows.Forms.TextBox();
            this.deceptionRatingLabel = new System.Windows.Forms.Label();
            this.skillDeception = new System.Windows.Forms.NumericUpDown();
            this.deceptionLabel = new System.Windows.Forms.Label();
            this.insightBonusBox = new System.Windows.Forms.TextBox();
            this.insightRatingLabel = new System.Windows.Forms.Label();
            this.skillInsight = new System.Windows.Forms.NumericUpDown();
            this.insightLabel = new System.Windows.Forms.Label();
            this.intimidationBonusBox = new System.Windows.Forms.TextBox();
            this.intimidationRatingLabel = new System.Windows.Forms.Label();
            this.skillIntimidation = new System.Windows.Forms.NumericUpDown();
            this.intimidationLabel = new System.Windows.Forms.Label();
            this.investigationBonusBox = new System.Windows.Forms.TextBox();
            this.investigationRatingLabel = new System.Windows.Forms.Label();
            this.skillInvestigation = new System.Windows.Forms.NumericUpDown();
            this.investigationLabel = new System.Windows.Forms.Label();
            this.leadershipBonusBox = new System.Windows.Forms.TextBox();
            this.leadershipRatingLabel = new System.Windows.Forms.Label();
            this.skillLeadership = new System.Windows.Forms.NumericUpDown();
            this.leadershipLabel = new System.Windows.Forms.Label();
            this.medicaeBonusBox = new System.Windows.Forms.TextBox();
            this.medicaeRatingLabel = new System.Windows.Forms.Label();
            this.skillMedicae = new System.Windows.Forms.NumericUpDown();
            this.medicaeLabel = new System.Windows.Forms.Label();
            this.persuasionBonusBox = new System.Windows.Forms.TextBox();
            this.persuasionRatingLabel = new System.Windows.Forms.Label();
            this.skillPersuasion = new System.Windows.Forms.NumericUpDown();
            this.persuasionLabel = new System.Windows.Forms.Label();
            this.pilotBonusBox = new System.Windows.Forms.TextBox();
            this.pilotRatingLabel = new System.Windows.Forms.Label();
            this.skillPilot = new System.Windows.Forms.NumericUpDown();
            this.pilotLabel = new System.Windows.Forms.Label();
            this.psychicBonusBox = new System.Windows.Forms.TextBox();
            this.psychicRatingLabel = new System.Windows.Forms.Label();
            this.skillPsychic = new System.Windows.Forms.NumericUpDown();
            this.psychicLabel = new System.Windows.Forms.Label();
            this.scholarBonusBox = new System.Windows.Forms.TextBox();
            this.scholarRatingLabel = new System.Windows.Forms.Label();
            this.skillScholar = new System.Windows.Forms.NumericUpDown();
            this.scholarLabel = new System.Windows.Forms.Label();
            this.stealthBonusBox = new System.Windows.Forms.TextBox();
            this.stealthRatingLabel = new System.Windows.Forms.Label();
            this.skillStealth = new System.Windows.Forms.NumericUpDown();
            this.stealthLabel = new System.Windows.Forms.Label();
            this.survivalBonusBox = new System.Windows.Forms.TextBox();
            this.survivalRatingLabel = new System.Windows.Forms.Label();
            this.skillSurvival = new System.Windows.Forms.NumericUpDown();
            this.survivalLabel = new System.Windows.Forms.Label();
            this.techBonusBox = new System.Windows.Forms.TextBox();
            this.techRatingLabel = new System.Windows.Forms.Label();
            this.skillTech = new System.Windows.Forms.NumericUpDown();
            this.techLabel = new System.Windows.Forms.Label();
            this.weaponSkillBonusBox = new System.Windows.Forms.TextBox();
            this.weaponSkillRatingLabel = new System.Windows.Forms.Label();
            this.skillWeaponSkill = new System.Windows.Forms.NumericUpDown();
            this.weaponSkillLabel = new System.Windows.Forms.Label();
            this.bpSpentAttribLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.bpSpentSkillsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.bpSpentRaceLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.bpSpentArchetypeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.equipment = new System.Windows.Forms.TabPage();
            this.psychicpowers = new System.Windows.Forms.TabPage();
            this.notes = new System.Windows.Forms.TabPage();
            this.notesTextBox = new System.Windows.Forms.RichTextBox();
            this.addBPButton = new System.Windows.Forms.Button();
            this.removeBPButton = new System.Windows.Forms.Button();
            this.equipmentTextBox = new System.Windows.Forms.RichTextBox();
            this.powersTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.core.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attInitiative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attFellowship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attWillpower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attIntellect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attToughness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attAgility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attStrength)).BeginInit();
            this.skills.SuspendLayout();
            this.tabControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skillAthletics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillAwareness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillBallstic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillCunning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillDeception)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillInsight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillIntimidation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillInvestigation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillLeadership)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillMedicae)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillPersuasion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillPilot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillPsychic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillScholar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillStealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillSurvival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillTech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillWeaponSkill)).BeginInit();
            this.equipment.SuspendLayout();
            this.psychicpowers.SuspendLayout();
            this.notes.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1288, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildPointsLabel,
            this.bpSpentAttribLabel,
            this.bpSpentSkillsLabel,
            this.bpSpentRaceLabel,
            this.bpSpentArchetypeLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 561);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1288, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // buildPointsLabel
            // 
            this.buildPointsLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.buildPointsLabel.Name = "buildPointsLabel";
            this.buildPointsLabel.Size = new System.Drawing.Size(77, 19);
            this.buildPointsLabel.Text = "Build Points:";
            this.buildPointsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buildPointsLabel.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 537);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Size = new System.Drawing.Size(1285, 537);
            this.splitContainer1.SplitterDistance = 836;
            this.splitContainer1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.core);
            this.tabControl1.Controls.Add(this.skills);
            this.tabControl1.Controls.Add(this.equipment);
            this.tabControl1.Controls.Add(this.psychicpowers);
            this.tabControl1.Controls.Add(this.notes);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(834, 535);
            this.tabControl1.TabIndex = 0;
            // 
            // core
            // 
            this.core.BackColor = System.Drawing.Color.WhiteSmoke;
            this.core.Controls.Add(this.removeBPButton);
            this.core.Controls.Add(this.addBPButton);
            this.core.Controls.Add(this.nameBox);
            this.core.Controls.Add(this.nameLabel);
            this.core.Controls.Add(this.removeTalentBtn);
            this.core.Controls.Add(this.addTalentBtn);
            this.core.Controls.Add(this.talentBox);
            this.core.Controls.Add(this.talentLabel);
            this.core.Controls.Add(this.archetypeSelect);
            this.core.Controls.Add(this.speciesSelect);
            this.core.Controls.Add(this.tierSelect);
            this.core.Controls.Add(this.tierLabel);
            this.core.Controls.Add(this.attSpeedTotal);
            this.core.Controls.Add(this.attInitiativeTotal);
            this.core.Controls.Add(this.attFellowshipTotal);
            this.core.Controls.Add(this.attWillpowerTotal);
            this.core.Controls.Add(this.attIntellectTotal);
            this.core.Controls.Add(this.attToughnessTotal);
            this.core.Controls.Add(this.attAgilityTotal);
            this.core.Controls.Add(this.attStrengthTotal);
            this.core.Controls.Add(this.archetypeSelectLabel);
            this.core.Controls.Add(this.speciesSelectLabel);
            this.core.Controls.Add(this.raceLabel);
            this.core.Controls.Add(this.attSpeed);
            this.core.Controls.Add(this.attInitiative);
            this.core.Controls.Add(this.attFellowship);
            this.core.Controls.Add(this.attWillpower);
            this.core.Controls.Add(this.attIntellect);
            this.core.Controls.Add(this.attToughness);
            this.core.Controls.Add(this.attAgility);
            this.core.Controls.Add(this.attStrength);
            this.core.Controls.Add(this.attSpeedLabel);
            this.core.Controls.Add(this.attInitiativeLabel);
            this.core.Controls.Add(this.attFellowshipLabel);
            this.core.Controls.Add(this.attWillpowerLabel);
            this.core.Controls.Add(this.attIntellectLabel);
            this.core.Controls.Add(this.attToughnessLabel);
            this.core.Controls.Add(this.attAgilityLabel);
            this.core.Controls.Add(this.attStrengthLabel);
            this.core.Controls.Add(this.attributesLabel);
            this.core.Location = new System.Drawing.Point(4, 22);
            this.core.Name = "core";
            this.core.Padding = new System.Windows.Forms.Padding(3);
            this.core.Size = new System.Drawing.Size(826, 509);
            this.core.TabIndex = 0;
            this.core.Text = "Core";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(61, 37);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(157, 20);
            this.nameBox.TabIndex = 40;
            this.nameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(0, 40);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 39;
            this.nameLabel.Text = "Name";
            // 
            // removeTalentBtn
            // 
            this.removeTalentBtn.Location = new System.Drawing.Point(582, 360);
            this.removeTalentBtn.Name = "removeTalentBtn";
            this.removeTalentBtn.Size = new System.Drawing.Size(94, 23);
            this.removeTalentBtn.TabIndex = 38;
            this.removeTalentBtn.Text = "Remove Talent";
            this.removeTalentBtn.UseVisualStyleBackColor = true;
            this.removeTalentBtn.Click += new System.EventHandler(this.removeTalentBtn_Click);
            // 
            // addTalentBtn
            // 
            this.addTalentBtn.Location = new System.Drawing.Point(462, 360);
            this.addTalentBtn.Name = "addTalentBtn";
            this.addTalentBtn.Size = new System.Drawing.Size(94, 23);
            this.addTalentBtn.TabIndex = 37;
            this.addTalentBtn.Text = "Add Talent";
            this.addTalentBtn.UseVisualStyleBackColor = true;
            this.addTalentBtn.Click += new System.EventHandler(this.addTalentBtn_Click);
            // 
            // talentBox
            // 
            this.talentBox.FormattingEnabled = true;
            this.talentBox.Location = new System.Drawing.Point(462, 37);
            this.talentBox.Name = "talentBox";
            this.talentBox.Size = new System.Drawing.Size(214, 316);
            this.talentBox.TabIndex = 36;
            // 
            // talentLabel
            // 
            this.talentLabel.AutoSize = true;
            this.talentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.talentLabel.Location = new System.Drawing.Point(459, 4);
            this.talentLabel.Name = "talentLabel";
            this.talentLabel.Size = new System.Drawing.Size(49, 13);
            this.talentLabel.TabIndex = 35;
            this.talentLabel.Text = "Talents";
            // 
            // archetypeSelect
            // 
            this.archetypeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.archetypeSelect.FormattingEnabled = true;
            this.archetypeSelect.Location = new System.Drawing.Point(61, 113);
            this.archetypeSelect.Name = "archetypeSelect";
            this.archetypeSelect.Size = new System.Drawing.Size(157, 21);
            this.archetypeSelect.TabIndex = 34;
            this.archetypeSelect.SelectedIndexChanged += new System.EventHandler(this.archetypeSelect_SelectedIndexChanged);
            // 
            // speciesSelect
            // 
            this.speciesSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speciesSelect.FormattingEnabled = true;
            this.speciesSelect.Location = new System.Drawing.Point(61, 87);
            this.speciesSelect.Name = "speciesSelect";
            this.speciesSelect.Size = new System.Drawing.Size(157, 21);
            this.speciesSelect.TabIndex = 33;
            this.speciesSelect.SelectedIndexChanged += new System.EventHandler(this.speciesSelect_SelectedIndexChanged);
            // 
            // tierSelect
            // 
            this.tierSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tierSelect.FormattingEnabled = true;
            this.tierSelect.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.tierSelect.Location = new System.Drawing.Point(61, 62);
            this.tierSelect.Name = "tierSelect";
            this.tierSelect.Size = new System.Drawing.Size(157, 21);
            this.tierSelect.TabIndex = 32;
            this.tierSelect.SelectedIndexChanged += new System.EventHandler(this.tierSelect_SelectedIndexChanged_1);
            // 
            // tierLabel
            // 
            this.tierLabel.AutoSize = true;
            this.tierLabel.Location = new System.Drawing.Point(-1, 65);
            this.tierLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.tierLabel.Name = "tierLabel";
            this.tierLabel.Size = new System.Drawing.Size(25, 13);
            this.tierLabel.TabIndex = 30;
            this.tierLabel.Text = "Tier";
            // 
            // attSpeedTotal
            // 
            this.attSpeedTotal.AutoSize = true;
            this.attSpeedTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attSpeedTotal.Location = new System.Drawing.Point(370, 215);
            this.attSpeedTotal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attSpeedTotal.Name = "attSpeedTotal";
            this.attSpeedTotal.Size = new System.Drawing.Size(87, 13);
            this.attSpeedTotal.TabIndex = 29;
            this.attSpeedTotal.Text = "attSpeedTotal";
            // 
            // attInitiativeTotal
            // 
            this.attInitiativeTotal.AutoSize = true;
            this.attInitiativeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attInitiativeTotal.Location = new System.Drawing.Point(370, 190);
            this.attInitiativeTotal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attInitiativeTotal.Name = "attInitiativeTotal";
            this.attInitiativeTotal.Size = new System.Drawing.Size(100, 13);
            this.attInitiativeTotal.TabIndex = 28;
            this.attInitiativeTotal.Text = "attInitiativeTotal";
            // 
            // attFellowshipTotal
            // 
            this.attFellowshipTotal.AutoSize = true;
            this.attFellowshipTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attFellowshipTotal.Location = new System.Drawing.Point(370, 165);
            this.attFellowshipTotal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attFellowshipTotal.Name = "attFellowshipTotal";
            this.attFellowshipTotal.Size = new System.Drawing.Size(110, 13);
            this.attFellowshipTotal.TabIndex = 27;
            this.attFellowshipTotal.Text = "attFellowshipTotal";
            // 
            // attWillpowerTotal
            // 
            this.attWillpowerTotal.AutoSize = true;
            this.attWillpowerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attWillpowerTotal.Location = new System.Drawing.Point(370, 140);
            this.attWillpowerTotal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attWillpowerTotal.Name = "attWillpowerTotal";
            this.attWillpowerTotal.Size = new System.Drawing.Size(106, 13);
            this.attWillpowerTotal.TabIndex = 26;
            this.attWillpowerTotal.Text = "attWillpowerTotal";
            // 
            // attIntellectTotal
            // 
            this.attIntellectTotal.AutoSize = true;
            this.attIntellectTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attIntellectTotal.Location = new System.Drawing.Point(370, 115);
            this.attIntellectTotal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attIntellectTotal.Name = "attIntellectTotal";
            this.attIntellectTotal.Size = new System.Drawing.Size(97, 13);
            this.attIntellectTotal.TabIndex = 25;
            this.attIntellectTotal.Text = "attIntellectTotal";
            // 
            // attToughnessTotal
            // 
            this.attToughnessTotal.AutoSize = true;
            this.attToughnessTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attToughnessTotal.Location = new System.Drawing.Point(370, 90);
            this.attToughnessTotal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attToughnessTotal.Name = "attToughnessTotal";
            this.attToughnessTotal.Size = new System.Drawing.Size(113, 13);
            this.attToughnessTotal.TabIndex = 24;
            this.attToughnessTotal.Text = "attToughnessTotal";
            // 
            // attAgilityTotal
            // 
            this.attAgilityTotal.AutoSize = true;
            this.attAgilityTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attAgilityTotal.Location = new System.Drawing.Point(370, 65);
            this.attAgilityTotal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attAgilityTotal.Name = "attAgilityTotal";
            this.attAgilityTotal.Size = new System.Drawing.Size(85, 13);
            this.attAgilityTotal.TabIndex = 23;
            this.attAgilityTotal.Text = "attAgilityTotal";
            // 
            // attStrengthTotal
            // 
            this.attStrengthTotal.AutoSize = true;
            this.attStrengthTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attStrengthTotal.Location = new System.Drawing.Point(370, 40);
            this.attStrengthTotal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attStrengthTotal.Name = "attStrengthTotal";
            this.attStrengthTotal.Size = new System.Drawing.Size(99, 13);
            this.attStrengthTotal.TabIndex = 22;
            this.attStrengthTotal.Text = "attStrengthTotal";
            this.attStrengthTotal.Click += new System.EventHandler(this.attStrengthTotal_Click);
            // 
            // archetypeSelectLabel
            // 
            this.archetypeSelectLabel.AutoSize = true;
            this.archetypeSelectLabel.Location = new System.Drawing.Point(0, 115);
            this.archetypeSelectLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.archetypeSelectLabel.Name = "archetypeSelectLabel";
            this.archetypeSelectLabel.Size = new System.Drawing.Size(55, 13);
            this.archetypeSelectLabel.TabIndex = 20;
            this.archetypeSelectLabel.Text = "Archetype";
            // 
            // speciesSelectLabel
            // 
            this.speciesSelectLabel.AutoSize = true;
            this.speciesSelectLabel.Location = new System.Drawing.Point(-1, 90);
            this.speciesSelectLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.speciesSelectLabel.Name = "speciesSelectLabel";
            this.speciesSelectLabel.Size = new System.Drawing.Size(45, 13);
            this.speciesSelectLabel.TabIndex = 19;
            this.speciesSelectLabel.Text = "Species";
            // 
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceLabel.Location = new System.Drawing.Point(-1, 4);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(118, 13);
            this.raceLabel.TabIndex = 17;
            this.raceLabel.Text = "General Information";
            // 
            // attSpeed
            // 
            this.attSpeed.Enabled = false;
            this.attSpeed.Location = new System.Drawing.Point(317, 213);
            this.attSpeed.Name = "attSpeed";
            this.attSpeed.ReadOnly = true;
            this.attSpeed.Size = new System.Drawing.Size(47, 20);
            this.attSpeed.TabIndex = 16;
            this.attSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attSpeed.ValueChanged += new System.EventHandler(this.attSpeed_ValueChanged);
            // 
            // attInitiative
            // 
            this.attInitiative.Location = new System.Drawing.Point(317, 188);
            this.attInitiative.Name = "attInitiative";
            this.attInitiative.ReadOnly = true;
            this.attInitiative.Size = new System.Drawing.Size(47, 20);
            this.attInitiative.TabIndex = 15;
            this.attInitiative.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attInitiative.ValueChanged += new System.EventHandler(this.attInitiative_ValueChanged);
            // 
            // attFellowship
            // 
            this.attFellowship.Location = new System.Drawing.Point(317, 163);
            this.attFellowship.Name = "attFellowship";
            this.attFellowship.ReadOnly = true;
            this.attFellowship.Size = new System.Drawing.Size(47, 20);
            this.attFellowship.TabIndex = 14;
            this.attFellowship.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attFellowship.ValueChanged += new System.EventHandler(this.attFellowship_ValueChanged);
            // 
            // attWillpower
            // 
            this.attWillpower.Location = new System.Drawing.Point(317, 138);
            this.attWillpower.Name = "attWillpower";
            this.attWillpower.ReadOnly = true;
            this.attWillpower.Size = new System.Drawing.Size(47, 20);
            this.attWillpower.TabIndex = 13;
            this.attWillpower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attWillpower.ValueChanged += new System.EventHandler(this.attWillpower_ValueChanged);
            // 
            // attIntellect
            // 
            this.attIntellect.Location = new System.Drawing.Point(317, 113);
            this.attIntellect.Name = "attIntellect";
            this.attIntellect.ReadOnly = true;
            this.attIntellect.Size = new System.Drawing.Size(47, 20);
            this.attIntellect.TabIndex = 12;
            this.attIntellect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attIntellect.ValueChanged += new System.EventHandler(this.attIntellect_ValueChanged);
            // 
            // attToughness
            // 
            this.attToughness.Location = new System.Drawing.Point(317, 88);
            this.attToughness.Name = "attToughness";
            this.attToughness.ReadOnly = true;
            this.attToughness.Size = new System.Drawing.Size(47, 20);
            this.attToughness.TabIndex = 11;
            this.attToughness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attToughness.ValueChanged += new System.EventHandler(this.attToughness_ValueChanged);
            // 
            // attAgility
            // 
            this.attAgility.Location = new System.Drawing.Point(317, 63);
            this.attAgility.Name = "attAgility";
            this.attAgility.ReadOnly = true;
            this.attAgility.Size = new System.Drawing.Size(47, 20);
            this.attAgility.TabIndex = 10;
            this.attAgility.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attAgility.ValueChanged += new System.EventHandler(this.attAgility_ValueChanged);
            // 
            // attStrength
            // 
            this.attStrength.Location = new System.Drawing.Point(317, 38);
            this.attStrength.Name = "attStrength";
            this.attStrength.ReadOnly = true;
            this.attStrength.Size = new System.Drawing.Size(47, 20);
            this.attStrength.TabIndex = 9;
            this.attStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attStrength.ValueChanged += new System.EventHandler(this.attStrength_ValueChanged);
            // 
            // attSpeedLabel
            // 
            this.attSpeedLabel.AutoSize = true;
            this.attSpeedLabel.Location = new System.Drawing.Point(235, 215);
            this.attSpeedLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attSpeedLabel.Name = "attSpeedLabel";
            this.attSpeedLabel.Size = new System.Drawing.Size(38, 13);
            this.attSpeedLabel.TabIndex = 8;
            this.attSpeedLabel.Text = "Speed";
            // 
            // attInitiativeLabel
            // 
            this.attInitiativeLabel.AutoSize = true;
            this.attInitiativeLabel.Location = new System.Drawing.Point(235, 190);
            this.attInitiativeLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attInitiativeLabel.Name = "attInitiativeLabel";
            this.attInitiativeLabel.Size = new System.Drawing.Size(46, 13);
            this.attInitiativeLabel.TabIndex = 7;
            this.attInitiativeLabel.Text = "Initiative";
            // 
            // attFellowshipLabel
            // 
            this.attFellowshipLabel.AutoSize = true;
            this.attFellowshipLabel.Location = new System.Drawing.Point(235, 165);
            this.attFellowshipLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attFellowshipLabel.Name = "attFellowshipLabel";
            this.attFellowshipLabel.Size = new System.Drawing.Size(56, 13);
            this.attFellowshipLabel.TabIndex = 6;
            this.attFellowshipLabel.Text = "Fellowship";
            // 
            // attWillpowerLabel
            // 
            this.attWillpowerLabel.AutoSize = true;
            this.attWillpowerLabel.Location = new System.Drawing.Point(235, 140);
            this.attWillpowerLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attWillpowerLabel.Name = "attWillpowerLabel";
            this.attWillpowerLabel.Size = new System.Drawing.Size(53, 13);
            this.attWillpowerLabel.TabIndex = 5;
            this.attWillpowerLabel.Text = "Willpower";
            // 
            // attIntellectLabel
            // 
            this.attIntellectLabel.AutoSize = true;
            this.attIntellectLabel.Location = new System.Drawing.Point(235, 115);
            this.attIntellectLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attIntellectLabel.Name = "attIntellectLabel";
            this.attIntellectLabel.Size = new System.Drawing.Size(44, 13);
            this.attIntellectLabel.TabIndex = 4;
            this.attIntellectLabel.Text = "Intellect";
            // 
            // attToughnessLabel
            // 
            this.attToughnessLabel.AutoSize = true;
            this.attToughnessLabel.Location = new System.Drawing.Point(235, 90);
            this.attToughnessLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attToughnessLabel.Name = "attToughnessLabel";
            this.attToughnessLabel.Size = new System.Drawing.Size(60, 13);
            this.attToughnessLabel.TabIndex = 3;
            this.attToughnessLabel.Text = "Toughness";
            // 
            // attAgilityLabel
            // 
            this.attAgilityLabel.AutoSize = true;
            this.attAgilityLabel.Location = new System.Drawing.Point(235, 65);
            this.attAgilityLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attAgilityLabel.Name = "attAgilityLabel";
            this.attAgilityLabel.Size = new System.Drawing.Size(34, 13);
            this.attAgilityLabel.TabIndex = 2;
            this.attAgilityLabel.Text = "Agility";
            // 
            // attStrengthLabel
            // 
            this.attStrengthLabel.AutoSize = true;
            this.attStrengthLabel.Location = new System.Drawing.Point(235, 40);
            this.attStrengthLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attStrengthLabel.Name = "attStrengthLabel";
            this.attStrengthLabel.Size = new System.Drawing.Size(47, 13);
            this.attStrengthLabel.TabIndex = 1;
            this.attStrengthLabel.Text = "Strength";
            // 
            // attributesLabel
            // 
            this.attributesLabel.AutoSize = true;
            this.attributesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attributesLabel.Location = new System.Drawing.Point(235, 4);
            this.attributesLabel.Name = "attributesLabel";
            this.attributesLabel.Size = new System.Drawing.Size(61, 13);
            this.attributesLabel.TabIndex = 0;
            this.attributesLabel.Text = "Attributes";
            // 
            // skills
            // 
            this.skills.BackColor = System.Drawing.Color.WhiteSmoke;
            this.skills.Controls.Add(this.weaponSkillBonusBox);
            this.skills.Controls.Add(this.weaponSkillRatingLabel);
            this.skills.Controls.Add(this.skillWeaponSkill);
            this.skills.Controls.Add(this.weaponSkillLabel);
            this.skills.Controls.Add(this.techBonusBox);
            this.skills.Controls.Add(this.techRatingLabel);
            this.skills.Controls.Add(this.skillTech);
            this.skills.Controls.Add(this.techLabel);
            this.skills.Controls.Add(this.survivalBonusBox);
            this.skills.Controls.Add(this.survivalRatingLabel);
            this.skills.Controls.Add(this.skillSurvival);
            this.skills.Controls.Add(this.survivalLabel);
            this.skills.Controls.Add(this.stealthBonusBox);
            this.skills.Controls.Add(this.stealthRatingLabel);
            this.skills.Controls.Add(this.skillStealth);
            this.skills.Controls.Add(this.stealthLabel);
            this.skills.Controls.Add(this.scholarBonusBox);
            this.skills.Controls.Add(this.scholarRatingLabel);
            this.skills.Controls.Add(this.skillScholar);
            this.skills.Controls.Add(this.scholarLabel);
            this.skills.Controls.Add(this.psychicBonusBox);
            this.skills.Controls.Add(this.psychicRatingLabel);
            this.skills.Controls.Add(this.skillPsychic);
            this.skills.Controls.Add(this.psychicLabel);
            this.skills.Controls.Add(this.pilotBonusBox);
            this.skills.Controls.Add(this.pilotRatingLabel);
            this.skills.Controls.Add(this.skillPilot);
            this.skills.Controls.Add(this.pilotLabel);
            this.skills.Controls.Add(this.persuasionBonusBox);
            this.skills.Controls.Add(this.persuasionRatingLabel);
            this.skills.Controls.Add(this.skillPersuasion);
            this.skills.Controls.Add(this.persuasionLabel);
            this.skills.Controls.Add(this.medicaeBonusBox);
            this.skills.Controls.Add(this.medicaeRatingLabel);
            this.skills.Controls.Add(this.skillMedicae);
            this.skills.Controls.Add(this.medicaeLabel);
            this.skills.Controls.Add(this.leadershipBonusBox);
            this.skills.Controls.Add(this.leadershipRatingLabel);
            this.skills.Controls.Add(this.skillLeadership);
            this.skills.Controls.Add(this.leadershipLabel);
            this.skills.Controls.Add(this.investigationBonusBox);
            this.skills.Controls.Add(this.investigationRatingLabel);
            this.skills.Controls.Add(this.skillInvestigation);
            this.skills.Controls.Add(this.investigationLabel);
            this.skills.Controls.Add(this.intimidationBonusBox);
            this.skills.Controls.Add(this.intimidationRatingLabel);
            this.skills.Controls.Add(this.skillIntimidation);
            this.skills.Controls.Add(this.intimidationLabel);
            this.skills.Controls.Add(this.insightBonusBox);
            this.skills.Controls.Add(this.insightRatingLabel);
            this.skills.Controls.Add(this.skillInsight);
            this.skills.Controls.Add(this.insightLabel);
            this.skills.Controls.Add(this.deceptionBonusBox);
            this.skills.Controls.Add(this.deceptionRatingLabel);
            this.skills.Controls.Add(this.skillDeception);
            this.skills.Controls.Add(this.deceptionLabel);
            this.skills.Controls.Add(this.cunningBonusBox);
            this.skills.Controls.Add(this.cunningRatingLabel);
            this.skills.Controls.Add(this.skillCunning);
            this.skills.Controls.Add(this.cunningLabel);
            this.skills.Controls.Add(this.ballisticBonusBox);
            this.skills.Controls.Add(this.ballisticRatingLabel);
            this.skills.Controls.Add(this.skillBallstic);
            this.skills.Controls.Add(this.ballisticLabel);
            this.skills.Controls.Add(this.awarenessBonusBox);
            this.skills.Controls.Add(this.awarenessRatingLabel);
            this.skills.Controls.Add(this.skillAwareness);
            this.skills.Controls.Add(this.awarenessLabel);
            this.skills.Controls.Add(this.skillBonusLabel);
            this.skills.Controls.Add(this.skillRatingLabel);
            this.skills.Controls.Add(this.athleticsBonusBox);
            this.skills.Controls.Add(this.athleticsRatingLabel);
            this.skills.Controls.Add(this.skillLabel);
            this.skills.Controls.Add(this.skillAthletics);
            this.skills.Controls.Add(this.athleticsLabel);
            this.skills.Location = new System.Drawing.Point(4, 22);
            this.skills.Name = "skills";
            this.skills.Padding = new System.Windows.Forms.Padding(3);
            this.skills.Size = new System.Drawing.Size(826, 509);
            this.skills.TabIndex = 1;
            this.skills.Text = "Skills";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.summary);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(443, 535);
            this.tabControl2.TabIndex = 0;
            // 
            // summary
            // 
            this.summary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.summary.Location = new System.Drawing.Point(4, 22);
            this.summary.Name = "summary";
            this.summary.Padding = new System.Windows.Forms.Padding(3);
            this.summary.Size = new System.Drawing.Size(435, 509);
            this.summary.TabIndex = 0;
            this.summary.Text = "Summary";
            // 
            // athleticsLabel
            // 
            this.athleticsLabel.AutoSize = true;
            this.athleticsLabel.Location = new System.Drawing.Point(1, 36);
            this.athleticsLabel.Name = "athleticsLabel";
            this.athleticsLabel.Size = new System.Drawing.Size(96, 13);
            this.athleticsLabel.TabIndex = 0;
            this.athleticsLabel.Text = "Athletics (Strength)";
            // 
            // skillAthletics
            // 
            this.skillAthletics.Location = new System.Drawing.Point(187, 34);
            this.skillAthletics.Name = "skillAthletics";
            this.skillAthletics.ReadOnly = true;
            this.skillAthletics.Size = new System.Drawing.Size(45, 20);
            this.skillAthletics.TabIndex = 1;
            this.skillAthletics.ValueChanged += new System.EventHandler(this.skillAthletics_ValueChanged);
            // 
            // skillLabel
            // 
            this.skillLabel.AutoSize = true;
            this.skillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillLabel.Location = new System.Drawing.Point(1, 4);
            this.skillLabel.Name = "skillLabel";
            this.skillLabel.Size = new System.Drawing.Size(37, 13);
            this.skillLabel.TabIndex = 2;
            this.skillLabel.Text = "Skills";
            // 
            // athleticsRatingLabel
            // 
            this.athleticsRatingLabel.AutoSize = true;
            this.athleticsRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.athleticsRatingLabel.Location = new System.Drawing.Point(238, 36);
            this.athleticsRatingLabel.Name = "athleticsRatingLabel";
            this.athleticsRatingLabel.Size = new System.Drawing.Size(41, 13);
            this.athleticsRatingLabel.TabIndex = 3;
            this.athleticsRatingLabel.Text = "label3";
            // 
            // athleticsBonusBox
            // 
            this.athleticsBonusBox.Location = new System.Drawing.Point(295, 33);
            this.athleticsBonusBox.Name = "athleticsBonusBox";
            this.athleticsBonusBox.Size = new System.Drawing.Size(511, 20);
            this.athleticsBonusBox.TabIndex = 4;
            // 
            // skillRatingLabel
            // 
            this.skillRatingLabel.AutoSize = true;
            this.skillRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillRatingLabel.Location = new System.Drawing.Point(184, 4);
            this.skillRatingLabel.Name = "skillRatingLabel";
            this.skillRatingLabel.Size = new System.Drawing.Size(72, 13);
            this.skillRatingLabel.TabIndex = 5;
            this.skillRatingLabel.Text = "Skill Rating";
            // 
            // skillBonusLabel
            // 
            this.skillBonusLabel.AutoSize = true;
            this.skillBonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillBonusLabel.Location = new System.Drawing.Point(292, 4);
            this.skillBonusLabel.Name = "skillBonusLabel";
            this.skillBonusLabel.Size = new System.Drawing.Size(83, 13);
            this.skillBonusLabel.TabIndex = 6;
            this.skillBonusLabel.Text = "Skill Bonuses";
            // 
            // awarenessBonusBox
            // 
            this.awarenessBonusBox.Location = new System.Drawing.Point(295, 59);
            this.awarenessBonusBox.Name = "awarenessBonusBox";
            this.awarenessBonusBox.Size = new System.Drawing.Size(511, 20);
            this.awarenessBonusBox.TabIndex = 10;
            // 
            // awarenessRatingLabel
            // 
            this.awarenessRatingLabel.AutoSize = true;
            this.awarenessRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awarenessRatingLabel.Location = new System.Drawing.Point(238, 62);
            this.awarenessRatingLabel.Name = "awarenessRatingLabel";
            this.awarenessRatingLabel.Size = new System.Drawing.Size(41, 13);
            this.awarenessRatingLabel.TabIndex = 9;
            this.awarenessRatingLabel.Text = "label2";
            // 
            // skillAwareness
            // 
            this.skillAwareness.Location = new System.Drawing.Point(187, 60);
            this.skillAwareness.Name = "skillAwareness";
            this.skillAwareness.ReadOnly = true;
            this.skillAwareness.Size = new System.Drawing.Size(45, 20);
            this.skillAwareness.TabIndex = 8;
            this.skillAwareness.ValueChanged += new System.EventHandler(this.skillAwareness_ValueChanged);
            // 
            // awarenessLabel
            // 
            this.awarenessLabel.AutoSize = true;
            this.awarenessLabel.Location = new System.Drawing.Point(1, 62);
            this.awarenessLabel.Name = "awarenessLabel";
            this.awarenessLabel.Size = new System.Drawing.Size(105, 13);
            this.awarenessLabel.TabIndex = 7;
            this.awarenessLabel.Text = "Awareness (Intellect)";
            // 
            // ballisticBonusBox
            // 
            this.ballisticBonusBox.Location = new System.Drawing.Point(295, 85);
            this.ballisticBonusBox.Name = "ballisticBonusBox";
            this.ballisticBonusBox.Size = new System.Drawing.Size(511, 20);
            this.ballisticBonusBox.TabIndex = 14;
            // 
            // ballisticRatingLabel
            // 
            this.ballisticRatingLabel.AutoSize = true;
            this.ballisticRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ballisticRatingLabel.Location = new System.Drawing.Point(238, 88);
            this.ballisticRatingLabel.Name = "ballisticRatingLabel";
            this.ballisticRatingLabel.Size = new System.Drawing.Size(41, 13);
            this.ballisticRatingLabel.TabIndex = 13;
            this.ballisticRatingLabel.Text = "label5";
            // 
            // skillBallstic
            // 
            this.skillBallstic.Location = new System.Drawing.Point(187, 86);
            this.skillBallstic.Name = "skillBallstic";
            this.skillBallstic.ReadOnly = true;
            this.skillBallstic.Size = new System.Drawing.Size(45, 20);
            this.skillBallstic.TabIndex = 12;
            this.skillBallstic.ValueChanged += new System.EventHandler(this.skillBallstic_ValueChanged);
            // 
            // ballisticLabel
            // 
            this.ballisticLabel.AutoSize = true;
            this.ballisticLabel.Location = new System.Drawing.Point(1, 88);
            this.ballisticLabel.Name = "ballisticLabel";
            this.ballisticLabel.Size = new System.Drawing.Size(100, 13);
            this.ballisticLabel.TabIndex = 11;
            this.ballisticLabel.Text = "Ballistic Skill (Agility)";
            // 
            // cunningBonusBox
            // 
            this.cunningBonusBox.Location = new System.Drawing.Point(295, 111);
            this.cunningBonusBox.Name = "cunningBonusBox";
            this.cunningBonusBox.Size = new System.Drawing.Size(511, 20);
            this.cunningBonusBox.TabIndex = 18;
            // 
            // cunningRatingLabel
            // 
            this.cunningRatingLabel.AutoSize = true;
            this.cunningRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cunningRatingLabel.Location = new System.Drawing.Point(238, 114);
            this.cunningRatingLabel.Name = "cunningRatingLabel";
            this.cunningRatingLabel.Size = new System.Drawing.Size(41, 13);
            this.cunningRatingLabel.TabIndex = 17;
            this.cunningRatingLabel.Text = "label7";
            // 
            // skillCunning
            // 
            this.skillCunning.Location = new System.Drawing.Point(187, 112);
            this.skillCunning.Name = "skillCunning";
            this.skillCunning.ReadOnly = true;
            this.skillCunning.Size = new System.Drawing.Size(45, 20);
            this.skillCunning.TabIndex = 16;
            this.skillCunning.ValueChanged += new System.EventHandler(this.skillCunning_ValueChanged);
            // 
            // cunningLabel
            // 
            this.cunningLabel.AutoSize = true;
            this.cunningLabel.Location = new System.Drawing.Point(1, 114);
            this.cunningLabel.Name = "cunningLabel";
            this.cunningLabel.Size = new System.Drawing.Size(104, 13);
            this.cunningLabel.TabIndex = 15;
            this.cunningLabel.Text = "Cunning (Fellowship)";
            // 
            // deceptionBonusBox
            // 
            this.deceptionBonusBox.Location = new System.Drawing.Point(295, 137);
            this.deceptionBonusBox.Name = "deceptionBonusBox";
            this.deceptionBonusBox.Size = new System.Drawing.Size(511, 20);
            this.deceptionBonusBox.TabIndex = 22;
            // 
            // deceptionRatingLabel
            // 
            this.deceptionRatingLabel.AutoSize = true;
            this.deceptionRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deceptionRatingLabel.Location = new System.Drawing.Point(238, 140);
            this.deceptionRatingLabel.Name = "deceptionRatingLabel";
            this.deceptionRatingLabel.Size = new System.Drawing.Size(41, 13);
            this.deceptionRatingLabel.TabIndex = 21;
            this.deceptionRatingLabel.Text = "label9";
            // 
            // skillDeception
            // 
            this.skillDeception.Location = new System.Drawing.Point(187, 138);
            this.skillDeception.Name = "skillDeception";
            this.skillDeception.ReadOnly = true;
            this.skillDeception.Size = new System.Drawing.Size(45, 20);
            this.skillDeception.TabIndex = 20;
            this.skillDeception.ValueChanged += new System.EventHandler(this.skillDeception_ValueChanged);
            // 
            // deceptionLabel
            // 
            this.deceptionLabel.AutoSize = true;
            this.deceptionLabel.Location = new System.Drawing.Point(1, 140);
            this.deceptionLabel.Name = "deceptionLabel";
            this.deceptionLabel.Size = new System.Drawing.Size(116, 13);
            this.deceptionLabel.TabIndex = 19;
            this.deceptionLabel.Text = "Deception (FellowShip)";
            // 
            // insightBonusBox
            // 
            this.insightBonusBox.Location = new System.Drawing.Point(295, 163);
            this.insightBonusBox.Name = "insightBonusBox";
            this.insightBonusBox.Size = new System.Drawing.Size(511, 20);
            this.insightBonusBox.TabIndex = 26;
            // 
            // insightRatingLabel
            // 
            this.insightRatingLabel.AutoSize = true;
            this.insightRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insightRatingLabel.Location = new System.Drawing.Point(238, 166);
            this.insightRatingLabel.Name = "insightRatingLabel";
            this.insightRatingLabel.Size = new System.Drawing.Size(48, 13);
            this.insightRatingLabel.TabIndex = 25;
            this.insightRatingLabel.Text = "label11";
            // 
            // skillInsight
            // 
            this.skillInsight.Location = new System.Drawing.Point(187, 164);
            this.skillInsight.Name = "skillInsight";
            this.skillInsight.ReadOnly = true;
            this.skillInsight.Size = new System.Drawing.Size(45, 20);
            this.skillInsight.TabIndex = 24;
            this.skillInsight.ValueChanged += new System.EventHandler(this.skillInsight_ValueChanged);
            // 
            // insightLabel
            // 
            this.insightLabel.AutoSize = true;
            this.insightLabel.Location = new System.Drawing.Point(1, 166);
            this.insightLabel.Name = "insightLabel";
            this.insightLabel.Size = new System.Drawing.Size(96, 13);
            this.insightLabel.TabIndex = 23;
            this.insightLabel.Text = "Insight (Fellowship)";
            // 
            // intimidationBonusBox
            // 
            this.intimidationBonusBox.Location = new System.Drawing.Point(295, 189);
            this.intimidationBonusBox.Name = "intimidationBonusBox";
            this.intimidationBonusBox.Size = new System.Drawing.Size(511, 20);
            this.intimidationBonusBox.TabIndex = 30;
            // 
            // intimidationRatingLabel
            // 
            this.intimidationRatingLabel.AutoSize = true;
            this.intimidationRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intimidationRatingLabel.Location = new System.Drawing.Point(238, 192);
            this.intimidationRatingLabel.Name = "intimidationRatingLabel";
            this.intimidationRatingLabel.Size = new System.Drawing.Size(48, 13);
            this.intimidationRatingLabel.TabIndex = 29;
            this.intimidationRatingLabel.Text = "label13";
            // 
            // skillIntimidation
            // 
            this.skillIntimidation.Location = new System.Drawing.Point(187, 190);
            this.skillIntimidation.Name = "skillIntimidation";
            this.skillIntimidation.ReadOnly = true;
            this.skillIntimidation.Size = new System.Drawing.Size(45, 20);
            this.skillIntimidation.TabIndex = 28;
            this.skillIntimidation.ValueChanged += new System.EventHandler(this.skillIntimidation_ValueChanged);
            // 
            // intimidationLabel
            // 
            this.intimidationLabel.AutoSize = true;
            this.intimidationLabel.Location = new System.Drawing.Point(1, 192);
            this.intimidationLabel.Name = "intimidationLabel";
            this.intimidationLabel.Size = new System.Drawing.Size(115, 13);
            this.intimidationLabel.TabIndex = 27;
            this.intimidationLabel.Text = "Intimidation (Willpower)";
            // 
            // investigationBonusBox
            // 
            this.investigationBonusBox.Location = new System.Drawing.Point(295, 215);
            this.investigationBonusBox.Name = "investigationBonusBox";
            this.investigationBonusBox.Size = new System.Drawing.Size(511, 20);
            this.investigationBonusBox.TabIndex = 34;
            // 
            // investigationRatingLabel
            // 
            this.investigationRatingLabel.AutoSize = true;
            this.investigationRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.investigationRatingLabel.Location = new System.Drawing.Point(238, 218);
            this.investigationRatingLabel.Name = "investigationRatingLabel";
            this.investigationRatingLabel.Size = new System.Drawing.Size(48, 13);
            this.investigationRatingLabel.TabIndex = 33;
            this.investigationRatingLabel.Text = "label15";
            // 
            // skillInvestigation
            // 
            this.skillInvestigation.Location = new System.Drawing.Point(187, 216);
            this.skillInvestigation.Name = "skillInvestigation";
            this.skillInvestigation.ReadOnly = true;
            this.skillInvestigation.Size = new System.Drawing.Size(45, 20);
            this.skillInvestigation.TabIndex = 32;
            this.skillInvestigation.ValueChanged += new System.EventHandler(this.skillInvestigation_ValueChanged);
            // 
            // investigationLabel
            // 
            this.investigationLabel.AutoSize = true;
            this.investigationLabel.Location = new System.Drawing.Point(1, 218);
            this.investigationLabel.Name = "investigationLabel";
            this.investigationLabel.Size = new System.Drawing.Size(113, 13);
            this.investigationLabel.TabIndex = 31;
            this.investigationLabel.Text = "Investigation (Intellect)";
            // 
            // leadershipBonusBox
            // 
            this.leadershipBonusBox.Location = new System.Drawing.Point(295, 241);
            this.leadershipBonusBox.Name = "leadershipBonusBox";
            this.leadershipBonusBox.Size = new System.Drawing.Size(511, 20);
            this.leadershipBonusBox.TabIndex = 38;
            // 
            // leadershipRatingLabel
            // 
            this.leadershipRatingLabel.AutoSize = true;
            this.leadershipRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leadershipRatingLabel.Location = new System.Drawing.Point(238, 244);
            this.leadershipRatingLabel.Name = "leadershipRatingLabel";
            this.leadershipRatingLabel.Size = new System.Drawing.Size(48, 13);
            this.leadershipRatingLabel.TabIndex = 37;
            this.leadershipRatingLabel.Text = "label17";
            // 
            // skillLeadership
            // 
            this.skillLeadership.Location = new System.Drawing.Point(187, 242);
            this.skillLeadership.Name = "skillLeadership";
            this.skillLeadership.ReadOnly = true;
            this.skillLeadership.Size = new System.Drawing.Size(45, 20);
            this.skillLeadership.TabIndex = 36;
            this.skillLeadership.ValueChanged += new System.EventHandler(this.skillLeadership_ValueChanged);
            // 
            // leadershipLabel
            // 
            this.leadershipLabel.AutoSize = true;
            this.leadershipLabel.Location = new System.Drawing.Point(1, 244);
            this.leadershipLabel.Name = "leadershipLabel";
            this.leadershipLabel.Size = new System.Drawing.Size(117, 13);
            this.leadershipLabel.TabIndex = 35;
            this.leadershipLabel.Text = "Leadership (Fellowship)";
            // 
            // medicaeBonusBox
            // 
            this.medicaeBonusBox.Location = new System.Drawing.Point(295, 267);
            this.medicaeBonusBox.Name = "medicaeBonusBox";
            this.medicaeBonusBox.Size = new System.Drawing.Size(511, 20);
            this.medicaeBonusBox.TabIndex = 42;
            // 
            // medicaeRatingLabel
            // 
            this.medicaeRatingLabel.AutoSize = true;
            this.medicaeRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicaeRatingLabel.Location = new System.Drawing.Point(238, 270);
            this.medicaeRatingLabel.Name = "medicaeRatingLabel";
            this.medicaeRatingLabel.Size = new System.Drawing.Size(48, 13);
            this.medicaeRatingLabel.TabIndex = 41;
            this.medicaeRatingLabel.Text = "label19";
            // 
            // skillMedicae
            // 
            this.skillMedicae.Location = new System.Drawing.Point(187, 268);
            this.skillMedicae.Name = "skillMedicae";
            this.skillMedicae.ReadOnly = true;
            this.skillMedicae.Size = new System.Drawing.Size(45, 20);
            this.skillMedicae.TabIndex = 40;
            this.skillMedicae.ValueChanged += new System.EventHandler(this.skillMedicae_ValueChanged);
            // 
            // medicaeLabel
            // 
            this.medicaeLabel.AutoSize = true;
            this.medicaeLabel.Location = new System.Drawing.Point(1, 270);
            this.medicaeLabel.Name = "medicaeLabel";
            this.medicaeLabel.Size = new System.Drawing.Size(94, 13);
            this.medicaeLabel.TabIndex = 39;
            this.medicaeLabel.Text = "Medicae (Intellect)";
            // 
            // persuasionBonusBox
            // 
            this.persuasionBonusBox.Location = new System.Drawing.Point(295, 293);
            this.persuasionBonusBox.Name = "persuasionBonusBox";
            this.persuasionBonusBox.Size = new System.Drawing.Size(511, 20);
            this.persuasionBonusBox.TabIndex = 46;
            // 
            // persuasionRatingLabel
            // 
            this.persuasionRatingLabel.AutoSize = true;
            this.persuasionRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persuasionRatingLabel.Location = new System.Drawing.Point(238, 296);
            this.persuasionRatingLabel.Name = "persuasionRatingLabel";
            this.persuasionRatingLabel.Size = new System.Drawing.Size(48, 13);
            this.persuasionRatingLabel.TabIndex = 45;
            this.persuasionRatingLabel.Text = "label21";
            // 
            // skillPersuasion
            // 
            this.skillPersuasion.Location = new System.Drawing.Point(187, 294);
            this.skillPersuasion.Name = "skillPersuasion";
            this.skillPersuasion.ReadOnly = true;
            this.skillPersuasion.Size = new System.Drawing.Size(45, 20);
            this.skillPersuasion.TabIndex = 44;
            this.skillPersuasion.ValueChanged += new System.EventHandler(this.skillPersuasion_ValueChanged);
            // 
            // persuasionLabel
            // 
            this.persuasionLabel.AutoSize = true;
            this.persuasionLabel.Location = new System.Drawing.Point(1, 296);
            this.persuasionLabel.Name = "persuasionLabel";
            this.persuasionLabel.Size = new System.Drawing.Size(117, 13);
            this.persuasionLabel.TabIndex = 43;
            this.persuasionLabel.Text = "Persuasion (Fellowship)";
            // 
            // pilotBonusBox
            // 
            this.pilotBonusBox.Location = new System.Drawing.Point(295, 319);
            this.pilotBonusBox.Name = "pilotBonusBox";
            this.pilotBonusBox.Size = new System.Drawing.Size(511, 20);
            this.pilotBonusBox.TabIndex = 50;
            // 
            // pilotRatingLabel
            // 
            this.pilotRatingLabel.AutoSize = true;
            this.pilotRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilotRatingLabel.Location = new System.Drawing.Point(238, 322);
            this.pilotRatingLabel.Name = "pilotRatingLabel";
            this.pilotRatingLabel.Size = new System.Drawing.Size(48, 13);
            this.pilotRatingLabel.TabIndex = 49;
            this.pilotRatingLabel.Text = "label23";
            // 
            // skillPilot
            // 
            this.skillPilot.Location = new System.Drawing.Point(187, 320);
            this.skillPilot.Name = "skillPilot";
            this.skillPilot.ReadOnly = true;
            this.skillPilot.Size = new System.Drawing.Size(45, 20);
            this.skillPilot.TabIndex = 48;
            this.skillPilot.ValueChanged += new System.EventHandler(this.skillPilot_ValueChanged);
            // 
            // pilotLabel
            // 
            this.pilotLabel.AutoSize = true;
            this.pilotLabel.Location = new System.Drawing.Point(1, 322);
            this.pilotLabel.Name = "pilotLabel";
            this.pilotLabel.Size = new System.Drawing.Size(63, 13);
            this.pilotLabel.TabIndex = 47;
            this.pilotLabel.Text = "Pilot (Agility)";
            // 
            // psychicBonusBox
            // 
            this.psychicBonusBox.Location = new System.Drawing.Point(295, 345);
            this.psychicBonusBox.Name = "psychicBonusBox";
            this.psychicBonusBox.Size = new System.Drawing.Size(511, 20);
            this.psychicBonusBox.TabIndex = 54;
            // 
            // psychicRatingLabel
            // 
            this.psychicRatingLabel.AutoSize = true;
            this.psychicRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psychicRatingLabel.Location = new System.Drawing.Point(238, 348);
            this.psychicRatingLabel.Name = "psychicRatingLabel";
            this.psychicRatingLabel.Size = new System.Drawing.Size(48, 13);
            this.psychicRatingLabel.TabIndex = 53;
            this.psychicRatingLabel.Text = "label25";
            // 
            // skillPsychic
            // 
            this.skillPsychic.Location = new System.Drawing.Point(187, 346);
            this.skillPsychic.Name = "skillPsychic";
            this.skillPsychic.ReadOnly = true;
            this.skillPsychic.Size = new System.Drawing.Size(45, 20);
            this.skillPsychic.TabIndex = 52;
            this.skillPsychic.ValueChanged += new System.EventHandler(this.skillPsychic_ValueChanged);
            // 
            // psychicLabel
            // 
            this.psychicLabel.AutoSize = true;
            this.psychicLabel.Location = new System.Drawing.Point(1, 348);
            this.psychicLabel.Name = "psychicLabel";
            this.psychicLabel.Size = new System.Drawing.Size(134, 13);
            this.psychicLabel.TabIndex = 51;
            this.psychicLabel.Text = "Psychic Master (Willpower)";
            // 
            // scholarBonusBox
            // 
            this.scholarBonusBox.Location = new System.Drawing.Point(295, 371);
            this.scholarBonusBox.Name = "scholarBonusBox";
            this.scholarBonusBox.Size = new System.Drawing.Size(511, 20);
            this.scholarBonusBox.TabIndex = 58;
            // 
            // scholarRatingLabel
            // 
            this.scholarRatingLabel.AutoSize = true;
            this.scholarRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scholarRatingLabel.Location = new System.Drawing.Point(238, 374);
            this.scholarRatingLabel.Name = "scholarRatingLabel";
            this.scholarRatingLabel.Size = new System.Drawing.Size(48, 13);
            this.scholarRatingLabel.TabIndex = 57;
            this.scholarRatingLabel.Text = "label27";
            // 
            // skillScholar
            // 
            this.skillScholar.Location = new System.Drawing.Point(187, 372);
            this.skillScholar.Name = "skillScholar";
            this.skillScholar.ReadOnly = true;
            this.skillScholar.Size = new System.Drawing.Size(45, 20);
            this.skillScholar.TabIndex = 56;
            this.skillScholar.ValueChanged += new System.EventHandler(this.skillScholar_ValueChanged);
            // 
            // scholarLabel
            // 
            this.scholarLabel.AutoSize = true;
            this.scholarLabel.Location = new System.Drawing.Point(1, 374);
            this.scholarLabel.Name = "scholarLabel";
            this.scholarLabel.Size = new System.Drawing.Size(89, 13);
            this.scholarLabel.TabIndex = 55;
            this.scholarLabel.Text = "Scholar (Intellect)";
            // 
            // stealthBonusBox
            // 
            this.stealthBonusBox.Location = new System.Drawing.Point(295, 397);
            this.stealthBonusBox.Name = "stealthBonusBox";
            this.stealthBonusBox.Size = new System.Drawing.Size(511, 20);
            this.stealthBonusBox.TabIndex = 62;
            // 
            // stealthRatingLabel
            // 
            this.stealthRatingLabel.AutoSize = true;
            this.stealthRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stealthRatingLabel.Location = new System.Drawing.Point(238, 400);
            this.stealthRatingLabel.Name = "stealthRatingLabel";
            this.stealthRatingLabel.Size = new System.Drawing.Size(48, 13);
            this.stealthRatingLabel.TabIndex = 61;
            this.stealthRatingLabel.Text = "label29";
            // 
            // skillStealth
            // 
            this.skillStealth.Location = new System.Drawing.Point(187, 398);
            this.skillStealth.Name = "skillStealth";
            this.skillStealth.ReadOnly = true;
            this.skillStealth.Size = new System.Drawing.Size(45, 20);
            this.skillStealth.TabIndex = 60;
            this.skillStealth.ValueChanged += new System.EventHandler(this.skillStealth_ValueChanged);
            // 
            // stealthLabel
            // 
            this.stealthLabel.AutoSize = true;
            this.stealthLabel.Location = new System.Drawing.Point(1, 400);
            this.stealthLabel.Name = "stealthLabel";
            this.stealthLabel.Size = new System.Drawing.Size(76, 13);
            this.stealthLabel.TabIndex = 59;
            this.stealthLabel.Text = "Stealth (Agility)";
            // 
            // survivalBonusBox
            // 
            this.survivalBonusBox.Location = new System.Drawing.Point(295, 423);
            this.survivalBonusBox.Name = "survivalBonusBox";
            this.survivalBonusBox.Size = new System.Drawing.Size(511, 20);
            this.survivalBonusBox.TabIndex = 66;
            // 
            // survivalRatingLabel
            // 
            this.survivalRatingLabel.AutoSize = true;
            this.survivalRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.survivalRatingLabel.Location = new System.Drawing.Point(238, 426);
            this.survivalRatingLabel.Name = "survivalRatingLabel";
            this.survivalRatingLabel.Size = new System.Drawing.Size(48, 13);
            this.survivalRatingLabel.TabIndex = 65;
            this.survivalRatingLabel.Text = "label31";
            // 
            // skillSurvival
            // 
            this.skillSurvival.Location = new System.Drawing.Point(187, 424);
            this.skillSurvival.Name = "skillSurvival";
            this.skillSurvival.ReadOnly = true;
            this.skillSurvival.Size = new System.Drawing.Size(45, 20);
            this.skillSurvival.TabIndex = 64;
            this.skillSurvival.ValueChanged += new System.EventHandler(this.skillSurvival_ValueChanged);
            // 
            // survivalLabel
            // 
            this.survivalLabel.AutoSize = true;
            this.survivalLabel.Location = new System.Drawing.Point(1, 426);
            this.survivalLabel.Name = "survivalLabel";
            this.survivalLabel.Size = new System.Drawing.Size(100, 13);
            this.survivalLabel.TabIndex = 63;
            this.survivalLabel.Text = "Survival (Willpower)";
            // 
            // techBonusBox
            // 
            this.techBonusBox.Location = new System.Drawing.Point(295, 449);
            this.techBonusBox.Name = "techBonusBox";
            this.techBonusBox.Size = new System.Drawing.Size(511, 20);
            this.techBonusBox.TabIndex = 70;
            // 
            // techRatingLabel
            // 
            this.techRatingLabel.AutoSize = true;
            this.techRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techRatingLabel.Location = new System.Drawing.Point(238, 452);
            this.techRatingLabel.Name = "techRatingLabel";
            this.techRatingLabel.Size = new System.Drawing.Size(48, 13);
            this.techRatingLabel.TabIndex = 69;
            this.techRatingLabel.Text = "label33";
            // 
            // skillTech
            // 
            this.skillTech.Location = new System.Drawing.Point(187, 450);
            this.skillTech.Name = "skillTech";
            this.skillTech.ReadOnly = true;
            this.skillTech.Size = new System.Drawing.Size(45, 20);
            this.skillTech.TabIndex = 68;
            this.skillTech.ValueChanged += new System.EventHandler(this.skillTech_ValueChanged);
            // 
            // techLabel
            // 
            this.techLabel.AutoSize = true;
            this.techLabel.Location = new System.Drawing.Point(1, 452);
            this.techLabel.Name = "techLabel";
            this.techLabel.Size = new System.Drawing.Size(78, 13);
            this.techLabel.TabIndex = 67;
            this.techLabel.Text = "Tech (Intellect)";
            // 
            // weaponSkillBonusBox
            // 
            this.weaponSkillBonusBox.Location = new System.Drawing.Point(295, 475);
            this.weaponSkillBonusBox.Name = "weaponSkillBonusBox";
            this.weaponSkillBonusBox.Size = new System.Drawing.Size(511, 20);
            this.weaponSkillBonusBox.TabIndex = 74;
            // 
            // weaponSkillRatingLabel
            // 
            this.weaponSkillRatingLabel.AutoSize = true;
            this.weaponSkillRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponSkillRatingLabel.Location = new System.Drawing.Point(238, 478);
            this.weaponSkillRatingLabel.Name = "weaponSkillRatingLabel";
            this.weaponSkillRatingLabel.Size = new System.Drawing.Size(48, 13);
            this.weaponSkillRatingLabel.TabIndex = 73;
            this.weaponSkillRatingLabel.Text = "label35";
            // 
            // skillWeaponSkill
            // 
            this.skillWeaponSkill.Location = new System.Drawing.Point(187, 476);
            this.skillWeaponSkill.Name = "skillWeaponSkill";
            this.skillWeaponSkill.ReadOnly = true;
            this.skillWeaponSkill.Size = new System.Drawing.Size(45, 20);
            this.skillWeaponSkill.TabIndex = 72;
            this.skillWeaponSkill.ValueChanged += new System.EventHandler(this.skillWeaponSkill_ValueChanged);
            // 
            // weaponSkillLabel
            // 
            this.weaponSkillLabel.AutoSize = true;
            this.weaponSkillLabel.Location = new System.Drawing.Point(1, 478);
            this.weaponSkillLabel.Name = "weaponSkillLabel";
            this.weaponSkillLabel.Size = new System.Drawing.Size(118, 13);
            this.weaponSkillLabel.TabIndex = 71;
            this.weaponSkillLabel.Text = "Weapon Skill (Initiative)";
            // 
            // bpSpentAttribLabel
            // 
            this.bpSpentAttribLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.bpSpentAttribLabel.Name = "bpSpentAttribLabel";
            this.bpSpentAttribLabel.Size = new System.Drawing.Size(133, 19);
            this.bpSpentAttribLabel.Text = "BP Spent on Attributes:";
            // 
            // bpSpentSkillsLabel
            // 
            this.bpSpentSkillsLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.bpSpentSkillsLabel.Name = "bpSpentSkillsLabel";
            this.bpSpentSkillsLabel.Size = new System.Drawing.Size(107, 19);
            this.bpSpentSkillsLabel.Text = "BP Spent on Skills:";
            // 
            // bpSpentRaceLabel
            // 
            this.bpSpentRaceLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.bpSpentRaceLabel.Name = "bpSpentRaceLabel";
            this.bpSpentRaceLabel.Size = new System.Drawing.Size(106, 19);
            this.bpSpentRaceLabel.Text = "BP Spent on Race:";
            // 
            // bpSpentArchetypeLabel
            // 
            this.bpSpentArchetypeLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.bpSpentArchetypeLabel.Name = "bpSpentArchetypeLabel";
            this.bpSpentArchetypeLabel.Size = new System.Drawing.Size(135, 19);
            this.bpSpentArchetypeLabel.Text = "BP Spent on Archetype:";
            // 
            // equipment
            // 
            this.equipment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.equipment.Controls.Add(this.equipmentTextBox);
            this.equipment.Location = new System.Drawing.Point(4, 22);
            this.equipment.Name = "equipment";
            this.equipment.Padding = new System.Windows.Forms.Padding(3);
            this.equipment.Size = new System.Drawing.Size(826, 509);
            this.equipment.TabIndex = 2;
            this.equipment.Text = "Equipment";
            // 
            // psychicpowers
            // 
            this.psychicpowers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.psychicpowers.Controls.Add(this.powersTextBox);
            this.psychicpowers.Location = new System.Drawing.Point(4, 22);
            this.psychicpowers.Name = "psychicpowers";
            this.psychicpowers.Padding = new System.Windows.Forms.Padding(3);
            this.psychicpowers.Size = new System.Drawing.Size(826, 509);
            this.psychicpowers.TabIndex = 3;
            this.psychicpowers.Text = "Psychic Powers";
            // 
            // notes
            // 
            this.notes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notes.Controls.Add(this.notesTextBox);
            this.notes.Location = new System.Drawing.Point(4, 22);
            this.notes.Name = "notes";
            this.notes.Padding = new System.Windows.Forms.Padding(3);
            this.notes.Size = new System.Drawing.Size(826, 509);
            this.notes.TabIndex = 4;
            this.notes.Text = "Notes";
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(0, 0);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(827, 506);
            this.notesTextBox.TabIndex = 0;
            this.notesTextBox.Text = "";
            // 
            // addBPButton
            // 
            this.addBPButton.Location = new System.Drawing.Point(35, 360);
            this.addBPButton.Name = "addBPButton";
            this.addBPButton.Size = new System.Drawing.Size(169, 49);
            this.addBPButton.TabIndex = 41;
            this.addBPButton.Text = "Add BP";
            this.addBPButton.UseVisualStyleBackColor = true;
            this.addBPButton.Click += new System.EventHandler(this.addBPButton_Click);
            // 
            // removeBPButton
            // 
            this.removeBPButton.Location = new System.Drawing.Point(35, 430);
            this.removeBPButton.Name = "removeBPButton";
            this.removeBPButton.Size = new System.Drawing.Size(169, 49);
            this.removeBPButton.TabIndex = 42;
            this.removeBPButton.Text = "Remove BP";
            this.removeBPButton.UseVisualStyleBackColor = true;
            this.removeBPButton.Click += new System.EventHandler(this.removeBPButton_Click);
            // 
            // equipmentTextBox
            // 
            this.equipmentTextBox.Location = new System.Drawing.Point(0, 0);
            this.equipmentTextBox.Name = "equipmentTextBox";
            this.equipmentTextBox.Size = new System.Drawing.Size(827, 510);
            this.equipmentTextBox.TabIndex = 0;
            this.equipmentTextBox.Text = "";
            // 
            // powersTextBox
            // 
            this.powersTextBox.Location = new System.Drawing.Point(0, 0);
            this.powersTextBox.Name = "powersTextBox";
            this.powersTextBox.Size = new System.Drawing.Size(827, 513);
            this.powersTextBox.TabIndex = 0;
            this.powersTextBox.Text = "";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1288, 585);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "The Commissar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.core.ResumeLayout(false);
            this.core.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.attSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attInitiative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attFellowship)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attWillpower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attIntellect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attToughness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attAgility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attStrength)).EndInit();
            this.skills.ResumeLayout(false);
            this.skills.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skillAthletics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillAwareness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillBallstic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillCunning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillDeception)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillInsight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillIntimidation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillInvestigation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillLeadership)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillMedicae)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillPersuasion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillPilot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillPsychic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillScholar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillStealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillSurvival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillTech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillWeaponSkill)).EndInit();
            this.equipment.ResumeLayout(false);
            this.psychicpowers.ResumeLayout(false);
            this.notes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel buildPointsLabel;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage core;
        private System.Windows.Forms.TabPage skills;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage summary;
        private System.Windows.Forms.NumericUpDown attSpeed;
        private System.Windows.Forms.NumericUpDown attInitiative;
        private System.Windows.Forms.NumericUpDown attFellowship;
        private System.Windows.Forms.NumericUpDown attWillpower;
        private System.Windows.Forms.NumericUpDown attIntellect;
        private System.Windows.Forms.NumericUpDown attToughness;
        private System.Windows.Forms.NumericUpDown attAgility;
        private System.Windows.Forms.NumericUpDown attStrength;
        private System.Windows.Forms.Label attSpeedLabel;
        private System.Windows.Forms.Label attInitiativeLabel;
        private System.Windows.Forms.Label attFellowshipLabel;
        private System.Windows.Forms.Label attWillpowerLabel;
        private System.Windows.Forms.Label attIntellectLabel;
        private System.Windows.Forms.Label attToughnessLabel;
        private System.Windows.Forms.Label attAgilityLabel;
        private System.Windows.Forms.Label attStrengthLabel;
        private System.Windows.Forms.Label attributesLabel;
        private System.Windows.Forms.Label archetypeSelectLabel;
        private System.Windows.Forms.Label speciesSelectLabel;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.Label attSpeedTotal;
        private System.Windows.Forms.Label attInitiativeTotal;
        private System.Windows.Forms.Label attFellowshipTotal;
        private System.Windows.Forms.Label attWillpowerTotal;
        private System.Windows.Forms.Label attIntellectTotal;
        private System.Windows.Forms.Label attToughnessTotal;
        private System.Windows.Forms.Label attAgilityTotal;
        private System.Windows.Forms.Label attStrengthTotal;
        private System.Windows.Forms.Label tierLabel;
        private System.Windows.Forms.ComboBox archetypeSelect;
        private System.Windows.Forms.ComboBox speciesSelect;
        private System.Windows.Forms.ComboBox tierSelect;
        private System.Windows.Forms.ListBox talentBox;
        private System.Windows.Forms.Label talentLabel;
        private System.Windows.Forms.Button removeTalentBtn;
        private System.Windows.Forms.Button addTalentBtn;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox weaponSkillBonusBox;
        private System.Windows.Forms.Label weaponSkillRatingLabel;
        private System.Windows.Forms.NumericUpDown skillWeaponSkill;
        private System.Windows.Forms.Label weaponSkillLabel;
        private System.Windows.Forms.TextBox techBonusBox;
        private System.Windows.Forms.Label techRatingLabel;
        private System.Windows.Forms.NumericUpDown skillTech;
        private System.Windows.Forms.Label techLabel;
        private System.Windows.Forms.TextBox survivalBonusBox;
        private System.Windows.Forms.Label survivalRatingLabel;
        private System.Windows.Forms.NumericUpDown skillSurvival;
        private System.Windows.Forms.Label survivalLabel;
        private System.Windows.Forms.TextBox stealthBonusBox;
        private System.Windows.Forms.Label stealthRatingLabel;
        private System.Windows.Forms.NumericUpDown skillStealth;
        private System.Windows.Forms.Label stealthLabel;
        private System.Windows.Forms.TextBox scholarBonusBox;
        private System.Windows.Forms.Label scholarRatingLabel;
        private System.Windows.Forms.NumericUpDown skillScholar;
        private System.Windows.Forms.Label scholarLabel;
        private System.Windows.Forms.TextBox psychicBonusBox;
        private System.Windows.Forms.Label psychicRatingLabel;
        private System.Windows.Forms.NumericUpDown skillPsychic;
        private System.Windows.Forms.Label psychicLabel;
        private System.Windows.Forms.TextBox pilotBonusBox;
        private System.Windows.Forms.Label pilotRatingLabel;
        private System.Windows.Forms.NumericUpDown skillPilot;
        private System.Windows.Forms.Label pilotLabel;
        private System.Windows.Forms.TextBox persuasionBonusBox;
        private System.Windows.Forms.Label persuasionRatingLabel;
        private System.Windows.Forms.NumericUpDown skillPersuasion;
        private System.Windows.Forms.Label persuasionLabel;
        private System.Windows.Forms.TextBox medicaeBonusBox;
        private System.Windows.Forms.Label medicaeRatingLabel;
        private System.Windows.Forms.NumericUpDown skillMedicae;
        private System.Windows.Forms.Label medicaeLabel;
        private System.Windows.Forms.TextBox leadershipBonusBox;
        private System.Windows.Forms.Label leadershipRatingLabel;
        private System.Windows.Forms.NumericUpDown skillLeadership;
        private System.Windows.Forms.Label leadershipLabel;
        private System.Windows.Forms.TextBox investigationBonusBox;
        private System.Windows.Forms.Label investigationRatingLabel;
        private System.Windows.Forms.NumericUpDown skillInvestigation;
        private System.Windows.Forms.Label investigationLabel;
        private System.Windows.Forms.TextBox intimidationBonusBox;
        private System.Windows.Forms.Label intimidationRatingLabel;
        private System.Windows.Forms.NumericUpDown skillIntimidation;
        private System.Windows.Forms.Label intimidationLabel;
        private System.Windows.Forms.TextBox insightBonusBox;
        private System.Windows.Forms.Label insightRatingLabel;
        private System.Windows.Forms.NumericUpDown skillInsight;
        private System.Windows.Forms.Label insightLabel;
        private System.Windows.Forms.TextBox deceptionBonusBox;
        private System.Windows.Forms.Label deceptionRatingLabel;
        private System.Windows.Forms.NumericUpDown skillDeception;
        private System.Windows.Forms.Label deceptionLabel;
        private System.Windows.Forms.TextBox cunningBonusBox;
        private System.Windows.Forms.Label cunningRatingLabel;
        private System.Windows.Forms.NumericUpDown skillCunning;
        private System.Windows.Forms.Label cunningLabel;
        private System.Windows.Forms.TextBox ballisticBonusBox;
        private System.Windows.Forms.Label ballisticRatingLabel;
        private System.Windows.Forms.NumericUpDown skillBallstic;
        private System.Windows.Forms.Label ballisticLabel;
        private System.Windows.Forms.TextBox awarenessBonusBox;
        private System.Windows.Forms.Label awarenessRatingLabel;
        private System.Windows.Forms.NumericUpDown skillAwareness;
        private System.Windows.Forms.Label awarenessLabel;
        private System.Windows.Forms.Label skillBonusLabel;
        private System.Windows.Forms.Label skillRatingLabel;
        private System.Windows.Forms.TextBox athleticsBonusBox;
        private System.Windows.Forms.Label athleticsRatingLabel;
        private System.Windows.Forms.Label skillLabel;
        private System.Windows.Forms.NumericUpDown skillAthletics;
        private System.Windows.Forms.Label athleticsLabel;
        private System.Windows.Forms.ToolStripStatusLabel bpSpentAttribLabel;
        private System.Windows.Forms.ToolStripStatusLabel bpSpentSkillsLabel;
        private System.Windows.Forms.ToolStripStatusLabel bpSpentRaceLabel;
        private System.Windows.Forms.ToolStripStatusLabel bpSpentArchetypeLabel;
        private System.Windows.Forms.TabPage equipment;
        private System.Windows.Forms.TabPage psychicpowers;
        private System.Windows.Forms.TabPage notes;
        private System.Windows.Forms.Button removeBPButton;
        private System.Windows.Forms.Button addBPButton;
        private System.Windows.Forms.RichTextBox notesTextBox;
        private System.Windows.Forms.RichTextBox equipmentTextBox;
        private System.Windows.Forms.RichTextBox powersTextBox;
    }
}

