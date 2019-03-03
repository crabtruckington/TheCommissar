using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace TheCommissar
{
    public partial class talentForm : Form
    {
        int bpCost = 0;
        string details = "";

        List<talentObject> customTalentList;

        public class talentObject
        {
            public string name { get; set; }
            public int bpcost { get; set; }
            public string details { get; set; }
        }

        public talentForm()
        {
            InitializeComponent();
            addHomebrewTalents();
            talentDetailsLabel.Text = "";
        }

        private void addHomebrewTalents()
        {
            string resourceName = Environment.CurrentDirectory + "\\HomebrewExtensions\\talentHomebrew.json";

            //JObject eBrew = JObject.Parse(File.ReadAllText(resourceName));

            try
            {
                customTalentList = JsonConvert.DeserializeObject<List<talentObject>>(File.ReadAllText(resourceName));
                foreach (talentObject x in customTalentList)
                {
                    string name = x.name;
                    talentSelectBox.Items.Add(name);
                }
            }
            catch (IOException)
            {
                string message = "Cant find the talentHomebrew.json file! Have you moved it? Do you have read access to the directory the program is running from?";
                string caption = "Error!";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, button, MessageBoxIcon.Error);
            }
            catch
            {
                string message = "There was an error loading talentHomebrew.json! Did you make a mistake in your syntax?";
                string caption = "Error!";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, button, MessageBoxIcon.Error);
            }
        }

        private void talentForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = talentSelectBox.SelectedItem.ToString();
            setTalentCost(curItem);
            talentDetailsLabel.Text = "BP Cost: " + Convert.ToString(bpCost) + Environment.NewLine + Environment.NewLine +
                                      "Details: " + details;

        }
        public Tuple<string, int, string> getTalentsAndCost()
        {
            var result = new Tuple<string, int, string>(talentSelectBox.SelectedItem.ToString(), bpCost, details);
            return result;
        }

        public Tuple<string, int, string> findTalentDetails(string Talent)
        {
            string talent = Talent;
            setTalentCost(talent);
            var result = new Tuple<string, int, string>(talent, bpCost, details);
            return result;
        }



        // giant retarded list that gets talent costs, this could probably be done way better but its easy
        private void setTalentCost (string Talent)
        {
            string talent = Talent;
            if (talent == "Acts of Faith")
            {
                bpCost = 40;
                details = "Requires Adeptus\u00A0Ministorum or Adepta\u00A0Sororitas, Willpower\u00A03. " +
                          "Selectable multiple times, granding 2\u00A0Faith each time. See P.171 for details.";
            }
            else if (talent == "Augmetic")
            {
                bpCost = 20;
                details = "Requires Toughness\u00A02. May choose 2\u00A0implants value (Rare) or lower, or 1\u00A0implant value (Very Rare) or higher. " +
                          "Implant numerical value is paid for in BP. Can be taken multiple times.";
            }
            else if (talent == "Cybernetic Reconstruction")
            {
                bpCost = 30;
                details = "Requires Tier\u00A02. +1/2\u00A0Rank to Tech and Soak tests. +2DN\u00A0penalty to Persuasion tests. May repair existing memorable " +
                    "or maiming injuries.";
            }
            else if (talent == "Betrayer")
            {
                bpCost = 30;
                details = "Requires Rank\u00A02+, Chaos, Devotees keywords. You gain +1\u00A0Corruption. May sacrifice 1\u00A0Devotee to gain a point of Wrath.";
            }
            else if (talent == "Bombardment")
            {
                bpCost = 40;
                details = "Requires Rank\u00A03+, Aeldari, Astra\u00A0Militarum, Chaos, Ork, Rogue\u00A0Trader, or Adeptus\u00A0Astartes. Call in an orbital" +
                    "bombardment. This does 20\u00A0+Rank\u00A0ED within Rank\u00A0x\u00A05\u00A0Meters of the target.";
            }
            else if (talent == "Chaos Familiar")
            {
                bpCost = 20;
                details = "Requires Chaos. You gain +2\u00A0Corruption. You gain a minion, see P.173 for details.";
            }
            else if (talent == "Counterstrike")
            {
                bpCost = 30;
                details = "Requires Weapon\u00A0Skill\u00A05+. The first time you are melee attacked in a round, you may melee attack the attacker.";
            }
            else if (talent == "Dedicant")
            {
                bpCost = 30;
                details = "Requires 1 ability that grants +1/2\u00A0Rank bonus. Improve that ability to be +1\u00A0Rank. Also gain +1\u00A0Influence.";
            }
            else if (talent == "Devotees")
            {
                bpCost = 30;
                details = "Requires Leadership\u00A04+. You get Devotees. See P.174 for details.";
            }
            else if (talent == "Dual Wielder")
            {
                bpCost = 30;
                details = "Requires Ballistic or Melee\u00A04+. May ignore up to +2DN penalty when making multi-attack. See P.174 for more details.";
            }
            else if (talent == "Favored by the Warp")
            {
                bpCost = 40;
                details = "Requires Psyker. May reroll Perils of the Warp results one time. Must keep the rerolled results.";
            }
            else if (talent == "Fearless")
            {
                bpCost = 30;
                details = "Requires Willpower\u00A05+. Automatically pass Fear tests. Immune to Intimidation Interaction Attacks.";
            }
            else if (talent == "Hammer Blow")
            {
                bpCost = 20;
                details = "Requires Weapon Skill\u00A03+. Add +1/2\u00A0Rank\u00A0ED to any All\u2011Out\u00A0Attack.";
            }
            else if (talent == "Hardy")
            {
                bpCost = 30;
                details = "Requires Toughness\u00A03+. Once per battle, may make a Toughness\u00A0DN3 test. Recover 1\u00A0shock on failure. Recover Rank\u00A0shock on success.";
            }
            else if (talent == "Hatred")
            {
                bpCost = 30;
                details = "Requires Weapon Skill\u00A03+. Selecte a race or faction keyword. +Rank bonus on melee attacks agains this keyword. +2DN penalty on non\u2011hostile actions " +
                    "against the same.";
            }
            else if (talent == "Heroic Charge")
            {
                bpCost = 20;
                details = "Requires Athletics\u00A02+, Weapon Skill\u00A02+. +1/2\u00A0Rank to any Charge attack.";
            }
            else if (talent == "Inspired Blessing")
            {
                bpCost = 25;
                details = "Requires Adeptus Ministorum. Cannot have Chaos keyword. Grants 1\u00A0Faith. May spend 1 faith to restore 1d3+Rank\u00A0Shock to you and " +
                    "all allies within 15\u00A0+Rank meters.";
            }
            else if (talent == "Legacy of Sorrow")
            {
                bpCost = 20;
                details = "Requires Aeldari. No longer suffer from Intense Emotion species ability. +1\u00A0Glory on successful Defiance checks.";
            }
            else if (talent == "Let the Galaxy Burn")
            {
                bpCost = 20;
                details = "Requires Chaos. You gain +1\u00A0Corruption. Any time you incapacity an Adversary or Elite, gain 1\u00A0Glory.";
            }
            else if (talent == "Loremaster")
            {
                bpCost = 30;
                details = "Requires Scholar\u00A04+. Choose a field of study. Any time you make a test related to this field, add +Rank bonus.";
            }
            else if (talent == "Mark of Chaos")
            {
                bpCost = 30;
                details = "Requires Mark of Chaos keyword. Gain +1\u00A0Corruption. Choose a Chaos god to dedicate yourself to, see P.177 for details.";
            }
            else if (talent == "Marksman")
            {
                bpCost = 20;
                details = "Requires Ballistics Skill\u00A03+. When you use Aim, may reduce DN of Called Shot by 1/2\u00A0Rank.";
            }
            else if (talent == "Mastered Paths")
            {
                bpCost = 20;
                details = "Requires Aeldari, Asuryani. May choose an additional Background.";
            }
            else if (talent == "Mob Rule")
            {
                bpCost = 20;
                details = "Requires Ork. When commanding a group of Orks, you and any allies within 15+Rank meters may add +Rank to Resolve tests.";
            }
            else if (talent == "Peer")
            {
                bpCost = 30;
                details = "Requires Persuasion\u00A03+. Add +Rank to Influence tests and interaction tests where social status makes a difference.";
            }
            else if (talent == "Primaris Perspective")
            {
                bpCost = 40;
                details = "Requires Primaris Astartes. Add +1/2\u00A0Rank to Resolve and Corruption tests. Add +Rank to Scholar tests regarding history.";
            }
            else if (talent == "Rite of Fear")
            {
                bpCost = 30;
                details = "Requires Adeptus Mechanicus. Activated with an action. Creates a cone 10\u00A0meters long by 3\u00A0meters. Anyone within " +
                    "must make a Fear tests, DN(Rank+2). You are immune.";
            }
            else if (talent == "Rite of Magnometrics")
            {
                bpCost = 20;
                details = "Requires Adeptus Mechanicus. May lift metal objects within 3+Rank meters from you, using your mind. Strength is equal to Rank+1.";
            }
            else if (talent == "Rite of Pure Thought")
            {
                bpCost = 30;
                details = "Requires Adeptus Mechanicus. May not have Uncanny Resolve. Add +1/2\u00A0Rank to Fear tests and resisting Persuasion and Initimidation Interaction " +
                    "Attacks. Add +1/2\u00A0Rank to Investigation tests.";
            }
            else if (talent == "Shootier")
            {
                bpCost = 35;
                details = "Requires Ork. Add +1/2\u00A0Rank to Salvo of any weapon you are using.";
            }
            else if (talent == "Sidestep")
            {
                bpCost = 30;
                details = "Requires Initiative\u00A03+. Once per round when you are melee attacked, you may sacrifice your move action to gain +Rank to your Defence and Resilience.";
            }
            else if (talent == "Special Weapons Trooper")
            {
                bpCost = 20;
                details = "Requires Ballistics Skill\u00A03+, Imperial Guardsman or Tempestus Scion. May select special weapon, see P.179 for details.";
            }
            else if (talent == "Steel and Doom")
            {
                bpCost = 30;
                details = "Requires Rank\u00A03+, Adeptus Astartes. Add +1/2 Rank to damage value of selected weapons. See P.180 for details.";
            }
            else if (talent == "Storm of Death")
            {
                bpCost = 30;
                details = "Requires Weapon Skill\u00A04+. May reduce penalty for Multi\u2011Attack by Rank. May not use any other combat actions while using this ability.";
            }
            else if (talent == "Superhuman Strength")
            {
                bpCost = 60;
                details = "Requires Strength\u00A05+. Add +Rank to all pools using Strength.";
            }
            else if (talent == "Superhuman Agility")
            {
                bpCost = 60;
                details = "Requires Agility\u00A05+. Add +Rank to all pools using Agility.";
            }
            else if (talent == "Superhuman Toughness")
            {
                bpCost = 60;
                details = "Requires Toughness\u00A05+. Add +Rank to all pools using Toughness.";
            }
            else if (talent == "Superhuman Intellect")
            {
                bpCost = 60;
                details = "Requires Intellect\u00A05+. Add +Rank to all pools using Intellect.";
            }
            else if (talent == "Superhuman Willpower")
            {
                bpCost = 60;
                details = "Requires Willpower\u00A05+. Add +Rank to all pools using Willpower.";
            }
            else if (talent == "Superhuman Fellowship")
            {
                bpCost = 60;
                details = "Requires Fellowship\u00A05+. Add +Rank to all pools using Fellowship.";
            }
            else if (talent == "Superhuman Initiative")
            {
                bpCost = 60;
                details = "Requires Initiative\u00A05+. Add +Rank to all pools using Initiative.";
            }
            else if (talent == "Superhuman Speed")
            {
                bpCost = 60;
                details = "Requires Speed\u00A05+. Add +Rank to all pools using Speed.";
            }
            else if (talent == "Supreme Presence")
            {
                bpCost = 30;
                details = "Requires Interaction Skill 4+. Choose an Interaction Skill, may add either Rank+1 targets or one mob of troops without DN penalty. Treat this " +
                    "as a Multi\u2011Attack without the DN increase.";
            }
            else if (talent == "The Emperor\'s Light")
            {
                bpCost = 25;
                details = "Requires Adeptus Ministorum, may not posses Chaos keyword. Gain 1\u00A0Faith. Spend 1\u00A0Faith to add +Rank to Fear and Corruption tests for you and " +
                    "all allies within 15+Rank\u00A0Meters for 1\u00A0Round.";
            }
            else if (talent == "Touched by Fate")
            {
                bpCost = 30;
                details = "No Requirements. Begin each session with +1/2\u00A0Rank Wrath.";
            }
            else if (talent == "Trademark Weapon")
            {
                bpCost = 30;
                details = "Requires Attack Skill 4+. Choose a single weapon. When using this weapon, add +Rank\u00A0ED to all successful attacks.";
            }
            else if (talent == "True Grit")
            {
                bpCost = 40;
                details = "Requires Toughness 4+. No DN penalty for Lightly\u00A0Wounded, +1DN Penalty for Heavily\u00A0Wounded. Increase total Wounds by +1/2\u00A0Rank.";
            }
            else if (talent == "Uncanny Defence")
            {
                bpCost = 40;
                details = "No requirements. Increase Defence by +1/2\u00A0Rank.";
            }
            else if (talent == "Uncanny Resilience")
            {
                bpCost = 40;
                details = "No requirements. Increase Resilience by +1/2\u00A0Rank.";
            }
            else if (talent == "Uncanny Soak")
            {
                bpCost = 40;
                details = "No requirements. Increase Soak by +1/2\u00A0Rank.";
            }
            else if (talent == "Uncanny Shock")
            {
                bpCost = 40;
                details = "No requirements. Increase Shock by +1/2\u00A0Rank.";
            }
            else if (talent == "Uncanny Speed")
            {
                bpCost = 40;
                details = "No requirements. Increase Speed by +1/2\u00A0Rank.";
            }
            else if (talent == "Uncanny Wounds")
            {
                bpCost = 40;
                details = "No requirements. Increase Wounds by +1/2\u00A0Rank.";
            }
            else if (talent == "Uncanny Convinction")
            {
                bpCost = 40;
                details = "No requirements. Increase Conviction by +1/2\u00A0Rank.";
            }
            else if (talent == "Uncanny Corruption")
            {
                bpCost = 40;
                details = "No requirements. Increase Corruption by +1/2\u00A0Rank.";
            }
            else if (talent == "Uncanny Passive Awareness")
            {
                bpCost = 40;
                details = "No requirements. Increase Passive Awareness by +1/2\u00A0Rank.";
            }
            else if (talent == "Uncanny Resolve")
            {
                bpCost = 40;
                details = "No requirements. Increase Resolve by +1/2\u00A0Rank.";
            }
            else if (talent == "Uncanny Influence")
            {
                bpCost = 40;
                details = "No requirements. Increase Influence by +1/2\u00A0Rank.";
            }
            else if (talent == "Uncanny Wealth")
            {
                bpCost = 40;
                details = "No requirements. Increase Wealth by +1/2\u00A0Rank.";
            }
            else if (talent == "Unnatural Athletics")
            {
                bpCost = 60;
                details = "Requires Athletics 4+. Reduce any DN modifiers for tests using Athletics by Rank.";
            }
            else if (talent == "Unnatural Awareness")
            {
                bpCost = 60;
                details = "Requires Awareness 4+. Reduce any DN modifiers for tests using Awareness by Rank.";
            }
            else if (talent == "Unnatural Ballistic Skill")
            {
                bpCost = 60;
                details = "Requires Ballistic Skill 4+. Reduce any DN modifiers for tests using Ballistic Skill by Rank.";
            }
            else if (talent == "Unnatural Cunning")
            {
                bpCost = 60;
                details = "Requires Cunning 4+. Reduce any DN modifiers for tests using Cunning by Rank.";
            }
            else if (talent == "Unnatural Deception")
            {
                bpCost = 60;
                details = "Requires Deception 4+. Reduce any DN modifiers for tests using Deception by Rank.";
            }
            else if (talent == "Unnatural Insight")
            {
                bpCost = 60;
                details = "Requires Insight 4+. Reduce any DN modifiers for tests using Insight by Rank.";
            }
            else if (talent == "Unnatural Intimidation")
            {
                bpCost = 60;
                details = "Requires Intimidation 4+. Reduce any DN modifiers for tests using Intimidation by Rank.";
            }
            else if (talent == "Unnatural Investigation")
            {
                bpCost = 60;
                details = "Requires Investigation 4+. Reduce any DN modifiers for tests using Investigation by Rank.";
            }
            else if (talent == "Unnatural Leadership")
            {
                bpCost = 60;
                details = "Requires Leadership 4+. Reduce any DN modifiers for tests using Leadership by Rank.";
            }
            else if (talent == "Unnatural Medicae")
            {
                bpCost = 60;
                details = "Requires Medicae 4+. Reduce any DN modifiers for tests using Medicae by Rank.";
            }
            else if (talent == "Unnatural Persuasion")
            {
                bpCost = 60;
                details = "Requires Persuasion 4+. Reduce any DN modifiers for tests using Persuasion by Rank.";
            }
            else if (talent == "Unnatural Pilot")
            {
                bpCost = 60;
                details = "Requires Pilot 4+. Reduce any DN modifiers for tests using Pilot by Rank.";
            }
            else if (talent == "Unnatural Psychic Mastery")
            {
                bpCost = 60;
                details = "Requires Psychic Master 4+. Reduce any DN modifiers for tests using Psychic Master by Rank.";
            }
            else if (talent == "Unnatural Scholar")
            {
                bpCost = 60;
                details = "Requires Scholar 4+. Reduce any DN modifiers for tests using Scholar by Rank.";
            }
            else if (talent == "Unnatural Stealth")
            {
                bpCost = 60;
                details = "Requires Stealth 4+. Reduce any DN modifiers for tests using Stealth by Rank.";
            }
            else if (talent == "Unnatural Survival")
            {
                bpCost = 60;
                details = "Requires Survival 4+. Reduce any DN modifiers for tests using Survival by Rank.";
            }
            else if (talent == "Unnatural Tech")
            {
                bpCost = 60;
                details = "Requires Tech 4+. Reduce any DN modifiers for tests using Tech by Rank.";
            }
            else if (talent == "Unnatural Weapon Skill")
            {
                bpCost = 60;
                details = "Requires Weapon Skill 4+. Reduce any DN modifiers for tests using Weapon Skill by Rank.";
            }
            else if (talent == "Unquestioning Faith")
            {
                bpCost = 20;
                details = "Requires Willpower 3+, must not have Chaos keyword. Gain +1 Faith. May spend 1 faith to gain +Rank to resist a Psychic Power. May " +
                    "spend 2 faith to grant same bonus to all allies within 15+Rank Meters.";
            }
            else
            {
                bpCost = 0;
                details = "";

                foreach (talentObject x in customTalentList)
                {
                    if (talent == x.name)
                    {
                        bpCost = x.bpcost;
                        details = x.details;
                    }
                }

            }
        }

    }
}
