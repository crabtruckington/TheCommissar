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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Ranged Weapons");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Melee Weapons");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Armor");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Ammo and Tools");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCharacterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkCharacterValidityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.buildPointsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.bpSpentAttribLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.bpSpentSkillsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.bpSpentRaceLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.bpSpentArchetypeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.bpSpentOnPowersLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.core = new System.Windows.Forms.TabPage();
            this.archInfoLabel = new System.Windows.Forms.Label();
            this.archetypeInfoHeaderLabel = new System.Windows.Forms.Label();
            this.shockValueBox = new System.Windows.Forms.NumericUpDown();
            this.shockBonusLabel = new System.Windows.Forms.Label();
            this.woundsValueBox = new System.Windows.Forms.NumericUpDown();
            this.woundsBonusLabel = new System.Windows.Forms.Label();
            this.rankAndBonusLabel = new System.Windows.Forms.Label();
            this.influenceValueBox = new System.Windows.Forms.NumericUpDown();
            this.resolveValueBox = new System.Windows.Forms.NumericUpDown();
            this.influenceBonusLabel = new System.Windows.Forms.Label();
            this.resolveBonusLabel = new System.Windows.Forms.Label();
            this.passiveAwarenessValueBox = new System.Windows.Forms.NumericUpDown();
            this.passiveAwarenessBonusLabel = new System.Windows.Forms.Label();
            this.convictionValueBox = new System.Windows.Forms.NumericUpDown();
            this.convictionBonusLabel = new System.Windows.Forms.Label();
            this.resilienceValueBox = new System.Windows.Forms.NumericUpDown();
            this.soakValueBox = new System.Windows.Forms.NumericUpDown();
            this.resilienceBonusLabel = new System.Windows.Forms.Label();
            this.soakBonusLabel = new System.Windows.Forms.Label();
            this.defenceValueBox = new System.Windows.Forms.NumericUpDown();
            this.defenceBonusLabel = new System.Windows.Forms.Label();
            this.attSpeedModifier = new System.Windows.Forms.NumericUpDown();
            this.attInitiativeModifier = new System.Windows.Forms.NumericUpDown();
            this.attFellowshipModifier = new System.Windows.Forms.NumericUpDown();
            this.attWillpowerModifier = new System.Windows.Forms.NumericUpDown();
            this.attIntellectModifier = new System.Windows.Forms.NumericUpDown();
            this.attToughnessModifier = new System.Windows.Forms.NumericUpDown();
            this.attAgilityModifier = new System.Windows.Forms.NumericUpDown();
            this.attStrengthModifier = new System.Windows.Forms.NumericUpDown();
            this.attModiferLabel = new System.Windows.Forms.Label();
            this.corruptionValueBox = new System.Windows.Forms.NumericUpDown();
            this.corruptionValueLabel = new System.Windows.Forms.Label();
            this.wealthValueBox = new System.Windows.Forms.NumericUpDown();
            this.rankValueBox = new System.Windows.Forms.NumericUpDown();
            this.wealthValueLabel = new System.Windows.Forms.Label();
            this.rankValueLabel = new System.Windows.Forms.Label();
            this.removeBPButton = new System.Windows.Forms.Button();
            this.addBPButton = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.skillWeaponSkillBonus = new System.Windows.Forms.NumericUpDown();
            this.skillTechBonus = new System.Windows.Forms.NumericUpDown();
            this.skillSurvivalBonus = new System.Windows.Forms.NumericUpDown();
            this.skillStealthBonus = new System.Windows.Forms.NumericUpDown();
            this.skillScholarBonus = new System.Windows.Forms.NumericUpDown();
            this.skillPsychicBonus = new System.Windows.Forms.NumericUpDown();
            this.skillPilotBonus = new System.Windows.Forms.NumericUpDown();
            this.skillPersuasionBonus = new System.Windows.Forms.NumericUpDown();
            this.skillMedicaeBonus = new System.Windows.Forms.NumericUpDown();
            this.skillLeadershipBonus = new System.Windows.Forms.NumericUpDown();
            this.skillInvestigationBonus = new System.Windows.Forms.NumericUpDown();
            this.skillIntimidationBonus = new System.Windows.Forms.NumericUpDown();
            this.skillInsightBonus = new System.Windows.Forms.NumericUpDown();
            this.skillDeceptionBonus = new System.Windows.Forms.NumericUpDown();
            this.skillCunningBonus = new System.Windows.Forms.NumericUpDown();
            this.skillBallisticBonus = new System.Windows.Forms.NumericUpDown();
            this.skillAwarenessBonus = new System.Windows.Forms.NumericUpDown();
            this.skillAthleticsBonus = new System.Windows.Forms.NumericUpDown();
            this.weaponSkillBonusBox = new System.Windows.Forms.TextBox();
            this.weaponSkillRatingLabel = new System.Windows.Forms.Label();
            this.skillWeaponSkill = new System.Windows.Forms.NumericUpDown();
            this.weaponSkillLabel = new System.Windows.Forms.Label();
            this.techBonusBox = new System.Windows.Forms.TextBox();
            this.techRatingLabel = new System.Windows.Forms.Label();
            this.skillTech = new System.Windows.Forms.NumericUpDown();
            this.techLabel = new System.Windows.Forms.Label();
            this.survivalBonusBox = new System.Windows.Forms.TextBox();
            this.survivalRatingLabel = new System.Windows.Forms.Label();
            this.skillSurvival = new System.Windows.Forms.NumericUpDown();
            this.survivalLabel = new System.Windows.Forms.Label();
            this.stealthBonusBox = new System.Windows.Forms.TextBox();
            this.stealthRatingLabel = new System.Windows.Forms.Label();
            this.skillStealth = new System.Windows.Forms.NumericUpDown();
            this.stealthLabel = new System.Windows.Forms.Label();
            this.scholarBonusBox = new System.Windows.Forms.TextBox();
            this.scholarRatingLabel = new System.Windows.Forms.Label();
            this.skillScholar = new System.Windows.Forms.NumericUpDown();
            this.scholarLabel = new System.Windows.Forms.Label();
            this.psychicBonusBox = new System.Windows.Forms.TextBox();
            this.psychicRatingLabel = new System.Windows.Forms.Label();
            this.skillPsychic = new System.Windows.Forms.NumericUpDown();
            this.psychicLabel = new System.Windows.Forms.Label();
            this.pilotBonusBox = new System.Windows.Forms.TextBox();
            this.pilotRatingLabel = new System.Windows.Forms.Label();
            this.skillPilot = new System.Windows.Forms.NumericUpDown();
            this.pilotLabel = new System.Windows.Forms.Label();
            this.persuasionBonusBox = new System.Windows.Forms.TextBox();
            this.persuasionRatingLabel = new System.Windows.Forms.Label();
            this.skillPersuasion = new System.Windows.Forms.NumericUpDown();
            this.persuasionLabel = new System.Windows.Forms.Label();
            this.medicaeBonusBox = new System.Windows.Forms.TextBox();
            this.medicaeRatingLabel = new System.Windows.Forms.Label();
            this.skillMedicae = new System.Windows.Forms.NumericUpDown();
            this.medicaeLabel = new System.Windows.Forms.Label();
            this.leadershipBonusBox = new System.Windows.Forms.TextBox();
            this.leadershipRatingLabel = new System.Windows.Forms.Label();
            this.skillLeadership = new System.Windows.Forms.NumericUpDown();
            this.leadershipLabel = new System.Windows.Forms.Label();
            this.investigationBonusBox = new System.Windows.Forms.TextBox();
            this.investigationRatingLabel = new System.Windows.Forms.Label();
            this.skillInvestigation = new System.Windows.Forms.NumericUpDown();
            this.investigationLabel = new System.Windows.Forms.Label();
            this.intimidationBonusBox = new System.Windows.Forms.TextBox();
            this.intimidationRatingLabel = new System.Windows.Forms.Label();
            this.skillIntimidation = new System.Windows.Forms.NumericUpDown();
            this.intimidationLabel = new System.Windows.Forms.Label();
            this.insightBonusBox = new System.Windows.Forms.TextBox();
            this.insightRatingLabel = new System.Windows.Forms.Label();
            this.skillInsight = new System.Windows.Forms.NumericUpDown();
            this.insightLabel = new System.Windows.Forms.Label();
            this.deceptionBonusBox = new System.Windows.Forms.TextBox();
            this.deceptionRatingLabel = new System.Windows.Forms.Label();
            this.skillDeception = new System.Windows.Forms.NumericUpDown();
            this.deceptionLabel = new System.Windows.Forms.Label();
            this.cunningBonusBox = new System.Windows.Forms.TextBox();
            this.cunningRatingLabel = new System.Windows.Forms.Label();
            this.skillCunning = new System.Windows.Forms.NumericUpDown();
            this.cunningLabel = new System.Windows.Forms.Label();
            this.ballisticBonusBox = new System.Windows.Forms.TextBox();
            this.ballisticRatingLabel = new System.Windows.Forms.Label();
            this.skillBallstic = new System.Windows.Forms.NumericUpDown();
            this.ballisticLabel = new System.Windows.Forms.Label();
            this.awarenessBonusBox = new System.Windows.Forms.TextBox();
            this.awarenessRatingLabel = new System.Windows.Forms.Label();
            this.skillAwareness = new System.Windows.Forms.NumericUpDown();
            this.awarenessLabel = new System.Windows.Forms.Label();
            this.skillNotesLabel = new System.Windows.Forms.Label();
            this.skillRatingLabel = new System.Windows.Forms.Label();
            this.athleticsBonusBox = new System.Windows.Forms.TextBox();
            this.athleticsRatingLabel = new System.Windows.Forms.Label();
            this.skillLabel = new System.Windows.Forms.Label();
            this.skillAthletics = new System.Windows.Forms.NumericUpDown();
            this.athleticsLabel = new System.Windows.Forms.Label();
            this.equipment = new System.Windows.Forms.TabPage();
            this.equipTreeBox = new System.Windows.Forms.TreeView();
            this.equipDamageLabel = new System.Windows.Forms.Label();
            this.equipArmorRatingLabel = new System.Windows.Forms.Label();
            this.equipKeywordsLabel = new System.Windows.Forms.Label();
            this.equipValueLabel = new System.Windows.Forms.Label();
            this.equipTraitsLabel = new System.Windows.Forms.Label();
            this.equipSalvoLabel = new System.Windows.Forms.Label();
            this.equipRangeLabel = new System.Windows.Forms.Label();
            this.equipAPLabel = new System.Windows.Forms.Label();
            this.removeEquipButton = new System.Windows.Forms.Button();
            this.addEquipButton = new System.Windows.Forms.Button();
            this.equipmentLabel = new System.Windows.Forms.Label();
            this.miscEquipmentHeaderLabel = new System.Windows.Forms.Label();
            this.equipmentTextBox = new System.Windows.Forms.RichTextBox();
            this.cyberAndAugments = new System.Windows.Forms.TabPage();
            this.augDetailsLabel = new System.Windows.Forms.Label();
            this.augRaceLabel = new System.Windows.Forms.Label();
            this.augHeaderLabel = new System.Windows.Forms.Label();
            this.removeAugButton = new System.Windows.Forms.Button();
            this.addAugButton = new System.Windows.Forms.Button();
            this.augmeticsBox = new System.Windows.Forms.ListBox();
            this.augmeticHeaderLabel = new System.Windows.Forms.Label();
            this.psychicpowers = new System.Windows.Forms.TabPage();
            this.powerDisciplineLabel = new System.Windows.Forms.Label();
            this.powerKeywordsLabel = new System.Windows.Forms.Label();
            this.powerMultiLabel = new System.Windows.Forms.Label();
            this.powerRangeLabel = new System.Windows.Forms.Label();
            this.powerDurationLabel = new System.Windows.Forms.Label();
            this.powerActivationLabel = new System.Windows.Forms.Label();
            this.powerDNLabel = new System.Windows.Forms.Label();
            this.powerBPCostLabel = new System.Windows.Forms.Label();
            this.removePowerButton = new System.Windows.Forms.Button();
            this.addPowerButton = new System.Windows.Forms.Button();
            this.powerBox = new System.Windows.Forms.ListBox();
            this.psychicPowersLabel = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.powersTextBox = new System.Windows.Forms.RichTextBox();
            this.notes = new System.Windows.Forms.TabPage();
            this.notesTextBox = new System.Windows.Forms.RichTextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.summary = new System.Windows.Forms.TabPage();
            this.objectiveLabel = new System.Windows.Forms.Label();
            this.lifetimeBPEarnedLabel = new System.Windows.Forms.Label();
            this.rankTraitLabel = new System.Windows.Forms.Label();
            this.woundsTotalLabel = new System.Windows.Forms.Label();
            this.shockTotalLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.damageTrackLabel = new System.Windows.Forms.Label();
            this.socialTraitsLabel = new System.Windows.Forms.Label();
            this.mentalTraitsLabel = new System.Windows.Forms.Label();
            this.combatTraitsLabel = new System.Windows.Forms.Label();
            this.wealthTraitLabel = new System.Windows.Forms.Label();
            this.resolveTraitLabel = new System.Windows.Forms.Label();
            this.corruptionTraitLabel = new System.Windows.Forms.Label();
            this.woundsTraitLabel = new System.Windows.Forms.Label();
            this.shockTraitLabel = new System.Windows.Forms.Label();
            this.soakTraitLabel = new System.Windows.Forms.Label();
            this.influenceTraitLabel = new System.Windows.Forms.Label();
            this.passiveAwarenessTraitLabel = new System.Windows.Forms.Label();
            this.convictionTraitLabel = new System.Windows.Forms.Label();
            this.speedTraitLabel = new System.Windows.Forms.Label();
            this.resilienceTraitLabel = new System.Windows.Forms.Label();
            this.defenceTraitLabel = new System.Windows.Forms.Label();
            this.traitsLabel = new System.Windows.Forms.Label();
            this.calcValuesToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.equipModMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.core.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shockValueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woundsValueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.influenceValueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolveValueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passiveAwarenessValueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.convictionValueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resilienceValueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soakValueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defenceValueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attSpeedModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attInitiativeModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attFellowshipModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attWillpowerModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attIntellectModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attToughnessModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attAgilityModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attStrengthModifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corruptionValueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wealthValueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankValueBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attInitiative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attFellowship)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attWillpower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attIntellect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attToughness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attAgility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attStrength)).BeginInit();
            this.skills.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skillWeaponSkillBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillTechBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillSurvivalBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillStealthBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillScholarBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillPsychicBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillPilotBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillPersuasionBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillMedicaeBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillLeadershipBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillInvestigationBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillIntimidationBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillInsightBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillDeceptionBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillCunningBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillBallisticBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillAwarenessBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillAthleticsBonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillWeaponSkill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillTech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillSurvival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillStealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillScholar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillPsychic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillPilot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillPersuasion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillMedicae)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillLeadership)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillInvestigation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillIntimidation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillInsight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillDeception)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillCunning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillBallstic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillAwareness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillAthletics)).BeginInit();
            this.equipment.SuspendLayout();
            this.cyberAndAugments.SuspendLayout();
            this.psychicpowers.SuspendLayout();
            this.notes.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.summary.SuspendLayout();
            this.equipModMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1186, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newCharacterToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newCharacterToolStripMenuItem
            // 
            this.newCharacterToolStripMenuItem.Name = "newCharacterToolStripMenuItem";
            this.newCharacterToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newCharacterToolStripMenuItem.Text = "New";
            this.newCharacterToolStripMenuItem.Click += new System.EventHandler(this.newCharacterToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(100, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.checkCharacterValidityToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.optionsToolStripMenuItem.Text = "Options (Placeholder)";
            // 
            // checkCharacterValidityToolStripMenuItem
            // 
            this.checkCharacterValidityToolStripMenuItem.Name = "checkCharacterValidityToolStripMenuItem";
            this.checkCharacterValidityToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.checkCharacterValidityToolStripMenuItem.Text = "Check Character Validity";
            this.checkCharacterValidityToolStripMenuItem.Click += new System.EventHandler(this.checkCharacterValidityToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buildPointsLabel,
            this.bpSpentAttribLabel,
            this.bpSpentSkillsLabel,
            this.bpSpentRaceLabel,
            this.bpSpentArchetypeLabel,
            this.bpSpentOnPowersLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 561);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1186, 24);
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
            // bpSpentOnPowersLabel
            // 
            this.bpSpentOnPowersLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.bpSpentOnPowersLabel.Name = "bpSpentOnPowersLabel";
            this.bpSpentOnPowersLabel.Size = new System.Drawing.Size(124, 19);
            this.bpSpentOnPowersLabel.Text = "BP Spent On Powers: ";
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
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl2);
            this.splitContainer1.Size = new System.Drawing.Size(1183, 537);
            this.splitContainer1.SplitterDistance = 835;
            this.splitContainer1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.core);
            this.tabControl1.Controls.Add(this.skills);
            this.tabControl1.Controls.Add(this.equipment);
            this.tabControl1.Controls.Add(this.cyberAndAugments);
            this.tabControl1.Controls.Add(this.psychicpowers);
            this.tabControl1.Controls.Add(this.notes);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(833, 535);
            this.tabControl1.TabIndex = 0;
            // 
            // core
            // 
            this.core.AutoScroll = true;
            this.core.BackColor = System.Drawing.Color.WhiteSmoke;
            this.core.Controls.Add(this.archInfoLabel);
            this.core.Controls.Add(this.archetypeInfoHeaderLabel);
            this.core.Controls.Add(this.shockValueBox);
            this.core.Controls.Add(this.shockBonusLabel);
            this.core.Controls.Add(this.woundsValueBox);
            this.core.Controls.Add(this.woundsBonusLabel);
            this.core.Controls.Add(this.rankAndBonusLabel);
            this.core.Controls.Add(this.influenceValueBox);
            this.core.Controls.Add(this.resolveValueBox);
            this.core.Controls.Add(this.influenceBonusLabel);
            this.core.Controls.Add(this.resolveBonusLabel);
            this.core.Controls.Add(this.passiveAwarenessValueBox);
            this.core.Controls.Add(this.passiveAwarenessBonusLabel);
            this.core.Controls.Add(this.convictionValueBox);
            this.core.Controls.Add(this.convictionBonusLabel);
            this.core.Controls.Add(this.resilienceValueBox);
            this.core.Controls.Add(this.soakValueBox);
            this.core.Controls.Add(this.resilienceBonusLabel);
            this.core.Controls.Add(this.soakBonusLabel);
            this.core.Controls.Add(this.defenceValueBox);
            this.core.Controls.Add(this.defenceBonusLabel);
            this.core.Controls.Add(this.attSpeedModifier);
            this.core.Controls.Add(this.attInitiativeModifier);
            this.core.Controls.Add(this.attFellowshipModifier);
            this.core.Controls.Add(this.attWillpowerModifier);
            this.core.Controls.Add(this.attIntellectModifier);
            this.core.Controls.Add(this.attToughnessModifier);
            this.core.Controls.Add(this.attAgilityModifier);
            this.core.Controls.Add(this.attStrengthModifier);
            this.core.Controls.Add(this.attModiferLabel);
            this.core.Controls.Add(this.corruptionValueBox);
            this.core.Controls.Add(this.corruptionValueLabel);
            this.core.Controls.Add(this.wealthValueBox);
            this.core.Controls.Add(this.rankValueBox);
            this.core.Controls.Add(this.wealthValueLabel);
            this.core.Controls.Add(this.rankValueLabel);
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
            this.core.Size = new System.Drawing.Size(825, 509);
            this.core.TabIndex = 0;
            this.core.Text = "Core";
            // 
            // archInfoLabel
            // 
            this.archInfoLabel.Location = new System.Drawing.Point(0, 185);
            this.archInfoLabel.Name = "archInfoLabel";
            this.archInfoLabel.Size = new System.Drawing.Size(245, 245);
            this.archInfoLabel.TabIndex = 4139;
            this.archInfoLabel.Text = "archInfoLabel";
            // 
            // archetypeInfoHeaderLabel
            // 
            this.archetypeInfoHeaderLabel.AutoSize = true;
            this.archetypeInfoHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archetypeInfoHeaderLabel.Location = new System.Drawing.Point(-3, 157);
            this.archetypeInfoHeaderLabel.Name = "archetypeInfoHeaderLabel";
            this.archetypeInfoHeaderLabel.Size = new System.Drawing.Size(94, 13);
            this.archetypeInfoHeaderLabel.TabIndex = 4138;
            this.archetypeInfoHeaderLabel.Text = "Archetype Info:";
            // 
            // shockValueBox
            // 
            this.shockValueBox.Location = new System.Drawing.Point(482, 410);
            this.shockValueBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.shockValueBox.Name = "shockValueBox";
            this.shockValueBox.Size = new System.Drawing.Size(47, 20);
            this.shockValueBox.TabIndex = 16;
            this.shockValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shockValueBox.ValueChanged += new System.EventHandler(this.shockValueBox_ValueChanged);
            // 
            // shockBonusLabel
            // 
            this.shockBonusLabel.AutoSize = true;
            this.shockBonusLabel.Location = new System.Drawing.Point(403, 412);
            this.shockBonusLabel.Name = "shockBonusLabel";
            this.shockBonusLabel.Size = new System.Drawing.Size(38, 13);
            this.shockBonusLabel.TabIndex = 76;
            this.shockBonusLabel.Text = "Shock";
            // 
            // woundsValueBox
            // 
            this.woundsValueBox.Location = new System.Drawing.Point(350, 410);
            this.woundsValueBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.woundsValueBox.Name = "woundsValueBox";
            this.woundsValueBox.Size = new System.Drawing.Size(47, 20);
            this.woundsValueBox.TabIndex = 10;
            this.woundsValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.woundsValueBox.ValueChanged += new System.EventHandler(this.woundsValueBox_ValueChanged);
            // 
            // woundsBonusLabel
            // 
            this.woundsBonusLabel.AutoSize = true;
            this.woundsBonusLabel.Location = new System.Drawing.Point(268, 412);
            this.woundsBonusLabel.Name = "woundsBonusLabel";
            this.woundsBonusLabel.Size = new System.Drawing.Size(47, 13);
            this.woundsBonusLabel.TabIndex = 74;
            this.woundsBonusLabel.Text = "Wounds";
            // 
            // rankAndBonusLabel
            // 
            this.rankAndBonusLabel.AutoSize = true;
            this.rankAndBonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankAndBonusLabel.Location = new System.Drawing.Point(268, 250);
            this.rankAndBonusLabel.Name = "rankAndBonusLabel";
            this.rankAndBonusLabel.Size = new System.Drawing.Size(114, 13);
            this.rankAndBonusLabel.TabIndex = 73;
            this.rankAndBonusLabel.Text = "Rank and Bonuses";
            // 
            // influenceValueBox
            // 
            this.influenceValueBox.Location = new System.Drawing.Point(482, 384);
            this.influenceValueBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.influenceValueBox.Name = "influenceValueBox";
            this.influenceValueBox.Size = new System.Drawing.Size(47, 20);
            this.influenceValueBox.TabIndex = 15;
            this.influenceValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.influenceValueBox.ValueChanged += new System.EventHandler(this.influenceValueBox_ValueChanged_1);
            // 
            // resolveValueBox
            // 
            this.resolveValueBox.Location = new System.Drawing.Point(482, 357);
            this.resolveValueBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.resolveValueBox.Name = "resolveValueBox";
            this.resolveValueBox.Size = new System.Drawing.Size(47, 20);
            this.resolveValueBox.TabIndex = 14;
            this.resolveValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resolveValueBox.ValueChanged += new System.EventHandler(this.resolveValueBox_ValueChanged);
            // 
            // influenceBonusLabel
            // 
            this.influenceBonusLabel.AutoSize = true;
            this.influenceBonusLabel.Location = new System.Drawing.Point(403, 386);
            this.influenceBonusLabel.Name = "influenceBonusLabel";
            this.influenceBonusLabel.Size = new System.Drawing.Size(51, 13);
            this.influenceBonusLabel.TabIndex = 70;
            this.influenceBonusLabel.Text = "Influence";
            // 
            // resolveBonusLabel
            // 
            this.resolveBonusLabel.AutoSize = true;
            this.resolveBonusLabel.Location = new System.Drawing.Point(403, 359);
            this.resolveBonusLabel.Name = "resolveBonusLabel";
            this.resolveBonusLabel.Size = new System.Drawing.Size(46, 13);
            this.resolveBonusLabel.TabIndex = 69;
            this.resolveBonusLabel.Text = "Resolve";
            // 
            // passiveAwarenessValueBox
            // 
            this.passiveAwarenessValueBox.Location = new System.Drawing.Point(482, 330);
            this.passiveAwarenessValueBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.passiveAwarenessValueBox.Name = "passiveAwarenessValueBox";
            this.passiveAwarenessValueBox.Size = new System.Drawing.Size(47, 20);
            this.passiveAwarenessValueBox.TabIndex = 13;
            this.passiveAwarenessValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.passiveAwarenessValueBox.ValueChanged += new System.EventHandler(this.passiveAwarenessValueBox_ValueChanged);
            // 
            // passiveAwarenessBonusLabel
            // 
            this.passiveAwarenessBonusLabel.AutoSize = true;
            this.passiveAwarenessBonusLabel.Location = new System.Drawing.Point(403, 328);
            this.passiveAwarenessBonusLabel.Name = "passiveAwarenessBonusLabel";
            this.passiveAwarenessBonusLabel.Size = new System.Drawing.Size(59, 26);
            this.passiveAwarenessBonusLabel.TabIndex = 67;
            this.passiveAwarenessBonusLabel.Text = "Passive\r\nAwareness\r\n";
            // 
            // convictionValueBox
            // 
            this.convictionValueBox.Location = new System.Drawing.Point(482, 305);
            this.convictionValueBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.convictionValueBox.Name = "convictionValueBox";
            this.convictionValueBox.Size = new System.Drawing.Size(47, 20);
            this.convictionValueBox.TabIndex = 12;
            this.convictionValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.convictionValueBox.ValueChanged += new System.EventHandler(this.convictionValueBox_ValueChanged);
            // 
            // convictionBonusLabel
            // 
            this.convictionBonusLabel.AutoSize = true;
            this.convictionBonusLabel.Location = new System.Drawing.Point(403, 307);
            this.convictionBonusLabel.Name = "convictionBonusLabel";
            this.convictionBonusLabel.Size = new System.Drawing.Size(57, 13);
            this.convictionBonusLabel.TabIndex = 65;
            this.convictionBonusLabel.Text = "Conviction";
            // 
            // resilienceValueBox
            // 
            this.resilienceValueBox.Location = new System.Drawing.Point(482, 279);
            this.resilienceValueBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.resilienceValueBox.Name = "resilienceValueBox";
            this.resilienceValueBox.Size = new System.Drawing.Size(47, 20);
            this.resilienceValueBox.TabIndex = 11;
            this.resilienceValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resilienceValueBox.ValueChanged += new System.EventHandler(this.resilienceValueBox_ValueChanged);
            // 
            // soakValueBox
            // 
            this.soakValueBox.Location = new System.Drawing.Point(350, 384);
            this.soakValueBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.soakValueBox.Name = "soakValueBox";
            this.soakValueBox.Size = new System.Drawing.Size(47, 20);
            this.soakValueBox.TabIndex = 9;
            this.soakValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.soakValueBox.ValueChanged += new System.EventHandler(this.soakValueBox_ValueChanged);
            // 
            // resilienceBonusLabel
            // 
            this.resilienceBonusLabel.AutoSize = true;
            this.resilienceBonusLabel.Location = new System.Drawing.Point(403, 281);
            this.resilienceBonusLabel.Name = "resilienceBonusLabel";
            this.resilienceBonusLabel.Size = new System.Drawing.Size(56, 13);
            this.resilienceBonusLabel.TabIndex = 62;
            this.resilienceBonusLabel.Text = "Resilience";
            // 
            // soakBonusLabel
            // 
            this.soakBonusLabel.AutoSize = true;
            this.soakBonusLabel.Location = new System.Drawing.Point(268, 386);
            this.soakBonusLabel.Name = "soakBonusLabel";
            this.soakBonusLabel.Size = new System.Drawing.Size(32, 13);
            this.soakBonusLabel.TabIndex = 61;
            this.soakBonusLabel.Text = "Soak";
            // 
            // defenceValueBox
            // 
            this.defenceValueBox.Location = new System.Drawing.Point(350, 357);
            this.defenceValueBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.defenceValueBox.Name = "defenceValueBox";
            this.defenceValueBox.Size = new System.Drawing.Size(47, 20);
            this.defenceValueBox.TabIndex = 8;
            this.defenceValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.defenceValueBox.ValueChanged += new System.EventHandler(this.defenceValueBox_ValueChanged);
            // 
            // defenceBonusLabel
            // 
            this.defenceBonusLabel.AutoSize = true;
            this.defenceBonusLabel.Location = new System.Drawing.Point(268, 359);
            this.defenceBonusLabel.Name = "defenceBonusLabel";
            this.defenceBonusLabel.Size = new System.Drawing.Size(48, 13);
            this.defenceBonusLabel.TabIndex = 59;
            this.defenceBonusLabel.Text = "Defence";
            // 
            // attSpeedModifier
            // 
            this.attSpeedModifier.Location = new System.Drawing.Point(438, 213);
            this.attSpeedModifier.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.attSpeedModifier.Name = "attSpeedModifier";
            this.attSpeedModifier.ReadOnly = true;
            this.attSpeedModifier.Size = new System.Drawing.Size(47, 20);
            this.attSpeedModifier.TabIndex = 32;
            this.attSpeedModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attSpeedModifier.ValueChanged += new System.EventHandler(this.attSpeedModifier_ValueChanged);
            // 
            // attInitiativeModifier
            // 
            this.attInitiativeModifier.Location = new System.Drawing.Point(438, 188);
            this.attInitiativeModifier.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.attInitiativeModifier.Name = "attInitiativeModifier";
            this.attInitiativeModifier.ReadOnly = true;
            this.attInitiativeModifier.Size = new System.Drawing.Size(47, 20);
            this.attInitiativeModifier.TabIndex = 30;
            this.attInitiativeModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attInitiativeModifier.ValueChanged += new System.EventHandler(this.attInitiativeModifier_ValueChanged);
            // 
            // attFellowshipModifier
            // 
            this.attFellowshipModifier.Location = new System.Drawing.Point(438, 163);
            this.attFellowshipModifier.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.attFellowshipModifier.Name = "attFellowshipModifier";
            this.attFellowshipModifier.ReadOnly = true;
            this.attFellowshipModifier.Size = new System.Drawing.Size(47, 20);
            this.attFellowshipModifier.TabIndex = 28;
            this.attFellowshipModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attFellowshipModifier.ValueChanged += new System.EventHandler(this.attFellowshipModifier_ValueChanged);
            // 
            // attWillpowerModifier
            // 
            this.attWillpowerModifier.Location = new System.Drawing.Point(438, 138);
            this.attWillpowerModifier.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.attWillpowerModifier.Name = "attWillpowerModifier";
            this.attWillpowerModifier.ReadOnly = true;
            this.attWillpowerModifier.Size = new System.Drawing.Size(47, 20);
            this.attWillpowerModifier.TabIndex = 26;
            this.attWillpowerModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attWillpowerModifier.ValueChanged += new System.EventHandler(this.attWillpowerModifier_ValueChanged);
            // 
            // attIntellectModifier
            // 
            this.attIntellectModifier.Location = new System.Drawing.Point(438, 113);
            this.attIntellectModifier.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.attIntellectModifier.Name = "attIntellectModifier";
            this.attIntellectModifier.ReadOnly = true;
            this.attIntellectModifier.Size = new System.Drawing.Size(47, 20);
            this.attIntellectModifier.TabIndex = 24;
            this.attIntellectModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attIntellectModifier.ValueChanged += new System.EventHandler(this.attIntellectModifier_ValueChanged);
            // 
            // attToughnessModifier
            // 
            this.attToughnessModifier.Location = new System.Drawing.Point(438, 88);
            this.attToughnessModifier.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.attToughnessModifier.Name = "attToughnessModifier";
            this.attToughnessModifier.ReadOnly = true;
            this.attToughnessModifier.Size = new System.Drawing.Size(47, 20);
            this.attToughnessModifier.TabIndex = 22;
            this.attToughnessModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attToughnessModifier.ValueChanged += new System.EventHandler(this.attToughnessModifier_ValueChanged);
            // 
            // attAgilityModifier
            // 
            this.attAgilityModifier.Location = new System.Drawing.Point(438, 63);
            this.attAgilityModifier.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.attAgilityModifier.Name = "attAgilityModifier";
            this.attAgilityModifier.ReadOnly = true;
            this.attAgilityModifier.Size = new System.Drawing.Size(47, 20);
            this.attAgilityModifier.TabIndex = 20;
            this.attAgilityModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attAgilityModifier.ValueChanged += new System.EventHandler(this.attAgilityModifier_ValueChanged);
            // 
            // attStrengthModifier
            // 
            this.attStrengthModifier.Location = new System.Drawing.Point(438, 38);
            this.attStrengthModifier.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.attStrengthModifier.Name = "attStrengthModifier";
            this.attStrengthModifier.ReadOnly = true;
            this.attStrengthModifier.Size = new System.Drawing.Size(47, 20);
            this.attStrengthModifier.TabIndex = 18;
            this.attStrengthModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attStrengthModifier.ValueChanged += new System.EventHandler(this.attStrengthModifier_ValueChanged);
            // 
            // attModiferLabel
            // 
            this.attModiferLabel.AutoSize = true;
            this.attModiferLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attModiferLabel.Location = new System.Drawing.Point(435, 8);
            this.attModiferLabel.Name = "attModiferLabel";
            this.attModiferLabel.Size = new System.Drawing.Size(110, 13);
            this.attModiferLabel.TabIndex = 50;
            this.attModiferLabel.Text = "Attribute Modifiers";
            // 
            // corruptionValueBox
            // 
            this.corruptionValueBox.Location = new System.Drawing.Point(350, 330);
            this.corruptionValueBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.corruptionValueBox.Name = "corruptionValueBox";
            this.corruptionValueBox.Size = new System.Drawing.Size(47, 20);
            this.corruptionValueBox.TabIndex = 7;
            this.corruptionValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.corruptionValueBox.ValueChanged += new System.EventHandler(this.corruptionValueBox_ValueChanged);
            // 
            // corruptionValueLabel
            // 
            this.corruptionValueLabel.AutoSize = true;
            this.corruptionValueLabel.Location = new System.Drawing.Point(268, 332);
            this.corruptionValueLabel.Name = "corruptionValueLabel";
            this.corruptionValueLabel.Size = new System.Drawing.Size(55, 13);
            this.corruptionValueLabel.TabIndex = 48;
            this.corruptionValueLabel.Text = "Corruption";
            // 
            // wealthValueBox
            // 
            this.wealthValueBox.Location = new System.Drawing.Point(350, 305);
            this.wealthValueBox.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.wealthValueBox.Name = "wealthValueBox";
            this.wealthValueBox.Size = new System.Drawing.Size(47, 20);
            this.wealthValueBox.TabIndex = 6;
            this.wealthValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.wealthValueBox.ValueChanged += new System.EventHandler(this.wealthValueBox_ValueChanged);
            // 
            // rankValueBox
            // 
            this.rankValueBox.Location = new System.Drawing.Point(350, 279);
            this.rankValueBox.Name = "rankValueBox";
            this.rankValueBox.Size = new System.Drawing.Size(47, 20);
            this.rankValueBox.TabIndex = 5;
            this.rankValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rankValueBox.ValueChanged += new System.EventHandler(this.rankValueBox_ValueChanged);
            // 
            // wealthValueLabel
            // 
            this.wealthValueLabel.AutoSize = true;
            this.wealthValueLabel.Location = new System.Drawing.Point(268, 307);
            this.wealthValueLabel.Name = "wealthValueLabel";
            this.wealthValueLabel.Size = new System.Drawing.Size(41, 13);
            this.wealthValueLabel.TabIndex = 45;
            this.wealthValueLabel.Text = "Wealth";
            // 
            // rankValueLabel
            // 
            this.rankValueLabel.AutoSize = true;
            this.rankValueLabel.Location = new System.Drawing.Point(268, 281);
            this.rankValueLabel.Name = "rankValueLabel";
            this.rankValueLabel.Size = new System.Drawing.Size(33, 13);
            this.rankValueLabel.TabIndex = 43;
            this.rankValueLabel.Text = "Rank";
            // 
            // removeBPButton
            // 
            this.removeBPButton.Location = new System.Drawing.Point(238, 443);
            this.removeBPButton.Name = "removeBPButton";
            this.removeBPButton.Size = new System.Drawing.Size(169, 49);
            this.removeBPButton.TabIndex = 38;
            this.removeBPButton.Text = "Remove BP";
            this.removeBPButton.UseVisualStyleBackColor = true;
            this.removeBPButton.Click += new System.EventHandler(this.removeBPButton_Click);
            // 
            // addBPButton
            // 
            this.addBPButton.Location = new System.Drawing.Point(35, 443);
            this.addBPButton.Name = "addBPButton";
            this.addBPButton.Size = new System.Drawing.Size(169, 49);
            this.addBPButton.TabIndex = 4137;
            this.addBPButton.Text = "Add BP";
            this.addBPButton.UseVisualStyleBackColor = true;
            this.addBPButton.Click += new System.EventHandler(this.addBPButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(61, 37);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(184, 20);
            this.nameBox.TabIndex = 1;
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
            this.removeTalentBtn.Location = new System.Drawing.Point(696, 360);
            this.removeTalentBtn.Name = "removeTalentBtn";
            this.removeTalentBtn.Size = new System.Drawing.Size(94, 23);
            this.removeTalentBtn.TabIndex = 34;
            this.removeTalentBtn.Text = "Remove Talent";
            this.removeTalentBtn.UseVisualStyleBackColor = true;
            this.removeTalentBtn.Click += new System.EventHandler(this.removeTalentBtn_Click);
            // 
            // addTalentBtn
            // 
            this.addTalentBtn.Location = new System.Drawing.Point(576, 360);
            this.addTalentBtn.Name = "addTalentBtn";
            this.addTalentBtn.Size = new System.Drawing.Size(94, 23);
            this.addTalentBtn.TabIndex = 33;
            this.addTalentBtn.Text = "Add Talent";
            this.addTalentBtn.UseVisualStyleBackColor = true;
            this.addTalentBtn.Click += new System.EventHandler(this.addTalentBtn_Click);
            // 
            // talentBox
            // 
            this.talentBox.FormattingEnabled = true;
            this.talentBox.Location = new System.Drawing.Point(576, 37);
            this.talentBox.Name = "talentBox";
            this.talentBox.Size = new System.Drawing.Size(214, 316);
            this.talentBox.TabIndex = 36;
            // 
            // talentLabel
            // 
            this.talentLabel.AutoSize = true;
            this.talentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.talentLabel.Location = new System.Drawing.Point(573, 8);
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
            this.archetypeSelect.Size = new System.Drawing.Size(184, 21);
            this.archetypeSelect.TabIndex = 4;
            this.archetypeSelect.SelectedIndexChanged += new System.EventHandler(this.archetypeSelect_SelectedIndexChanged);
            // 
            // speciesSelect
            // 
            this.speciesSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speciesSelect.FormattingEnabled = true;
            this.speciesSelect.Location = new System.Drawing.Point(61, 87);
            this.speciesSelect.Name = "speciesSelect";
            this.speciesSelect.Size = new System.Drawing.Size(184, 21);
            this.speciesSelect.TabIndex = 3;
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
            this.tierSelect.Size = new System.Drawing.Size(184, 21);
            this.tierSelect.TabIndex = 2;
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
            this.attSpeedTotal.Location = new System.Drawing.Point(403, 215);
            this.attSpeedTotal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attSpeedTotal.Name = "attSpeedTotal";
            this.attSpeedTotal.Size = new System.Drawing.Size(28, 13);
            this.attSpeedTotal.TabIndex = 29;
            this.attSpeedTotal.Text = "100";
            // 
            // attInitiativeTotal
            // 
            this.attInitiativeTotal.AutoSize = true;
            this.attInitiativeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attInitiativeTotal.Location = new System.Drawing.Point(403, 190);
            this.attInitiativeTotal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attInitiativeTotal.Name = "attInitiativeTotal";
            this.attInitiativeTotal.Size = new System.Drawing.Size(21, 13);
            this.attInitiativeTotal.TabIndex = 28;
            this.attInitiativeTotal.Text = "99";
            // 
            // attFellowshipTotal
            // 
            this.attFellowshipTotal.AutoSize = true;
            this.attFellowshipTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attFellowshipTotal.Location = new System.Drawing.Point(403, 165);
            this.attFellowshipTotal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attFellowshipTotal.Name = "attFellowshipTotal";
            this.attFellowshipTotal.Size = new System.Drawing.Size(21, 13);
            this.attFellowshipTotal.TabIndex = 27;
            this.attFellowshipTotal.Text = "99";
            // 
            // attWillpowerTotal
            // 
            this.attWillpowerTotal.AutoSize = true;
            this.attWillpowerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attWillpowerTotal.Location = new System.Drawing.Point(403, 140);
            this.attWillpowerTotal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attWillpowerTotal.Name = "attWillpowerTotal";
            this.attWillpowerTotal.Size = new System.Drawing.Size(21, 13);
            this.attWillpowerTotal.TabIndex = 26;
            this.attWillpowerTotal.Text = "99";
            // 
            // attIntellectTotal
            // 
            this.attIntellectTotal.AutoSize = true;
            this.attIntellectTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attIntellectTotal.Location = new System.Drawing.Point(403, 115);
            this.attIntellectTotal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attIntellectTotal.Name = "attIntellectTotal";
            this.attIntellectTotal.Size = new System.Drawing.Size(21, 13);
            this.attIntellectTotal.TabIndex = 25;
            this.attIntellectTotal.Text = "88";
            // 
            // attToughnessTotal
            // 
            this.attToughnessTotal.AutoSize = true;
            this.attToughnessTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attToughnessTotal.Location = new System.Drawing.Point(403, 90);
            this.attToughnessTotal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attToughnessTotal.Name = "attToughnessTotal";
            this.attToughnessTotal.Size = new System.Drawing.Size(21, 13);
            this.attToughnessTotal.TabIndex = 24;
            this.attToughnessTotal.Text = "77";
            // 
            // attAgilityTotal
            // 
            this.attAgilityTotal.AutoSize = true;
            this.attAgilityTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attAgilityTotal.Location = new System.Drawing.Point(403, 65);
            this.attAgilityTotal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attAgilityTotal.Name = "attAgilityTotal";
            this.attAgilityTotal.Size = new System.Drawing.Size(21, 13);
            this.attAgilityTotal.TabIndex = 23;
            this.attAgilityTotal.Text = "22";
            // 
            // attStrengthTotal
            // 
            this.attStrengthTotal.AutoSize = true;
            this.attStrengthTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attStrengthTotal.Location = new System.Drawing.Point(403, 40);
            this.attStrengthTotal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attStrengthTotal.Name = "attStrengthTotal";
            this.attStrengthTotal.Size = new System.Drawing.Size(21, 13);
            this.attStrengthTotal.TabIndex = 22;
            this.attStrengthTotal.Text = "22";
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
            this.raceLabel.Location = new System.Drawing.Point(-1, 8);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(118, 13);
            this.raceLabel.TabIndex = 17;
            this.raceLabel.Text = "General Information";
            // 
            // attSpeed
            // 
            this.attSpeed.Enabled = false;
            this.attSpeed.Location = new System.Drawing.Point(350, 213);
            this.attSpeed.Name = "attSpeed";
            this.attSpeed.ReadOnly = true;
            this.attSpeed.Size = new System.Drawing.Size(47, 20);
            this.attSpeed.TabIndex = 31;
            this.attSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attSpeed.ValueChanged += new System.EventHandler(this.attSpeed_ValueChanged);
            // 
            // attInitiative
            // 
            this.attInitiative.Location = new System.Drawing.Point(350, 188);
            this.attInitiative.Name = "attInitiative";
            this.attInitiative.ReadOnly = true;
            this.attInitiative.Size = new System.Drawing.Size(47, 20);
            this.attInitiative.TabIndex = 29;
            this.attInitiative.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attInitiative.ValueChanged += new System.EventHandler(this.attInitiative_ValueChanged);
            // 
            // attFellowship
            // 
            this.attFellowship.Location = new System.Drawing.Point(350, 163);
            this.attFellowship.Name = "attFellowship";
            this.attFellowship.ReadOnly = true;
            this.attFellowship.Size = new System.Drawing.Size(47, 20);
            this.attFellowship.TabIndex = 27;
            this.attFellowship.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attFellowship.ValueChanged += new System.EventHandler(this.attFellowship_ValueChanged);
            // 
            // attWillpower
            // 
            this.attWillpower.Location = new System.Drawing.Point(350, 138);
            this.attWillpower.Name = "attWillpower";
            this.attWillpower.ReadOnly = true;
            this.attWillpower.Size = new System.Drawing.Size(47, 20);
            this.attWillpower.TabIndex = 25;
            this.attWillpower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attWillpower.ValueChanged += new System.EventHandler(this.attWillpower_ValueChanged);
            // 
            // attIntellect
            // 
            this.attIntellect.Location = new System.Drawing.Point(350, 113);
            this.attIntellect.Name = "attIntellect";
            this.attIntellect.ReadOnly = true;
            this.attIntellect.Size = new System.Drawing.Size(47, 20);
            this.attIntellect.TabIndex = 23;
            this.attIntellect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attIntellect.ValueChanged += new System.EventHandler(this.attIntellect_ValueChanged);
            // 
            // attToughness
            // 
            this.attToughness.Location = new System.Drawing.Point(350, 88);
            this.attToughness.Name = "attToughness";
            this.attToughness.ReadOnly = true;
            this.attToughness.Size = new System.Drawing.Size(47, 20);
            this.attToughness.TabIndex = 21;
            this.attToughness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attToughness.ValueChanged += new System.EventHandler(this.attToughness_ValueChanged);
            // 
            // attAgility
            // 
            this.attAgility.Location = new System.Drawing.Point(350, 63);
            this.attAgility.Name = "attAgility";
            this.attAgility.ReadOnly = true;
            this.attAgility.Size = new System.Drawing.Size(47, 20);
            this.attAgility.TabIndex = 19;
            this.attAgility.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attAgility.ValueChanged += new System.EventHandler(this.attAgility_ValueChanged);
            // 
            // attStrength
            // 
            this.attStrength.Location = new System.Drawing.Point(350, 38);
            this.attStrength.Name = "attStrength";
            this.attStrength.ReadOnly = true;
            this.attStrength.Size = new System.Drawing.Size(47, 20);
            this.attStrength.TabIndex = 17;
            this.attStrength.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attStrength.ValueChanged += new System.EventHandler(this.attStrength_ValueChanged);
            // 
            // attSpeedLabel
            // 
            this.attSpeedLabel.AutoSize = true;
            this.attSpeedLabel.Location = new System.Drawing.Point(268, 215);
            this.attSpeedLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attSpeedLabel.Name = "attSpeedLabel";
            this.attSpeedLabel.Size = new System.Drawing.Size(38, 13);
            this.attSpeedLabel.TabIndex = 8;
            this.attSpeedLabel.Text = "Speed";
            // 
            // attInitiativeLabel
            // 
            this.attInitiativeLabel.AutoSize = true;
            this.attInitiativeLabel.Location = new System.Drawing.Point(268, 190);
            this.attInitiativeLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attInitiativeLabel.Name = "attInitiativeLabel";
            this.attInitiativeLabel.Size = new System.Drawing.Size(46, 13);
            this.attInitiativeLabel.TabIndex = 7;
            this.attInitiativeLabel.Text = "Initiative";
            // 
            // attFellowshipLabel
            // 
            this.attFellowshipLabel.AutoSize = true;
            this.attFellowshipLabel.Location = new System.Drawing.Point(268, 165);
            this.attFellowshipLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attFellowshipLabel.Name = "attFellowshipLabel";
            this.attFellowshipLabel.Size = new System.Drawing.Size(56, 13);
            this.attFellowshipLabel.TabIndex = 6;
            this.attFellowshipLabel.Text = "Fellowship";
            // 
            // attWillpowerLabel
            // 
            this.attWillpowerLabel.AutoSize = true;
            this.attWillpowerLabel.Location = new System.Drawing.Point(268, 140);
            this.attWillpowerLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attWillpowerLabel.Name = "attWillpowerLabel";
            this.attWillpowerLabel.Size = new System.Drawing.Size(53, 13);
            this.attWillpowerLabel.TabIndex = 5;
            this.attWillpowerLabel.Text = "Willpower";
            // 
            // attIntellectLabel
            // 
            this.attIntellectLabel.AutoSize = true;
            this.attIntellectLabel.Location = new System.Drawing.Point(268, 115);
            this.attIntellectLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attIntellectLabel.Name = "attIntellectLabel";
            this.attIntellectLabel.Size = new System.Drawing.Size(44, 13);
            this.attIntellectLabel.TabIndex = 4;
            this.attIntellectLabel.Text = "Intellect";
            // 
            // attToughnessLabel
            // 
            this.attToughnessLabel.AutoSize = true;
            this.attToughnessLabel.Location = new System.Drawing.Point(268, 90);
            this.attToughnessLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attToughnessLabel.Name = "attToughnessLabel";
            this.attToughnessLabel.Size = new System.Drawing.Size(60, 13);
            this.attToughnessLabel.TabIndex = 3;
            this.attToughnessLabel.Text = "Toughness";
            // 
            // attAgilityLabel
            // 
            this.attAgilityLabel.AutoSize = true;
            this.attAgilityLabel.Location = new System.Drawing.Point(268, 65);
            this.attAgilityLabel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 12);
            this.attAgilityLabel.Name = "attAgilityLabel";
            this.attAgilityLabel.Size = new System.Drawing.Size(34, 13);
            this.attAgilityLabel.TabIndex = 2;
            this.attAgilityLabel.Text = "Agility";
            // 
            // attStrengthLabel
            // 
            this.attStrengthLabel.AutoSize = true;
            this.attStrengthLabel.Location = new System.Drawing.Point(268, 40);
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
            this.attributesLabel.Location = new System.Drawing.Point(268, 8);
            this.attributesLabel.Name = "attributesLabel";
            this.attributesLabel.Size = new System.Drawing.Size(61, 13);
            this.attributesLabel.TabIndex = 0;
            this.attributesLabel.Text = "Attributes";
            // 
            // skills
            // 
            this.skills.BackColor = System.Drawing.Color.WhiteSmoke;
            this.skills.Controls.Add(this.label1);
            this.skills.Controls.Add(this.skillWeaponSkillBonus);
            this.skills.Controls.Add(this.skillTechBonus);
            this.skills.Controls.Add(this.skillSurvivalBonus);
            this.skills.Controls.Add(this.skillStealthBonus);
            this.skills.Controls.Add(this.skillScholarBonus);
            this.skills.Controls.Add(this.skillPsychicBonus);
            this.skills.Controls.Add(this.skillPilotBonus);
            this.skills.Controls.Add(this.skillPersuasionBonus);
            this.skills.Controls.Add(this.skillMedicaeBonus);
            this.skills.Controls.Add(this.skillLeadershipBonus);
            this.skills.Controls.Add(this.skillInvestigationBonus);
            this.skills.Controls.Add(this.skillIntimidationBonus);
            this.skills.Controls.Add(this.skillInsightBonus);
            this.skills.Controls.Add(this.skillDeceptionBonus);
            this.skills.Controls.Add(this.skillCunningBonus);
            this.skills.Controls.Add(this.skillBallisticBonus);
            this.skills.Controls.Add(this.skillAwarenessBonus);
            this.skills.Controls.Add(this.skillAthleticsBonus);
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
            this.skills.Controls.Add(this.skillNotesLabel);
            this.skills.Controls.Add(this.skillRatingLabel);
            this.skills.Controls.Add(this.athleticsBonusBox);
            this.skills.Controls.Add(this.athleticsRatingLabel);
            this.skills.Controls.Add(this.skillLabel);
            this.skills.Controls.Add(this.skillAthletics);
            this.skills.Controls.Add(this.athleticsLabel);
            this.skills.Location = new System.Drawing.Point(4, 22);
            this.skills.Name = "skills";
            this.skills.Padding = new System.Windows.Forms.Padding(3);
            this.skills.Size = new System.Drawing.Size(825, 509);
            this.skills.TabIndex = 1;
            this.skills.Text = "Skills";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "Bonus";
            // 
            // skillWeaponSkillBonus
            // 
            this.skillWeaponSkillBonus.Location = new System.Drawing.Point(276, 476);
            this.skillWeaponSkillBonus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.skillWeaponSkillBonus.Name = "skillWeaponSkillBonus";
            this.skillWeaponSkillBonus.ReadOnly = true;
            this.skillWeaponSkillBonus.Size = new System.Drawing.Size(45, 20);
            this.skillWeaponSkillBonus.TabIndex = 53;
            this.skillWeaponSkillBonus.ValueChanged += new System.EventHandler(this.skillWeaponSkillBonus_ValueChanged);
            // 
            // skillTechBonus
            // 
            this.skillTechBonus.Location = new System.Drawing.Point(276, 450);
            this.skillTechBonus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.skillTechBonus.Name = "skillTechBonus";
            this.skillTechBonus.ReadOnly = true;
            this.skillTechBonus.Size = new System.Drawing.Size(45, 20);
            this.skillTechBonus.TabIndex = 50;
            this.skillTechBonus.ValueChanged += new System.EventHandler(this.skillTechBonus_ValueChanged);
            // 
            // skillSurvivalBonus
            // 
            this.skillSurvivalBonus.Location = new System.Drawing.Point(276, 424);
            this.skillSurvivalBonus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.skillSurvivalBonus.Name = "skillSurvivalBonus";
            this.skillSurvivalBonus.ReadOnly = true;
            this.skillSurvivalBonus.Size = new System.Drawing.Size(45, 20);
            this.skillSurvivalBonus.TabIndex = 47;
            this.skillSurvivalBonus.ValueChanged += new System.EventHandler(this.skillSurvivalBonus_ValueChanged);
            // 
            // skillStealthBonus
            // 
            this.skillStealthBonus.Location = new System.Drawing.Point(276, 398);
            this.skillStealthBonus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.skillStealthBonus.Name = "skillStealthBonus";
            this.skillStealthBonus.ReadOnly = true;
            this.skillStealthBonus.Size = new System.Drawing.Size(45, 20);
            this.skillStealthBonus.TabIndex = 44;
            this.skillStealthBonus.ValueChanged += new System.EventHandler(this.skillAgilityBonus_ValueChanged);
            // 
            // skillScholarBonus
            // 
            this.skillScholarBonus.Location = new System.Drawing.Point(276, 372);
            this.skillScholarBonus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.skillScholarBonus.Name = "skillScholarBonus";
            this.skillScholarBonus.ReadOnly = true;
            this.skillScholarBonus.Size = new System.Drawing.Size(45, 20);
            this.skillScholarBonus.TabIndex = 41;
            this.skillScholarBonus.ValueChanged += new System.EventHandler(this.skillScholarBonus_ValueChanged);
            // 
            // skillPsychicBonus
            // 
            this.skillPsychicBonus.Location = new System.Drawing.Point(276, 346);
            this.skillPsychicBonus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.skillPsychicBonus.Name = "skillPsychicBonus";
            this.skillPsychicBonus.ReadOnly = true;
            this.skillPsychicBonus.Size = new System.Drawing.Size(45, 20);
            this.skillPsychicBonus.TabIndex = 38;
            this.skillPsychicBonus.ValueChanged += new System.EventHandler(this.skillPsychicBonus_ValueChanged);
            // 
            // skillPilotBonus
            // 
            this.skillPilotBonus.Location = new System.Drawing.Point(276, 320);
            this.skillPilotBonus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.skillPilotBonus.Name = "skillPilotBonus";
            this.skillPilotBonus.ReadOnly = true;
            this.skillPilotBonus.Size = new System.Drawing.Size(45, 20);
            this.skillPilotBonus.TabIndex = 35;
            this.skillPilotBonus.ValueChanged += new System.EventHandler(this.skillPilotBonus_ValueChanged);
            // 
            // skillPersuasionBonus
            // 
            this.skillPersuasionBonus.Location = new System.Drawing.Point(276, 294);
            this.skillPersuasionBonus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.skillPersuasionBonus.Name = "skillPersuasionBonus";
            this.skillPersuasionBonus.ReadOnly = true;
            this.skillPersuasionBonus.Size = new System.Drawing.Size(45, 20);
            this.skillPersuasionBonus.TabIndex = 32;
            this.skillPersuasionBonus.ValueChanged += new System.EventHandler(this.skillPersuasionBonus_ValueChanged);
            // 
            // skillMedicaeBonus
            // 
            this.skillMedicaeBonus.Location = new System.Drawing.Point(276, 268);
            this.skillMedicaeBonus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.skillMedicaeBonus.Name = "skillMedicaeBonus";
            this.skillMedicaeBonus.ReadOnly = true;
            this.skillMedicaeBonus.Size = new System.Drawing.Size(45, 20);
            this.skillMedicaeBonus.TabIndex = 29;
            this.skillMedicaeBonus.ValueChanged += new System.EventHandler(this.skillMedicaeBonus_ValueChanged);
            // 
            // skillLeadershipBonus
            // 
            this.skillLeadershipBonus.Location = new System.Drawing.Point(276, 242);
            this.skillLeadershipBonus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.skillLeadershipBonus.Name = "skillLeadershipBonus";
            this.skillLeadershipBonus.ReadOnly = true;
            this.skillLeadershipBonus.Size = new System.Drawing.Size(45, 20);
            this.skillLeadershipBonus.TabIndex = 26;
            this.skillLeadershipBonus.ValueChanged += new System.EventHandler(this.skillLeadershipBonus_ValueChanged);
            // 
            // skillInvestigationBonus
            // 
            this.skillInvestigationBonus.Location = new System.Drawing.Point(276, 216);
            this.skillInvestigationBonus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.skillInvestigationBonus.Name = "skillInvestigationBonus";
            this.skillInvestigationBonus.ReadOnly = true;
            this.skillInvestigationBonus.Size = new System.Drawing.Size(45, 20);
            this.skillInvestigationBonus.TabIndex = 23;
            this.skillInvestigationBonus.ValueChanged += new System.EventHandler(this.skillInvestigationBonus_ValueChanged);
            // 
            // skillIntimidationBonus
            // 
            this.skillIntimidationBonus.Location = new System.Drawing.Point(276, 190);
            this.skillIntimidationBonus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.skillIntimidationBonus.Name = "skillIntimidationBonus";
            this.skillIntimidationBonus.ReadOnly = true;
            this.skillIntimidationBonus.Size = new System.Drawing.Size(45, 20);
            this.skillIntimidationBonus.TabIndex = 20;
            this.skillIntimidationBonus.ValueChanged += new System.EventHandler(this.skillIntimidationBonus_ValueChanged);
            // 
            // skillInsightBonus
            // 
            this.skillInsightBonus.Location = new System.Drawing.Point(276, 164);
            this.skillInsightBonus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.skillInsightBonus.Name = "skillInsightBonus";
            this.skillInsightBonus.ReadOnly = true;
            this.skillInsightBonus.Size = new System.Drawing.Size(45, 20);
            this.skillInsightBonus.TabIndex = 17;
            this.skillInsightBonus.ValueChanged += new System.EventHandler(this.skillInsightBonus_ValueChanged);
            // 
            // skillDeceptionBonus
            // 
            this.skillDeceptionBonus.Location = new System.Drawing.Point(276, 138);
            this.skillDeceptionBonus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.skillDeceptionBonus.Name = "skillDeceptionBonus";
            this.skillDeceptionBonus.ReadOnly = true;
            this.skillDeceptionBonus.Size = new System.Drawing.Size(45, 20);
            this.skillDeceptionBonus.TabIndex = 14;
            this.skillDeceptionBonus.ValueChanged += new System.EventHandler(this.skillDeceptionBonus_ValueChanged);
            // 
            // skillCunningBonus
            // 
            this.skillCunningBonus.Location = new System.Drawing.Point(276, 112);
            this.skillCunningBonus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.skillCunningBonus.Name = "skillCunningBonus";
            this.skillCunningBonus.ReadOnly = true;
            this.skillCunningBonus.Size = new System.Drawing.Size(45, 20);
            this.skillCunningBonus.TabIndex = 11;
            this.skillCunningBonus.ValueChanged += new System.EventHandler(this.skillCunningBonus_ValueChanged);
            // 
            // skillBallisticBonus
            // 
            this.skillBallisticBonus.Location = new System.Drawing.Point(276, 86);
            this.skillBallisticBonus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.skillBallisticBonus.Name = "skillBallisticBonus";
            this.skillBallisticBonus.ReadOnly = true;
            this.skillBallisticBonus.Size = new System.Drawing.Size(45, 20);
            this.skillBallisticBonus.TabIndex = 8;
            this.skillBallisticBonus.ValueChanged += new System.EventHandler(this.skillBallisticBonus_ValueChanged);
            // 
            // skillAwarenessBonus
            // 
            this.skillAwarenessBonus.Location = new System.Drawing.Point(276, 60);
            this.skillAwarenessBonus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.skillAwarenessBonus.Name = "skillAwarenessBonus";
            this.skillAwarenessBonus.ReadOnly = true;
            this.skillAwarenessBonus.Size = new System.Drawing.Size(45, 20);
            this.skillAwarenessBonus.TabIndex = 5;
            this.skillAwarenessBonus.ValueChanged += new System.EventHandler(this.skillAwarenessBonus_ValueChanged);
            // 
            // skillAthleticsBonus
            // 
            this.skillAthleticsBonus.Location = new System.Drawing.Point(276, 34);
            this.skillAthleticsBonus.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.skillAthleticsBonus.Name = "skillAthleticsBonus";
            this.skillAthleticsBonus.ReadOnly = true;
            this.skillAthleticsBonus.Size = new System.Drawing.Size(45, 20);
            this.skillAthleticsBonus.TabIndex = 2;
            this.skillAthleticsBonus.ValueChanged += new System.EventHandler(this.skillAthleticsBonus_ValueChanged);
            // 
            // weaponSkillBonusBox
            // 
            this.weaponSkillBonusBox.Location = new System.Drawing.Point(350, 475);
            this.weaponSkillBonusBox.Name = "weaponSkillBonusBox";
            this.weaponSkillBonusBox.Size = new System.Drawing.Size(456, 20);
            this.weaponSkillBonusBox.TabIndex = 54;
            // 
            // weaponSkillRatingLabel
            // 
            this.weaponSkillRatingLabel.AutoSize = true;
            this.weaponSkillRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponSkillRatingLabel.Location = new System.Drawing.Point(238, 478);
            this.weaponSkillRatingLabel.Name = "weaponSkillRatingLabel";
            this.weaponSkillRatingLabel.Size = new System.Drawing.Size(21, 13);
            this.weaponSkillRatingLabel.TabIndex = 73;
            this.weaponSkillRatingLabel.Text = "99";
            // 
            // skillWeaponSkill
            // 
            this.skillWeaponSkill.Location = new System.Drawing.Point(182, 476);
            this.skillWeaponSkill.Name = "skillWeaponSkill";
            this.skillWeaponSkill.ReadOnly = true;
            this.skillWeaponSkill.Size = new System.Drawing.Size(45, 20);
            this.skillWeaponSkill.TabIndex = 52;
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
            // techBonusBox
            // 
            this.techBonusBox.Location = new System.Drawing.Point(350, 449);
            this.techBonusBox.Name = "techBonusBox";
            this.techBonusBox.Size = new System.Drawing.Size(456, 20);
            this.techBonusBox.TabIndex = 51;
            // 
            // techRatingLabel
            // 
            this.techRatingLabel.AutoSize = true;
            this.techRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techRatingLabel.Location = new System.Drawing.Point(238, 452);
            this.techRatingLabel.Name = "techRatingLabel";
            this.techRatingLabel.Size = new System.Drawing.Size(28, 13);
            this.techRatingLabel.TabIndex = 69;
            this.techRatingLabel.Text = "999";
            // 
            // skillTech
            // 
            this.skillTech.Location = new System.Drawing.Point(182, 450);
            this.skillTech.Name = "skillTech";
            this.skillTech.ReadOnly = true;
            this.skillTech.Size = new System.Drawing.Size(45, 20);
            this.skillTech.TabIndex = 49;
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
            // survivalBonusBox
            // 
            this.survivalBonusBox.Location = new System.Drawing.Point(350, 423);
            this.survivalBonusBox.Name = "survivalBonusBox";
            this.survivalBonusBox.Size = new System.Drawing.Size(456, 20);
            this.survivalBonusBox.TabIndex = 48;
            // 
            // survivalRatingLabel
            // 
            this.survivalRatingLabel.AutoSize = true;
            this.survivalRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.survivalRatingLabel.Location = new System.Drawing.Point(238, 426);
            this.survivalRatingLabel.Name = "survivalRatingLabel";
            this.survivalRatingLabel.Size = new System.Drawing.Size(21, 13);
            this.survivalRatingLabel.TabIndex = 65;
            this.survivalRatingLabel.Text = "99";
            // 
            // skillSurvival
            // 
            this.skillSurvival.Location = new System.Drawing.Point(182, 424);
            this.skillSurvival.Name = "skillSurvival";
            this.skillSurvival.ReadOnly = true;
            this.skillSurvival.Size = new System.Drawing.Size(45, 20);
            this.skillSurvival.TabIndex = 46;
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
            // stealthBonusBox
            // 
            this.stealthBonusBox.Location = new System.Drawing.Point(350, 397);
            this.stealthBonusBox.Name = "stealthBonusBox";
            this.stealthBonusBox.Size = new System.Drawing.Size(456, 20);
            this.stealthBonusBox.TabIndex = 45;
            // 
            // stealthRatingLabel
            // 
            this.stealthRatingLabel.AutoSize = true;
            this.stealthRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stealthRatingLabel.Location = new System.Drawing.Point(238, 400);
            this.stealthRatingLabel.Name = "stealthRatingLabel";
            this.stealthRatingLabel.Size = new System.Drawing.Size(21, 13);
            this.stealthRatingLabel.TabIndex = 61;
            this.stealthRatingLabel.Text = "99";
            // 
            // skillStealth
            // 
            this.skillStealth.Location = new System.Drawing.Point(182, 398);
            this.skillStealth.Name = "skillStealth";
            this.skillStealth.ReadOnly = true;
            this.skillStealth.Size = new System.Drawing.Size(45, 20);
            this.skillStealth.TabIndex = 43;
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
            // scholarBonusBox
            // 
            this.scholarBonusBox.Location = new System.Drawing.Point(350, 371);
            this.scholarBonusBox.Name = "scholarBonusBox";
            this.scholarBonusBox.Size = new System.Drawing.Size(456, 20);
            this.scholarBonusBox.TabIndex = 42;
            // 
            // scholarRatingLabel
            // 
            this.scholarRatingLabel.AutoSize = true;
            this.scholarRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scholarRatingLabel.Location = new System.Drawing.Point(238, 374);
            this.scholarRatingLabel.Name = "scholarRatingLabel";
            this.scholarRatingLabel.Size = new System.Drawing.Size(21, 13);
            this.scholarRatingLabel.TabIndex = 57;
            this.scholarRatingLabel.Text = "99";
            // 
            // skillScholar
            // 
            this.skillScholar.Location = new System.Drawing.Point(182, 372);
            this.skillScholar.Name = "skillScholar";
            this.skillScholar.ReadOnly = true;
            this.skillScholar.Size = new System.Drawing.Size(45, 20);
            this.skillScholar.TabIndex = 40;
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
            // psychicBonusBox
            // 
            this.psychicBonusBox.Location = new System.Drawing.Point(350, 345);
            this.psychicBonusBox.Name = "psychicBonusBox";
            this.psychicBonusBox.Size = new System.Drawing.Size(456, 20);
            this.psychicBonusBox.TabIndex = 39;
            // 
            // psychicRatingLabel
            // 
            this.psychicRatingLabel.AutoSize = true;
            this.psychicRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psychicRatingLabel.Location = new System.Drawing.Point(238, 348);
            this.psychicRatingLabel.Name = "psychicRatingLabel";
            this.psychicRatingLabel.Size = new System.Drawing.Size(21, 13);
            this.psychicRatingLabel.TabIndex = 53;
            this.psychicRatingLabel.Text = "99";
            // 
            // skillPsychic
            // 
            this.skillPsychic.Location = new System.Drawing.Point(182, 346);
            this.skillPsychic.Name = "skillPsychic";
            this.skillPsychic.ReadOnly = true;
            this.skillPsychic.Size = new System.Drawing.Size(45, 20);
            this.skillPsychic.TabIndex = 37;
            this.skillPsychic.ValueChanged += new System.EventHandler(this.skillPsychic_ValueChanged);
            // 
            // psychicLabel
            // 
            this.psychicLabel.AutoSize = true;
            this.psychicLabel.Location = new System.Drawing.Point(1, 348);
            this.psychicLabel.Name = "psychicLabel";
            this.psychicLabel.Size = new System.Drawing.Size(139, 13);
            this.psychicLabel.TabIndex = 51;
            this.psychicLabel.Text = "Psychic Mastery (Willpower)";
            // 
            // pilotBonusBox
            // 
            this.pilotBonusBox.Location = new System.Drawing.Point(350, 319);
            this.pilotBonusBox.Name = "pilotBonusBox";
            this.pilotBonusBox.Size = new System.Drawing.Size(456, 20);
            this.pilotBonusBox.TabIndex = 36;
            // 
            // pilotRatingLabel
            // 
            this.pilotRatingLabel.AutoSize = true;
            this.pilotRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pilotRatingLabel.Location = new System.Drawing.Point(238, 322);
            this.pilotRatingLabel.Name = "pilotRatingLabel";
            this.pilotRatingLabel.Size = new System.Drawing.Size(21, 13);
            this.pilotRatingLabel.TabIndex = 49;
            this.pilotRatingLabel.Text = "99";
            // 
            // skillPilot
            // 
            this.skillPilot.Location = new System.Drawing.Point(182, 320);
            this.skillPilot.Name = "skillPilot";
            this.skillPilot.ReadOnly = true;
            this.skillPilot.Size = new System.Drawing.Size(45, 20);
            this.skillPilot.TabIndex = 34;
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
            // persuasionBonusBox
            // 
            this.persuasionBonusBox.Location = new System.Drawing.Point(350, 293);
            this.persuasionBonusBox.Name = "persuasionBonusBox";
            this.persuasionBonusBox.Size = new System.Drawing.Size(456, 20);
            this.persuasionBonusBox.TabIndex = 33;
            // 
            // persuasionRatingLabel
            // 
            this.persuasionRatingLabel.AutoSize = true;
            this.persuasionRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persuasionRatingLabel.Location = new System.Drawing.Point(238, 296);
            this.persuasionRatingLabel.Name = "persuasionRatingLabel";
            this.persuasionRatingLabel.Size = new System.Drawing.Size(21, 13);
            this.persuasionRatingLabel.TabIndex = 45;
            this.persuasionRatingLabel.Text = "99";
            // 
            // skillPersuasion
            // 
            this.skillPersuasion.Location = new System.Drawing.Point(182, 294);
            this.skillPersuasion.Name = "skillPersuasion";
            this.skillPersuasion.ReadOnly = true;
            this.skillPersuasion.Size = new System.Drawing.Size(45, 20);
            this.skillPersuasion.TabIndex = 31;
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
            // medicaeBonusBox
            // 
            this.medicaeBonusBox.Location = new System.Drawing.Point(350, 267);
            this.medicaeBonusBox.Name = "medicaeBonusBox";
            this.medicaeBonusBox.Size = new System.Drawing.Size(456, 20);
            this.medicaeBonusBox.TabIndex = 30;
            // 
            // medicaeRatingLabel
            // 
            this.medicaeRatingLabel.AutoSize = true;
            this.medicaeRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medicaeRatingLabel.Location = new System.Drawing.Point(238, 270);
            this.medicaeRatingLabel.Name = "medicaeRatingLabel";
            this.medicaeRatingLabel.Size = new System.Drawing.Size(21, 13);
            this.medicaeRatingLabel.TabIndex = 41;
            this.medicaeRatingLabel.Text = "99";
            // 
            // skillMedicae
            // 
            this.skillMedicae.Location = new System.Drawing.Point(182, 268);
            this.skillMedicae.Name = "skillMedicae";
            this.skillMedicae.ReadOnly = true;
            this.skillMedicae.Size = new System.Drawing.Size(45, 20);
            this.skillMedicae.TabIndex = 28;
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
            // leadershipBonusBox
            // 
            this.leadershipBonusBox.Location = new System.Drawing.Point(350, 241);
            this.leadershipBonusBox.Name = "leadershipBonusBox";
            this.leadershipBonusBox.Size = new System.Drawing.Size(456, 20);
            this.leadershipBonusBox.TabIndex = 27;
            // 
            // leadershipRatingLabel
            // 
            this.leadershipRatingLabel.AutoSize = true;
            this.leadershipRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leadershipRatingLabel.Location = new System.Drawing.Point(238, 244);
            this.leadershipRatingLabel.Name = "leadershipRatingLabel";
            this.leadershipRatingLabel.Size = new System.Drawing.Size(21, 13);
            this.leadershipRatingLabel.TabIndex = 37;
            this.leadershipRatingLabel.Text = "99";
            // 
            // skillLeadership
            // 
            this.skillLeadership.Location = new System.Drawing.Point(182, 242);
            this.skillLeadership.Name = "skillLeadership";
            this.skillLeadership.ReadOnly = true;
            this.skillLeadership.Size = new System.Drawing.Size(45, 20);
            this.skillLeadership.TabIndex = 25;
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
            // investigationBonusBox
            // 
            this.investigationBonusBox.Location = new System.Drawing.Point(350, 215);
            this.investigationBonusBox.Name = "investigationBonusBox";
            this.investigationBonusBox.Size = new System.Drawing.Size(456, 20);
            this.investigationBonusBox.TabIndex = 24;
            // 
            // investigationRatingLabel
            // 
            this.investigationRatingLabel.AutoSize = true;
            this.investigationRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.investigationRatingLabel.Location = new System.Drawing.Point(238, 218);
            this.investigationRatingLabel.Name = "investigationRatingLabel";
            this.investigationRatingLabel.Size = new System.Drawing.Size(21, 13);
            this.investigationRatingLabel.TabIndex = 33;
            this.investigationRatingLabel.Text = "99";
            // 
            // skillInvestigation
            // 
            this.skillInvestigation.Location = new System.Drawing.Point(182, 216);
            this.skillInvestigation.Name = "skillInvestigation";
            this.skillInvestigation.ReadOnly = true;
            this.skillInvestigation.Size = new System.Drawing.Size(45, 20);
            this.skillInvestigation.TabIndex = 22;
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
            // intimidationBonusBox
            // 
            this.intimidationBonusBox.Location = new System.Drawing.Point(350, 189);
            this.intimidationBonusBox.Name = "intimidationBonusBox";
            this.intimidationBonusBox.Size = new System.Drawing.Size(456, 20);
            this.intimidationBonusBox.TabIndex = 21;
            // 
            // intimidationRatingLabel
            // 
            this.intimidationRatingLabel.AutoSize = true;
            this.intimidationRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intimidationRatingLabel.Location = new System.Drawing.Point(238, 192);
            this.intimidationRatingLabel.Name = "intimidationRatingLabel";
            this.intimidationRatingLabel.Size = new System.Drawing.Size(21, 13);
            this.intimidationRatingLabel.TabIndex = 29;
            this.intimidationRatingLabel.Text = "99";
            // 
            // skillIntimidation
            // 
            this.skillIntimidation.Location = new System.Drawing.Point(182, 190);
            this.skillIntimidation.Name = "skillIntimidation";
            this.skillIntimidation.ReadOnly = true;
            this.skillIntimidation.Size = new System.Drawing.Size(45, 20);
            this.skillIntimidation.TabIndex = 19;
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
            // insightBonusBox
            // 
            this.insightBonusBox.Location = new System.Drawing.Point(350, 163);
            this.insightBonusBox.Name = "insightBonusBox";
            this.insightBonusBox.Size = new System.Drawing.Size(456, 20);
            this.insightBonusBox.TabIndex = 18;
            // 
            // insightRatingLabel
            // 
            this.insightRatingLabel.AutoSize = true;
            this.insightRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insightRatingLabel.Location = new System.Drawing.Point(238, 166);
            this.insightRatingLabel.Name = "insightRatingLabel";
            this.insightRatingLabel.Size = new System.Drawing.Size(21, 13);
            this.insightRatingLabel.TabIndex = 25;
            this.insightRatingLabel.Text = "99";
            // 
            // skillInsight
            // 
            this.skillInsight.Location = new System.Drawing.Point(182, 164);
            this.skillInsight.Name = "skillInsight";
            this.skillInsight.ReadOnly = true;
            this.skillInsight.Size = new System.Drawing.Size(45, 20);
            this.skillInsight.TabIndex = 16;
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
            // deceptionBonusBox
            // 
            this.deceptionBonusBox.Location = new System.Drawing.Point(350, 137);
            this.deceptionBonusBox.Name = "deceptionBonusBox";
            this.deceptionBonusBox.Size = new System.Drawing.Size(456, 20);
            this.deceptionBonusBox.TabIndex = 15;
            // 
            // deceptionRatingLabel
            // 
            this.deceptionRatingLabel.AutoSize = true;
            this.deceptionRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deceptionRatingLabel.Location = new System.Drawing.Point(238, 140);
            this.deceptionRatingLabel.Name = "deceptionRatingLabel";
            this.deceptionRatingLabel.Size = new System.Drawing.Size(21, 13);
            this.deceptionRatingLabel.TabIndex = 21;
            this.deceptionRatingLabel.Text = "99";
            // 
            // skillDeception
            // 
            this.skillDeception.Location = new System.Drawing.Point(182, 138);
            this.skillDeception.Name = "skillDeception";
            this.skillDeception.ReadOnly = true;
            this.skillDeception.Size = new System.Drawing.Size(45, 20);
            this.skillDeception.TabIndex = 13;
            this.skillDeception.ValueChanged += new System.EventHandler(this.skillDeception_ValueChanged);
            // 
            // deceptionLabel
            // 
            this.deceptionLabel.AutoSize = true;
            this.deceptionLabel.Location = new System.Drawing.Point(1, 140);
            this.deceptionLabel.Name = "deceptionLabel";
            this.deceptionLabel.Size = new System.Drawing.Size(114, 13);
            this.deceptionLabel.TabIndex = 19;
            this.deceptionLabel.Text = "Deception (Fellowship)";
            // 
            // cunningBonusBox
            // 
            this.cunningBonusBox.Location = new System.Drawing.Point(350, 111);
            this.cunningBonusBox.Name = "cunningBonusBox";
            this.cunningBonusBox.Size = new System.Drawing.Size(456, 20);
            this.cunningBonusBox.TabIndex = 12;
            // 
            // cunningRatingLabel
            // 
            this.cunningRatingLabel.AutoSize = true;
            this.cunningRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cunningRatingLabel.Location = new System.Drawing.Point(238, 114);
            this.cunningRatingLabel.Name = "cunningRatingLabel";
            this.cunningRatingLabel.Size = new System.Drawing.Size(21, 13);
            this.cunningRatingLabel.TabIndex = 17;
            this.cunningRatingLabel.Text = "99";
            // 
            // skillCunning
            // 
            this.skillCunning.Location = new System.Drawing.Point(182, 112);
            this.skillCunning.Name = "skillCunning";
            this.skillCunning.ReadOnly = true;
            this.skillCunning.Size = new System.Drawing.Size(45, 20);
            this.skillCunning.TabIndex = 10;
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
            // ballisticBonusBox
            // 
            this.ballisticBonusBox.Location = new System.Drawing.Point(350, 85);
            this.ballisticBonusBox.Name = "ballisticBonusBox";
            this.ballisticBonusBox.Size = new System.Drawing.Size(456, 20);
            this.ballisticBonusBox.TabIndex = 9;
            // 
            // ballisticRatingLabel
            // 
            this.ballisticRatingLabel.AutoSize = true;
            this.ballisticRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ballisticRatingLabel.Location = new System.Drawing.Point(238, 88);
            this.ballisticRatingLabel.Name = "ballisticRatingLabel";
            this.ballisticRatingLabel.Size = new System.Drawing.Size(21, 13);
            this.ballisticRatingLabel.TabIndex = 13;
            this.ballisticRatingLabel.Text = "99";
            // 
            // skillBallstic
            // 
            this.skillBallstic.Location = new System.Drawing.Point(182, 86);
            this.skillBallstic.Name = "skillBallstic";
            this.skillBallstic.ReadOnly = true;
            this.skillBallstic.Size = new System.Drawing.Size(45, 20);
            this.skillBallstic.TabIndex = 7;
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
            // awarenessBonusBox
            // 
            this.awarenessBonusBox.Location = new System.Drawing.Point(350, 59);
            this.awarenessBonusBox.Name = "awarenessBonusBox";
            this.awarenessBonusBox.Size = new System.Drawing.Size(456, 20);
            this.awarenessBonusBox.TabIndex = 6;
            // 
            // awarenessRatingLabel
            // 
            this.awarenessRatingLabel.AutoSize = true;
            this.awarenessRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awarenessRatingLabel.Location = new System.Drawing.Point(238, 62);
            this.awarenessRatingLabel.Name = "awarenessRatingLabel";
            this.awarenessRatingLabel.Size = new System.Drawing.Size(21, 13);
            this.awarenessRatingLabel.TabIndex = 9;
            this.awarenessRatingLabel.Text = "99";
            // 
            // skillAwareness
            // 
            this.skillAwareness.Location = new System.Drawing.Point(182, 60);
            this.skillAwareness.Name = "skillAwareness";
            this.skillAwareness.ReadOnly = true;
            this.skillAwareness.Size = new System.Drawing.Size(45, 20);
            this.skillAwareness.TabIndex = 4;
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
            // skillNotesLabel
            // 
            this.skillNotesLabel.AutoSize = true;
            this.skillNotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillNotesLabel.Location = new System.Drawing.Point(347, 4);
            this.skillNotesLabel.Name = "skillNotesLabel";
            this.skillNotesLabel.Size = new System.Drawing.Size(40, 13);
            this.skillNotesLabel.TabIndex = 6;
            this.skillNotesLabel.Text = "Notes";
            // 
            // skillRatingLabel
            // 
            this.skillRatingLabel.AutoSize = true;
            this.skillRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillRatingLabel.Location = new System.Drawing.Point(179, 4);
            this.skillRatingLabel.Name = "skillRatingLabel";
            this.skillRatingLabel.Size = new System.Drawing.Size(72, 13);
            this.skillRatingLabel.TabIndex = 5;
            this.skillRatingLabel.Text = "Skill Rating";
            // 
            // athleticsBonusBox
            // 
            this.athleticsBonusBox.Location = new System.Drawing.Point(350, 33);
            this.athleticsBonusBox.Name = "athleticsBonusBox";
            this.athleticsBonusBox.Size = new System.Drawing.Size(456, 20);
            this.athleticsBonusBox.TabIndex = 3;
            // 
            // athleticsRatingLabel
            // 
            this.athleticsRatingLabel.AutoSize = true;
            this.athleticsRatingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.athleticsRatingLabel.Location = new System.Drawing.Point(238, 36);
            this.athleticsRatingLabel.Name = "athleticsRatingLabel";
            this.athleticsRatingLabel.Size = new System.Drawing.Size(21, 13);
            this.athleticsRatingLabel.TabIndex = 3;
            this.athleticsRatingLabel.Text = "99";
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
            // skillAthletics
            // 
            this.skillAthletics.Location = new System.Drawing.Point(182, 34);
            this.skillAthletics.Name = "skillAthletics";
            this.skillAthletics.ReadOnly = true;
            this.skillAthletics.Size = new System.Drawing.Size(45, 20);
            this.skillAthletics.TabIndex = 1;
            this.skillAthletics.ValueChanged += new System.EventHandler(this.skillAthletics_ValueChanged);
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
            // equipment
            // 
            this.equipment.AutoScroll = true;
            this.equipment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.equipment.Controls.Add(this.equipTreeBox);
            this.equipment.Controls.Add(this.equipDamageLabel);
            this.equipment.Controls.Add(this.equipArmorRatingLabel);
            this.equipment.Controls.Add(this.equipKeywordsLabel);
            this.equipment.Controls.Add(this.equipValueLabel);
            this.equipment.Controls.Add(this.equipTraitsLabel);
            this.equipment.Controls.Add(this.equipSalvoLabel);
            this.equipment.Controls.Add(this.equipRangeLabel);
            this.equipment.Controls.Add(this.equipAPLabel);
            this.equipment.Controls.Add(this.removeEquipButton);
            this.equipment.Controls.Add(this.addEquipButton);
            this.equipment.Controls.Add(this.equipmentLabel);
            this.equipment.Controls.Add(this.miscEquipmentHeaderLabel);
            this.equipment.Controls.Add(this.equipmentTextBox);
            this.equipment.Location = new System.Drawing.Point(4, 22);
            this.equipment.Name = "equipment";
            this.equipment.Padding = new System.Windows.Forms.Padding(3);
            this.equipment.Size = new System.Drawing.Size(825, 509);
            this.equipment.TabIndex = 2;
            this.equipment.Text = "Equipment";
            // 
            // equipTreeBox
            // 
            this.equipTreeBox.Location = new System.Drawing.Point(6, 37);
            this.equipTreeBox.Name = "equipTreeBox";
            treeNode1.Name = "rangedWeaponNode";
            treeNode1.Text = "Ranged Weapons";
            treeNode2.Name = "meleeWeaponNode";
            treeNode2.Text = "Melee Weapons";
            treeNode3.Name = "armorNode";
            treeNode3.Text = "Armor";
            treeNode4.Name = "toolsNode";
            treeNode4.Text = "Ammo and Tools";
            this.equipTreeBox.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            this.equipTreeBox.ShowRootLines = false;
            this.equipTreeBox.Size = new System.Drawing.Size(214, 316);
            this.equipTreeBox.TabIndex = 1;
            this.equipTreeBox.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.equipTreeBox_AfterSelect);
            this.equipTreeBox.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.equipTreeBox_NodeMouseClick);
            // 
            // equipDamageLabel
            // 
            this.equipDamageLabel.AutoSize = true;
            this.equipDamageLabel.Location = new System.Drawing.Point(226, 37);
            this.equipDamageLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.equipDamageLabel.Name = "equipDamageLabel";
            this.equipDamageLabel.Size = new System.Drawing.Size(53, 13);
            this.equipDamageLabel.TabIndex = 133;
            this.equipDamageLabel.Text = "Damage: ";
            // 
            // equipArmorRatingLabel
            // 
            this.equipArmorRatingLabel.AutoSize = true;
            this.equipArmorRatingLabel.Location = new System.Drawing.Point(226, 137);
            this.equipArmorRatingLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.equipArmorRatingLabel.Name = "equipArmorRatingLabel";
            this.equipArmorRatingLabel.Size = new System.Drawing.Size(37, 13);
            this.equipArmorRatingLabel.TabIndex = 132;
            this.equipArmorRatingLabel.Text = "Armor:";
            // 
            // equipKeywordsLabel
            // 
            this.equipKeywordsLabel.AutoSize = true;
            this.equipKeywordsLabel.Location = new System.Drawing.Point(226, 187);
            this.equipKeywordsLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.equipKeywordsLabel.Name = "equipKeywordsLabel";
            this.equipKeywordsLabel.Size = new System.Drawing.Size(56, 13);
            this.equipKeywordsLabel.TabIndex = 131;
            this.equipKeywordsLabel.Text = "Keywords:";
            // 
            // equipValueLabel
            // 
            this.equipValueLabel.AutoSize = true;
            this.equipValueLabel.Location = new System.Drawing.Point(226, 162);
            this.equipValueLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.equipValueLabel.Name = "equipValueLabel";
            this.equipValueLabel.Size = new System.Drawing.Size(37, 13);
            this.equipValueLabel.TabIndex = 130;
            this.equipValueLabel.Text = "Value:";
            // 
            // equipTraitsLabel
            // 
            this.equipTraitsLabel.AutoSize = true;
            this.equipTraitsLabel.Location = new System.Drawing.Point(226, 212);
            this.equipTraitsLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.equipTraitsLabel.Name = "equipTraitsLabel";
            this.equipTraitsLabel.Size = new System.Drawing.Size(39, 13);
            this.equipTraitsLabel.TabIndex = 129;
            this.equipTraitsLabel.Text = "Traits: ";
            // 
            // equipSalvoLabel
            // 
            this.equipSalvoLabel.AutoSize = true;
            this.equipSalvoLabel.Location = new System.Drawing.Point(226, 112);
            this.equipSalvoLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.equipSalvoLabel.Name = "equipSalvoLabel";
            this.equipSalvoLabel.Size = new System.Drawing.Size(40, 13);
            this.equipSalvoLabel.TabIndex = 128;
            this.equipSalvoLabel.Text = "Salvo: ";
            // 
            // equipRangeLabel
            // 
            this.equipRangeLabel.AutoSize = true;
            this.equipRangeLabel.Location = new System.Drawing.Point(226, 87);
            this.equipRangeLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.equipRangeLabel.Name = "equipRangeLabel";
            this.equipRangeLabel.Size = new System.Drawing.Size(45, 13);
            this.equipRangeLabel.TabIndex = 127;
            this.equipRangeLabel.Text = "Range: ";
            // 
            // equipAPLabel
            // 
            this.equipAPLabel.AutoSize = true;
            this.equipAPLabel.Location = new System.Drawing.Point(226, 62);
            this.equipAPLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.equipAPLabel.Name = "equipAPLabel";
            this.equipAPLabel.Size = new System.Drawing.Size(27, 13);
            this.equipAPLabel.TabIndex = 126;
            this.equipAPLabel.Text = "AP: ";
            // 
            // removeEquipButton
            // 
            this.removeEquipButton.Location = new System.Drawing.Point(126, 359);
            this.removeEquipButton.Name = "removeEquipButton";
            this.removeEquipButton.Size = new System.Drawing.Size(94, 23);
            this.removeEquipButton.TabIndex = 3;
            this.removeEquipButton.Text = "Remove";
            this.removeEquipButton.UseVisualStyleBackColor = true;
            this.removeEquipButton.Click += new System.EventHandler(this.removeEquipButton_Click);
            // 
            // addEquipButton
            // 
            this.addEquipButton.Location = new System.Drawing.Point(6, 359);
            this.addEquipButton.Name = "addEquipButton";
            this.addEquipButton.Size = new System.Drawing.Size(94, 23);
            this.addEquipButton.TabIndex = 2;
            this.addEquipButton.Text = "Add Equipment";
            this.addEquipButton.UseVisualStyleBackColor = true;
            this.addEquipButton.Click += new System.EventHandler(this.addEquipButton_Click);
            // 
            // equipmentLabel
            // 
            this.equipmentLabel.AutoSize = true;
            this.equipmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentLabel.Location = new System.Drawing.Point(3, 8);
            this.equipmentLabel.Name = "equipmentLabel";
            this.equipmentLabel.Size = new System.Drawing.Size(66, 13);
            this.equipmentLabel.TabIndex = 123;
            this.equipmentLabel.Text = "Equipment";
            // 
            // miscEquipmentHeaderLabel
            // 
            this.miscEquipmentHeaderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.miscEquipmentHeaderLabel.AutoSize = true;
            this.miscEquipmentHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscEquipmentHeaderLabel.Location = new System.Drawing.Point(479, 9);
            this.miscEquipmentHeaderLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.miscEquipmentHeaderLabel.Name = "miscEquipmentHeaderLabel";
            this.miscEquipmentHeaderLabel.Size = new System.Drawing.Size(212, 13);
            this.miscEquipmentHeaderLabel.TabIndex = 51;
            this.miscEquipmentHeaderLabel.Text = "Miscellaneous Equipment and Notes";
            // 
            // equipmentTextBox
            // 
            this.equipmentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equipmentTextBox.Location = new System.Drawing.Point(482, 37);
            this.equipmentTextBox.Name = "equipmentTextBox";
            this.equipmentTextBox.Size = new System.Drawing.Size(337, 466);
            this.equipmentTextBox.TabIndex = 4;
            this.equipmentTextBox.Text = "";
            // 
            // cyberAndAugments
            // 
            this.cyberAndAugments.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cyberAndAugments.Controls.Add(this.augDetailsLabel);
            this.cyberAndAugments.Controls.Add(this.augRaceLabel);
            this.cyberAndAugments.Controls.Add(this.augHeaderLabel);
            this.cyberAndAugments.Controls.Add(this.removeAugButton);
            this.cyberAndAugments.Controls.Add(this.addAugButton);
            this.cyberAndAugments.Controls.Add(this.augmeticsBox);
            this.cyberAndAugments.Controls.Add(this.augmeticHeaderLabel);
            this.cyberAndAugments.Location = new System.Drawing.Point(4, 22);
            this.cyberAndAugments.Name = "cyberAndAugments";
            this.cyberAndAugments.Padding = new System.Windows.Forms.Padding(3);
            this.cyberAndAugments.Size = new System.Drawing.Size(825, 509);
            this.cyberAndAugments.TabIndex = 5;
            this.cyberAndAugments.Text = "Cybernetics";
            // 
            // augDetailsLabel
            // 
            this.augDetailsLabel.AutoSize = true;
            this.augDetailsLabel.Location = new System.Drawing.Point(240, 90);
            this.augDetailsLabel.Name = "augDetailsLabel";
            this.augDetailsLabel.Size = new System.Drawing.Size(42, 13);
            this.augDetailsLabel.TabIndex = 45;
            this.augDetailsLabel.Text = "Details:";
            // 
            // augRaceLabel
            // 
            this.augRaceLabel.AutoSize = true;
            this.augRaceLabel.Location = new System.Drawing.Point(241, 64);
            this.augRaceLabel.Name = "augRaceLabel";
            this.augRaceLabel.Size = new System.Drawing.Size(36, 13);
            this.augRaceLabel.TabIndex = 44;
            this.augRaceLabel.Text = "Race:";
            // 
            // augHeaderLabel
            // 
            this.augHeaderLabel.AutoSize = true;
            this.augHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.augHeaderLabel.Location = new System.Drawing.Point(240, 37);
            this.augHeaderLabel.Name = "augHeaderLabel";
            this.augHeaderLabel.Size = new System.Drawing.Size(91, 13);
            this.augHeaderLabel.TabIndex = 43;
            this.augHeaderLabel.Text = "Implant Details";
            // 
            // removeAugButton
            // 
            this.removeAugButton.Location = new System.Drawing.Point(126, 359);
            this.removeAugButton.Name = "removeAugButton";
            this.removeAugButton.Size = new System.Drawing.Size(94, 23);
            this.removeAugButton.TabIndex = 3;
            this.removeAugButton.Text = "Remove";
            this.removeAugButton.UseVisualStyleBackColor = true;
            this.removeAugButton.Click += new System.EventHandler(this.removeAugButton_Click);
            // 
            // addAugButton
            // 
            this.addAugButton.Location = new System.Drawing.Point(6, 359);
            this.addAugButton.Name = "addAugButton";
            this.addAugButton.Size = new System.Drawing.Size(94, 23);
            this.addAugButton.TabIndex = 2;
            this.addAugButton.Text = "Add Modification";
            this.addAugButton.UseVisualStyleBackColor = true;
            this.addAugButton.Click += new System.EventHandler(this.addAugButton_Click);
            // 
            // augmeticsBox
            // 
            this.augmeticsBox.FormattingEnabled = true;
            this.augmeticsBox.Location = new System.Drawing.Point(6, 37);
            this.augmeticsBox.Name = "augmeticsBox";
            this.augmeticsBox.Size = new System.Drawing.Size(214, 316);
            this.augmeticsBox.TabIndex = 1;
            this.augmeticsBox.SelectedIndexChanged += new System.EventHandler(this.augmeticsBox_SelectedIndexChanged);
            // 
            // augmeticHeaderLabel
            // 
            this.augmeticHeaderLabel.AutoSize = true;
            this.augmeticHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.augmeticHeaderLabel.Location = new System.Drawing.Point(3, 8);
            this.augmeticHeaderLabel.Name = "augmeticHeaderLabel";
            this.augmeticHeaderLabel.Size = new System.Drawing.Size(160, 13);
            this.augmeticHeaderLabel.TabIndex = 39;
            this.augmeticHeaderLabel.Text = "Augmetics and Cybernetics";
            // 
            // psychicpowers
            // 
            this.psychicpowers.AutoScroll = true;
            this.psychicpowers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.psychicpowers.Controls.Add(this.powerDisciplineLabel);
            this.psychicpowers.Controls.Add(this.powerKeywordsLabel);
            this.psychicpowers.Controls.Add(this.powerMultiLabel);
            this.psychicpowers.Controls.Add(this.powerRangeLabel);
            this.psychicpowers.Controls.Add(this.powerDurationLabel);
            this.psychicpowers.Controls.Add(this.powerActivationLabel);
            this.psychicpowers.Controls.Add(this.powerDNLabel);
            this.psychicpowers.Controls.Add(this.powerBPCostLabel);
            this.psychicpowers.Controls.Add(this.removePowerButton);
            this.psychicpowers.Controls.Add(this.addPowerButton);
            this.psychicpowers.Controls.Add(this.powerBox);
            this.psychicpowers.Controls.Add(this.psychicPowersLabel);
            this.psychicpowers.Controls.Add(this.label65);
            this.psychicpowers.Controls.Add(this.powersTextBox);
            this.psychicpowers.Location = new System.Drawing.Point(4, 22);
            this.psychicpowers.Name = "psychicpowers";
            this.psychicpowers.Padding = new System.Windows.Forms.Padding(3);
            this.psychicpowers.Size = new System.Drawing.Size(825, 509);
            this.psychicpowers.TabIndex = 3;
            this.psychicpowers.Text = "Psychic Powers";
            // 
            // powerDisciplineLabel
            // 
            this.powerDisciplineLabel.AutoSize = true;
            this.powerDisciplineLabel.Location = new System.Drawing.Point(226, 37);
            this.powerDisciplineLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.powerDisciplineLabel.Name = "powerDisciplineLabel";
            this.powerDisciplineLabel.Size = new System.Drawing.Size(55, 13);
            this.powerDisciplineLabel.TabIndex = 122;
            this.powerDisciplineLabel.Text = "Discipline:";
            // 
            // powerKeywordsLabel
            // 
            this.powerKeywordsLabel.AutoSize = true;
            this.powerKeywordsLabel.Location = new System.Drawing.Point(226, 212);
            this.powerKeywordsLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.powerKeywordsLabel.Name = "powerKeywordsLabel";
            this.powerKeywordsLabel.Size = new System.Drawing.Size(56, 13);
            this.powerKeywordsLabel.TabIndex = 121;
            this.powerKeywordsLabel.Text = "Keywords:";
            // 
            // powerMultiLabel
            // 
            this.powerMultiLabel.AutoSize = true;
            this.powerMultiLabel.Location = new System.Drawing.Point(226, 187);
            this.powerMultiLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.powerMultiLabel.Name = "powerMultiLabel";
            this.powerMultiLabel.Size = new System.Drawing.Size(66, 13);
            this.powerMultiLabel.TabIndex = 120;
            this.powerMultiLabel.Text = "Multi-Target:";
            // 
            // powerRangeLabel
            // 
            this.powerRangeLabel.AutoSize = true;
            this.powerRangeLabel.Location = new System.Drawing.Point(226, 162);
            this.powerRangeLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.powerRangeLabel.Name = "powerRangeLabel";
            this.powerRangeLabel.Size = new System.Drawing.Size(42, 13);
            this.powerRangeLabel.TabIndex = 119;
            this.powerRangeLabel.Text = "Range:";
            // 
            // powerDurationLabel
            // 
            this.powerDurationLabel.AutoSize = true;
            this.powerDurationLabel.Location = new System.Drawing.Point(226, 137);
            this.powerDurationLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.powerDurationLabel.Name = "powerDurationLabel";
            this.powerDurationLabel.Size = new System.Drawing.Size(50, 13);
            this.powerDurationLabel.TabIndex = 118;
            this.powerDurationLabel.Text = "Duration:";
            // 
            // powerActivationLabel
            // 
            this.powerActivationLabel.AutoSize = true;
            this.powerActivationLabel.Location = new System.Drawing.Point(226, 112);
            this.powerActivationLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.powerActivationLabel.Name = "powerActivationLabel";
            this.powerActivationLabel.Size = new System.Drawing.Size(57, 13);
            this.powerActivationLabel.TabIndex = 117;
            this.powerActivationLabel.Text = "Activation:";
            // 
            // powerDNLabel
            // 
            this.powerDNLabel.AutoSize = true;
            this.powerDNLabel.Location = new System.Drawing.Point(226, 87);
            this.powerDNLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.powerDNLabel.Name = "powerDNLabel";
            this.powerDNLabel.Size = new System.Drawing.Size(29, 13);
            this.powerDNLabel.TabIndex = 116;
            this.powerDNLabel.Text = "DN: ";
            // 
            // powerBPCostLabel
            // 
            this.powerBPCostLabel.AutoSize = true;
            this.powerBPCostLabel.Location = new System.Drawing.Point(226, 62);
            this.powerBPCostLabel.Margin = new System.Windows.Forms.Padding(3, 12, 3, 0);
            this.powerBPCostLabel.Name = "powerBPCostLabel";
            this.powerBPCostLabel.Size = new System.Drawing.Size(48, 13);
            this.powerBPCostLabel.TabIndex = 115;
            this.powerBPCostLabel.Text = "BP Cost:";
            // 
            // removePowerButton
            // 
            this.removePowerButton.Location = new System.Drawing.Point(126, 359);
            this.removePowerButton.Name = "removePowerButton";
            this.removePowerButton.Size = new System.Drawing.Size(94, 23);
            this.removePowerButton.TabIndex = 3;
            this.removePowerButton.Text = "Remove";
            this.removePowerButton.UseVisualStyleBackColor = true;
            this.removePowerButton.Click += new System.EventHandler(this.removePowerButton_Click);
            // 
            // addPowerButton
            // 
            this.addPowerButton.Location = new System.Drawing.Point(6, 359);
            this.addPowerButton.Name = "addPowerButton";
            this.addPowerButton.Size = new System.Drawing.Size(94, 23);
            this.addPowerButton.TabIndex = 2;
            this.addPowerButton.Text = "Add Power";
            this.addPowerButton.UseVisualStyleBackColor = true;
            this.addPowerButton.Click += new System.EventHandler(this.addPowerButton_Click);
            // 
            // powerBox
            // 
            this.powerBox.FormattingEnabled = true;
            this.powerBox.Location = new System.Drawing.Point(6, 37);
            this.powerBox.Name = "powerBox";
            this.powerBox.Size = new System.Drawing.Size(214, 316);
            this.powerBox.TabIndex = 1;
            this.powerBox.SelectedIndexChanged += new System.EventHandler(this.powerBox_SelectedIndexChanged);
            // 
            // psychicPowersLabel
            // 
            this.psychicPowersLabel.AutoSize = true;
            this.psychicPowersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.psychicPowersLabel.Location = new System.Drawing.Point(3, 8);
            this.psychicPowersLabel.Name = "psychicPowersLabel";
            this.psychicPowersLabel.Size = new System.Drawing.Size(96, 13);
            this.psychicPowersLabel.TabIndex = 111;
            this.psychicPowersLabel.Text = "Psychic Powers";
            // 
            // label65
            // 
            this.label65.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(479, 8);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(79, 13);
            this.label65.TabIndex = 110;
            this.label65.Text = "Power Notes";
            // 
            // powersTextBox
            // 
            this.powersTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.powersTextBox.Location = new System.Drawing.Point(482, 37);
            this.powersTextBox.MinimumSize = new System.Drawing.Size(100, 100);
            this.powersTextBox.Name = "powersTextBox";
            this.powersTextBox.Size = new System.Drawing.Size(337, 466);
            this.powersTextBox.TabIndex = 4;
            this.powersTextBox.Text = "";
            // 
            // notes
            // 
            this.notes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.notes.Controls.Add(this.notesTextBox);
            this.notes.Location = new System.Drawing.Point(4, 22);
            this.notes.Name = "notes";
            this.notes.Padding = new System.Windows.Forms.Padding(3);
            this.notes.Size = new System.Drawing.Size(825, 509);
            this.notes.TabIndex = 4;
            this.notes.Text = "Notes";
            // 
            // notesTextBox
            // 
            this.notesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notesTextBox.Location = new System.Drawing.Point(3, 3);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(819, 503);
            this.notesTextBox.TabIndex = 0;
            this.notesTextBox.Text = "";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.summary);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(0, 0);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(342, 535);
            this.tabControl2.TabIndex = 0;
            // 
            // summary
            // 
            this.summary.AutoScroll = true;
            this.summary.BackColor = System.Drawing.Color.WhiteSmoke;
            this.summary.Controls.Add(this.objectiveLabel);
            this.summary.Controls.Add(this.lifetimeBPEarnedLabel);
            this.summary.Controls.Add(this.rankTraitLabel);
            this.summary.Controls.Add(this.woundsTotalLabel);
            this.summary.Controls.Add(this.shockTotalLabel);
            this.summary.Controls.Add(this.textBox2);
            this.summary.Controls.Add(this.textBox1);
            this.summary.Controls.Add(this.damageTrackLabel);
            this.summary.Controls.Add(this.socialTraitsLabel);
            this.summary.Controls.Add(this.mentalTraitsLabel);
            this.summary.Controls.Add(this.combatTraitsLabel);
            this.summary.Controls.Add(this.wealthTraitLabel);
            this.summary.Controls.Add(this.resolveTraitLabel);
            this.summary.Controls.Add(this.corruptionTraitLabel);
            this.summary.Controls.Add(this.woundsTraitLabel);
            this.summary.Controls.Add(this.shockTraitLabel);
            this.summary.Controls.Add(this.soakTraitLabel);
            this.summary.Controls.Add(this.influenceTraitLabel);
            this.summary.Controls.Add(this.passiveAwarenessTraitLabel);
            this.summary.Controls.Add(this.convictionTraitLabel);
            this.summary.Controls.Add(this.speedTraitLabel);
            this.summary.Controls.Add(this.resilienceTraitLabel);
            this.summary.Controls.Add(this.defenceTraitLabel);
            this.summary.Controls.Add(this.traitsLabel);
            this.summary.Location = new System.Drawing.Point(4, 22);
            this.summary.Name = "summary";
            this.summary.Padding = new System.Windows.Forms.Padding(3);
            this.summary.Size = new System.Drawing.Size(334, 509);
            this.summary.TabIndex = 0;
            this.summary.Text = "Summary";
            // 
            // objectiveLabel
            // 
            this.objectiveLabel.AutoSize = true;
            this.objectiveLabel.Location = new System.Drawing.Point(6, 394);
            this.objectiveLabel.Name = "objectiveLabel";
            this.objectiveLabel.Size = new System.Drawing.Size(60, 13);
            this.objectiveLabel.TabIndex = 46;
            this.objectiveLabel.Text = "Objectives:";
            // 
            // lifetimeBPEarnedLabel
            // 
            this.lifetimeBPEarnedLabel.AutoSize = true;
            this.lifetimeBPEarnedLabel.Location = new System.Drawing.Point(6, 359);
            this.lifetimeBPEarnedLabel.Name = "lifetimeBPEarnedLabel";
            this.lifetimeBPEarnedLabel.Size = new System.Drawing.Size(63, 13);
            this.lifetimeBPEarnedLabel.TabIndex = 45;
            this.lifetimeBPEarnedLabel.Text = "Lifetime BP:";
            // 
            // rankTraitLabel
            // 
            this.rankTraitLabel.AutoSize = true;
            this.rankTraitLabel.Location = new System.Drawing.Point(6, 324);
            this.rankTraitLabel.Name = "rankTraitLabel";
            this.rankTraitLabel.Size = new System.Drawing.Size(33, 13);
            this.rankTraitLabel.TabIndex = 44;
            this.rankTraitLabel.Text = "Rank";
            // 
            // woundsTotalLabel
            // 
            this.woundsTotalLabel.AutoSize = true;
            this.woundsTotalLabel.Location = new System.Drawing.Point(96, 67);
            this.woundsTotalLabel.Name = "woundsTotalLabel";
            this.woundsTotalLabel.Size = new System.Drawing.Size(24, 13);
            this.woundsTotalLabel.TabIndex = 20;
            this.woundsTotalLabel.Text = "/19";
            // 
            // shockTotalLabel
            // 
            this.shockTotalLabel.AutoSize = true;
            this.shockTotalLabel.Location = new System.Drawing.Point(243, 67);
            this.shockTotalLabel.Name = "shockTotalLabel";
            this.shockTotalLabel.Size = new System.Drawing.Size(24, 13);
            this.shockTotalLabel.TabIndex = 19;
            this.shockTotalLabel.Text = "/19";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(59, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(36, 20);
            this.textBox2.TabIndex = 35;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 20);
            this.textBox1.TabIndex = 36;
            // 
            // damageTrackLabel
            // 
            this.damageTrackLabel.AutoSize = true;
            this.damageTrackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.damageTrackLabel.Location = new System.Drawing.Point(6, 40);
            this.damageTrackLabel.Name = "damageTrackLabel";
            this.damageTrackLabel.Size = new System.Drawing.Size(90, 13);
            this.damageTrackLabel.TabIndex = 16;
            this.damageTrackLabel.Text = "Damage Track";
            // 
            // socialTraitsLabel
            // 
            this.socialTraitsLabel.AutoSize = true;
            this.socialTraitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.socialTraitsLabel.Location = new System.Drawing.Point(6, 274);
            this.socialTraitsLabel.Name = "socialTraitsLabel";
            this.socialTraitsLabel.Size = new System.Drawing.Size(78, 13);
            this.socialTraitsLabel.TabIndex = 15;
            this.socialTraitsLabel.Text = "Social Traits";
            // 
            // mentalTraitsLabel
            // 
            this.mentalTraitsLabel.AutoSize = true;
            this.mentalTraitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mentalTraitsLabel.Location = new System.Drawing.Point(6, 190);
            this.mentalTraitsLabel.Name = "mentalTraitsLabel";
            this.mentalTraitsLabel.Size = new System.Drawing.Size(81, 13);
            this.mentalTraitsLabel.TabIndex = 14;
            this.mentalTraitsLabel.Text = "Mental Traits";
            // 
            // combatTraitsLabel
            // 
            this.combatTraitsLabel.AutoSize = true;
            this.combatTraitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combatTraitsLabel.Location = new System.Drawing.Point(6, 103);
            this.combatTraitsLabel.Name = "combatTraitsLabel";
            this.combatTraitsLabel.Size = new System.Drawing.Size(85, 13);
            this.combatTraitsLabel.TabIndex = 13;
            this.combatTraitsLabel.Text = "Combat Traits";
            // 
            // wealthTraitLabel
            // 
            this.wealthTraitLabel.AutoSize = true;
            this.wealthTraitLabel.Location = new System.Drawing.Point(164, 299);
            this.wealthTraitLabel.Name = "wealthTraitLabel";
            this.wealthTraitLabel.Size = new System.Drawing.Size(41, 13);
            this.wealthTraitLabel.TabIndex = 12;
            this.wealthTraitLabel.Text = "Wealth";
            // 
            // resolveTraitLabel
            // 
            this.resolveTraitLabel.AutoSize = true;
            this.resolveTraitLabel.Location = new System.Drawing.Point(164, 240);
            this.resolveTraitLabel.Name = "resolveTraitLabel";
            this.resolveTraitLabel.Size = new System.Drawing.Size(46, 13);
            this.resolveTraitLabel.TabIndex = 11;
            this.resolveTraitLabel.Text = "Resolve";
            // 
            // corruptionTraitLabel
            // 
            this.corruptionTraitLabel.AutoSize = true;
            this.corruptionTraitLabel.Location = new System.Drawing.Point(164, 216);
            this.corruptionTraitLabel.Name = "corruptionTraitLabel";
            this.corruptionTraitLabel.Size = new System.Drawing.Size(55, 13);
            this.corruptionTraitLabel.TabIndex = 10;
            this.corruptionTraitLabel.Text = "Corruption";
            // 
            // woundsTraitLabel
            // 
            this.woundsTraitLabel.AutoSize = true;
            this.woundsTraitLabel.Location = new System.Drawing.Point(6, 67);
            this.woundsTraitLabel.Name = "woundsTraitLabel";
            this.woundsTraitLabel.Size = new System.Drawing.Size(47, 13);
            this.woundsTraitLabel.TabIndex = 9;
            this.woundsTraitLabel.Text = "Wounds";
            // 
            // shockTraitLabel
            // 
            this.shockTraitLabel.AutoSize = true;
            this.shockTraitLabel.Location = new System.Drawing.Point(164, 67);
            this.shockTraitLabel.Name = "shockTraitLabel";
            this.shockTraitLabel.Size = new System.Drawing.Size(38, 13);
            this.shockTraitLabel.TabIndex = 8;
            this.shockTraitLabel.Text = "Shock";
            // 
            // soakTraitLabel
            // 
            this.soakTraitLabel.AutoSize = true;
            this.soakTraitLabel.Location = new System.Drawing.Point(164, 130);
            this.soakTraitLabel.Name = "soakTraitLabel";
            this.soakTraitLabel.Size = new System.Drawing.Size(32, 13);
            this.soakTraitLabel.TabIndex = 7;
            this.soakTraitLabel.Text = "Soak";
            // 
            // influenceTraitLabel
            // 
            this.influenceTraitLabel.AutoSize = true;
            this.influenceTraitLabel.Location = new System.Drawing.Point(6, 299);
            this.influenceTraitLabel.Name = "influenceTraitLabel";
            this.influenceTraitLabel.Size = new System.Drawing.Size(51, 13);
            this.influenceTraitLabel.TabIndex = 6;
            this.influenceTraitLabel.Text = "Influence";
            // 
            // passiveAwarenessTraitLabel
            // 
            this.passiveAwarenessTraitLabel.AutoSize = true;
            this.passiveAwarenessTraitLabel.Location = new System.Drawing.Point(6, 240);
            this.passiveAwarenessTraitLabel.Name = "passiveAwarenessTraitLabel";
            this.passiveAwarenessTraitLabel.Size = new System.Drawing.Size(99, 13);
            this.passiveAwarenessTraitLabel.TabIndex = 5;
            this.passiveAwarenessTraitLabel.Text = "Passive Awareness";
            // 
            // convictionTraitLabel
            // 
            this.convictionTraitLabel.AutoSize = true;
            this.convictionTraitLabel.Location = new System.Drawing.Point(6, 215);
            this.convictionTraitLabel.Name = "convictionTraitLabel";
            this.convictionTraitLabel.Size = new System.Drawing.Size(57, 13);
            this.convictionTraitLabel.TabIndex = 4;
            this.convictionTraitLabel.Text = "Conviction";
            // 
            // speedTraitLabel
            // 
            this.speedTraitLabel.AutoSize = true;
            this.speedTraitLabel.Location = new System.Drawing.Point(164, 155);
            this.speedTraitLabel.Name = "speedTraitLabel";
            this.speedTraitLabel.Size = new System.Drawing.Size(38, 13);
            this.speedTraitLabel.TabIndex = 3;
            this.speedTraitLabel.Text = "Speed";
            // 
            // resilienceTraitLabel
            // 
            this.resilienceTraitLabel.AutoSize = true;
            this.resilienceTraitLabel.Location = new System.Drawing.Point(6, 155);
            this.resilienceTraitLabel.Name = "resilienceTraitLabel";
            this.resilienceTraitLabel.Size = new System.Drawing.Size(56, 13);
            this.resilienceTraitLabel.TabIndex = 2;
            this.resilienceTraitLabel.Text = "Resilience";
            // 
            // defenceTraitLabel
            // 
            this.defenceTraitLabel.AutoSize = true;
            this.defenceTraitLabel.Location = new System.Drawing.Point(6, 128);
            this.defenceTraitLabel.Name = "defenceTraitLabel";
            this.defenceTraitLabel.Size = new System.Drawing.Size(48, 13);
            this.defenceTraitLabel.TabIndex = 1;
            this.defenceTraitLabel.Text = "Defence";
            // 
            // traitsLabel
            // 
            this.traitsLabel.AutoSize = true;
            this.traitsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traitsLabel.Location = new System.Drawing.Point(6, 6);
            this.traitsLabel.Name = "traitsLabel";
            this.traitsLabel.Size = new System.Drawing.Size(39, 13);
            this.traitsLabel.TabIndex = 0;
            this.traitsLabel.Text = "Traits";
            // 
            // equipModMenu
            // 
            this.equipModMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addModToolStripMenuItem});
            this.equipModMenu.Name = "contextMenuStrip1";
            this.equipModMenu.Size = new System.Drawing.Size(125, 26);
            // 
            // addModToolStripMenuItem
            // 
            this.addModToolStripMenuItem.Name = "addModToolStripMenuItem";
            this.addModToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.addModToolStripMenuItem.Text = "Add Mod";
            this.addModToolStripMenuItem.Click += new System.EventHandler(this.addModToolStripMenuItem_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1186, 585);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "mainForm";
            this.Text = "The Commissar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_FormClosing_1);
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
            ((System.ComponentModel.ISupportInitialize)(this.shockValueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woundsValueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.influenceValueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolveValueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passiveAwarenessValueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.convictionValueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resilienceValueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soakValueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defenceValueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attSpeedModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attInitiativeModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attFellowshipModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attWillpowerModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attIntellectModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attToughnessModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attAgilityModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attStrengthModifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corruptionValueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wealthValueBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rankValueBox)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.skillWeaponSkillBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillTechBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillSurvivalBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillStealthBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillScholarBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillPsychicBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillPilotBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillPersuasionBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillMedicaeBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillLeadershipBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillInvestigationBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillIntimidationBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillInsightBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillDeceptionBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillCunningBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillBallisticBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillAwarenessBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillAthleticsBonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillWeaponSkill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillTech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillSurvival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillStealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillScholar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillPsychic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillPilot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillPersuasion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillMedicae)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillLeadership)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillInvestigation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillIntimidation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillInsight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillDeception)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillCunning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillBallstic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillAwareness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.skillAthletics)).EndInit();
            this.equipment.ResumeLayout(false);
            this.equipment.PerformLayout();
            this.cyberAndAugments.ResumeLayout(false);
            this.cyberAndAugments.PerformLayout();
            this.psychicpowers.ResumeLayout(false);
            this.psychicpowers.PerformLayout();
            this.notes.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.summary.ResumeLayout(false);
            this.summary.PerformLayout();
            this.equipModMenu.ResumeLayout(false);
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
        private System.Windows.Forms.Label skillNotesLabel;
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
        private System.Windows.Forms.Label socialTraitsLabel;
        private System.Windows.Forms.Label mentalTraitsLabel;
        private System.Windows.Forms.Label combatTraitsLabel;
        private System.Windows.Forms.Label wealthTraitLabel;
        private System.Windows.Forms.Label resolveTraitLabel;
        private System.Windows.Forms.Label corruptionTraitLabel;
        private System.Windows.Forms.Label woundsTraitLabel;
        private System.Windows.Forms.Label shockTraitLabel;
        private System.Windows.Forms.Label soakTraitLabel;
        private System.Windows.Forms.Label influenceTraitLabel;
        private System.Windows.Forms.Label passiveAwarenessTraitLabel;
        private System.Windows.Forms.Label convictionTraitLabel;
        private System.Windows.Forms.Label speedTraitLabel;
        private System.Windows.Forms.Label resilienceTraitLabel;
        private System.Windows.Forms.Label defenceTraitLabel;
        private System.Windows.Forms.Label traitsLabel;
        private System.Windows.Forms.Label woundsTotalLabel;
        private System.Windows.Forms.Label shockTotalLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label damageTrackLabel;
        private System.Windows.Forms.NumericUpDown wealthValueBox;
        private System.Windows.Forms.NumericUpDown rankValueBox;
        private System.Windows.Forms.Label wealthValueLabel;
        private System.Windows.Forms.Label rankValueLabel;
        private System.Windows.Forms.Label rankTraitLabel;
        private System.Windows.Forms.NumericUpDown corruptionValueBox;
        private System.Windows.Forms.Label corruptionValueLabel;
        private System.Windows.Forms.Label lifetimeBPEarnedLabel;
        private System.Windows.Forms.NumericUpDown attSpeedModifier;
        private System.Windows.Forms.NumericUpDown attInitiativeModifier;
        private System.Windows.Forms.NumericUpDown attFellowshipModifier;
        private System.Windows.Forms.NumericUpDown attWillpowerModifier;
        private System.Windows.Forms.NumericUpDown attIntellectModifier;
        private System.Windows.Forms.NumericUpDown attToughnessModifier;
        private System.Windows.Forms.NumericUpDown attAgilityModifier;
        private System.Windows.Forms.NumericUpDown attStrengthModifier;
        private System.Windows.Forms.Label attModiferLabel;
        private System.Windows.Forms.NumericUpDown defenceValueBox;
        private System.Windows.Forms.Label defenceBonusLabel;
        private System.Windows.Forms.NumericUpDown soakValueBox;
        private System.Windows.Forms.Label soakBonusLabel;
        private System.Windows.Forms.Label rankAndBonusLabel;
        private System.Windows.Forms.NumericUpDown influenceValueBox;
        private System.Windows.Forms.NumericUpDown resolveValueBox;
        private System.Windows.Forms.Label influenceBonusLabel;
        private System.Windows.Forms.Label resolveBonusLabel;
        private System.Windows.Forms.NumericUpDown passiveAwarenessValueBox;
        private System.Windows.Forms.Label passiveAwarenessBonusLabel;
        private System.Windows.Forms.NumericUpDown convictionValueBox;
        private System.Windows.Forms.Label convictionBonusLabel;
        private System.Windows.Forms.NumericUpDown resilienceValueBox;
        private System.Windows.Forms.Label resilienceBonusLabel;
        private System.Windows.Forms.NumericUpDown shockValueBox;
        private System.Windows.Forms.Label shockBonusLabel;
        private System.Windows.Forms.NumericUpDown woundsValueBox;
        private System.Windows.Forms.Label woundsBonusLabel;
        private System.Windows.Forms.ToolTip calcValuesToolTip;
        private System.Windows.Forms.NumericUpDown skillWeaponSkillBonus;
        private System.Windows.Forms.NumericUpDown skillTechBonus;
        private System.Windows.Forms.NumericUpDown skillSurvivalBonus;
        private System.Windows.Forms.NumericUpDown skillStealthBonus;
        private System.Windows.Forms.NumericUpDown skillScholarBonus;
        private System.Windows.Forms.NumericUpDown skillPsychicBonus;
        private System.Windows.Forms.NumericUpDown skillPilotBonus;
        private System.Windows.Forms.NumericUpDown skillPersuasionBonus;
        private System.Windows.Forms.NumericUpDown skillMedicaeBonus;
        private System.Windows.Forms.NumericUpDown skillLeadershipBonus;
        private System.Windows.Forms.NumericUpDown skillInvestigationBonus;
        private System.Windows.Forms.NumericUpDown skillIntimidationBonus;
        private System.Windows.Forms.NumericUpDown skillInsightBonus;
        private System.Windows.Forms.NumericUpDown skillDeceptionBonus;
        private System.Windows.Forms.NumericUpDown skillCunningBonus;
        private System.Windows.Forms.NumericUpDown skillBallisticBonus;
        private System.Windows.Forms.NumericUpDown skillAwarenessBonus;
        private System.Windows.Forms.NumericUpDown skillAthleticsBonus;
        private System.Windows.Forms.TabPage cyberAndAugments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeAugButton;
        private System.Windows.Forms.Button addAugButton;
        private System.Windows.Forms.ListBox augmeticsBox;
        private System.Windows.Forms.Label augmeticHeaderLabel;
        private System.Windows.Forms.Label augDetailsLabel;
        private System.Windows.Forms.Label augRaceLabel;
        private System.Windows.Forms.Label augHeaderLabel;
        private System.Windows.Forms.Label powerKeywordsLabel;
        private System.Windows.Forms.Label powerMultiLabel;
        private System.Windows.Forms.Label powerRangeLabel;
        private System.Windows.Forms.Label powerDurationLabel;
        private System.Windows.Forms.Label powerActivationLabel;
        private System.Windows.Forms.Label powerDNLabel;
        private System.Windows.Forms.Label powerBPCostLabel;
        private System.Windows.Forms.Button removePowerButton;
        private System.Windows.Forms.Button addPowerButton;
        private System.Windows.Forms.ListBox powerBox;
        private System.Windows.Forms.Label psychicPowersLabel;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.RichTextBox powersTextBox;
        private System.Windows.Forms.Label powerDisciplineLabel;
        private System.Windows.Forms.ToolStripStatusLabel bpSpentOnPowersLabel;
        private System.Windows.Forms.TreeView equipTreeBox;
        private System.Windows.Forms.Label equipDamageLabel;
        private System.Windows.Forms.Label equipArmorRatingLabel;
        private System.Windows.Forms.Label equipKeywordsLabel;
        private System.Windows.Forms.Label equipValueLabel;
        private System.Windows.Forms.Label equipTraitsLabel;
        private System.Windows.Forms.Label equipSalvoLabel;
        private System.Windows.Forms.Label equipRangeLabel;
        private System.Windows.Forms.Label equipAPLabel;
        private System.Windows.Forms.Button removeEquipButton;
        private System.Windows.Forms.Button addEquipButton;
        private System.Windows.Forms.Label equipmentLabel;
        private System.Windows.Forms.Label miscEquipmentHeaderLabel;
        private System.Windows.Forms.RichTextBox equipmentTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label objectiveLabel;
        private System.Windows.Forms.ContextMenuStrip equipModMenu;
        private System.Windows.Forms.ToolStripMenuItem addModToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCharacterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkCharacterValidityToolStripMenuItem;
        private System.Windows.Forms.Label archInfoLabel;
        private System.Windows.Forms.Label archetypeInfoHeaderLabel;
    }
}

