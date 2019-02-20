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
            this.bpSpentAttribLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.bpSpentSkillsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.bpSpentRaceLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.bpSpentArchetypeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.core = new System.Windows.Forms.TabPage();
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
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.armorNameLabel = new System.Windows.Forms.Label();
            this.armorRatingBox = new System.Windows.Forms.NumericUpDown();
            this.armorRatingHeaderLabel = new System.Windows.Forms.Label();
            this.armorKeywordsBox = new System.Windows.Forms.TextBox();
            this.armorValueBox = new System.Windows.Forms.TextBox();
            this.armorTraitsBox = new System.Windows.Forms.TextBox();
            this.armorNameBox = new System.Windows.Forms.TextBox();
            this.meleeWeaponKeywordsBox = new System.Windows.Forms.TextBox();
            this.meleeWeaponValueBox = new System.Windows.Forms.TextBox();
            this.meleeWeaponTraitsBox = new System.Windows.Forms.TextBox();
            this.MeleeWeaponRangeBox = new System.Windows.Forms.TextBox();
            this.meleeWeaponAPBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.meleeWeaponEDBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.meleeWeaponDamageBox = new System.Windows.Forms.TextBox();
            this.meleeWeaponNameBox = new System.Windows.Forms.TextBox();
            this.meleeWeaponHeaderLabel = new System.Windows.Forms.Label();
            this.rangedWeaponKeywordsBox = new System.Windows.Forms.TextBox();
            this.keywordsHeaderLabel = new System.Windows.Forms.Label();
            this.rangedWeaponValueBox = new System.Windows.Forms.TextBox();
            this.rangedWeaponTraitBox = new System.Windows.Forms.TextBox();
            this.rangedWeaponSalvoBox = new System.Windows.Forms.TextBox();
            this.rangedWeaponRangeBox = new System.Windows.Forms.TextBox();
            this.rangedWeaponAPBox = new System.Windows.Forms.TextBox();
            this.rangedEDBoxLabel = new System.Windows.Forms.Label();
            this.rangedWeaponEDBox = new System.Windows.Forms.TextBox();
            this.rangedBaseModLabel = new System.Windows.Forms.Label();
            this.rangedWeaponDamageBox = new System.Windows.Forms.TextBox();
            this.rangedWeaponNameBox = new System.Windows.Forms.TextBox();
            this.weaponValueHeaderLabel = new System.Windows.Forms.Label();
            this.weaponTraitsHeaderLabel = new System.Windows.Forms.Label();
            this.salvoHeaderLabel = new System.Windows.Forms.Label();
            this.weaponRangeHeaderLabel = new System.Windows.Forms.Label();
            this.apHeaderLabel = new System.Windows.Forms.Label();
            this.weaponDamageHeaderLabel = new System.Windows.Forms.Label();
            this.rangedWeaponHeaderLabel = new System.Windows.Forms.Label();
            this.armorHeaderLabel = new System.Windows.Forms.Label();
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.powerPotencyBox24 = new System.Windows.Forms.TextBox();
            this.powerPotencyBox23 = new System.Windows.Forms.TextBox();
            this.powerPotencyBox22 = new System.Windows.Forms.TextBox();
            this.powerPotencyBox21 = new System.Windows.Forms.TextBox();
            this.powerPotencyBox20 = new System.Windows.Forms.TextBox();
            this.powerPotencyBox19 = new System.Windows.Forms.TextBox();
            this.powerPotencyBox18 = new System.Windows.Forms.TextBox();
            this.powerPotencyBox17 = new System.Windows.Forms.TextBox();
            this.powerPotencyBox16 = new System.Windows.Forms.TextBox();
            this.powerPotencyBox15 = new System.Windows.Forms.TextBox();
            this.powerPotencyBox14 = new System.Windows.Forms.TextBox();
            this.powerPotencyBox13 = new System.Windows.Forms.TextBox();
            this.powerPotencyBox12 = new System.Windows.Forms.TextBox();
            this.powerPotencyBox11 = new System.Windows.Forms.TextBox();
            this.powerPotencyBox10 = new System.Windows.Forms.TextBox();
            this.powerPotencyBox9 = new System.Windows.Forms.TextBox();
            this.powerPotencyBox8 = new System.Windows.Forms.TextBox();
            this.powerPotencyBox7 = new System.Windows.Forms.TextBox();
            this.powerPotencyBox6 = new System.Windows.Forms.TextBox();
            this.powerPotencyBox5 = new System.Windows.Forms.TextBox();
            this.powerPotencyBox4 = new System.Windows.Forms.TextBox();
            this.powerPotencyBox3 = new System.Windows.Forms.TextBox();
            this.powerPotencyBox2 = new System.Windows.Forms.TextBox();
            this.powerPotencyBox1 = new System.Windows.Forms.TextBox();
            this.powerPotentcyLabel = new System.Windows.Forms.Label();
            this.powerMultiCheckBox24 = new System.Windows.Forms.CheckBox();
            this.powerDurationBox24 = new System.Windows.Forms.TextBox();
            this.powerKeywordBox24 = new System.Windows.Forms.TextBox();
            this.powerDNBox24 = new System.Windows.Forms.TextBox();
            this.powerRangeBox24 = new System.Windows.Forms.TextBox();
            this.powerActivationBox24 = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.powerEDBox24 = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.powerDamageBox24 = new System.Windows.Forms.TextBox();
            this.powerNameBox24 = new System.Windows.Forms.TextBox();
            this.powerMultiCheckBox23 = new System.Windows.Forms.CheckBox();
            this.powerDurationBox23 = new System.Windows.Forms.TextBox();
            this.powerKeywordBox23 = new System.Windows.Forms.TextBox();
            this.powerDNBox23 = new System.Windows.Forms.TextBox();
            this.powerRangeBox23 = new System.Windows.Forms.TextBox();
            this.powerActivationBox23 = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.powerEDBox23 = new System.Windows.Forms.TextBox();
            this.label60 = new System.Windows.Forms.Label();
            this.powerDamageBox23 = new System.Windows.Forms.TextBox();
            this.powerNameBox23 = new System.Windows.Forms.TextBox();
            this.powerMultiCheckBox22 = new System.Windows.Forms.CheckBox();
            this.powerDurationBox22 = new System.Windows.Forms.TextBox();
            this.powerKeywordBox22 = new System.Windows.Forms.TextBox();
            this.powerDNBox22 = new System.Windows.Forms.TextBox();
            this.powerRangeBox22 = new System.Windows.Forms.TextBox();
            this.powerActivationBox22 = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.powerEDBox22 = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.powerDamageBox22 = new System.Windows.Forms.TextBox();
            this.powerNameBox22 = new System.Windows.Forms.TextBox();
            this.powerMultiCheckBox21 = new System.Windows.Forms.CheckBox();
            this.powerDurationBox21 = new System.Windows.Forms.TextBox();
            this.powerKeywordBox21 = new System.Windows.Forms.TextBox();
            this.powerDNBox21 = new System.Windows.Forms.TextBox();
            this.powerRangeBox21 = new System.Windows.Forms.TextBox();
            this.powerActivationBox21 = new System.Windows.Forms.TextBox();
            this.label63 = new System.Windows.Forms.Label();
            this.powerEDBox21 = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.powerDamageBox21 = new System.Windows.Forms.TextBox();
            this.powerNameBox21 = new System.Windows.Forms.TextBox();
            this.powerMultiCheckBox20 = new System.Windows.Forms.CheckBox();
            this.powerDurationBox20 = new System.Windows.Forms.TextBox();
            this.powerKeywordBox20 = new System.Windows.Forms.TextBox();
            this.powerDNBox20 = new System.Windows.Forms.TextBox();
            this.powerRangeBox20 = new System.Windows.Forms.TextBox();
            this.powerActivationBox20 = new System.Windows.Forms.TextBox();
            this.label51 = new System.Windows.Forms.Label();
            this.powerEDBox20 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.powerDamageBox20 = new System.Windows.Forms.TextBox();
            this.powerNameBox20 = new System.Windows.Forms.TextBox();
            this.powerMultiCheckBox19 = new System.Windows.Forms.CheckBox();
            this.powerDurationBox19 = new System.Windows.Forms.TextBox();
            this.powerKeywordBox19 = new System.Windows.Forms.TextBox();
            this.powerDNBox19 = new System.Windows.Forms.TextBox();
            this.powerRangeBox19 = new System.Windows.Forms.TextBox();
            this.powerActivationBox19 = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.powerEDBox19 = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.powerDamageBox19 = new System.Windows.Forms.TextBox();
            this.powerNameBox19 = new System.Windows.Forms.TextBox();
            this.powerMultiCheckBox18 = new System.Windows.Forms.CheckBox();
            this.powerDurationBox18 = new System.Windows.Forms.TextBox();
            this.powerKeywordBox18 = new System.Windows.Forms.TextBox();
            this.powerDNBox18 = new System.Windows.Forms.TextBox();
            this.powerRangeBox18 = new System.Windows.Forms.TextBox();
            this.powerActivationBox18 = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.powerEDBox18 = new System.Windows.Forms.TextBox();
            this.label56 = new System.Windows.Forms.Label();
            this.powerDamageBox18 = new System.Windows.Forms.TextBox();
            this.powerNameBox18 = new System.Windows.Forms.TextBox();
            this.powerMultiCheckBox17 = new System.Windows.Forms.CheckBox();
            this.powerDurationBox17 = new System.Windows.Forms.TextBox();
            this.powerKeywordBox17 = new System.Windows.Forms.TextBox();
            this.powerDNBox17 = new System.Windows.Forms.TextBox();
            this.powerRangeBox17 = new System.Windows.Forms.TextBox();
            this.powerActivationBox17 = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.powerEDBox17 = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.powerDamageBox17 = new System.Windows.Forms.TextBox();
            this.powerNameBox17 = new System.Windows.Forms.TextBox();
            this.powerMultiCheckBox16 = new System.Windows.Forms.CheckBox();
            this.powerDurationBox16 = new System.Windows.Forms.TextBox();
            this.powerKeywordBox16 = new System.Windows.Forms.TextBox();
            this.powerDNBox16 = new System.Windows.Forms.TextBox();
            this.powerRangeBox16 = new System.Windows.Forms.TextBox();
            this.powerActivationBox16 = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.powerEDBox16 = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.powerDamageBox16 = new System.Windows.Forms.TextBox();
            this.powerNameBox16 = new System.Windows.Forms.TextBox();
            this.powerMultiCheckBox15 = new System.Windows.Forms.CheckBox();
            this.powerDurationBox15 = new System.Windows.Forms.TextBox();
            this.powerKeywordBox15 = new System.Windows.Forms.TextBox();
            this.powerDNBox15 = new System.Windows.Forms.TextBox();
            this.powerRangeBox15 = new System.Windows.Forms.TextBox();
            this.powerActivationBox15 = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.powerEDBox15 = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.powerDamageBox15 = new System.Windows.Forms.TextBox();
            this.powerNameBox15 = new System.Windows.Forms.TextBox();
            this.powerMultiCheckBox14 = new System.Windows.Forms.CheckBox();
            this.powerDurationBox14 = new System.Windows.Forms.TextBox();
            this.powerKeywordBox14 = new System.Windows.Forms.TextBox();
            this.powerDNBox14 = new System.Windows.Forms.TextBox();
            this.powerRangeBox14 = new System.Windows.Forms.TextBox();
            this.powerActivationBox14 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.powerEDBox14 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.powerDamageBox14 = new System.Windows.Forms.TextBox();
            this.powerNameBox14 = new System.Windows.Forms.TextBox();
            this.powerMultiCheckBox13 = new System.Windows.Forms.CheckBox();
            this.powerDurationBox13 = new System.Windows.Forms.TextBox();
            this.powerKeywordBox13 = new System.Windows.Forms.TextBox();
            this.powerDNBox13 = new System.Windows.Forms.TextBox();
            this.powerRangeBox13 = new System.Windows.Forms.TextBox();
            this.powerActivationBox13 = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.powerEDBox13 = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.powerDamageBox13 = new System.Windows.Forms.TextBox();
            this.powerNameBox13 = new System.Windows.Forms.TextBox();
            this.powerMultiCheckBox12 = new System.Windows.Forms.CheckBox();
            this.powerDurationBox12 = new System.Windows.Forms.TextBox();
            this.powerKeywordBox12 = new System.Windows.Forms.TextBox();
            this.powerDNBox12 = new System.Windows.Forms.TextBox();
            this.powerRangeBox12 = new System.Windows.Forms.TextBox();
            this.powerActivationBox12 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.powerEDBox12 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.powerDamageBox12 = new System.Windows.Forms.TextBox();
            this.powerNameBox12 = new System.Windows.Forms.TextBox();
            this.powerMultiCheckBox11 = new System.Windows.Forms.CheckBox();
            this.powerDurationBox11 = new System.Windows.Forms.TextBox();
            this.powerKeywordBox11 = new System.Windows.Forms.TextBox();
            this.powerDNBox11 = new System.Windows.Forms.TextBox();
            this.powerRangeBox11 = new System.Windows.Forms.TextBox();
            this.powerActivationBox11 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.powerEDBox11 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.powerDamageBox11 = new System.Windows.Forms.TextBox();
            this.powerNameBox11 = new System.Windows.Forms.TextBox();
            this.powerMultiCheckBox10 = new System.Windows.Forms.CheckBox();
            this.powerDurationBox10 = new System.Windows.Forms.TextBox();
            this.powerKeywordBox10 = new System.Windows.Forms.TextBox();
            this.powerDNBox10 = new System.Windows.Forms.TextBox();
            this.powerRangeBox10 = new System.Windows.Forms.TextBox();
            this.powerActivationBox10 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.powerEDBox10 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.powerDamageBox10 = new System.Windows.Forms.TextBox();
            this.powerNameBox10 = new System.Windows.Forms.TextBox();
            this.powerMultiCheckBox9 = new System.Windows.Forms.CheckBox();
            this.powerDurationBox9 = new System.Windows.Forms.TextBox();
            this.powerKeywordBox9 = new System.Windows.Forms.TextBox();
            this.powerDNBox9 = new System.Windows.Forms.TextBox();
            this.powerRangeBox9 = new System.Windows.Forms.TextBox();
            this.powerActivationBox9 = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.powerEDBox9 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.powerDamageBox9 = new System.Windows.Forms.TextBox();
            this.powerNameBox9 = new System.Windows.Forms.TextBox();
            this.powerMultiCheckBox8 = new System.Windows.Forms.CheckBox();
            this.powerDurationBox8 = new System.Windows.Forms.TextBox();
            this.powerKeywordBox8 = new System.Windows.Forms.TextBox();
            this.powerDNBox8 = new System.Windows.Forms.TextBox();
            this.powerRangeBox8 = new System.Windows.Forms.TextBox();
            this.powerActivationBox8 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.powerEDBox8 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.powerDamageBox8 = new System.Windows.Forms.TextBox();
            this.powerNameBox8 = new System.Windows.Forms.TextBox();
            this.powerMultiCheckBox7 = new System.Windows.Forms.CheckBox();
            this.powerDurationBox7 = new System.Windows.Forms.TextBox();
            this.powerKeywordBox7 = new System.Windows.Forms.TextBox();
            this.powerDNBox7 = new System.Windows.Forms.TextBox();
            this.powerRangeBox7 = new System.Windows.Forms.TextBox();
            this.powerActivationBox7 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.powerEDBox7 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.powerDamageBox7 = new System.Windows.Forms.TextBox();
            this.powerNameBox7 = new System.Windows.Forms.TextBox();
            this.powerMultiCheckBox6 = new System.Windows.Forms.CheckBox();
            this.powerDurationBox6 = new System.Windows.Forms.TextBox();
            this.powerKeywordBox6 = new System.Windows.Forms.TextBox();
            this.powerDNBox6 = new System.Windows.Forms.TextBox();
            this.powerRangeBox6 = new System.Windows.Forms.TextBox();
            this.powerActivationBox6 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.powerEDBox6 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.powerDamageBox6 = new System.Windows.Forms.TextBox();
            this.powerNameBox6 = new System.Windows.Forms.TextBox();
            this.powerMultiCheckBox5 = new System.Windows.Forms.CheckBox();
            this.powerDurationBox5 = new System.Windows.Forms.TextBox();
            this.powerKeywordBox5 = new System.Windows.Forms.TextBox();
            this.powerDNBox5 = new System.Windows.Forms.TextBox();
            this.powerRangeBox5 = new System.Windows.Forms.TextBox();
            this.powerActivationBox5 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.powerEDBox5 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.powerDamageBox5 = new System.Windows.Forms.TextBox();
            this.powerNameBox5 = new System.Windows.Forms.TextBox();
            this.powerMultiCheckBox4 = new System.Windows.Forms.CheckBox();
            this.powerDurationBox4 = new System.Windows.Forms.TextBox();
            this.powerKeywordBox4 = new System.Windows.Forms.TextBox();
            this.powerDNBox4 = new System.Windows.Forms.TextBox();
            this.powerRangeBox4 = new System.Windows.Forms.TextBox();
            this.powerActivationBox4 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.powerEDBox4 = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.powerDamageBox4 = new System.Windows.Forms.TextBox();
            this.powerNameBox4 = new System.Windows.Forms.TextBox();
            this.powerMultiCheckBox3 = new System.Windows.Forms.CheckBox();
            this.powerDurationBox3 = new System.Windows.Forms.TextBox();
            this.powerKeywordBox3 = new System.Windows.Forms.TextBox();
            this.powerDNBox3 = new System.Windows.Forms.TextBox();
            this.powerRangeBox3 = new System.Windows.Forms.TextBox();
            this.powerActivationBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.powerEDBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.powerDamageBox3 = new System.Windows.Forms.TextBox();
            this.powerNameBox3 = new System.Windows.Forms.TextBox();
            this.powerMultiCheckBox2 = new System.Windows.Forms.CheckBox();
            this.powerDurationBox2 = new System.Windows.Forms.TextBox();
            this.powerKeywordBox2 = new System.Windows.Forms.TextBox();
            this.powerDNBox2 = new System.Windows.Forms.TextBox();
            this.powerRangeBox2 = new System.Windows.Forms.TextBox();
            this.powerActivationBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.powerEDBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.powerDamageBox2 = new System.Windows.Forms.TextBox();
            this.powerNameBox2 = new System.Windows.Forms.TextBox();
            this.powerMultiCheckBox1 = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.powerDurationBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.powerKeywordBox1 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.powerDNBox1 = new System.Windows.Forms.TextBox();
            this.powerRangeBox1 = new System.Windows.Forms.TextBox();
            this.powerActivationBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.powerEDBox1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.powerDamageBox1 = new System.Windows.Forms.TextBox();
            this.powerNameBox1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.powersTextBox = new System.Windows.Forms.RichTextBox();
            this.notes = new System.Windows.Forms.TabPage();
            this.notesTextBox = new System.Windows.Forms.RichTextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.summary = new System.Windows.Forms.TabPage();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.armorRatingBox)).BeginInit();
            this.cyberAndAugments.SuspendLayout();
            this.psychicpowers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.notes.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.summary.SuspendLayout();
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
            this.buildPointsLabel.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
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
            // shockValueBox
            // 
            this.shockValueBox.Location = new System.Drawing.Point(189, 315);
            this.shockValueBox.Name = "shockValueBox";
            this.shockValueBox.Size = new System.Drawing.Size(56, 20);
            this.shockValueBox.TabIndex = 77;
            this.shockValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.shockValueBox.ValueChanged += new System.EventHandler(this.shockValueBox_ValueChanged);
            // 
            // shockBonusLabel
            // 
            this.shockBonusLabel.AutoSize = true;
            this.shockBonusLabel.Location = new System.Drawing.Point(129, 317);
            this.shockBonusLabel.Name = "shockBonusLabel";
            this.shockBonusLabel.Size = new System.Drawing.Size(38, 13);
            this.shockBonusLabel.TabIndex = 76;
            this.shockBonusLabel.Text = "Shock";
            // 
            // woundsValueBox
            // 
            this.woundsValueBox.Location = new System.Drawing.Point(57, 315);
            this.woundsValueBox.Name = "woundsValueBox";
            this.woundsValueBox.Size = new System.Drawing.Size(56, 20);
            this.woundsValueBox.TabIndex = 75;
            this.woundsValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.woundsValueBox.ValueChanged += new System.EventHandler(this.woundsValueBox_ValueChanged);
            // 
            // woundsBonusLabel
            // 
            this.woundsBonusLabel.AutoSize = true;
            this.woundsBonusLabel.Location = new System.Drawing.Point(0, 317);
            this.woundsBonusLabel.Name = "woundsBonusLabel";
            this.woundsBonusLabel.Size = new System.Drawing.Size(47, 13);
            this.woundsBonusLabel.TabIndex = 74;
            this.woundsBonusLabel.Text = "Wounds";
            // 
            // rankAndBonusLabel
            // 
            this.rankAndBonusLabel.AutoSize = true;
            this.rankAndBonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rankAndBonusLabel.Location = new System.Drawing.Point(0, 155);
            this.rankAndBonusLabel.Name = "rankAndBonusLabel";
            this.rankAndBonusLabel.Size = new System.Drawing.Size(114, 13);
            this.rankAndBonusLabel.TabIndex = 73;
            this.rankAndBonusLabel.Text = "Rank and Bonuses";
            // 
            // influenceValueBox
            // 
            this.influenceValueBox.Location = new System.Drawing.Point(189, 289);
            this.influenceValueBox.Name = "influenceValueBox";
            this.influenceValueBox.Size = new System.Drawing.Size(56, 20);
            this.influenceValueBox.TabIndex = 72;
            this.influenceValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.influenceValueBox.ValueChanged += new System.EventHandler(this.influenceValueBox_ValueChanged_1);
            // 
            // resolveValueBox
            // 
            this.resolveValueBox.Location = new System.Drawing.Point(189, 262);
            this.resolveValueBox.Name = "resolveValueBox";
            this.resolveValueBox.Size = new System.Drawing.Size(56, 20);
            this.resolveValueBox.TabIndex = 71;
            this.resolveValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resolveValueBox.ValueChanged += new System.EventHandler(this.resolveValueBox_ValueChanged);
            // 
            // influenceBonusLabel
            // 
            this.influenceBonusLabel.AutoSize = true;
            this.influenceBonusLabel.Location = new System.Drawing.Point(129, 291);
            this.influenceBonusLabel.Name = "influenceBonusLabel";
            this.influenceBonusLabel.Size = new System.Drawing.Size(51, 13);
            this.influenceBonusLabel.TabIndex = 70;
            this.influenceBonusLabel.Text = "Influence";
            // 
            // resolveBonusLabel
            // 
            this.resolveBonusLabel.AutoSize = true;
            this.resolveBonusLabel.Location = new System.Drawing.Point(129, 264);
            this.resolveBonusLabel.Name = "resolveBonusLabel";
            this.resolveBonusLabel.Size = new System.Drawing.Size(46, 13);
            this.resolveBonusLabel.TabIndex = 69;
            this.resolveBonusLabel.Text = "Resolve";
            // 
            // passiveAwarenessValueBox
            // 
            this.passiveAwarenessValueBox.Location = new System.Drawing.Point(189, 235);
            this.passiveAwarenessValueBox.Name = "passiveAwarenessValueBox";
            this.passiveAwarenessValueBox.Size = new System.Drawing.Size(56, 20);
            this.passiveAwarenessValueBox.TabIndex = 68;
            this.passiveAwarenessValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.passiveAwarenessValueBox.ValueChanged += new System.EventHandler(this.passiveAwarenessValueBox_ValueChanged);
            // 
            // passiveAwarenessBonusLabel
            // 
            this.passiveAwarenessBonusLabel.AutoSize = true;
            this.passiveAwarenessBonusLabel.Location = new System.Drawing.Point(129, 233);
            this.passiveAwarenessBonusLabel.Name = "passiveAwarenessBonusLabel";
            this.passiveAwarenessBonusLabel.Size = new System.Drawing.Size(59, 26);
            this.passiveAwarenessBonusLabel.TabIndex = 67;
            this.passiveAwarenessBonusLabel.Text = "Passive\r\nAwareness\r\n";
            // 
            // convictionValueBox
            // 
            this.convictionValueBox.Location = new System.Drawing.Point(189, 210);
            this.convictionValueBox.Name = "convictionValueBox";
            this.convictionValueBox.Size = new System.Drawing.Size(56, 20);
            this.convictionValueBox.TabIndex = 66;
            this.convictionValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.convictionValueBox.ValueChanged += new System.EventHandler(this.convictionValueBox_ValueChanged);
            // 
            // convictionBonusLabel
            // 
            this.convictionBonusLabel.AutoSize = true;
            this.convictionBonusLabel.Location = new System.Drawing.Point(129, 212);
            this.convictionBonusLabel.Name = "convictionBonusLabel";
            this.convictionBonusLabel.Size = new System.Drawing.Size(57, 13);
            this.convictionBonusLabel.TabIndex = 65;
            this.convictionBonusLabel.Text = "Conviction";
            // 
            // resilienceValueBox
            // 
            this.resilienceValueBox.Location = new System.Drawing.Point(189, 184);
            this.resilienceValueBox.Name = "resilienceValueBox";
            this.resilienceValueBox.Size = new System.Drawing.Size(56, 20);
            this.resilienceValueBox.TabIndex = 64;
            this.resilienceValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resilienceValueBox.ValueChanged += new System.EventHandler(this.resilienceValueBox_ValueChanged);
            // 
            // soakValueBox
            // 
            this.soakValueBox.Location = new System.Drawing.Point(57, 289);
            this.soakValueBox.Name = "soakValueBox";
            this.soakValueBox.Size = new System.Drawing.Size(56, 20);
            this.soakValueBox.TabIndex = 63;
            this.soakValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.soakValueBox.ValueChanged += new System.EventHandler(this.soakValueBox_ValueChanged);
            // 
            // resilienceBonusLabel
            // 
            this.resilienceBonusLabel.AutoSize = true;
            this.resilienceBonusLabel.Location = new System.Drawing.Point(129, 186);
            this.resilienceBonusLabel.Name = "resilienceBonusLabel";
            this.resilienceBonusLabel.Size = new System.Drawing.Size(56, 13);
            this.resilienceBonusLabel.TabIndex = 62;
            this.resilienceBonusLabel.Text = "Resilience";
            // 
            // soakBonusLabel
            // 
            this.soakBonusLabel.AutoSize = true;
            this.soakBonusLabel.Location = new System.Drawing.Point(0, 291);
            this.soakBonusLabel.Name = "soakBonusLabel";
            this.soakBonusLabel.Size = new System.Drawing.Size(32, 13);
            this.soakBonusLabel.TabIndex = 61;
            this.soakBonusLabel.Text = "Soak";
            // 
            // defenceValueBox
            // 
            this.defenceValueBox.Location = new System.Drawing.Point(57, 262);
            this.defenceValueBox.Name = "defenceValueBox";
            this.defenceValueBox.Size = new System.Drawing.Size(56, 20);
            this.defenceValueBox.TabIndex = 60;
            this.defenceValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.defenceValueBox.ValueChanged += new System.EventHandler(this.defenceValueBox_ValueChanged);
            // 
            // defenceBonusLabel
            // 
            this.defenceBonusLabel.AutoSize = true;
            this.defenceBonusLabel.Location = new System.Drawing.Point(0, 264);
            this.defenceBonusLabel.Name = "defenceBonusLabel";
            this.defenceBonusLabel.Size = new System.Drawing.Size(48, 13);
            this.defenceBonusLabel.TabIndex = 59;
            this.defenceBonusLabel.Text = "Defence";
            // 
            // attSpeedModifier
            // 
            this.attSpeedModifier.Location = new System.Drawing.Point(438, 213);
            this.attSpeedModifier.Name = "attSpeedModifier";
            this.attSpeedModifier.ReadOnly = true;
            this.attSpeedModifier.Size = new System.Drawing.Size(47, 20);
            this.attSpeedModifier.TabIndex = 58;
            this.attSpeedModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attSpeedModifier.ValueChanged += new System.EventHandler(this.attSpeedModifier_ValueChanged);
            // 
            // attInitiativeModifier
            // 
            this.attInitiativeModifier.Location = new System.Drawing.Point(438, 188);
            this.attInitiativeModifier.Name = "attInitiativeModifier";
            this.attInitiativeModifier.ReadOnly = true;
            this.attInitiativeModifier.Size = new System.Drawing.Size(47, 20);
            this.attInitiativeModifier.TabIndex = 57;
            this.attInitiativeModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attInitiativeModifier.ValueChanged += new System.EventHandler(this.attInitiativeModifier_ValueChanged);
            // 
            // attFellowshipModifier
            // 
            this.attFellowshipModifier.Location = new System.Drawing.Point(438, 163);
            this.attFellowshipModifier.Name = "attFellowshipModifier";
            this.attFellowshipModifier.ReadOnly = true;
            this.attFellowshipModifier.Size = new System.Drawing.Size(47, 20);
            this.attFellowshipModifier.TabIndex = 56;
            this.attFellowshipModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attFellowshipModifier.ValueChanged += new System.EventHandler(this.attFellowshipModifier_ValueChanged);
            // 
            // attWillpowerModifier
            // 
            this.attWillpowerModifier.Location = new System.Drawing.Point(438, 138);
            this.attWillpowerModifier.Name = "attWillpowerModifier";
            this.attWillpowerModifier.ReadOnly = true;
            this.attWillpowerModifier.Size = new System.Drawing.Size(47, 20);
            this.attWillpowerModifier.TabIndex = 55;
            this.attWillpowerModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attWillpowerModifier.ValueChanged += new System.EventHandler(this.attWillpowerModifier_ValueChanged);
            // 
            // attIntellectModifier
            // 
            this.attIntellectModifier.Location = new System.Drawing.Point(438, 113);
            this.attIntellectModifier.Name = "attIntellectModifier";
            this.attIntellectModifier.ReadOnly = true;
            this.attIntellectModifier.Size = new System.Drawing.Size(47, 20);
            this.attIntellectModifier.TabIndex = 54;
            this.attIntellectModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attIntellectModifier.ValueChanged += new System.EventHandler(this.attIntellectModifier_ValueChanged);
            // 
            // attToughnessModifier
            // 
            this.attToughnessModifier.Location = new System.Drawing.Point(438, 88);
            this.attToughnessModifier.Name = "attToughnessModifier";
            this.attToughnessModifier.ReadOnly = true;
            this.attToughnessModifier.Size = new System.Drawing.Size(47, 20);
            this.attToughnessModifier.TabIndex = 53;
            this.attToughnessModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attToughnessModifier.ValueChanged += new System.EventHandler(this.attToughnessModifier_ValueChanged);
            // 
            // attAgilityModifier
            // 
            this.attAgilityModifier.Location = new System.Drawing.Point(438, 63);
            this.attAgilityModifier.Name = "attAgilityModifier";
            this.attAgilityModifier.ReadOnly = true;
            this.attAgilityModifier.Size = new System.Drawing.Size(47, 20);
            this.attAgilityModifier.TabIndex = 52;
            this.attAgilityModifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attAgilityModifier.ValueChanged += new System.EventHandler(this.attAgilityModifier_ValueChanged);
            // 
            // attStrengthModifier
            // 
            this.attStrengthModifier.Location = new System.Drawing.Point(438, 38);
            this.attStrengthModifier.Name = "attStrengthModifier";
            this.attStrengthModifier.ReadOnly = true;
            this.attStrengthModifier.Size = new System.Drawing.Size(47, 20);
            this.attStrengthModifier.TabIndex = 51;
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
            this.corruptionValueBox.Location = new System.Drawing.Point(57, 235);
            this.corruptionValueBox.Name = "corruptionValueBox";
            this.corruptionValueBox.Size = new System.Drawing.Size(56, 20);
            this.corruptionValueBox.TabIndex = 49;
            this.corruptionValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.corruptionValueBox.ValueChanged += new System.EventHandler(this.corruptionValueBox_ValueChanged);
            // 
            // corruptionValueLabel
            // 
            this.corruptionValueLabel.AutoSize = true;
            this.corruptionValueLabel.Location = new System.Drawing.Point(0, 237);
            this.corruptionValueLabel.Name = "corruptionValueLabel";
            this.corruptionValueLabel.Size = new System.Drawing.Size(55, 13);
            this.corruptionValueLabel.TabIndex = 48;
            this.corruptionValueLabel.Text = "Corruption";
            // 
            // wealthValueBox
            // 
            this.wealthValueBox.Location = new System.Drawing.Point(57, 210);
            this.wealthValueBox.Name = "wealthValueBox";
            this.wealthValueBox.Size = new System.Drawing.Size(56, 20);
            this.wealthValueBox.TabIndex = 47;
            this.wealthValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.wealthValueBox.ValueChanged += new System.EventHandler(this.wealthValueBox_ValueChanged);
            // 
            // rankValueBox
            // 
            this.rankValueBox.Location = new System.Drawing.Point(57, 184);
            this.rankValueBox.Name = "rankValueBox";
            this.rankValueBox.Size = new System.Drawing.Size(56, 20);
            this.rankValueBox.TabIndex = 46;
            this.rankValueBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.rankValueBox.ValueChanged += new System.EventHandler(this.rankValueBox_ValueChanged);
            // 
            // wealthValueLabel
            // 
            this.wealthValueLabel.AutoSize = true;
            this.wealthValueLabel.Location = new System.Drawing.Point(0, 212);
            this.wealthValueLabel.Name = "wealthValueLabel";
            this.wealthValueLabel.Size = new System.Drawing.Size(41, 13);
            this.wealthValueLabel.TabIndex = 45;
            this.wealthValueLabel.Text = "Wealth";
            // 
            // rankValueLabel
            // 
            this.rankValueLabel.AutoSize = true;
            this.rankValueLabel.Location = new System.Drawing.Point(0, 186);
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
            this.removeBPButton.TabIndex = 42;
            this.removeBPButton.Text = "Remove BP";
            this.removeBPButton.UseVisualStyleBackColor = true;
            this.removeBPButton.Click += new System.EventHandler(this.removeBPButton_Click);
            // 
            // addBPButton
            // 
            this.addBPButton.Location = new System.Drawing.Point(35, 443);
            this.addBPButton.Name = "addBPButton";
            this.addBPButton.Size = new System.Drawing.Size(169, 49);
            this.addBPButton.TabIndex = 41;
            this.addBPButton.Text = "Add BP";
            this.addBPButton.UseVisualStyleBackColor = true;
            this.addBPButton.Click += new System.EventHandler(this.addBPButton_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(61, 37);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(184, 20);
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
            this.removeTalentBtn.Location = new System.Drawing.Point(696, 360);
            this.removeTalentBtn.Name = "removeTalentBtn";
            this.removeTalentBtn.Size = new System.Drawing.Size(94, 23);
            this.removeTalentBtn.TabIndex = 38;
            this.removeTalentBtn.Text = "Remove Talent";
            this.removeTalentBtn.UseVisualStyleBackColor = true;
            this.removeTalentBtn.Click += new System.EventHandler(this.removeTalentBtn_Click);
            // 
            // addTalentBtn
            // 
            this.addTalentBtn.Location = new System.Drawing.Point(576, 360);
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
            this.archetypeSelect.TabIndex = 34;
            this.archetypeSelect.SelectedIndexChanged += new System.EventHandler(this.archetypeSelect_SelectedIndexChanged);
            // 
            // speciesSelect
            // 
            this.speciesSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speciesSelect.FormattingEnabled = true;
            this.speciesSelect.Location = new System.Drawing.Point(61, 87);
            this.speciesSelect.Name = "speciesSelect";
            this.speciesSelect.Size = new System.Drawing.Size(184, 21);
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
            this.tierSelect.Size = new System.Drawing.Size(184, 21);
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
            this.attSpeed.TabIndex = 16;
            this.attSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attSpeed.ValueChanged += new System.EventHandler(this.attSpeed_ValueChanged);
            // 
            // attInitiative
            // 
            this.attInitiative.Location = new System.Drawing.Point(350, 188);
            this.attInitiative.Name = "attInitiative";
            this.attInitiative.ReadOnly = true;
            this.attInitiative.Size = new System.Drawing.Size(47, 20);
            this.attInitiative.TabIndex = 15;
            this.attInitiative.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attInitiative.ValueChanged += new System.EventHandler(this.attInitiative_ValueChanged);
            // 
            // attFellowship
            // 
            this.attFellowship.Location = new System.Drawing.Point(350, 163);
            this.attFellowship.Name = "attFellowship";
            this.attFellowship.ReadOnly = true;
            this.attFellowship.Size = new System.Drawing.Size(47, 20);
            this.attFellowship.TabIndex = 14;
            this.attFellowship.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attFellowship.ValueChanged += new System.EventHandler(this.attFellowship_ValueChanged);
            // 
            // attWillpower
            // 
            this.attWillpower.Location = new System.Drawing.Point(350, 138);
            this.attWillpower.Name = "attWillpower";
            this.attWillpower.ReadOnly = true;
            this.attWillpower.Size = new System.Drawing.Size(47, 20);
            this.attWillpower.TabIndex = 13;
            this.attWillpower.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attWillpower.ValueChanged += new System.EventHandler(this.attWillpower_ValueChanged);
            // 
            // attIntellect
            // 
            this.attIntellect.Location = new System.Drawing.Point(350, 113);
            this.attIntellect.Name = "attIntellect";
            this.attIntellect.ReadOnly = true;
            this.attIntellect.Size = new System.Drawing.Size(47, 20);
            this.attIntellect.TabIndex = 12;
            this.attIntellect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attIntellect.ValueChanged += new System.EventHandler(this.attIntellect_ValueChanged);
            // 
            // attToughness
            // 
            this.attToughness.Location = new System.Drawing.Point(350, 88);
            this.attToughness.Name = "attToughness";
            this.attToughness.ReadOnly = true;
            this.attToughness.Size = new System.Drawing.Size(47, 20);
            this.attToughness.TabIndex = 11;
            this.attToughness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attToughness.ValueChanged += new System.EventHandler(this.attToughness_ValueChanged);
            // 
            // attAgility
            // 
            this.attAgility.Location = new System.Drawing.Point(350, 63);
            this.attAgility.Name = "attAgility";
            this.attAgility.ReadOnly = true;
            this.attAgility.Size = new System.Drawing.Size(47, 20);
            this.attAgility.TabIndex = 10;
            this.attAgility.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.attAgility.ValueChanged += new System.EventHandler(this.attAgility_ValueChanged);
            // 
            // attStrength
            // 
            this.attStrength.Location = new System.Drawing.Point(350, 38);
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
            this.skillWeaponSkillBonus.Name = "skillWeaponSkillBonus";
            this.skillWeaponSkillBonus.ReadOnly = true;
            this.skillWeaponSkillBonus.Size = new System.Drawing.Size(45, 20);
            this.skillWeaponSkillBonus.TabIndex = 92;
            this.skillWeaponSkillBonus.ValueChanged += new System.EventHandler(this.skillWeaponSkillBonus_ValueChanged);
            // 
            // skillTechBonus
            // 
            this.skillTechBonus.Location = new System.Drawing.Point(276, 450);
            this.skillTechBonus.Name = "skillTechBonus";
            this.skillTechBonus.ReadOnly = true;
            this.skillTechBonus.Size = new System.Drawing.Size(45, 20);
            this.skillTechBonus.TabIndex = 91;
            this.skillTechBonus.ValueChanged += new System.EventHandler(this.skillTechBonus_ValueChanged);
            // 
            // skillSurvivalBonus
            // 
            this.skillSurvivalBonus.Location = new System.Drawing.Point(276, 424);
            this.skillSurvivalBonus.Name = "skillSurvivalBonus";
            this.skillSurvivalBonus.ReadOnly = true;
            this.skillSurvivalBonus.Size = new System.Drawing.Size(45, 20);
            this.skillSurvivalBonus.TabIndex = 90;
            this.skillSurvivalBonus.ValueChanged += new System.EventHandler(this.skillSurvivalBonus_ValueChanged);
            // 
            // skillStealthBonus
            // 
            this.skillStealthBonus.Location = new System.Drawing.Point(276, 398);
            this.skillStealthBonus.Name = "skillStealthBonus";
            this.skillStealthBonus.ReadOnly = true;
            this.skillStealthBonus.Size = new System.Drawing.Size(45, 20);
            this.skillStealthBonus.TabIndex = 89;
            this.skillStealthBonus.ValueChanged += new System.EventHandler(this.skillAgilityBonus_ValueChanged);
            // 
            // skillScholarBonus
            // 
            this.skillScholarBonus.Location = new System.Drawing.Point(276, 372);
            this.skillScholarBonus.Name = "skillScholarBonus";
            this.skillScholarBonus.ReadOnly = true;
            this.skillScholarBonus.Size = new System.Drawing.Size(45, 20);
            this.skillScholarBonus.TabIndex = 88;
            this.skillScholarBonus.ValueChanged += new System.EventHandler(this.skillScholarBonus_ValueChanged);
            // 
            // skillPsychicBonus
            // 
            this.skillPsychicBonus.Location = new System.Drawing.Point(276, 346);
            this.skillPsychicBonus.Name = "skillPsychicBonus";
            this.skillPsychicBonus.ReadOnly = true;
            this.skillPsychicBonus.Size = new System.Drawing.Size(45, 20);
            this.skillPsychicBonus.TabIndex = 87;
            this.skillPsychicBonus.ValueChanged += new System.EventHandler(this.skillPsychicBonus_ValueChanged);
            // 
            // skillPilotBonus
            // 
            this.skillPilotBonus.Location = new System.Drawing.Point(276, 320);
            this.skillPilotBonus.Name = "skillPilotBonus";
            this.skillPilotBonus.ReadOnly = true;
            this.skillPilotBonus.Size = new System.Drawing.Size(45, 20);
            this.skillPilotBonus.TabIndex = 86;
            this.skillPilotBonus.ValueChanged += new System.EventHandler(this.skillPilotBonus_ValueChanged);
            // 
            // skillPersuasionBonus
            // 
            this.skillPersuasionBonus.Location = new System.Drawing.Point(276, 294);
            this.skillPersuasionBonus.Name = "skillPersuasionBonus";
            this.skillPersuasionBonus.ReadOnly = true;
            this.skillPersuasionBonus.Size = new System.Drawing.Size(45, 20);
            this.skillPersuasionBonus.TabIndex = 85;
            this.skillPersuasionBonus.ValueChanged += new System.EventHandler(this.skillPersuasionBonus_ValueChanged);
            // 
            // skillMedicaeBonus
            // 
            this.skillMedicaeBonus.Location = new System.Drawing.Point(276, 268);
            this.skillMedicaeBonus.Name = "skillMedicaeBonus";
            this.skillMedicaeBonus.ReadOnly = true;
            this.skillMedicaeBonus.Size = new System.Drawing.Size(45, 20);
            this.skillMedicaeBonus.TabIndex = 84;
            this.skillMedicaeBonus.ValueChanged += new System.EventHandler(this.skillMedicaeBonus_ValueChanged);
            // 
            // skillLeadershipBonus
            // 
            this.skillLeadershipBonus.Location = new System.Drawing.Point(276, 242);
            this.skillLeadershipBonus.Name = "skillLeadershipBonus";
            this.skillLeadershipBonus.ReadOnly = true;
            this.skillLeadershipBonus.Size = new System.Drawing.Size(45, 20);
            this.skillLeadershipBonus.TabIndex = 83;
            this.skillLeadershipBonus.ValueChanged += new System.EventHandler(this.skillLeadershipBonus_ValueChanged);
            // 
            // skillInvestigationBonus
            // 
            this.skillInvestigationBonus.Location = new System.Drawing.Point(276, 216);
            this.skillInvestigationBonus.Name = "skillInvestigationBonus";
            this.skillInvestigationBonus.ReadOnly = true;
            this.skillInvestigationBonus.Size = new System.Drawing.Size(45, 20);
            this.skillInvestigationBonus.TabIndex = 82;
            this.skillInvestigationBonus.ValueChanged += new System.EventHandler(this.skillInvestigationBonus_ValueChanged);
            // 
            // skillIntimidationBonus
            // 
            this.skillIntimidationBonus.Location = new System.Drawing.Point(276, 190);
            this.skillIntimidationBonus.Name = "skillIntimidationBonus";
            this.skillIntimidationBonus.ReadOnly = true;
            this.skillIntimidationBonus.Size = new System.Drawing.Size(45, 20);
            this.skillIntimidationBonus.TabIndex = 81;
            this.skillIntimidationBonus.ValueChanged += new System.EventHandler(this.skillIntimidationBonus_ValueChanged);
            // 
            // skillInsightBonus
            // 
            this.skillInsightBonus.Location = new System.Drawing.Point(276, 164);
            this.skillInsightBonus.Name = "skillInsightBonus";
            this.skillInsightBonus.ReadOnly = true;
            this.skillInsightBonus.Size = new System.Drawing.Size(45, 20);
            this.skillInsightBonus.TabIndex = 80;
            this.skillInsightBonus.ValueChanged += new System.EventHandler(this.skillInsightBonus_ValueChanged);
            // 
            // skillDeceptionBonus
            // 
            this.skillDeceptionBonus.Location = new System.Drawing.Point(276, 138);
            this.skillDeceptionBonus.Name = "skillDeceptionBonus";
            this.skillDeceptionBonus.ReadOnly = true;
            this.skillDeceptionBonus.Size = new System.Drawing.Size(45, 20);
            this.skillDeceptionBonus.TabIndex = 79;
            this.skillDeceptionBonus.ValueChanged += new System.EventHandler(this.skillDeceptionBonus_ValueChanged);
            // 
            // skillCunningBonus
            // 
            this.skillCunningBonus.Location = new System.Drawing.Point(276, 112);
            this.skillCunningBonus.Name = "skillCunningBonus";
            this.skillCunningBonus.ReadOnly = true;
            this.skillCunningBonus.Size = new System.Drawing.Size(45, 20);
            this.skillCunningBonus.TabIndex = 78;
            this.skillCunningBonus.ValueChanged += new System.EventHandler(this.skillCunningBonus_ValueChanged);
            // 
            // skillBallisticBonus
            // 
            this.skillBallisticBonus.Location = new System.Drawing.Point(276, 86);
            this.skillBallisticBonus.Name = "skillBallisticBonus";
            this.skillBallisticBonus.ReadOnly = true;
            this.skillBallisticBonus.Size = new System.Drawing.Size(45, 20);
            this.skillBallisticBonus.TabIndex = 77;
            this.skillBallisticBonus.ValueChanged += new System.EventHandler(this.skillBallisticBonus_ValueChanged);
            // 
            // skillAwarenessBonus
            // 
            this.skillAwarenessBonus.Location = new System.Drawing.Point(276, 60);
            this.skillAwarenessBonus.Name = "skillAwarenessBonus";
            this.skillAwarenessBonus.ReadOnly = true;
            this.skillAwarenessBonus.Size = new System.Drawing.Size(45, 20);
            this.skillAwarenessBonus.TabIndex = 76;
            this.skillAwarenessBonus.ValueChanged += new System.EventHandler(this.skillAwarenessBonus_ValueChanged);
            // 
            // skillAthleticsBonus
            // 
            this.skillAthleticsBonus.Location = new System.Drawing.Point(276, 34);
            this.skillAthleticsBonus.Name = "skillAthleticsBonus";
            this.skillAthleticsBonus.ReadOnly = true;
            this.skillAthleticsBonus.Size = new System.Drawing.Size(45, 20);
            this.skillAthleticsBonus.TabIndex = 75;
            this.skillAthleticsBonus.ValueChanged += new System.EventHandler(this.skillAthleticsBonus_ValueChanged);
            // 
            // weaponSkillBonusBox
            // 
            this.weaponSkillBonusBox.Location = new System.Drawing.Point(350, 475);
            this.weaponSkillBonusBox.Name = "weaponSkillBonusBox";
            this.weaponSkillBonusBox.Size = new System.Drawing.Size(456, 20);
            this.weaponSkillBonusBox.TabIndex = 74;
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
            // techBonusBox
            // 
            this.techBonusBox.Location = new System.Drawing.Point(350, 449);
            this.techBonusBox.Name = "techBonusBox";
            this.techBonusBox.Size = new System.Drawing.Size(456, 20);
            this.techBonusBox.TabIndex = 70;
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
            // survivalBonusBox
            // 
            this.survivalBonusBox.Location = new System.Drawing.Point(350, 423);
            this.survivalBonusBox.Name = "survivalBonusBox";
            this.survivalBonusBox.Size = new System.Drawing.Size(456, 20);
            this.survivalBonusBox.TabIndex = 66;
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
            // stealthBonusBox
            // 
            this.stealthBonusBox.Location = new System.Drawing.Point(350, 397);
            this.stealthBonusBox.Name = "stealthBonusBox";
            this.stealthBonusBox.Size = new System.Drawing.Size(456, 20);
            this.stealthBonusBox.TabIndex = 62;
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
            // scholarBonusBox
            // 
            this.scholarBonusBox.Location = new System.Drawing.Point(350, 371);
            this.scholarBonusBox.Name = "scholarBonusBox";
            this.scholarBonusBox.Size = new System.Drawing.Size(456, 20);
            this.scholarBonusBox.TabIndex = 58;
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
            // psychicBonusBox
            // 
            this.psychicBonusBox.Location = new System.Drawing.Point(350, 345);
            this.psychicBonusBox.Name = "psychicBonusBox";
            this.psychicBonusBox.Size = new System.Drawing.Size(456, 20);
            this.psychicBonusBox.TabIndex = 54;
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
            // pilotBonusBox
            // 
            this.pilotBonusBox.Location = new System.Drawing.Point(350, 319);
            this.pilotBonusBox.Name = "pilotBonusBox";
            this.pilotBonusBox.Size = new System.Drawing.Size(456, 20);
            this.pilotBonusBox.TabIndex = 50;
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
            // persuasionBonusBox
            // 
            this.persuasionBonusBox.Location = new System.Drawing.Point(350, 293);
            this.persuasionBonusBox.Name = "persuasionBonusBox";
            this.persuasionBonusBox.Size = new System.Drawing.Size(456, 20);
            this.persuasionBonusBox.TabIndex = 46;
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
            // medicaeBonusBox
            // 
            this.medicaeBonusBox.Location = new System.Drawing.Point(350, 267);
            this.medicaeBonusBox.Name = "medicaeBonusBox";
            this.medicaeBonusBox.Size = new System.Drawing.Size(456, 20);
            this.medicaeBonusBox.TabIndex = 42;
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
            // leadershipBonusBox
            // 
            this.leadershipBonusBox.Location = new System.Drawing.Point(350, 241);
            this.leadershipBonusBox.Name = "leadershipBonusBox";
            this.leadershipBonusBox.Size = new System.Drawing.Size(456, 20);
            this.leadershipBonusBox.TabIndex = 38;
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
            // investigationBonusBox
            // 
            this.investigationBonusBox.Location = new System.Drawing.Point(350, 215);
            this.investigationBonusBox.Name = "investigationBonusBox";
            this.investigationBonusBox.Size = new System.Drawing.Size(456, 20);
            this.investigationBonusBox.TabIndex = 34;
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
            // intimidationBonusBox
            // 
            this.intimidationBonusBox.Location = new System.Drawing.Point(350, 189);
            this.intimidationBonusBox.Name = "intimidationBonusBox";
            this.intimidationBonusBox.Size = new System.Drawing.Size(456, 20);
            this.intimidationBonusBox.TabIndex = 30;
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
            // insightBonusBox
            // 
            this.insightBonusBox.Location = new System.Drawing.Point(350, 163);
            this.insightBonusBox.Name = "insightBonusBox";
            this.insightBonusBox.Size = new System.Drawing.Size(456, 20);
            this.insightBonusBox.TabIndex = 26;
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
            // deceptionBonusBox
            // 
            this.deceptionBonusBox.Location = new System.Drawing.Point(350, 137);
            this.deceptionBonusBox.Name = "deceptionBonusBox";
            this.deceptionBonusBox.Size = new System.Drawing.Size(456, 20);
            this.deceptionBonusBox.TabIndex = 22;
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
            // cunningBonusBox
            // 
            this.cunningBonusBox.Location = new System.Drawing.Point(350, 111);
            this.cunningBonusBox.Name = "cunningBonusBox";
            this.cunningBonusBox.Size = new System.Drawing.Size(456, 20);
            this.cunningBonusBox.TabIndex = 18;
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
            // ballisticBonusBox
            // 
            this.ballisticBonusBox.Location = new System.Drawing.Point(350, 85);
            this.ballisticBonusBox.Name = "ballisticBonusBox";
            this.ballisticBonusBox.Size = new System.Drawing.Size(456, 20);
            this.ballisticBonusBox.TabIndex = 14;
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
            // awarenessBonusBox
            // 
            this.awarenessBonusBox.Location = new System.Drawing.Point(350, 59);
            this.awarenessBonusBox.Name = "awarenessBonusBox";
            this.awarenessBonusBox.Size = new System.Drawing.Size(456, 20);
            this.awarenessBonusBox.TabIndex = 10;
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
            this.athleticsBonusBox.TabIndex = 4;
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
            this.equipment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.equipment.Controls.Add(this.splitContainer3);
            this.equipment.Location = new System.Drawing.Point(4, 22);
            this.equipment.Name = "equipment";
            this.equipment.Padding = new System.Windows.Forms.Padding(3);
            this.equipment.Size = new System.Drawing.Size(825, 509);
            this.equipment.TabIndex = 2;
            this.equipment.Text = "Equipment";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.AutoScroll = true;
            this.splitContainer3.Panel1.Controls.Add(this.armorNameLabel);
            this.splitContainer3.Panel1.Controls.Add(this.armorRatingBox);
            this.splitContainer3.Panel1.Controls.Add(this.armorRatingHeaderLabel);
            this.splitContainer3.Panel1.Controls.Add(this.armorKeywordsBox);
            this.splitContainer3.Panel1.Controls.Add(this.armorValueBox);
            this.splitContainer3.Panel1.Controls.Add(this.armorTraitsBox);
            this.splitContainer3.Panel1.Controls.Add(this.armorNameBox);
            this.splitContainer3.Panel1.Controls.Add(this.meleeWeaponKeywordsBox);
            this.splitContainer3.Panel1.Controls.Add(this.meleeWeaponValueBox);
            this.splitContainer3.Panel1.Controls.Add(this.meleeWeaponTraitsBox);
            this.splitContainer3.Panel1.Controls.Add(this.MeleeWeaponRangeBox);
            this.splitContainer3.Panel1.Controls.Add(this.meleeWeaponAPBox);
            this.splitContainer3.Panel1.Controls.Add(this.label2);
            this.splitContainer3.Panel1.Controls.Add(this.meleeWeaponEDBox);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            this.splitContainer3.Panel1.Controls.Add(this.meleeWeaponDamageBox);
            this.splitContainer3.Panel1.Controls.Add(this.meleeWeaponNameBox);
            this.splitContainer3.Panel1.Controls.Add(this.meleeWeaponHeaderLabel);
            this.splitContainer3.Panel1.Controls.Add(this.rangedWeaponKeywordsBox);
            this.splitContainer3.Panel1.Controls.Add(this.keywordsHeaderLabel);
            this.splitContainer3.Panel1.Controls.Add(this.rangedWeaponValueBox);
            this.splitContainer3.Panel1.Controls.Add(this.rangedWeaponTraitBox);
            this.splitContainer3.Panel1.Controls.Add(this.rangedWeaponSalvoBox);
            this.splitContainer3.Panel1.Controls.Add(this.rangedWeaponRangeBox);
            this.splitContainer3.Panel1.Controls.Add(this.rangedWeaponAPBox);
            this.splitContainer3.Panel1.Controls.Add(this.rangedEDBoxLabel);
            this.splitContainer3.Panel1.Controls.Add(this.rangedWeaponEDBox);
            this.splitContainer3.Panel1.Controls.Add(this.rangedBaseModLabel);
            this.splitContainer3.Panel1.Controls.Add(this.rangedWeaponDamageBox);
            this.splitContainer3.Panel1.Controls.Add(this.rangedWeaponNameBox);
            this.splitContainer3.Panel1.Controls.Add(this.weaponValueHeaderLabel);
            this.splitContainer3.Panel1.Controls.Add(this.weaponTraitsHeaderLabel);
            this.splitContainer3.Panel1.Controls.Add(this.salvoHeaderLabel);
            this.splitContainer3.Panel1.Controls.Add(this.weaponRangeHeaderLabel);
            this.splitContainer3.Panel1.Controls.Add(this.apHeaderLabel);
            this.splitContainer3.Panel1.Controls.Add(this.weaponDamageHeaderLabel);
            this.splitContainer3.Panel1.Controls.Add(this.rangedWeaponHeaderLabel);
            this.splitContainer3.Panel1.Controls.Add(this.armorHeaderLabel);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.miscEquipmentHeaderLabel);
            this.splitContainer3.Panel2.Controls.Add(this.equipmentTextBox);
            this.splitContainer3.Size = new System.Drawing.Size(819, 503);
            this.splitContainer3.SplitterDistance = 251;
            this.splitContainer3.TabIndex = 48;
            // 
            // armorNameLabel
            // 
            this.armorNameLabel.AutoSize = true;
            this.armorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.armorNameLabel.Location = new System.Drawing.Point(6, 130);
            this.armorNameLabel.Name = "armorNameLabel";
            this.armorNameLabel.Size = new System.Drawing.Size(39, 13);
            this.armorNameLabel.TabIndex = 122;
            this.armorNameLabel.Text = "Armor";
            // 
            // armorRatingBox
            // 
            this.armorRatingBox.Location = new System.Drawing.Point(161, 147);
            this.armorRatingBox.Name = "armorRatingBox";
            this.armorRatingBox.Size = new System.Drawing.Size(57, 20);
            this.armorRatingBox.TabIndex = 121;
            this.armorRatingBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.armorRatingBox.ValueChanged += new System.EventHandler(this.armorRatingBox_ValueChanged);
            // 
            // armorRatingHeaderLabel
            // 
            this.armorRatingHeaderLabel.AutoSize = true;
            this.armorRatingHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.armorRatingHeaderLabel.Location = new System.Drawing.Point(158, 130);
            this.armorRatingHeaderLabel.Name = "armorRatingHeaderLabel";
            this.armorRatingHeaderLabel.Size = new System.Drawing.Size(80, 13);
            this.armorRatingHeaderLabel.TabIndex = 120;
            this.armorRatingHeaderLabel.Text = "Armor Rating";
            // 
            // armorKeywordsBox
            // 
            this.armorKeywordsBox.Location = new System.Drawing.Point(692, 146);
            this.armorKeywordsBox.Multiline = true;
            this.armorKeywordsBox.Name = "armorKeywordsBox";
            this.armorKeywordsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.armorKeywordsBox.Size = new System.Drawing.Size(118, 33);
            this.armorKeywordsBox.TabIndex = 119;
            // 
            // armorValueBox
            // 
            this.armorValueBox.Location = new System.Drawing.Point(588, 146);
            this.armorValueBox.Name = "armorValueBox";
            this.armorValueBox.Size = new System.Drawing.Size(89, 20);
            this.armorValueBox.TabIndex = 118;
            // 
            // armorTraitsBox
            // 
            this.armorTraitsBox.Location = new System.Drawing.Point(469, 146);
            this.armorTraitsBox.Multiline = true;
            this.armorTraitsBox.Name = "armorTraitsBox";
            this.armorTraitsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.armorTraitsBox.Size = new System.Drawing.Size(105, 33);
            this.armorTraitsBox.TabIndex = 117;
            // 
            // armorNameBox
            // 
            this.armorNameBox.Location = new System.Drawing.Point(7, 146);
            this.armorNameBox.Multiline = true;
            this.armorNameBox.Name = "armorNameBox";
            this.armorNameBox.Size = new System.Drawing.Size(132, 33);
            this.armorNameBox.TabIndex = 116;
            // 
            // meleeWeaponKeywordsBox
            // 
            this.meleeWeaponKeywordsBox.Location = new System.Drawing.Point(692, 84);
            this.meleeWeaponKeywordsBox.Multiline = true;
            this.meleeWeaponKeywordsBox.Name = "meleeWeaponKeywordsBox";
            this.meleeWeaponKeywordsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.meleeWeaponKeywordsBox.Size = new System.Drawing.Size(118, 33);
            this.meleeWeaponKeywordsBox.TabIndex = 115;
            // 
            // meleeWeaponValueBox
            // 
            this.meleeWeaponValueBox.Location = new System.Drawing.Point(588, 84);
            this.meleeWeaponValueBox.Name = "meleeWeaponValueBox";
            this.meleeWeaponValueBox.Size = new System.Drawing.Size(89, 20);
            this.meleeWeaponValueBox.TabIndex = 114;
            // 
            // meleeWeaponTraitsBox
            // 
            this.meleeWeaponTraitsBox.Location = new System.Drawing.Point(469, 84);
            this.meleeWeaponTraitsBox.Multiline = true;
            this.meleeWeaponTraitsBox.Name = "meleeWeaponTraitsBox";
            this.meleeWeaponTraitsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.meleeWeaponTraitsBox.Size = new System.Drawing.Size(105, 33);
            this.meleeWeaponTraitsBox.TabIndex = 113;
            // 
            // MeleeWeaponRangeBox
            // 
            this.MeleeWeaponRangeBox.Location = new System.Drawing.Point(338, 84);
            this.MeleeWeaponRangeBox.Multiline = true;
            this.MeleeWeaponRangeBox.Name = "MeleeWeaponRangeBox";
            this.MeleeWeaponRangeBox.Size = new System.Drawing.Size(63, 30);
            this.MeleeWeaponRangeBox.TabIndex = 112;
            // 
            // meleeWeaponAPBox
            // 
            this.meleeWeaponAPBox.Location = new System.Drawing.Point(287, 84);
            this.meleeWeaponAPBox.Name = "meleeWeaponAPBox";
            this.meleeWeaponAPBox.Size = new System.Drawing.Size(34, 20);
            this.meleeWeaponAPBox.TabIndex = 111;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 110;
            this.label2.Text = "ED";
            // 
            // meleeWeaponEDBox
            // 
            this.meleeWeaponEDBox.Location = new System.Drawing.Point(215, 84);
            this.meleeWeaponEDBox.Name = "meleeWeaponEDBox";
            this.meleeWeaponEDBox.Size = new System.Drawing.Size(34, 20);
            this.meleeWeaponEDBox.TabIndex = 109;
            this.meleeWeaponEDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 108;
            this.label3.Text = "+";
            // 
            // meleeWeaponDamageBox
            // 
            this.meleeWeaponDamageBox.Location = new System.Drawing.Point(161, 84);
            this.meleeWeaponDamageBox.Name = "meleeWeaponDamageBox";
            this.meleeWeaponDamageBox.Size = new System.Drawing.Size(40, 20);
            this.meleeWeaponDamageBox.TabIndex = 107;
            this.meleeWeaponDamageBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // meleeWeaponNameBox
            // 
            this.meleeWeaponNameBox.Location = new System.Drawing.Point(7, 84);
            this.meleeWeaponNameBox.Multiline = true;
            this.meleeWeaponNameBox.Name = "meleeWeaponNameBox";
            this.meleeWeaponNameBox.Size = new System.Drawing.Size(132, 33);
            this.meleeWeaponNameBox.TabIndex = 106;
            // 
            // meleeWeaponHeaderLabel
            // 
            this.meleeWeaponHeaderLabel.AutoSize = true;
            this.meleeWeaponHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meleeWeaponHeaderLabel.Location = new System.Drawing.Point(6, 67);
            this.meleeWeaponHeaderLabel.Name = "meleeWeaponHeaderLabel";
            this.meleeWeaponHeaderLabel.Size = new System.Drawing.Size(92, 13);
            this.meleeWeaponHeaderLabel.TabIndex = 105;
            this.meleeWeaponHeaderLabel.Text = "Melee Weapon";
            // 
            // rangedWeaponKeywordsBox
            // 
            this.rangedWeaponKeywordsBox.Location = new System.Drawing.Point(692, 21);
            this.rangedWeaponKeywordsBox.Multiline = true;
            this.rangedWeaponKeywordsBox.Name = "rangedWeaponKeywordsBox";
            this.rangedWeaponKeywordsBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rangedWeaponKeywordsBox.Size = new System.Drawing.Size(118, 33);
            this.rangedWeaponKeywordsBox.TabIndex = 104;
            // 
            // keywordsHeaderLabel
            // 
            this.keywordsHeaderLabel.AutoSize = true;
            this.keywordsHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keywordsHeaderLabel.Location = new System.Drawing.Point(689, 4);
            this.keywordsHeaderLabel.Name = "keywordsHeaderLabel";
            this.keywordsHeaderLabel.Size = new System.Drawing.Size(61, 13);
            this.keywordsHeaderLabel.TabIndex = 103;
            this.keywordsHeaderLabel.Text = "Keywords";
            // 
            // rangedWeaponValueBox
            // 
            this.rangedWeaponValueBox.Location = new System.Drawing.Point(588, 21);
            this.rangedWeaponValueBox.Name = "rangedWeaponValueBox";
            this.rangedWeaponValueBox.Size = new System.Drawing.Size(89, 20);
            this.rangedWeaponValueBox.TabIndex = 102;
            // 
            // rangedWeaponTraitBox
            // 
            this.rangedWeaponTraitBox.Location = new System.Drawing.Point(469, 21);
            this.rangedWeaponTraitBox.Multiline = true;
            this.rangedWeaponTraitBox.Name = "rangedWeaponTraitBox";
            this.rangedWeaponTraitBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rangedWeaponTraitBox.Size = new System.Drawing.Size(105, 33);
            this.rangedWeaponTraitBox.TabIndex = 101;
            // 
            // rangedWeaponSalvoBox
            // 
            this.rangedWeaponSalvoBox.Location = new System.Drawing.Point(420, 21);
            this.rangedWeaponSalvoBox.Name = "rangedWeaponSalvoBox";
            this.rangedWeaponSalvoBox.Size = new System.Drawing.Size(28, 20);
            this.rangedWeaponSalvoBox.TabIndex = 100;
            // 
            // rangedWeaponRangeBox
            // 
            this.rangedWeaponRangeBox.Location = new System.Drawing.Point(338, 21);
            this.rangedWeaponRangeBox.Name = "rangedWeaponRangeBox";
            this.rangedWeaponRangeBox.Size = new System.Drawing.Size(63, 20);
            this.rangedWeaponRangeBox.TabIndex = 99;
            // 
            // rangedWeaponAPBox
            // 
            this.rangedWeaponAPBox.Location = new System.Drawing.Point(287, 21);
            this.rangedWeaponAPBox.Name = "rangedWeaponAPBox";
            this.rangedWeaponAPBox.Size = new System.Drawing.Size(34, 20);
            this.rangedWeaponAPBox.TabIndex = 98;
            // 
            // rangedEDBoxLabel
            // 
            this.rangedEDBoxLabel.AutoSize = true;
            this.rangedEDBoxLabel.Location = new System.Drawing.Point(250, 24);
            this.rangedEDBoxLabel.Name = "rangedEDBoxLabel";
            this.rangedEDBoxLabel.Size = new System.Drawing.Size(22, 13);
            this.rangedEDBoxLabel.TabIndex = 97;
            this.rangedEDBoxLabel.Text = "ED";
            // 
            // rangedWeaponEDBox
            // 
            this.rangedWeaponEDBox.Location = new System.Drawing.Point(215, 21);
            this.rangedWeaponEDBox.Name = "rangedWeaponEDBox";
            this.rangedWeaponEDBox.Size = new System.Drawing.Size(34, 20);
            this.rangedWeaponEDBox.TabIndex = 96;
            this.rangedWeaponEDBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rangedBaseModLabel
            // 
            this.rangedBaseModLabel.AutoSize = true;
            this.rangedBaseModLabel.Location = new System.Drawing.Point(202, 24);
            this.rangedBaseModLabel.Name = "rangedBaseModLabel";
            this.rangedBaseModLabel.Size = new System.Drawing.Size(13, 13);
            this.rangedBaseModLabel.TabIndex = 95;
            this.rangedBaseModLabel.Text = "+";
            // 
            // rangedWeaponDamageBox
            // 
            this.rangedWeaponDamageBox.Location = new System.Drawing.Point(161, 21);
            this.rangedWeaponDamageBox.Name = "rangedWeaponDamageBox";
            this.rangedWeaponDamageBox.Size = new System.Drawing.Size(40, 20);
            this.rangedWeaponDamageBox.TabIndex = 94;
            this.rangedWeaponDamageBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rangedWeaponNameBox
            // 
            this.rangedWeaponNameBox.Location = new System.Drawing.Point(7, 21);
            this.rangedWeaponNameBox.Multiline = true;
            this.rangedWeaponNameBox.Name = "rangedWeaponNameBox";
            this.rangedWeaponNameBox.Size = new System.Drawing.Size(132, 33);
            this.rangedWeaponNameBox.TabIndex = 93;
            // 
            // weaponValueHeaderLabel
            // 
            this.weaponValueHeaderLabel.AutoSize = true;
            this.weaponValueHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponValueHeaderLabel.Location = new System.Drawing.Point(585, 4);
            this.weaponValueHeaderLabel.Name = "weaponValueHeaderLabel";
            this.weaponValueHeaderLabel.Size = new System.Drawing.Size(39, 13);
            this.weaponValueHeaderLabel.TabIndex = 92;
            this.weaponValueHeaderLabel.Text = "Value";
            // 
            // weaponTraitsHeaderLabel
            // 
            this.weaponTraitsHeaderLabel.AutoSize = true;
            this.weaponTraitsHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponTraitsHeaderLabel.Location = new System.Drawing.Point(466, 4);
            this.weaponTraitsHeaderLabel.Name = "weaponTraitsHeaderLabel";
            this.weaponTraitsHeaderLabel.Size = new System.Drawing.Size(39, 13);
            this.weaponTraitsHeaderLabel.TabIndex = 91;
            this.weaponTraitsHeaderLabel.Text = "Traits";
            // 
            // salvoHeaderLabel
            // 
            this.salvoHeaderLabel.AutoSize = true;
            this.salvoHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salvoHeaderLabel.Location = new System.Drawing.Point(417, 4);
            this.salvoHeaderLabel.Name = "salvoHeaderLabel";
            this.salvoHeaderLabel.Size = new System.Drawing.Size(39, 13);
            this.salvoHeaderLabel.TabIndex = 90;
            this.salvoHeaderLabel.Text = "Salvo";
            // 
            // weaponRangeHeaderLabel
            // 
            this.weaponRangeHeaderLabel.AutoSize = true;
            this.weaponRangeHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponRangeHeaderLabel.Location = new System.Drawing.Point(335, 4);
            this.weaponRangeHeaderLabel.Name = "weaponRangeHeaderLabel";
            this.weaponRangeHeaderLabel.Size = new System.Drawing.Size(44, 13);
            this.weaponRangeHeaderLabel.TabIndex = 89;
            this.weaponRangeHeaderLabel.Text = "Range";
            // 
            // apHeaderLabel
            // 
            this.apHeaderLabel.AutoSize = true;
            this.apHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apHeaderLabel.Location = new System.Drawing.Point(286, 4);
            this.apHeaderLabel.Name = "apHeaderLabel";
            this.apHeaderLabel.Size = new System.Drawing.Size(23, 13);
            this.apHeaderLabel.TabIndex = 88;
            this.apHeaderLabel.Text = "AP";
            // 
            // weaponDamageHeaderLabel
            // 
            this.weaponDamageHeaderLabel.AutoSize = true;
            this.weaponDamageHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponDamageHeaderLabel.Location = new System.Drawing.Point(158, 4);
            this.weaponDamageHeaderLabel.Name = "weaponDamageHeaderLabel";
            this.weaponDamageHeaderLabel.Size = new System.Drawing.Size(104, 13);
            this.weaponDamageHeaderLabel.TabIndex = 87;
            this.weaponDamageHeaderLabel.Text = "Weapon Damage";
            // 
            // rangedWeaponHeaderLabel
            // 
            this.rangedWeaponHeaderLabel.AutoSize = true;
            this.rangedWeaponHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rangedWeaponHeaderLabel.Location = new System.Drawing.Point(6, 4);
            this.rangedWeaponHeaderLabel.Name = "rangedWeaponHeaderLabel";
            this.rangedWeaponHeaderLabel.Size = new System.Drawing.Size(102, 13);
            this.rangedWeaponHeaderLabel.TabIndex = 86;
            this.rangedWeaponHeaderLabel.Text = "Ranged Weapon";
            // 
            // armorHeaderLabel
            // 
            this.armorHeaderLabel.AutoSize = true;
            this.armorHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.armorHeaderLabel.Location = new System.Drawing.Point(-51, 139);
            this.armorHeaderLabel.Name = "armorHeaderLabel";
            this.armorHeaderLabel.Size = new System.Drawing.Size(39, 13);
            this.armorHeaderLabel.TabIndex = 79;
            this.armorHeaderLabel.Text = "Armor";
            // 
            // miscEquipmentHeaderLabel
            // 
            this.miscEquipmentHeaderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.miscEquipmentHeaderLabel.AutoSize = true;
            this.miscEquipmentHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscEquipmentHeaderLabel.Location = new System.Drawing.Point(5, 7);
            this.miscEquipmentHeaderLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 12);
            this.miscEquipmentHeaderLabel.Name = "miscEquipmentHeaderLabel";
            this.miscEquipmentHeaderLabel.Size = new System.Drawing.Size(318, 13);
            this.miscEquipmentHeaderLabel.TabIndex = 49;
            this.miscEquipmentHeaderLabel.Text = "Miscellaneous Equipment (Trinkets, Ammo, Tools, etc.)";
            // 
            // equipmentTextBox
            // 
            this.equipmentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.equipmentTextBox.Location = new System.Drawing.Point(2, 26);
            this.equipmentTextBox.Name = "equipmentTextBox";
            this.equipmentTextBox.Size = new System.Drawing.Size(817, 222);
            this.equipmentTextBox.TabIndex = 48;
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
            this.removeAugButton.TabIndex = 42;
            this.removeAugButton.Text = "Remove";
            this.removeAugButton.UseVisualStyleBackColor = true;
            this.removeAugButton.Click += new System.EventHandler(this.removeAugButton_Click);
            // 
            // addAugButton
            // 
            this.addAugButton.Location = new System.Drawing.Point(6, 359);
            this.addAugButton.Name = "addAugButton";
            this.addAugButton.Size = new System.Drawing.Size(94, 23);
            this.addAugButton.TabIndex = 41;
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
            this.augmeticsBox.TabIndex = 40;
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
            this.psychicpowers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.psychicpowers.Controls.Add(this.splitContainer2);
            this.psychicpowers.Location = new System.Drawing.Point(4, 22);
            this.psychicpowers.Name = "psychicpowers";
            this.psychicpowers.Padding = new System.Windows.Forms.Padding(3);
            this.psychicpowers.Size = new System.Drawing.Size(825, 509);
            this.psychicpowers.TabIndex = 3;
            this.psychicpowers.Text = "Psychic Powers";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.AutoScrollMargin = new System.Drawing.Size(12, 12);
            this.splitContainer2.Panel1.Controls.Add(this.powerPotencyBox24);
            this.splitContainer2.Panel1.Controls.Add(this.powerPotencyBox23);
            this.splitContainer2.Panel1.Controls.Add(this.powerPotencyBox22);
            this.splitContainer2.Panel1.Controls.Add(this.powerPotencyBox21);
            this.splitContainer2.Panel1.Controls.Add(this.powerPotencyBox20);
            this.splitContainer2.Panel1.Controls.Add(this.powerPotencyBox19);
            this.splitContainer2.Panel1.Controls.Add(this.powerPotencyBox18);
            this.splitContainer2.Panel1.Controls.Add(this.powerPotencyBox17);
            this.splitContainer2.Panel1.Controls.Add(this.powerPotencyBox16);
            this.splitContainer2.Panel1.Controls.Add(this.powerPotencyBox15);
            this.splitContainer2.Panel1.Controls.Add(this.powerPotencyBox14);
            this.splitContainer2.Panel1.Controls.Add(this.powerPotencyBox13);
            this.splitContainer2.Panel1.Controls.Add(this.powerPotencyBox12);
            this.splitContainer2.Panel1.Controls.Add(this.powerPotencyBox11);
            this.splitContainer2.Panel1.Controls.Add(this.powerPotencyBox10);
            this.splitContainer2.Panel1.Controls.Add(this.powerPotencyBox9);
            this.splitContainer2.Panel1.Controls.Add(this.powerPotencyBox8);
            this.splitContainer2.Panel1.Controls.Add(this.powerPotencyBox7);
            this.splitContainer2.Panel1.Controls.Add(this.powerPotencyBox6);
            this.splitContainer2.Panel1.Controls.Add(this.powerPotencyBox5);
            this.splitContainer2.Panel1.Controls.Add(this.powerPotencyBox4);
            this.splitContainer2.Panel1.Controls.Add(this.powerPotencyBox3);
            this.splitContainer2.Panel1.Controls.Add(this.powerPotencyBox2);
            this.splitContainer2.Panel1.Controls.Add(this.powerPotencyBox1);
            this.splitContainer2.Panel1.Controls.Add(this.powerPotentcyLabel);
            this.splitContainer2.Panel1.Controls.Add(this.powerMultiCheckBox24);
            this.splitContainer2.Panel1.Controls.Add(this.powerDurationBox24);
            this.splitContainer2.Panel1.Controls.Add(this.powerKeywordBox24);
            this.splitContainer2.Panel1.Controls.Add(this.powerDNBox24);
            this.splitContainer2.Panel1.Controls.Add(this.powerRangeBox24);
            this.splitContainer2.Panel1.Controls.Add(this.powerActivationBox24);
            this.splitContainer2.Panel1.Controls.Add(this.label57);
            this.splitContainer2.Panel1.Controls.Add(this.powerEDBox24);
            this.splitContainer2.Panel1.Controls.Add(this.label58);
            this.splitContainer2.Panel1.Controls.Add(this.powerDamageBox24);
            this.splitContainer2.Panel1.Controls.Add(this.powerNameBox24);
            this.splitContainer2.Panel1.Controls.Add(this.powerMultiCheckBox23);
            this.splitContainer2.Panel1.Controls.Add(this.powerDurationBox23);
            this.splitContainer2.Panel1.Controls.Add(this.powerKeywordBox23);
            this.splitContainer2.Panel1.Controls.Add(this.powerDNBox23);
            this.splitContainer2.Panel1.Controls.Add(this.powerRangeBox23);
            this.splitContainer2.Panel1.Controls.Add(this.powerActivationBox23);
            this.splitContainer2.Panel1.Controls.Add(this.label59);
            this.splitContainer2.Panel1.Controls.Add(this.powerEDBox23);
            this.splitContainer2.Panel1.Controls.Add(this.label60);
            this.splitContainer2.Panel1.Controls.Add(this.powerDamageBox23);
            this.splitContainer2.Panel1.Controls.Add(this.powerNameBox23);
            this.splitContainer2.Panel1.Controls.Add(this.powerMultiCheckBox22);
            this.splitContainer2.Panel1.Controls.Add(this.powerDurationBox22);
            this.splitContainer2.Panel1.Controls.Add(this.powerKeywordBox22);
            this.splitContainer2.Panel1.Controls.Add(this.powerDNBox22);
            this.splitContainer2.Panel1.Controls.Add(this.powerRangeBox22);
            this.splitContainer2.Panel1.Controls.Add(this.powerActivationBox22);
            this.splitContainer2.Panel1.Controls.Add(this.label61);
            this.splitContainer2.Panel1.Controls.Add(this.powerEDBox22);
            this.splitContainer2.Panel1.Controls.Add(this.label62);
            this.splitContainer2.Panel1.Controls.Add(this.powerDamageBox22);
            this.splitContainer2.Panel1.Controls.Add(this.powerNameBox22);
            this.splitContainer2.Panel1.Controls.Add(this.powerMultiCheckBox21);
            this.splitContainer2.Panel1.Controls.Add(this.powerDurationBox21);
            this.splitContainer2.Panel1.Controls.Add(this.powerKeywordBox21);
            this.splitContainer2.Panel1.Controls.Add(this.powerDNBox21);
            this.splitContainer2.Panel1.Controls.Add(this.powerRangeBox21);
            this.splitContainer2.Panel1.Controls.Add(this.powerActivationBox21);
            this.splitContainer2.Panel1.Controls.Add(this.label63);
            this.splitContainer2.Panel1.Controls.Add(this.powerEDBox21);
            this.splitContainer2.Panel1.Controls.Add(this.label64);
            this.splitContainer2.Panel1.Controls.Add(this.powerDamageBox21);
            this.splitContainer2.Panel1.Controls.Add(this.powerNameBox21);
            this.splitContainer2.Panel1.Controls.Add(this.powerMultiCheckBox20);
            this.splitContainer2.Panel1.Controls.Add(this.powerDurationBox20);
            this.splitContainer2.Panel1.Controls.Add(this.powerKeywordBox20);
            this.splitContainer2.Panel1.Controls.Add(this.powerDNBox20);
            this.splitContainer2.Panel1.Controls.Add(this.powerRangeBox20);
            this.splitContainer2.Panel1.Controls.Add(this.powerActivationBox20);
            this.splitContainer2.Panel1.Controls.Add(this.label51);
            this.splitContainer2.Panel1.Controls.Add(this.powerEDBox20);
            this.splitContainer2.Panel1.Controls.Add(this.label52);
            this.splitContainer2.Panel1.Controls.Add(this.powerDamageBox20);
            this.splitContainer2.Panel1.Controls.Add(this.powerNameBox20);
            this.splitContainer2.Panel1.Controls.Add(this.powerMultiCheckBox19);
            this.splitContainer2.Panel1.Controls.Add(this.powerDurationBox19);
            this.splitContainer2.Panel1.Controls.Add(this.powerKeywordBox19);
            this.splitContainer2.Panel1.Controls.Add(this.powerDNBox19);
            this.splitContainer2.Panel1.Controls.Add(this.powerRangeBox19);
            this.splitContainer2.Panel1.Controls.Add(this.powerActivationBox19);
            this.splitContainer2.Panel1.Controls.Add(this.label53);
            this.splitContainer2.Panel1.Controls.Add(this.powerEDBox19);
            this.splitContainer2.Panel1.Controls.Add(this.label54);
            this.splitContainer2.Panel1.Controls.Add(this.powerDamageBox19);
            this.splitContainer2.Panel1.Controls.Add(this.powerNameBox19);
            this.splitContainer2.Panel1.Controls.Add(this.powerMultiCheckBox18);
            this.splitContainer2.Panel1.Controls.Add(this.powerDurationBox18);
            this.splitContainer2.Panel1.Controls.Add(this.powerKeywordBox18);
            this.splitContainer2.Panel1.Controls.Add(this.powerDNBox18);
            this.splitContainer2.Panel1.Controls.Add(this.powerRangeBox18);
            this.splitContainer2.Panel1.Controls.Add(this.powerActivationBox18);
            this.splitContainer2.Panel1.Controls.Add(this.label55);
            this.splitContainer2.Panel1.Controls.Add(this.powerEDBox18);
            this.splitContainer2.Panel1.Controls.Add(this.label56);
            this.splitContainer2.Panel1.Controls.Add(this.powerDamageBox18);
            this.splitContainer2.Panel1.Controls.Add(this.powerNameBox18);
            this.splitContainer2.Panel1.Controls.Add(this.powerMultiCheckBox17);
            this.splitContainer2.Panel1.Controls.Add(this.powerDurationBox17);
            this.splitContainer2.Panel1.Controls.Add(this.powerKeywordBox17);
            this.splitContainer2.Panel1.Controls.Add(this.powerDNBox17);
            this.splitContainer2.Panel1.Controls.Add(this.powerRangeBox17);
            this.splitContainer2.Panel1.Controls.Add(this.powerActivationBox17);
            this.splitContainer2.Panel1.Controls.Add(this.label45);
            this.splitContainer2.Panel1.Controls.Add(this.powerEDBox17);
            this.splitContainer2.Panel1.Controls.Add(this.label46);
            this.splitContainer2.Panel1.Controls.Add(this.powerDamageBox17);
            this.splitContainer2.Panel1.Controls.Add(this.powerNameBox17);
            this.splitContainer2.Panel1.Controls.Add(this.powerMultiCheckBox16);
            this.splitContainer2.Panel1.Controls.Add(this.powerDurationBox16);
            this.splitContainer2.Panel1.Controls.Add(this.powerKeywordBox16);
            this.splitContainer2.Panel1.Controls.Add(this.powerDNBox16);
            this.splitContainer2.Panel1.Controls.Add(this.powerRangeBox16);
            this.splitContainer2.Panel1.Controls.Add(this.powerActivationBox16);
            this.splitContainer2.Panel1.Controls.Add(this.label47);
            this.splitContainer2.Panel1.Controls.Add(this.powerEDBox16);
            this.splitContainer2.Panel1.Controls.Add(this.label48);
            this.splitContainer2.Panel1.Controls.Add(this.powerDamageBox16);
            this.splitContainer2.Panel1.Controls.Add(this.powerNameBox16);
            this.splitContainer2.Panel1.Controls.Add(this.powerMultiCheckBox15);
            this.splitContainer2.Panel1.Controls.Add(this.powerDurationBox15);
            this.splitContainer2.Panel1.Controls.Add(this.powerKeywordBox15);
            this.splitContainer2.Panel1.Controls.Add(this.powerDNBox15);
            this.splitContainer2.Panel1.Controls.Add(this.powerRangeBox15);
            this.splitContainer2.Panel1.Controls.Add(this.powerActivationBox15);
            this.splitContainer2.Panel1.Controls.Add(this.label49);
            this.splitContainer2.Panel1.Controls.Add(this.powerEDBox15);
            this.splitContainer2.Panel1.Controls.Add(this.label50);
            this.splitContainer2.Panel1.Controls.Add(this.powerDamageBox15);
            this.splitContainer2.Panel1.Controls.Add(this.powerNameBox15);
            this.splitContainer2.Panel1.Controls.Add(this.powerMultiCheckBox14);
            this.splitContainer2.Panel1.Controls.Add(this.powerDurationBox14);
            this.splitContainer2.Panel1.Controls.Add(this.powerKeywordBox14);
            this.splitContainer2.Panel1.Controls.Add(this.powerDNBox14);
            this.splitContainer2.Panel1.Controls.Add(this.powerRangeBox14);
            this.splitContainer2.Panel1.Controls.Add(this.powerActivationBox14);
            this.splitContainer2.Panel1.Controls.Add(this.label39);
            this.splitContainer2.Panel1.Controls.Add(this.powerEDBox14);
            this.splitContainer2.Panel1.Controls.Add(this.label40);
            this.splitContainer2.Panel1.Controls.Add(this.powerDamageBox14);
            this.splitContainer2.Panel1.Controls.Add(this.powerNameBox14);
            this.splitContainer2.Panel1.Controls.Add(this.powerMultiCheckBox13);
            this.splitContainer2.Panel1.Controls.Add(this.powerDurationBox13);
            this.splitContainer2.Panel1.Controls.Add(this.powerKeywordBox13);
            this.splitContainer2.Panel1.Controls.Add(this.powerDNBox13);
            this.splitContainer2.Panel1.Controls.Add(this.powerRangeBox13);
            this.splitContainer2.Panel1.Controls.Add(this.powerActivationBox13);
            this.splitContainer2.Panel1.Controls.Add(this.label41);
            this.splitContainer2.Panel1.Controls.Add(this.powerEDBox13);
            this.splitContainer2.Panel1.Controls.Add(this.label42);
            this.splitContainer2.Panel1.Controls.Add(this.powerDamageBox13);
            this.splitContainer2.Panel1.Controls.Add(this.powerNameBox13);
            this.splitContainer2.Panel1.Controls.Add(this.powerMultiCheckBox12);
            this.splitContainer2.Panel1.Controls.Add(this.powerDurationBox12);
            this.splitContainer2.Panel1.Controls.Add(this.powerKeywordBox12);
            this.splitContainer2.Panel1.Controls.Add(this.powerDNBox12);
            this.splitContainer2.Panel1.Controls.Add(this.powerRangeBox12);
            this.splitContainer2.Panel1.Controls.Add(this.powerActivationBox12);
            this.splitContainer2.Panel1.Controls.Add(this.label43);
            this.splitContainer2.Panel1.Controls.Add(this.powerEDBox12);
            this.splitContainer2.Panel1.Controls.Add(this.label44);
            this.splitContainer2.Panel1.Controls.Add(this.powerDamageBox12);
            this.splitContainer2.Panel1.Controls.Add(this.powerNameBox12);
            this.splitContainer2.Panel1.Controls.Add(this.powerMultiCheckBox11);
            this.splitContainer2.Panel1.Controls.Add(this.powerDurationBox11);
            this.splitContainer2.Panel1.Controls.Add(this.powerKeywordBox11);
            this.splitContainer2.Panel1.Controls.Add(this.powerDNBox11);
            this.splitContainer2.Panel1.Controls.Add(this.powerRangeBox11);
            this.splitContainer2.Panel1.Controls.Add(this.powerActivationBox11);
            this.splitContainer2.Panel1.Controls.Add(this.label29);
            this.splitContainer2.Panel1.Controls.Add(this.powerEDBox11);
            this.splitContainer2.Panel1.Controls.Add(this.label30);
            this.splitContainer2.Panel1.Controls.Add(this.powerDamageBox11);
            this.splitContainer2.Panel1.Controls.Add(this.powerNameBox11);
            this.splitContainer2.Panel1.Controls.Add(this.powerMultiCheckBox10);
            this.splitContainer2.Panel1.Controls.Add(this.powerDurationBox10);
            this.splitContainer2.Panel1.Controls.Add(this.powerKeywordBox10);
            this.splitContainer2.Panel1.Controls.Add(this.powerDNBox10);
            this.splitContainer2.Panel1.Controls.Add(this.powerRangeBox10);
            this.splitContainer2.Panel1.Controls.Add(this.powerActivationBox10);
            this.splitContainer2.Panel1.Controls.Add(this.label31);
            this.splitContainer2.Panel1.Controls.Add(this.powerEDBox10);
            this.splitContainer2.Panel1.Controls.Add(this.label32);
            this.splitContainer2.Panel1.Controls.Add(this.powerDamageBox10);
            this.splitContainer2.Panel1.Controls.Add(this.powerNameBox10);
            this.splitContainer2.Panel1.Controls.Add(this.powerMultiCheckBox9);
            this.splitContainer2.Panel1.Controls.Add(this.powerDurationBox9);
            this.splitContainer2.Panel1.Controls.Add(this.powerKeywordBox9);
            this.splitContainer2.Panel1.Controls.Add(this.powerDNBox9);
            this.splitContainer2.Panel1.Controls.Add(this.powerRangeBox9);
            this.splitContainer2.Panel1.Controls.Add(this.powerActivationBox9);
            this.splitContainer2.Panel1.Controls.Add(this.label33);
            this.splitContainer2.Panel1.Controls.Add(this.powerEDBox9);
            this.splitContainer2.Panel1.Controls.Add(this.label34);
            this.splitContainer2.Panel1.Controls.Add(this.powerDamageBox9);
            this.splitContainer2.Panel1.Controls.Add(this.powerNameBox9);
            this.splitContainer2.Panel1.Controls.Add(this.powerMultiCheckBox8);
            this.splitContainer2.Panel1.Controls.Add(this.powerDurationBox8);
            this.splitContainer2.Panel1.Controls.Add(this.powerKeywordBox8);
            this.splitContainer2.Panel1.Controls.Add(this.powerDNBox8);
            this.splitContainer2.Panel1.Controls.Add(this.powerRangeBox8);
            this.splitContainer2.Panel1.Controls.Add(this.powerActivationBox8);
            this.splitContainer2.Panel1.Controls.Add(this.label35);
            this.splitContainer2.Panel1.Controls.Add(this.powerEDBox8);
            this.splitContainer2.Panel1.Controls.Add(this.label36);
            this.splitContainer2.Panel1.Controls.Add(this.powerDamageBox8);
            this.splitContainer2.Panel1.Controls.Add(this.powerNameBox8);
            this.splitContainer2.Panel1.Controls.Add(this.powerMultiCheckBox7);
            this.splitContainer2.Panel1.Controls.Add(this.powerDurationBox7);
            this.splitContainer2.Panel1.Controls.Add(this.powerKeywordBox7);
            this.splitContainer2.Panel1.Controls.Add(this.powerDNBox7);
            this.splitContainer2.Panel1.Controls.Add(this.powerRangeBox7);
            this.splitContainer2.Panel1.Controls.Add(this.powerActivationBox7);
            this.splitContainer2.Panel1.Controls.Add(this.label37);
            this.splitContainer2.Panel1.Controls.Add(this.powerEDBox7);
            this.splitContainer2.Panel1.Controls.Add(this.label38);
            this.splitContainer2.Panel1.Controls.Add(this.powerDamageBox7);
            this.splitContainer2.Panel1.Controls.Add(this.powerNameBox7);
            this.splitContainer2.Panel1.Controls.Add(this.powerMultiCheckBox6);
            this.splitContainer2.Panel1.Controls.Add(this.powerDurationBox6);
            this.splitContainer2.Panel1.Controls.Add(this.powerKeywordBox6);
            this.splitContainer2.Panel1.Controls.Add(this.powerDNBox6);
            this.splitContainer2.Panel1.Controls.Add(this.powerRangeBox6);
            this.splitContainer2.Panel1.Controls.Add(this.powerActivationBox6);
            this.splitContainer2.Panel1.Controls.Add(this.label23);
            this.splitContainer2.Panel1.Controls.Add(this.powerEDBox6);
            this.splitContainer2.Panel1.Controls.Add(this.label24);
            this.splitContainer2.Panel1.Controls.Add(this.powerDamageBox6);
            this.splitContainer2.Panel1.Controls.Add(this.powerNameBox6);
            this.splitContainer2.Panel1.Controls.Add(this.powerMultiCheckBox5);
            this.splitContainer2.Panel1.Controls.Add(this.powerDurationBox5);
            this.splitContainer2.Panel1.Controls.Add(this.powerKeywordBox5);
            this.splitContainer2.Panel1.Controls.Add(this.powerDNBox5);
            this.splitContainer2.Panel1.Controls.Add(this.powerRangeBox5);
            this.splitContainer2.Panel1.Controls.Add(this.powerActivationBox5);
            this.splitContainer2.Panel1.Controls.Add(this.label25);
            this.splitContainer2.Panel1.Controls.Add(this.powerEDBox5);
            this.splitContainer2.Panel1.Controls.Add(this.label26);
            this.splitContainer2.Panel1.Controls.Add(this.powerDamageBox5);
            this.splitContainer2.Panel1.Controls.Add(this.powerNameBox5);
            this.splitContainer2.Panel1.Controls.Add(this.powerMultiCheckBox4);
            this.splitContainer2.Panel1.Controls.Add(this.powerDurationBox4);
            this.splitContainer2.Panel1.Controls.Add(this.powerKeywordBox4);
            this.splitContainer2.Panel1.Controls.Add(this.powerDNBox4);
            this.splitContainer2.Panel1.Controls.Add(this.powerRangeBox4);
            this.splitContainer2.Panel1.Controls.Add(this.powerActivationBox4);
            this.splitContainer2.Panel1.Controls.Add(this.label27);
            this.splitContainer2.Panel1.Controls.Add(this.powerEDBox4);
            this.splitContainer2.Panel1.Controls.Add(this.label28);
            this.splitContainer2.Panel1.Controls.Add(this.powerDamageBox4);
            this.splitContainer2.Panel1.Controls.Add(this.powerNameBox4);
            this.splitContainer2.Panel1.Controls.Add(this.powerMultiCheckBox3);
            this.splitContainer2.Panel1.Controls.Add(this.powerDurationBox3);
            this.splitContainer2.Panel1.Controls.Add(this.powerKeywordBox3);
            this.splitContainer2.Panel1.Controls.Add(this.powerDNBox3);
            this.splitContainer2.Panel1.Controls.Add(this.powerRangeBox3);
            this.splitContainer2.Panel1.Controls.Add(this.powerActivationBox3);
            this.splitContainer2.Panel1.Controls.Add(this.label9);
            this.splitContainer2.Panel1.Controls.Add(this.powerEDBox3);
            this.splitContainer2.Panel1.Controls.Add(this.label10);
            this.splitContainer2.Panel1.Controls.Add(this.powerDamageBox3);
            this.splitContainer2.Panel1.Controls.Add(this.powerNameBox3);
            this.splitContainer2.Panel1.Controls.Add(this.powerMultiCheckBox2);
            this.splitContainer2.Panel1.Controls.Add(this.powerDurationBox2);
            this.splitContainer2.Panel1.Controls.Add(this.powerKeywordBox2);
            this.splitContainer2.Panel1.Controls.Add(this.powerDNBox2);
            this.splitContainer2.Panel1.Controls.Add(this.powerRangeBox2);
            this.splitContainer2.Panel1.Controls.Add(this.powerActivationBox2);
            this.splitContainer2.Panel1.Controls.Add(this.label11);
            this.splitContainer2.Panel1.Controls.Add(this.powerEDBox2);
            this.splitContainer2.Panel1.Controls.Add(this.label12);
            this.splitContainer2.Panel1.Controls.Add(this.powerDamageBox2);
            this.splitContainer2.Panel1.Controls.Add(this.powerNameBox2);
            this.splitContainer2.Panel1.Controls.Add(this.powerMultiCheckBox1);
            this.splitContainer2.Panel1.Controls.Add(this.label13);
            this.splitContainer2.Panel1.Controls.Add(this.powerDurationBox1);
            this.splitContainer2.Panel1.Controls.Add(this.label14);
            this.splitContainer2.Panel1.Controls.Add(this.powerKeywordBox1);
            this.splitContainer2.Panel1.Controls.Add(this.label15);
            this.splitContainer2.Panel1.Controls.Add(this.powerDNBox1);
            this.splitContainer2.Panel1.Controls.Add(this.powerRangeBox1);
            this.splitContainer2.Panel1.Controls.Add(this.powerActivationBox1);
            this.splitContainer2.Panel1.Controls.Add(this.label16);
            this.splitContainer2.Panel1.Controls.Add(this.powerEDBox1);
            this.splitContainer2.Panel1.Controls.Add(this.label17);
            this.splitContainer2.Panel1.Controls.Add(this.powerDamageBox1);
            this.splitContainer2.Panel1.Controls.Add(this.powerNameBox1);
            this.splitContainer2.Panel1.Controls.Add(this.label18);
            this.splitContainer2.Panel1.Controls.Add(this.label19);
            this.splitContainer2.Panel1.Controls.Add(this.label20);
            this.splitContainer2.Panel1.Controls.Add(this.label21);
            this.splitContainer2.Panel1.Controls.Add(this.label22);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label65);
            this.splitContainer2.Panel2.Controls.Add(this.powersTextBox);
            this.splitContainer2.Size = new System.Drawing.Size(819, 503);
            this.splitContainer2.SplitterDistance = 259;
            this.splitContainer2.TabIndex = 0;
            // 
            // powerPotencyBox24
            // 
            this.powerPotencyBox24.Location = new System.Drawing.Point(758, 918);
            this.powerPotencyBox24.Multiline = true;
            this.powerPotencyBox24.Name = "powerPotencyBox24";
            this.powerPotencyBox24.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerPotencyBox24.Size = new System.Drawing.Size(168, 33);
            this.powerPotencyBox24.TabIndex = 403;
            // 
            // powerPotencyBox23
            // 
            this.powerPotencyBox23.Location = new System.Drawing.Point(758, 879);
            this.powerPotencyBox23.Multiline = true;
            this.powerPotencyBox23.Name = "powerPotencyBox23";
            this.powerPotencyBox23.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerPotencyBox23.Size = new System.Drawing.Size(168, 33);
            this.powerPotencyBox23.TabIndex = 402;
            // 
            // powerPotencyBox22
            // 
            this.powerPotencyBox22.Location = new System.Drawing.Point(758, 840);
            this.powerPotencyBox22.Multiline = true;
            this.powerPotencyBox22.Name = "powerPotencyBox22";
            this.powerPotencyBox22.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerPotencyBox22.Size = new System.Drawing.Size(168, 33);
            this.powerPotencyBox22.TabIndex = 401;
            // 
            // powerPotencyBox21
            // 
            this.powerPotencyBox21.Location = new System.Drawing.Point(758, 801);
            this.powerPotencyBox21.Multiline = true;
            this.powerPotencyBox21.Name = "powerPotencyBox21";
            this.powerPotencyBox21.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerPotencyBox21.Size = new System.Drawing.Size(168, 33);
            this.powerPotencyBox21.TabIndex = 400;
            // 
            // powerPotencyBox20
            // 
            this.powerPotencyBox20.Location = new System.Drawing.Point(758, 762);
            this.powerPotencyBox20.Multiline = true;
            this.powerPotencyBox20.Name = "powerPotencyBox20";
            this.powerPotencyBox20.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerPotencyBox20.Size = new System.Drawing.Size(168, 33);
            this.powerPotencyBox20.TabIndex = 399;
            // 
            // powerPotencyBox19
            // 
            this.powerPotencyBox19.Location = new System.Drawing.Point(758, 723);
            this.powerPotencyBox19.Multiline = true;
            this.powerPotencyBox19.Name = "powerPotencyBox19";
            this.powerPotencyBox19.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerPotencyBox19.Size = new System.Drawing.Size(168, 33);
            this.powerPotencyBox19.TabIndex = 398;
            // 
            // powerPotencyBox18
            // 
            this.powerPotencyBox18.Location = new System.Drawing.Point(758, 684);
            this.powerPotencyBox18.Multiline = true;
            this.powerPotencyBox18.Name = "powerPotencyBox18";
            this.powerPotencyBox18.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerPotencyBox18.Size = new System.Drawing.Size(168, 33);
            this.powerPotencyBox18.TabIndex = 397;
            // 
            // powerPotencyBox17
            // 
            this.powerPotencyBox17.Location = new System.Drawing.Point(758, 645);
            this.powerPotencyBox17.Multiline = true;
            this.powerPotencyBox17.Name = "powerPotencyBox17";
            this.powerPotencyBox17.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerPotencyBox17.Size = new System.Drawing.Size(168, 33);
            this.powerPotencyBox17.TabIndex = 396;
            // 
            // powerPotencyBox16
            // 
            this.powerPotencyBox16.Location = new System.Drawing.Point(758, 606);
            this.powerPotencyBox16.Multiline = true;
            this.powerPotencyBox16.Name = "powerPotencyBox16";
            this.powerPotencyBox16.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerPotencyBox16.Size = new System.Drawing.Size(168, 33);
            this.powerPotencyBox16.TabIndex = 395;
            // 
            // powerPotencyBox15
            // 
            this.powerPotencyBox15.Location = new System.Drawing.Point(758, 567);
            this.powerPotencyBox15.Multiline = true;
            this.powerPotencyBox15.Name = "powerPotencyBox15";
            this.powerPotencyBox15.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerPotencyBox15.Size = new System.Drawing.Size(168, 33);
            this.powerPotencyBox15.TabIndex = 394;
            // 
            // powerPotencyBox14
            // 
            this.powerPotencyBox14.Location = new System.Drawing.Point(758, 528);
            this.powerPotencyBox14.Multiline = true;
            this.powerPotencyBox14.Name = "powerPotencyBox14";
            this.powerPotencyBox14.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerPotencyBox14.Size = new System.Drawing.Size(168, 33);
            this.powerPotencyBox14.TabIndex = 393;
            // 
            // powerPotencyBox13
            // 
            this.powerPotencyBox13.Location = new System.Drawing.Point(758, 489);
            this.powerPotencyBox13.Multiline = true;
            this.powerPotencyBox13.Name = "powerPotencyBox13";
            this.powerPotencyBox13.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerPotencyBox13.Size = new System.Drawing.Size(168, 33);
            this.powerPotencyBox13.TabIndex = 392;
            // 
            // powerPotencyBox12
            // 
            this.powerPotencyBox12.Location = new System.Drawing.Point(758, 449);
            this.powerPotencyBox12.Multiline = true;
            this.powerPotencyBox12.Name = "powerPotencyBox12";
            this.powerPotencyBox12.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerPotencyBox12.Size = new System.Drawing.Size(168, 33);
            this.powerPotencyBox12.TabIndex = 391;
            // 
            // powerPotencyBox11
            // 
            this.powerPotencyBox11.Location = new System.Drawing.Point(758, 410);
            this.powerPotencyBox11.Multiline = true;
            this.powerPotencyBox11.Name = "powerPotencyBox11";
            this.powerPotencyBox11.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerPotencyBox11.Size = new System.Drawing.Size(168, 33);
            this.powerPotencyBox11.TabIndex = 390;
            // 
            // powerPotencyBox10
            // 
            this.powerPotencyBox10.Location = new System.Drawing.Point(758, 371);
            this.powerPotencyBox10.Multiline = true;
            this.powerPotencyBox10.Name = "powerPotencyBox10";
            this.powerPotencyBox10.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerPotencyBox10.Size = new System.Drawing.Size(168, 33);
            this.powerPotencyBox10.TabIndex = 389;
            // 
            // powerPotencyBox9
            // 
            this.powerPotencyBox9.Location = new System.Drawing.Point(758, 332);
            this.powerPotencyBox9.Multiline = true;
            this.powerPotencyBox9.Name = "powerPotencyBox9";
            this.powerPotencyBox9.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerPotencyBox9.Size = new System.Drawing.Size(168, 33);
            this.powerPotencyBox9.TabIndex = 388;
            // 
            // powerPotencyBox8
            // 
            this.powerPotencyBox8.Location = new System.Drawing.Point(758, 293);
            this.powerPotencyBox8.Multiline = true;
            this.powerPotencyBox8.Name = "powerPotencyBox8";
            this.powerPotencyBox8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerPotencyBox8.Size = new System.Drawing.Size(168, 33);
            this.powerPotencyBox8.TabIndex = 387;
            // 
            // powerPotencyBox7
            // 
            this.powerPotencyBox7.Location = new System.Drawing.Point(758, 254);
            this.powerPotencyBox7.Multiline = true;
            this.powerPotencyBox7.Name = "powerPotencyBox7";
            this.powerPotencyBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerPotencyBox7.Size = new System.Drawing.Size(168, 33);
            this.powerPotencyBox7.TabIndex = 386;
            // 
            // powerPotencyBox6
            // 
            this.powerPotencyBox6.Location = new System.Drawing.Point(758, 216);
            this.powerPotencyBox6.Multiline = true;
            this.powerPotencyBox6.Name = "powerPotencyBox6";
            this.powerPotencyBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerPotencyBox6.Size = new System.Drawing.Size(168, 33);
            this.powerPotencyBox6.TabIndex = 385;
            // 
            // powerPotencyBox5
            // 
            this.powerPotencyBox5.Location = new System.Drawing.Point(758, 177);
            this.powerPotencyBox5.Multiline = true;
            this.powerPotencyBox5.Name = "powerPotencyBox5";
            this.powerPotencyBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerPotencyBox5.Size = new System.Drawing.Size(168, 33);
            this.powerPotencyBox5.TabIndex = 384;
            // 
            // powerPotencyBox4
            // 
            this.powerPotencyBox4.Location = new System.Drawing.Point(758, 138);
            this.powerPotencyBox4.Multiline = true;
            this.powerPotencyBox4.Name = "powerPotencyBox4";
            this.powerPotencyBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerPotencyBox4.Size = new System.Drawing.Size(168, 33);
            this.powerPotencyBox4.TabIndex = 383;
            // 
            // powerPotencyBox3
            // 
            this.powerPotencyBox3.Location = new System.Drawing.Point(758, 99);
            this.powerPotencyBox3.Multiline = true;
            this.powerPotencyBox3.Name = "powerPotencyBox3";
            this.powerPotencyBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerPotencyBox3.Size = new System.Drawing.Size(168, 33);
            this.powerPotencyBox3.TabIndex = 382;
            // 
            // powerPotencyBox2
            // 
            this.powerPotencyBox2.Location = new System.Drawing.Point(758, 60);
            this.powerPotencyBox2.Multiline = true;
            this.powerPotencyBox2.Name = "powerPotencyBox2";
            this.powerPotencyBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerPotencyBox2.Size = new System.Drawing.Size(168, 33);
            this.powerPotencyBox2.TabIndex = 381;
            // 
            // powerPotencyBox1
            // 
            this.powerPotencyBox1.Location = new System.Drawing.Point(758, 21);
            this.powerPotencyBox1.Multiline = true;
            this.powerPotencyBox1.Name = "powerPotencyBox1";
            this.powerPotencyBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerPotencyBox1.Size = new System.Drawing.Size(168, 33);
            this.powerPotencyBox1.TabIndex = 380;
            // 
            // powerPotentcyLabel
            // 
            this.powerPotentcyLabel.AutoSize = true;
            this.powerPotentcyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerPotentcyLabel.Location = new System.Drawing.Point(755, 3);
            this.powerPotentcyLabel.Name = "powerPotentcyLabel";
            this.powerPotentcyLabel.Size = new System.Drawing.Size(53, 13);
            this.powerPotentcyLabel.TabIndex = 379;
            this.powerPotentcyLabel.Text = "Potency";
            // 
            // powerMultiCheckBox24
            // 
            this.powerMultiCheckBox24.AutoSize = true;
            this.powerMultiCheckBox24.Location = new System.Drawing.Point(568, 922);
            this.powerMultiCheckBox24.Name = "powerMultiCheckBox24";
            this.powerMultiCheckBox24.Size = new System.Drawing.Size(15, 14);
            this.powerMultiCheckBox24.TabIndex = 378;
            this.powerMultiCheckBox24.UseVisualStyleBackColor = true;
            // 
            // powerDurationBox24
            // 
            this.powerDurationBox24.Location = new System.Drawing.Point(473, 918);
            this.powerDurationBox24.Name = "powerDurationBox24";
            this.powerDurationBox24.Size = new System.Drawing.Size(62, 20);
            this.powerDurationBox24.TabIndex = 377;
            // 
            // powerKeywordBox24
            // 
            this.powerKeywordBox24.Location = new System.Drawing.Point(624, 918);
            this.powerKeywordBox24.Multiline = true;
            this.powerKeywordBox24.Name = "powerKeywordBox24";
            this.powerKeywordBox24.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerKeywordBox24.Size = new System.Drawing.Size(118, 33);
            this.powerKeywordBox24.TabIndex = 376;
            // 
            // powerDNBox24
            // 
            this.powerDNBox24.Location = new System.Drawing.Point(436, 918);
            this.powerDNBox24.Name = "powerDNBox24";
            this.powerDNBox24.Size = new System.Drawing.Size(22, 20);
            this.powerDNBox24.TabIndex = 375;
            // 
            // powerRangeBox24
            // 
            this.powerRangeBox24.Location = new System.Drawing.Point(357, 918);
            this.powerRangeBox24.Name = "powerRangeBox24";
            this.powerRangeBox24.Size = new System.Drawing.Size(63, 20);
            this.powerRangeBox24.TabIndex = 374;
            // 
            // powerActivationBox24
            // 
            this.powerActivationBox24.Location = new System.Drawing.Point(279, 918);
            this.powerActivationBox24.Name = "powerActivationBox24";
            this.powerActivationBox24.Size = new System.Drawing.Size(63, 20);
            this.powerActivationBox24.TabIndex = 373;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(249, 921);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(22, 13);
            this.label57.TabIndex = 372;
            this.label57.Text = "ED";
            // 
            // powerEDBox24
            // 
            this.powerEDBox24.Location = new System.Drawing.Point(214, 918);
            this.powerEDBox24.Name = "powerEDBox24";
            this.powerEDBox24.Size = new System.Drawing.Size(34, 20);
            this.powerEDBox24.TabIndex = 371;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(201, 921);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(13, 13);
            this.label58.TabIndex = 370;
            this.label58.Text = "+";
            // 
            // powerDamageBox24
            // 
            this.powerDamageBox24.Location = new System.Drawing.Point(160, 918);
            this.powerDamageBox24.Name = "powerDamageBox24";
            this.powerDamageBox24.Size = new System.Drawing.Size(40, 20);
            this.powerDamageBox24.TabIndex = 369;
            // 
            // powerNameBox24
            // 
            this.powerNameBox24.Location = new System.Drawing.Point(6, 918);
            this.powerNameBox24.Multiline = true;
            this.powerNameBox24.Name = "powerNameBox24";
            this.powerNameBox24.Size = new System.Drawing.Size(132, 33);
            this.powerNameBox24.TabIndex = 368;
            // 
            // powerMultiCheckBox23
            // 
            this.powerMultiCheckBox23.AutoSize = true;
            this.powerMultiCheckBox23.Location = new System.Drawing.Point(568, 883);
            this.powerMultiCheckBox23.Name = "powerMultiCheckBox23";
            this.powerMultiCheckBox23.Size = new System.Drawing.Size(15, 14);
            this.powerMultiCheckBox23.TabIndex = 367;
            this.powerMultiCheckBox23.UseVisualStyleBackColor = true;
            // 
            // powerDurationBox23
            // 
            this.powerDurationBox23.Location = new System.Drawing.Point(473, 879);
            this.powerDurationBox23.Name = "powerDurationBox23";
            this.powerDurationBox23.Size = new System.Drawing.Size(62, 20);
            this.powerDurationBox23.TabIndex = 366;
            // 
            // powerKeywordBox23
            // 
            this.powerKeywordBox23.Location = new System.Drawing.Point(624, 879);
            this.powerKeywordBox23.Multiline = true;
            this.powerKeywordBox23.Name = "powerKeywordBox23";
            this.powerKeywordBox23.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerKeywordBox23.Size = new System.Drawing.Size(118, 33);
            this.powerKeywordBox23.TabIndex = 365;
            // 
            // powerDNBox23
            // 
            this.powerDNBox23.Location = new System.Drawing.Point(436, 879);
            this.powerDNBox23.Name = "powerDNBox23";
            this.powerDNBox23.Size = new System.Drawing.Size(22, 20);
            this.powerDNBox23.TabIndex = 364;
            // 
            // powerRangeBox23
            // 
            this.powerRangeBox23.Location = new System.Drawing.Point(357, 879);
            this.powerRangeBox23.Name = "powerRangeBox23";
            this.powerRangeBox23.Size = new System.Drawing.Size(63, 20);
            this.powerRangeBox23.TabIndex = 363;
            // 
            // powerActivationBox23
            // 
            this.powerActivationBox23.Location = new System.Drawing.Point(279, 879);
            this.powerActivationBox23.Name = "powerActivationBox23";
            this.powerActivationBox23.Size = new System.Drawing.Size(63, 20);
            this.powerActivationBox23.TabIndex = 362;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(249, 882);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(22, 13);
            this.label59.TabIndex = 361;
            this.label59.Text = "ED";
            // 
            // powerEDBox23
            // 
            this.powerEDBox23.Location = new System.Drawing.Point(214, 879);
            this.powerEDBox23.Name = "powerEDBox23";
            this.powerEDBox23.Size = new System.Drawing.Size(34, 20);
            this.powerEDBox23.TabIndex = 360;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(201, 882);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(13, 13);
            this.label60.TabIndex = 359;
            this.label60.Text = "+";
            // 
            // powerDamageBox23
            // 
            this.powerDamageBox23.Location = new System.Drawing.Point(160, 879);
            this.powerDamageBox23.Name = "powerDamageBox23";
            this.powerDamageBox23.Size = new System.Drawing.Size(40, 20);
            this.powerDamageBox23.TabIndex = 358;
            // 
            // powerNameBox23
            // 
            this.powerNameBox23.Location = new System.Drawing.Point(6, 879);
            this.powerNameBox23.Multiline = true;
            this.powerNameBox23.Name = "powerNameBox23";
            this.powerNameBox23.Size = new System.Drawing.Size(132, 33);
            this.powerNameBox23.TabIndex = 357;
            // 
            // powerMultiCheckBox22
            // 
            this.powerMultiCheckBox22.AutoSize = true;
            this.powerMultiCheckBox22.Location = new System.Drawing.Point(568, 845);
            this.powerMultiCheckBox22.Name = "powerMultiCheckBox22";
            this.powerMultiCheckBox22.Size = new System.Drawing.Size(15, 14);
            this.powerMultiCheckBox22.TabIndex = 356;
            this.powerMultiCheckBox22.UseVisualStyleBackColor = true;
            // 
            // powerDurationBox22
            // 
            this.powerDurationBox22.Location = new System.Drawing.Point(473, 840);
            this.powerDurationBox22.Name = "powerDurationBox22";
            this.powerDurationBox22.Size = new System.Drawing.Size(62, 20);
            this.powerDurationBox22.TabIndex = 355;
            // 
            // powerKeywordBox22
            // 
            this.powerKeywordBox22.Location = new System.Drawing.Point(624, 840);
            this.powerKeywordBox22.Multiline = true;
            this.powerKeywordBox22.Name = "powerKeywordBox22";
            this.powerKeywordBox22.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerKeywordBox22.Size = new System.Drawing.Size(118, 33);
            this.powerKeywordBox22.TabIndex = 354;
            // 
            // powerDNBox22
            // 
            this.powerDNBox22.Location = new System.Drawing.Point(436, 840);
            this.powerDNBox22.Name = "powerDNBox22";
            this.powerDNBox22.Size = new System.Drawing.Size(22, 20);
            this.powerDNBox22.TabIndex = 353;
            // 
            // powerRangeBox22
            // 
            this.powerRangeBox22.Location = new System.Drawing.Point(357, 840);
            this.powerRangeBox22.Name = "powerRangeBox22";
            this.powerRangeBox22.Size = new System.Drawing.Size(63, 20);
            this.powerRangeBox22.TabIndex = 352;
            // 
            // powerActivationBox22
            // 
            this.powerActivationBox22.Location = new System.Drawing.Point(279, 840);
            this.powerActivationBox22.Name = "powerActivationBox22";
            this.powerActivationBox22.Size = new System.Drawing.Size(63, 20);
            this.powerActivationBox22.TabIndex = 351;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(249, 844);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(22, 13);
            this.label61.TabIndex = 350;
            this.label61.Text = "ED";
            // 
            // powerEDBox22
            // 
            this.powerEDBox22.Location = new System.Drawing.Point(214, 840);
            this.powerEDBox22.Name = "powerEDBox22";
            this.powerEDBox22.Size = new System.Drawing.Size(34, 20);
            this.powerEDBox22.TabIndex = 349;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(201, 844);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(13, 13);
            this.label62.TabIndex = 348;
            this.label62.Text = "+";
            // 
            // powerDamageBox22
            // 
            this.powerDamageBox22.Location = new System.Drawing.Point(160, 840);
            this.powerDamageBox22.Name = "powerDamageBox22";
            this.powerDamageBox22.Size = new System.Drawing.Size(40, 20);
            this.powerDamageBox22.TabIndex = 347;
            // 
            // powerNameBox22
            // 
            this.powerNameBox22.Location = new System.Drawing.Point(6, 840);
            this.powerNameBox22.Multiline = true;
            this.powerNameBox22.Name = "powerNameBox22";
            this.powerNameBox22.Size = new System.Drawing.Size(132, 33);
            this.powerNameBox22.TabIndex = 346;
            // 
            // powerMultiCheckBox21
            // 
            this.powerMultiCheckBox21.AutoSize = true;
            this.powerMultiCheckBox21.Location = new System.Drawing.Point(568, 805);
            this.powerMultiCheckBox21.Name = "powerMultiCheckBox21";
            this.powerMultiCheckBox21.Size = new System.Drawing.Size(15, 14);
            this.powerMultiCheckBox21.TabIndex = 345;
            this.powerMultiCheckBox21.UseVisualStyleBackColor = true;
            // 
            // powerDurationBox21
            // 
            this.powerDurationBox21.Location = new System.Drawing.Point(473, 801);
            this.powerDurationBox21.Name = "powerDurationBox21";
            this.powerDurationBox21.Size = new System.Drawing.Size(62, 20);
            this.powerDurationBox21.TabIndex = 344;
            // 
            // powerKeywordBox21
            // 
            this.powerKeywordBox21.Location = new System.Drawing.Point(624, 801);
            this.powerKeywordBox21.Multiline = true;
            this.powerKeywordBox21.Name = "powerKeywordBox21";
            this.powerKeywordBox21.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerKeywordBox21.Size = new System.Drawing.Size(118, 33);
            this.powerKeywordBox21.TabIndex = 343;
            // 
            // powerDNBox21
            // 
            this.powerDNBox21.Location = new System.Drawing.Point(436, 801);
            this.powerDNBox21.Name = "powerDNBox21";
            this.powerDNBox21.Size = new System.Drawing.Size(22, 20);
            this.powerDNBox21.TabIndex = 342;
            // 
            // powerRangeBox21
            // 
            this.powerRangeBox21.Location = new System.Drawing.Point(357, 801);
            this.powerRangeBox21.Name = "powerRangeBox21";
            this.powerRangeBox21.Size = new System.Drawing.Size(63, 20);
            this.powerRangeBox21.TabIndex = 341;
            // 
            // powerActivationBox21
            // 
            this.powerActivationBox21.Location = new System.Drawing.Point(279, 801);
            this.powerActivationBox21.Name = "powerActivationBox21";
            this.powerActivationBox21.Size = new System.Drawing.Size(63, 20);
            this.powerActivationBox21.TabIndex = 340;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Location = new System.Drawing.Point(249, 804);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(22, 13);
            this.label63.TabIndex = 339;
            this.label63.Text = "ED";
            // 
            // powerEDBox21
            // 
            this.powerEDBox21.Location = new System.Drawing.Point(214, 801);
            this.powerEDBox21.Name = "powerEDBox21";
            this.powerEDBox21.Size = new System.Drawing.Size(34, 20);
            this.powerEDBox21.TabIndex = 338;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Location = new System.Drawing.Point(201, 804);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(13, 13);
            this.label64.TabIndex = 337;
            this.label64.Text = "+";
            // 
            // powerDamageBox21
            // 
            this.powerDamageBox21.Location = new System.Drawing.Point(160, 801);
            this.powerDamageBox21.Name = "powerDamageBox21";
            this.powerDamageBox21.Size = new System.Drawing.Size(40, 20);
            this.powerDamageBox21.TabIndex = 336;
            // 
            // powerNameBox21
            // 
            this.powerNameBox21.Location = new System.Drawing.Point(6, 801);
            this.powerNameBox21.Multiline = true;
            this.powerNameBox21.Name = "powerNameBox21";
            this.powerNameBox21.Size = new System.Drawing.Size(132, 33);
            this.powerNameBox21.TabIndex = 335;
            // 
            // powerMultiCheckBox20
            // 
            this.powerMultiCheckBox20.AutoSize = true;
            this.powerMultiCheckBox20.Location = new System.Drawing.Point(568, 766);
            this.powerMultiCheckBox20.Name = "powerMultiCheckBox20";
            this.powerMultiCheckBox20.Size = new System.Drawing.Size(15, 14);
            this.powerMultiCheckBox20.TabIndex = 334;
            this.powerMultiCheckBox20.UseVisualStyleBackColor = true;
            // 
            // powerDurationBox20
            // 
            this.powerDurationBox20.Location = new System.Drawing.Point(473, 762);
            this.powerDurationBox20.Name = "powerDurationBox20";
            this.powerDurationBox20.Size = new System.Drawing.Size(62, 20);
            this.powerDurationBox20.TabIndex = 333;
            // 
            // powerKeywordBox20
            // 
            this.powerKeywordBox20.Location = new System.Drawing.Point(624, 762);
            this.powerKeywordBox20.Multiline = true;
            this.powerKeywordBox20.Name = "powerKeywordBox20";
            this.powerKeywordBox20.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerKeywordBox20.Size = new System.Drawing.Size(118, 33);
            this.powerKeywordBox20.TabIndex = 332;
            // 
            // powerDNBox20
            // 
            this.powerDNBox20.Location = new System.Drawing.Point(436, 762);
            this.powerDNBox20.Name = "powerDNBox20";
            this.powerDNBox20.Size = new System.Drawing.Size(22, 20);
            this.powerDNBox20.TabIndex = 331;
            // 
            // powerRangeBox20
            // 
            this.powerRangeBox20.Location = new System.Drawing.Point(357, 762);
            this.powerRangeBox20.Name = "powerRangeBox20";
            this.powerRangeBox20.Size = new System.Drawing.Size(63, 20);
            this.powerRangeBox20.TabIndex = 330;
            // 
            // powerActivationBox20
            // 
            this.powerActivationBox20.Location = new System.Drawing.Point(279, 762);
            this.powerActivationBox20.Name = "powerActivationBox20";
            this.powerActivationBox20.Size = new System.Drawing.Size(63, 20);
            this.powerActivationBox20.TabIndex = 329;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(249, 765);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(22, 13);
            this.label51.TabIndex = 328;
            this.label51.Text = "ED";
            // 
            // powerEDBox20
            // 
            this.powerEDBox20.Location = new System.Drawing.Point(214, 762);
            this.powerEDBox20.Name = "powerEDBox20";
            this.powerEDBox20.Size = new System.Drawing.Size(34, 20);
            this.powerEDBox20.TabIndex = 327;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(201, 765);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(13, 13);
            this.label52.TabIndex = 326;
            this.label52.Text = "+";
            // 
            // powerDamageBox20
            // 
            this.powerDamageBox20.Location = new System.Drawing.Point(160, 762);
            this.powerDamageBox20.Name = "powerDamageBox20";
            this.powerDamageBox20.Size = new System.Drawing.Size(40, 20);
            this.powerDamageBox20.TabIndex = 325;
            // 
            // powerNameBox20
            // 
            this.powerNameBox20.Location = new System.Drawing.Point(6, 762);
            this.powerNameBox20.Multiline = true;
            this.powerNameBox20.Name = "powerNameBox20";
            this.powerNameBox20.Size = new System.Drawing.Size(132, 33);
            this.powerNameBox20.TabIndex = 324;
            // 
            // powerMultiCheckBox19
            // 
            this.powerMultiCheckBox19.AutoSize = true;
            this.powerMultiCheckBox19.Location = new System.Drawing.Point(568, 727);
            this.powerMultiCheckBox19.Name = "powerMultiCheckBox19";
            this.powerMultiCheckBox19.Size = new System.Drawing.Size(15, 14);
            this.powerMultiCheckBox19.TabIndex = 323;
            this.powerMultiCheckBox19.UseVisualStyleBackColor = true;
            // 
            // powerDurationBox19
            // 
            this.powerDurationBox19.Location = new System.Drawing.Point(473, 723);
            this.powerDurationBox19.Name = "powerDurationBox19";
            this.powerDurationBox19.Size = new System.Drawing.Size(62, 20);
            this.powerDurationBox19.TabIndex = 322;
            // 
            // powerKeywordBox19
            // 
            this.powerKeywordBox19.Location = new System.Drawing.Point(624, 723);
            this.powerKeywordBox19.Multiline = true;
            this.powerKeywordBox19.Name = "powerKeywordBox19";
            this.powerKeywordBox19.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerKeywordBox19.Size = new System.Drawing.Size(118, 33);
            this.powerKeywordBox19.TabIndex = 321;
            // 
            // powerDNBox19
            // 
            this.powerDNBox19.Location = new System.Drawing.Point(436, 723);
            this.powerDNBox19.Name = "powerDNBox19";
            this.powerDNBox19.Size = new System.Drawing.Size(22, 20);
            this.powerDNBox19.TabIndex = 320;
            // 
            // powerRangeBox19
            // 
            this.powerRangeBox19.Location = new System.Drawing.Point(357, 723);
            this.powerRangeBox19.Name = "powerRangeBox19";
            this.powerRangeBox19.Size = new System.Drawing.Size(63, 20);
            this.powerRangeBox19.TabIndex = 319;
            // 
            // powerActivationBox19
            // 
            this.powerActivationBox19.Location = new System.Drawing.Point(279, 723);
            this.powerActivationBox19.Name = "powerActivationBox19";
            this.powerActivationBox19.Size = new System.Drawing.Size(63, 20);
            this.powerActivationBox19.TabIndex = 318;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(249, 726);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(22, 13);
            this.label53.TabIndex = 317;
            this.label53.Text = "ED";
            // 
            // powerEDBox19
            // 
            this.powerEDBox19.Location = new System.Drawing.Point(214, 723);
            this.powerEDBox19.Name = "powerEDBox19";
            this.powerEDBox19.Size = new System.Drawing.Size(34, 20);
            this.powerEDBox19.TabIndex = 316;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(201, 726);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(13, 13);
            this.label54.TabIndex = 315;
            this.label54.Text = "+";
            // 
            // powerDamageBox19
            // 
            this.powerDamageBox19.Location = new System.Drawing.Point(160, 723);
            this.powerDamageBox19.Name = "powerDamageBox19";
            this.powerDamageBox19.Size = new System.Drawing.Size(40, 20);
            this.powerDamageBox19.TabIndex = 314;
            // 
            // powerNameBox19
            // 
            this.powerNameBox19.Location = new System.Drawing.Point(6, 723);
            this.powerNameBox19.Multiline = true;
            this.powerNameBox19.Name = "powerNameBox19";
            this.powerNameBox19.Size = new System.Drawing.Size(132, 33);
            this.powerNameBox19.TabIndex = 313;
            // 
            // powerMultiCheckBox18
            // 
            this.powerMultiCheckBox18.AutoSize = true;
            this.powerMultiCheckBox18.Location = new System.Drawing.Point(568, 689);
            this.powerMultiCheckBox18.Name = "powerMultiCheckBox18";
            this.powerMultiCheckBox18.Size = new System.Drawing.Size(15, 14);
            this.powerMultiCheckBox18.TabIndex = 312;
            this.powerMultiCheckBox18.UseVisualStyleBackColor = true;
            // 
            // powerDurationBox18
            // 
            this.powerDurationBox18.Location = new System.Drawing.Point(473, 684);
            this.powerDurationBox18.Name = "powerDurationBox18";
            this.powerDurationBox18.Size = new System.Drawing.Size(62, 20);
            this.powerDurationBox18.TabIndex = 311;
            // 
            // powerKeywordBox18
            // 
            this.powerKeywordBox18.Location = new System.Drawing.Point(624, 684);
            this.powerKeywordBox18.Multiline = true;
            this.powerKeywordBox18.Name = "powerKeywordBox18";
            this.powerKeywordBox18.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerKeywordBox18.Size = new System.Drawing.Size(118, 33);
            this.powerKeywordBox18.TabIndex = 310;
            // 
            // powerDNBox18
            // 
            this.powerDNBox18.Location = new System.Drawing.Point(436, 684);
            this.powerDNBox18.Name = "powerDNBox18";
            this.powerDNBox18.Size = new System.Drawing.Size(22, 20);
            this.powerDNBox18.TabIndex = 309;
            // 
            // powerRangeBox18
            // 
            this.powerRangeBox18.Location = new System.Drawing.Point(357, 684);
            this.powerRangeBox18.Name = "powerRangeBox18";
            this.powerRangeBox18.Size = new System.Drawing.Size(63, 20);
            this.powerRangeBox18.TabIndex = 308;
            // 
            // powerActivationBox18
            // 
            this.powerActivationBox18.Location = new System.Drawing.Point(279, 684);
            this.powerActivationBox18.Name = "powerActivationBox18";
            this.powerActivationBox18.Size = new System.Drawing.Size(63, 20);
            this.powerActivationBox18.TabIndex = 307;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(249, 688);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(22, 13);
            this.label55.TabIndex = 306;
            this.label55.Text = "ED";
            // 
            // powerEDBox18
            // 
            this.powerEDBox18.Location = new System.Drawing.Point(214, 684);
            this.powerEDBox18.Name = "powerEDBox18";
            this.powerEDBox18.Size = new System.Drawing.Size(34, 20);
            this.powerEDBox18.TabIndex = 305;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(201, 688);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(13, 13);
            this.label56.TabIndex = 304;
            this.label56.Text = "+";
            // 
            // powerDamageBox18
            // 
            this.powerDamageBox18.Location = new System.Drawing.Point(160, 684);
            this.powerDamageBox18.Name = "powerDamageBox18";
            this.powerDamageBox18.Size = new System.Drawing.Size(40, 20);
            this.powerDamageBox18.TabIndex = 303;
            // 
            // powerNameBox18
            // 
            this.powerNameBox18.Location = new System.Drawing.Point(6, 684);
            this.powerNameBox18.Multiline = true;
            this.powerNameBox18.Name = "powerNameBox18";
            this.powerNameBox18.Size = new System.Drawing.Size(132, 33);
            this.powerNameBox18.TabIndex = 302;
            // 
            // powerMultiCheckBox17
            // 
            this.powerMultiCheckBox17.AutoSize = true;
            this.powerMultiCheckBox17.Location = new System.Drawing.Point(568, 649);
            this.powerMultiCheckBox17.Name = "powerMultiCheckBox17";
            this.powerMultiCheckBox17.Size = new System.Drawing.Size(15, 14);
            this.powerMultiCheckBox17.TabIndex = 301;
            this.powerMultiCheckBox17.UseVisualStyleBackColor = true;
            // 
            // powerDurationBox17
            // 
            this.powerDurationBox17.Location = new System.Drawing.Point(473, 645);
            this.powerDurationBox17.Name = "powerDurationBox17";
            this.powerDurationBox17.Size = new System.Drawing.Size(62, 20);
            this.powerDurationBox17.TabIndex = 300;
            // 
            // powerKeywordBox17
            // 
            this.powerKeywordBox17.Location = new System.Drawing.Point(624, 645);
            this.powerKeywordBox17.Multiline = true;
            this.powerKeywordBox17.Name = "powerKeywordBox17";
            this.powerKeywordBox17.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerKeywordBox17.Size = new System.Drawing.Size(118, 33);
            this.powerKeywordBox17.TabIndex = 299;
            // 
            // powerDNBox17
            // 
            this.powerDNBox17.Location = new System.Drawing.Point(436, 645);
            this.powerDNBox17.Name = "powerDNBox17";
            this.powerDNBox17.Size = new System.Drawing.Size(22, 20);
            this.powerDNBox17.TabIndex = 298;
            // 
            // powerRangeBox17
            // 
            this.powerRangeBox17.Location = new System.Drawing.Point(357, 645);
            this.powerRangeBox17.Name = "powerRangeBox17";
            this.powerRangeBox17.Size = new System.Drawing.Size(63, 20);
            this.powerRangeBox17.TabIndex = 297;
            // 
            // powerActivationBox17
            // 
            this.powerActivationBox17.Location = new System.Drawing.Point(279, 645);
            this.powerActivationBox17.Name = "powerActivationBox17";
            this.powerActivationBox17.Size = new System.Drawing.Size(63, 20);
            this.powerActivationBox17.TabIndex = 296;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(249, 648);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(22, 13);
            this.label45.TabIndex = 295;
            this.label45.Text = "ED";
            // 
            // powerEDBox17
            // 
            this.powerEDBox17.Location = new System.Drawing.Point(214, 645);
            this.powerEDBox17.Name = "powerEDBox17";
            this.powerEDBox17.Size = new System.Drawing.Size(34, 20);
            this.powerEDBox17.TabIndex = 294;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(201, 648);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(13, 13);
            this.label46.TabIndex = 293;
            this.label46.Text = "+";
            // 
            // powerDamageBox17
            // 
            this.powerDamageBox17.Location = new System.Drawing.Point(160, 645);
            this.powerDamageBox17.Name = "powerDamageBox17";
            this.powerDamageBox17.Size = new System.Drawing.Size(40, 20);
            this.powerDamageBox17.TabIndex = 292;
            // 
            // powerNameBox17
            // 
            this.powerNameBox17.Location = new System.Drawing.Point(6, 645);
            this.powerNameBox17.Multiline = true;
            this.powerNameBox17.Name = "powerNameBox17";
            this.powerNameBox17.Size = new System.Drawing.Size(132, 33);
            this.powerNameBox17.TabIndex = 291;
            // 
            // powerMultiCheckBox16
            // 
            this.powerMultiCheckBox16.AutoSize = true;
            this.powerMultiCheckBox16.Location = new System.Drawing.Point(568, 610);
            this.powerMultiCheckBox16.Name = "powerMultiCheckBox16";
            this.powerMultiCheckBox16.Size = new System.Drawing.Size(15, 14);
            this.powerMultiCheckBox16.TabIndex = 290;
            this.powerMultiCheckBox16.UseVisualStyleBackColor = true;
            // 
            // powerDurationBox16
            // 
            this.powerDurationBox16.Location = new System.Drawing.Point(473, 606);
            this.powerDurationBox16.Name = "powerDurationBox16";
            this.powerDurationBox16.Size = new System.Drawing.Size(62, 20);
            this.powerDurationBox16.TabIndex = 289;
            // 
            // powerKeywordBox16
            // 
            this.powerKeywordBox16.Location = new System.Drawing.Point(624, 606);
            this.powerKeywordBox16.Multiline = true;
            this.powerKeywordBox16.Name = "powerKeywordBox16";
            this.powerKeywordBox16.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerKeywordBox16.Size = new System.Drawing.Size(118, 33);
            this.powerKeywordBox16.TabIndex = 288;
            // 
            // powerDNBox16
            // 
            this.powerDNBox16.Location = new System.Drawing.Point(436, 606);
            this.powerDNBox16.Name = "powerDNBox16";
            this.powerDNBox16.Size = new System.Drawing.Size(22, 20);
            this.powerDNBox16.TabIndex = 287;
            // 
            // powerRangeBox16
            // 
            this.powerRangeBox16.Location = new System.Drawing.Point(357, 606);
            this.powerRangeBox16.Name = "powerRangeBox16";
            this.powerRangeBox16.Size = new System.Drawing.Size(63, 20);
            this.powerRangeBox16.TabIndex = 286;
            // 
            // powerActivationBox16
            // 
            this.powerActivationBox16.Location = new System.Drawing.Point(279, 606);
            this.powerActivationBox16.Name = "powerActivationBox16";
            this.powerActivationBox16.Size = new System.Drawing.Size(63, 20);
            this.powerActivationBox16.TabIndex = 285;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(249, 609);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(22, 13);
            this.label47.TabIndex = 284;
            this.label47.Text = "ED";
            // 
            // powerEDBox16
            // 
            this.powerEDBox16.Location = new System.Drawing.Point(214, 606);
            this.powerEDBox16.Name = "powerEDBox16";
            this.powerEDBox16.Size = new System.Drawing.Size(34, 20);
            this.powerEDBox16.TabIndex = 283;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(201, 609);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(13, 13);
            this.label48.TabIndex = 282;
            this.label48.Text = "+";
            // 
            // powerDamageBox16
            // 
            this.powerDamageBox16.Location = new System.Drawing.Point(160, 606);
            this.powerDamageBox16.Name = "powerDamageBox16";
            this.powerDamageBox16.Size = new System.Drawing.Size(40, 20);
            this.powerDamageBox16.TabIndex = 281;
            // 
            // powerNameBox16
            // 
            this.powerNameBox16.Location = new System.Drawing.Point(6, 606);
            this.powerNameBox16.Multiline = true;
            this.powerNameBox16.Name = "powerNameBox16";
            this.powerNameBox16.Size = new System.Drawing.Size(132, 33);
            this.powerNameBox16.TabIndex = 280;
            // 
            // powerMultiCheckBox15
            // 
            this.powerMultiCheckBox15.AutoSize = true;
            this.powerMultiCheckBox15.Location = new System.Drawing.Point(568, 572);
            this.powerMultiCheckBox15.Name = "powerMultiCheckBox15";
            this.powerMultiCheckBox15.Size = new System.Drawing.Size(15, 14);
            this.powerMultiCheckBox15.TabIndex = 279;
            this.powerMultiCheckBox15.UseVisualStyleBackColor = true;
            // 
            // powerDurationBox15
            // 
            this.powerDurationBox15.Location = new System.Drawing.Point(473, 567);
            this.powerDurationBox15.Name = "powerDurationBox15";
            this.powerDurationBox15.Size = new System.Drawing.Size(62, 20);
            this.powerDurationBox15.TabIndex = 278;
            // 
            // powerKeywordBox15
            // 
            this.powerKeywordBox15.Location = new System.Drawing.Point(624, 567);
            this.powerKeywordBox15.Multiline = true;
            this.powerKeywordBox15.Name = "powerKeywordBox15";
            this.powerKeywordBox15.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerKeywordBox15.Size = new System.Drawing.Size(118, 33);
            this.powerKeywordBox15.TabIndex = 277;
            // 
            // powerDNBox15
            // 
            this.powerDNBox15.Location = new System.Drawing.Point(436, 567);
            this.powerDNBox15.Name = "powerDNBox15";
            this.powerDNBox15.Size = new System.Drawing.Size(22, 20);
            this.powerDNBox15.TabIndex = 276;
            // 
            // powerRangeBox15
            // 
            this.powerRangeBox15.Location = new System.Drawing.Point(357, 567);
            this.powerRangeBox15.Name = "powerRangeBox15";
            this.powerRangeBox15.Size = new System.Drawing.Size(63, 20);
            this.powerRangeBox15.TabIndex = 275;
            // 
            // powerActivationBox15
            // 
            this.powerActivationBox15.Location = new System.Drawing.Point(279, 567);
            this.powerActivationBox15.Name = "powerActivationBox15";
            this.powerActivationBox15.Size = new System.Drawing.Size(63, 20);
            this.powerActivationBox15.TabIndex = 274;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(249, 571);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(22, 13);
            this.label49.TabIndex = 273;
            this.label49.Text = "ED";
            // 
            // powerEDBox15
            // 
            this.powerEDBox15.Location = new System.Drawing.Point(214, 567);
            this.powerEDBox15.Name = "powerEDBox15";
            this.powerEDBox15.Size = new System.Drawing.Size(34, 20);
            this.powerEDBox15.TabIndex = 272;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(201, 571);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(13, 13);
            this.label50.TabIndex = 271;
            this.label50.Text = "+";
            // 
            // powerDamageBox15
            // 
            this.powerDamageBox15.Location = new System.Drawing.Point(160, 567);
            this.powerDamageBox15.Name = "powerDamageBox15";
            this.powerDamageBox15.Size = new System.Drawing.Size(40, 20);
            this.powerDamageBox15.TabIndex = 270;
            // 
            // powerNameBox15
            // 
            this.powerNameBox15.Location = new System.Drawing.Point(6, 567);
            this.powerNameBox15.Multiline = true;
            this.powerNameBox15.Name = "powerNameBox15";
            this.powerNameBox15.Size = new System.Drawing.Size(132, 33);
            this.powerNameBox15.TabIndex = 269;
            // 
            // powerMultiCheckBox14
            // 
            this.powerMultiCheckBox14.AutoSize = true;
            this.powerMultiCheckBox14.Location = new System.Drawing.Point(568, 532);
            this.powerMultiCheckBox14.Name = "powerMultiCheckBox14";
            this.powerMultiCheckBox14.Size = new System.Drawing.Size(15, 14);
            this.powerMultiCheckBox14.TabIndex = 268;
            this.powerMultiCheckBox14.UseVisualStyleBackColor = true;
            // 
            // powerDurationBox14
            // 
            this.powerDurationBox14.Location = new System.Drawing.Point(473, 528);
            this.powerDurationBox14.Name = "powerDurationBox14";
            this.powerDurationBox14.Size = new System.Drawing.Size(62, 20);
            this.powerDurationBox14.TabIndex = 267;
            // 
            // powerKeywordBox14
            // 
            this.powerKeywordBox14.Location = new System.Drawing.Point(624, 528);
            this.powerKeywordBox14.Multiline = true;
            this.powerKeywordBox14.Name = "powerKeywordBox14";
            this.powerKeywordBox14.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerKeywordBox14.Size = new System.Drawing.Size(118, 33);
            this.powerKeywordBox14.TabIndex = 266;
            // 
            // powerDNBox14
            // 
            this.powerDNBox14.Location = new System.Drawing.Point(436, 528);
            this.powerDNBox14.Name = "powerDNBox14";
            this.powerDNBox14.Size = new System.Drawing.Size(22, 20);
            this.powerDNBox14.TabIndex = 265;
            // 
            // powerRangeBox14
            // 
            this.powerRangeBox14.Location = new System.Drawing.Point(357, 528);
            this.powerRangeBox14.Name = "powerRangeBox14";
            this.powerRangeBox14.Size = new System.Drawing.Size(63, 20);
            this.powerRangeBox14.TabIndex = 264;
            // 
            // powerActivationBox14
            // 
            this.powerActivationBox14.Location = new System.Drawing.Point(279, 528);
            this.powerActivationBox14.Name = "powerActivationBox14";
            this.powerActivationBox14.Size = new System.Drawing.Size(63, 20);
            this.powerActivationBox14.TabIndex = 263;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(249, 531);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(22, 13);
            this.label39.TabIndex = 262;
            this.label39.Text = "ED";
            // 
            // powerEDBox14
            // 
            this.powerEDBox14.Location = new System.Drawing.Point(214, 528);
            this.powerEDBox14.Name = "powerEDBox14";
            this.powerEDBox14.Size = new System.Drawing.Size(34, 20);
            this.powerEDBox14.TabIndex = 261;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(201, 531);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(13, 13);
            this.label40.TabIndex = 260;
            this.label40.Text = "+";
            // 
            // powerDamageBox14
            // 
            this.powerDamageBox14.Location = new System.Drawing.Point(160, 528);
            this.powerDamageBox14.Name = "powerDamageBox14";
            this.powerDamageBox14.Size = new System.Drawing.Size(40, 20);
            this.powerDamageBox14.TabIndex = 259;
            // 
            // powerNameBox14
            // 
            this.powerNameBox14.Location = new System.Drawing.Point(6, 528);
            this.powerNameBox14.Multiline = true;
            this.powerNameBox14.Name = "powerNameBox14";
            this.powerNameBox14.Size = new System.Drawing.Size(132, 33);
            this.powerNameBox14.TabIndex = 258;
            // 
            // powerMultiCheckBox13
            // 
            this.powerMultiCheckBox13.AutoSize = true;
            this.powerMultiCheckBox13.Location = new System.Drawing.Point(568, 493);
            this.powerMultiCheckBox13.Name = "powerMultiCheckBox13";
            this.powerMultiCheckBox13.Size = new System.Drawing.Size(15, 14);
            this.powerMultiCheckBox13.TabIndex = 257;
            this.powerMultiCheckBox13.UseVisualStyleBackColor = true;
            // 
            // powerDurationBox13
            // 
            this.powerDurationBox13.Location = new System.Drawing.Point(473, 489);
            this.powerDurationBox13.Name = "powerDurationBox13";
            this.powerDurationBox13.Size = new System.Drawing.Size(62, 20);
            this.powerDurationBox13.TabIndex = 256;
            // 
            // powerKeywordBox13
            // 
            this.powerKeywordBox13.Location = new System.Drawing.Point(624, 489);
            this.powerKeywordBox13.Multiline = true;
            this.powerKeywordBox13.Name = "powerKeywordBox13";
            this.powerKeywordBox13.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerKeywordBox13.Size = new System.Drawing.Size(118, 33);
            this.powerKeywordBox13.TabIndex = 255;
            // 
            // powerDNBox13
            // 
            this.powerDNBox13.Location = new System.Drawing.Point(436, 489);
            this.powerDNBox13.Name = "powerDNBox13";
            this.powerDNBox13.Size = new System.Drawing.Size(22, 20);
            this.powerDNBox13.TabIndex = 254;
            // 
            // powerRangeBox13
            // 
            this.powerRangeBox13.Location = new System.Drawing.Point(357, 489);
            this.powerRangeBox13.Name = "powerRangeBox13";
            this.powerRangeBox13.Size = new System.Drawing.Size(63, 20);
            this.powerRangeBox13.TabIndex = 253;
            // 
            // powerActivationBox13
            // 
            this.powerActivationBox13.Location = new System.Drawing.Point(279, 489);
            this.powerActivationBox13.Name = "powerActivationBox13";
            this.powerActivationBox13.Size = new System.Drawing.Size(63, 20);
            this.powerActivationBox13.TabIndex = 252;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(249, 492);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(22, 13);
            this.label41.TabIndex = 251;
            this.label41.Text = "ED";
            // 
            // powerEDBox13
            // 
            this.powerEDBox13.Location = new System.Drawing.Point(214, 489);
            this.powerEDBox13.Name = "powerEDBox13";
            this.powerEDBox13.Size = new System.Drawing.Size(34, 20);
            this.powerEDBox13.TabIndex = 250;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(201, 492);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(13, 13);
            this.label42.TabIndex = 249;
            this.label42.Text = "+";
            // 
            // powerDamageBox13
            // 
            this.powerDamageBox13.Location = new System.Drawing.Point(160, 489);
            this.powerDamageBox13.Name = "powerDamageBox13";
            this.powerDamageBox13.Size = new System.Drawing.Size(40, 20);
            this.powerDamageBox13.TabIndex = 248;
            // 
            // powerNameBox13
            // 
            this.powerNameBox13.Location = new System.Drawing.Point(6, 489);
            this.powerNameBox13.Multiline = true;
            this.powerNameBox13.Name = "powerNameBox13";
            this.powerNameBox13.Size = new System.Drawing.Size(132, 33);
            this.powerNameBox13.TabIndex = 247;
            // 
            // powerMultiCheckBox12
            // 
            this.powerMultiCheckBox12.AutoSize = true;
            this.powerMultiCheckBox12.Location = new System.Drawing.Point(568, 455);
            this.powerMultiCheckBox12.Name = "powerMultiCheckBox12";
            this.powerMultiCheckBox12.Size = new System.Drawing.Size(15, 14);
            this.powerMultiCheckBox12.TabIndex = 246;
            this.powerMultiCheckBox12.UseVisualStyleBackColor = true;
            // 
            // powerDurationBox12
            // 
            this.powerDurationBox12.Location = new System.Drawing.Point(473, 450);
            this.powerDurationBox12.Name = "powerDurationBox12";
            this.powerDurationBox12.Size = new System.Drawing.Size(62, 20);
            this.powerDurationBox12.TabIndex = 245;
            // 
            // powerKeywordBox12
            // 
            this.powerKeywordBox12.Location = new System.Drawing.Point(624, 450);
            this.powerKeywordBox12.Multiline = true;
            this.powerKeywordBox12.Name = "powerKeywordBox12";
            this.powerKeywordBox12.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerKeywordBox12.Size = new System.Drawing.Size(118, 33);
            this.powerKeywordBox12.TabIndex = 244;
            // 
            // powerDNBox12
            // 
            this.powerDNBox12.Location = new System.Drawing.Point(436, 450);
            this.powerDNBox12.Name = "powerDNBox12";
            this.powerDNBox12.Size = new System.Drawing.Size(22, 20);
            this.powerDNBox12.TabIndex = 243;
            // 
            // powerRangeBox12
            // 
            this.powerRangeBox12.Location = new System.Drawing.Point(357, 450);
            this.powerRangeBox12.Name = "powerRangeBox12";
            this.powerRangeBox12.Size = new System.Drawing.Size(63, 20);
            this.powerRangeBox12.TabIndex = 242;
            // 
            // powerActivationBox12
            // 
            this.powerActivationBox12.Location = new System.Drawing.Point(279, 450);
            this.powerActivationBox12.Name = "powerActivationBox12";
            this.powerActivationBox12.Size = new System.Drawing.Size(63, 20);
            this.powerActivationBox12.TabIndex = 241;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(249, 454);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(22, 13);
            this.label43.TabIndex = 240;
            this.label43.Text = "ED";
            // 
            // powerEDBox12
            // 
            this.powerEDBox12.Location = new System.Drawing.Point(214, 450);
            this.powerEDBox12.Name = "powerEDBox12";
            this.powerEDBox12.Size = new System.Drawing.Size(34, 20);
            this.powerEDBox12.TabIndex = 239;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(201, 454);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(13, 13);
            this.label44.TabIndex = 238;
            this.label44.Text = "+";
            // 
            // powerDamageBox12
            // 
            this.powerDamageBox12.Location = new System.Drawing.Point(160, 450);
            this.powerDamageBox12.Name = "powerDamageBox12";
            this.powerDamageBox12.Size = new System.Drawing.Size(40, 20);
            this.powerDamageBox12.TabIndex = 237;
            // 
            // powerNameBox12
            // 
            this.powerNameBox12.Location = new System.Drawing.Point(6, 450);
            this.powerNameBox12.Multiline = true;
            this.powerNameBox12.Name = "powerNameBox12";
            this.powerNameBox12.Size = new System.Drawing.Size(132, 33);
            this.powerNameBox12.TabIndex = 236;
            // 
            // powerMultiCheckBox11
            // 
            this.powerMultiCheckBox11.AutoSize = true;
            this.powerMultiCheckBox11.Location = new System.Drawing.Point(568, 415);
            this.powerMultiCheckBox11.Name = "powerMultiCheckBox11";
            this.powerMultiCheckBox11.Size = new System.Drawing.Size(15, 14);
            this.powerMultiCheckBox11.TabIndex = 235;
            this.powerMultiCheckBox11.UseVisualStyleBackColor = true;
            // 
            // powerDurationBox11
            // 
            this.powerDurationBox11.Location = new System.Drawing.Point(473, 411);
            this.powerDurationBox11.Name = "powerDurationBox11";
            this.powerDurationBox11.Size = new System.Drawing.Size(62, 20);
            this.powerDurationBox11.TabIndex = 234;
            // 
            // powerKeywordBox11
            // 
            this.powerKeywordBox11.Location = new System.Drawing.Point(624, 411);
            this.powerKeywordBox11.Multiline = true;
            this.powerKeywordBox11.Name = "powerKeywordBox11";
            this.powerKeywordBox11.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerKeywordBox11.Size = new System.Drawing.Size(118, 33);
            this.powerKeywordBox11.TabIndex = 233;
            // 
            // powerDNBox11
            // 
            this.powerDNBox11.Location = new System.Drawing.Point(436, 411);
            this.powerDNBox11.Name = "powerDNBox11";
            this.powerDNBox11.Size = new System.Drawing.Size(22, 20);
            this.powerDNBox11.TabIndex = 232;
            // 
            // powerRangeBox11
            // 
            this.powerRangeBox11.Location = new System.Drawing.Point(357, 411);
            this.powerRangeBox11.Name = "powerRangeBox11";
            this.powerRangeBox11.Size = new System.Drawing.Size(63, 20);
            this.powerRangeBox11.TabIndex = 231;
            // 
            // powerActivationBox11
            // 
            this.powerActivationBox11.Location = new System.Drawing.Point(279, 411);
            this.powerActivationBox11.Name = "powerActivationBox11";
            this.powerActivationBox11.Size = new System.Drawing.Size(63, 20);
            this.powerActivationBox11.TabIndex = 230;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(249, 414);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(22, 13);
            this.label29.TabIndex = 229;
            this.label29.Text = "ED";
            // 
            // powerEDBox11
            // 
            this.powerEDBox11.Location = new System.Drawing.Point(214, 411);
            this.powerEDBox11.Name = "powerEDBox11";
            this.powerEDBox11.Size = new System.Drawing.Size(34, 20);
            this.powerEDBox11.TabIndex = 228;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(201, 414);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(13, 13);
            this.label30.TabIndex = 227;
            this.label30.Text = "+";
            // 
            // powerDamageBox11
            // 
            this.powerDamageBox11.Location = new System.Drawing.Point(160, 411);
            this.powerDamageBox11.Name = "powerDamageBox11";
            this.powerDamageBox11.Size = new System.Drawing.Size(40, 20);
            this.powerDamageBox11.TabIndex = 226;
            // 
            // powerNameBox11
            // 
            this.powerNameBox11.Location = new System.Drawing.Point(6, 411);
            this.powerNameBox11.Multiline = true;
            this.powerNameBox11.Name = "powerNameBox11";
            this.powerNameBox11.Size = new System.Drawing.Size(132, 33);
            this.powerNameBox11.TabIndex = 225;
            // 
            // powerMultiCheckBox10
            // 
            this.powerMultiCheckBox10.AutoSize = true;
            this.powerMultiCheckBox10.Location = new System.Drawing.Point(568, 376);
            this.powerMultiCheckBox10.Name = "powerMultiCheckBox10";
            this.powerMultiCheckBox10.Size = new System.Drawing.Size(15, 14);
            this.powerMultiCheckBox10.TabIndex = 224;
            this.powerMultiCheckBox10.UseVisualStyleBackColor = true;
            // 
            // powerDurationBox10
            // 
            this.powerDurationBox10.Location = new System.Drawing.Point(473, 372);
            this.powerDurationBox10.Name = "powerDurationBox10";
            this.powerDurationBox10.Size = new System.Drawing.Size(62, 20);
            this.powerDurationBox10.TabIndex = 223;
            // 
            // powerKeywordBox10
            // 
            this.powerKeywordBox10.Location = new System.Drawing.Point(624, 372);
            this.powerKeywordBox10.Multiline = true;
            this.powerKeywordBox10.Name = "powerKeywordBox10";
            this.powerKeywordBox10.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerKeywordBox10.Size = new System.Drawing.Size(118, 33);
            this.powerKeywordBox10.TabIndex = 222;
            // 
            // powerDNBox10
            // 
            this.powerDNBox10.Location = new System.Drawing.Point(436, 372);
            this.powerDNBox10.Name = "powerDNBox10";
            this.powerDNBox10.Size = new System.Drawing.Size(22, 20);
            this.powerDNBox10.TabIndex = 221;
            // 
            // powerRangeBox10
            // 
            this.powerRangeBox10.Location = new System.Drawing.Point(357, 372);
            this.powerRangeBox10.Name = "powerRangeBox10";
            this.powerRangeBox10.Size = new System.Drawing.Size(63, 20);
            this.powerRangeBox10.TabIndex = 220;
            // 
            // powerActivationBox10
            // 
            this.powerActivationBox10.Location = new System.Drawing.Point(279, 372);
            this.powerActivationBox10.Name = "powerActivationBox10";
            this.powerActivationBox10.Size = new System.Drawing.Size(63, 20);
            this.powerActivationBox10.TabIndex = 219;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(249, 375);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(22, 13);
            this.label31.TabIndex = 218;
            this.label31.Text = "ED";
            // 
            // powerEDBox10
            // 
            this.powerEDBox10.Location = new System.Drawing.Point(214, 372);
            this.powerEDBox10.Name = "powerEDBox10";
            this.powerEDBox10.Size = new System.Drawing.Size(34, 20);
            this.powerEDBox10.TabIndex = 217;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(201, 375);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(13, 13);
            this.label32.TabIndex = 216;
            this.label32.Text = "+";
            // 
            // powerDamageBox10
            // 
            this.powerDamageBox10.Location = new System.Drawing.Point(160, 372);
            this.powerDamageBox10.Name = "powerDamageBox10";
            this.powerDamageBox10.Size = new System.Drawing.Size(40, 20);
            this.powerDamageBox10.TabIndex = 215;
            // 
            // powerNameBox10
            // 
            this.powerNameBox10.Location = new System.Drawing.Point(6, 372);
            this.powerNameBox10.Multiline = true;
            this.powerNameBox10.Name = "powerNameBox10";
            this.powerNameBox10.Size = new System.Drawing.Size(132, 33);
            this.powerNameBox10.TabIndex = 214;
            // 
            // powerMultiCheckBox9
            // 
            this.powerMultiCheckBox9.AutoSize = true;
            this.powerMultiCheckBox9.Location = new System.Drawing.Point(568, 338);
            this.powerMultiCheckBox9.Name = "powerMultiCheckBox9";
            this.powerMultiCheckBox9.Size = new System.Drawing.Size(15, 14);
            this.powerMultiCheckBox9.TabIndex = 213;
            this.powerMultiCheckBox9.UseVisualStyleBackColor = true;
            // 
            // powerDurationBox9
            // 
            this.powerDurationBox9.Location = new System.Drawing.Point(473, 333);
            this.powerDurationBox9.Name = "powerDurationBox9";
            this.powerDurationBox9.Size = new System.Drawing.Size(62, 20);
            this.powerDurationBox9.TabIndex = 212;
            // 
            // powerKeywordBox9
            // 
            this.powerKeywordBox9.Location = new System.Drawing.Point(624, 333);
            this.powerKeywordBox9.Multiline = true;
            this.powerKeywordBox9.Name = "powerKeywordBox9";
            this.powerKeywordBox9.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerKeywordBox9.Size = new System.Drawing.Size(118, 33);
            this.powerKeywordBox9.TabIndex = 211;
            // 
            // powerDNBox9
            // 
            this.powerDNBox9.Location = new System.Drawing.Point(436, 333);
            this.powerDNBox9.Name = "powerDNBox9";
            this.powerDNBox9.Size = new System.Drawing.Size(22, 20);
            this.powerDNBox9.TabIndex = 210;
            // 
            // powerRangeBox9
            // 
            this.powerRangeBox9.Location = new System.Drawing.Point(357, 333);
            this.powerRangeBox9.Name = "powerRangeBox9";
            this.powerRangeBox9.Size = new System.Drawing.Size(63, 20);
            this.powerRangeBox9.TabIndex = 209;
            // 
            // powerActivationBox9
            // 
            this.powerActivationBox9.Location = new System.Drawing.Point(279, 333);
            this.powerActivationBox9.Name = "powerActivationBox9";
            this.powerActivationBox9.Size = new System.Drawing.Size(63, 20);
            this.powerActivationBox9.TabIndex = 208;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(249, 337);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(22, 13);
            this.label33.TabIndex = 207;
            this.label33.Text = "ED";
            // 
            // powerEDBox9
            // 
            this.powerEDBox9.Location = new System.Drawing.Point(214, 333);
            this.powerEDBox9.Name = "powerEDBox9";
            this.powerEDBox9.Size = new System.Drawing.Size(34, 20);
            this.powerEDBox9.TabIndex = 206;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(201, 337);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(13, 13);
            this.label34.TabIndex = 205;
            this.label34.Text = "+";
            // 
            // powerDamageBox9
            // 
            this.powerDamageBox9.Location = new System.Drawing.Point(160, 333);
            this.powerDamageBox9.Name = "powerDamageBox9";
            this.powerDamageBox9.Size = new System.Drawing.Size(40, 20);
            this.powerDamageBox9.TabIndex = 204;
            // 
            // powerNameBox9
            // 
            this.powerNameBox9.Location = new System.Drawing.Point(6, 333);
            this.powerNameBox9.Multiline = true;
            this.powerNameBox9.Name = "powerNameBox9";
            this.powerNameBox9.Size = new System.Drawing.Size(132, 33);
            this.powerNameBox9.TabIndex = 203;
            // 
            // powerMultiCheckBox8
            // 
            this.powerMultiCheckBox8.AutoSize = true;
            this.powerMultiCheckBox8.Location = new System.Drawing.Point(568, 297);
            this.powerMultiCheckBox8.Name = "powerMultiCheckBox8";
            this.powerMultiCheckBox8.Size = new System.Drawing.Size(15, 14);
            this.powerMultiCheckBox8.TabIndex = 202;
            this.powerMultiCheckBox8.UseVisualStyleBackColor = true;
            // 
            // powerDurationBox8
            // 
            this.powerDurationBox8.Location = new System.Drawing.Point(473, 293);
            this.powerDurationBox8.Name = "powerDurationBox8";
            this.powerDurationBox8.Size = new System.Drawing.Size(62, 20);
            this.powerDurationBox8.TabIndex = 201;
            // 
            // powerKeywordBox8
            // 
            this.powerKeywordBox8.Location = new System.Drawing.Point(624, 293);
            this.powerKeywordBox8.Multiline = true;
            this.powerKeywordBox8.Name = "powerKeywordBox8";
            this.powerKeywordBox8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerKeywordBox8.Size = new System.Drawing.Size(118, 33);
            this.powerKeywordBox8.TabIndex = 200;
            // 
            // powerDNBox8
            // 
            this.powerDNBox8.Location = new System.Drawing.Point(436, 293);
            this.powerDNBox8.Name = "powerDNBox8";
            this.powerDNBox8.Size = new System.Drawing.Size(22, 20);
            this.powerDNBox8.TabIndex = 199;
            // 
            // powerRangeBox8
            // 
            this.powerRangeBox8.Location = new System.Drawing.Point(357, 293);
            this.powerRangeBox8.Name = "powerRangeBox8";
            this.powerRangeBox8.Size = new System.Drawing.Size(63, 20);
            this.powerRangeBox8.TabIndex = 198;
            // 
            // powerActivationBox8
            // 
            this.powerActivationBox8.Location = new System.Drawing.Point(279, 293);
            this.powerActivationBox8.Name = "powerActivationBox8";
            this.powerActivationBox8.Size = new System.Drawing.Size(63, 20);
            this.powerActivationBox8.TabIndex = 197;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(249, 296);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(22, 13);
            this.label35.TabIndex = 196;
            this.label35.Text = "ED";
            // 
            // powerEDBox8
            // 
            this.powerEDBox8.Location = new System.Drawing.Point(214, 293);
            this.powerEDBox8.Name = "powerEDBox8";
            this.powerEDBox8.Size = new System.Drawing.Size(34, 20);
            this.powerEDBox8.TabIndex = 195;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(201, 296);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(13, 13);
            this.label36.TabIndex = 194;
            this.label36.Text = "+";
            // 
            // powerDamageBox8
            // 
            this.powerDamageBox8.Location = new System.Drawing.Point(160, 293);
            this.powerDamageBox8.Name = "powerDamageBox8";
            this.powerDamageBox8.Size = new System.Drawing.Size(40, 20);
            this.powerDamageBox8.TabIndex = 193;
            // 
            // powerNameBox8
            // 
            this.powerNameBox8.Location = new System.Drawing.Point(6, 293);
            this.powerNameBox8.Multiline = true;
            this.powerNameBox8.Name = "powerNameBox8";
            this.powerNameBox8.Size = new System.Drawing.Size(132, 33);
            this.powerNameBox8.TabIndex = 192;
            // 
            // powerMultiCheckBox7
            // 
            this.powerMultiCheckBox7.AutoSize = true;
            this.powerMultiCheckBox7.Location = new System.Drawing.Point(568, 258);
            this.powerMultiCheckBox7.Name = "powerMultiCheckBox7";
            this.powerMultiCheckBox7.Size = new System.Drawing.Size(15, 14);
            this.powerMultiCheckBox7.TabIndex = 191;
            this.powerMultiCheckBox7.UseVisualStyleBackColor = true;
            // 
            // powerDurationBox7
            // 
            this.powerDurationBox7.Location = new System.Drawing.Point(473, 254);
            this.powerDurationBox7.Name = "powerDurationBox7";
            this.powerDurationBox7.Size = new System.Drawing.Size(62, 20);
            this.powerDurationBox7.TabIndex = 190;
            // 
            // powerKeywordBox7
            // 
            this.powerKeywordBox7.Location = new System.Drawing.Point(624, 254);
            this.powerKeywordBox7.Multiline = true;
            this.powerKeywordBox7.Name = "powerKeywordBox7";
            this.powerKeywordBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerKeywordBox7.Size = new System.Drawing.Size(118, 33);
            this.powerKeywordBox7.TabIndex = 189;
            // 
            // powerDNBox7
            // 
            this.powerDNBox7.Location = new System.Drawing.Point(436, 254);
            this.powerDNBox7.Name = "powerDNBox7";
            this.powerDNBox7.Size = new System.Drawing.Size(22, 20);
            this.powerDNBox7.TabIndex = 188;
            // 
            // powerRangeBox7
            // 
            this.powerRangeBox7.Location = new System.Drawing.Point(357, 254);
            this.powerRangeBox7.Name = "powerRangeBox7";
            this.powerRangeBox7.Size = new System.Drawing.Size(63, 20);
            this.powerRangeBox7.TabIndex = 187;
            // 
            // powerActivationBox7
            // 
            this.powerActivationBox7.Location = new System.Drawing.Point(279, 254);
            this.powerActivationBox7.Name = "powerActivationBox7";
            this.powerActivationBox7.Size = new System.Drawing.Size(63, 20);
            this.powerActivationBox7.TabIndex = 186;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(249, 257);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(22, 13);
            this.label37.TabIndex = 185;
            this.label37.Text = "ED";
            // 
            // powerEDBox7
            // 
            this.powerEDBox7.Location = new System.Drawing.Point(214, 254);
            this.powerEDBox7.Name = "powerEDBox7";
            this.powerEDBox7.Size = new System.Drawing.Size(34, 20);
            this.powerEDBox7.TabIndex = 184;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(201, 257);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(13, 13);
            this.label38.TabIndex = 183;
            this.label38.Text = "+";
            // 
            // powerDamageBox7
            // 
            this.powerDamageBox7.Location = new System.Drawing.Point(160, 254);
            this.powerDamageBox7.Name = "powerDamageBox7";
            this.powerDamageBox7.Size = new System.Drawing.Size(40, 20);
            this.powerDamageBox7.TabIndex = 182;
            // 
            // powerNameBox7
            // 
            this.powerNameBox7.Location = new System.Drawing.Point(6, 254);
            this.powerNameBox7.Multiline = true;
            this.powerNameBox7.Name = "powerNameBox7";
            this.powerNameBox7.Size = new System.Drawing.Size(132, 33);
            this.powerNameBox7.TabIndex = 181;
            // 
            // powerMultiCheckBox6
            // 
            this.powerMultiCheckBox6.AutoSize = true;
            this.powerMultiCheckBox6.Location = new System.Drawing.Point(568, 219);
            this.powerMultiCheckBox6.Name = "powerMultiCheckBox6";
            this.powerMultiCheckBox6.Size = new System.Drawing.Size(15, 14);
            this.powerMultiCheckBox6.TabIndex = 180;
            this.powerMultiCheckBox6.UseVisualStyleBackColor = true;
            // 
            // powerDurationBox6
            // 
            this.powerDurationBox6.Location = new System.Drawing.Point(473, 215);
            this.powerDurationBox6.Name = "powerDurationBox6";
            this.powerDurationBox6.Size = new System.Drawing.Size(62, 20);
            this.powerDurationBox6.TabIndex = 179;
            // 
            // powerKeywordBox6
            // 
            this.powerKeywordBox6.Location = new System.Drawing.Point(624, 215);
            this.powerKeywordBox6.Multiline = true;
            this.powerKeywordBox6.Name = "powerKeywordBox6";
            this.powerKeywordBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerKeywordBox6.Size = new System.Drawing.Size(118, 33);
            this.powerKeywordBox6.TabIndex = 178;
            // 
            // powerDNBox6
            // 
            this.powerDNBox6.Location = new System.Drawing.Point(436, 215);
            this.powerDNBox6.Name = "powerDNBox6";
            this.powerDNBox6.Size = new System.Drawing.Size(22, 20);
            this.powerDNBox6.TabIndex = 177;
            // 
            // powerRangeBox6
            // 
            this.powerRangeBox6.Location = new System.Drawing.Point(357, 215);
            this.powerRangeBox6.Name = "powerRangeBox6";
            this.powerRangeBox6.Size = new System.Drawing.Size(63, 20);
            this.powerRangeBox6.TabIndex = 176;
            // 
            // powerActivationBox6
            // 
            this.powerActivationBox6.Location = new System.Drawing.Point(279, 215);
            this.powerActivationBox6.Name = "powerActivationBox6";
            this.powerActivationBox6.Size = new System.Drawing.Size(63, 20);
            this.powerActivationBox6.TabIndex = 175;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(249, 218);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(22, 13);
            this.label23.TabIndex = 174;
            this.label23.Text = "ED";
            // 
            // powerEDBox6
            // 
            this.powerEDBox6.Location = new System.Drawing.Point(214, 215);
            this.powerEDBox6.Name = "powerEDBox6";
            this.powerEDBox6.Size = new System.Drawing.Size(34, 20);
            this.powerEDBox6.TabIndex = 173;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(201, 218);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(13, 13);
            this.label24.TabIndex = 172;
            this.label24.Text = "+";
            // 
            // powerDamageBox6
            // 
            this.powerDamageBox6.Location = new System.Drawing.Point(160, 215);
            this.powerDamageBox6.Name = "powerDamageBox6";
            this.powerDamageBox6.Size = new System.Drawing.Size(40, 20);
            this.powerDamageBox6.TabIndex = 171;
            // 
            // powerNameBox6
            // 
            this.powerNameBox6.Location = new System.Drawing.Point(6, 215);
            this.powerNameBox6.Multiline = true;
            this.powerNameBox6.Name = "powerNameBox6";
            this.powerNameBox6.Size = new System.Drawing.Size(132, 33);
            this.powerNameBox6.TabIndex = 170;
            // 
            // powerMultiCheckBox5
            // 
            this.powerMultiCheckBox5.AutoSize = true;
            this.powerMultiCheckBox5.Location = new System.Drawing.Point(568, 180);
            this.powerMultiCheckBox5.Name = "powerMultiCheckBox5";
            this.powerMultiCheckBox5.Size = new System.Drawing.Size(15, 14);
            this.powerMultiCheckBox5.TabIndex = 169;
            this.powerMultiCheckBox5.UseVisualStyleBackColor = true;
            // 
            // powerDurationBox5
            // 
            this.powerDurationBox5.Location = new System.Drawing.Point(473, 176);
            this.powerDurationBox5.Name = "powerDurationBox5";
            this.powerDurationBox5.Size = new System.Drawing.Size(62, 20);
            this.powerDurationBox5.TabIndex = 168;
            // 
            // powerKeywordBox5
            // 
            this.powerKeywordBox5.Location = new System.Drawing.Point(624, 176);
            this.powerKeywordBox5.Multiline = true;
            this.powerKeywordBox5.Name = "powerKeywordBox5";
            this.powerKeywordBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerKeywordBox5.Size = new System.Drawing.Size(118, 33);
            this.powerKeywordBox5.TabIndex = 167;
            // 
            // powerDNBox5
            // 
            this.powerDNBox5.Location = new System.Drawing.Point(436, 176);
            this.powerDNBox5.Name = "powerDNBox5";
            this.powerDNBox5.Size = new System.Drawing.Size(22, 20);
            this.powerDNBox5.TabIndex = 166;
            // 
            // powerRangeBox5
            // 
            this.powerRangeBox5.Location = new System.Drawing.Point(357, 176);
            this.powerRangeBox5.Name = "powerRangeBox5";
            this.powerRangeBox5.Size = new System.Drawing.Size(63, 20);
            this.powerRangeBox5.TabIndex = 165;
            // 
            // powerActivationBox5
            // 
            this.powerActivationBox5.Location = new System.Drawing.Point(279, 176);
            this.powerActivationBox5.Name = "powerActivationBox5";
            this.powerActivationBox5.Size = new System.Drawing.Size(63, 20);
            this.powerActivationBox5.TabIndex = 164;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(249, 179);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(22, 13);
            this.label25.TabIndex = 163;
            this.label25.Text = "ED";
            // 
            // powerEDBox5
            // 
            this.powerEDBox5.Location = new System.Drawing.Point(214, 176);
            this.powerEDBox5.Name = "powerEDBox5";
            this.powerEDBox5.Size = new System.Drawing.Size(34, 20);
            this.powerEDBox5.TabIndex = 162;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(201, 179);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(13, 13);
            this.label26.TabIndex = 161;
            this.label26.Text = "+";
            // 
            // powerDamageBox5
            // 
            this.powerDamageBox5.Location = new System.Drawing.Point(160, 176);
            this.powerDamageBox5.Name = "powerDamageBox5";
            this.powerDamageBox5.Size = new System.Drawing.Size(40, 20);
            this.powerDamageBox5.TabIndex = 160;
            // 
            // powerNameBox5
            // 
            this.powerNameBox5.Location = new System.Drawing.Point(6, 176);
            this.powerNameBox5.Multiline = true;
            this.powerNameBox5.Name = "powerNameBox5";
            this.powerNameBox5.Size = new System.Drawing.Size(132, 33);
            this.powerNameBox5.TabIndex = 159;
            // 
            // powerMultiCheckBox4
            // 
            this.powerMultiCheckBox4.AutoSize = true;
            this.powerMultiCheckBox4.Location = new System.Drawing.Point(568, 142);
            this.powerMultiCheckBox4.Name = "powerMultiCheckBox4";
            this.powerMultiCheckBox4.Size = new System.Drawing.Size(15, 14);
            this.powerMultiCheckBox4.TabIndex = 158;
            this.powerMultiCheckBox4.UseVisualStyleBackColor = true;
            // 
            // powerDurationBox4
            // 
            this.powerDurationBox4.Location = new System.Drawing.Point(473, 137);
            this.powerDurationBox4.Name = "powerDurationBox4";
            this.powerDurationBox4.Size = new System.Drawing.Size(62, 20);
            this.powerDurationBox4.TabIndex = 157;
            // 
            // powerKeywordBox4
            // 
            this.powerKeywordBox4.Location = new System.Drawing.Point(624, 137);
            this.powerKeywordBox4.Multiline = true;
            this.powerKeywordBox4.Name = "powerKeywordBox4";
            this.powerKeywordBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerKeywordBox4.Size = new System.Drawing.Size(118, 33);
            this.powerKeywordBox4.TabIndex = 156;
            // 
            // powerDNBox4
            // 
            this.powerDNBox4.Location = new System.Drawing.Point(436, 137);
            this.powerDNBox4.Name = "powerDNBox4";
            this.powerDNBox4.Size = new System.Drawing.Size(22, 20);
            this.powerDNBox4.TabIndex = 155;
            // 
            // powerRangeBox4
            // 
            this.powerRangeBox4.Location = new System.Drawing.Point(357, 137);
            this.powerRangeBox4.Name = "powerRangeBox4";
            this.powerRangeBox4.Size = new System.Drawing.Size(63, 20);
            this.powerRangeBox4.TabIndex = 154;
            // 
            // powerActivationBox4
            // 
            this.powerActivationBox4.Location = new System.Drawing.Point(279, 137);
            this.powerActivationBox4.Name = "powerActivationBox4";
            this.powerActivationBox4.Size = new System.Drawing.Size(63, 20);
            this.powerActivationBox4.TabIndex = 153;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(249, 141);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(22, 13);
            this.label27.TabIndex = 152;
            this.label27.Text = "ED";
            // 
            // powerEDBox4
            // 
            this.powerEDBox4.Location = new System.Drawing.Point(214, 137);
            this.powerEDBox4.Name = "powerEDBox4";
            this.powerEDBox4.Size = new System.Drawing.Size(34, 20);
            this.powerEDBox4.TabIndex = 151;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(201, 141);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(13, 13);
            this.label28.TabIndex = 150;
            this.label28.Text = "+";
            // 
            // powerDamageBox4
            // 
            this.powerDamageBox4.Location = new System.Drawing.Point(160, 137);
            this.powerDamageBox4.Name = "powerDamageBox4";
            this.powerDamageBox4.Size = new System.Drawing.Size(40, 20);
            this.powerDamageBox4.TabIndex = 149;
            // 
            // powerNameBox4
            // 
            this.powerNameBox4.Location = new System.Drawing.Point(6, 137);
            this.powerNameBox4.Multiline = true;
            this.powerNameBox4.Name = "powerNameBox4";
            this.powerNameBox4.Size = new System.Drawing.Size(132, 33);
            this.powerNameBox4.TabIndex = 148;
            // 
            // powerMultiCheckBox3
            // 
            this.powerMultiCheckBox3.AutoSize = true;
            this.powerMultiCheckBox3.Location = new System.Drawing.Point(568, 102);
            this.powerMultiCheckBox3.Name = "powerMultiCheckBox3";
            this.powerMultiCheckBox3.Size = new System.Drawing.Size(15, 14);
            this.powerMultiCheckBox3.TabIndex = 147;
            this.powerMultiCheckBox3.UseVisualStyleBackColor = true;
            // 
            // powerDurationBox3
            // 
            this.powerDurationBox3.Location = new System.Drawing.Point(473, 98);
            this.powerDurationBox3.Name = "powerDurationBox3";
            this.powerDurationBox3.Size = new System.Drawing.Size(62, 20);
            this.powerDurationBox3.TabIndex = 146;
            // 
            // powerKeywordBox3
            // 
            this.powerKeywordBox3.Location = new System.Drawing.Point(624, 98);
            this.powerKeywordBox3.Multiline = true;
            this.powerKeywordBox3.Name = "powerKeywordBox3";
            this.powerKeywordBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerKeywordBox3.Size = new System.Drawing.Size(118, 33);
            this.powerKeywordBox3.TabIndex = 145;
            // 
            // powerDNBox3
            // 
            this.powerDNBox3.Location = new System.Drawing.Point(436, 98);
            this.powerDNBox3.Name = "powerDNBox3";
            this.powerDNBox3.Size = new System.Drawing.Size(22, 20);
            this.powerDNBox3.TabIndex = 144;
            // 
            // powerRangeBox3
            // 
            this.powerRangeBox3.Location = new System.Drawing.Point(357, 98);
            this.powerRangeBox3.Name = "powerRangeBox3";
            this.powerRangeBox3.Size = new System.Drawing.Size(63, 20);
            this.powerRangeBox3.TabIndex = 143;
            // 
            // powerActivationBox3
            // 
            this.powerActivationBox3.Location = new System.Drawing.Point(279, 98);
            this.powerActivationBox3.Name = "powerActivationBox3";
            this.powerActivationBox3.Size = new System.Drawing.Size(63, 20);
            this.powerActivationBox3.TabIndex = 142;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(249, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 141;
            this.label9.Text = "ED";
            // 
            // powerEDBox3
            // 
            this.powerEDBox3.Location = new System.Drawing.Point(214, 98);
            this.powerEDBox3.Name = "powerEDBox3";
            this.powerEDBox3.Size = new System.Drawing.Size(34, 20);
            this.powerEDBox3.TabIndex = 140;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(201, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 139;
            this.label10.Text = "+";
            // 
            // powerDamageBox3
            // 
            this.powerDamageBox3.Location = new System.Drawing.Point(160, 98);
            this.powerDamageBox3.Name = "powerDamageBox3";
            this.powerDamageBox3.Size = new System.Drawing.Size(40, 20);
            this.powerDamageBox3.TabIndex = 138;
            // 
            // powerNameBox3
            // 
            this.powerNameBox3.Location = new System.Drawing.Point(6, 98);
            this.powerNameBox3.Multiline = true;
            this.powerNameBox3.Name = "powerNameBox3";
            this.powerNameBox3.Size = new System.Drawing.Size(132, 33);
            this.powerNameBox3.TabIndex = 137;
            // 
            // powerMultiCheckBox2
            // 
            this.powerMultiCheckBox2.AutoSize = true;
            this.powerMultiCheckBox2.Location = new System.Drawing.Point(568, 63);
            this.powerMultiCheckBox2.Name = "powerMultiCheckBox2";
            this.powerMultiCheckBox2.Size = new System.Drawing.Size(15, 14);
            this.powerMultiCheckBox2.TabIndex = 136;
            this.powerMultiCheckBox2.UseVisualStyleBackColor = true;
            // 
            // powerDurationBox2
            // 
            this.powerDurationBox2.Location = new System.Drawing.Point(473, 59);
            this.powerDurationBox2.Name = "powerDurationBox2";
            this.powerDurationBox2.Size = new System.Drawing.Size(62, 20);
            this.powerDurationBox2.TabIndex = 135;
            // 
            // powerKeywordBox2
            // 
            this.powerKeywordBox2.Location = new System.Drawing.Point(624, 59);
            this.powerKeywordBox2.Multiline = true;
            this.powerKeywordBox2.Name = "powerKeywordBox2";
            this.powerKeywordBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerKeywordBox2.Size = new System.Drawing.Size(118, 33);
            this.powerKeywordBox2.TabIndex = 134;
            // 
            // powerDNBox2
            // 
            this.powerDNBox2.Location = new System.Drawing.Point(436, 59);
            this.powerDNBox2.Name = "powerDNBox2";
            this.powerDNBox2.Size = new System.Drawing.Size(22, 20);
            this.powerDNBox2.TabIndex = 133;
            // 
            // powerRangeBox2
            // 
            this.powerRangeBox2.Location = new System.Drawing.Point(357, 59);
            this.powerRangeBox2.Name = "powerRangeBox2";
            this.powerRangeBox2.Size = new System.Drawing.Size(63, 20);
            this.powerRangeBox2.TabIndex = 132;
            // 
            // powerActivationBox2
            // 
            this.powerActivationBox2.Location = new System.Drawing.Point(279, 59);
            this.powerActivationBox2.Name = "powerActivationBox2";
            this.powerActivationBox2.Size = new System.Drawing.Size(63, 20);
            this.powerActivationBox2.TabIndex = 131;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(249, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 130;
            this.label11.Text = "ED";
            // 
            // powerEDBox2
            // 
            this.powerEDBox2.Location = new System.Drawing.Point(214, 59);
            this.powerEDBox2.Name = "powerEDBox2";
            this.powerEDBox2.Size = new System.Drawing.Size(34, 20);
            this.powerEDBox2.TabIndex = 129;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(201, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(13, 13);
            this.label12.TabIndex = 128;
            this.label12.Text = "+";
            // 
            // powerDamageBox2
            // 
            this.powerDamageBox2.Location = new System.Drawing.Point(160, 59);
            this.powerDamageBox2.Name = "powerDamageBox2";
            this.powerDamageBox2.Size = new System.Drawing.Size(40, 20);
            this.powerDamageBox2.TabIndex = 127;
            // 
            // powerNameBox2
            // 
            this.powerNameBox2.Location = new System.Drawing.Point(6, 59);
            this.powerNameBox2.Multiline = true;
            this.powerNameBox2.Name = "powerNameBox2";
            this.powerNameBox2.Size = new System.Drawing.Size(132, 33);
            this.powerNameBox2.TabIndex = 126;
            // 
            // powerMultiCheckBox1
            // 
            this.powerMultiCheckBox1.AutoSize = true;
            this.powerMultiCheckBox1.Location = new System.Drawing.Point(568, 24);
            this.powerMultiCheckBox1.Name = "powerMultiCheckBox1";
            this.powerMultiCheckBox1.Size = new System.Drawing.Size(15, 14);
            this.powerMultiCheckBox1.TabIndex = 125;
            this.powerMultiCheckBox1.UseVisualStyleBackColor = true;
            this.powerMultiCheckBox1.CheckedChanged += new System.EventHandler(this.powerMultiCheckBox1_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(540, 3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 13);
            this.label13.TabIndex = 124;
            this.label13.Text = "Multi-Target";
            // 
            // powerDurationBox1
            // 
            this.powerDurationBox1.Location = new System.Drawing.Point(473, 20);
            this.powerDurationBox1.Name = "powerDurationBox1";
            this.powerDurationBox1.Size = new System.Drawing.Size(62, 20);
            this.powerDurationBox1.TabIndex = 123;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(472, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 122;
            this.label14.Text = "Duration";
            // 
            // powerKeywordBox1
            // 
            this.powerKeywordBox1.Location = new System.Drawing.Point(624, 20);
            this.powerKeywordBox1.Multiline = true;
            this.powerKeywordBox1.Name = "powerKeywordBox1";
            this.powerKeywordBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.powerKeywordBox1.Size = new System.Drawing.Size(118, 33);
            this.powerKeywordBox1.TabIndex = 121;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(621, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 13);
            this.label15.TabIndex = 120;
            this.label15.Text = "Keywords";
            // 
            // powerDNBox1
            // 
            this.powerDNBox1.Location = new System.Drawing.Point(436, 20);
            this.powerDNBox1.Name = "powerDNBox1";
            this.powerDNBox1.Size = new System.Drawing.Size(22, 20);
            this.powerDNBox1.TabIndex = 119;
            // 
            // powerRangeBox1
            // 
            this.powerRangeBox1.Location = new System.Drawing.Point(357, 20);
            this.powerRangeBox1.Name = "powerRangeBox1";
            this.powerRangeBox1.Size = new System.Drawing.Size(63, 20);
            this.powerRangeBox1.TabIndex = 118;
            // 
            // powerActivationBox1
            // 
            this.powerActivationBox1.Location = new System.Drawing.Point(279, 20);
            this.powerActivationBox1.Name = "powerActivationBox1";
            this.powerActivationBox1.Size = new System.Drawing.Size(63, 20);
            this.powerActivationBox1.TabIndex = 117;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(249, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(22, 13);
            this.label16.TabIndex = 116;
            this.label16.Text = "ED";
            // 
            // powerEDBox1
            // 
            this.powerEDBox1.Location = new System.Drawing.Point(214, 20);
            this.powerEDBox1.Name = "powerEDBox1";
            this.powerEDBox1.Size = new System.Drawing.Size(34, 20);
            this.powerEDBox1.TabIndex = 115;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(201, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(13, 13);
            this.label17.TabIndex = 114;
            this.label17.Text = "+";
            // 
            // powerDamageBox1
            // 
            this.powerDamageBox1.Location = new System.Drawing.Point(160, 20);
            this.powerDamageBox1.Name = "powerDamageBox1";
            this.powerDamageBox1.Size = new System.Drawing.Size(40, 20);
            this.powerDamageBox1.TabIndex = 113;
            // 
            // powerNameBox1
            // 
            this.powerNameBox1.Location = new System.Drawing.Point(6, 20);
            this.powerNameBox1.Multiline = true;
            this.powerNameBox1.Name = "powerNameBox1";
            this.powerNameBox1.Size = new System.Drawing.Size(132, 33);
            this.powerNameBox1.TabIndex = 112;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(433, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(25, 13);
            this.label18.TabIndex = 111;
            this.label18.Text = "DN";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(354, 3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 13);
            this.label19.TabIndex = 110;
            this.label19.Text = "Range";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(278, 3);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 13);
            this.label20.TabIndex = 109;
            this.label20.Text = "Activation";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(157, 3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 13);
            this.label21.TabIndex = 108;
            this.label21.Text = "Damage";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(5, 3);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(78, 13);
            this.label22.TabIndex = 107;
            this.label22.Text = "Power Name";
            // 
            // label65
            // 
            this.label65.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(5, 7);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(79, 13);
            this.label65.TabIndex = 108;
            this.label65.Text = "Power Notes";
            // 
            // powersTextBox
            // 
            this.powersTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.powersTextBox.Location = new System.Drawing.Point(2, 26);
            this.powersTextBox.Name = "powersTextBox";
            this.powersTextBox.Size = new System.Drawing.Size(817, 222);
            this.powersTextBox.TabIndex = 0;
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
            this.textBox2.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(206, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 20);
            this.textBox1.TabIndex = 17;
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
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.armorRatingBox)).EndInit();
            this.cyberAndAugments.ResumeLayout(false);
            this.cyberAndAugments.PerformLayout();
            this.psychicpowers.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.notes.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.summary.ResumeLayout(false);
            this.summary.PerformLayout();
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
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.CheckBox powerMultiCheckBox11;
        private System.Windows.Forms.TextBox powerDurationBox11;
        private System.Windows.Forms.TextBox powerKeywordBox11;
        private System.Windows.Forms.TextBox powerDNBox11;
        private System.Windows.Forms.TextBox powerRangeBox11;
        private System.Windows.Forms.TextBox powerActivationBox11;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox powerEDBox11;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox powerDamageBox11;
        private System.Windows.Forms.TextBox powerNameBox11;
        private System.Windows.Forms.CheckBox powerMultiCheckBox10;
        private System.Windows.Forms.TextBox powerDurationBox10;
        private System.Windows.Forms.TextBox powerKeywordBox10;
        private System.Windows.Forms.TextBox powerDNBox10;
        private System.Windows.Forms.TextBox powerRangeBox10;
        private System.Windows.Forms.TextBox powerActivationBox10;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox powerEDBox10;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox powerDamageBox10;
        private System.Windows.Forms.TextBox powerNameBox10;
        private System.Windows.Forms.CheckBox powerMultiCheckBox9;
        private System.Windows.Forms.TextBox powerDurationBox9;
        private System.Windows.Forms.TextBox powerKeywordBox9;
        private System.Windows.Forms.TextBox powerDNBox9;
        private System.Windows.Forms.TextBox powerRangeBox9;
        private System.Windows.Forms.TextBox powerActivationBox9;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox powerEDBox9;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox powerDamageBox9;
        private System.Windows.Forms.TextBox powerNameBox9;
        private System.Windows.Forms.CheckBox powerMultiCheckBox8;
        private System.Windows.Forms.TextBox powerDurationBox8;
        private System.Windows.Forms.TextBox powerKeywordBox8;
        private System.Windows.Forms.TextBox powerDNBox8;
        private System.Windows.Forms.TextBox powerRangeBox8;
        private System.Windows.Forms.TextBox powerActivationBox8;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox powerEDBox8;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox powerDamageBox8;
        private System.Windows.Forms.TextBox powerNameBox8;
        private System.Windows.Forms.CheckBox powerMultiCheckBox7;
        private System.Windows.Forms.TextBox powerDurationBox7;
        private System.Windows.Forms.TextBox powerKeywordBox7;
        private System.Windows.Forms.TextBox powerDNBox7;
        private System.Windows.Forms.TextBox powerRangeBox7;
        private System.Windows.Forms.TextBox powerActivationBox7;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox powerEDBox7;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox powerDamageBox7;
        private System.Windows.Forms.TextBox powerNameBox7;
        private System.Windows.Forms.CheckBox powerMultiCheckBox6;
        private System.Windows.Forms.TextBox powerDurationBox6;
        private System.Windows.Forms.TextBox powerKeywordBox6;
        private System.Windows.Forms.TextBox powerDNBox6;
        private System.Windows.Forms.TextBox powerRangeBox6;
        private System.Windows.Forms.TextBox powerActivationBox6;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox powerEDBox6;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox powerDamageBox6;
        private System.Windows.Forms.TextBox powerNameBox6;
        private System.Windows.Forms.CheckBox powerMultiCheckBox5;
        private System.Windows.Forms.TextBox powerDurationBox5;
        private System.Windows.Forms.TextBox powerKeywordBox5;
        private System.Windows.Forms.TextBox powerDNBox5;
        private System.Windows.Forms.TextBox powerRangeBox5;
        private System.Windows.Forms.TextBox powerActivationBox5;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox powerEDBox5;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox powerDamageBox5;
        private System.Windows.Forms.TextBox powerNameBox5;
        private System.Windows.Forms.CheckBox powerMultiCheckBox4;
        private System.Windows.Forms.TextBox powerDurationBox4;
        private System.Windows.Forms.TextBox powerKeywordBox4;
        private System.Windows.Forms.TextBox powerDNBox4;
        private System.Windows.Forms.TextBox powerRangeBox4;
        private System.Windows.Forms.TextBox powerActivationBox4;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox powerEDBox4;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox powerDamageBox4;
        private System.Windows.Forms.TextBox powerNameBox4;
        private System.Windows.Forms.CheckBox powerMultiCheckBox3;
        private System.Windows.Forms.TextBox powerDurationBox3;
        private System.Windows.Forms.TextBox powerKeywordBox3;
        private System.Windows.Forms.TextBox powerDNBox3;
        private System.Windows.Forms.TextBox powerRangeBox3;
        private System.Windows.Forms.TextBox powerActivationBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox powerEDBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox powerDamageBox3;
        private System.Windows.Forms.TextBox powerNameBox3;
        private System.Windows.Forms.CheckBox powerMultiCheckBox2;
        private System.Windows.Forms.TextBox powerDurationBox2;
        private System.Windows.Forms.TextBox powerKeywordBox2;
        private System.Windows.Forms.TextBox powerDNBox2;
        private System.Windows.Forms.TextBox powerRangeBox2;
        private System.Windows.Forms.TextBox powerActivationBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox powerEDBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox powerDamageBox2;
        private System.Windows.Forms.TextBox powerNameBox2;
        private System.Windows.Forms.CheckBox powerMultiCheckBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox powerDurationBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox powerKeywordBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox powerDNBox1;
        private System.Windows.Forms.TextBox powerRangeBox1;
        private System.Windows.Forms.TextBox powerActivationBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox powerEDBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox powerDamageBox1;
        private System.Windows.Forms.TextBox powerNameBox1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.CheckBox powerMultiCheckBox24;
        private System.Windows.Forms.TextBox powerDurationBox24;
        private System.Windows.Forms.TextBox powerKeywordBox24;
        private System.Windows.Forms.TextBox powerDNBox24;
        private System.Windows.Forms.TextBox powerRangeBox24;
        private System.Windows.Forms.TextBox powerActivationBox24;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.TextBox powerEDBox24;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.TextBox powerDamageBox24;
        private System.Windows.Forms.TextBox powerNameBox24;
        private System.Windows.Forms.CheckBox powerMultiCheckBox23;
        private System.Windows.Forms.TextBox powerDurationBox23;
        private System.Windows.Forms.TextBox powerKeywordBox23;
        private System.Windows.Forms.TextBox powerDNBox23;
        private System.Windows.Forms.TextBox powerRangeBox23;
        private System.Windows.Forms.TextBox powerActivationBox23;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.TextBox powerEDBox23;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox powerDamageBox23;
        private System.Windows.Forms.TextBox powerNameBox23;
        private System.Windows.Forms.CheckBox powerMultiCheckBox22;
        private System.Windows.Forms.TextBox powerDurationBox22;
        private System.Windows.Forms.TextBox powerKeywordBox22;
        private System.Windows.Forms.TextBox powerDNBox22;
        private System.Windows.Forms.TextBox powerRangeBox22;
        private System.Windows.Forms.TextBox powerActivationBox22;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.TextBox powerEDBox22;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.TextBox powerDamageBox22;
        private System.Windows.Forms.TextBox powerNameBox22;
        private System.Windows.Forms.CheckBox powerMultiCheckBox21;
        private System.Windows.Forms.TextBox powerDurationBox21;
        private System.Windows.Forms.TextBox powerKeywordBox21;
        private System.Windows.Forms.TextBox powerDNBox21;
        private System.Windows.Forms.TextBox powerRangeBox21;
        private System.Windows.Forms.TextBox powerActivationBox21;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.TextBox powerEDBox21;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox powerDamageBox21;
        private System.Windows.Forms.TextBox powerNameBox21;
        private System.Windows.Forms.CheckBox powerMultiCheckBox20;
        private System.Windows.Forms.TextBox powerDurationBox20;
        private System.Windows.Forms.TextBox powerKeywordBox20;
        private System.Windows.Forms.TextBox powerDNBox20;
        private System.Windows.Forms.TextBox powerRangeBox20;
        private System.Windows.Forms.TextBox powerActivationBox20;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox powerEDBox20;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox powerDamageBox20;
        private System.Windows.Forms.TextBox powerNameBox20;
        private System.Windows.Forms.CheckBox powerMultiCheckBox19;
        private System.Windows.Forms.TextBox powerDurationBox19;
        private System.Windows.Forms.TextBox powerKeywordBox19;
        private System.Windows.Forms.TextBox powerDNBox19;
        private System.Windows.Forms.TextBox powerRangeBox19;
        private System.Windows.Forms.TextBox powerActivationBox19;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox powerEDBox19;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox powerDamageBox19;
        private System.Windows.Forms.TextBox powerNameBox19;
        private System.Windows.Forms.CheckBox powerMultiCheckBox18;
        private System.Windows.Forms.TextBox powerDurationBox18;
        private System.Windows.Forms.TextBox powerKeywordBox18;
        private System.Windows.Forms.TextBox powerDNBox18;
        private System.Windows.Forms.TextBox powerRangeBox18;
        private System.Windows.Forms.TextBox powerActivationBox18;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox powerEDBox18;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TextBox powerDamageBox18;
        private System.Windows.Forms.TextBox powerNameBox18;
        private System.Windows.Forms.CheckBox powerMultiCheckBox17;
        private System.Windows.Forms.TextBox powerDurationBox17;
        private System.Windows.Forms.TextBox powerKeywordBox17;
        private System.Windows.Forms.TextBox powerDNBox17;
        private System.Windows.Forms.TextBox powerRangeBox17;
        private System.Windows.Forms.TextBox powerActivationBox17;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox powerEDBox17;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox powerDamageBox17;
        private System.Windows.Forms.TextBox powerNameBox17;
        private System.Windows.Forms.CheckBox powerMultiCheckBox16;
        private System.Windows.Forms.TextBox powerDurationBox16;
        private System.Windows.Forms.TextBox powerKeywordBox16;
        private System.Windows.Forms.TextBox powerDNBox16;
        private System.Windows.Forms.TextBox powerRangeBox16;
        private System.Windows.Forms.TextBox powerActivationBox16;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox powerEDBox16;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox powerDamageBox16;
        private System.Windows.Forms.TextBox powerNameBox16;
        private System.Windows.Forms.CheckBox powerMultiCheckBox15;
        private System.Windows.Forms.TextBox powerDurationBox15;
        private System.Windows.Forms.TextBox powerKeywordBox15;
        private System.Windows.Forms.TextBox powerDNBox15;
        private System.Windows.Forms.TextBox powerRangeBox15;
        private System.Windows.Forms.TextBox powerActivationBox15;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox powerEDBox15;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TextBox powerDamageBox15;
        private System.Windows.Forms.TextBox powerNameBox15;
        private System.Windows.Forms.CheckBox powerMultiCheckBox14;
        private System.Windows.Forms.TextBox powerDurationBox14;
        private System.Windows.Forms.TextBox powerKeywordBox14;
        private System.Windows.Forms.TextBox powerDNBox14;
        private System.Windows.Forms.TextBox powerRangeBox14;
        private System.Windows.Forms.TextBox powerActivationBox14;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox powerEDBox14;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox powerDamageBox14;
        private System.Windows.Forms.TextBox powerNameBox14;
        private System.Windows.Forms.CheckBox powerMultiCheckBox13;
        private System.Windows.Forms.TextBox powerDurationBox13;
        private System.Windows.Forms.TextBox powerKeywordBox13;
        private System.Windows.Forms.TextBox powerDNBox13;
        private System.Windows.Forms.TextBox powerRangeBox13;
        private System.Windows.Forms.TextBox powerActivationBox13;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox powerEDBox13;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox powerDamageBox13;
        private System.Windows.Forms.TextBox powerNameBox13;
        private System.Windows.Forms.CheckBox powerMultiCheckBox12;
        private System.Windows.Forms.TextBox powerDurationBox12;
        private System.Windows.Forms.TextBox powerKeywordBox12;
        private System.Windows.Forms.TextBox powerDNBox12;
        private System.Windows.Forms.TextBox powerRangeBox12;
        private System.Windows.Forms.TextBox powerActivationBox12;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TextBox powerEDBox12;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox powerDamageBox12;
        private System.Windows.Forms.TextBox powerNameBox12;
        private System.Windows.Forms.RichTextBox powersTextBox;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.TextBox powerPotencyBox24;
        private System.Windows.Forms.TextBox powerPotencyBox23;
        private System.Windows.Forms.TextBox powerPotencyBox22;
        private System.Windows.Forms.TextBox powerPotencyBox21;
        private System.Windows.Forms.TextBox powerPotencyBox20;
        private System.Windows.Forms.TextBox powerPotencyBox19;
        private System.Windows.Forms.TextBox powerPotencyBox18;
        private System.Windows.Forms.TextBox powerPotencyBox17;
        private System.Windows.Forms.TextBox powerPotencyBox16;
        private System.Windows.Forms.TextBox powerPotencyBox15;
        private System.Windows.Forms.TextBox powerPotencyBox14;
        private System.Windows.Forms.TextBox powerPotencyBox13;
        private System.Windows.Forms.TextBox powerPotencyBox12;
        private System.Windows.Forms.TextBox powerPotencyBox11;
        private System.Windows.Forms.TextBox powerPotencyBox10;
        private System.Windows.Forms.TextBox powerPotencyBox9;
        private System.Windows.Forms.TextBox powerPotencyBox8;
        private System.Windows.Forms.TextBox powerPotencyBox7;
        private System.Windows.Forms.TextBox powerPotencyBox6;
        private System.Windows.Forms.TextBox powerPotencyBox5;
        private System.Windows.Forms.TextBox powerPotencyBox4;
        private System.Windows.Forms.TextBox powerPotencyBox3;
        private System.Windows.Forms.TextBox powerPotencyBox2;
        private System.Windows.Forms.TextBox powerPotencyBox1;
        private System.Windows.Forms.Label powerPotentcyLabel;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label armorHeaderLabel;
        private System.Windows.Forms.Label miscEquipmentHeaderLabel;
        private System.Windows.Forms.RichTextBox equipmentTextBox;
        private System.Windows.Forms.NumericUpDown armorRatingBox;
        private System.Windows.Forms.Label armorRatingHeaderLabel;
        private System.Windows.Forms.TextBox armorKeywordsBox;
        private System.Windows.Forms.TextBox armorValueBox;
        private System.Windows.Forms.TextBox armorTraitsBox;
        private System.Windows.Forms.TextBox armorNameBox;
        private System.Windows.Forms.TextBox meleeWeaponKeywordsBox;
        private System.Windows.Forms.TextBox meleeWeaponValueBox;
        private System.Windows.Forms.TextBox meleeWeaponTraitsBox;
        private System.Windows.Forms.TextBox MeleeWeaponRangeBox;
        private System.Windows.Forms.TextBox meleeWeaponAPBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox meleeWeaponEDBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox meleeWeaponDamageBox;
        private System.Windows.Forms.TextBox meleeWeaponNameBox;
        private System.Windows.Forms.Label meleeWeaponHeaderLabel;
        private System.Windows.Forms.TextBox rangedWeaponKeywordsBox;
        private System.Windows.Forms.Label keywordsHeaderLabel;
        private System.Windows.Forms.TextBox rangedWeaponValueBox;
        private System.Windows.Forms.TextBox rangedWeaponTraitBox;
        private System.Windows.Forms.TextBox rangedWeaponSalvoBox;
        private System.Windows.Forms.TextBox rangedWeaponRangeBox;
        private System.Windows.Forms.TextBox rangedWeaponAPBox;
        private System.Windows.Forms.Label rangedEDBoxLabel;
        private System.Windows.Forms.TextBox rangedWeaponEDBox;
        private System.Windows.Forms.Label rangedBaseModLabel;
        private System.Windows.Forms.TextBox rangedWeaponDamageBox;
        private System.Windows.Forms.TextBox rangedWeaponNameBox;
        private System.Windows.Forms.Label weaponValueHeaderLabel;
        private System.Windows.Forms.Label weaponTraitsHeaderLabel;
        private System.Windows.Forms.Label salvoHeaderLabel;
        private System.Windows.Forms.Label weaponRangeHeaderLabel;
        private System.Windows.Forms.Label apHeaderLabel;
        private System.Windows.Forms.Label weaponDamageHeaderLabel;
        private System.Windows.Forms.Label rangedWeaponHeaderLabel;
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
        private System.Windows.Forms.Label armorNameLabel;
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
    }
}

