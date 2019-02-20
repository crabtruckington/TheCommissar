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
        int bpSpentOnPowers = 0;
        int tierSelection = 1;
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
            buildPointsLabel.Text = "Build Points: " + Convert.ToString(totalBP - totalSpentBP - bpSpentOnRace - bpSpentOnArchetype - bpSpentOnAttributes - bpSpentOnSkills - bpSpentOnPowers);
            bpSpentAttribLabel.Text = "BP Spent on Attributes: " + Convert.ToString(bpSpentOnAttributes);
            bpSpentSkillsLabel.Text = "BP Spent on Skills: " + Convert.ToString(bpSpentOnSkills);
            bpSpentRaceLabel.Text = "BP Spent on Race: " + Convert.ToString(bpSpentOnRace);
            bpSpentArchetypeLabel.Text = "BP Spent on Archetype: " + Convert.ToString(bpSpentOnArchetype);
            bpSpentOnPowersLabel.Text = "BP Spent on Powers: " + Convert.ToString(bpSpentOnPowers);

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


        //Adding talents

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


        // adding augs

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
        //adding powers
        private void addPowerButton_Click(object sender, EventArgs e)
        {
            powerForm powers = new powerForm();
            DialogResult dr = powers.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                powers.Close();
            }
            else if (dr == DialogResult.OK)
            {
                string power = powers.returnPowerDetails();
                var results = powers.getPowerDetails(power);
                powerBox.Items.Add(results.Item1.Item1.ToString());
                bpSpentOnPowers += Convert.ToInt32(results.Item1.Item3);
                updateBuildPoints(0);
            }
        }

        private void removePowerButton_Click(object sender, EventArgs e)
        {
            powerForm powers = new powerForm();
            var results = powers.getPowerDetails(powerBox.SelectedItem.ToString());
            bpSpentOnPowers -= Convert.ToInt32(results.Item1.Item3);
            powerBox.Items.Remove(powerBox.SelectedItem);
            updateBuildPoints(0);
        }

        private void powerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            powerForm powers = new powerForm();
            var results = Tuple.Create(Tuple.Create("", "", "", "", ""), Tuple.Create("", "", "", ""));
            results = powers.getPowerDetails(Convert.ToString(powerBox.SelectedItem));
            powerDisciplineLabel.Text = results.Item1.Item2;
            powerBPCostLabel.Text = "BP Cost: " + Convert.ToString(results.Item1.Item3);
            powerDNLabel.Text = results.Item1.Item4;
            powerActivationLabel.Text = results.Item1.Item5;
            powerDurationLabel.Text = results.Item2.Item1;
            powerRangeLabel.Text = results.Item2.Item2;
            powerMultiLabel.Text = results.Item2.Item3;
            powerKeywordsLabel.Text = results.Item2.Item4;
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
                sw.WriteLine(Convert.ToString(bpSpentOnPowers));


                sw.WriteLine(Convert.ToString(rankValueBox.Value));
                sw.WriteLine(Convert.ToString(wealthValueBox.Value));
                sw.WriteLine(Convert.ToString(corruptionValueBox.Value));
                sw.WriteLine(Convert.ToString(defenceValueBox.Value));
                sw.WriteLine(Convert.ToString(soakValueBox.Value));
                sw.WriteLine(Convert.ToString(woundsValueBox.Value));
                sw.WriteLine(Convert.ToString(resilienceValueBox.Value));
                sw.WriteLine(Convert.ToString(convictionValueBox.Value));
                sw.WriteLine(Convert.ToString(passiveAwarenessValueBox.Value));
                sw.WriteLine(Convert.ToString(resolveValueBox.Value));
                sw.WriteLine(Convert.ToString(influenceValueBox.Value));
                sw.WriteLine(Convert.ToString(shockValueBox.Value));
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


                // talents and special tabs
                sw.WriteLine("?????Powers?????");
                foreach (var item in powerBox.Items)
                {
                    sw.WriteLine(item.ToString());
                }


                sw.WriteLine("?????Talents?????");
                foreach (var item in talentBox.Items)
                {
                    sw.WriteLine(item.ToString());
                }

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
                bpSpentOnPowers = Convert.ToInt32(sr.ReadLine());


                rankValueBox.Value = Convert.ToInt32(sr.ReadLine());
                wealthValueBox.Value = Convert.ToInt32(sr.ReadLine());
                corruptionValueBox.Value = Convert.ToInt32(sr.ReadLine());
                defenceValueBox.Value = Convert.ToInt32(sr.ReadLine());

                soakValueBox.Value = Convert.ToInt32(sr.ReadLine());
                woundsValueBox.Value = Convert.ToInt32(sr.ReadLine());
                resilienceValueBox.Value = Convert.ToInt32(sr.ReadLine());
                convictionValueBox.Value = Convert.ToInt32(sr.ReadLine());
                passiveAwarenessValueBox.Value = Convert.ToInt32(sr.ReadLine());
                resolveValueBox.Value = Convert.ToInt32(sr.ReadLine());
                influenceValueBox.Value = Convert.ToInt32(sr.ReadLine());
                shockValueBox.Value = Convert.ToInt32(sr.ReadLine());

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
                rangedWeaponNameBox.Text = "";
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
                rangedWeaponTraitBox.Text = "";
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
                rangedWeaponKeywordsBox.Text = "";
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
                meleeWeaponNameBox.Text = "";
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
                MeleeWeaponRangeBox.Text = "";
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
                meleeWeaponTraitsBox.Text = "";
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
                meleeWeaponKeywordsBox.Text = "";
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
                armorNameBox.Text = "";
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
                armorTraitsBox.Text = "";
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
                armorKeywordsBox.Text = "";
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

                // special boxes
                sr.ReadLine();
                powerBox.Items.Clear();
                while (line != "?????Talents?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Talents?????")
                    {
                        powerBox.Items.Add(line);
                    }
                }

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



