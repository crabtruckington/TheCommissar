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
        int rank = 1;
        int wealth = 1;
        int shock = 0;
        int wounds = 0;
        int defence = 0;
        int resilience = 0;
        int soak = 0;
        int speed = 0;
        int conviction = 0;
        int passiveAwareness = 0;
        int corruption = 0;
        int resolve = 0;
        int influence = 0;
        string raceSelection = "";
        string archetypeSelection = "";

        public mainForm()
        {
            InitializeComponent();

            calcValuesToolTip.ShowAlways = true;

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
            rankValueBox.Value = 1;
            wealthValueBox.Value = 0;
            updateBuildPoints(0);
        }

        // this does much more than just update buildpoints, it basically refreshes all the computed values and updates labels, but the input is for BP
        public void updateBuildPoints(int BPChange)
        {
            int bpChange = BPChange;
            totalSpentBP = totalSpentBP + BPChange;
            
            // Find current buildpoint values
            buildPointsLabel.Text = "Build Points: " + Convert.ToString(totalBP - totalSpentBP - bpSpentOnRace - bpSpentOnArchetype - bpSpentOnAttributes - bpSpentOnSkills);
            bpSpentAttribLabel.Text = "BP Spent on Attributes: " + Convert.ToString(bpSpentOnAttributes);
            bpSpentSkillsLabel.Text = "BP Spent on Skills: " + Convert.ToString(bpSpentOnSkills);
            bpSpentRaceLabel.Text = "BP Spent on Race: " + Convert.ToString(bpSpentOnRace);
            bpSpentArchetypeLabel.Text = "BP Spent on Archetype: " + Convert.ToString(bpSpentOnArchetype);

            //values need to be updated before summary tab is updated
            updateAttribValues();
            updateSkillValues();

            // update derived stats (traits) in summary tab and set tooltips
            shockTotalLabel.Text = "/ " + (Convert.ToString(Convert.ToInt32(attWillpowerTotal.Text) + tierSelection + Convert.ToInt32(shockValueBox.Value)));
            woundsTotalLabel.Text = "/ " + (Convert.ToString(Convert.ToInt32(attToughnessTotal.Text) + tierSelection + Convert.ToInt32(woundsValueBox.Value)));
            defenceTraitLabel.Text = "Defence: " + Convert.ToString(Convert.ToInt32(attInitiativeTotal.Text) - 1 + Convert.ToInt32(defenceValueBox.Value));
            resilienceTraitLabel.Text = "Resilience: " + Convert.ToString(Convert.ToInt32(attToughnessTotal.Text) + 1 + Convert.ToInt32(armorRatingBox.Value) + Convert.ToInt32(resilienceValueBox.Value));
            soakTraitLabel.Text = "Soak: " + Convert.ToString(Convert.ToInt32(attToughnessTotal.Text) + Convert.ToInt32(soakValueBox.Value));
            speedTraitLabel.Text = "Speed: " + attSpeedTotal.Text;
            convictionTraitLabel.Text = "Conviction: " + Convert.ToString(Convert.ToInt32(attWillpowerTotal.Text) + Convert.ToInt32(convictionValueBox.Value));
            passiveAwarenessTraitLabel.Text = "Passive Awareness: " + Convert.ToString((Convert.ToInt32(awarenessRatingLabel.Text) / 2) + Convert.ToInt32(passiveAwarenessValueBox.Value));
            corruptionTraitLabel.Text = "Corruption: " + Convert.ToString(corruptionValueBox.Value);
            resolveTraitLabel.Text = "Resolve: " + Convert.ToString(Convert.ToInt32(attWillpowerTotal.Text) - 1 + Convert.ToInt32(resolveValueBox.Value));
            influenceTraitLabel.Text = "Influence: " + Convert.ToString(Convert.ToInt32(attFellowshipTotal.Text) - 1 + influenceValueBox.Value);
            rankTraitLabel.Text = "Rank: " + Convert.ToString(rankValueBox.Value);
            wealthTraitLabel.Text = "Wealth: " + Convert.ToString(wealthValueBox.Value + tierSelection);
            lifetimeBPEarnedLabel.Text = "Lifetime BP: " + Convert.ToString(totalBPGained - totalBPRemoved);

            // update tooltips for summary tab
            calcValuesToolTip.SetToolTip(shockTotalLabel, "Willpower " + attWillpowerTotal.Text + " + Tier " + Convert.ToString(tierSelection) + " + Bonus " + Convert.ToString(shockValueBox.Value));
            calcValuesToolTip.SetToolTip(woundsTotalLabel, "Toughness " + attToughnessTotal.Text + " + Tier " + Convert.ToString(tierSelection) + " + Bonus " + Convert.ToString(woundsValueBox.Value));
            calcValuesToolTip.SetToolTip(defenceTraitLabel, "Initiative " + attInitiativeTotal.Text + " - 1 + Bonus " + Convert.ToString(defenceValueBox.Value));
            calcValuesToolTip.SetToolTip(resilienceTraitLabel, "Toughness " + attToughnessTotal.Text + " + 1 + Armor " + Convert.ToString(armorRatingBox.Value) + " + Bonus " + Convert.ToInt32(resilienceValueBox.Value));
            calcValuesToolTip.SetToolTip(soakTraitLabel, "Toughness " + attToughnessTotal.Text + " + Bonus " + Convert.ToString(soakValueBox.Value));
            calcValuesToolTip.SetToolTip(speedTraitLabel, "Speed " + attSpeedTotal.Text);
            calcValuesToolTip.SetToolTip(convictionTraitLabel, "Willpower " + attWillpowerTotal.Text + " + Bonus " + Convert.ToString(convictionValueBox.Value));
            calcValuesToolTip.SetToolTip(passiveAwarenessTraitLabel, "Awareness " + awarenessRatingLabel.Text + " / 2 + Bonus " + Convert.ToString(passiveAwarenessValueBox.Value));
            calcValuesToolTip.SetToolTip(corruptionTraitLabel, "Corruption " + Convert.ToString(corruptionValueBox.Value));
            calcValuesToolTip.SetToolTip(resolveTraitLabel, "Willpower " + attWillpowerTotal.Text + " - 1 + Bonus " + Convert.ToString(resolveValueBox.Value));
            calcValuesToolTip.SetToolTip(influenceTraitLabel, "Fellowship " + attFellowshipTotal.Text + " - 1 + Bonus " + Convert.ToString(influenceValueBox.Value));
            calcValuesToolTip.SetToolTip(rankTraitLabel, "Rank " + Convert.ToString(rankValueBox.Value));
            calcValuesToolTip.SetToolTip(wealthTraitLabel, "Tier " + Convert.ToString(tierSelection) + " + Bonus " + Convert.ToString(wealthValueBox.Value));
            calcValuesToolTip.SetToolTip(lifetimeBPEarnedLabel, "BP Gained " + Convert.ToString(totalBPGained) + " - BP Removed " + Convert.ToString(totalBPRemoved));
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

        //public void changeAttributeValue(string attribute, int value)
        //{
        //    string Attribute = attribute;
        //    int Value = value;

        //    if (Attribute == "strength")
        //        {
        //            attStrengthTotal.Text = Convert.ToString(Convert.ToInt32(attStrengthTotal.Text) + Value);
        //        }
        //    else if (Attribute == "agility")
        //        {
        //            attAgilityTotal.Text = Convert.ToString(Convert.ToInt32(attAgilityTotal.Text) + Value);
        //        }
        //    else if (Attribute == "toughness")
        //        {
        //            attToughnessTotal.Text = Convert.ToString(Convert.ToInt32(attToughnessTotal.Text) + Value);
        //        }
        //    else if (Attribute == "intellect")
        //        {
        //            attIntellectTotal.Text = Convert.ToString(Convert.ToInt32(attIntellectTotal.Text) + Value);
        //        }
        //    else if (Attribute == "willpower")
        //        {
        //            attWillpowerTotal.Text = Convert.ToString(Convert.ToInt32(attWillpowerTotal.Text) + Value);
        //        }
        //    else if (Attribute == "fellowship")
        //        {
        //            attFellowshipTotal.Text = Convert.ToString(Convert.ToInt32(attFellowshipTotal.Text) + Value);
        //        }
        //    else if (Attribute == "initiative")
        //        {
        //            attInitiativeTotal.Text = Convert.ToString(Convert.ToInt32(attInitiativeTotal.Text) + Value);
        //        }
        //    else if (Attribute == "speed")
        //        {
        //            // speed is unique in that its a derived state from your race
        //            attSpeedTotal.Text = Convert.ToString(Value);
        //        }
        //    else
        //        {
                    
        //        }
        //}

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

        private void armorRatingBox_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void wealthValueBox_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void corruptionValueBox_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void rankValueBox_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void defenceValueBox_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void influenceValueBox_ValueChanged_1(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void resolveValueBox_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void passiveAwarenessValueBox_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void convictionValueBox_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void resilienceValueBox_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void soakValueBox_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void woundsValueBox_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void shockValueBox_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void attStrengthModifier_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void attAgilityModifier_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void attToughnessModifier_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void attIntellectModifier_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void attWillpowerModifier_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void attFellowshipModifier_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void attInitiativeModifier_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void attSpeedModifier_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void powerMultiCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void attStrength_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(attStrength.Value);
            int change = newValue - prevValue;
            //changeAttributeValue("strength", change);
            updateAttribValues();
            updateAttribBuildPoints(prevValue, newValue);
        }

        private void attAgility_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(attAgility.Value);
            int change = newValue - prevValue;
            //changeAttributeValue("agility", change);
            updateAttribValues();
            updateAttribBuildPoints(prevValue, newValue);
        }

        private void attToughness_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(attToughness.Value);
            int change = newValue - prevValue;
            //changeAttributeValue("toughness", change);
            updateAttribValues();
            updateAttribBuildPoints(prevValue, newValue);
        }

        private void attIntellect_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(attIntellect.Value);
            int change = newValue - prevValue;
            //changeAttributeValue("intellect", change);
            updateAttribValues();
            updateAttribBuildPoints(prevValue, newValue);
        }

        private void attWillpower_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(attWillpower.Value);
            int change = newValue - prevValue;
            //changeAttributeValue("willpower", change);
            updateAttribValues();
            updateAttribBuildPoints(prevValue, newValue);
        }

        private void attFellowship_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(attFellowship.Value);
            int change = newValue - prevValue;
            //changeAttributeValue("fellowship", change);
            updateAttribValues();
            updateAttribBuildPoints(prevValue, newValue);
        }

        private void attInitiative_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(attInitiative.Value);
            int change = newValue - prevValue;
            //changeAttributeValue("initiative", change);
            updateAttribValues();
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

        private void addAugButton_Click(object sender, EventArgs e)
        {
            cyberneticsForm cyber = new cyberneticsForm();
            DialogResult dr = cyber.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                cyber.Close();
            }
            else if (dr == DialogResult.OK)
            {
                string results = cyber.returnAugDetails();
                augmeticsBox.Items.Add(results);
            }
        }

        private void removeAugButton_Click(object sender, EventArgs e)
        {
            augmeticsBox.Items.Remove(augmeticsBox.SelectedItem);
        }

        private void augmeticsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cyberneticsForm cyber = new cyberneticsForm();
            var results = new Tuple<string, string, string>("", "", "");
            results = cyber.getAugDetails(Convert.ToString(augmeticsBox.SelectedItem));
            augRaceLabel.Text = results.Item2;
            augDetailsLabel.Text = results.Item3;
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
            //changeSkillValue("athletics");
            //updateSkillValues();
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
            //changeSkillValue("awareness");
            ////updateSkillValues();
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillBallstic_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillBallstic.Value);
            int change = newValue - prevValue;
            //changeSkillValue("ballistic");
            ////updateSkillValues();
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillCunning_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillCunning.Value);
            int change = newValue - prevValue;
            //changeSkillValue("cunning");
            ////updateSkillValues();
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillDeception_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillDeception.Value);
            int change = newValue - prevValue;
            //changeSkillValue("deception");
            ////updateSkillValues();
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillInsight_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillInsight.Value);
            int change = newValue - prevValue;
            //changeSkillValue("insight");
            ////updateSkillValues();
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillIntimidation_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillIntimidation.Value);
            int change = newValue - prevValue;
            //changeSkillValue("intimidation");
            //updateSkillValues();
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillInvestigation_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillInvestigation.Value);
            int change = newValue - prevValue;
            //changeSkillValue("investigation");
            //updateSkillValues();
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillLeadership_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillLeadership.Value);
            int change = newValue - prevValue;
            //changeSkillValue("leadership");
            //updateSkillValues();
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillMedicae_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillMedicae.Value);
            int change = newValue - prevValue;
            //changeSkillValue("medicae");
            //updateSkillValues();
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillPersuasion_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillPersuasion.Value);
            int change = newValue - prevValue;
            //changeSkillValue("persuasion");
            //updateSkillValues();
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillPilot_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillPilot.Value);
            int change = newValue - prevValue;
            //changeSkillValue("pilot");
            //updateSkillValues();
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillPsychic_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillPsychic.Value);
            int change = newValue - prevValue;
            //changeSkillValue("psychic");
            //updateSkillValues();
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillScholar_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillScholar.Value);
            int change = newValue - prevValue;
            //changeSkillValue("scholar");
            //updateSkillValues();
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillStealth_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillStealth.Value);
            int change = newValue - prevValue;
            //changeSkillValue("stealth");
            //updateSkillValues();
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillSurvival_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillSurvival.Value);
            int change = newValue - prevValue;
            //changeSkillValue("survival");
            //updateSkillValues();
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillTech_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillTech.Value);
            int change = newValue - prevValue;
            //changeSkillValue("tech");
            //updateSkillValues();
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillWeaponSkill_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillWeaponSkill.Value);
            int change = newValue - prevValue;
            //changeSkillValue("weapon");
            //updateSkillValues();
            updateSkillBuildPoints(prevValue, newValue);
        }

        private void skillAthleticsBonus_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void skillAwarenessBonus_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void skillBallisticBonus_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void skillCunningBonus_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void skillDeceptionBonus_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void skillInsightBonus_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void skillIntimidationBonus_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void skillInvestigationBonus_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void skillLeadershipBonus_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void skillMedicaeBonus_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void skillPersuasionBonus_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void skillPilotBonus_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void skillPsychicBonus_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void skillScholarBonus_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void skillAgilityBonus_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void skillSurvivalBonus_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void skillTechBonus_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }

        private void skillWeaponSkillBonus_ValueChanged(object sender, EventArgs e)
        {
            updateBuildPoints(0);
        }




        public void updateSkillValues()
        {
            athleticsRatingLabel.Text = Convert.ToString(skillAthletics.Value +  skillAthleticsBonus.Value + Convert.ToInt32(attStrengthTotal.Text));
            awarenessRatingLabel.Text = Convert.ToString(skillAwareness.Value + skillAwarenessBonus.Value + Convert.ToInt32(attIntellectTotal.Text));
            ballisticRatingLabel.Text = Convert.ToString(skillBallstic.Value + skillBallisticBonus.Value + Convert.ToInt32(attAgilityTotal.Text));
            cunningRatingLabel.Text = Convert.ToString(skillCunning.Value + +skillCunningBonus.Value + Convert.ToInt32(attFellowshipTotal.Text));
            deceptionRatingLabel.Text = Convert.ToString(skillDeception.Value + skillDeceptionBonus.Value + Convert.ToInt32(attFellowshipTotal.Text));
            insightRatingLabel.Text = Convert.ToString(skillInsight.Value + skillInsightBonus.Value + Convert.ToInt32(attFellowshipTotal.Text));
            intimidationRatingLabel.Text = Convert.ToString(skillIntimidation.Value + skillIntimidationBonus.Value + Convert.ToInt32(attWillpowerTotal.Text));
            investigationRatingLabel.Text = Convert.ToString(skillInvestigation.Value + skillInvestigationBonus.Value + Convert.ToInt32(attIntellectTotal.Text));
            leadershipRatingLabel.Text = Convert.ToString(skillLeadership.Value + skillLeadershipBonus.Value + Convert.ToInt32(attFellowshipTotal.Text));
            medicaeRatingLabel.Text = Convert.ToString(skillMedicae.Value + skillMedicaeBonus.Value + Convert.ToInt32(attIntellectTotal.Text));
            persuasionRatingLabel.Text = Convert.ToString(skillPersuasion.Value + skillPersuasionBonus.Value + Convert.ToInt32(attFellowshipTotal.Text));
            pilotRatingLabel.Text = Convert.ToString(skillPilot.Value + skillPilotBonus.Value + Convert.ToInt32(attAgilityTotal.Text));
            psychicRatingLabel.Text = Convert.ToString(skillPsychic.Value + skillPsychicBonus.Value + Convert.ToInt32(attWillpowerTotal.Text));
            scholarRatingLabel.Text = Convert.ToString(skillScholar.Value + skillScholarBonus.Value + Convert.ToInt32(attIntellectTotal.Text));
            stealthRatingLabel.Text = Convert.ToString(skillStealth.Value + skillStealthBonus.Value + Convert.ToInt32(attAgilityTotal.Text));
            survivalRatingLabel.Text = Convert.ToString(skillSurvival.Value + skillSurvivalBonus.Value + Convert.ToInt32(attWillpowerTotal.Text));
            techRatingLabel.Text = Convert.ToString(skillTech.Value + skillTechBonus.Value + Convert.ToInt32(attIntellectTotal.Text));
            weaponSkillRatingLabel.Text = Convert.ToString(skillWeaponSkill.Value + skillWeaponSkillBonus.Value + Convert.ToInt32(attInitiativeTotal.Text));
        }

        public void updateAttribValues()
        {
            attStrengthTotal.Text = Convert.ToString(attStrength.Value + attStrengthModifier.Value);
            attAgilityTotal.Text = Convert.ToString(attAgility.Value + attAgilityModifier.Value);
            attToughnessTotal.Text = Convert.ToString(attToughness.Value + attToughnessModifier.Value);
            attIntellectTotal.Text = Convert.ToString(attIntellect.Value + attIntellectModifier.Value);
            attWillpowerTotal.Text = Convert.ToString(attWillpower.Value + attWillpowerModifier.Value);
            attFellowshipTotal.Text = Convert.ToString(attFellowship.Value + attFellowshipModifier.Value);
            attInitiativeTotal.Text = Convert.ToString(attInitiative.Value + attInitiativeModifier.Value);
            attSpeedTotal.Text = Convert.ToString(attSpeed.Value + attSpeedModifier.Value);
        }

        public void updateSpeciesSelectList()
        {
            speciesSelect.Items.Clear();
            speciesSelect.Items.Add("Human, 0BP");
            speciesSelect.Items.Add("Eldar, 10BP");
            speciesSelect.Items.Add("Ork, 10BP");
            speciesSelect.Items.Add("Necron, 20BP");
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
                if (raceSelection == "Necron, 20BP")
                {
                    archetypeSelect.Items.Add("Necron Warrior");
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
                if (raceSelection == "Necron, 20BP")
                {
                    archetypeSelect.Items.Add("Necron Cryptek");
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
                if (raceSelection == "Necron, 20BP")
                {
                    archetypeSelect.Items.Add("Necron Nemesor");
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
                //changeAttributeValue("speed", 6);
                attSpeed.Value = 6;
            }
            else if (raceSelection == "Eldar, 10BP")
            {
                bpSpentOnRace = 10;
                //changeAttributeValue("speed", 8);
                attSpeed.Value = 8;
            }
            else if (raceSelection == "Ork, 10BP")
            {
                bpSpentOnRace = 10;
                //changeAttributeValue("speed", 6);
                attSpeed.Value = 6;
            }
            else if (raceSelection == "Necron, 20BP")
            {
                bpSpentOnRace = 20;
                attSpeed.Value = 5;
            }
            else if (raceSelection == "Adeptus Astartes, 50BP")
            {
                bpSpentOnRace = 50;
                //changeAttributeValue("speed", 7);
                attSpeed.Value = 7;
            }
            else if (raceSelection == "Primaris Astartes, 100BP")
            {
                bpSpentOnRace = 100;
                //changeAttributeValue("speed", 6);
                attSpeed.Value = 6;
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
                archetypeSelect.SelectedItem.ToString() == "Ork Boy" || archetypeSelect.SelectedItem.ToString() == "Necron Warrior")
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
                archetypeSelect.SelectedItem.ToString() == "Imperial Commisar" || archetypeSelect.SelectedItem.ToString() == "Tactical Space Marine" ||
                archetypeSelect.SelectedItem.ToString() == "Necron Cryptek")
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
            if (archetypeSelect.SelectedItem.ToString() == "Eldar Warlock" || archetypeSelect.SelectedItem.ToString() == "Necron Nemesor")
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
                totalBPGained = totalBPGained + results;
                updateBuildPoints(results * -1);                
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
                totalBPRemoved = totalBPRemoved + results;
                updateBuildPoints(results);                
            }
        }


        //saving routine, this is totally gross
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
                sw.WriteLine(Convert.ToString(skillAthleticsBonus.Value));
                sw.WriteLine(Convert.ToString(skillAwarenessBonus.Value));
                sw.WriteLine(Convert.ToString(skillBallisticBonus.Value));
                sw.WriteLine(Convert.ToString(skillCunningBonus.Value));
                sw.WriteLine(Convert.ToString(skillDeceptionBonus.Value));
                sw.WriteLine(Convert.ToString(skillInsightBonus.Value));
                sw.WriteLine(Convert.ToString(skillIntimidationBonus.Value));
                sw.WriteLine(Convert.ToString(skillInvestigationBonus.Value));
                sw.WriteLine(Convert.ToString(skillLeadershipBonus.Value));
                sw.WriteLine(Convert.ToString(skillMedicaeBonus.Value));
                sw.WriteLine(Convert.ToString(skillPersuasionBonus.Value));
                sw.WriteLine(Convert.ToString(skillPilotBonus.Value));
                sw.WriteLine(Convert.ToString(skillPsychicBonus.Value));
                sw.WriteLine(Convert.ToString(skillScholarBonus.Value));
                sw.WriteLine(Convert.ToString(skillStealthBonus.Value));
                sw.WriteLine(Convert.ToString(skillSurvivalBonus.Value));
                sw.WriteLine(Convert.ToString(skillTechBonus.Value));
                sw.WriteLine(Convert.ToString(skillWeaponSkillBonus.Value));

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
                sw.WriteLine(Convert.ToString(rankValueBox.Value));
                sw.WriteLine(Convert.ToString(wealthValueBox.Value));
                sw.WriteLine(Convert.ToString(corruptionValueBox.Value));
                sw.WriteLine(Convert.ToString(defenceValueBox.Value));
                //new stuff below defence
                sw.WriteLine(Convert.ToString(soakValueBox.Value));
                sw.WriteLine(Convert.ToString(woundsValueBox.Value));
                sw.WriteLine(Convert.ToString(resilienceValueBox.Value));
                sw.WriteLine(Convert.ToString(convictionValueBox.Value));
                sw.WriteLine(Convert.ToString(passiveAwarenessValueBox.Value));
                sw.WriteLine(Convert.ToString(resolveValueBox.Value));
                sw.WriteLine(Convert.ToString(influenceValueBox.Value));
                sw.WriteLine(Convert.ToString(shockValueBox.Value));
                //new stuff above strength modifier
                sw.WriteLine(Convert.ToString(attStrengthModifier.Value));
                sw.WriteLine(Convert.ToString(attAgilityModifier.Value));
                sw.WriteLine(Convert.ToString(attToughnessModifier.Value));
                sw.WriteLine(Convert.ToString(attIntellectModifier.Value));
                sw.WriteLine(Convert.ToString(attWillpowerModifier.Value));
                sw.WriteLine(Convert.ToString(attFellowshipModifier.Value));
                sw.WriteLine(Convert.ToString(attInitiativeModifier.Value));
                sw.WriteLine(Convert.ToString(attSpeedModifier.Value));
                sw.WriteLine("?????RangedWeaponName?????");
                sw.WriteLine(Convert.ToString(rangedWeaponNameBox.Text));
                sw.WriteLine("?????RangedWeaponNameEnd?????");
                sw.WriteLine(Convert.ToString(rangedWeaponDamageBox.Text));
                sw.WriteLine(Convert.ToString(rangedWeaponEDBox.Text));
                sw.WriteLine(Convert.ToString(rangedWeaponAPBox.Text));
                sw.WriteLine(Convert.ToString(rangedWeaponRangeBox.Text));
                sw.WriteLine(Convert.ToString(rangedWeaponSalvoBox.Text));
                sw.WriteLine("?????RangedWeaponTraits?????");
                sw.WriteLine(Convert.ToString(rangedWeaponTraitBox.Text));
                sw.WriteLine("?????RangedWeaponTraitsEnd?????");
                sw.WriteLine(Convert.ToString(rangedWeaponValueBox.Text));
                sw.WriteLine("?????RangedWeaponKeywords?????");
                sw.WriteLine(Convert.ToString(rangedWeaponKeywordsBox.Text));
                sw.WriteLine("?????RangedWeaponKeywordsEnd?????");
                sw.WriteLine("?????MeleeWeaponName?????");
                sw.WriteLine(Convert.ToString(meleeWeaponNameBox.Text));
                sw.WriteLine("?????MeleeWeaponNameEnd?????");
                sw.WriteLine(Convert.ToString(meleeWeaponDamageBox.Text));
                sw.WriteLine(Convert.ToString(meleeWeaponEDBox.Text));
                sw.WriteLine(Convert.ToString(meleeWeaponAPBox.Text));
                sw.WriteLine("?????MeleeWeaponRange?????");
                sw.WriteLine(Convert.ToString(MeleeWeaponRangeBox.Text));
                sw.WriteLine("?????MeleeWeaponRangeEnd?????");
                sw.WriteLine("?????MeleeWeaponTraits?????");
                sw.WriteLine(Convert.ToString(meleeWeaponTraitsBox.Text));
                sw.WriteLine("?????MeleeWeaponTraitsEnd?????");
                sw.WriteLine(Convert.ToString(meleeWeaponValueBox.Text));
                sw.WriteLine("?????MeleeWeaponKeywords?????");
                sw.WriteLine(Convert.ToString(meleeWeaponKeywordsBox.Text));
                sw.WriteLine("?????MeleeWeaponKeywordsEnd?????");
                sw.WriteLine("?????ArmorName?????");
                sw.WriteLine(Convert.ToString(armorNameBox.Text));
                sw.WriteLine("?????ArmorNameEnd?????");
                sw.WriteLine(Convert.ToString(armorRatingBox.Value));
                sw.WriteLine("?????ArmorTraits?????");
                sw.WriteLine(Convert.ToString(armorTraitsBox.Text));
                sw.WriteLine("?????ArmorTraitsEnd?????");
                sw.WriteLine(Convert.ToString(armorValueBox.Text));
                sw.WriteLine("?????ArmorKeywords?????");
                sw.WriteLine(Convert.ToString(armorKeywordsBox.Text));
                sw.WriteLine("?????ArmorKeywordsEnd?????");
                sw.WriteLine(Convert.ToString("?????Power1?????"));
                sw.WriteLine(Convert.ToString(powerNameBox1.Text));
                sw.WriteLine(Convert.ToString("?????Power2?????"));
                sw.WriteLine(Convert.ToString(powerNameBox2.Text));
                sw.WriteLine(Convert.ToString("?????Power3?????"));
                sw.WriteLine(Convert.ToString(powerNameBox3.Text));
                sw.WriteLine(Convert.ToString("?????Power4?????"));
                sw.WriteLine(Convert.ToString(powerNameBox4.Text));
                sw.WriteLine(Convert.ToString("?????Power5?????"));
                sw.WriteLine(Convert.ToString(powerNameBox5.Text));
                sw.WriteLine(Convert.ToString("?????Power6?????"));
                sw.WriteLine(Convert.ToString(powerNameBox6.Text));
                sw.WriteLine(Convert.ToString("?????Power7?????"));
                sw.WriteLine(Convert.ToString(powerNameBox7.Text));
                sw.WriteLine(Convert.ToString("?????Power8?????"));
                sw.WriteLine(Convert.ToString(powerNameBox8.Text));
                sw.WriteLine(Convert.ToString("?????Power9?????"));
                sw.WriteLine(Convert.ToString(powerNameBox9.Text));
                sw.WriteLine(Convert.ToString("?????Power10?????"));
                sw.WriteLine(Convert.ToString(powerNameBox10.Text));
                sw.WriteLine(Convert.ToString("?????Power11?????"));
                sw.WriteLine(Convert.ToString(powerNameBox11.Text));
                sw.WriteLine(Convert.ToString("?????Power12?????"));
                sw.WriteLine(Convert.ToString(powerNameBox12.Text));
                sw.WriteLine(Convert.ToString("?????Power13?????"));
                sw.WriteLine(Convert.ToString(powerNameBox13.Text));
                sw.WriteLine(Convert.ToString("?????Power14?????"));
                sw.WriteLine(Convert.ToString(powerNameBox14.Text));
                sw.WriteLine(Convert.ToString("?????Power15?????"));
                sw.WriteLine(Convert.ToString(powerNameBox15.Text));
                sw.WriteLine(Convert.ToString("?????Power16?????"));
                sw.WriteLine(Convert.ToString(powerNameBox16.Text));
                sw.WriteLine(Convert.ToString("?????Power17?????"));
                sw.WriteLine(Convert.ToString(powerNameBox17.Text));
                sw.WriteLine(Convert.ToString("?????Power18?????"));
                sw.WriteLine(Convert.ToString(powerNameBox18.Text));
                sw.WriteLine(Convert.ToString("?????Power19?????"));
                sw.WriteLine(Convert.ToString(powerNameBox19.Text));
                sw.WriteLine(Convert.ToString("?????Power20?????"));
                sw.WriteLine(Convert.ToString(powerNameBox20.Text));
                sw.WriteLine(Convert.ToString("?????Power21?????"));
                sw.WriteLine(Convert.ToString(powerNameBox21.Text));
                sw.WriteLine(Convert.ToString("?????Power22?????"));
                sw.WriteLine(Convert.ToString(powerNameBox22.Text));
                sw.WriteLine(Convert.ToString("?????Power23?????"));
                sw.WriteLine(Convert.ToString(powerNameBox23.Text));
                sw.WriteLine(Convert.ToString("?????Power24?????"));
                sw.WriteLine(Convert.ToString(powerNameBox24.Text));
                sw.WriteLine(Convert.ToString("?????PowerDamage1?????"));
                sw.WriteLine(Convert.ToString(powerDamageBox1.Text));
                sw.WriteLine(Convert.ToString("?????PowerDamage2?????"));
                sw.WriteLine(Convert.ToString(powerDamageBox2.Text));
                sw.WriteLine(Convert.ToString("?????PowerDamage3?????"));
                sw.WriteLine(Convert.ToString(powerDamageBox3.Text));
                sw.WriteLine(Convert.ToString("?????PowerDamage4?????"));
                sw.WriteLine(Convert.ToString(powerDamageBox4.Text));
                sw.WriteLine(Convert.ToString("?????PowerDamage5?????"));
                sw.WriteLine(Convert.ToString(powerDamageBox5.Text));
                sw.WriteLine(Convert.ToString("?????PowerDamage6?????"));
                sw.WriteLine(Convert.ToString(powerDamageBox6.Text));
                sw.WriteLine(Convert.ToString("?????PowerDamage7?????"));
                sw.WriteLine(Convert.ToString(powerDamageBox7.Text));
                sw.WriteLine(Convert.ToString("?????PowerDamage8?????"));
                sw.WriteLine(Convert.ToString(powerDamageBox8.Text));
                sw.WriteLine(Convert.ToString("?????PowerDamage9?????"));
                sw.WriteLine(Convert.ToString(powerDamageBox9.Text));
                sw.WriteLine(Convert.ToString("?????PowerDamage10?????"));
                sw.WriteLine(Convert.ToString(powerDamageBox10.Text));
                sw.WriteLine(Convert.ToString("?????PowerDamage11?????"));
                sw.WriteLine(Convert.ToString(powerDamageBox11.Text));
                sw.WriteLine(Convert.ToString("?????PowerDamage12?????"));
                sw.WriteLine(Convert.ToString(powerDamageBox12.Text));
                sw.WriteLine(Convert.ToString("?????PowerDamage13?????"));
                sw.WriteLine(Convert.ToString(powerDamageBox13.Text));
                sw.WriteLine(Convert.ToString("?????PowerDamage14?????"));
                sw.WriteLine(Convert.ToString(powerDamageBox14.Text));
                sw.WriteLine(Convert.ToString("?????PowerDamage15?????"));
                sw.WriteLine(Convert.ToString(powerDamageBox15.Text));
                sw.WriteLine(Convert.ToString("?????PowerDamage16?????"));
                sw.WriteLine(Convert.ToString(powerDamageBox16.Text));
                sw.WriteLine(Convert.ToString("?????PowerDamage17?????"));
                sw.WriteLine(Convert.ToString(powerDamageBox17.Text));
                sw.WriteLine(Convert.ToString("?????PowerDamage18?????"));
                sw.WriteLine(Convert.ToString(powerDamageBox18.Text));
                sw.WriteLine(Convert.ToString("?????PowerDamage19?????"));
                sw.WriteLine(Convert.ToString(powerDamageBox19.Text));
                sw.WriteLine(Convert.ToString("?????PowerDamage20?????"));
                sw.WriteLine(Convert.ToString(powerDamageBox20.Text));
                sw.WriteLine(Convert.ToString("?????PowerDamage21?????"));
                sw.WriteLine(Convert.ToString(powerDamageBox21.Text));
                sw.WriteLine(Convert.ToString("?????PowerDamage22?????"));
                sw.WriteLine(Convert.ToString(powerDamageBox22.Text));
                sw.WriteLine(Convert.ToString("?????PowerDamage23?????"));
                sw.WriteLine(Convert.ToString(powerDamageBox23.Text));
                sw.WriteLine(Convert.ToString("?????PowerDamage24?????"));
                sw.WriteLine(Convert.ToString(powerDamageBox24.Text));
                sw.WriteLine(Convert.ToString("?????PowerED1?????"));
                sw.WriteLine(Convert.ToString(powerEDBox1.Text));
                sw.WriteLine(Convert.ToString("?????PowerED2?????"));
                sw.WriteLine(Convert.ToString(powerEDBox2.Text));
                sw.WriteLine(Convert.ToString("?????PowerED3?????"));
                sw.WriteLine(Convert.ToString(powerEDBox3.Text));
                sw.WriteLine(Convert.ToString("?????PowerED4?????"));
                sw.WriteLine(Convert.ToString(powerEDBox4.Text));
                sw.WriteLine(Convert.ToString("?????PowerED5?????"));
                sw.WriteLine(Convert.ToString(powerEDBox5.Text));
                sw.WriteLine(Convert.ToString("?????PowerED6?????"));
                sw.WriteLine(Convert.ToString(powerEDBox6.Text));
                sw.WriteLine(Convert.ToString("?????PowerED7?????"));
                sw.WriteLine(Convert.ToString(powerEDBox7.Text));
                sw.WriteLine(Convert.ToString("?????PowerED8?????"));
                sw.WriteLine(Convert.ToString(powerEDBox8.Text));
                sw.WriteLine(Convert.ToString("?????PowerED9?????"));
                sw.WriteLine(Convert.ToString(powerEDBox9.Text));
                sw.WriteLine(Convert.ToString("?????PowerED10?????"));
                sw.WriteLine(Convert.ToString(powerEDBox10.Text));
                sw.WriteLine(Convert.ToString("?????PowerED11?????"));
                sw.WriteLine(Convert.ToString(powerEDBox11.Text));
                sw.WriteLine(Convert.ToString("?????PowerED12?????"));
                sw.WriteLine(Convert.ToString(powerEDBox12.Text));
                sw.WriteLine(Convert.ToString("?????PowerED13?????"));
                sw.WriteLine(Convert.ToString(powerEDBox13.Text));
                sw.WriteLine(Convert.ToString("?????PowerED14?????"));
                sw.WriteLine(Convert.ToString(powerEDBox14.Text));
                sw.WriteLine(Convert.ToString("?????PowerED15?????"));
                sw.WriteLine(Convert.ToString(powerEDBox15.Text));
                sw.WriteLine(Convert.ToString("?????PowerED16?????"));
                sw.WriteLine(Convert.ToString(powerEDBox16.Text));
                sw.WriteLine(Convert.ToString("?????PowerED17?????"));
                sw.WriteLine(Convert.ToString(powerEDBox17.Text));
                sw.WriteLine(Convert.ToString("?????PowerED18?????"));
                sw.WriteLine(Convert.ToString(powerEDBox18.Text));
                sw.WriteLine(Convert.ToString("?????PowerED19?????"));
                sw.WriteLine(Convert.ToString(powerEDBox19.Text));
                sw.WriteLine(Convert.ToString("?????PowerED20?????"));
                sw.WriteLine(Convert.ToString(powerEDBox20.Text));
                sw.WriteLine(Convert.ToString("?????PowerED21?????"));
                sw.WriteLine(Convert.ToString(powerEDBox21.Text));
                sw.WriteLine(Convert.ToString("?????PowerED22?????"));
                sw.WriteLine(Convert.ToString(powerEDBox22.Text));
                sw.WriteLine(Convert.ToString("?????PowerED23?????"));
                sw.WriteLine(Convert.ToString(powerEDBox23.Text));
                sw.WriteLine(Convert.ToString("?????PowerED24?????"));
                sw.WriteLine(Convert.ToString(powerEDBox24.Text));
                sw.WriteLine(Convert.ToString("?????PowerActivation1?????"));
                sw.WriteLine(Convert.ToString(powerActivationBox1.Text));
                sw.WriteLine(Convert.ToString("?????PowerActivation2?????"));
                sw.WriteLine(Convert.ToString(powerActivationBox2.Text));
                sw.WriteLine(Convert.ToString("?????PowerActivation3?????"));
                sw.WriteLine(Convert.ToString(powerActivationBox3.Text));
                sw.WriteLine(Convert.ToString("?????PowerActivation4?????"));
                sw.WriteLine(Convert.ToString(powerActivationBox4.Text));
                sw.WriteLine(Convert.ToString("?????PowerActivation5?????"));
                sw.WriteLine(Convert.ToString(powerActivationBox5.Text));
                sw.WriteLine(Convert.ToString("?????PowerActivation6?????"));
                sw.WriteLine(Convert.ToString(powerActivationBox6.Text));
                sw.WriteLine(Convert.ToString("?????PowerActivation7?????"));
                sw.WriteLine(Convert.ToString(powerActivationBox7.Text));
                sw.WriteLine(Convert.ToString("?????PowerActivation8?????"));
                sw.WriteLine(Convert.ToString(powerActivationBox8.Text));
                sw.WriteLine(Convert.ToString("?????PowerActivation9?????"));
                sw.WriteLine(Convert.ToString(powerActivationBox9.Text));
                sw.WriteLine(Convert.ToString("?????PowerActivation10?????"));
                sw.WriteLine(Convert.ToString(powerActivationBox10.Text));
                sw.WriteLine(Convert.ToString("?????PowerActivation11?????"));
                sw.WriteLine(Convert.ToString(powerActivationBox11.Text));
                sw.WriteLine(Convert.ToString("?????PowerActivation12?????"));
                sw.WriteLine(Convert.ToString(powerActivationBox12.Text));
                sw.WriteLine(Convert.ToString("?????PowerActivation13?????"));
                sw.WriteLine(Convert.ToString(powerActivationBox13.Text));
                sw.WriteLine(Convert.ToString("?????PowerActivation14?????"));
                sw.WriteLine(Convert.ToString(powerActivationBox14.Text));
                sw.WriteLine(Convert.ToString("?????PowerActivation15?????"));
                sw.WriteLine(Convert.ToString(powerActivationBox15.Text));
                sw.WriteLine(Convert.ToString("?????PowerActivation16?????"));
                sw.WriteLine(Convert.ToString(powerActivationBox16.Text));
                sw.WriteLine(Convert.ToString("?????PowerActivation17?????"));
                sw.WriteLine(Convert.ToString(powerActivationBox17.Text));
                sw.WriteLine(Convert.ToString("?????PowerActivation18?????"));
                sw.WriteLine(Convert.ToString(powerActivationBox18.Text));
                sw.WriteLine(Convert.ToString("?????PowerActivation19?????"));
                sw.WriteLine(Convert.ToString(powerActivationBox19.Text));
                sw.WriteLine(Convert.ToString("?????PowerActivation20?????"));
                sw.WriteLine(Convert.ToString(powerActivationBox20.Text));
                sw.WriteLine(Convert.ToString("?????PowerActivation21?????"));
                sw.WriteLine(Convert.ToString(powerActivationBox21.Text));
                sw.WriteLine(Convert.ToString("?????PowerActivation22?????"));
                sw.WriteLine(Convert.ToString(powerActivationBox22.Text));
                sw.WriteLine(Convert.ToString("?????PowerActivation23?????"));
                sw.WriteLine(Convert.ToString(powerActivationBox23.Text));
                sw.WriteLine(Convert.ToString("?????PowerActivation24?????"));
                sw.WriteLine(Convert.ToString(powerActivationBox24.Text));
                sw.WriteLine(Convert.ToString("?????PowerRange1?????"));
                sw.WriteLine(Convert.ToString(powerRangeBox1.Text));
                sw.WriteLine(Convert.ToString("?????PowerRange2?????"));
                sw.WriteLine(Convert.ToString(powerRangeBox2.Text));
                sw.WriteLine(Convert.ToString("?????PowerRange3?????"));
                sw.WriteLine(Convert.ToString(powerRangeBox3.Text));
                sw.WriteLine(Convert.ToString("?????PowerRange4?????"));
                sw.WriteLine(Convert.ToString(powerRangeBox4.Text));
                sw.WriteLine(Convert.ToString("?????PowerRange5?????"));
                sw.WriteLine(Convert.ToString(powerRangeBox5.Text));
                sw.WriteLine(Convert.ToString("?????PowerRange6?????"));
                sw.WriteLine(Convert.ToString(powerRangeBox6.Text));
                sw.WriteLine(Convert.ToString("?????PowerRange7?????"));
                sw.WriteLine(Convert.ToString(powerRangeBox7.Text));
                sw.WriteLine(Convert.ToString("?????PowerRange8?????"));
                sw.WriteLine(Convert.ToString(powerRangeBox8.Text));
                sw.WriteLine(Convert.ToString("?????PowerRange9?????"));
                sw.WriteLine(Convert.ToString(powerRangeBox9.Text));
                sw.WriteLine(Convert.ToString("?????PowerRange10?????"));
                sw.WriteLine(Convert.ToString(powerRangeBox10.Text));
                sw.WriteLine(Convert.ToString("?????PowerRange11?????"));
                sw.WriteLine(Convert.ToString(powerRangeBox11.Text));
                sw.WriteLine(Convert.ToString("?????PowerRange12?????"));
                sw.WriteLine(Convert.ToString(powerRangeBox12.Text));
                sw.WriteLine(Convert.ToString("?????PowerRange13?????"));
                sw.WriteLine(Convert.ToString(powerRangeBox13.Text));
                sw.WriteLine(Convert.ToString("?????PowerRange14?????"));
                sw.WriteLine(Convert.ToString(powerRangeBox14.Text));
                sw.WriteLine(Convert.ToString("?????PowerRange15?????"));
                sw.WriteLine(Convert.ToString(powerRangeBox15.Text));
                sw.WriteLine(Convert.ToString("?????PowerRange16?????"));
                sw.WriteLine(Convert.ToString(powerRangeBox16.Text));
                sw.WriteLine(Convert.ToString("?????PowerRange17?????"));
                sw.WriteLine(Convert.ToString(powerRangeBox17.Text));
                sw.WriteLine(Convert.ToString("?????PowerRange18?????"));
                sw.WriteLine(Convert.ToString(powerRangeBox18.Text));
                sw.WriteLine(Convert.ToString("?????PowerRange19?????"));
                sw.WriteLine(Convert.ToString(powerRangeBox19.Text));
                sw.WriteLine(Convert.ToString("?????PowerRange20?????"));
                sw.WriteLine(Convert.ToString(powerRangeBox20.Text));
                sw.WriteLine(Convert.ToString("?????PowerRange21?????"));
                sw.WriteLine(Convert.ToString(powerRangeBox21.Text));
                sw.WriteLine(Convert.ToString("?????PowerRange22?????"));
                sw.WriteLine(Convert.ToString(powerRangeBox22.Text));
                sw.WriteLine(Convert.ToString("?????PowerRange23?????"));
                sw.WriteLine(Convert.ToString(powerRangeBox23.Text));
                sw.WriteLine(Convert.ToString("?????PowerRange24?????"));
                sw.WriteLine(Convert.ToString(powerRangeBox24.Text));
                sw.WriteLine(Convert.ToString("?????PowerMulti1?????"));
                sw.WriteLine(Convert.ToString(powerMultiCheckBox1.Checked.ToString()));
                sw.WriteLine(Convert.ToString(powerMultiCheckBox2.Checked.ToString()));
                sw.WriteLine(Convert.ToString(powerMultiCheckBox3.Checked.ToString()));
                sw.WriteLine(Convert.ToString(powerMultiCheckBox4.Checked.ToString()));
                sw.WriteLine(Convert.ToString(powerMultiCheckBox5.Checked.ToString()));
                sw.WriteLine(Convert.ToString(powerMultiCheckBox6.Checked.ToString()));
                sw.WriteLine(Convert.ToString(powerMultiCheckBox7.Checked.ToString()));
                sw.WriteLine(Convert.ToString(powerMultiCheckBox8.Checked.ToString()));
                sw.WriteLine(Convert.ToString(powerMultiCheckBox9.Checked.ToString()));
                sw.WriteLine(Convert.ToString(powerMultiCheckBox10.Checked.ToString()));
                sw.WriteLine(Convert.ToString(powerMultiCheckBox11.Checked.ToString()));
                sw.WriteLine(Convert.ToString(powerMultiCheckBox12.Checked.ToString()));
                sw.WriteLine(Convert.ToString(powerMultiCheckBox13.Checked.ToString()));
                sw.WriteLine(Convert.ToString(powerMultiCheckBox14.Checked.ToString()));
                sw.WriteLine(Convert.ToString(powerMultiCheckBox15.Checked.ToString()));
                sw.WriteLine(Convert.ToString(powerMultiCheckBox16.Checked.ToString()));
                sw.WriteLine(Convert.ToString(powerMultiCheckBox17.Checked.ToString()));
                sw.WriteLine(Convert.ToString(powerMultiCheckBox18.Checked.ToString()));
                sw.WriteLine(Convert.ToString(powerMultiCheckBox19.Checked.ToString()));
                sw.WriteLine(Convert.ToString(powerMultiCheckBox20.Checked.ToString()));
                sw.WriteLine(Convert.ToString(powerMultiCheckBox21.Checked.ToString()));
                sw.WriteLine(Convert.ToString(powerMultiCheckBox22.Checked.ToString()));
                sw.WriteLine(Convert.ToString(powerMultiCheckBox23.Checked.ToString()));
                sw.WriteLine(Convert.ToString(powerMultiCheckBox24.Checked.ToString()));
                sw.WriteLine(Convert.ToString("?????PowerKeyword1?????"));
                sw.WriteLine(Convert.ToString(powerKeywordBox1.Text));
                sw.WriteLine(Convert.ToString("?????PowerKeyword2?????"));
                sw.WriteLine(Convert.ToString(powerKeywordBox2.Text));
                sw.WriteLine(Convert.ToString("?????PowerKeyword3?????"));
                sw.WriteLine(Convert.ToString(powerKeywordBox3.Text));
                sw.WriteLine(Convert.ToString("?????PowerKeyword4?????"));
                sw.WriteLine(Convert.ToString(powerKeywordBox4.Text));
                sw.WriteLine(Convert.ToString("?????PowerKeyword5?????"));
                sw.WriteLine(Convert.ToString(powerKeywordBox5.Text));
                sw.WriteLine(Convert.ToString("?????PowerKeyword6?????"));
                sw.WriteLine(Convert.ToString(powerKeywordBox6.Text));
                sw.WriteLine(Convert.ToString("?????PowerKeyword7?????"));
                sw.WriteLine(Convert.ToString(powerKeywordBox7.Text));
                sw.WriteLine(Convert.ToString("?????PowerKeyword8?????"));
                sw.WriteLine(Convert.ToString(powerKeywordBox8.Text));
                sw.WriteLine(Convert.ToString("?????PowerKeyword9?????"));
                sw.WriteLine(Convert.ToString(powerKeywordBox9.Text));
                sw.WriteLine(Convert.ToString("?????PowerKeyword10?????"));
                sw.WriteLine(Convert.ToString(powerKeywordBox10.Text));
                sw.WriteLine(Convert.ToString("?????PowerKeyword11?????"));
                sw.WriteLine(Convert.ToString(powerKeywordBox11.Text));
                sw.WriteLine(Convert.ToString("?????PowerKeyword12?????"));
                sw.WriteLine(Convert.ToString(powerKeywordBox12.Text));
                sw.WriteLine(Convert.ToString("?????PowerKeyword13?????"));
                sw.WriteLine(Convert.ToString(powerKeywordBox13.Text));
                sw.WriteLine(Convert.ToString("?????PowerKeyword14?????"));
                sw.WriteLine(Convert.ToString(powerKeywordBox14.Text));
                sw.WriteLine(Convert.ToString("?????PowerKeyword15?????"));
                sw.WriteLine(Convert.ToString(powerKeywordBox15.Text));
                sw.WriteLine(Convert.ToString("?????PowerKeyword16?????"));
                sw.WriteLine(Convert.ToString(powerKeywordBox16.Text));
                sw.WriteLine(Convert.ToString("?????PowerKeyword17?????"));
                sw.WriteLine(Convert.ToString(powerKeywordBox17.Text));
                sw.WriteLine(Convert.ToString("?????PowerKeyword18?????"));
                sw.WriteLine(Convert.ToString(powerKeywordBox18.Text));
                sw.WriteLine(Convert.ToString("?????PowerKeyword19?????"));
                sw.WriteLine(Convert.ToString(powerKeywordBox19.Text));
                sw.WriteLine(Convert.ToString("?????PowerKeyword20?????"));
                sw.WriteLine(Convert.ToString(powerKeywordBox20.Text));
                sw.WriteLine(Convert.ToString("?????PowerKeyword21?????"));
                sw.WriteLine(Convert.ToString(powerKeywordBox21.Text));
                sw.WriteLine(Convert.ToString("?????PowerKeyword22?????"));
                sw.WriteLine(Convert.ToString(powerKeywordBox22.Text));
                sw.WriteLine(Convert.ToString("?????PowerKeyword23?????"));
                sw.WriteLine(Convert.ToString(powerKeywordBox23.Text));
                sw.WriteLine(Convert.ToString("?????PowerKeyword24?????"));
                sw.WriteLine(Convert.ToString(powerKeywordBox24.Text));
                sw.WriteLine(Convert.ToString("?????PowerPotency1?????"));
                sw.WriteLine(Convert.ToString(powerPotencyBox1.Text));
                sw.WriteLine(Convert.ToString("?????PowerPotency2?????"));
                sw.WriteLine(Convert.ToString(powerPotencyBox2.Text));
                sw.WriteLine(Convert.ToString("?????PowerPotency3?????"));
                sw.WriteLine(Convert.ToString(powerPotencyBox3.Text));
                sw.WriteLine(Convert.ToString("?????PowerPotency4?????"));
                sw.WriteLine(Convert.ToString(powerPotencyBox4.Text));
                sw.WriteLine(Convert.ToString("?????PowerPotency5?????"));
                sw.WriteLine(Convert.ToString(powerPotencyBox5.Text));
                sw.WriteLine(Convert.ToString("?????PowerPotency6?????"));
                sw.WriteLine(Convert.ToString(powerPotencyBox6.Text));
                sw.WriteLine(Convert.ToString("?????PowerPotency7?????"));
                sw.WriteLine(Convert.ToString(powerPotencyBox7.Text));
                sw.WriteLine(Convert.ToString("?????PowerPotency8?????"));
                sw.WriteLine(Convert.ToString(powerPotencyBox8.Text));
                sw.WriteLine(Convert.ToString("?????PowerPotency9?????"));
                sw.WriteLine(Convert.ToString(powerPotencyBox9.Text));
                sw.WriteLine(Convert.ToString("?????PowerPotency10?????"));
                sw.WriteLine(Convert.ToString(powerPotencyBox10.Text));
                sw.WriteLine(Convert.ToString("?????PowerPotency11?????"));
                sw.WriteLine(Convert.ToString(powerPotencyBox11.Text));
                sw.WriteLine(Convert.ToString("?????PowerPotency12?????"));
                sw.WriteLine(Convert.ToString(powerPotencyBox12.Text));
                sw.WriteLine(Convert.ToString("?????PowerPotency13?????"));
                sw.WriteLine(Convert.ToString(powerPotencyBox13.Text));
                sw.WriteLine(Convert.ToString("?????PowerPotency14?????"));
                sw.WriteLine(Convert.ToString(powerPotencyBox14.Text));
                sw.WriteLine(Convert.ToString("?????PowerPotency15?????"));
                sw.WriteLine(Convert.ToString(powerPotencyBox15.Text));
                sw.WriteLine(Convert.ToString("?????PowerPotency16?????"));
                sw.WriteLine(Convert.ToString(powerPotencyBox16.Text));
                sw.WriteLine(Convert.ToString("?????PowerPotency17?????"));
                sw.WriteLine(Convert.ToString(powerPotencyBox17.Text));
                sw.WriteLine(Convert.ToString("?????PowerPotency18?????"));
                sw.WriteLine(Convert.ToString(powerPotencyBox18.Text));
                sw.WriteLine(Convert.ToString("?????PowerPotency19?????"));
                sw.WriteLine(Convert.ToString(powerPotencyBox19.Text));
                sw.WriteLine(Convert.ToString("?????PowerPotency20?????"));
                sw.WriteLine(Convert.ToString(powerPotencyBox20.Text));
                sw.WriteLine(Convert.ToString("?????PowerPotency21?????"));
                sw.WriteLine(Convert.ToString(powerPotencyBox21.Text));
                sw.WriteLine(Convert.ToString("?????PowerPotency22?????"));
                sw.WriteLine(Convert.ToString(powerPotencyBox22.Text));
                sw.WriteLine(Convert.ToString("?????PowerPotency23?????"));
                sw.WriteLine(Convert.ToString(powerPotencyBox23.Text));
                sw.WriteLine(Convert.ToString("?????PowerPotency24?????"));
                sw.WriteLine(Convert.ToString(powerPotencyBox24.Text));
                // talents and special tabs
                sw.WriteLine("?????Talents?????");
                foreach (var item in talentBox.Items)
                {
                    sw.WriteLine(item.ToString());
                }

                //new augmetics stuff
                sw.WriteLine("?????Augmetics?????");
                foreach(var item in augmeticsBox.Items)
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


        //loading routine, this is absolutely disgusting and there has to be a better way to do it
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
                int counter = 0;

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
                skillAthleticsBonus.Value = Convert.ToInt32(sr.ReadLine());
                skillAwarenessBonus.Value = Convert.ToInt32(sr.ReadLine());
                skillBallisticBonus.Value = Convert.ToInt32(sr.ReadLine());
                skillCunningBonus.Value = Convert.ToInt32(sr.ReadLine());
                skillDeceptionBonus.Value = Convert.ToInt32(sr.ReadLine());
                skillInsightBonus.Value = Convert.ToInt32(sr.ReadLine());
                skillIntimidationBonus.Value = Convert.ToInt32(sr.ReadLine());
                skillInvestigationBonus.Value = Convert.ToInt32(sr.ReadLine());
                skillLeadershipBonus.Value = Convert.ToInt32(sr.ReadLine());
                skillMedicaeBonus.Value = Convert.ToInt32(sr.ReadLine());
                skillPersuasionBonus.Value = Convert.ToInt32(sr.ReadLine());
                skillPilotBonus.Value = Convert.ToInt32(sr.ReadLine());
                skillPsychicBonus.Value = Convert.ToInt32(sr.ReadLine());
                skillScholarBonus.Value = Convert.ToInt32(sr.ReadLine());
                skillStealthBonus.Value = Convert.ToInt32(sr.ReadLine());
                skillSurvivalBonus.Value = Convert.ToInt32(sr.ReadLine());
                skillTechBonus.Value = Convert.ToInt32(sr.ReadLine());
                skillWeaponSkillBonus.Value = Convert.ToInt32(sr.ReadLine());

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



                // new work right now

                rankValueBox.Value = Convert.ToInt32(sr.ReadLine());
                wealthValueBox.Value = Convert.ToInt32(sr.ReadLine());
                corruptionValueBox.Value = Convert.ToInt32(sr.ReadLine());
                defenceValueBox.Value = Convert.ToInt32(sr.ReadLine());


                //newest addition
                soakValueBox.Value = Convert.ToInt32(sr.ReadLine());
                woundsValueBox.Value = Convert.ToInt32(sr.ReadLine());
                resilienceValueBox.Value = Convert.ToInt32(sr.ReadLine());
                convictionValueBox.Value = Convert.ToInt32(sr.ReadLine());
                passiveAwarenessValueBox.Value = Convert.ToInt32(sr.ReadLine());
                resolveValueBox.Value = Convert.ToInt32(sr.ReadLine());
                influenceValueBox.Value = Convert.ToInt32(sr.ReadLine());
                shockValueBox.Value = Convert.ToInt32(sr.ReadLine());
                //newest addition


                attStrengthModifier.Value = Convert.ToInt32(sr.ReadLine());
                attAgilityModifier.Value = Convert.ToInt32(sr.ReadLine());
                attToughnessModifier.Value = Convert.ToInt32(sr.ReadLine());
                attIntellectModifier.Value = Convert.ToInt32(sr.ReadLine());
                attWillpowerModifier.Value = Convert.ToInt32(sr.ReadLine());
                attFellowshipModifier.Value = Convert.ToInt32(sr.ReadLine());
                attInitiativeModifier.Value = Convert.ToInt32(sr.ReadLine());
                attSpeedModifier.Value = Convert.ToInt32(sr.ReadLine());

                line = sr.ReadLine();
                counter = 0;
                while (line != "?????RangedWeaponNameEnd?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????RangedWeaponNameEnd?????")
                    {
                        if (counter != 0)
                        {
                            rangedWeaponNameBox.Text += Environment.NewLine;
                        }
                        rangedWeaponNameBox.Text += (line);
                        
                    }
                    counter += 1;
                }

                rangedWeaponDamageBox.Text = sr.ReadLine();
                rangedWeaponEDBox.Text = sr.ReadLine();
                rangedWeaponAPBox.Text = sr.ReadLine();
                rangedWeaponRangeBox.Text = sr.ReadLine();
                rangedWeaponSalvoBox.Text = sr.ReadLine();


                line = sr.ReadLine();
                counter = 0;
                while (line != "?????RangedWeaponTraitsEnd?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????RangedWeaponTraitsEnd?????")
                    {
                        if (counter != 0)
                        {
                            rangedWeaponTraitBox.Text += Environment.NewLine;
                        }
                        rangedWeaponTraitBox.Text += (line);
                        
                    }
                    counter += 1;
                }

                rangedWeaponValueBox.Text = sr.ReadLine();

                line = sr.ReadLine();
                counter = 0;
                while (line != "?????RangedWeaponKeywordsEnd?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????RangedWeaponKeywordsEnd?????")
                    {
                        if (counter != 0)
                        {
                            rangedWeaponKeywordsBox.Text += Environment.NewLine;
                        }
                        rangedWeaponKeywordsBox.Text += (line);
                        
                    }
                    counter += 1;
                }



                line = sr.ReadLine();
                counter = 0;
                while (line != "?????MeleeWeaponNameEnd?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????MeleeWeaponNameEnd?????")
                    {
                        if (counter != 0)
                        {
                            meleeWeaponNameBox.Text += Environment.NewLine;
                        }
                        meleeWeaponNameBox.Text += (line);
                        
                    }
                    counter += 1;
                }

                meleeWeaponDamageBox.Text = sr.ReadLine();
                meleeWeaponEDBox.Text = sr.ReadLine();
                meleeWeaponAPBox.Text = sr.ReadLine();


                line = sr.ReadLine();
                counter = 0;
                while (line != "?????MeleeWeaponRangeEnd?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????MeleeWeaponRangeEnd?????")
                    {
                        if (counter != 0)
                        {
                            MeleeWeaponRangeBox.Text += Environment.NewLine;
                        }
                        MeleeWeaponRangeBox.Text += (line);
                        
                    }
                    counter += 1;
                }


                line = sr.ReadLine();
                counter = 0;
                while (line != "?????MeleeWeaponTraitsEnd?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????MeleeWeaponTraitsEnd?????")
                    {
                        if (counter != 0)
                        {
                            meleeWeaponTraitsBox.Text += Environment.NewLine;
                        }
                        meleeWeaponTraitsBox.Text += (line);
                        
                    }
                    counter += 1;
                }

                meleeWeaponValueBox.Text = sr.ReadLine();


                line = sr.ReadLine();
                counter = 0;
                while (line != "?????MeleeWeaponKeywordsEnd?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????MeleeWeaponKeywordsEnd?????")
                    {
                        if (counter != 0)
                        {
                            meleeWeaponKeywordsBox.Text += Environment.NewLine;
                        }
                        meleeWeaponKeywordsBox.Text += (line);
                        
                    }
                    counter += 1;
                }


                line = sr.ReadLine();
                counter = 0;
                while (line != "?????ArmorNameEnd?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????ArmorNameEnd?????")
                    {
                        if (counter != 0)
                        {
                            armorNameBox.Text += Environment.NewLine;
                        }
                        armorNameBox.Text += (line);
                        
                    }
                    counter += 1;
                }

                armorRatingBox.Value = Convert.ToInt32(sr.ReadLine());

                line = sr.ReadLine();
                counter = 0;
                while (line != "?????ArmorTraitsEnd?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????ArmorTraitsEnd?????")
                    {
                        if (counter != 0)
                        {
                            armorTraitsBox.Text += Environment.NewLine;
                        }
                        armorTraitsBox.Text += (line);                        
                    }
                    counter += 1;
                }


                armorValueBox.Text = sr.ReadLine();

                line = sr.ReadLine();
                counter = 0;
                while (line != "?????ArmorKeywordsEnd?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????ArmorKeywordsEnd?????")
                    {
                        if (counter != 0)
                        {
                            armorKeywordsBox.Text += Environment.NewLine;
                        }
                        armorKeywordsBox.Text += (line);
                    }
                    counter += 1;
                }


                line = sr.ReadLine();
                counter = 0;
                while (line != "?????Power2?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Power2?????")
                    {
                        if (counter != 0)
                        {
                            powerNameBox1.Text += Environment.NewLine;
                        }
                        powerNameBox1.Text += (line);
                    }
                    counter += 1;
                }

                counter = 0;
                while (line != "?????Power3?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Power3?????")
                    {
                        if (counter != 0)
                        {
                            powerNameBox2.Text += Environment.NewLine;
                        }
                        powerNameBox2.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????Power4?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Power4?????")
                    {
                        if (counter != 0)
                        {
                            powerNameBox3.Text += Environment.NewLine;
                        }
                        powerNameBox3.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????Power5?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Power5?????")
                    {
                        if (counter != 0)
                        {
                            powerNameBox4.Text += Environment.NewLine;
                        }
                        powerNameBox4.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????Power6?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Power6?????")
                    {
                        if (counter != 0)
                        {
                            powerNameBox5.Text += Environment.NewLine;
                        }
                        powerNameBox5.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????Power7?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Power7?????")
                    {
                        if (counter != 0)
                        {
                            powerNameBox6.Text += Environment.NewLine;
                        }
                        powerNameBox6.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????Power8?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Power8?????")
                    {
                        if (counter != 0)
                        {
                            powerNameBox7.Text += Environment.NewLine;
                        }
                        powerNameBox7.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????Power9?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Power9?????")
                    {
                        if (counter != 0)
                        {
                            powerNameBox8.Text += Environment.NewLine;
                        }
                        powerNameBox8.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????Power10?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Power10?????")
                    {
                        if (counter != 0)
                        {
                            powerNameBox9.Text += Environment.NewLine;
                        }
                        powerNameBox9.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????Power11?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Power11?????")
                    {
                        if (counter != 0)
                        {
                            powerNameBox10.Text += Environment.NewLine;
                        }
                        powerNameBox10.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????Power12?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Power12?????")
                    {
                        if (counter != 0)
                        {
                            powerNameBox11.Text += Environment.NewLine;
                        }
                        powerNameBox11.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????Power13?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Power13?????")
                    {
                        if (counter != 0)
                        {
                            powerNameBox12.Text += Environment.NewLine;
                        }
                        powerNameBox12.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????Power14?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Power14?????")
                    {
                        if (counter != 0)
                        {
                            powerNameBox13.Text += Environment.NewLine;
                        }
                        powerNameBox13.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????Power15?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Power15?????")
                    {
                        if (counter != 0)
                        {
                            powerNameBox14.Text += Environment.NewLine;
                        }
                        powerNameBox14.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????Power16?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Power16?????")
                    {
                        if (counter != 0)
                        {
                            powerNameBox15.Text += Environment.NewLine;
                        }
                        powerNameBox15.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????Power17?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Power17?????")
                    {
                        if (counter != 0)
                        {
                            powerNameBox16.Text += Environment.NewLine;
                        }
                        powerNameBox16.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????Power18?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Power18?????")
                    {
                        if (counter != 0)
                        {
                            powerNameBox17.Text += Environment.NewLine;
                        }
                        powerNameBox17.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????Power19?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Power19?????")
                    {
                        if (counter != 0)
                        {
                            powerNameBox18.Text += Environment.NewLine;
                        }
                        powerNameBox18.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????Power20?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Power20?????")
                    {
                        if (counter != 0)
                        {
                            powerNameBox19.Text += Environment.NewLine;
                        }
                        powerNameBox19.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????Power21?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Power21?????")
                    {
                        if (counter != 0)
                        {
                            powerNameBox20.Text += Environment.NewLine;
                        }
                        powerNameBox20.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????Power22?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Power22?????")
                    {
                        if (counter != 0)
                        {
                            powerNameBox21.Text += Environment.NewLine;
                        }
                        powerNameBox21.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????Power23?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Power23?????")
                    {
                        if (counter != 0)
                        {
                            powerNameBox22.Text += Environment.NewLine;
                        }
                        powerNameBox22.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????Power24?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Power24?????")
                    {
                        if (counter != 0)
                        {
                            powerNameBox23.Text += Environment.NewLine;
                        }
                        powerNameBox23.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerDamage1?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerDamage1?????")
                    {
                        if (counter != 0)
                        {
                            powerNameBox24.Text += Environment.NewLine;
                        }
                        powerNameBox24.Text += (line);
                    }
                    counter += 1;
                }

                counter = 0;
                while (line != "?????PowerDamage2?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerDamage2?????")
                    {
                        if (counter != 0)
                        {
                            powerDamageBox1.Text += Environment.NewLine;
                        }
                        powerDamageBox1.Text += (line);
                    }
                    counter += 1;
                }

                counter = 0;
                while (line != "?????PowerDamage3?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerDamage3?????")
                    {
                        if (counter != 0)
                        {
                            powerDamageBox2.Text += Environment.NewLine;
                        }
                        powerDamageBox2.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerDamage4?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerDamage4?????")
                    {
                        if (counter != 0)
                        {
                            powerDamageBox3.Text += Environment.NewLine;
                        }
                        powerDamageBox3.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerDamage5?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerDamage5?????")
                    {
                        if (counter != 0)
                        {
                            powerDamageBox4.Text += Environment.NewLine;
                        }
                        powerDamageBox4.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerDamage6?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerDamage6?????")
                    {
                        if (counter != 0)
                        {
                            powerDamageBox5.Text += Environment.NewLine;
                        }
                        powerDamageBox5.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerDamage7?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerDamage7?????")
                    {
                        if (counter != 0)
                        {
                            powerDamageBox6.Text += Environment.NewLine;
                        }
                        powerDamageBox6.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerDamage8?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerDamage8?????")
                    {
                        if (counter != 0)
                        {
                            powerDamageBox7.Text += Environment.NewLine;
                        }
                        powerDamageBox7.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerDamage9?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerDamage9?????")
                    {
                        if (counter != 0)
                        {
                            powerDamageBox8.Text += Environment.NewLine;
                        }
                        powerDamageBox8.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerDamage10?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerDamage10?????")
                    {
                        if (counter != 0)
                        {
                            powerDamageBox9.Text += Environment.NewLine;
                        }
                        powerDamageBox9.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerDamage11?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerDamage11?????")
                    {
                        if (counter != 0)
                        {
                            powerDamageBox10.Text += Environment.NewLine;
                        }
                        powerDamageBox10.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerDamage12?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerDamage12?????")
                    {
                        if (counter != 0)
                        {
                            powerDamageBox11.Text += Environment.NewLine;
                        }
                        powerDamageBox11.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerDamage13?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerDamage13?????")
                    {
                        if (counter != 0)
                        {
                            powerDamageBox12.Text += Environment.NewLine;
                        }
                        powerDamageBox12.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerDamage14?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerDamage14?????")
                    {
                        if (counter != 0)
                        {
                            powerDamageBox13.Text += Environment.NewLine;
                        }
                        powerDamageBox13.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerDamage15?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerDamage15?????")
                    {
                        if (counter != 0)
                        {
                            powerDamageBox14.Text += Environment.NewLine;
                        }
                        powerDamageBox14.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerDamage16?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerDamage16?????")
                    {
                        if (counter != 0)
                        {
                            powerDamageBox15.Text += Environment.NewLine;
                        }
                        powerDamageBox15.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerDamage17?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerDamage17?????")
                    {
                        if (counter != 0)
                        {
                            powerDamageBox16.Text += Environment.NewLine;
                        }
                        powerDamageBox16.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerDamage18?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerDamage18?????")
                    {
                        if (counter != 0)
                        {
                            powerDamageBox17.Text += Environment.NewLine;
                        }
                        powerDamageBox17.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerDamage19?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerDamage19?????")
                    {
                        if (counter != 0)
                        {
                            powerDamageBox18.Text += Environment.NewLine;
                        }
                        powerDamageBox18.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerDamage20?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerDamage20?????")
                    {
                        if (counter != 0)
                        {
                            powerDamageBox19.Text += Environment.NewLine;
                        }
                        powerDamageBox19.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerDamage21?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerDamage21?????")
                    {
                        if (counter != 0)
                        {
                            powerDamageBox20.Text += Environment.NewLine;
                        }
                        powerDamageBox20.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerDamage22?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerDamage22?????")
                    {
                        if (counter != 0)
                        {
                            powerDamageBox21.Text += Environment.NewLine;
                        }
                        powerDamageBox21.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerDamage23?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerDamage23?????")
                    {
                        if (counter != 0)
                        {
                            powerDamageBox22.Text += Environment.NewLine;
                        }
                        powerDamageBox22.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerDamage24?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerDamage24?????")
                    {
                        if (counter != 0)
                        {
                            powerDamageBox23.Text += Environment.NewLine;
                        }
                        powerDamageBox23.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerED1?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerED1?????")
                    {
                        if (counter != 0)
                        {
                            powerDamageBox24.Text += Environment.NewLine;
                        }
                        powerDamageBox24.Text += (line);
                    }
                    counter += 1;
                }

                counter = 0;
                while (line != "?????PowerED2?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerED2?????")
                    {
                        if (counter != 0)
                        {
                            powerEDBox1.Text += Environment.NewLine;
                        }
                        powerEDBox1.Text += (line);
                    }
                    counter += 1;
                }

                counter = 0;
                while (line != "?????PowerED3?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerED3?????")
                    {
                        if (counter != 0)
                        {
                            powerEDBox2.Text += Environment.NewLine;
                        }
                        powerEDBox2.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerED4?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerED4?????")
                    {
                        if (counter != 0)
                        {
                            powerEDBox3.Text += Environment.NewLine;
                        }
                        powerEDBox3.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerED5?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerED5?????")
                    {
                        if (counter != 0)
                        {
                            powerEDBox4.Text += Environment.NewLine;
                        }
                        powerEDBox4.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerED6?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerED6?????")
                    {
                        if (counter != 0)
                        {
                            powerEDBox5.Text += Environment.NewLine;
                        }
                        powerEDBox5.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerED7?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerED7?????")
                    {
                        if (counter != 0)
                        {
                            powerEDBox6.Text += Environment.NewLine;
                        }
                        powerEDBox6.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerED8?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerED8?????")
                    {
                        if (counter != 0)
                        {
                            powerEDBox7.Text += Environment.NewLine;
                        }
                        powerEDBox7.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerED9?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerED9?????")
                    {
                        if (counter != 0)
                        {
                            powerEDBox8.Text += Environment.NewLine;
                        }
                        powerEDBox8.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerED10?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerED10?????")
                    {
                        if (counter != 0)
                        {
                            powerEDBox9.Text += Environment.NewLine;
                        }
                        powerEDBox9.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerED11?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerED11?????")
                    {
                        if (counter != 0)
                        {
                            powerEDBox10.Text += Environment.NewLine;
                        }
                        powerEDBox10.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerED12?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerED12?????")
                    {
                        if (counter != 0)
                        {
                            powerEDBox11.Text += Environment.NewLine;
                        }
                        powerEDBox11.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerED13?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerED13?????")
                    {
                        if (counter != 0)
                        {
                            powerEDBox12.Text += Environment.NewLine;
                        }
                        powerEDBox12.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerED14?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerED14?????")
                    {
                        if (counter != 0)
                        {
                            powerEDBox13.Text += Environment.NewLine;
                        }
                        powerEDBox13.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerED15?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerED15?????")
                    {
                        if (counter != 0)
                        {
                            powerEDBox14.Text += Environment.NewLine;
                        }
                        powerEDBox14.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerED16?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerED16?????")
                    {
                        if (counter != 0)
                        {
                            powerEDBox15.Text += Environment.NewLine;
                        }
                        powerEDBox15.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerED17?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerED17?????")
                    {
                        if (counter != 0)
                        {
                            powerEDBox16.Text += Environment.NewLine;
                        }
                        powerEDBox16.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerED18?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerED18?????")
                    {
                        if (counter != 0)
                        {
                            powerEDBox17.Text += Environment.NewLine;
                        }
                        powerEDBox17.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerED19?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerED19?????")
                    {
                        if (counter != 0)
                        {
                            powerEDBox18.Text += Environment.NewLine;
                        }
                        powerEDBox18.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerED20?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerED20?????")
                    {
                        if (counter != 0)
                        {
                            powerEDBox19.Text += Environment.NewLine;
                        }
                        powerEDBox19.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerED21?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerED21?????")
                    {
                        if (counter != 0)
                        {
                            powerEDBox20.Text += Environment.NewLine;
                        }
                        powerEDBox20.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerED22?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerED22?????")
                    {
                        if (counter != 0)
                        {
                            powerEDBox21.Text += Environment.NewLine;
                        }
                        powerEDBox21.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerED23?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerED23?????")
                    {
                        if (counter != 0)
                        {
                            powerEDBox22.Text += Environment.NewLine;
                        }
                        powerEDBox22.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerED24?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerED24?????")
                    {
                        if (counter != 0)
                        {
                            powerEDBox23.Text += Environment.NewLine;
                        }
                        powerEDBox23.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerActivation1?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerActivation1?????")
                    {
                        if (counter != 0)
                        {
                            powerEDBox24.Text += Environment.NewLine;
                        }
                        powerEDBox24.Text += (line);
                    }
                    counter += 1;
                }

                counter = 0;
                while (line != "?????PowerActivation2?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerActivation2?????")
                    {
                        if (counter != 0)
                        {
                            powerActivationBox1.Text += Environment.NewLine;
                        }
                        powerActivationBox1.Text += (line);
                    }
                    counter += 1;
                }

                counter = 0;
                while (line != "?????PowerActivation3?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerActivation3?????")
                    {
                        if (counter != 0)
                        {
                            powerActivationBox2.Text += Environment.NewLine;
                        }
                        powerActivationBox2.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerActivation4?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerActivation4?????")
                    {
                        if (counter != 0)
                        {
                            powerActivationBox3.Text += Environment.NewLine;
                        }
                        powerActivationBox3.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerActivation5?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerActivation5?????")
                    {
                        if (counter != 0)
                        {
                            powerActivationBox4.Text += Environment.NewLine;
                        }
                        powerActivationBox4.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerActivation6?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerActivation6?????")
                    {
                        if (counter != 0)
                        {
                            powerActivationBox5.Text += Environment.NewLine;
                        }
                        powerActivationBox5.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerActivation7?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerActivation7?????")
                    {
                        if (counter != 0)
                        {
                            powerActivationBox6.Text += Environment.NewLine;
                        }
                        powerActivationBox6.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerActivation8?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerActivation8?????")
                    {
                        if (counter != 0)
                        {
                            powerActivationBox7.Text += Environment.NewLine;
                        }
                        powerActivationBox7.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerActivation9?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerActivation9?????")
                    {
                        if (counter != 0)
                        {
                            powerActivationBox8.Text += Environment.NewLine;
                        }
                        powerActivationBox8.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerActivation10?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerActivation10?????")
                    {
                        if (counter != 0)
                        {
                            powerActivationBox9.Text += Environment.NewLine;
                        }
                        powerActivationBox9.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerActivation11?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerActivation11?????")
                    {
                        if (counter != 0)
                        {
                            powerActivationBox10.Text += Environment.NewLine;
                        }
                        powerActivationBox10.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerActivation12?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerActivation12?????")
                    {
                        if (counter != 0)
                        {
                            powerActivationBox11.Text += Environment.NewLine;
                        }
                        powerActivationBox11.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerActivation13?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerActivation13?????")
                    {
                        if (counter != 0)
                        {
                            powerActivationBox12.Text += Environment.NewLine;
                        }
                        powerActivationBox12.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerActivation14?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerActivation14?????")
                    {
                        if (counter != 0)
                        {
                            powerActivationBox13.Text += Environment.NewLine;
                        }
                        powerActivationBox13.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerActivation15?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerActivation15?????")
                    {
                        if (counter != 0)
                        {
                            powerActivationBox14.Text += Environment.NewLine;
                        }
                        powerActivationBox14.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerActivation16?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerActivation16?????")
                    {
                        if (counter != 0)
                        {
                            powerActivationBox15.Text += Environment.NewLine;
                        }
                        powerActivationBox15.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerActivation17?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerActivation17?????")
                    {
                        if (counter != 0)
                        {
                            powerActivationBox16.Text += Environment.NewLine;
                        }
                        powerActivationBox16.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerActivation18?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerActivation18?????")
                    {
                        if (counter != 0)
                        {
                            powerActivationBox17.Text += Environment.NewLine;
                        }
                        powerActivationBox17.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerActivation19?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerActivation19?????")
                    {
                        if (counter != 0)
                        {
                            powerActivationBox18.Text += Environment.NewLine;
                        }
                        powerActivationBox18.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerActivation20?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerActivation20?????")
                    {
                        if (counter != 0)
                        {
                            powerActivationBox19.Text += Environment.NewLine;
                        }
                        powerActivationBox19.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerActivation21?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerActivation21?????")
                    {
                        if (counter != 0)
                        {
                            powerActivationBox20.Text += Environment.NewLine;
                        }
                        powerActivationBox20.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerActivation22?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerActivation22?????")
                    {
                        if (counter != 0)
                        {
                            powerActivationBox21.Text += Environment.NewLine;
                        }
                        powerActivationBox21.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerActivation23?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerActivation23?????")
                    {
                        if (counter != 0)
                        {
                            powerActivationBox22.Text += Environment.NewLine;
                        }
                        powerActivationBox22.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerActivation24?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerActivation24?????")
                    {
                        if (counter != 0)
                        {
                            powerActivationBox23.Text += Environment.NewLine;
                        }
                        powerActivationBox23.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerRange1?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerRange1?????")
                    {
                        if (counter != 0)
                        {
                            powerActivationBox24.Text += Environment.NewLine;
                        }
                        powerActivationBox24.Text += (line);
                    }
                    counter += 1;
                }

                counter = 0;
                while (line != "?????PowerRange2?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerRange2?????")
                    {
                        if (counter != 0)
                        {
                            powerRangeBox1.Text += Environment.NewLine;
                        }
                        powerRangeBox1.Text += (line);
                    }
                    counter += 1;
                }

                counter = 0;
                while (line != "?????PowerRange3?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerRange3?????")
                    {
                        if (counter != 0)
                        {
                            powerRangeBox2.Text += Environment.NewLine;
                        }
                        powerRangeBox2.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerRange4?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerRange4?????")
                    {
                        if (counter != 0)
                        {
                            powerRangeBox3.Text += Environment.NewLine;
                        }
                        powerRangeBox3.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerRange5?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerRange5?????")
                    {
                        if (counter != 0)
                        {
                            powerRangeBox4.Text += Environment.NewLine;
                        }
                        powerRangeBox4.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerRange6?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerRange6?????")
                    {
                        if (counter != 0)
                        {
                            powerRangeBox5.Text += Environment.NewLine;
                        }
                        powerRangeBox5.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerRange7?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerRange7?????")
                    {
                        if (counter != 0)
                        {
                            powerRangeBox6.Text += Environment.NewLine;
                        }
                        powerRangeBox6.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerRange8?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerRange8?????")
                    {
                        if (counter != 0)
                        {
                            powerRangeBox7.Text += Environment.NewLine;
                        }
                        powerRangeBox7.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerRange9?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerRange9?????")
                    {
                        if (counter != 0)
                        {
                            powerRangeBox8.Text += Environment.NewLine;
                        }
                        powerRangeBox8.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerRange10?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerRange10?????")
                    {
                        if (counter != 0)
                        {
                            powerRangeBox9.Text += Environment.NewLine;
                        }
                        powerRangeBox9.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerRange11?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerRange11?????")
                    {
                        if (counter != 0)
                        {
                            powerRangeBox10.Text += Environment.NewLine;
                        }
                        powerRangeBox10.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerRange12?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerRange12?????")
                    {
                        if (counter != 0)
                        {
                            powerRangeBox11.Text += Environment.NewLine;
                        }
                        powerRangeBox11.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerRange13?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerRange13?????")
                    {
                        if (counter != 0)
                        {
                            powerRangeBox12.Text += Environment.NewLine;
                        }
                        powerRangeBox12.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerRange14?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerRange14?????")
                    {
                        if (counter != 0)
                        {
                            powerRangeBox13.Text += Environment.NewLine;
                        }
                        powerRangeBox13.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerRange15?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerRange15?????")
                    {
                        if (counter != 0)
                        {
                            powerRangeBox14.Text += Environment.NewLine;
                        }
                        powerRangeBox14.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerRange16?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerRange16?????")
                    {
                        if (counter != 0)
                        {
                            powerRangeBox15.Text += Environment.NewLine;
                        }
                        powerRangeBox15.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerRange17?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerRange17?????")
                    {
                        if (counter != 0)
                        {
                            powerRangeBox16.Text += Environment.NewLine;
                        }
                        powerRangeBox16.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerRange18?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerRange18?????")
                    {
                        if (counter != 0)
                        {
                            powerRangeBox17.Text += Environment.NewLine;
                        }
                        powerRangeBox17.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerRange19?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerRange19?????")
                    {
                        if (counter != 0)
                        {
                            powerRangeBox18.Text += Environment.NewLine;
                        }
                        powerRangeBox18.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerRange20?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerRange20?????")
                    {
                        if (counter != 0)
                        {
                            powerRangeBox19.Text += Environment.NewLine;
                        }
                        powerRangeBox19.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerRange21?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerRange21?????")
                    {
                        if (counter != 0)
                        {
                            powerRangeBox20.Text += Environment.NewLine;
                        }
                        powerRangeBox20.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerRange22?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerRange22?????")
                    {
                        if (counter != 0)
                        {
                            powerRangeBox21.Text += Environment.NewLine;
                        }
                        powerRangeBox21.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerRange23?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerRange23?????")
                    {
                        if (counter != 0)
                        {
                            powerRangeBox22.Text += Environment.NewLine;
                        }
                        powerRangeBox22.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerRange24?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerRange24?????")
                    {
                        if (counter != 0)
                        {
                            powerRangeBox23.Text += Environment.NewLine;
                        }
                        powerRangeBox23.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerMulti1?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerMulti1?????")
                    {
                        if (counter != 0)
                        {
                            powerRangeBox24.Text += Environment.NewLine;
                        }
                        powerRangeBox24.Text += (line);
                    }
                    counter += 1;
                }


                powerMultiCheckBox1.Checked = Convert.ToBoolean(sr.ReadLine());
                powerMultiCheckBox2.Checked = Convert.ToBoolean(sr.ReadLine());
                powerMultiCheckBox3.Checked = Convert.ToBoolean(sr.ReadLine());
                powerMultiCheckBox4.Checked = Convert.ToBoolean(sr.ReadLine());
                powerMultiCheckBox5.Checked = Convert.ToBoolean(sr.ReadLine());
                powerMultiCheckBox6.Checked = Convert.ToBoolean(sr.ReadLine());
                powerMultiCheckBox7.Checked = Convert.ToBoolean(sr.ReadLine());
                powerMultiCheckBox8.Checked = Convert.ToBoolean(sr.ReadLine());
                powerMultiCheckBox9.Checked = Convert.ToBoolean(sr.ReadLine());
                powerMultiCheckBox10.Checked = Convert.ToBoolean(sr.ReadLine());
                powerMultiCheckBox11.Checked = Convert.ToBoolean(sr.ReadLine());
                powerMultiCheckBox12.Checked = Convert.ToBoolean(sr.ReadLine());
                powerMultiCheckBox13.Checked = Convert.ToBoolean(sr.ReadLine());
                powerMultiCheckBox14.Checked = Convert.ToBoolean(sr.ReadLine());
                powerMultiCheckBox15.Checked = Convert.ToBoolean(sr.ReadLine());
                powerMultiCheckBox16.Checked = Convert.ToBoolean(sr.ReadLine());
                powerMultiCheckBox17.Checked = Convert.ToBoolean(sr.ReadLine());
                powerMultiCheckBox18.Checked = Convert.ToBoolean(sr.ReadLine());
                powerMultiCheckBox19.Checked = Convert.ToBoolean(sr.ReadLine());
                powerMultiCheckBox20.Checked = Convert.ToBoolean(sr.ReadLine());
                powerMultiCheckBox21.Checked = Convert.ToBoolean(sr.ReadLine());
                powerMultiCheckBox22.Checked = Convert.ToBoolean(sr.ReadLine());
                powerMultiCheckBox23.Checked = Convert.ToBoolean(sr.ReadLine());
                powerMultiCheckBox24.Checked = Convert.ToBoolean(sr.ReadLine());







                line = sr.ReadLine();
                counter = 0;
                while (line != "?????PowerKeyword2?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerKeyword2?????")
                    {
                        if (counter != 0)
                        {
                            powerKeywordBox1.Text += Environment.NewLine;
                        }
                        powerKeywordBox1.Text += (line);
                    }
                    counter += 1;
                }

                counter = 0;
                while (line != "?????PowerKeyword3?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerKeyword3?????")
                    {
                        if (counter != 0)
                        {
                            powerKeywordBox2.Text += Environment.NewLine;
                        }
                        powerKeywordBox2.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerKeyword4?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerKeyword4?????")
                    {
                        if (counter != 0)
                        {
                            powerKeywordBox3.Text += Environment.NewLine;
                        }
                        powerKeywordBox3.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerKeyword5?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerKeyword5?????")
                    {
                        if (counter != 0)
                        {
                            powerKeywordBox4.Text += Environment.NewLine;
                        }
                        powerKeywordBox4.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerKeyword6?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerKeyword6?????")
                    {
                        if (counter != 0)
                        {
                            powerKeywordBox5.Text += Environment.NewLine;
                        }
                        powerKeywordBox5.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerKeyword7?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerKeyword7?????")
                    {
                        if (counter != 0)
                        {
                            powerKeywordBox6.Text += Environment.NewLine;
                        }
                        powerKeywordBox6.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerKeyword8?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerKeyword8?????")
                    {
                        if (counter != 0)
                        {
                            powerKeywordBox7.Text += Environment.NewLine;
                        }
                        powerKeywordBox7.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerKeyword9?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerKeyword9?????")
                    {
                        if (counter != 0)
                        {
                            powerKeywordBox8.Text += Environment.NewLine;
                        }
                        powerKeywordBox8.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerKeyword10?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerKeyword10?????")
                    {
                        if (counter != 0)
                        {
                            powerKeywordBox9.Text += Environment.NewLine;
                        }
                        powerKeywordBox9.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerKeyword11?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerKeyword11?????")
                    {
                        if (counter != 0)
                        {
                            powerKeywordBox10.Text += Environment.NewLine;
                        }
                        powerKeywordBox10.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerKeyword12?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerKeyword12?????")
                    {
                        if (counter != 0)
                        {
                            powerKeywordBox11.Text += Environment.NewLine;
                        }
                        powerKeywordBox11.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerKeyword13?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerKeyword13?????")
                    {
                        if (counter != 0)
                        {
                            powerKeywordBox12.Text += Environment.NewLine;
                        }
                        powerKeywordBox12.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerKeyword14?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerKeyword14?????")
                    {
                        if (counter != 0)
                        {
                            powerKeywordBox13.Text += Environment.NewLine;
                        }
                        powerKeywordBox13.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerKeyword15?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerKeyword15?????")
                    {
                        if (counter != 0)
                        {
                            powerKeywordBox14.Text += Environment.NewLine;
                        }
                        powerKeywordBox14.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerKeyword16?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerKeyword16?????")
                    {
                        if (counter != 0)
                        {
                            powerKeywordBox15.Text += Environment.NewLine;
                        }
                        powerKeywordBox15.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerKeyword17?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerKeyword17?????")
                    {
                        if (counter != 0)
                        {
                            powerKeywordBox16.Text += Environment.NewLine;
                        }
                        powerKeywordBox16.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerKeyword18?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerKeyword18?????")
                    {
                        if (counter != 0)
                        {
                            powerKeywordBox17.Text += Environment.NewLine;
                        }
                        powerKeywordBox17.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerKeyword19?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerKeyword19?????")
                    {
                        if (counter != 0)
                        {
                            powerKeywordBox18.Text += Environment.NewLine;
                        }
                        powerKeywordBox18.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerKeyword20?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerKeyword20?????")
                    {
                        if (counter != 0)
                        {
                            powerKeywordBox19.Text += Environment.NewLine;
                        }
                        powerKeywordBox19.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerKeyword21?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerKeyword21?????")
                    {
                        if (counter != 0)
                        {
                            powerKeywordBox20.Text += Environment.NewLine;
                        }
                        powerKeywordBox20.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerKeyword22?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerKeyword22?????")
                    {
                        if (counter != 0)
                        {
                            powerKeywordBox21.Text += Environment.NewLine;
                        }
                        powerKeywordBox21.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerKeyword23?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerKeyword23?????")
                    {
                        if (counter != 0)
                        {
                            powerKeywordBox22.Text += Environment.NewLine;
                        }
                        powerKeywordBox22.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerKeyword24?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerKeyword24?????")
                    {
                        if (counter != 0)
                        {
                            powerKeywordBox23.Text += Environment.NewLine;
                        }
                        powerKeywordBox23.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerPotency1?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerPotency1?????")
                    {
                        if (counter != 0)
                        {
                            powerKeywordBox24.Text += Environment.NewLine;
                        }
                        powerKeywordBox24.Text += (line);
                    }
                    counter += 1;
                }


                counter = 0;
                while (line != "?????PowerPotency2?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerPotency2?????")
                    {
                        if (counter != 0)
                        {
                            powerPotencyBox1.Text += Environment.NewLine;
                        }
                        powerPotencyBox1.Text += (line);
                    }
                    counter += 1;
                }

                counter = 0;
                while (line != "?????PowerPotency3?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerPotency3?????")
                    {
                        if (counter != 0)
                        {
                            powerPotencyBox2.Text += Environment.NewLine;
                        }
                        powerPotencyBox2.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerPotency4?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerPotency4?????")
                    {
                        if (counter != 0)
                        {
                            powerPotencyBox3.Text += Environment.NewLine;
                        }
                        powerPotencyBox3.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerPotency5?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerPotency5?????")
                    {
                        if (counter != 0)
                        {
                            powerPotencyBox4.Text += Environment.NewLine;
                        }
                        powerPotencyBox4.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerPotency6?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerPotency6?????")
                    {
                        if (counter != 0)
                        {
                            powerPotencyBox5.Text += Environment.NewLine;
                        }
                        powerPotencyBox5.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerPotency7?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerPotency7?????")
                    {
                        if (counter != 0)
                        {
                            powerPotencyBox6.Text += Environment.NewLine;
                        }
                        powerPotencyBox6.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerPotency8?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerPotency8?????")
                    {
                        if (counter != 0)
                        {
                            powerPotencyBox7.Text += Environment.NewLine;
                        }
                        powerPotencyBox7.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerPotency9?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerPotency9?????")
                    {
                        if (counter != 0)
                        {
                            powerPotencyBox8.Text += Environment.NewLine;
                        }
                        powerPotencyBox8.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerPotency10?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerPotency10?????")
                    {
                        if (counter != 0)
                        {
                            powerPotencyBox9.Text += Environment.NewLine;
                        }
                        powerPotencyBox9.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerPotency11?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerPotency11?????")
                    {
                        if (counter != 0)
                        {
                            powerPotencyBox10.Text += Environment.NewLine;
                        }
                        powerPotencyBox10.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerPotency12?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerPotency12?????")
                    {
                        if (counter != 0)
                        {
                            powerPotencyBox11.Text += Environment.NewLine;
                        }
                        powerPotencyBox11.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerPotency13?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerPotency13?????")
                    {
                        if (counter != 0)
                        {
                            powerPotencyBox12.Text += Environment.NewLine;
                        }
                        powerPotencyBox12.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerPotency14?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerPotency14?????")
                    {
                        if (counter != 0)
                        {
                            powerPotencyBox13.Text += Environment.NewLine;
                        }
                        powerPotencyBox13.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerPotency15?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerPotency15?????")
                    {
                        if (counter != 0)
                        {
                            powerPotencyBox14.Text += Environment.NewLine;
                        }
                        powerPotencyBox14.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerPotency16?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerPotency16?????")
                    {
                        if (counter != 0)
                        {
                            powerPotencyBox15.Text += Environment.NewLine;
                        }
                        powerPotencyBox15.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerPotency17?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerPotency17?????")
                    {
                        if (counter != 0)
                        {
                            powerPotencyBox16.Text += Environment.NewLine;
                        }
                        powerPotencyBox16.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerPotency18?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerPotency18?????")
                    {
                        if (counter != 0)
                        {
                            powerPotencyBox17.Text += Environment.NewLine;
                        }
                        powerPotencyBox17.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerPotency19?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerPotency19?????")
                    {
                        if (counter != 0)
                        {
                            powerPotencyBox18.Text += Environment.NewLine;
                        }
                        powerPotencyBox18.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerPotency20?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerPotency20?????")
                    {
                        if (counter != 0)
                        {
                            powerPotencyBox19.Text += Environment.NewLine;
                        }
                        powerPotencyBox19.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerPotency21?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerPotency21?????")
                    {
                        if (counter != 0)
                        {
                            powerPotencyBox20.Text += Environment.NewLine;
                        }
                        powerPotencyBox20.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerPotency22?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerPotency22?????")
                    {
                        if (counter != 0)
                        {
                            powerPotencyBox21.Text += Environment.NewLine;
                        }
                        powerPotencyBox21.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerPotency23?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerPotency23?????")
                    {
                        if (counter != 0)
                        {
                            powerPotencyBox22.Text += Environment.NewLine;
                        }
                        powerPotencyBox22.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????PowerPotency24?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????PowerPotency24?????")
                    {
                        if (counter != 0)
                        {
                            powerPotencyBox23.Text += Environment.NewLine;
                        }
                        powerPotencyBox23.Text += (line);
                    }
                    counter += 1;
                }
                counter = 0;
                while (line != "?????Talents?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Talents?????")
                    {
                        if (counter != 0)
                        {
                            powerPotencyBox24.Text += Environment.NewLine;
                        }
                        powerPotencyBox24.Text += (line);
                    }
                    counter += 1;
                }

                // special boxes
                talentBox.Items.Clear();
                while (line != "?????Augmetics?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Augmetics?????")
                    {
                        talentBox.Items.Add(line);
                    }
                }

                augmeticsBox.Items.Clear();
                while(line != "?????Equipment?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Equipment?????")
                    {
                        augmeticsBox.Items.Add(line);
                    }
                }
            
                equipmentTextBox.Text = "";
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



