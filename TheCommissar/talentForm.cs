using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheCommissar
{
    public partial class talentForm : Form
    {
        int bpCost = 0;

        public talentForm()
        {
            InitializeComponent();
        }

        private void talentForm_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = talentSelectBox.SelectedItem.ToString();
            setTalentCost(curItem);
            bpCostLabel.Text = "BP Cost: " + Convert.ToString(bpCost);

        }
        public Tuple<string, int> getTalentsAndCost()
        {
            var result = new Tuple<string, int>(talentSelectBox.SelectedItem.ToString(), bpCost);
            return result;
        }

        



        // giant retarded list that gets talent costs, this could probably be done way better but its easy
        private void setTalentCost (string Talent)
        {
            string talent = Talent;
            if (talent == "Acts of Faith")
            {
                bpCost = 40;
            }
            else if (talent == "Augmetic")
            {
                bpCost = 20;
            }
            else if (talent == "Cybernetic Reconstruction")
            {
                bpCost = 30;
            }
            else if (talent == "Betrayer")
            {
                bpCost = 30;
            }
            else if (talent == "Bombardment")
            {
                bpCost = 40;
            }
            else if (talent == "Chaos Familiar")
            {
                bpCost = 20;
            }
            else if (talent == "Counterstrike")
            {
                bpCost = 30;
            }
            else if (talent == "Dedicant")
            {
                bpCost = 30;
            }
            else if (talent == "Devotees")
            {
                bpCost = 30;
            }
            else if (talent == "Dual Wielder")
            {
                bpCost = 30;
            }
            else if (talent == "Favored by the Warp")
            {
                bpCost = 40;
            }
            else if (talent == "Fearless")
            {
                bpCost = 30;
            }
            else if (talent == "Hammer Blow")
            {
                bpCost = 20;
            }
            else if (talent == "Hardy")
            {
                bpCost = 30;
            }
            else if (talent == "Hatred")
            {
                bpCost = 30;
            }
            else if (talent == "Heroic Charge")
            {
                bpCost = 20;
            }
            else if (talent == "Inspired Blessing")
            {
                bpCost = 25;
            }
            else if (talent == "Legacy of Sorrow")
            {
                bpCost = 20;
            }
            else if (talent == "Let the Galaxy Burn")
            {
                bpCost = 20;
            }
            else if (talent == "Loremaster")
            {
                bpCost = 30;
            }
            else if (talent == "Mark of Chaos")
            {
                bpCost = 30;
            }
            else if (talent == "Marksman")
            {
                bpCost = 20;
            }
            else if (talent == "Mastered Paths")
            {
                bpCost = 20;
            }
            else if (talent == "Mob Rule")
            {
                bpCost = 20;
            }
            else if (talent == "Peer")
            {
                bpCost = 30;
            }
            else if (talent == "Primaris Perspective")
            {
                bpCost = 40;
            }
            else if (talent == "Rite of Fear")
            {
                bpCost = 30;
            }
            else if (talent == "Rite of Magnometrics")
            {
                bpCost = 20;
            }
            else if (talent == "Rite of Pure Thought")
            {
                bpCost = 30;
            }
            else if (talent == "Shootier")
            {
                bpCost = 35;
            }
            else if (talent == "Sidestep")
            {
                bpCost = 30;
            }
            else if (talent == "Special Weapons Trooper")
            {
                bpCost = 20;
            }
            else if (talent == "Steel and Doom")
            {
                bpCost = 30;
            }
            else if (talent == "Storm of Death")
            {
                bpCost = 30;
            }
            else if (talent == "Superhuman Strength")
            {
                bpCost = 60;
            }
            else if (talent == "Superhuman Agility")
            {
                bpCost = 60;
            }
            else if (talent == "Superhuman Toughness")
            {
                bpCost = 60;
            }
            else if (talent == "Superhuman Intellect")
            {
                bpCost = 60;
            }
            else if (talent == "Superhuman Willpower")
            {
                bpCost = 60;
            }
            else if (talent == "Superhuman Fellowship")
            {
                bpCost = 60;
            }
            else if (talent == "Superhuman Initiative")
            {
                bpCost = 60;
            }
            else if (talent == "Superhuman Speed")
            {
                bpCost = 60;
            }
            else if (talent == "Supreme Presence")
            {
                bpCost = 30;
            }
            else if (talent == "The Emperor\'s Light")
            {
                bpCost = 25;
            }
            else if (talent == "Touched by Fate")
            {
                bpCost = 30;
            }
            else if (talent == "Trademark Weapon")
            {
                bpCost = 30;
            }
            else if (talent == "True Grit")
            {
                bpCost = 40;
            }
            else if (talent == "Uncanny Defence")
            {
                bpCost = 40;
            }
            else if (talent == "Uncanny Resilience")
            {
                bpCost = 40;
            }
            else if (talent == "Uncanny Soak")
            {
                bpCost = 40;
            }
            else if (talent == "Uncanny Shock")
            {
                bpCost = 40;
            }
            else if (talent == "Uncanny Speed")
            {
                bpCost = 40;
            }
            else if (talent == "Uncanny Wounds")
            {
                bpCost = 40;
            }
            else if (talent == "Uncanny Convinction")
            {
                bpCost = 40;
            }
            else if (talent == "Uncanny Corruption")
            {
                bpCost = 40;
            }
            else if (talent == "Uncanny Passive Awareness")
            {
                bpCost = 40;
            }
            else if (talent == "Uncanny Resolve")
            {
                bpCost = 40;
            }
            else if (talent == "Uncanny Influence")
            {
                bpCost = 40;
            }
            else if (talent == "Uncanny Wealth")
            {
                bpCost = 40;
            }
            else if (talent == "Unnatural Athletics")
            {
                bpCost = 60;
            }
            else if (talent == "Unnatural Awareness")
            {
                bpCost = 60;
            }
            else if (talent == "Unnatural Ballistic Skill")
            {
                bpCost = 60;
            }
            else if (talent == "Unnatural Cunning")
            {
                bpCost = 60;
            }
            else if (talent == "Unnatural Deception")
            {
                bpCost = 60;
            }
            else if (talent == "Unnatural Insight")
            {
                bpCost = 60;
            }
            else if (talent == "Unnatural Intimidation")
            {
                bpCost = 60;
            }
            else if (talent == "Unnatural Investigation")
            {
                bpCost = 60;
            }
            else if (talent == "Unnatural Leadership")
            {
                bpCost = 60;
            }
            else if (talent == "Unnatural Medicae")
            {
                bpCost = 60;
            }
            else if (talent == "Unnatural Persuasion")
            {
                bpCost = 60;
            }
            else if (talent == "Unnatural Pilot")
            {
                bpCost = 60;
            }
            else if (talent == "Unnatural Psychic Mastery")
            {
                bpCost = 60;
            }
            else if (talent == "Unnatural Scholar")
            {
                bpCost = 60;
            }
            else if (talent == "Unnatural Stealth")
            {
                bpCost = 60;
            }
            else if (talent == "Unnatural Survival")
            {
                bpCost = 60;
            }
            else if (talent == "Unnatural Tech")
            {
                bpCost = 60;
            }
            else if (talent == "Unnatural Weapon Skill")
            {
                bpCost = 60;
            }
            else if (talent == "Unquestioning Faith")
            {
                bpCost = 20;
            }
            else
            {
                bpCost = 0;
            }
        }

    }
}
