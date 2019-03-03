using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

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
        int armorFromEquip = 0;
        string objectives = "Objectives: ";
        string raceSelection = "";
        string archetypeSelection = "";
        string keywordsList = "";
        string raceBenefitsList = "";
        string archetypeBenefitsList = "";
        List<Tuple<string, int>> archetypeRequirementsList = new List<Tuple<string, int>>();
        List<customArchetype> customArchetypeList = new List<customArchetype>();


        public class customArchetype
        {
            public string name { get; set; }
            public int bpCost { get; set; }
            public string racialBonus { get; set; }
            public List<Dictionary<string, string>> archetypes { get; set; }
            public string tier { get; set; }
        }

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

            // set equipment details label
            equipDetailsLabel.Text = "";
            equipDetailsLabel.Text += "Damage:" + Environment.NewLine + Environment.NewLine +
                                      "AP:" + Environment.NewLine + Environment.NewLine +
                                      "Range:" + Environment.NewLine + Environment.NewLine +
                                      "Salvo:" + Environment.NewLine + Environment.NewLine +
                                      "Armor" + Environment.NewLine + Environment.NewLine +
                                      "Value:" + Environment.NewLine + Environment.NewLine +
                                      "Keywords:" + Environment.NewLine + Environment.NewLine +
                                      "Traits:";

            // grab custom archetypes
            string resourceName = Environment.CurrentDirectory + "\\HomebrewExtensions\\characterHomebrew.json";

            try
            {
                customArchetypeList = JsonConvert.DeserializeObject<List<customArchetype>>(File.ReadAllText(resourceName));

                foreach (customArchetype x in customArchetypeList)
                {
                    string name = x.name;
                }

            }
            catch (IOException)
            {
                string message = "Cant find the characterHomebrew.json file! Have you moved it? Do you have read access to the directory the program is running from?";
                string caption = "Error!";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, button, MessageBoxIcon.Error);
            }
            catch
            {
                string message = "There was an error loading characterHomebrew.json! Did you make a mistake in your syntax?";
                string caption = "Error!";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, button, MessageBoxIcon.Error);
            }

            augDetailsLabel.Text = "";
            powerDescriptionLabel.Text = "";
            talentDetailsLabel.Text = "";


            //List<equipmentObject> eBrew = JsonConvert.DeserializeObject<List<equipmentObject>>(File.ReadAllText(resourceName));
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
            resilienceTraitLabel.Text = "Resilience: " + Convert.ToString(Convert.ToInt32(attToughnessTotal.Text) + 1 + armorFromEquip + Convert.ToInt32(resilienceValueBox.Value));
            soakTraitLabel.Text = "Soak: " + Convert.ToString(Convert.ToInt32(attToughnessTotal.Text) + Convert.ToInt32(soakValueBox.Value));
            speedTraitLabel.Text = "Speed: " + attSpeedTotal.Text;
            convictionTraitLabel.Text = "Conviction: " + Convert.ToString(Convert.ToInt32(attWillpowerTotal.Text) + Convert.ToInt32(convictionValueBox.Value));
            passiveAwarenessTraitLabel.Text = "Passive Awareness: " + Convert.ToString((Convert.ToInt32(awarenessRatingLabel.Text) / 2) + Convert.ToInt32(passiveAwarenessValueBox.Value));
            if (raceSelection == "Necron, 20BP")
            {
                corruptionValueLabel.Text = "Insanity";
                corruptionTraitLabel.Text = "Insanity: " + Convert.ToString(corruptionValueBox.Value);
            }
            else
            {
                corruptionValueLabel.Text = "Corruption";
                corruptionTraitLabel.Text = "Corruption: " + Convert.ToString(corruptionValueBox.Value);
            }
            resolveTraitLabel.Text = "Resolve: " + Convert.ToString(Convert.ToInt32(attWillpowerTotal.Text) - 1 + Convert.ToInt32(resolveValueBox.Value));
            if (raceSelection == "Ork, 10BP")
            {
                influenceTraitLabel.Text = "Influence: " + Convert.ToString(Convert.ToInt32(attStrengthTotal.Text) - 1 + influenceValueBox.Value);
            }
            else
            { 
                influenceTraitLabel.Text = "Influence: " + Convert.ToString(Convert.ToInt32(attFellowshipTotal.Text) - 1 + influenceValueBox.Value);
            }
            rankTraitLabel.Text = "Rank: " + Convert.ToString(rankValueBox.Value);
            wealthTraitLabel.Text = "Wealth: " + Convert.ToString(wealthValueBox.Value + tierSelection);
            lifetimeBPEarnedLabel.Text = "Lifetime BP: " + Convert.ToString(totalBPGained - totalBPRemoved);
            objectiveLabel.Text = objectives;

            //set the keywords, benefits and bonuses section up
            archInfoLabel.Text = raceBenefitsList + archetypeBenefitsList;
            if (keywordsList == "")
            {
                
            }
            else
            {
                archInfoLabel.Text += "Keywords: " + keywordsList;
            }

            // update tooltips for summary tab
            calcValuesToolTip.SetToolTip(shockTotalLabel, "Willpower " + attWillpowerTotal.Text + " + Tier " + Convert.ToString(tierSelection) + " + Bonus " + Convert.ToString(shockValueBox.Value));
            calcValuesToolTip.SetToolTip(woundsTotalLabel, "Toughness " + attToughnessTotal.Text + " + Tier " + Convert.ToString(tierSelection) + " + Bonus " + Convert.ToString(woundsValueBox.Value));
            calcValuesToolTip.SetToolTip(defenceTraitLabel, "Initiative " + attInitiativeTotal.Text + " - 1 + Bonus " + Convert.ToString(defenceValueBox.Value));
            calcValuesToolTip.SetToolTip(resilienceTraitLabel, "Toughness " + attToughnessTotal.Text + " + 1 + Armor " + armorFromEquip + " + Bonus " + Convert.ToInt32(resilienceValueBox.Value));
            calcValuesToolTip.SetToolTip(soakTraitLabel, "Toughness " + attToughnessTotal.Text + " + Bonus " + Convert.ToString(soakValueBox.Value));
            calcValuesToolTip.SetToolTip(speedTraitLabel, "Speed " + attSpeedTotal.Text);
            calcValuesToolTip.SetToolTip(convictionTraitLabel, "Willpower " + attWillpowerTotal.Text + " + Bonus " + Convert.ToString(convictionValueBox.Value));
            calcValuesToolTip.SetToolTip(passiveAwarenessTraitLabel, "Awareness " + awarenessRatingLabel.Text + " / 2 + Bonus " + Convert.ToString(passiveAwarenessValueBox.Value));
            if (raceSelection == "Necron, 20BP")
            {
                calcValuesToolTip.SetToolTip(corruptionTraitLabel, "Insanity " + Convert.ToString(corruptionValueBox.Value));
            }
            else
            { 
                calcValuesToolTip.SetToolTip(corruptionTraitLabel, "Corruption " + Convert.ToString(corruptionValueBox.Value));
            }
            calcValuesToolTip.SetToolTip(resolveTraitLabel, "Willpower " + attWillpowerTotal.Text + " - 1 + Bonus " + Convert.ToString(resolveValueBox.Value));
            if (raceSelection == "Ork, 10BP")
            {
                calcValuesToolTip.SetToolTip(influenceTraitLabel, "Strenght " + attStrengthTotal.Text + " - 1 + Bonus " + Convert.ToString(influenceValueBox.Value));
            }
            else
            {
                calcValuesToolTip.SetToolTip(influenceTraitLabel, "Fellowship " + attFellowshipTotal.Text + " - 1 + Bonus " + Convert.ToString(influenceValueBox.Value));
            }
            calcValuesToolTip.SetToolTip(rankTraitLabel, "Rank " + Convert.ToString(rankValueBox.Value));
            calcValuesToolTip.SetToolTip(wealthTraitLabel, "Tier " + Convert.ToString(tierSelection) + " + Bonus " + Convert.ToString(wealthValueBox.Value));
            calcValuesToolTip.SetToolTip(lifetimeBPEarnedLabel, "BP Gained " + Convert.ToString(totalBPGained) + " - BP Removed " + Convert.ToString(totalBPRemoved));
        }


        // this section updates the BP spent for raising or lowering attributes
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

        // this section updates the BP spent for raising or lowering skills
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
               
      
        //traits BP change triggers
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

        //attributes modifier change BP triggers
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

        //BP trigger off skill changes
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


        //attributes update BP triggers
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

        // You cant change speed manually, its Race Derived
        private void attSpeed_ValueChanged(object sender, EventArgs e)
        {
            //int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            //int newValue = Convert.ToInt32(attSpeed.Value);
            //int change = newValue - prevValue;
            //changeAttributeValue("speed", change);
            //updateAttribBuildPoints(prevValue, newValue);
        }


        //skill value changes and BP triggers
        private void skillAthletics_ValueChanged(object sender, EventArgs e)
        {
            int prevValue = Convert.ToInt32(((UpDownBase)sender).Text);
            int newValue = Convert.ToInt32(skillAthletics.Value);
            int change = newValue - prevValue;
            //changeSkillValue("athletics");
            //updateSkillValues();
            updateSkillBuildPoints(prevValue, newValue);
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


        // these two sections calculate the total values update the labels based on base attribute or skill values plus bonuses
        public void updateSkillValues()
        {
            athleticsRatingLabel.Text = Convert.ToString(skillAthletics.Value + skillAthleticsBonus.Value + Convert.ToInt32(attStrengthTotal.Text));
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
                talentBox.Items.Add(results.Item1.ToString());
                updateBuildPoints(results.Item2);
            }
        }

        private void removeTalentBtn_Click(object sender, EventArgs e)
        {
            string findBPCost = talentBox.SelectedItem.ToString();
            talentForm talents = new talentForm();
            var results = talents.findTalentDetails(talentBox.SelectedItem.ToString());

            updateBuildPoints(results.Item2 * -1);

            talentBox.Items.Remove(talentBox.SelectedItem);
        }

        private void talentBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (talentBox.SelectedItem != null)
            {
                string talentName = talentBox.SelectedItem.ToString();
                talentForm talents = new talentForm();
                var results = talents.findTalentDetails(talentName);

                talentDetailsLabel.Text = "BP Cost: " + results.Item2.ToString() + Environment.NewLine + Environment.NewLine +
                                          "Details: " + results.Item3;
            }
            else
            {
                talentDetailsLabel.Text = "";
            }
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
                if (results == "Servo-Arm Mechadendrite")
                {
                    TreeNode rootNode = equipTreeBox.Nodes.Cast<TreeNode>().ToList().Find(n => n.Text.Equals("Melee Weapons"));
                    if (rootNode != null)
                    {
                        rootNode.Nodes.Add(results);
                        rootNode.Expand();
                    }
                }
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
            augDetailsLabel.Text = results.Item2 + Environment.NewLine + Environment.NewLine +
                                   results.Item3;
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
            powerDescriptionLabel.Text = results.Item1.Item2 + Environment.NewLine + Environment.NewLine +
                                         "BP Cost: " + results.Item1.Item3 + Environment.NewLine + Environment.NewLine +
                                         results.Item1.Item4 + Environment.NewLine + Environment.NewLine +
                                         results.Item1.Item5 + Environment.NewLine + Environment.NewLine +
                                         results.Item2.Item1 + Environment.NewLine + Environment.NewLine +
                                         results.Item2.Item2 + Environment.NewLine + Environment.NewLine +
                                         results.Item2.Item3 + Environment.NewLine + Environment.NewLine +
                                         results.Item2.Item4;
        }

        // adding weapon mods
        private void equipTreeBox_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                equipTreeBox.SelectedNode = e.Node;
                if (e.Node.Parent != null)
                {
                    if (e.Node.Parent.Text == "Ranged Weapons" || e.Node.Parent.Text == "Melee Weapons")
                    {
                        equipModMenu.Show(Cursor.Position);
                    }
                }
            }
        }


        private void addModToolStripMenuItem_Click(object sender, EventArgs e)
        {
            equipForm equip = new equipForm(1);
            var curItem = equipTreeBox.SelectedNode;

            DialogResult dr = equip.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                equip.Close();
            }
            else if (dr == DialogResult.OK)
            {
                string equipSelected = equip.returnEquipDetails();
                var results = equip.getEquipValues(equipSelected);

                curItem.Nodes.Add(results.Item1.Item1);
                curItem.Expand();
            }
        }


        // adding Equipment

        private void equipTreeBox_AfterSelect(object sender, TreeViewEventArgs e)
        {
            equipForm equip = new equipForm(0);
            var curItem = equipTreeBox.SelectedNode;
            

            if (curItem.Parent != null)
            {
                var result = equip.getEquipValues(curItem.Text);

                equipDetailsLabel.Text = "";
                equipDetailsLabel.Text += result.Item1.Item2 + Environment.NewLine + Environment.NewLine +
                                          result.Item1.Item3 + Environment.NewLine + Environment.NewLine +
                                          result.Item1.Item4 + Environment.NewLine + Environment.NewLine +
                                          result.Item1.Item5 + Environment.NewLine + Environment.NewLine +
                                          result.Item2.Item1 + Environment.NewLine + Environment.NewLine +
                                          result.Item2.Item2 + Environment.NewLine + Environment.NewLine +
                                          result.Item2.Item3 + Environment.NewLine + Environment.NewLine +
                                          result.Item2.Item4;
            }
            else
            {
                equipDetailsLabel.Text = "";
                equipDetailsLabel.Text += "Damage:" + Environment.NewLine + Environment.NewLine +
                                          "AP:" + Environment.NewLine + Environment.NewLine +
                                          "Range:" + Environment.NewLine + Environment.NewLine +
                                          "Salvo:" + Environment.NewLine + Environment.NewLine +
                                          "Armor" + Environment.NewLine + Environment.NewLine +
                                          "Value:" + Environment.NewLine + Environment.NewLine +
                                          "Keywords:" + Environment.NewLine + Environment.NewLine +
                                          "Traits:";
            }
        }

        private void addEquipButton_Click(object sender, EventArgs e)
        {
            equipForm equip = new equipForm(0);
            DialogResult dr = equip.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                equip.Close();
            }
            else if (dr == DialogResult.OK)
            {
                string equipSelected = equip.returnEquipDetails();
                var results = equip.getEquipValues(equipSelected);

                if (results.Item2.Item5 == "ranged")
                {
                    TreeNode rootNode = equipTreeBox.Nodes.Cast<TreeNode>().ToList().Find(n => n.Text.Equals("Ranged Weapons"));
                    if (rootNode != null)
                    {
                        rootNode.Nodes.Add(results.Item1.Item1);
                        rootNode.Expand();
                    }
                }
                else if (results.Item2.Item5 == "melee")
                {
                    TreeNode rootNode = equipTreeBox.Nodes.Cast<TreeNode>().ToList().Find(n => n.Text.Equals("Melee Weapons"));
                    if (rootNode != null)
                    {
                        rootNode.Nodes.Add(results.Item1.Item1);
                        rootNode.Expand();
                    }
                }
                else if (results.Item2.Item5 == "armor")
                {
                    TreeNode rootNode = equipTreeBox.Nodes.Cast<TreeNode>().ToList().Find(n => n.Text.Equals("Armor"));
                    if (rootNode != null)
                    {
                        rootNode.Nodes.Add(results.Item1.Item1);
                        rootNode.Expand();

                        //get the armor value and set it so we can do things with it later
                        string armorValueNumber = results.Item2.Item1.Substring(results.Item2.Item1.Length - 1);
                        int armorValue = 0;
                        try
                        {
                            armorValue = Convert.ToInt32((armorValueNumber));
                        }
                        catch
                        {
                            string message = "You have entered a non-numeric value for Armor!! Please check your homebrew file, only values from 0\u20119 are accepted!!";
                            string caption = "Error!";
                            MessageBoxButtons button = MessageBoxButtons.OK;
                            MessageBox.Show(message, caption, button, MessageBoxIcon.Error);
                        }
                        armorFromEquip += armorValue;
                    }
                }

                // new tools stuff
                else if (results.Item2.Item5 == "tools")
                {
                    TreeNode rootNode = equipTreeBox.Nodes.Cast<TreeNode>().ToList().Find(n => n.Text.Equals("Ammo and Tools"));
                    if (rootNode != null)
                    {
                        rootNode.Nodes.Add(results.Item1.Item1);
                        rootNode.Expand();                     
                    }
                }
                else
                {

                }
                updateBuildPoints(0);
            }

        }

        private void removeEquipButton_Click(object sender, EventArgs e)
        {
            equipForm equip = new equipForm(0);
            var curItem = equipTreeBox.SelectedNode;


            if (curItem.Parent != null)
            {
                if (curItem.Parent.Text == "Armor")
                {
                    var results = equip.getEquipValues(curItem.Text);
                    string armorValueNumber = results.Item2.Item1.Substring(results.Item2.Item1.Length - 1);
                    int armorValue = Convert.ToInt32((armorValueNumber));
                    armorFromEquip -= armorValue;
                }
                curItem.Remove();
                updateBuildPoints(0);
            }
        }




        public void updateSpeciesSelectList()
        {
            speciesSelect.Items.Clear();
            speciesSelect.SelectedItem = null;
            archetypeRequirementsList.Clear();
            raceBenefitsList = "";
            archetypeBenefitsList = "";
            raceSelection = "";
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

            foreach (customArchetype x in customArchetypeList)
            {
                if (Convert.ToInt32(x.tier) <= tierSelection)
                {
                    speciesSelect.Items.Add(x.name + ", " + Convert.ToString(x.bpCost) + "BP");
                }
            }
        }


        // this updates the species select dropdown, as well as adds bonuses to the bonus list
        public void updateArchetypeSelectList()
        {
            archetypeSelect.Items.Clear();
            archetypeSelect.SelectedItem = null;
            archetypeRequirementsList.Clear();
            raceBenefitsList = "";
            archetypeBenefitsList = "";
            keywordsList = "";
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
                    archetypeSelect.Items.Add("Imperial Commissar");
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


            // add in custom archetypes

            foreach (customArchetype x in customArchetypeList)
            {
                foreach (Dictionary<string, string> y in x.archetypes)
                {
                    if (Convert.ToInt32(y["tier"]) <= tierSelection)
                    {
                        archetypeSelect.Items.Add(y["archetype"]);
                    }
                }
            }



            if (raceSelection == "Eldar, 10BP")
            {
                raceBenefitsList = "Eldar: +1\u00A0Agility, +2DN\u00A0to all Interaction tests against " +
                                          "<Imperium> keyword. +1DN\u00A0to all Resolve tests. All Eldar " +
                                          "may purchase 1\u00A0Minor Psychic Power and gain the <Psyker> " +
                                          "keyword if they also purchase the Psychic Mastery Skill. " +
                                          "Eldar may purchase 1\u00A0more power per Tier level if they " +
                                          "choose to do this. " + Environment.NewLine + Environment.NewLine;
            }
            else if (raceSelection == "Ork, 10BP")
            {

                raceBenefitsList = "Ork: +1\u00A0Toughness. +2DN\u00A0to all Interaction tests " +
                                          "against <Imperium> keyword. +1\u00A0to all Intimidation " + 
                                          "tests. Orks calculate Influence using Strength rather " + 
                                          "than Fellowship. " + Environment.NewLine + Environment.NewLine;
            }
            else if (raceSelection == "Necron, 20BP")
            {
                raceBenefitsList = "Necron: +1\u00A0Shock, +1\u00A0Resilience. +2DN\u00A0to all " + 
                                          "Interaction tests against anyone without <Necron> " + 
                                          "keyword. Necrons are immune to warp Corruption, but " + 
                                          "use a replacement trait called Insanity. Any time you " +
                                          "face a terrifying threat (GM\u00A0Discretion), make an Insanity " + 
                                          "test using the same mechanics as Corruption." + Environment.NewLine + Environment.NewLine;                
            }
            else if (raceSelection == "Adeptus Astartes, 50BP")
            {
                raceBenefitsList = "Adeptus Astartes: +1\u00A0Strength, +1\u00A0Agility, +1\u00A0Toughness, " +
                                          "+1\u00A0Resolve. Space Marines add +1/2\u00A0Rank icons to attacks " + 
                                          "against Mobs. Space Marines do not bleed. You may add " +
                                          "+1\u00A0to any test using their implants, at GM\u00A0discretion. " + Environment.NewLine + Environment.NewLine;
            }
            else if (raceSelection == "Primaris Astartes, 100BP")
            {
                raceBenefitsList = "Primaris Astartes: +2\u00A0Strength, +1\u00A0Agility, " +
                                          "+1\u00A0Toughness, +1\u00A0Resolve, +4\u00A0Wounds. Space Marines add " +
                                          "+1/2\u00A0Rank icons to attacks against Mobs. Space Marines " +
                                          "do not bleed. You may add +1\u00A0to any test using their " +
                                          "implants, at GM\u00A0discretion. " + Environment.NewLine + Environment.NewLine;

                
            }
            else
            {
                raceBenefitsList = "";

                foreach (customArchetype x in customArchetypeList)
                {
                    if (raceSelection == x.name  + ", " + Convert.ToString(x.bpCost) + "BP")
                    {
                        raceBenefitsList = x.racialBonus + Environment.NewLine + Environment.NewLine;
                    }
                }
            }

        }

        private void tierSelect_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tierSelect.SelectedItem.ToString() == "1")
            {
                tierSelection = 1;
                totalBP = 100;
            }
            if (tierSelect.SelectedItem.ToString() == "2")
            {
                tierSelection = 2;
                totalBP = 200;
            }
            if (tierSelect.SelectedItem.ToString() == "3")
            {
                tierSelection = 3;
                totalBP = 300;
            }
            if (tierSelect.SelectedItem.ToString() == "4")
            {
                tierSelection = 4;
                totalBP = 400;
            }
            if (tierSelect.SelectedItem.ToString() == "5")
            {
                tierSelection = 5;
                totalBP = 500;
            }
            updateSpeciesSelectList();
            updateArchetypeSelectList();
            bpSpentOnRace = 0;
            bpSpentOnArchetype = 0;
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
            archetypeRequirementsList.Clear();
            string selectedArchetype = archetypeSelect.SelectedItem.ToString();

            bpSpentOnArchetype = 0;
            if (selectedArchetype == "Ministorum Priest" || selectedArchetype == "Sister Hospitaller" || 
                selectedArchetype == "Imperial Guardsman" || selectedArchetype == "Inquisitional Acolyte" ||
                selectedArchetype == "Inquisitorial Adept" || selectedArchetype == "Hive Ganger" ||
                selectedArchetype == "Cultist" || selectedArchetype == "Eldar Corsair" ||
                selectedArchetype == "Ork Boy" || selectedArchetype == "Necron Warrior")
            {
                bpSpentOnArchetype = 0;

            }
            if (selectedArchetype == "Scavvy")
            {
                bpSpentOnArchetype = 10;
            }
            if (selectedArchetype == "Death Cult Assassin" || selectedArchetype == "Space Marine Scout")
            {
                bpSpentOnArchetype = 20;
            }
            if (selectedArchetype == "Tempestus Scion" || selectedArchetype == "Eldar Ranger" ||
                selectedArchetype == "Ork Kommando" || selectedArchetype == "Desperado")
            {
                bpSpentOnArchetype = 30;
            }
            if (selectedArchetype == "Sister of Battle" || selectedArchetype == "Rogue Trader" ||
                selectedArchetype == "Skitarius" || selectedArchetype == "Crusader")
            {
                bpSpentOnArchetype = 40;
            }
            if (selectedArchetype == "Sanctioned Psyker" || selectedArchetype == "Rogue Psyker" ||
                selectedArchetype == "Imperial Commissar" || selectedArchetype == "Tactical Space Marine" ||
                selectedArchetype == "Necron Cryptek")
            {
                bpSpentOnArchetype = 50;
            }
            if (selectedArchetype == "Primaris Marine Intercessor" || selectedArchetype == "Tech-Priest" ||
                selectedArchetype == "Heretek" || selectedArchetype == "Ork Nob")
            {
                bpSpentOnArchetype = 60;
            }
            if (selectedArchetype == "Inquisitor")
            {
                bpSpentOnArchetype = 70;
            }
            if (selectedArchetype == "Eldar Warlock" || selectedArchetype == "Necron Nemesor")
            {
                bpSpentOnArchetype = 80;
            }


            // update Objectives and benefits/keywords
            if (selectedArchetype == "Ministorum Priest" || selectedArchetype == "Death Cult Assassin" || selectedArchetype == "Crusader")
            {
                objectives = "Objectives: " + Environment.NewLine + Environment.NewLine + "1: Extoll the virtues of worshipping the God-Emperor" + Environment.NewLine +
                                                                                            "     to an unbeliever." + Environment.NewLine + Environment.NewLine +
                                                                                            "2: Proclaim your enemy to be a heretic unworthy" + Environment.NewLine +
                                                                                            "     of the Emperor's Light." + Environment.NewLine + Environment.NewLine +
                                                                                            "3: Bear witness to an act that you consider a" + Environment.NewLine +
                                                                                            "     miracle of the divine emperor.";

                if (selectedArchetype == "Ministorum Priest")
                {
                    archetypeBenefitsList = "Ministorum Priest: +1 Influence. Once per combat, the " + 
                                              "Priest may take a free action to preach the Imperial " +
                                              "Creed. All allies with <Imperium> keyword heal 1d3\u00A0+\u00A0" + 
                                              "Rank Shock." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Imperium>, <Adeptus\u00A0Ministorum>";

                    archetypeRequirementsList.Add(Tuple.Create("attWillpowerTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("scholarRatingLabel", 3));
                }

                if (selectedArchetype == "Crusader")
                {
                    archetypeBenefitsList = "Crusader: +1 Influence, +1/2 Rank Resolve. +Rank bonus " + 
                                              "dice to attacks against <Heretic> or <Chaos> keyword " + 
                                              "enemies." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Imperium>, <Adeptus\u00A0Ministorum>";

                    archetypeRequirementsList.Add(Tuple.Create("attInitiativeTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("attWillpowerTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("weaponSkillRatingLabel", 3));
                    archetypeRequirementsList.Add(Tuple.Create("scholarRatingLabel", 3));
                }

                if (selectedArchetype == "Death Cult Assassin")
                {
                    archetypeBenefitsList = "Death Cult Assassin: Unless immobilized or restrained, " + 
                                              "may attempt to soak Mortal Wounds, and may substitute " + 
                                              "their Agility for their Soak when doing so." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Imperium>, <Adeptus\u00A0Ministorum>";

                    archetypeRequirementsList.Add(Tuple.Create("attAgilityTotal", 4));
                    archetypeRequirementsList.Add(Tuple.Create("ballisticRatingLabel", 2));
                    archetypeRequirementsList.Add(Tuple.Create("weaponSkillRatingLabel", 2));
                }



            }
            else if (selectedArchetype == "Sister Hospitaller" || selectedArchetype == "Sister of Battle")
            {
                objectives = "Objectives: " + Environment.NewLine + Environment.NewLine + "1: Describe how faith and/or sacrifice in the" + Environment.NewLine +
                                                                                            "     Emperor's name brings success." + Environment.NewLine + Environment.NewLine +
                                                                                            "2: Invoke an Imperial Saint (Saint Alicia Dominica" + Environment.NewLine +
                                                                                            "     are two examples) to bless your achievements." + Environment.NewLine + Environment.NewLine +
                                                                                            "3. Bear witness to an act that you consider" + Environment.NewLine +
                                                                                            "     a miracle of the divine Emperor.";


                if (selectedArchetype == "Sister of Battle")
                {
                    archetypeBenefitsList = "Sister of Battle: +1 Influence. Character and all Allies " +
                                              "within 15\u00A0meters may add +Rank to all corruption tests." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Imperium>, <Adeptus\u00A0Ministorum>, <Adepta\u00A0Sororitas>, " + 
                                            "<ORDER>";

                    archetypeRequirementsList.Add(Tuple.Create("attStrengthTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("attAgilityTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("attToughnessTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("attWillpowerTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("scholarRatingLabel", 1));
                    archetypeRequirementsList.Add(Tuple.Create("ballisticRatingLabel", 2));
                    archetypeRequirementsList.Add(Tuple.Create("weaponSkillRatingLabel", 2));
                }

                if (selectedArchetype == "Sister Hospitaller")
                {
                    archetypeBenefitsList = "Sister Hospitaller: Add +Rank on Medicae tests when " + 
                                              "treating characters with <Imperium> keyword." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Imperium>, <Adeptus\u00A0Ministorum>, <Adepta\u00A0Sororitas>, " + 
                                   "<ORDER>";

                    archetypeRequirementsList.Add(Tuple.Create("attIntellectTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("attWillpowerTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("medicaeRatingLabel", 1));
                    archetypeRequirementsList.Add(Tuple.Create("scholarRatingLabel", 1));
                }



            }
            else if (selectedArchetype == "Imperial Guardsman" || selectedArchetype == "Tempestus Scion" || selectedArchetype == "Imperial Commissar")
            {
                objectives = "Objectives: " + Environment.NewLine + Environment.NewLine + "1. Express confidence (or the opposite!) in" + Environment.NewLine +
                                                                                            "     the virtue of overwhelming numbers and firepower." + Environment.NewLine + Environment.NewLine +
                                                                                            "2. Explain how the Imperial Infrantryman's" + Environment.NewLine +
                                                                                            "     Uplifting Primer has a lesson appropriate" + Environment.NewLine +
                                                                                            "     to the current situation." + Environment.NewLine + Environment.NewLine +
                                                                                            "3. Reminisce about your far-flung home world and" + Environment.NewLine +
                                                                                            "     compare it to the current situation.";

                if (selectedArchetype == "Imperial Commissar")
                {
                    archetypeBenefitsList = "Imperial Commissar: +3 Influence. Commissar and all " +
                                              "Allies within 15\u00A0meters add +Rank to Resolve tests. " + 
                                              "Commissar adds +Rank to Intimidation tests." + Environment.NewLine + Environment.NewLine;

                    keywordsList          = "<Imperium>, <Astra Militarum>, <Officio\u00A0Prefectus>";

                    archetypeRequirementsList.Add(Tuple.Create("attStrengthTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("attToughnessTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("attWillpowerTotal", 4));
                    archetypeRequirementsList.Add(Tuple.Create("intimidationRatingLabel", 2));
                }

                if (selectedArchetype == "Imperial Guardsman")
                {
                    archetypeBenefitsList = "Imperial Guardsman: Once per battle, you may dive " + 
                                              "in front of an attack that would have hit an Ally. " + 
                                              "When doing so, add +Rank to your Resilience when " + 
                                              "determining the damage." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Imperium>, <Astra Militarum>, <REGIMENT>";

                    archetypeRequirementsList.Add(Tuple.Create("ballisticSkillLabel", 2));
                }

                if (selectedArchetype == "Tempestus Scion")
                {
                    archetypeBenefitsList = "Tempestus Scion: +1 Influence. When spending Glory to " + 
                                              "increase attack damage, if the weapon has <Imperium> " +
                                              "or <Astra\u00A0Militarum> tags, add +Rank to final damage." + Environment.NewLine + Environment.NewLine;

                    keywordsList         = "<Imperium>, <Astra Militarum>, <Militarum\u00A0Tempestus>";

                    archetypeRequirementsList.Add(Tuple.Create("attInitiativeTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("attStrengthTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("attToughnessTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("ballisticRatingLabel", 2));
                    archetypeRequirementsList.Add(Tuple.Create("stealthRatingLabel", 2));
                }



            }
            else if (selectedArchetype == "Space Marine Scout" || selectedArchetype == "Tactical Space Marine" || selectedArchetype == "Primaris Marine Intercessor")
            {
                objectives = "Objectives: " + Environment.NewLine + Environment.NewLine + "1. Call upon your Chapter's Primarch as you" + Environment.NewLine +
                                                                                            "     defeat an enemy." + Environment.NewLine + Environment.NewLine +
                                                                                            "2. Describe how the Codex Astartes applies" + Environment.NewLine +
                                                                                            "     (or does not apply) to the current situation." + Environment.NewLine + Environment.NewLine +
                                                                                            "3. Reminisce upon the traditions of your Chapter" + Environment.NewLine +
                                                                                            "     (and the Chapter's Homeworld, if any, and" + Environment.NewLine +
                                                                                            "     compare it to the current situation.";

                if (selectedArchetype == "Space Marine Scout")
                {
                    archetypeBenefitsList = "Space Marine Scout: +1 Influence. +Rank to all Stealth " + 
                                              "tests if they are in cover." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Imperium>, <Adeptus Astartes>, <CHAPTER>";

                    archetypeRequirementsList.Add(Tuple.Create("attStrengthTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("attAgilityTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("attToughnessTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("ballisticRatingLabel", 2));
                    archetypeRequirementsList.Add(Tuple.Create("weaponSkillRatingLabel", 2));
                }

                if (selectedArchetype == "Tactical Space Marine")
                {
                    archetypeBenefitsList = "Tactical Space Marine: +2 Influence. On a Critical " +
                                              "Hit, draw 2\u00A0cards (or make 2\u00A0rolls) and pick one " + 
                                              "to keep." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Imperium>, <Adeptus Astartes>, <CHAPTER>";

                    archetypeRequirementsList.Add(Tuple.Create("attStrengthTotal", 4));
                    archetypeRequirementsList.Add(Tuple.Create("attAgilityTotal", 4));
                    archetypeRequirementsList.Add(Tuple.Create("attToughnessTotal", 4));
                    archetypeRequirementsList.Add(Tuple.Create("ballisticRatingLabel", 3));
                    archetypeRequirementsList.Add(Tuple.Create("weaponSkillRatingLabel", 3));
                }

                if (selectedArchetype == "Primaris Marine Intercessor")
                {
                    archetypeBenefitsList = "Primaris Marine Intercessor: +1 Influence. When firing " + 
                                              "a Bolt Rifle or Heavy Bolt Pistol, add +Rank to attack " + 
                                              "rolls." + Environment.NewLine + Environment.NewLine;

                    keywordsList          = "<Imperium>, <Adeptus\u00A0Astartes>, <Primaris>, <CHAPTER>";

                    archetypeRequirementsList.Add(Tuple.Create("attStrengthTotal", 4));
                    archetypeRequirementsList.Add(Tuple.Create("attAgilityTotal", 4));
                    archetypeRequirementsList.Add(Tuple.Create("attToughnessTotal", 4));
                    archetypeRequirementsList.Add(Tuple.Create("ballisticRatingLabel", 4));
                    archetypeRequirementsList.Add(Tuple.Create("weaponSkillRatingLabel", 4));
                }



            }
            else if (selectedArchetype == "Inquisitional Acolyte" || selectedArchetype == "Inquisitorial Adept" || selectedArchetype == "Sanctioned Psyker" ||
                selectedArchetype == "Inquisitor" || selectedArchetype == "Rogue Trader")
            {
                objectives = "Objectives: " + Environment.NewLine + Environment.NewLine + "1. Solve a problem using wealth, influence, psychic" + Environment.NewLine +
                                                                                            "     abilities, or guile instead of threats or force." + Environment.NewLine + Environment.NewLine +
                                                                                            "2. Compare the current situation to a far-flung exotic" + Environment.NewLine +
                                                                                            "     world (within or beyond the Imperium) that you have" + Environment.NewLine +
                                                                                            "     visited." + Environment.NewLine + Environment.NewLine +
                                                                                            "3. Display a symbol of your authority, and use it to" + Environment.NewLine +
                                                                                            "     firmly establish your position in an interaction" + Environment.NewLine +
                                                                                            "     with an NPC.";

                if (selectedArchetype == "Inquisitional Acolyte")
                {
                    archetypeBenefitsList = "Inquisitional Acolyte: +2 Influence. Once per Scene, " + 
                                              "you may invoke the name of your Inquisitor to add +Rank " + 
                                              "to an Influence or Interaction skill test involving a " + 
                                              "character with the <Imperium> keyword." + Environment.NewLine + Environment.NewLine;

                    keywordsList          = "<Imperium>, <Inquisition>, <Any>, <ORDO>";

                    archetypeRequirementsList.Add(Tuple.Create("attStrengthTotal", 1));
                }

                if (selectedArchetype == "Inquisitorial Adept")
                {
                    archetypeBenefitsList = "Inquisitorial Adept: +1 Influence. Add +Rank to " + 
                                              "Influence or Investigation tests to acquire " + 
                                              "information." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Imperium>, <Inquisition>, <ORDO>";

                    archetypeRequirementsList.Add(Tuple.Create("attIntellectTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("scholarRatingLabel", 2));
                }

                if (selectedArchetype == "Inquisitor")
                {
                    archetypeBenefitsList = "Inquisitor: +4 Influence. +Rank to all Influence and " + 
                                              "Interaction skill tests against characters with the " + 
                                              "<Imperium> keyword." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Imperium>, <Inquisition>, <Any>, <ORDO>";

                    archetypeRequirementsList.Add(Tuple.Create("attIntellectTotal", 4));
                    archetypeRequirementsList.Add(Tuple.Create("attWillpowerTotal", 4));
                    archetypeRequirementsList.Add(Tuple.Create("cunningRatingLabel", 2));
                    archetypeRequirementsList.Add(Tuple.Create("insightRatingLabel", 2));
                    archetypeRequirementsList.Add(Tuple.Create("intimidationRatingLabel", 2));
                    archetypeRequirementsList.Add(Tuple.Create("awarenessRatingLabel", 2));
                }

                if (selectedArchetype == "Rogue Trader")
                {
                    archetypeBenefitsList = "Rogue Trader: +2 Influence. +Rank to all Persuassion " + 
                                              "and Influence tests to acquire goods or services." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Imperium>, <Rogue Trader>, <DYNASTY>";


                    archetypeRequirementsList.Add(Tuple.Create("attFellowshipTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("cunningRatingLabel", 1));
                    archetypeRequirementsList.Add(Tuple.Create("insightRatingLabel", 2));
                    archetypeRequirementsList.Add(Tuple.Create("persuasionRatingLabel", 2));
                    archetypeRequirementsList.Add(Tuple.Create("awarenessRatingLabel", 1));
                }

                if (selectedArchetype == "Sanctioned Psyker")
                {
                    archetypeBenefitsList = "Sanctioned Psyker: Starts with 1\u00A0Minor Psychic Power, " + 
                                              "and the Smite power. May purchase additional Minor " + 
                                              "Psychic Powers, subject to Tier restrictions." + Environment.NewLine + Environment.NewLine;

                    keywordsList          = "<Imperium>, <Adeptus\u00A0Astra\u00A0Telepathica>, <Psyker>, " +
                                            "<Scholastica\u00A0Psykana>";

                    archetypeRequirementsList.Add(Tuple.Create("attWillpowerTotal", 4));
                    archetypeRequirementsList.Add(Tuple.Create("psychicRatingLabel", 1));
                }



            }
            else if (selectedArchetype == "Skitarius" || selectedArchetype == "Tech-Priest")
            {
                objectives = "Objectives: " + Environment.NewLine + Environment.NewLine + "1. Praise the Omnissiah as you commune with a" + Environment.NewLine +
                                                                                            "     machine-spirit (a successful Tech test counts" + Environment.NewLine +
                                                                                            "     for this." + Environment.NewLine + Environment.NewLine +
                                                                                            "2. Calculate the odds of any given task and" + Environment.NewLine +
                                                                                            "     provide an estime of either survival or" + Environment.NewLine +
                                                                                            "     success (or both)." + Environment.NewLine + Environment.NewLine +
                                                                                            "3. Reminisce about a Forge World you have visited" + Environment.NewLine +
                                                                                            "     and compare it to the current location.";

                if (selectedArchetype == "Tech-Priest")
                {
                    archetypeBenefitsList = "Tech-Priest: +2 Influence. You reduce the time by half " +  
                                              "for any Tech test. You receive +Rank on Tech tests to " + 
                                              "repair damaged machines." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Imperium>, <Adeptus\u00A0Mechanicus>, <Cult\u00A0Mechanicus>, " +
                                            "<FORGE\u00A0WORLD>";

                    archetypeRequirementsList.Add(Tuple.Create("attIntellectTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("techRatingLabel", 3));
                    archetypeRequirementsList.Add(Tuple.Create("scholarRatingLabel", 1));
                }

                if (selectedArchetype == "Skitarius")
                {
                    archetypeBenefitsList = "Skitarius: You do not bleed, and gain +1/2 Rank to " + 
                                              "Soak tests." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Imperium>, <Adeptus\u00A0Mechanicus>, <Skitarii>, " +
                                            "<FORGE\u00A0WORLD>";

                    archetypeRequirementsList.Add(Tuple.Create("attToughnessTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("ballisticRatingLabel", 2));
                    archetypeRequirementsList.Add(Tuple.Create("techRatingLabel", 1));
                }

            }
            else if (selectedArchetype == "Hive Ganger" || selectedArchetype == "Scavvy" || selectedArchetype == "Desperado")
            {
                objectives = "Objectives: " + Environment.NewLine + Environment.NewLine + "1. Compare the current situation to a crime you" + Environment.NewLine +
                                                                                            "     once observed (or participated in)." + Environment.NewLine + Environment.NewLine +
                                                                                            "2. Verbally estimate the potential value of an" + Environment.NewLine +
                                                                                            "     item (or person!) if it were in your possession." + Environment.NewLine +
                                                                                            "     This may be as subtle or as overt as you wish." + Environment.NewLine + Environment.NewLine +
                                                                                            "3. Describe a desperate act of survival you attempted" + Environment.NewLine +
                                                                                            "     under difficult circumstances.";
                if (selectedArchetype == "Hive Ganger")
                {
                    archetypeBenefitsList = "Hive Ganger: +1 Influence. +Rank to Cunning tests. " + 
                                              "May make a single retroactive Influence test, +Rank " + 
                                              "to represent an item they prepared in advance." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Scum>, <Any>";

                    archetypeRequirementsList.Add(Tuple.Create("cunningRatingLabel", 1));
                }

                if (selectedArchetype == "Scavvy")
                {
                    archetypeBenefitsList = "Scavvy: -1 Influence. May select 1 Mutation\u00A0(P.368). " + 
                                              "When you gain a Rank, you may select 1 new Mutation." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Scum>, <Any>";

                    archetypeRequirementsList.Add(Tuple.Create("attToughnessTotal", 2));
                    archetypeRequirementsList.Add(Tuple.Create("survivalRatingLabel", 1));
                }

                if (selectedArchetype == "Desperado")
                {
                    archetypeBenefitsList = "Desperado: +1 Influence. +Rank for Cunning tests. " + 
                                              "+Rank for Awareness tests while tracking a target." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Scum>, <Any>";

                    archetypeRequirementsList.Add(Tuple.Create("attAgilityTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("attIntellectTotal", 2));
                    archetypeRequirementsList.Add(Tuple.Create("awarenessRatingLabel", 2));
                    archetypeRequirementsList.Add(Tuple.Create("cunningRatingLabel", 2));
                    archetypeRequirementsList.Add(Tuple.Create("investigationRatingLabel", 2));
                }

            }
            else if (selectedArchetype == "Cultist" || selectedArchetype == "Chaos Space Marine" || selectedArchetype == "Heretek" || selectedArchetype == "Rogue Psyker")
            {
                objectives = "Objectives: " + Environment.NewLine + Environment.NewLine + "1. Describe the benefit (or lack thereof!) of" + Environment.NewLine +
                                                                                            "     gaining the attention of the Ruinous Powers." + Environment.NewLine + Environment.NewLine +
                                                                                            "2. Proclaim how a flaw of the Imperium shall lead" + Environment.NewLine +
                                                                                            "     to its downfall." + Environment.NewLine + Environment.NewLine +
                                                                                            "3. Bear witness to an act that you consider a sign" + Environment.NewLine +
                                                                                            "     of the Ruinous Powers' favour (or contempt).";

                if (selectedArchetype == "Cultist")
                {
                    archetypeBenefitsList = "Cultist: +2\u00A0Influence. +1\u00A0Corruption. +Rank to " + 
                                              "Deception tests, including attacks, against any " + 
                                              "characters with the <Imperium> keyword." + Environment.NewLine + Environment.NewLine;

                    keywordsList          = "<Chaos>, <Heretic>, <Heretic\u00A0Astartes>, " +
                                            "<Mark\u00A0of\u00A0Chaos>, <Any>";

                    archetypeRequirementsList.Add(Tuple.Create("deceptionRatingLabel", 1));
                }

                if (selectedArchetype == "Heretek")
                {
                    archetypeBenefitsList = "Heretek: +1\u00A0Influence. +3\u00A0Corruption. Automatically " + 
                                              "reduce the time for tech tests by half. +Rank for " + 
                                              "tech Interaction attacks." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Chaos>, <Heretic>, <Adeptus Mechanicus>, " + 
                                            "<Dark Mechanicus>";

                    archetypeRequirementsList.Add(Tuple.Create("attIntellectTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("techRatingLabel", 3));
                    archetypeRequirementsList.Add(Tuple.Create("scholarRatingLabel", 1));
                }

                if (selectedArchetype == "Rogue Psyker")
                {
                    archetypeBenefitsList = "Rogue Psyker: +3\u00A0Corruption. Starts with 1\u00A0Minor" +  
                                              "Psychic Power, and Smite. May purchase additional " + 
                                              "Minor, Universal, or Maleficarum Psychic Powers, " + 
                                              "subject to Tier restrictions" + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Chaos>, <Heretic>, <Psyker>";

                    archetypeRequirementsList.Add(Tuple.Create("attWillpowerTotal", 4));
                    archetypeRequirementsList.Add(Tuple.Create("psychicRatingLabel", 1));
                }

                if (selectedArchetype == "Chaos Space Marine")
                {
                    archetypeBenefitsList = "Chaos Space Marine: +3\u00A0Corruption. See Imperium " +
                                              "Space Marine benefits for more details\u00A0(P.126)." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Chaos>, <Heretic>, <Heretic\u00A0Astartes>," +
                                            "<Mark\u00A0of\u00A0Chaos>, <LEGION>";

                    archetypeRequirementsList.Add(Tuple.Create("attWillpowerTotal", 1));
                }


            }
            else if (selectedArchetype == "Eldar Corsair" || selectedArchetype == "Eldar Ranger" || selectedArchetype == "Eldar Warlock")
            {
                objectives = "Objectives: " + Environment.NewLine + Environment.NewLine + "1. Unfavourably evaluate a facet of another species" + Environment.NewLine +
                                                                                            "     against Eldar culture, technology or art." + Environment.NewLine + Environment.NewLine +
                                                                                            "2. Call upon one of the gods of the Edlar as you" + Environment.NewLine +
                                                                                            "     accomplish a difficult task or defeat an enemy." + Environment.NewLine + Environment.NewLine +
                                                                                            "3. Reminisce upon the traditions of an Eldar Craftworld," + Environment.NewLine +
                                                                                            "     and compare it to the current situation.";

                if (selectedArchetype == "Eldar Corsair")
                {
                    archetypeBenefitsList = "Eldar Corsair: Choose either Athletics or Persuassion " + 
                                              "Interaction attacks. You receive +Rank to the chosen " + 
                                              "attack, and +Rank to defending against the same. You " +
                                              "suffer +1DN\u00A0penalty to fear tests." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Aeldari>, <Anhrathe>, <COTERIE>";

                    archetypeRequirementsList.Add(Tuple.Create("attAgilityTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("athleticsRatingLabel", 2));
                }

                if (selectedArchetype == "Eldar Ranger")
                {
                    archetypeBenefitsList = "Eldar Ranger: Any penalties to detect (using " + 
                                              "Awareness) or attack you, due to lighting or cover " +
                                              "are increased by +1/2\u00A0Rank." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Aeldari>, <Asuryani>, <CRAFTWORLD>";

                    archetypeRequirementsList.Add(Tuple.Create("attAgilityTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("stealthRatingLabel", 1));
                    archetypeRequirementsList.Add(Tuple.Create("survivalRatingLabel", 2));
                }

                if (selectedArchetype == "Eldar Warlock")
                {
                    archetypeBenefitsList = "Eldar Warlock: +2\u00A0Influence. Starts with Psyniscience " + 
                                              "and Smite. May purchase additional Minor, Universal, " + 
                                              "and Runes of Battle Psychic Powers, subject to Tier " + 
                                              "restrictions." + Environment.NewLine + Environment.NewLine;

                    keywordsList          = "<Aeldari>, <Asuryani>, <Psyker>, <CRAFTWORLD>";

                    archetypeRequirementsList.Add(Tuple.Create("attWillpowerTotal", 4));
                    archetypeRequirementsList.Add(Tuple.Create("psychicRatingLabel", 2));
                }
            }

            else if (selectedArchetype == "Ork Boy" || selectedArchetype == "Ork Kommando" || selectedArchetype == "Ork Nob")
            {
                objectives = "Objectives: " + Environment.NewLine + Environment.NewLine + "1. Reminisce on the traditions of your Ork Clan," + Environment.NewLine +
                                                                                            "     and compare them to your current situation." + Environment.NewLine + Environment.NewLine +
                                                                                            "2. Use your size, physical might, or reputation" + Environment.NewLine +
                                                                                            "     in a fearsome manner." + Environment.NewLine + Environment.NewLine +
                                                                                            "3. Sincerely express your desire for a brutal," + Environment.NewLine +
                                                                                            "     uncompromising combat.";

                if (selectedArchetype == "Ork Boy")
                {
                    archetypeBenefitsList = "Ork Boy: +Rank to melee attacks for every ally " + 
                                              "engaged in melee combat with the same target." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Ork>, <CLAN>";

                    archetypeRequirementsList.Add(Tuple.Create("attToughnessTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("weaponSkillRatingLabel", 2));
                }

                if (selectedArchetype == "Ork Kommando")
                {
                    archetypeBenefitsList = "Ork Kommando: You and any Allies within 15\u00A0meters " +
                                              "gain +1/2\u00A0Rank to Stealth tests." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Ork>, <CLAN>";

                    archetypeRequirementsList.Add(Tuple.Create("attAgilityTotal", 2));
                    archetypeRequirementsList.Add(Tuple.Create("attToughnessTotal", 2));
                    archetypeRequirementsList.Add(Tuple.Create("stealthRatingLabel", 2));
                    archetypeRequirementsList.Add(Tuple.Create("survivalRatingLabel", 1));
                }

                if (selectedArchetype == "Ork Nob")
                {
                    archetypeBenefitsList = "Ork Nob: +2\u00A0Influence. You command a Mob of Troops, " +
                                              "numbering up to Rank\u00A0x\u00A03\u00A0Boyz who loyally follow " + 
                                              "your direction. See\u00A0P.150 for Boyz profile." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Ork>, <CLAN>";

                    archetypeRequirementsList.Add(Tuple.Create("attStrengthTotal", 4));
                    archetypeRequirementsList.Add(Tuple.Create("attToughnessTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("intimidationRatingLabel", 2));
                }


            }

            else if (selectedArchetype == "Necron Warrior" || selectedArchetype ==  "Necron Nemesor" || selectedArchetype == "Necron Cryptek")
            {
                objectives = "Objectives: " + Environment.NewLine + Environment.NewLine + "1. Remind another Necron of the Overlords" + Environment.NewLine +
                                                                                          "     wisdom and infallibility in a difficult" + Environment.NewLine +
                                                                                          "     situation." + Environment.NewLine + Environment.NewLine +
                                                                                          "2. Attempt to remember a detail of your past" + Environment.NewLine +
                                                                                          "     life, in specific reference to the current" + Environment.NewLine +
                                                                                          "     situation." + Environment.NewLine + Environment.NewLine +
                                                                                          "3. Willingly make a sacrific (Ammo, equipment," + Environment.NewLine +
                                                                                          "     or even your own wellbeing!) for the benefit" + Environment.NewLine +
                                                                                          "     of another Necron or the mission.";

                if (selectedArchetype == "Necron Warrior")
                {
                    archetypeBenefitsList = "Necron Warrior: At 0\u00A0wounds, if you have at least " + 
                                              "1\u00A0point of Glory, may spend ALL Glory in the pool " + 
                                              "to recover all Wounds, instead of making a Defiance " + 
                                              "check." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Necron>";

                    archetypeRequirementsList.Add(Tuple.Create("attAgilityTotal", 2));
                    archetypeRequirementsList.Add(Tuple.Create("ballisticRatingLabel", 2));
                }

                if (selectedArchetype == "Necron Nemesor")
                {
                    archetypeBenefitsList = "Necron Nemesor: At 0\u00A0wounds, if you have at least " +
                                              "1\u00A0point of Glory, may spend ALL Glory in the pool " + 
                                              "to recover all Wounds, instead of making a Defiance " + 
                                              "check." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Necron>, <DYNASTY>";

                    archetypeRequirementsList.Add(Tuple.Create("attToughnessTotal", 3));
                }
                if (selectedArchetype == "Necron Cryptek")
                {
                    archetypeBenefitsList = "Necron Cryptek: At 0\u00A0wounds, if you have at least " + 
                                              "1\u00A0point of Glory, may spend ALL Glory in the pool " + 
                                              "to recover all Wounds, instead of making a Defiance " +
                                              "check. Starts with 1\u00A0Minor Psychic Power, and Smite. " +
                                              "May purchase additional Psychic Powers, subject to " + 
                                              "Tier restrictions. Treat these powers as working " + 
                                              "technologically, rather than via the Warp." + Environment.NewLine + Environment.NewLine;

                    keywordsList = "<Necron>, <Psyker>";

                    archetypeRequirementsList.Add(Tuple.Create("attWillpowerTotal", 3));
                    archetypeRequirementsList.Add(Tuple.Create("psychicRatingLabel", 3));
                }
            }

            else
            {
                foreach (customArchetype x in customArchetypeList)
                {
                    if (raceSelection == x.name + ", " + Convert.ToString(x.bpCost) + "BP")
                    {
                        foreach (Dictionary<string, string> y in x.archetypes)
                        {
                            if (y["archetype"] == selectedArchetype)
                            {
                                archetypeBenefitsList = y["archetypeDescription"];
                                archetypeRequirementsList.Add(Tuple.Create("attStrengthTotal", 1));
                            }
                        }
                    }
                }
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
                sw.WriteLine(Convert.ToString(armorFromEquip));
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

                sw.WriteLine("?????Equipment?????");
                foreach (TreeNode item in equipTreeBox.Nodes)
                {
                    if (item !=  null)
                    {
                        if (item.Nodes.Count > 0)
                        {
                            foreach (TreeNode n in item.Nodes)
                            {
                                sw.WriteLine(n.Parent.Text);
                                sw.WriteLine(n.Text);
                                
                                if (item.Nodes.Count > 0)
                                {
                                    foreach (TreeNode m in n.Nodes)
                                    {
                                        sw.WriteLine("WeaponMod");
                                        sw.WriteLine(m.Parent.Text);
                                        sw.WriteLine(m.Text);
                                    }
                                }
                                
                            }
                        }
                    }
                }
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
                //int counter = 0;

                nameBox.Text = sr.ReadLine();
                tierSelection = Convert.ToInt32(sr.ReadLine());
                raceSelection = sr.ReadLine();
                archetypeSelection = sr.ReadLine();
                tierSelect.SelectedIndex = Convert.ToInt32(sr.ReadLine());
                armorFromEquip = Convert.ToInt32(sr.ReadLine());
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




           


                // special boxes
                sr.ReadLine();
                foreach(TreeNode item in equipTreeBox.Nodes)
                {
                    if (item != null)
                    {
                        if (item.Nodes.Count > 0)
                        {
                            item.Nodes.Clear();
                        }
                            
                    }
                }
                while (line != "?????Powers?????")
                {
                    line = sr.ReadLine();
                    if (line != "?????Powers?????")
                    {
                        if (line == "Ranged Weapons")
                        {
                            TreeNode rootNode = equipTreeBox.Nodes.Cast<TreeNode>().ToList().Find(n => n.Text.Equals("Ranged Weapons"));
                            if (rootNode != null)
                            {
                                line = sr.ReadLine();
                                rootNode.Nodes.Add(line);
                                rootNode.Expand();
                            }
                        }
                        if (line == "Melee Weapons")
                        {
                            TreeNode rootNode = equipTreeBox.Nodes.Cast<TreeNode>().ToList().Find(n => n.Text.Equals("Melee Weapons"));
                            if (rootNode != null)
                            {
                                line = sr.ReadLine();
                                rootNode.Nodes.Add(line);
                                rootNode.Expand();
                            }
                        }
                        if (line == "Armor")
                        {
                            TreeNode rootNode = equipTreeBox.Nodes.Cast<TreeNode>().ToList().Find(n => n.Text.Equals("Armor"));
                            if (rootNode != null)
                            {
                                line = sr.ReadLine();
                                rootNode.Nodes.Add(line);
                                rootNode.Expand();
                            }
                        }
                        if (line == "Ammo and Tools")
                        {
                            TreeNode rootNode = equipTreeBox.Nodes.Cast<TreeNode>().ToList().Find(n => n.Text.Equals("Ammo and Tools"));
                            if (rootNode != null)
                            {
                                line = sr.ReadLine();
                                rootNode.Nodes.Add(line);
                                rootNode.Expand();
                            }
                        }

                        // weapon mods are a little lower, take a little trip
                        if (line == "WeaponMod")
                        {
                            string modName;
                            string weaponBeingModded;

                            weaponBeingModded = sr.ReadLine();
                            modName = sr.ReadLine();

                            List<TreeNode> treeNodes = new List<TreeNode>();

                            treeNodes = equipTreeBox.Nodes.Cast<TreeNode>().ToList();


                            foreach (TreeNode node in treeNodes)
                            {
                                TreeNode rootNode = node.Nodes.Cast<TreeNode>().ToList().Find(n => n.Text.Equals(weaponBeingModded));
                                if (rootNode != null)
                                {
                                    rootNode.Nodes.Add(modName);
                                    rootNode.Expand();
                                }
                            }
                        }
                    }
                }

                //sr.ReadLine();
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

        private void newCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string message = "Are you sure you want to create a new character? All unsaved changes will be lost.";
            string caption = "New Character Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;


            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                mainForm form = new mainForm();
                form.Show();
                this.Dispose(false);
            }

            else
            {
                
            }

        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mainForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            string message = "Are you sure you wish to close TheCommissar? All unsaved changes will be lost.";
            string caption = "Close Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;


            result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void checkCharacterValidityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "";
            string caption = "";
            MessageBoxButtons button = MessageBoxButtons.OK;
            int tierValidation = tierSelection;
            List<NumericUpDown> attributeList = new List<NumericUpDown>();
            List<NumericUpDown> skillList = new List<NumericUpDown>();
            List<Label> attributeTotalList = new List<Label>();
            List<Tuple<Label, string>> skillTotalList = new List<Tuple<Label, String>>();

            attributeList.Add(attStrength);
            attributeList.Add(attAgility);
            attributeList.Add(attToughness);
            attributeList.Add(attIntellect);
            attributeList.Add(attWillpower);
            attributeList.Add(attFellowship);
            attributeList.Add(attInitiative);

            skillList.Add(skillAthletics);
            skillList.Add(skillAwareness);
            skillList.Add(skillBallstic);
            skillList.Add(skillCunning);
            skillList.Add(skillDeception);
            skillList.Add(skillInsight);
            skillList.Add(skillIntimidation);
            skillList.Add(skillInvestigation);
            skillList.Add(skillLeadership);
            skillList.Add(skillMedicae);
            skillList.Add(skillPersuasion);
            skillList.Add(skillPilot);
            skillList.Add(skillPsychic);
            skillList.Add(skillScholar);
            skillList.Add(skillStealth);
            skillList.Add(skillSurvival);
            skillList.Add(skillTech);
            skillList.Add(skillWeaponSkill);

            attributeTotalList.Add(attStrengthTotal);
            attributeTotalList.Add(attAgilityTotal);
            attributeTotalList.Add(attToughnessTotal);
            attributeTotalList.Add(attIntellectTotal);
            attributeTotalList.Add(attWillpowerTotal);
            attributeTotalList.Add(attFellowshipTotal);
            attributeTotalList.Add(attInitiativeTotal);

            skillTotalList.Add(Tuple.Create(athleticsRatingLabel, "Athletics"));
            skillTotalList.Add(Tuple.Create(awarenessRatingLabel, "Awareness"));
            skillTotalList.Add(Tuple.Create(ballisticRatingLabel, "Ballistics"));
            skillTotalList.Add(Tuple.Create(cunningRatingLabel, "Cunning"));
            skillTotalList.Add(Tuple.Create(deceptionRatingLabel, "Deception"));
            skillTotalList.Add(Tuple.Create(insightRatingLabel, "Insight"));
            skillTotalList.Add(Tuple.Create(intimidationRatingLabel, "Intimidation"));
            skillTotalList.Add(Tuple.Create(investigationRatingLabel, "Investigation"));
            skillTotalList.Add(Tuple.Create(leadershipRatingLabel, "Leadership"));
            skillTotalList.Add(Tuple.Create(medicaeRatingLabel, "Medicae"));
            skillTotalList.Add(Tuple.Create(persuasionRatingLabel, "Persusasion"));
            skillTotalList.Add(Tuple.Create(pilotRatingLabel, "Pilot"));
            skillTotalList.Add(Tuple.Create(psychicRatingLabel, "Psychic Master"));
            skillTotalList.Add(Tuple.Create(scholarRatingLabel, "Scholar"));
            skillTotalList.Add(Tuple.Create(stealthRatingLabel, "Stealth"));
            skillTotalList.Add(Tuple.Create(survivalRatingLabel, "Survival"));
            skillTotalList.Add(Tuple.Create(techRatingLabel, "Tech"));
            skillTotalList.Add(Tuple.Create(weaponSkillRatingLabel, "Weapon Skill"));



            if (totalBP - totalSpentBP - bpSpentOnRace - bpSpentOnArchetype - bpSpentOnAttributes - bpSpentOnSkills - bpSpentOnPowers < 0)
            {
                message += "You you have spent too much total BP!" + Environment.NewLine;
            }

            if (tierSelect.SelectedItem == null)
            {
                message += "You do not have a Tier selected!" + Environment.NewLine;
            }

            if (speciesSelect.SelectedItem == null)
            {
                message += "You do not have a Species selected!" + Environment.NewLine;
            }

            if (archetypeSelect.SelectedItem == null)
            {
                message += "You do not have an Archetype selected!" + Environment.NewLine;
            }
            else // do the archetype requirements validation
            {
                foreach (Tuple<string, int> item in archetypeRequirementsList)
                {
                    foreach (Label att in attributeTotalList)
                    {
                        if (item.Item1 == att.Name.ToString())
                        {
                            if (Convert.ToInt32(att.Text) < item.Item2)
                            {
                                message += "Your " + att.Name.Substring(3, att.Name.Length - 8) + " is " + att.Text + "! It needs to be atleast " + item.Item2.ToString() + "!" + Environment.NewLine;
                            }
                        }
                    }
                    foreach (Tuple<Label, string> skill in skillTotalList)
                    {
                        if (item.Item1 == skill.Item1.Name.ToString())
                        {
                            if  (Convert.ToInt32(skill.Item1.Text) < item.Item2)
                            {
                                message += "Your " + skill.Item2 + " is " + skill.Item1.Text + "! It needs to be atleast " + item.Item2.ToString() + "!" + Environment.NewLine;
                            }
                        }
                    }
                }
            }

            foreach (Label item in attributeTotalList)
            {
                if (Convert.ToInt32(item.Text) == 0)
                {
                    message += "You have not put any points into " + item.Name.Substring(3, item.Name.Length - 8) + "!" + Environment.NewLine;
                }
            }

            if (tierValidation == 1)
            {
                if (bpSpentOnAttributes > 100)
                {
                    message += "You have spent more than 100BP on Attributes!" + Environment.NewLine;
                }
                foreach (NumericUpDown item in attributeList)
                {
                    if (item.Value > 4)
                    {
                        message += "You have put more than 4 points into " + item.Name.Substring(3, item.Name.Length -3) + "!" + Environment.NewLine;
                    }
                }
                foreach (NumericUpDown item in skillList)
                {
                    if (item.Value > 4)
                    {
                        message += "You have put more than 4 points into " + item.Name.Substring(5, item.Name.Length - 5) + "!" + Environment.NewLine;
                    }
                }
                
            }
            else if (tierValidation == 2)
            {
                if (bpSpentOnAttributes > 100)
                {
                    message += "You have spent more than 100BP on Attributes!" + Environment.NewLine;
                }
                foreach (NumericUpDown item in attributeList)
                {
                    if (item.Value > 5)
                    {
                        message += "You have put more than 5 points into " + item.Name.Substring(3, item.Name.Length-3) + "!" + Environment.NewLine;
                    }
                }
                foreach (NumericUpDown item in skillList)
                {
                    if (item.Value > 5)
                    {
                        message += "You have put more than 5 points into " + item.Name.Substring(5, item.Name.Length - 5) + "!" + Environment.NewLine;
                    }
                }
                
            }
            else if (tierValidation == 3)
            {
                if (bpSpentOnAttributes > 150)
                {
                    message += "You have spent more than 150BP on Attributes!" + Environment.NewLine;
                }
                foreach (NumericUpDown item in attributeList)
                {
                    if (item.Value > 6)
                    {
                        message += "You have put more than 6 points into " + item.Name.Substring(3, item.Name.Length-3) + "!" + Environment.NewLine;
                    }
                }
                foreach (NumericUpDown item in skillList)
                {
                    if (item.Value > 6)
                    {
                        message += "You have put more than 6 points into " + item.Name.Substring(5, item.Name.Length - 5) + "!" + Environment.NewLine;
                    }
                }
                
            }
            else if (tierValidation == 4)
            {
                if (bpSpentOnAttributes > 200)
                {
                    message += "You have spent more than 200BP on Attributes!" + Environment.NewLine;
                }
                foreach (NumericUpDown item in attributeList)
                {
                    if (item.Value > 8)
                    {
                        message += "You have put more than 8 points into " + item.Name.Substring(3, item.Name.Length-3) + "!" + Environment.NewLine;
                    }
                }
                foreach (NumericUpDown item in skillList)
                {
                    if (item.Value > 7)
                    {
                        message += "You have put more than 7 points into " + item.Name.Substring(5, item.Name.Length - 5) + "!" + Environment.NewLine;
                    }
                }
                
            }
            else if (tierValidation == 5)
            {
                if (bpSpentOnAttributes > 500)
                {
                    message += "You have spent more than 500BP on Attributes!" + Environment.NewLine;
                }
                foreach (NumericUpDown item in attributeList)
                {
                    if (item.Value > 10)
                    {
                        message += "You have put more than 10 points into " + item.Name.Substring(3, item.Name.Length-3) + "!" + Environment.NewLine;
                    }
                }
                foreach (NumericUpDown item in skillList)
                {
                    if (item.Value > 8)
                    {
                        message += "You have put more than 8 points into " + item.Name.Substring(5, item.Name.Length - 5) + "!" + Environment.NewLine;
                    }
                }
                
            }


            

            if (message == "")
            {
                caption = "Character is Valid!";
                message = "Your character has no errors!";
            }
            else
            {
                caption = "Validation Errors";
            }

            MessageBox.Show(message, caption, button, MessageBoxIcon.Information);

        }

    }
}



