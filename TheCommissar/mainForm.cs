using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TheCommissar
{
    public partial class mainForm : Form
    {
        // Globals
        int totalBP = 100;
        int totalSpentBP = 0;
        int totalBPGained = 0;
        int totalBPRemoved = 0;
        int bpSpentOnRace = 0;
        int bpSpentOnAttributes = 0;
        int bpSpentOnSkills = 0;
        int bpSpentOnArchetype = 0;
        int tierSelection = 1;
        string raceSelection = "";
        string archetypeSelection = "";

        public mainForm()
        {
            InitializeComponent();

            // set base attributes, skills and starting values
            attStrengthTotal.Text = Convert.ToString(attStrength.Value);
            attAgilityTotal.Text = Convert.ToString(attAgility.Value);
            attToughnessTotal.Text = Convert.ToString(attToughness.Value);
            attIntellectTotal.Text = Convert.ToString(attIntellect.Value);
            attWillpowerTotal.Text = Convert.ToString(attWillpower.Value);
            attFellowshipTotal.Text = Convert.ToString(attFellowship.Value);
            attInitiativeTotal.Text = Convert.ToString(attInitiative.Value);
            attSpeedTotal.Text = Convert.ToString(attSpeed.Value);
            athleticsRatingLabel.Text = Convert.ToString(skillAthletics.Value);
            awarenessRatingLabel.Text = Convert.ToString(skillAwareness.Value);
            ballisticRatingLabel.Text = Convert.ToString(skillBallstic.Value);
            cunningRatingLabel.Text = Convert.ToString(skillCunning.Value);
            deceptionRatingLabel.Text = Convert.ToString(skillDeception.Value);
            insightRatingLabel.Text = Convert.ToString(skillInsight.Value);
            intimidationRatingLabel.Text = Convert.ToString(skillIntimidation.Value);
            investigationRatingLabel.Text = Convert.ToString(skillInvestigation.Value);
            leadershipRatingLabel.Text = Convert.ToString(skillLeadership.Value);
            medicaeRatingLabel.Text = Convert.ToString(skillMedicae.Value);
            persuasionRatingLabel.Text = Convert.ToString(skillPersuasion.Value);
            pilotRatingLabel.Text = Convert.ToString(skillPilot.Value);
            psychicRatingLabel.Text = Convert.ToString(skillPsychic.Value);
            scholarRatingLabel.Text = Convert.ToString(skillScholar.Value);
            stealthRatingLabel.Text = Convert.ToString(skillStealth.Value);
            survivalRatingLabel.Text = Convert.ToString(skillSurvival.Value);
            techRatingLabel.Text = Convert.ToString(skillTech.Value);
            weaponSkillRatingLabel.Text = Convert.ToString(skillWeaponSkill.Value);
            updateBuildPoints(0);
        }

        
        public void updateBuildPoints(int BPChange)
        {
            int bpChange = BPChange;
            totalSpentBP = totalSpentBP + BPChange;
            buildPointsLabel.Text = "Build Points: " + Convert.ToString(totalBP - totalSpentBP - bpSpentOnRace - bpSpentOnArchetype - bpSpentOnAttributes - bpSpentOnSkills);
            bpSpentAttribLabel.Text = "BP Spent on Attributes: " + Convert.ToString(bpSpentOnAttributes);
            bpSpentSkillsLabel.Text = "BP Spent on Skills: " + Convert.ToString(bpSpentOnSkills);
            bpSpentRaceLabel.Text = "BP Spent on Race: " + Convert.ToString(bpSpentOnRace);
            bpSpentArchetypeLabel.Text = "BP Spent on Archetype: " + Convert.ToString(bpSpentOnArchetype);
            updateSkillValues();
        }

        public void updateAttribBuildPoints (int OldValue, int NewValue)
        {
            int oldValue = OldValue;
            int newValue = NewValue;

            if (oldValue < newValue)
            {
                if (oldValue == 0)
                {

                }
                if (oldValue == 1)
                {
                    bpSpentOnAttributes = bpSpentOnAttributes + 4;
                }
                if (oldValue == 2)
                {
                    bpSpentOnAttributes = bpSpentOnAttributes + 6;
                }
                if (oldValue == 3)
                {
                    bpSpentOnAttributes = bpSpentOnAttributes + 8;
                }
                if (oldValue == 4)
                {
                    bpSpentOnAttributes = bpSpentOnAttributes + 15;
                }
                if (oldValue == 5)
                {
                    bpSpentOnAttributes = bpSpentOnAttributes + 18;
                }
                if (oldValue == 6)
                {
                    bpSpentOnAttributes = bpSpentOnAttributes + 21;
                }
                if (oldValue == 7)
                {
                    bpSpentOnAttributes = bpSpentOnAttributes + 32;
                }
                if (oldValue == 8)
                {
                    bpSpentOnAttributes = bpSpentOnAttributes + 36;
                }
                if (oldValue == 9)
                {
                    bpSpentOnAttributes = bpSpentOnAttributes + 40;
                }
                if (oldValue == 10)
                {
                    bpSpentOnAttributes = bpSpentOnAttributes + 55;
                }
                if (oldValue == 11)
                {
                    bpSpentOnAttributes = bpSpentOnAttributes + 72;
                }
                
            }
            else if (newValue < oldValue)
            {
                if (oldValue == 12)
                {
                    bpSpentOnAttributes = bpSpentOnAttributes - 72;
                }
                if (oldValue == 11)
                {
                    bpSpentOnAttributes = bpSpentOnAttributes - 55;
                }
                if (oldValue == 10)
                {
                    bpSpentOnAttributes = bpSpentOnAttributes - 40;
                }
                if (oldValue == 9)
                {
                    bpSpentOnAttributes = bpSpentOnAttributes - 36;
                }
                if (oldValue == 8)
                {
                    bpSpentOnAttributes = bpSpentOnAttributes - 32;
                }
                if (oldValue == 7)
                {
                    bpSpentOnAttributes = bpSpentOnAttributes - 21;
                }
                if (oldValue == 6)
                {
                    bpSpentOnAttributes = bpSpentOnAttributes - 18;
                }
                if (oldValue == 5)
                {
                    bpSpentOnAttributes = bpSpentOnAttributes - 15;
                }
                if (oldValue == 4)
                {
                    bpSpentOnAttributes = bpSpentOnAttributes - 8;
                }
                if (oldValue == 3)
                {
                    bpSpentOnAttributes = bpSpentOnAttributes - 6;
                }
                if (oldValue == 2)
                {
                    bpSpentOnAttributes = bpSpentOnAttributes - 4;
                }
                if (oldValue == 1)
                {
                    bpSpentOnAttributes = bpSpentOnAttributes - 0;
                }
            }
            else
            {
                throw new ArgumentException("How did you break this?", "attrib BP calc");
            }
            updateBuildPoints(0);
        }

        public void updateSkillBuildPoints(int OldValue, int NewValue)
        {
            int oldValue = OldValue;
            int newValue = NewValue;

            if (oldValue < newValue)
            {
                if (oldValue == 0)
                {
                    bpSpentOnSkills = bpSpentOnSkills + 1;
                }
                if (oldValue == 1)
                {
                    bpSpentOnSkills = bpSpentOnSkills + 2;
                }
                if (oldValue == 2)
                {
                    bpSpentOnSkills = bpSpentOnSkills + 3;
                }
                if (oldValue == 3)
                {
                    bpSpentOnSkills = bpSpentOnSkills + 4;
                }
                if (oldValue == 4)
                {
                    bpSpentOnSkills = bpSpentOnSkills + 10;
                }
                if (oldValue == 5)
                {
                    bpSpentOnSkills = bpSpentOnSkills + 12;
                }
                if (oldValue == 6)
                {
                    bpSpentOnSkills = bpSpentOnSkills + 14;
                }
                if (oldValue == 7)
                {
                    bpSpentOnSkills = bpSpentOnSkills + 24;
                }
            }
            else if (newValue < oldValue)
            {
                if (oldValue == 8)
                {
                    bpSpentOnSkills = bpSpentOnSkills - 24;
                }
                if (oldValue == 7)
                {
                    bpSpentOnSkills = bpSpentOnSkills - 14;
                }
                if (oldValue == 6)
                {
                    bpSpentOnSkills = bpSpentOnSkills - 12;
                }
                if (oldValue == 5)
                {
                    bpSpentOnSkills = bpSpentOnSkills - 10;
                }
                if (oldValue == 4)
                {
                    bpSpentOnSkills = bpSpentOnSkills - 4;
                }
                if (oldValue == 3)
                {
                    bpSpentOnSkills = bpSpentOnSkills - 3;
                }
                if (oldValue == 2)
                {
                    bpSpentOnSkills = bpSpentOnSkills - 2;
                }
                if (oldValue == 1)
                {
                    bpSpentOnSkills = bpSpentOnSkills - 1;
                }
            }
            else
            {
                throw new ArgumentException("How did you break this?", "skill BP calc");
            }
            updateBuildPoints(0);
        }

        public void changeAttributeValue(string attribute, int value)
        {
            string Attribute = attribute;
            int Value = value;

            if (Attribute == "strength")
                {
                    attStrengthTotal.Text = Convert.ToString(Convert.ToInt32(attStrengthTotal.Text) + Value);
                }
            else if (Attribute == "agility")
                {
                    attAgilityTotal.Text = Convert.ToString(Convert.ToInt32(attAgilityTotal.Text) + Value);
                }
            else if (Attribute == "toughness")
                {
                    attToughnessTotal.Text = Convert.ToString(Convert.ToInt32(attToughnessTotal.Text) + Value);
                }
            else if (Attribute == "intellect")
                {
                    attIntellectTotal.Text = Convert.ToString(Convert.ToInt32(attIntellectTotal.Text) + Value);
                }
            else if (Attribute == "willpower")
                {
                    attWillpowerTotal.Text = Convert.ToString(Convert.ToInt32(attWillpowerTotal.Text) + Value);
                }
            else if (Attribute == "fellowship")
                {
                    attFellowshipTotal.Text = Convert.ToString(Convert.ToInt32(attFellowshipTotal.Text) + Value);
                }
            else if (Attribute == "initiative")
                {
                    attInitiativeTotal.Text = Convert.ToString(Convert.ToInt32(attInitiativeTotal.Text) + Value);
                }
            else if (Attribute == "speed")
                {
                    // speed is unique in that its a derived state from your race
                    attSpeedTotal.Text = Convert.ToString(Value);
                }
            else
                {
                    
                }
        }

        public void changeSkillValue(string Skill)
        {
            string skill = Skill;
            if (skill == "athletics")
            {
                athleticsRatingLabel.Text = Convert.ToString(skillAthletics.Value + Convert.ToInt32(attStrengthTotal.Text));
            }
            else if (skill == "awareness")
            {
                awarenessRatingLabel.Text = Convert.ToString(skillAwareness.Value + Convert.ToInt32(attIntellectTotal.Text));
            }
            else if (skill == "ballistic")
            {
                ballisticRatingLabel.Text = Convert.ToString(skillBallstic.Value + Convert.ToInt32(attAgilityTotal.Text));
            }
            else if (skill == "cunning")
            {
                cunningRatingLabel.Text = Convert.ToString(skillCunning.Value + Convert.ToInt32(attFellowshipTotal.Text));
            }
            else if (skill == "deception")
            {
                deceptionRatingLabel.Text = Convert.ToString(skillDeception.Value + Convert.ToInt32(attFellowshipTotal.Text));
            }
            else if (skill == "insight")
            {
                insightRatingLabel.Text = Convert.ToString(skillInsight.Value + Convert.ToInt32(attFellowshipTotal.Text));
            }
            else if (skill == "intimidation")
            {
                intimidationRatingLabel.Text = Convert.ToString(skillIntimidation.Value + Convert.ToInt32(attWillpowerTotal.Text));
            }
            else if (skill == "investigation")
            {
                investigationRatingLabel.Text = Convert.ToString(skillInvestigation.Value + Convert.ToInt32(attIntellectTotal.Text));
            }
            else if (skill == "leadership")
            {
                leadershipRatingLabel.Text = Convert.ToString(skillLeadership.Value + Convert.ToInt32(attFellowshipTotal.Text));
            }
            else if (skill == "medicae")
            {
                medicaeRatingLabel.Text = Convert.ToString(skillMedicae.Value + Convert.ToInt32(attIntellectTotal.Text));
            }
            else if (skill == "persuasion")
            {
                persuasionRatingLabel.Text = Convert.ToString(skillPersuasion.Value + Convert.ToInt32(attFellowshipTotal.Text));
            }
            else if (skill == "pilot")
            {
                pilotRatingLabel.Text = Convert.ToString(skillPilot.Value + Convert.ToInt32(attAgilityTotal.Text));
            }
            else if (skill == "psychic")
            {
                psychicRatingLabel.Text = Convert.ToString(skillPsychic.Value + Convert.ToInt32(attWillpowerTotal.Text));
            }
            else if (skill == "scholar")
            {
                scholarRatingLabel.Text = Convert.ToString(skillScholar.Value + Convert.ToInt32(attIntellectTotal.Text));
            }
            else if (skill == "stealth")
            {
                stealthRatingLabel.Text = Convert.ToString(skillStealth.Value + Convert.ToInt32(attAgilityTotal.Text));
            }
            else if (skill == "survival")
            {
                survivalRatingLabel.Text = Convert.ToString(skillSurvival.Value + Convert.ToInt32(attWillpowerTotal.Text));
            }
            else if (skill == "tech")
            {
                techRatingLabel.Text = Convert.ToString(skillTech.Value + Convert.ToInt32(attIntellectTotal.Text));
            }
            else if (skill == "weapon")
            {
                weaponSkillRatingLabel.Text = Convert.ToString(skillWeaponSkill.Value + Convert.ToInt32(attInitiativeTotal.Text));
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void attStrengthTotal_Click(object sender, EventArgs e)
        {

        }

        private void tierSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void attStrength_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(attStrength.Value);
            int change = newValue - prevValue;
            changeAttributeValue("strength", change);
            updateAttribBuildPoints(prevValue, newValue);
        }

        private void attAgility_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(attAgility.Value);
            int change = newValue - prevValue;
            changeAttributeValue("agility", change);
            updateAttribBuildPoints(prevValue, newValue);
        }

        private void attToughness_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(attToughness.Value);
            int change = newValue - prevValue;
            changeAttributeValue("toughness", change);
            updateAttribBuildPoints(prevValue, newValue);
        }

        private void attIntellect_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(attIntellect.Value);
            int change = newValue - prevValue;
            changeAttributeValue("intellect", change);
            updateAttribBuildPoints(prevValue, newValue);
        }

        private void attWillpower_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(attWillpower.Value);
            int change = newValue - prevValue;
            changeAttributeValue("willpower", change);
            updateAttribBuildPoints(prevValue, newValue);
        }

        private void attFellowship_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(attFellowship.Value);
            int change = newValue - prevValue;
            changeAttributeValue("fellowship", change);
            updateAttribBuildPoints(prevValue, newValue);
        }

        private void attInitiative_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(attInitiative.Value);
            int change = newValue - prevValue;
            changeAttributeValue("initiative", change);
            updateAttribBuildPoints(prevValue, newValue);
        }

        private void attSpeed_ValueChanged(object sender, EventArgs e)
        {
            // You cant change speed manually, its Race Derived

            //int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            //int newValue = Convert.ToInt32(attSpeed.Value);
            //int change = newValue - prevValue;
            //changeAttributeValue("speed", change);
            //updateAttribBuildPoints(prevValue, newValue);
        }

        private void addTalentBtn_Click(object sender, EventArgs e)
        {
            talentForm talents = new talentForm();
            DialogResult dr = talents.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                talents.Close();
            }
            else if (dr == DialogResult.OK)
            {
                var results = talents.getTalentsAndCost();
                talentBox.Items.Add(results.Item1.ToString() + ", " + results.Item2.ToString() + "BP");
                updateBuildPoints(results.Item2);
            }
        }

        private void removeTalentBtn_Click(object sender, EventArgs e)
        {
            string findBPCost = talentBox.SelectedItem.ToString();
            findBPCost = findBPCost.Substring(findBPCost.Length - 4);
            findBPCost = findBPCost.Substring(0,2);
            updateBuildPoints(Convert.ToInt32(findBPCost) * -1);
            talentBox.Items.Remove(talentBox.SelectedItem);
        }

        //private bool tierMaxValidation(int raisedValue, string type)
        //{
        //    if (type == "skill")
        //    {
        //        if (raisedValue > (Convert.ToInt32(tierSelection) + 3))
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            return true;
        //        }
        //    }
        //    else if (type == "attribute")
        //    {
        //        if (raisedValue > (Convert.ToInt32(tierSelection) * 2 + 2))
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            return true;
        //        }
        //    }
        //    else if (type == "talent")
        //    {
        //        if (raisedValue > (Convert.ToInt32(tierSelection) +1) || raisedValue > 5)
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            return true;
        //        }
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        private void skillAthletics_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillAthletics.Value);
            int change = newValue - prevValue;
            changeSkillValue("athletics");
            updateSkillBuildPoints(prevValue, newValue);
            // we're going to add the tier validation here
            //if (tierMaxValidation(newValue, "skill"))
            //{
            //    int change = newValue - prevValue;
            //    changeSkillValue("athletics");
            //}
            //else
            //{
            //    skillAthletics.Value = prevValue;
            //}
            
        }

        private void skillAwareness_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillAwareness.Value);
            int change = newValue - prevValue;
            changeSkillValue("awareness");
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillBallstic_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillBallstic.Value);
            int change = newValue - prevValue;
            changeSkillValue("ballistic");
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillCunning_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillCunning.Value);
            int change = newValue - prevValue;
            changeSkillValue("cunning");
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillDeception_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillDeception.Value);
            int change = newValue - prevValue;
            changeSkillValue("deception");
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillInsight_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillInsight.Value);
            int change = newValue - prevValue;
            changeSkillValue("insight");
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillIntimidation_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillIntimidation.Value);
            int change = newValue - prevValue;
            changeSkillValue("intimidation");
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillInvestigation_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillInvestigation.Value);
            int change = newValue - prevValue;
            changeSkillValue("investigation");
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillLeadership_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillLeadership.Value);
            int change = newValue - prevValue;
            changeSkillValue("leadership");
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillMedicae_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillMedicae.Value);
            int change = newValue - prevValue;
            changeSkillValue("medicae");
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillPersuasion_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillPersuasion.Value);
            int change = newValue - prevValue;
            changeSkillValue("persuasion");
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillPilot_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillPilot.Value);
            int change = newValue - prevValue;
            changeSkillValue("pilot");
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillPsychic_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillPsychic.Value);
            int change = newValue - prevValue;
            changeSkillValue("psychic");
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillScholar_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillScholar.Value);
            int change = newValue - prevValue;
            changeSkillValue("scholar");
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillStealth_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillStealth.Value);
            int change = newValue - prevValue;
            changeSkillValue("stealth");
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillSurvival_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillSurvival.Value);
            int change = newValue - prevValue;
            changeSkillValue("survival");
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillTech_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillTech.Value);
            int change = newValue - prevValue;
            changeSkillValue("tech");
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillWeaponSkill_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillWeaponSkill.Value);
            int change = newValue - prevValue;
            changeSkillValue("weapon");
            updateSkillBuildPoints(prevValue, newValue);
        }

        public void updateSkillValues()
        {
            athleticsRatingLabel.Text = Convert.ToString(skillAthletics.Value + Convert.ToInt32(attStrengthTotal.Text));
            awarenessRatingLabel.Text = Convert.ToString(skillAwareness.Value + Convert.ToInt32(attIntellectTotal.Text));
            ballisticRatingLabel.Text = Convert.ToString(skillBallstic.Value + Convert.ToInt32(attAgilityTotal.Text));
            cunningRatingLabel.Text = Convert.ToString(skillCunning.Value + Convert.ToInt32(attFellowshipTotal.Text));
            deceptionRatingLabel.Text = Convert.ToString(skillDeception.Value + Convert.ToInt32(attFellowshipTotal.Text));
            insightRatingLabel.Text = Convert.ToString(skillInsight.Value + Convert.ToInt32(attFellowshipTotal.Text));
            intimidationRatingLabel.Text = Convert.ToString(skillIntimidation.Value + Convert.ToInt32(attWillpowerTotal.Text));
            investigationRatingLabel.Text = Convert.ToString(skillInvestigation.Value + Convert.ToInt32(attIntellectTotal.Text));
            leadershipRatingLabel.Text = Convert.ToString(skillLeadership.Value + Convert.ToInt32(attFellowshipTotal.Text));
            medicaeRatingLabel.Text = Convert.ToString(skillMedicae.Value + Convert.ToInt32(attIntellectTotal.Text));
            persuasionRatingLabel.Text = Convert.ToString(skillPersuasion.Value + Convert.ToInt32(attFellowshipTotal.Text));
            pilotRatingLabel.Text = Convert.ToString(skillPilot.Value + Convert.ToInt32(attAgilityTotal.Text));
            psychicRatingLabel.Text = Convert.ToString(skillPsychic.Value + Convert.ToInt32(attWillpowerTotal.Text));
            scholarRatingLabel.Text = Convert.ToString(skillScholar.Value + Convert.ToInt32(attIntellectTotal.Text));
            stealthRatingLabel.Text = Convert.ToString(skillStealth.Value + Convert.ToInt32(attAgilityTotal.Text));
            survivalRatingLabel.Text = Convert.ToString(skillSurvival.Value + Convert.ToInt32(attWillpowerTotal.Text));
            techRatingLabel.Text = Convert.ToString(skillTech.Value + Convert.ToInt32(attIntellectTotal.Text));
            weaponSkillRatingLabel.Text = Convert.ToString(skillWeaponSkill.Value + Convert.ToInt32(attInitiativeTotal.Text));
        }

        public void updateAttribValues()
        {
            attStrengthTotal.Text = Convert.ToString(attStrength.Value);
            attAgilityTotal.Text = Convert.ToString(attAgility.Value);
            attToughnessTotal.Text = Convert.ToString(attToughness.Value);
            attIntellectTotal.Text = Convert.ToString(attIntellect.Value);
            attWillpowerTotal.Text = Convert.ToString(attWillpower.Value);
            attFellowshipTotal.Text = Convert.ToString(attFellowship.Value);
            attInitiativeTotal.Text = Convert.ToString(attInitiative.Value);
        }

        public void updateSpeciesSelectList()
        {
            speciesSelect.Items.Clear();
            speciesSelect.Items.Add("Human, 0BP");
            speciesSelect.Items.Add("Eldar, 10BP");
            speciesSelect.Items.Add("Ork, 10BP");
            if (tierSelection >= 2)
            {
                speciesSelect.Items.Add("Adeptus Astartes, 50BP");
            }
            if (tierSelection >= 4)
            {
                speciesSelect.Items.Add("Primaris Astartes, 100BP");
            }
        }

        public void updateArchetypeSelectList()
        {
            archetypeSelect.Items.Clear();
            if (tierSelection >= 1)
            {
                if (raceSelection == "Human, 0BP")
                {
                    archetypeSelect.Items.Add("Ministorum Priest");
                    archetypeSelect.Items.Add("Sister Hospitaller");
                    archetypeSelect.Items.Add("Imperial Guardsman");
                    archetypeSelect.Items.Add("Inquisitional Acolyte");
                    archetypeSelect.Items.Add("Inquisitorial Adept");
                    archetypeSelect.Items.Add("Hive Ganger");
                    archetypeSelect.Items.Add("Cultist");
                }
                if (raceSelection == "Eldar, 10BP")
                {
                    archetypeSelect.Items.Add("Eldar Corsair");
                }
                if (raceSelection == "Ork, 10BP")
                {
                    archetypeSelect.Items.Add("Ork Boy");
                }
            }
            if (tierSelection >= 2)
            {
                if (raceSelection == "Human, 0BP")
                {
                    archetypeSelect.Items.Add("Death Cult Assassin");
                    archetypeSelect.Items.Add("Sister of Battle");
                    archetypeSelect.Items.Add("Tempestus Scion");
                    archetypeSelect.Items.Add("Sanctioned Psyker");
                    archetypeSelect.Items.Add("Rogue Trader");
                    archetypeSelect.Items.Add("Skitarius");
                    archetypeSelect.Items.Add("Scavvy");
                    archetypeSelect.Items.Add("Rogue Psyker");
                }
                if (raceSelection == "Eldar, 10BP")
                {
                    archetypeSelect.Items.Add("Eldar Ranger");
                }
                if (raceSelection == "Ork, 10BP")
                { 
                    archetypeSelect.Items.Add("Ork Kommando");
                }
                if (raceSelection == "Adeptus Astartes, 50BP")
                {
                    archetypeSelect.Items.Add("Space Marine Scout");
                }

            }
            if (tierSelection >= 3)
            {
                if (raceSelection == "Human, 0BP")
                {
                    archetypeSelect.Items.Add("Crusader");
                    archetypeSelect.Items.Add("Imperial Commisar");
                    archetypeSelect.Items.Add("Tech-Priest");
                    archetypeSelect.Items.Add("Desperado");
                    archetypeSelect.Items.Add("Heretek");
                }
                if (raceSelection == "Eldar, 10BP")
                {
                    archetypeSelect.Items.Add("Eldar Warlock");
                }
                if (raceSelection == "Ork, 10BP")
                {
                    archetypeSelect.Items.Add("Ork Nob");
                }
                if (raceSelection == "Adeptus Astartes, 50BP")
                { 
                    archetypeSelect.Items.Add("Tactical Space Marine");
                }

            }
            if (tierSelection >=4)
            {
                if (raceSelection == "Human, 0BP")
                {
                    archetypeSelect.Items.Add("Inquisitor");
                }
                if (raceSelection == "Primaris Astartes, 100BP")
                {
                    archetypeSelect.Items.Add("Primaris Marine Intercessor");
                }
            }

        }

        private void tierSelect_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tierSelect.SelectedItem.ToString() == "1")
            {
                tierSelection = 1;
                totalBP = 100;
                updateBuildPoints(0);
                updateSpeciesSelectList();
            }
            if (tierSelect.SelectedItem.ToString() == "2")
            {
                tierSelection = 2;
                totalBP = 200;
                updateBuildPoints(0);
                updateSpeciesSelectList();
            }
            if (tierSelect.SelectedItem.ToString() == "3")
            {
                tierSelection = 3;
                totalBP = 300;
                updateBuildPoints(0);
                updateSpeciesSelectList();
            }
            if (tierSelect.SelectedItem.ToString() == "4")
            {
                tierSelection = 4;
                totalBP = 400;
                updateBuildPoints(0);
                updateSpeciesSelectList();
            }
            if (tierSelect.SelectedItem.ToString() == "5")
            {
                tierSelection = 5;
                totalBP = 500;
                updateBuildPoints(0);
                updateSpeciesSelectList();
            }
            updateBuildPoints(0);
        }

        private void speciesSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            raceSelection = speciesSelect.SelectedItem.ToString();
            updateArchetypeSelectList();
            if (raceSelection == "Human, 0BP")
            {
                bpSpentOnRace = 0;
                changeAttributeValue("speed", 6);
            }
            else if (raceSelection == "Eldar, 10BP")
            {
                bpSpentOnRace = 10;
                changeAttributeValue("speed", 8);
            }
            else if (raceSelection == "Ork, 10BP")
            {
                bpSpentOnRace = 10;
                changeAttributeValue("speed", 6);
            }
            else if (raceSelection == "Adeptus Astartes, 50BP")
            {
                bpSpentOnRace = 50;
                changeAttributeValue("speed", 7);
            }
            else if (raceSelection == "Primaris Astartes, 100BP")
            {
                bpSpentOnRace = 100;
                changeAttributeValue("speed", 6);
            }
            updateBuildPoints(0);
        }

        private void archetypeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            bpSpentOnArchetype = 0;
            if (archetypeSelect.SelectedItem.ToString() == "Ministorum Priest" || archetypeSelect.SelectedItem.ToString() == "Sister Hospitaller" || 
                archetypeSelect.SelectedItem.ToString() == "Imperial Guardsman" || archetypeSelect.SelectedItem.ToString() == "Inquisitional Acolyte" ||
                archetypeSelect.SelectedItem.ToString() == "Inquisitorial Adept" || archetypeSelect.SelectedItem.ToString() == "Hive Ganger" ||
                archetypeSelect.SelectedItem.ToString() == "Cultist" || archetypeSelect.SelectedItem.ToString() == "Eldar Corsair" ||
                archetypeSelect.SelectedItem.ToString() == "Ork Boy")
            {
                bpSpentOnArchetype = 0;
            }
            if (archetypeSelect.SelectedItem.ToString() == "Scavvy")
            {
                bpSpentOnArchetype = 10;
            }
            if (archetypeSelect.SelectedItem.ToString() == "Death Cult Assassin" || archetypeSelect.SelectedItem.ToString() == "Space Marine Scout")
            {
                bpSpentOnArchetype = 20;
            }
            if (archetypeSelect.SelectedItem.ToString() == "Tempestus Scion" || archetypeSelect.SelectedItem.ToString() == "Eldar Ranger" ||
                archetypeSelect.SelectedItem.ToString() == "Ork Kommando" || archetypeSelect.SelectedItem.ToString() == "Desperado")
            {
                bpSpentOnArchetype = 30;
            }
            if (archetypeSelect.SelectedItem.ToString() == "Sister of Battle" || archetypeSelect.SelectedItem.ToString() == "Rogue Trader" ||
                archetypeSelect.SelectedItem.ToString() == "Skitarius" || archetypeSelect.SelectedItem.ToString() == "Crusader")
            {
                bpSpentOnArchetype = 40;
            }
            if (archetypeSelect.SelectedItem.ToString() == "Sanctioned Psyker" || archetypeSelect.SelectedItem.ToString() == "Rogue Psyker" ||
                archetypeSelect.SelectedItem.ToString() == "Imperial Commisar" || archetypeSelect.SelectedItem.ToString() == "Tactical Space Marine")
            {
                bpSpentOnArchetype = 50;
            }
            if (archetypeSelect.SelectedItem.ToString() == "Primaris Marine Intercessor" || archetypeSelect.SelectedItem.ToString() == "Tech-Priest" ||
                archetypeSelect.SelectedItem.ToString() == "Heretek" || archetypeSelect.SelectedItem.ToString() == "Ork Nob")
            {
                bpSpentOnArchetype = 60;
            }
            if (archetypeSelect.SelectedItem.ToString() == "Inquisitor")
            {
                bpSpentOnArchetype = 70;
            }
            if (archetypeSelect.SelectedItem.ToString() == "Eldar Warlock")
            {
                bpSpentOnArchetype = 80;
            }

            archetypeSelection = archetypeSelect.SelectedItem.ToString();
            updateBuildPoints(0);
        }

        private void addBPButton_Click(object sender, EventArgs e)
        {
            bpModForm bpMod = new bpModForm();
            bpMod.Text = "Add BP";
            bpMod.changeAddRemove();
            DialogResult dr = bpMod.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                bpMod.Close();
            }
            else if (dr == DialogResult.OK)
            {
                int results = bpMod.returnBPChangeValue();
                updateBuildPoints(results * -1);
                totalBPGained = totalBPGained + results;
            }
        }

        private void removeBPButton_Click(object sender, EventArgs e)
        {
            bpModForm bpMod = new bpModForm();
            bpMod.Text = "Remove BP";
            bpMod.changeAddRemove();
            DialogResult dr = bpMod.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                bpMod.Close();
            }
            else if (dr == DialogResult.OK)
            {
                int results = bpMod.returnBPChangeValue();
                updateBuildPoints(results);
                totalBPRemoved = totalBPRemoved + results;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.InitialDirectory = System.AppContext.BaseDirectory + "\\\\TheCommissarSaves\\\\";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.OverwritePrompt = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog.FileName);

                sw.WriteLine(Convert.ToString(nameBox.Text));
                sw.WriteLine(Convert.ToString(tierSelection));
                sw.WriteLine(Convert.ToString(raceSelection));
                sw.WriteLine(Convert.ToString(archetypeSelection));
                sw.WriteLine(Convert.ToString(tierSelect.SelectedIndex));
                sw.WriteLine(Convert.ToString(speciesSelect.SelectedIndex));
                sw.WriteLine(Convert.ToString(archetypeSelect.SelectedIndex));
                sw.WriteLine(Convert.ToString(attStrength.Value));
                sw.WriteLine(Convert.ToString(attAgility.Value));
                sw.WriteLine(Convert.ToString(attToughness.Value));
                sw.WriteLine(Convert.ToString(attIntellect.Value));
                sw.WriteLine(Convert.ToString(attWillpower.Value));
                sw.WriteLine(Convert.ToString(attFellowship.Value));
                sw.WriteLine(Convert.ToString(attInitiative.Value));
                //speed is unique as a derived stat
                sw.WriteLine(Convert.ToString(attSpeedTotal.Text));
                sw.WriteLine(Convert.ToString(skillAthletics.Value));
                sw.WriteLine(Convert.ToString(skillAwareness.Value));
                sw.WriteLine(Convert.ToString(skillBallstic.Value));
                sw.WriteLine(Convert.ToString(skillCunning.Value));
                sw.WriteLine(Convert.ToString(skillDeception.Value));
                sw.WriteLine(Convert.ToString(skillInsight.Value));
                sw.WriteLine(Convert.ToString(skillIntimidation.Value));
                sw.WriteLine(Convert.ToString(skillInvestigation.Value));
                sw.WriteLine(Convert.ToString(skillLeadership.Value));
                sw.WriteLine(Convert.ToString(skillMedicae.Value));
                sw.WriteLine(Convert.ToString(skillPersuasion.Value));
                sw.WriteLine(Convert.ToString(skillPilot.Value));
                sw.WriteLine(Convert.ToString(skillPsychic.Value));
                sw.WriteLine(Convert.ToString(skillScholar.Value));
                sw.WriteLine(Convert.ToString(skillStealth.Value));
                sw.WriteLine(Convert.ToString(skillSurvival.Value));
                sw.WriteLine(Convert.ToString(skillTech.Value));
                sw.WriteLine(Convert.ToString(skillWeaponSkill.Value));
                sw.WriteLine(Convert.ToString(athleticsBonusBox.Text));
                sw.WriteLine(Convert.ToString(awarenessBonusBox.Text));
                sw.WriteLine(Convert.ToString(ballisticBonusBox.Text));
                sw.WriteLine(Convert.ToString(cunningBonusBox.Text));
                sw.WriteLine(Convert.ToString(deceptionBonusBox.Text));
                sw.WriteLine(Convert.ToString(insightBonusBox.Text));
                sw.WriteLine(Convert.ToString(intimidationBonusBox.Text));
                sw.WriteLine(Convert.ToString(investigationBonusBox.Text));
                sw.WriteLine(Convert.ToString(leadershipBonusBox.Text));
                sw.WriteLine(Convert.ToString(medicaeBonusBox.Text));
                sw.WriteLine(Convert.ToString(persuasionBonusBox.Text));
                sw.WriteLine(Convert.ToString(pilotBonusBox.Text));
                sw.WriteLine(Convert.ToString(psychicBonusBox.Text));
                sw.WriteLine(Convert.ToString(scholarBonusBox.Text));
                sw.WriteLine(Convert.ToString(stealthBonusBox.Text));
                sw.WriteLine(Convert.ToString(survivalBonusBox.Text));
                sw.WriteLine(Convert.ToString(techBonusBox.Text));
                sw.WriteLine(Convert.ToString(weaponSkillBonusBox.Text));
                //bp goes here to not trigger value updates on load
                sw.WriteLine(Convert.ToString(totalBP));
                sw.WriteLine(Convert.ToString(totalSpentBP));
                sw.WriteLine(Convert.ToString(totalBPGained));
                sw.WriteLine(Convert.ToString(totalBPRemoved));
                sw.WriteLine(Convert.ToString(bpSpentOnRace));
                sw.WriteLine(Convert.ToString(bpSpentOnArchetype));
                sw.WriteLine(Convert.ToString(bpSpentOnSkills));
                sw.WriteLine(Convert.ToString(bpSpentOnAttributes));
                // talents and special tabs
                sw.WriteLine("?????Talents?????");
                foreach (var item in talentBox.Items)
                {
                    sw.WriteLine(item.ToString());
                }
                sw.WriteLine("?????Equipment?????");
                sw.WriteLine(Convert.ToString(equipmentTextBox.Text));
                sw.WriteLine("?????Powers?????");
                sw.WriteLine(Convert.ToString(powersTextBox.Text));
                sw.WriteLine("?????Notes?????");
                sw.WriteLine(Convert.ToString(notesTextBox.Text));
                sw.Close();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.InitialDirectory = System.AppContext.BaseDirectory + "\\\\TheCommissarSaves\\\\";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog.FileName);
                string line = "";

                nameBox.Text = sr.ReadLine();
                tierSelection = Convert.ToInt32(sr.ReadLine());
                raceSelection = sr.ReadLine();
                archetypeSelection = sr.ReadLine();
                tierSelect.SelectedIndex = Convert.ToInt32(sr.ReadLine());
                speciesSelect.SelectedIndex = Convert.ToInt32(sr.ReadLine());
                archetypeSelect.SelectedIndex = Convert.ToInt32(sr.ReadLine());
                attStrength.Value = Convert.ToInt32(sr.ReadLine());
                attAgility.Value = Convert.ToInt32(sr.ReadLine());
                attToughness.Value = Convert.ToInt32(sr.ReadLine());
                attIntellect.Value = Convert.ToInt32(sr.ReadLine());
                attWillpower.Value = Convert.ToInt32(sr.ReadLine());
                attFellowship.Value = Convert.ToInt32(sr.ReadLine());
                attInitiative.Value = Convert.ToInt32(sr.ReadLine());
                //speed is unique as a derived stat
                attSpeedTotal.Text = sr.ReadLine();
                skillAthletics.Value = Convert.ToInt32(sr.ReadLine());
                skillAwareness.Value = Convert.ToInt32(sr.ReadLine());
                skillBallstic.Value = Convert.ToInt32(sr.ReadLine());
                skillCunning.Value = Convert.ToInt32(sr.ReadLine());
                skillDeception.Value = Convert.ToInt32(sr.ReadLine());
                skillInsight.Value = Convert.ToInt32(sr.ReadLine());
                skillIntimidation.Value = Convert.ToInt32(sr.ReadLine());
                skillInvestigation.Value = Convert.ToInt32(sr.ReadLine());
                skillLeadership.Value = Convert.ToInt32(sr.ReadLine());
                skillMedicae.Value = Convert.ToInt32(sr.ReadLine());
                skillPersuasion.Value = Convert.ToInt32(sr.ReadLine());
                skillPilot.Value = Convert.ToInt32(sr.ReadLine());
                skillPsychic.Value = Convert.ToInt32(sr.ReadLine());
                skillScholar.Value = Convert.ToInt32(sr.ReadLine());
                skillStealth.Value = Convert.ToInt32(sr.ReadLine());
                skillSurvival.Value = Convert.ToInt32(sr.ReadLine());
                skillTech.Value = Convert.ToInt32(sr.ReadLine());
                skillWeaponSkill.Value = Convert.ToInt32(sr.ReadLine());
                athleticsBonusBox.Text = sr.ReadLine();
                awarenessBonusBox.Text = sr.ReadLine();
                ballisticBonusBox.Text = sr.ReadLine();
                cunningBonusBox.Text = sr.ReadLine();
                deceptionBonusBox.Text = sr.ReadLine();
                insightBonusBox.Text = sr.ReadLine();
                intimidationBonusBox.Text = sr.ReadLine();
                investigationBonusBox.Text = sr.ReadLine();
                leadershipBonusBox.Text = sr.ReadLine();
                medicaeBonusBox.Text = sr.ReadLine();
                persuasionBonusBox.Text = sr.ReadLine();
                pilotBonusBox.Text = sr.ReadLine();
                psychicBonusBox.Text = sr.ReadLine();
                scholarBonusBox.Text = sr.ReadLine();
                stealthBonusBox.Text = sr.ReadLine();
                survivalBonusBox.Text = sr.ReadLine();
                techBonusBox.Text = sr.ReadLine();
                weaponSkillBonusBox.Text = sr.ReadLine();
                //bp goes here so as to not trigger value updates again
                totalBP = Convert.ToInt32(sr.ReadLine());
                totalSpentBP = Convert.ToInt32(sr.ReadLine());
                totalBPGained = Convert.ToInt32(sr.ReadLine());
                totalBPRemoved = Convert.ToInt32(sr.ReadLine());
                bpSpentOnRace = Convert.ToInt32(sr.ReadLine());
                bpSpentOnArchetype = Convert.ToInt32(sr.ReadLine());
                bpSpentOnSkills = Convert.ToInt32(sr.ReadLine());
                bpSpentOnAttributes = Convert.ToInt32(sr.ReadLine());
                // special boxes
                talentBox.Items.Clear();
                line = sr.ReadLine();
                while (line != "?????Equipment?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Equipment?????")
                    {
                        talentBox.Items.Add(line);
                    }
                }
                equipmentTextBox.Text = "";
                line = sr.ReadLine();
                while (line != "?????Powers?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Powers?????")
                    {
                        equipmentTextBox.Text += (line + Environment.NewLine);
                    }
                }
                powersTextBox.Text = "";
                while (line != "?????Notes?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Notes?????")
                    {
                        powersTextBox.Text += (line + Environment.NewLine);
                    }
                }
                notesTextBox.Text = "";
                while (line != null)
                {
                    line = sr.ReadLine();
                    notesTextBox.Text += (line + Environment.NewLine);
                }

                sr.Close();

                updateBuildPoints(0);
                updateAttribValues();

            }
        }
    }
}



