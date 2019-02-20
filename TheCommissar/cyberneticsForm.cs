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
    public partial class cyberneticsForm : Form
    {
        Tuple<string, string, string> returnedAug;
        public cyberneticsForm()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void augSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = augSelectBox.SelectedItem.ToString();
            var result = getAugDetails(curItem);
            augRaceLabel.Text = result.Item2;
            augDetailsLabel.Text = result.Item3;
            returnedAug = result;
            //bpCostLabel.Text = "BP Cost: " + Convert.ToString(bpCost);
        }

        public string returnAugDetails()
        {
            string result = augSelectBox.SelectedItem.ToString();
            return result;
        }

        public Tuple<string, string, string> getAugDetails(string SelectedAug)
        {
            Tuple<string, string, string> result = new Tuple<string, string, string>("", "", "");
            string aug = SelectedAug;
            string race;
            string details;
            
            if (aug == "Bionic Reconstruction")
            {
                race = "Race: Human";
                details = "Details: Restores lost body parts" + Environment.NewLine + Environment.NewLine + "Value: Varies, 2-5 (P.313 CRB)";
            }
            else if (aug == "Augmetic Arms")
            {
                race = "Race: Human";
                details = "Details: +1 Strength for melee attacks, stackable to 2" + Environment.NewLine + Environment.NewLine + "Value: 4 (Rare)";
            }
            else if (aug == "Auger Eye")
            {
                race = "Race: Human";
                details = "Details: +1d Sight Awareness" + Environment.NewLine + Environment.NewLine + "Value: 6 (Uncommon)";
            }
            else if (aug == "Night's Eye")
            {
                race = "Race: Human";
                details = "Details: Immune to Darkness and Fog" + Environment.NewLine + Environment.NewLine + "Value: 6 (Uncommon)";
            }
            else if (aug == "Pict Recorder Eye")
            {
                race = "Race: Human";
                details = "Details: Record pictures of 1 hour of video" + Environment.NewLine + Environment.NewLine + "Value: 6 (Uncommon)";
            }
            else if (aug == "Reticule Eye")
            {
                race = "Race: Human";
                details = "Details: +1d Ballistic Skill tests" + Environment.NewLine + Environment.NewLine + "Value: 6 (Uncommon)";
            }
            else if (aug == "Telescopic Eye")
            {
                race = "Race: Human";
                details = "Details: No Sight Awareness penalties for distance" + Environment.NewLine + Environment.NewLine + "Value: 6 (Uncommon)";
            }
            else if (aug == "Augmetic Legs (Pair)")
            {
                race = "Race: Human";
                details = "Details: +2 Speed and Jump Distance" + Environment.NewLine + Environment.NewLine + "Value: 4 (Rare)";
            }
            else if (aug == "Augmetic Respirator")
            {
                race = "Race: Human";
                details = "Details: +1d to Toxin resist, X2 Breath Holding" + Environment.NewLine + Environment.NewLine + "Value: 5 (Rare)";
            }
            else if (aug == "Augmetic Viscera")
            {
                race = "Race: Human";
                details = "Details: +1 Wound, +1 Toughness" + Environment.NewLine + Environment.NewLine + "Value: 5 (Very Rare)";
            }
            else if (aug == "Auger Array")
            {
                race = "Race: Human";
                details = "Details: Internal Auspec or Diagnostor (P.306, 308), Max 2" + Environment.NewLine + Environment.NewLine + "Value: 4 (Rare)";
            }
            else if (aug == "Autodogmatic Cortex")
            {
                race = "Race: Human";
                details = "Details: +1 Willpower" + Environment.NewLine + Environment.NewLine + "Value: 6 (Very Rare)";
            }
            else if (aug == "Cardioproxy")
            {
                race = "Race: Human";
                details = "Details: +1 Toughness, +1 Defiance" + Environment.NewLine + Environment.NewLine + "Value: 6 (Unique)";
            }
            else if (aug == "Cortex Implant")
            {
                race = "Race: Human";
                details = "Details: +1 Intellect" + Environment.NewLine + Environment.NewLine + "Value: 7 (Very Rare)";
            }
            else if (aug == "Ballistic Mechadendrite")
            {
                race = "Race: Human";
                details = "Details: Implanted Laspistol (P.282)" + Environment.NewLine + Environment.NewLine + "Value: 5 (Very Rare)";
            }
            else if (aug == "Exploration Mechadendrite")
            {
                race = "Race: Human";
                details = "Details: +1d Navigate and Track (Survival)" + Environment.NewLine + Environment.NewLine + "Value: 5 (Very Rare)";
            }
            else if (aug == "Medicae Mechadendrite")
            {
                race = "Race: Human";
                details = "Details: +1d Medicae Tests" + Environment.NewLine + Environment.NewLine + "Value: 5 (Very Rare)";
            }
            else if (aug == "Optical Mechadendrite")
            {
                race = "Race: Human";
                details = "Details: +1d Awareness tests, contains a microscope" + Environment.NewLine + Environment.NewLine + "Value: 5 (Very Rare)";
            }
            else if (aug == "Servo-Arm Mechadendrite")
            {
                race = "Race: Human";
                details = "Details: +4d Strenght for lifting, carry, etc. Can prevent" + Environment.NewLine + "knockdown using free action." + Environment.NewLine + Environment.NewLine +
                    "Melee Combat Stats: 6+2ED, AP-3," + Environment.NewLine + "Range 1m (M), Unweildy 2" + Environment.NewLine + Environment.NewLine + "Value: 5 (Very Rare)";
            }
            else if (aug == "Utility Mechadendrite")
            {
                race = "Race: Human";
                details = "Details: +1d Tech tests" + Environment.NewLine + Environment.NewLine + "Value: 5 (Very Rare)";
            }
            else if (aug == "Mind Impulse Unit")
            {
                race = "Race: Human";
                details = "Details: +1d to Skill tests for machine operation," + Environment.NewLine + "after interface established" + Environment.NewLine + Environment.NewLine + "Value: 5 (Rare)";
            }
            else if (aug == "Neuroplastic Psychosectemy")
            {
                race = "Race: Human";
                details = "Details: +1 Intellect, +1 Willpower, -2 Fellowship" + Environment.NewLine + Environment.NewLine + "Value: 7 (Unique)";
            }
            else if (aug == "Reflex Catalyst")
            {
                race = "Race: Human";
                details = "Details: +1 Initiative" + Environment.NewLine + Environment.NewLine + "Value: 6 (Very Rare)";
            }
            else if (aug == "Sinew Armature")
            {
                race = "Race: Human";
                details = "Details: +1 Strength" + Environment.NewLine + Environment.NewLine + "Value: 6 (Very Rare)";
            }
            else if (aug == "Sub-Dermal Armor")
            {
                race = "Race: Human";
                details = "Details: +1 Armor. Stacks with other Armor" + Environment.NewLine + Environment.NewLine + "Value: 4 (Rare)";
            }
            else if (aug == "Weapon Implant")
            {
                race = "Race: Human";
                details = "Details: Implanted Weapon. See P.316 for restrictions" + Environment.NewLine + Environment.NewLine + "Value: 3 + Weapon Value (Rare or weapon rarity)";
            }
            else if (aug == "Iron Gob")
            {
                race = "Race: Ork";
                details = "Details: +1 Armor (stackable), +1d Intimidation," + Environment.NewLine + Environment.NewLine + "Melee Bite 6+2ED" + Environment.NewLine + Environment.NewLine + "Value: 3 (Rare)";
            }
            else if (aug == "Iron Gutz")
            {
                race = "Race: Ork";
                details = "Details: +2d resist ingested poisons, Automatic" + Environment.NewLine + "Survival (Food) success" + Environment.NewLine + Environment.NewLine + "Value: 5 (Very Rare)";
            }
            else if (aug == "Rebuilt Cranium")
            {
                race = "Race: Ork";
                details = "Details: +1d3 Intellect, see P.317 for full rules" + Environment.NewLine + Environment.NewLine + "Value: 6 (Very Rare)";
            }
            else if (aug == "Eyes of the Crone")
            {
                race = "Race: Eldar";
                details = "Details: Pick 2 augmetic eye bonuses. See P.317" + Environment.NewLine + Environment.NewLine + "Value: 5 (Very Rare)";
            }
            else if (aug == "Heart of Vaul")
            {
                race = "Race: Eldar";
                details = "Details: +1 Defence, +1 Armor (stackable)" + Environment.NewLine + Environment.NewLine + "Value: 7 (Unique)";
            }
            else
            {
                aug = "";
                race = "";
                details = "";
            }
            result = Tuple.Create(aug, race, details);
            return result;
        }

        private void cyberneticsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
