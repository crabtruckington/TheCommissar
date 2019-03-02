using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace TheCommissar
{
    public partial class equipForm : Form
    {
        
        List<string> rangedWeaponsList = new List<string>();
        List<string> meleeWeaponsList = new List<string>();
        List<string> armorList = new List<string>();
        List<string> weaponModList = new List<string>();
        List<string> toolsList = new List<string>();
        List<string> unfilteredEquipList = new List<string>();
        

        public class equipmentObject
        {
            public string name { get; set; }
            public string damage { get; set; }
            public string ap { get; set; }
            public string range { get; set; }
            public string salvo { get; set; }
            public string armor { get; set; }
            public string value { get; set; }
            public string keywords { get; set; }
            public string traits { get; set; }
            public string type { get; set; }
        }

        public equipForm(int type)
        {
            InitializeComponent();

            equipDetailsLabel.Text = "";

            if (type == 0)
            {
                equipBoxFilter.SelectedIndex = 0;
                createEquipLists();
                updateEquipSelections();
            }
            if (type == 1)
            {
                equipBoxFilter.Items.Clear();
                equipBoxFilter.Items.Add("Weapon Mods");
                equipBoxFilter.SelectedIndex = 0;
                equipBoxFilter.Enabled = false;
                createEquipLists();
                updateEquipSelections();
            }
        }

        private void equipSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //55 length
            //result = Tuple.Create(Tuple.Create(name, damage, ap, range, salvo), Tuple.Create(armor, value, keywords, traits));
            string curItem = equipSelectBox.SelectedItem.ToString();
            var result = getEquipValues(curItem);

            equipDetailsLabel.Text = "";

            equipDetailsLabel.Text += result.Item1.Item2 + Environment.NewLine + Environment.NewLine +
                                      result.Item1.Item3 + Environment.NewLine + Environment.NewLine +
                                      result.Item1.Item4 + Environment.NewLine + Environment.NewLine +
                                      result.Item1.Item5 + Environment.NewLine + Environment.NewLine +
                                      result.Item2.Item1 + Environment.NewLine + Environment.NewLine +
                                      result.Item2.Item2 + Environment.NewLine + Environment.NewLine +
                                      result.Item2.Item3 + Environment.NewLine + Environment.NewLine +
                                      result.Item2.Item4;

            //equipDamageLabel.Text = result.Item1.Item2;
            //equipAPLabel.Text = result.Item1.Item3;
            //equipRangeLabel.Text = result.Item1.Item4;
            //equipSalvoLabel.Text = result.Item1.Item5;
            //equipArmorRatingLabel.Text = result.Item2.Item1;
            //equipValueLabel.Text = result.Item2.Item2;
            //equipKeywordsLabel.Text = result.Item2.Item3;
            //equipTraitsLabel.Text = result.Item2.Item4;
        }

        private void addEquipButton_Click(object sender, EventArgs e)
        {

        }

        public string returnEquipDetails()
        {
            string result = equipSelectBox.SelectedItem.ToString();
            return result;
        }

        private void equipSearchBox_TextChanged(object sender, EventArgs e)
        {

            if (equipSearchBox.Text.Length > 0)
            {
                List<string> filteredEquipList = new List<string>();
                string searchText = equipSearchBox.Text;

                equipSelectBox.Items.Clear();
                filteredEquipList = unfilteredEquipList.Where(x => x.IndexOf(searchText, StringComparison.InvariantCultureIgnoreCase) >= 0).ToList();

                foreach (string item in filteredEquipList)
                {
                    equipSelectBox.Items.Add(item);
                }

            }
            else
            {
                updateEquipSelections();
            }

        }


        private void equipBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateEquipSelections();
            equipSearchBox.Text = "";
        }


        public Tuple<Tuple<string, string, string, string, string>, Tuple<string, string, string, string, string>> getEquipValues(string Equip)
        {
            Tuple<Tuple<string, string, string, string, string>, Tuple<string, string, string, string, string>> result;
            string name = Equip;
            string damage;
            string ap;
            string range;
            string salvo;
            string armor;
            string value;
            string keywords;
            string traits;
            string type;



            // add type value
            if (name == "Assault Bolter")
            {
                damage = "Damage: 12 + 2ED";
                ap = "AP: -1";
                range = "Range: 36m";
                salvo = "Salvo: 3";
                armor = "Armor: N/A";
                value = "Value: 8 (Very Rare)";
                keywords = "Keywords: Bolt, Imperium, Adeptus\u00A0Astartes, Primaris";
                traits = "Traits: Assault, Brutal";
                type = "ranged";
            }
            else if (name == "Bolt Rifle")
            {
                damage = "Damage: 10 + 1ED";
                ap = "AP: -1";
                range = "Range: 60m";
                salvo = "Salvo: 2";
                armor = "Armor: N/A";
                value = "Value: 7 (Very Rare)";
                keywords = "Keywords: Bolt, Imperium, Adeptus\u00A0Astartes, Primaris";
                traits = "Traits: Brutal, Rapid Fire(2)";
                type = "ranged";
            }
            else if (name == "Bolt Pistol")
            {
                damage = "Damage: 10 + 1ED";
                ap = "AP: 0";
                range = "Range: 20m";
                salvo = "Salvo: 1";
                armor = "Armor: N/A";
                value = "Value: 4 (Uncommon)";
                keywords = "Keywords: Bolt, Imperium";
                traits = "Traits: Brutal, Pistol";
                type = "ranged";
            }
            else if (name == "Boltgun")
            {
                damage = "Damage: 10 + 1ED";
                ap = "AP: 0";
                range = "Range: 40m";
                salvo = "Salvo: 2";
                armor = "Armor: N/A";
                value = "Value: 4 (Uncommon)";
                keywords = "Keywords: Bolt, Imperium";
                traits = "Traits: Brutal, Rapid Fire(2)";
                type = "ranged";
            }
            else if (name == "Heavy Bolter")
            {
                damage = "Damage: 12 + 2ED";
                ap = "AP: -1";
                range = "Range: 60m";
                salvo = "Salvo: 3";
                armor = "Armor: N/A";
                value = "Value: 6 (Uncommon)";
                keywords = "Keywords: Bolt, Imperium";
                traits = "Traits: Brutal, Heavy";
                type = "ranged";
            }
            else if (name == "Heavy Bolt Pistol")
            {
                damage = "Damage: 10 + 1ED";
                ap = "AP: -1";
                range = "Range: 24m";
                salvo = "Salvo: 1";
                armor = "Armor: N/A";
                value = "Value: 7 (Very Rare)";
                keywords = "Keywords: Bolt, Imperium, Adeptus\u00A0Astartes, Primaris";
                traits = "Traits: Brutal, Pistol";
                type = "ranged";
            }
            else if (name == "Storm Bolter")
            {
                damage = "Damage: 10 + 1ED";
                ap = "AP: 0";
                range = "Range: 40m";
                salvo = "Salvo: 4";
                armor = "Armor: N/A";
                value = "Value: 6 (Rare)";
                keywords = "Keywords: Bolt, Imperium";
                traits = "Traits: Brutal, Rapid Fire (2)";
                type = "ranged";
            }
            else if (name == "Flamer")
            {
                damage = "Damage: 10 + 1ED";
                ap = "AP: 0";
                range = "Range: 16m";
                salvo = "Salvo: 1";
                armor = "Armor: N/A";
                value = "Value: 5 (Uncommon)";
                keywords = "Keywords: Fire, Imperium";
                traits = "Traits: Assault, Blast\u00A0(Medium), Blaze, Spread";
                type = "ranged";
            }
            else if (name == "Hand Flamer")
            {
                damage = "Damage: 7 + 1ED";
                ap = "AP: 0";
                range = "Range: 12m";
                salvo = "Salvo: 1";
                armor = "Armor: N/A";
                value = "Value: 5 (Rare)";
                keywords = "Keywords: Fire, Imperium";
                traits = "Traits: Blast\u00A0(Small), Blaze, Pistol, Spread";
                type = "ranged";
            }
            else if (name == "Heavy Flamer")
            {
                damage = "Damage: 12 + 2ED";
                ap = "AP: -1";
                range = "Range: 16m";
                salvo = "Salvo: 2";
                armor = "Armor: N/A";
                value = "Value: 5 (Rare)";
                keywords = "Keywords: Fire Imperium";
                traits = "Traits: Blast\u00A0(Large), Blaze, Heavy, Spread";
                type = "ranged";
            }
            else if (name == "Duelling Laspistol")
            {
                damage = "Damage: 10 + 1ED";
                ap = "AP: 0";
                range = "Range: 24m";
                salvo = "Salvo: 1";
                armor = "Armor: N/A";
                value = "Value: 6 (Very Rare)";
                keywords = "Keywords: Las, Imperium";
                traits = "Traits: Pistol";
                type = "ranged";
            }
            else if (name == "Hot-Shot Lasgun")
            {
                damage = "Damage: 7 + 1ED";
                ap = "AP: -2";
                range = "Range: 36m";
                salvo = "Salvo: 2";
                armor = "Armor: N/A";
                value = "Value: 6 (Very Rare)";
                keywords = "Keywords: Las, Imperium, Astra\u00A0Militarum";
                traits = "Traits: Rapid Fire(1), Steadfast";
                type = "ranged";
            }
            else if (name == "Hot-Shot Laspistol")
            {
                damage = "Damage: 7 + 1ED";
                ap = "AP: -2";
                range = "Range: 12m";
                salvo = "Salvo: 1";
                armor = "Armor: N/A";
                value = "Value: 6 (Very Rare)";
                keywords = "Keywords: Las, Imperium, Astra\u00A0Militarum";
                traits = "Traits: Pistol, Steadfast";
                type = "ranged";
            }
            else if (name == "Hot-Shot Volley Gun")
            {
                damage = "Damage: 10 + 1ED";
                ap = "AP: -2";
                range = "Range: 48m";
                salvo = "Salvo: 4";
                armor = "Armor: N/A";
                value = "Value: 6 (Very Rare)";
                keywords = "Keywords: Las, Imperium, Astra\u00A0Militarum";
                traits = "Traits: Heavy, Steadfast";
                type = "ranged";
            }
            else if (name == "Lascannon")
            {
                damage = "Damage: 18 + 3ED";
                ap = "AP: -3";
                range = "Range: 150m";
                salvo = "Salvo: 1";
                armor = "Armor: N/A";
                value = "Value: 9 (Uncommon)";
                keywords = "Keywords: Las, Imperium";
                traits = "Traits: Heavy, Steadfast";
                type = "ranged";
            }
            else if (name == "Lasgun")
            {
                damage = "Damage: 7 + 1ED";
                ap = "AP: 0";
                range = "Range: 48m";
                salvo = "Salvo: 2";
                armor = "Armor: N/A";
                value = "Value: 3 (Common)";
                keywords = "Keywords: Las, Imperium";
                traits = "Traits: Rapid\u00A0Fire(1), Steadfast";
                type = "ranged";
            }
            else if (name == "Laspistol")
            {
                damage = "Damage: 7 + 1ED";
                ap = "AP: 0";
                range = "Range: 24m";
                salvo = "Salvo: 1";
                armor = "Armor: N/A";
                value = "Value: 3 (Common)";
                keywords = "Keywords: Las, Imperium";
                traits = "Traits: Pistol, Steadfast";
                type = "ranged";
            }
            else if (name == "Long Las")
            {
                damage = "Damage: 10 + 1ED";
                ap = "AP: 0";
                range = "Range: 140m";
                salvo = "Salvo: 0";
                armor = "Armor: N/A";
                value = "Value: 6 (Uncommon)";
                keywords = "Keywords: Las, Imperium, Astra\u00A0Militarum";
                traits = "Traits: Sniper(1), Steadfast";
                type = "ranged";
            }
            else if (name == "Inferno Pistol")
            {
                damage = "Damage: 16 + 1ED";
                ap = "AP: -4";
                range = "Range: 12m";
                salvo = "Salvo: 1";
                armor = "Armor: N/A";
                value = "Value: 6 (Very Rare)";
                keywords = "Keywords: Melta, Imperium, Adepta\u00A0Sororitas, Adeptus\u00A0Astartes";
                traits = "Traits: Melta, Pistol";
                type = "ranged";
            }
            else if (name == "Meltagun")
            {
                damage = "Damage: 16 + 2ED";
                ap = "AP: -4";
                range = "Range: 24m";
                salvo = "Salvo: 1";
                armor = "Armor: N/A";
                value = "Value: 6 (Uncommon)";
                keywords = "Keywords: Melta, Imperium";
                traits = "Traits: Assault, Melta";
                type = "ranged";
            }
            else if (name == "Multi-Melta")
            {
                damage = "Damage: 16 + 3ED";
                ap = "AP: -4";
                range = "Range: 48m";
                salvo = "Salvo: 1";
                armor = "Armor: N/A";
                value = "Value: 7 (Rare)";
                keywords = "Keywords: Melta, Imperium";
                traits = "Traits: Heavy, Melta";
                type = "ranged";
            }
            else if (name == "Plasma Cannon")
            {
                damage = "Damage: 15 + 2ED";
                ap = "AP: -3";
                range = "Range: 72m";
                salvo = "Salvo: 3";
                armor = "Armor: N/A";
                value = "Value: 7 (Very Rare)";
                keywords = "Keywords: Plasma, Imperium";
                traits = "Traits: Heavy, Supercharge";
                type = "ranged";
            }
            else if (name == "Plasma Gun")
            {
                damage = "Damage: 15 + 1ED";
                ap = "AP: -3";
                range = "Range: 48m";
                salvo = "Salvo: 2";
                armor = "Armor: N/A";
                value = "Value: 6 (Rare)";
                keywords = "Keywords: Plasma, Imperium";
                traits = "Traits: Rapid Fire(1), Supercharge";
                type = "ranged";
            }
            else if (name == "Plasma Pistol")
            {
                damage = "Damage: 15 + 1ED";
                ap = "AP: -3";
                range = "Range: 24m";
                salvo = "Salvo: 1";
                armor = "Armor: N/A";
                value = "Value: 6 (Rare)";
                keywords = "Keywords: Plasma, Imperium";
                traits = "Traits: Pistol, Supercharge";
                type = "ranged";
            }
            else if (name == "Assault Cannon")
            {
                damage = "Damage: 14 + 2ED";
                ap = "AP: -1";
                range = "Range: 48m";
                salvo = "Salvo: 6";
                armor = "Armor: N/A";
                value = "Value: 6 (Uncommon)";
                keywords = "Keywords: Projectile, Imperium, Adeptus\u00A0Astartes";
                traits = "Traits: Heavy";
                type = "ranged";
            }
            else if (name == "Astartes Shotgun")
            {
                damage = "Damage: 10 + 1ED";
                ap = "AP: 0";
                range = "Range: 24m";
                salvo = "Salvo: 2";
                armor = "Armor: N/A";
                value = "Value: 7 (Rare)";
                keywords = "Keywords: Projectile, Imperium, Adeptus\u00A0Astartes";
                traits = "Traits: Assault, Spread, Steadfast";
                type = "ranged";
            }
            else if (name == "Astartes Sniper Rifle")
            {
                damage = "Damage: 10 + 1ED";
                ap = "AP: 0";
                range = "Range: 150m";
                salvo = "Salvo: 0";
                armor = "Armor: N/A";
                value = "Value: 6 (Uncommon)";
                keywords = "Keywords: Projectile, Imperium, Adeptus\u00A0Astartes";
                traits = "Traits: Sniper(2)";
                type = "ranged";
            }
            else if (name == "Autocannon")
            {
                damage = "Damage: 16 + 1ED";
                ap = "AP: -1";
                range = "Range: 96m";
                salvo = "Salvo: 3";
                armor = "Armor: N/A";
                value = "Value: 5 (Common)";
                keywords = "Keywords: Projectile, Imperium";
                traits = "Traits: Heavy";
                type = "ranged";
            }
            else if (name == "Autogun")
            {
                damage = "Damage: 7 + 1ED";
                ap = "AP: 0";
                range = "Range: 48m";
                salvo = "Salvo: 3";
                armor = "Armor: N/A";
                value = "Value: 3 (Common)";
                keywords = "Keywords: Projectile, Imperium, Scum";
                traits = "Traits: Rapid Fire(1)";
                type = "ranged";
            }
            else if (name == "Autopistol")
            {
                damage = "Damage: 7 + 1ED";
                ap = "AP: 0";
                range = "Range: 20m";
                salvo = "Salvo: 2";
                armor = "Armor: N/A";
                value = "Value: 3 (Common)";
                keywords = "Keywords: Projectile, Imperium, Scum";
                traits = "Traits: Pistol";
                type = "ranged";
            }
            else if (name == "Combat Shotgun")
            {
                damage = "Damage: 9 + 1ED";
                ap = "AP: 0";
                range = "Range: 24m";
                salvo = "Salvo: 2";
                armor = "Armor: N/A";
                value = "Value: 3 (Uncommon)";
                keywords = "Keywords: Projectile, Imperium";
                traits = "Traits: Assault, Rapid\u00A0Fire(1), Spread";
                type = "ranged";
            }
            else if (name == "Hand Cannon")
            {
                damage = "Damage: 9 + 1ED";
                ap = "AP: 0";
                range = "Range: 20m";
                salvo = "Salvo: 1";
                armor = "Armor: N/A";
                value = "Value: 4 (Common)";
                keywords = "Keywords: Projectile, Imperium, Scum";
                traits = "Traits: Pistol";
                type = "ranged";
            }
            else if (name == "Heavy Stubber")
            {
                damage = "Damage: 10 + 2ED";
                ap = "AP: 0";
                range = "Range: 72m";
                salvo = "Salvo: 3";
                armor = "Armor: N/A";
                value = "Value: 5 (Uncommon)";
                keywords = "Keywords: Projectile, Imperium, Scum";
                traits = "Traits: Heavy";
                type = "ranged";
            }
            else if (name == "Shotgun")
            {
                damage = "Damage: 8 + 1ED";
                ap = "AP: 0";
                range = "Range: 20m";
                salvo = "Salvo: 1";
                armor = "Armor: N/A";
                value = "Value: 3 (Common)";
                keywords = "Keywords: Projectile, Imperium, Scum";
                traits = "Traits: Assault, Spread";
                type = "ranged";
            }
            else if (name == "Stubber")
            {
                damage = "Damage: 7 + 1ED";
                ap = "AP: 0";
                range = "Range: 20m";
                salvo = "Salvo: 1";
                armor = "Armor: N/A";
                value = "Value: 2 (Common)";
                keywords = "Keywords: Projectile, Imperium, Scum";
                traits = "Traits: Pistol";
                type = "ranged";
            }
            else if (name == "Stubcannon")
            {
                damage = "Damage: 9 + 1ED";
                ap = "AP: 0";
                range = "Range: 30m";
                salvo = "Salvo: 1";
                armor = "Armor: N/A";
                value = "Value: 3 (Common)";
                keywords = "Keywords: Projectile, Imperium, Scum";
                traits = "Traits: Brutal";
                type = "ranged";
            }
            else if (name == "Cyclone Missile Launcher")
            {
                damage = "Damage: By Missile";
                ap = "AP: By Missile";
                range = "Range: 150m";
                salvo = "Salvo: 1*";
                armor = "Armor: N/A";
                value = "Value: 11 (Very Rare)";
                keywords = "Keywords: Explosive, Imperium, Adeptus\u00A0Astartes";
                traits = "Traits: Heavy";
                type = "ranged";
            }
            else if (name == "Missile Launcher")
            {
                damage = "Damage: By Missile";
                ap = "AP: By Missile";
                range = "Range: 150m";
                salvo = "Salvo: --";
                armor = "Armor: N/A";
                value = "Value: 4 (Common)";
                keywords = "Keywords: Explosive, Immperium";
                traits = "Traits: Heavy";
                type = "ranged";
            }
            else if (name == "Frag Missile")
            {
                damage = "Damage: 10 + 2ED";
                ap = "AP: 0";
                range = "Range: --";
                salvo = "Salvo: --";
                armor = "Armor: N/A";
                value = "Value: (4 Common)";
                keywords = "Keywords: Explosive, Imperium, <Any>";
                traits = "Traits: Blast (Large)";
                type = "ranged";
            }
            else if (name == "Krak Missile")
            {
                damage = "Damage: 16 + 3ED";
                ap = "AP: -2";
                range = "Range: --";
                salvo = "Salvo: --";
                armor = "Armor: N/A";
                value = "Value: 6 (Uncommon)";
                keywords = "Keywords: Explosive, Imperium";
                traits = "Traits: Blast\u00A0(Small)";
                type = "ranged";
            }
            else if (name == "Militarum\u00A0Tempestus Grenade Launcher")
            {
                damage = "Damage: By Grenade";
                ap = "AP: By Grenade";
                range = "Range: 50m";
                salvo = "Salvo: 1";
                armor = "Armor: N/A";
                value = "Value: 6 (Uncommon)";
                keywords = "Keywords: Explosive, Imperium, Astra\u00A0Militarum";
                traits = "Traits: Assault";
                type = "ranged";
            }
            else if (name == "Voss Pattern Grenade Launcher")
            {
                damage = "Damage: By Grenade";
                ap = "AP: By Grenade";
                range = "Range: 40m";
                salvo = "Salvo: 1";
                armor = "Armor: N/A";
                value = "Value: 5 (Uncommon)";
                keywords = "Keywords: Explosive, Imperium, Astra\u00A0Militarum";
                traits = "Traits: Assault";
                type = "ranged";
            }
            else if (name == "Frag Grenade")
            {
                damage = "Damage: 10 + 1ED";
                ap = "AP: 0";
                range = "Range: Strength X4 Meters or by Launcher";
                salvo = "Salvo: --";
                armor = "Armor: N/A";
                value = "Value: 2 (Common)";
                keywords = "Keywords: Explosive, Imperium";
                traits = "Traits: Blast\u00A0(Medium)";
                type = "ranged";
            }
            else if (name == "Krak Grenade")
            {
                damage = "Damage: 14 + 2ED";
                ap = "AP: -2";
                range = "Range: Strength X4 Meters or by Launcher";
                salvo = "Salvo: --";
                armor = "Armor: N/A";
                value = "Value: 4 (Uncommon)";
                keywords = "Keywords: Explosive, Imperium";
                traits = "Traits: Blast\u00A0(Small)";
                type = "ranged";
            }
            else if (name == "Plasma Grenade")
            {
                damage = "Damage: 10 + 1ED";
                ap = "AP: -1";
                range = "Range: Strength X4 Meters or by Launcher";
                salvo = "Salvo: --";
                armor = "Armor: N/A";
                value = "Value: 7 (Very Rare)";
                keywords = "Keywords: Explosive, Aeldari";
                traits = "Traits: Blast\u00A0(Medium)";
                type = "ranged";
            }
            else if (name == "Arc Pistol")
            {
                damage = "Damage: 14 + 1ED";
                ap = "AP: -1";
                range = "Range: 24m";
                salvo = "Salvo: 1";
                armor = "Armor: N/A";
                value = "Value: 5 (Rare)";
                keywords = "Keywords: Arc, Adeptus\u00A0Mechanicus";
                traits = "Traits: Arc(2), Pistol";
                type = "ranged";
            }
            else if (name == "Arc Rifle")
            {
                damage = "Damage: 14 + 1ED";
                ap = "AP: -1";
                range = "Range: 48m";
                salvo = "Salvo: 2";
                armor = "Armor: N/A";
                value = "Value: 6 (Rare)";
                keywords = "Keywords: Arc, Adeptus\u00A0Mechanicus";
                traits = "Traits: Arc(2), Rapid Fire(1)";
                type = "ranged";
            }
            else if (name == "Galvanic Rifle")
            {
                damage = "Damage: 10 + 1ED";
                ap = "AP: 0";
                range = "Range: 60m";
                salvo = "Salvo: 2";
                armor = "Armor: N/A";
                value = "Value: 5 (Rare)";
                keywords = "Keywords: Projectile, Adeptus\u00A0Mechanicus";
                traits = "Traits: Rapid Fire(1), Penetrating(1)";
                type = "ranged";
            }
            else if (name == "Radium Carbine")
            {
                damage = "Damage: 7 + 1ED";
                ap = "AP: 0";
                range = "Range: 36m";
                salvo = "Salvo: 3";
                armor = "Armor: N/A";
                value = "Value: 6 (Very Rare)";
                keywords = "Keywords: Projectile, Adeptus\u00A0Mechanicus";
                traits = "Traits: Assault, Rad(2)";
                type = "ranged";
            }
            else if (name == "Radium Pistol")
            {
                damage = "Damage: 7 + 1ED";
                ap = "AP: 0";
                range = "Range: 24m";
                salvo = "Salvo: 1";
                armor = "Armor: N/A";
                value = "Value: 6 (Rare)";
                keywords = "Keywords: Projectile, Adeptus\u00A0Mechanicus";
                traits = "Traits: Pistol, Rad(2)";
                type = "ranged";
            }
            else if (name == "Fusion Gun")
            {
                damage = "Damage: 16 + 2ED";
                ap = "AP: -4";
                range = "Range: 24m";
                salvo = "Salvo: 1";
                armor = "Armor: N/A";
                value = "Value: 6 (Rare)";
                keywords = "Keywords: Melta, Aeldari";
                traits = "Traits: Assault, Melta";
                type = "ranged";
            }
            else if (name == "Lasblaster")
            {
                damage = "Damage: 7 + 1ED";
                ap = "AP: 0";
                range = "Range: 48m";
                salvo = "Salvo: 4";
                armor = "Armor: N/A";
                value = "Value: 5 (Very Rare)";
                keywords = "Keywords: Las, Aeldari";
                traits = "Traits: Assault";
                type = "ranged";
            }
            else if (name == "Ranger Long Rifle")
            {
                damage = "Damage: 10 + 1ED";
                ap = "AP: 0";
                range = "Range: 150m";
                salvo = "Salvo: 0";
                armor = "Armor: N/A";
                value = "Value: 7 (Very Rare)";
                keywords = "Keywords: Las, Aeldari";
                traits = "Traits: Sniper(2)";
                type = "ranged";
            }
            else if (name == "Shuriken Catapult")
            {
                damage = "Damage: 10 + 1ED";
                ap = "AP: 0";
                range = "Range: 24m";
                salvo = "Salvo: 3";
                armor = "Armor: N/A";
                value = "Value: 6 (Rare)";
                keywords = "Keywords: Shuriken, Aeldari, Asuryani";
                traits = "Traits: Assault, Penetrating(3)";
                type = "ranged";
            }
            else if (name == "Shuriken Pistol")
            {
                damage = "Damage: 10 + 1ED";
                ap = "AP: 0";
                range = "Range: 24m";
                salvo = "Salvo: 2";
                armor = "Armor: N/A";
                value = "Value: 6 (Rare)";
                keywords = "Keywords: Shuriken, Aeldari, Asuryani";
                traits = "Traits: Pistol, Penetrating(3)";
                type = "ranged";
            }
            else if (name == "Big Shoota")
            {
                damage = "Damage: 12 + 2ED";
                ap = "AP: 0";
                range = "Range: 72m";
                salvo = "Salvo: 3";
                armor = "Armor: N/A";
                value = "Value: 5 (Uncommon)";
                keywords = "Keywords: Projectile, Ork";
                traits = "Traits: Assault, Waaagh!";
                type = "ranged";
            }
            else if (name == "Burna")
            {
                damage = "Damage: 10 + 1ED";
                ap = "AP: 0";
                range = "Range: 16m";
                salvo = "Salvo: 1";
                armor = "Armor: N/A";
                value = "Value: 5 (Uncommon)";
                keywords = "Keywords: Fire, Ork";
                traits = "Traits: Assault, Blast\u00A0(Small), Blaze, Spread";
                type = "ranged";
            }
            else if (name == "Rokkit Launcha")
            {
                damage = "Damage: 16 + (1d3 + 1ED)";
                ap = "AP: -2";
                range = "Range: 48m";
                salvo = "Salvo: --";
                armor = "Armor: N/A";
                value = "Value: 7 (Rare)";
                keywords = "Keywords: Explosive, Ork";
                traits = "Traits: Blast\u00A0(Small)";
                type = "ranged";
            }
            else if (name == "Shoota")
            {
                damage = "Damage: 10 + 1ED";
                ap = "AP: 0";
                range = "Range: 48m";
                salvo = "Salvo: 2";
                armor = "Armor: N/A";
                value = "Value: 4 (Uncommon)";
                keywords = "Keywords: Projectile, Ork";
                traits = "Traits: Assault, Waaagh!";
                type = "ranged";
            }
            else if (name == "Slugga")
            {
                damage = "Damage: 10 + 1ED";
                ap = "AP: 0";
                range = "Range: 24m";
                salvo = "Salvo: 1";
                armor = "Armor: N/A";
                value = "Value: 3 (Common)";
                keywords = "Keywords: Projectile, Ork";
                traits = "Traits: Pistol, Waaagh!";
                type = "ranged";
            }
            else if (name == "Snazzgun")
            {
                damage = "Damage: 12 + 2ED";
                ap = "AP: -2";
                range = "Range: 48m";
                salvo = "Salvo: 3";
                armor = "Armor: N/A";
                value = "Value: 8 (Unique)";
                keywords = "Keywords: Ork";
                traits = "Traits: Heavy* (See P.288)";
                type = "ranged";
            }
            else if (name == "Stikkbomb")
            {
                damage = "Damage: 7 + 1ED";
                ap = "AP: 0";
                range = "Range: Strength\u00A0X4\u00A0Meters or By\u00A0Launcher";
                salvo = "Salvo: --";
                armor = "Armor: N/A";
                value = "Value: 2 (Uncommon)";
                keywords = "Keywords: Explosive, Ork";
                traits = "Traits: Blast\u00A0(Medium)";
                type = "ranged";
            }
            else if (name == "Gauss Rifle")
            {
                damage = "Damage: 10 + 1ED";
                ap = "AP: -2";
                range = "Range: 24m";
                salvo = "Salvo: 1";
                armor = "Armor: N/A";
                value = "Value: 2 (Uncommon)";
                keywords = "Keywords: Plasma, Necron";
                traits = "Traits: Brutal";
                type = "ranged";
            }

            //melee weapons
            else if (name == "Astartes Combat Knife")
            {
                damage = "Damage: 3 + 1ED";
                ap = "AP: 0";
                range = "Range: --";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 3 (Uncommon)";
                keywords = "Keywords: Blade, Imperium, Adeptus\u00A0Astartes";
                traits = "Traits: Steadfast";
                type = "melee";
            }
            else if (name == "Industrial Bludgeon")
            {
                damage = "Damage: 4 + 2ED";
                ap = "AP: 0";
                range = "Range: --";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 3 (Uncommon)";
                keywords = "Keywords: Imperium, Ork, Scum, <Any>";
                traits = "Traits: Brutal, Unwieldy(1)";
                type = "melee";
            }
            else if (name == "Knife")
            {
                damage = "Damage: 2 + 1ED";
                ap = "AP: 0";
                range = "Range: --";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 2 (Common)";
                keywords = "Keywords: Blade, Imperium, Aeldari, Ork, Scum, <Any>";
                traits = "Traits: None";
                type = "melee";
            }
            else if (name == "Mono Knife")
            {
                damage = "Damage: 3 + 2ED";
                ap = "AP: -1";
                range = "Range: --";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 3 (Uncommon)";
                keywords = "Keywords: Blade, Imperium, Scum";
                traits = "Traits: Penetrating(1)";
                type = "melee";
            }
            else if (name == "Psykana Mercy Blade")
            {
                damage = "Damage: 2 + 1ED";
                ap = "AP: -1";
                range = "Range: --";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 2 (Uncommon)";
                keywords = "Keywords: Blade, Imperium, Adeptus\u00A0Astra\u00A0Telepathica";
                traits = "Traits: None";
                type = "melee";
            }
            else if (name == "Sword")
            {
                damage = "Damage: 3 + 1ED";
                ap = "AP: 0";
                range = "Range: --";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 3 (Common)";
                keywords = "Keywords: Blade, Imperium, Aeldari, <Any>";
                traits = "Traits: Parry";
                type = "melee";
            }
            else if (name == "Throwing Knife")
            {
                damage = "Damage: 2 + 1ED";
                ap = "AP: 0";
                range = "Range: Strength X 4m";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 2 (Common)";
                keywords = "Keywords: Blade, Aeldari, Scum, <Any>";
                traits = "Traits: None";
                type = "melee";
            }
            else if (name == "Chain Axe")
            {
                damage = "Damage: 5 + 2ED";
                ap = "AP: 0";
                range = "Range: --";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Rare)";
                keywords = "Keywords: Chain, Chaos";
                traits = "Traits: Brutal, Penetrating(1)";
                type = "melee";
            }
            else if (name == "Chain Bayonet")
            {
                damage = "Damage: 4 + 1ED";
                ap = "AP: 0";
                range = "Range: --";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 4 (Rare)";
                keywords = "Keywords: Chain, Imperium, Chaos";
                traits = "Traits: Brutal";
                type = "melee";
            }
            else if (name == "Chain Fist")
            {
                damage = "Damage: 7 + 3ED";
                ap = "AP: -4";
                range = "Range: --";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 10 (Very Rare)";
                keywords = "Keywords: Chain, Power\u00A0Field, Imperium, Chaos, Adeptus\u00A0Astartes";
                traits = "Traits: Brutal, Unwieldy(3)";
                type = "melee";
            }
            else if (name == "Chain Sword")
            {
                damage = "Damage: 5 + 1ED";
                ap = "AP: 0";
                range = "Range: --";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Uncommon)";
                keywords = "Keywords: Chain, Aeldari, Imperium, Chaos";
                traits = "Traits: Brutal, Parry";
                type = "melee";
            }
            else if (name == "Eviscerator")
            {
                damage = "Damage: 6 + 2ED";
                ap = "AP: -4";
                range = "Range: 2m";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 6 (Rare)";
                keywords = "Keywords: Chain, Adeptus\u00A0Ministorum, Adeptus\u00A0Sororitas, Two\u2011Handed";
                traits = "Traits: Brutal, Unwieldy(2)";
                type = "melee";
            }
            else if (name == "Force Axe")
            {
                damage = "Damage: 5 + 2ED";
                ap = "AP: -2";
                range = "Range: --";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 6 (Very Rare)";
                keywords = "Keywords: Force, Imperium, Inquisition, Adeptus\u00A0Astartes";
                traits = "Traits: Force";
                type = "melee";
            }
            else if (name == "Force Hammer")
            {
                damage = "Damage: 6 + 2ED";
                ap = "AP: -3";
                range = "Range: 2m";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 7 (Very Rare)";
                keywords = "Keywords: Force, Imperium, Inquisition, Two\u2011Handed, Adeptus\u00A0Astartes";
                traits = "Traits: Force, Unwieldy(2)";
                type = "melee";
            }
            else if (name == "Force Rod")
            {
                damage = "Damage: 4 + 1ED";
                ap = "AP: -1";
                range = "Range: 2m";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 6 (Uncommon)";
                keywords = "Keywords: Force, Imperium, Inquisition, Adeptus\u00A0Astartes, Adeptus\u00A0Astra\u00A0Telepathica, Two\u2011Handed";
                traits = "Traits: Brutal, Force";
                type = "melee";
            }
            else if (name == "Force Sword")
            {
                damage = "Damage: 5 + 1ED";
                ap = "AP: -3";
                range = "Range: --";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 6 (Rare)";
                keywords = "Keywords: Force, Imperium, Inquisition, Adeptus\u00A0Astartes";
                traits = "Traits: Force, Parry";
                type = "melee";
            }
            else if (name == "Death Cult Powerblade")
            {
                damage = "Damage: 5 + 1ED";
                ap = "AP: -2";
                range = "Range: --";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 6 (Very Rare)";
                keywords = "Keywords: Power\u00A0Field, Imperium, Adeptus\u00A0Ministorum";
                traits = "Traits: Parry";
                type = "melee";
            }
            else if (name == "Omnissian Axe")
            {
                damage = "Damage: 5 + 2ED";
                ap = "AP: -2";
                range = "Range: 2m";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 6 (Very Rare)";
                keywords = "Keywords: Power\u00A0Field, Imperium, Adeptus\u00A0Mechanicus, Two\u2011Handed";
                traits = "Traits: None";
                type = "melee";
            }
            else if (name == "Power Axe")
            {
                damage = "Damage: 5 + 2ED";
                ap = "AP: -2";
                range = "Range: --";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 6 (Rare)";
                keywords = "Keywords: Power\u00A0Field, Imperium, Adeptus\u00A0Astartes, Adeptus\u00A0Mechanicus, Aeldari";
                traits = "Traits: ";
                type = "melee";
            }
            else if (name == "Power Fist")
            {
                damage = "Damage: 7 + 2ED";
                ap = "AP: -3";
                range = "Range: --";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 8 (Very Rare)";
                keywords = "Keywords: Power\u00A0Field, Imperium, Adeptus\u00A0Astartes";
                traits = "Traits: Brutal, Unwieldy(2)";
                type = "melee";
            }
            else if (name == "Power Sword")
            {
                damage = "Damage: 5 + 1ED";
                ap = "AP: -3";
                range = "Range: --";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 6 (Rare)";
                keywords = "Keywords: Power\u00A0Field, Imperium, Aeldari";
                traits = "Traits: Parry";
                type = "melee";
            }
            else if (name == "Thunder Hammer")
            {
                damage = "Damage: 8 + 3ED";
                ap = "AP: -3";
                range = "Range: 2m";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 9 (Unique)";
                keywords = "Keywords: Power\u00A0Field, Imperium, Adeptus\u00A0Astartes, Inquisition, Two\u2011Handed";
                traits = "Traits: Brutal, Unwieldy(2)";
                type = "melee";
            }
            else if (name == "Void Sabre")
            {
                damage = "Damage: 5 + 1ED";
                ap = "AP: -3";
                range = "Range: --";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 8 (Very Rare)";
                keywords = "Keywords: Power\u00A0Field, Aeldari, Anhrathe";
                traits = "Traits: Brutal, Parry";
                type = "melee";
            }
            else if (name == "Neural Whip")
            {
                damage = "Damage: 3 + 1ED";
                ap = "AP: -2";
                range = "Range: 4m";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Rare)";
                keywords = "Keywords: Exotic, Chaos, Inquisition";
                traits = "Traits: Agonizing";
                type = "melee";
            }
            else if (name == "Shock Maul")
            {
                damage = "Damage: 4 + 2ED";
                ap = "AP: -1";
                range = "Range: --";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Uncommon)";
                keywords = "Keywords: Exotic, Imperium, Adeptus\u00A0Arbites";
                traits = "Traits: Agonizing, Brutal";
                type = "melee";
            }
            else if (name == "Shock Whip")
            {
                damage = "Damage: 4 + 1ED";
                ap = "AP: 0";
                range = "Range: 4m";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Very Rare)";
                keywords = "Keywords: Exotic, Scum, <Any>";
                traits = "Traits: Agonizing, Penetrating(2)";
                type = "melee";
            }
            else if (name == "Whip")
            {
                damage = "Damage: 1 + 1ED";
                ap = "AP: 0";
                range = "Range: 4m";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 2 (Common)";
                keywords = "Keywords: Primitive, Imperium, Ork";
                traits = "Traits: Agonizing";
                type = "melee";
            }
            else if (name == "Singing Spear")
            {
                damage = "Damage: 6 + 3ED";
                ap = "AP: 0";
                range = "Range: 2m or Strength X 5m";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 11 (Unique)";
                keywords = "Keywords: Force, Aeldari, Asuryani";
                traits = "Traits: Assault, Force, Warp\u00A0Weapon";
                type = "melee";
            }
            else if (name == "Witchblade")
            {
                damage = "Damage: 6 + 3ED";
                ap = "AP: 0";
                range = "Range: --";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 9 (Very Rare)";
                keywords = "Keywords: Force, Aeldari, Asuryani";
                traits = "Traits: Force, Parry, Warp\u00A0Weapon";
                type = "melee";
            }
            else if (name == "Big Choppa")
            {
                damage = "Damage: 5 + 2ED";
                ap = "AP: -1";
                range = "Range: --";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 4 (Rare)";
                keywords = "Keywords: Blade, Ork, Two\u2011Handed";
                traits = "Traits: Waaagh!";
                type = "melee";
            }
            else if (name == "Chain Choppa")
            {
                damage = "Damage: 5 + 1ED";
                ap = "AP: 0";
                range = "Range: --";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Very Rare)";
                keywords = "Keywords: Chain, Ork";
                traits = "Traits: Brutal, Waaagh!";
                type = "melee";
            }
            else if (name == "Choppa")
            {
                damage = "Damage: 3 + 2ED";
                ap = "AP: 0";
                range = "Range: --";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 2 (Common)";
                keywords = "Keywords: Blade, Ork";
                traits = "Traits: Steadfast, Waaagh!";
                type = "melee";
            }
            else if (name == "Power Klaw")
            {
                damage = "Damage: 6 + 3ED";
                ap = "AP: -3";
                range = "Range: 2m";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 8 (Very Rare)";
                keywords = "Keywords: Power\u00A0Field, Ork";
                traits = "Traits: Brutal, Unwieldy(3)";
                type = "melee";
            }
            else if (name == "Weirdboy Staff")
            {
                damage = "Damage: 4 + 1ED";
                ap = "AP: -1";
                range = "Range: 2m";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Very Rare)";
                keywords = "Keywords: Force, Ork, Two\u2011Handed";
                traits = "Traits: Force, Waaagh!";
                type = "melee";
            }
            else if (name == "Axe Bayonet")
            {
                damage = "Damage: 2 + 1ED";
                ap = "AP: 0";
                range = "Range: --";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 3 (Uncommon)";
                keywords = "Keywords: Blade, Necron";
                traits = "Traits: None";
                type = "melee";
            }
            else if (name == "Servo-Arm Mechadendrite")
            {
                damage = "Damage: 6 + 2ED";
                ap = "AP: -3";
                range = "Range: 1m";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Very Rare)";
                keywords = "Keywords: Adeptus\u00A0Mechanicus";
                traits = "Traits: Unwieldy(2)";
                type = "melee";
            }
            //"Melee Combat Stats: 6+2ED, AP-3, Range 1m (M), Unweildy 2" + Environment.NewLine + Environment.NewLine + "Value: 5 (Very Rare)"

            //armor
            else if (name == "Bodyglove")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 2";
                value = "Value: 3 (Rare)";
                keywords = "Keywords: Light, Imperium, Adeptus\u00A0Ministorum";
                traits = "Traits: None";
                type = "armor";
            }
            else if (name == "Carapace Armour")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 4";
                value = "Value: 5 (Uncommon)";
                keywords = "Keywords: Imperium, Officio\u00A0Assassinorum, Astra\u00A0Militarum";
                traits = "Traits: Bulk(1)";
                type = "armor";
            }
            else if (name == "Flak Armour")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 3";
                value = "Value: 4 (Common)";
                keywords = "Keywords: Flak, Imperium, Astra\u00A0Militarum";
                traits = "Traits: None";
                type = "armor";
            }
            else if (name == "Flak Coat")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 3";
                value = "Value: 4 (Uncommon)";
                keywords = "Keywords: Flak Imperium, Astra\u00A0Militarum";
                traits = "Traits: None";
                type = "armor";
            }
            else if (name == "Mesh Armour")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 3";
                value = "Value: 3 (Rare)";
                keywords = "Keywords: Light, Imperium, <Any>";
                traits = "Traits: None";
                type = "armor";
            }
            else if (name == "Primitive Armour")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 2";
                value = "Value: 2 (Common)";
                keywords = "Keywords: Heavy, Primitive";
                traits = "Traits: Bulk(2)";
                type = "armor";
            }
            else if (name == "Skitarii Auto-Cuirass")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 3";
                value = "Value: 5 (Rare)";
                keywords = "Keywords: Heavy, Imperium, Adeptus\u00A0Mechanicus, Skitarii";
                traits = "Traits: None";
                type = "armor";
            }
            else if (name == "Tempestus Carapace")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 4";
                value = "Value: 6 (Very Rare)";
                keywords = "Keywords: Heavy, Imperium, Astra\u00A0Militarum, Militarum\u00A0Tempestus";
                traits = "Traits: None";
                type = "armor";
            }
            else if (name == "Heavy Power Armour")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 6";
                value = "Value: 8 (Very Rare)";
                keywords = "Keywords: Heavy, Powered, Imperium, Inquisition";
                traits = "Traits: Bulk(1), Cumbersome, Powered(3)";
                type = "armor";
            }
            else if (name == "Ignatus Power Armour")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 5";
                value = "Value: 7 (Very Rare)";
                keywords = "Keywords: Powered, Imperium, Inquisition";
                traits = "Traits: Powered(2)";
                type = "armor";
            }
            else if (name == "Light Power Armour")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 4";
                value = "Value: 6 (Very Rare)";
                keywords = "Keywords: Powered, Imperium";
                traits = "Traits: Powered(1)";
                type = "armor";
            }
            else if (name == "Sororitas Powered Armour")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 5";
                value = "Value: 6 (Very Rare)";
                keywords = "Keywords: Powered, Imperium, Adepta\u00A0Sororitas";
                traits = "Traits: Powered(2)";
                type = "armor";
            }
            else if (name == "Aquila Mk VII")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 5";
                value = "Value: 8 (Very Rare)";
                keywords = "Keywords: Powered, Imperium, Adeptus\u00A0Astartes";
                traits = "Traits: Powered(3)";
                type = "armor";
            }
            else if (name == "Scout Armour")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 4";
                value = "Value: 5 (Rare)";
                keywords = "Keywords: Imperium, Adeptus\u00A0Astartes";
                traits = "Traits: None";
                type = "armor";
            }
            else if (name == "Tacticus Mk X")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 5";
                value = "Value: 9 (Very Rare)";
                keywords = "Keywords: Powered, Imperium, Adeptus\u00A0Astartes, Primaris";
                traits = "Traits: Powered(4)";
                type = "armor";
            }
            else if (name == "Terminator Armour")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 7";
                value = "Value: 10 (Unique)";
                keywords = "Keywords: Powered, Imperium, Adeptus\u00A0Astartes";
                traits = "Traits: Powered(5), Cumbersome";
                type = "armor";
            }
            else if (name == "Refractor Field")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: *3";
                value = "Value: 5 (Rare)";
                keywords = "Keywords: Force\u00A0Field, Imperium, Astra\u00A0Militarum";
                traits = "Traits: Force\u00A0Shield";
                type = "armor";
            }
            else if (name == "Rosarius")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: *4";
                value = "Value: 7 (Very Rare)";
                keywords = "Keywords: Force\u00A0Field, Imperium, Adeptus\u00A0Astartes, Adeptus\u00A0Ministorum";
                traits = "Traits: Force\u00A0Shield";
                type = "armor";
            }
            else if (name == "Storm Shield")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: *2";
                value = "Value: 8 (Unique)";
                keywords = "Keywords: Force\u00A0Field, Imperium, Adeptus\u00A0Astartes, Adeptus\u00A0Ministorum, Inquisition";
                traits = "Traits: Bulk(1), Force\u00A0Shield, Shield";
                type = "armor";
            }
            else if (name == "Corsair Armour")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 3";
                value = "Value: 3 (Rare)";
                keywords = "Keywords: Light, Aeldari, Anhrathe";
                traits = "Traits: None";
                type = "armor";
            }
            else if (name == "Eldar Mesh Armour")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 3";
                value = "Value: 4 (Very Rare)";
                keywords = "Keywords: Light, Aeldari, Asuryani";
                traits = "Traits: None";
                type = "armor";
            }
            else if (name == "Heavy Mesh Armour")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 4";
                value = "Value: 6 (Very Rare)";
                keywords = "Keywords: Aeldari, Anhrathe";
                traits = "Traits: None";
                type = "armor";
            }
            else if (name == "Shimmershield")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: *2";
                value = "Value: 7 (Unique)";
                keywords = "Keywords: Force\u00A0Field, Aeldari, Asuryani";
                traits = "Traits: Force\u00A0Shield, Shield";
                type = "armor";
            }
            else if (name == "Rune Armour")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 4";
                value = "Value: 6 (Unique)";
                keywords = "Keywords: Force\u00A0Field, Aeldari, Asuryani";
                traits = "Traits: Force\u00A0Shield";
                type = "armor";
            }
            else if (name == "Voidplate Harness")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 5";
                value = "Value: 7 (Rare)";
                keywords = "Keywords: Aeldari, Anhrathe";
                traits = "Traits: Bulk(2)";
                type = "armor";
            }
            else if (name == "Eavy Armour")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 4";
                value = "Value: 3 (Uncommon)";
                keywords = "Keywords: Heavy, Primitive, Ork";
                traits = "Traits: Ere\u00A0We\u00A0Go, Bulk(1)";
                type = "armor";
            }
            else if (name == "Mega Armour")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 7";
                value = "Value: 9 (Very Rare)";
                keywords = "Keywords: Powered, Ork";
                traits = "Traits: Ere\u00A0We\u00A0Go, Cumbersome, Powered(4)";
                type = "armor";
            }
            else if (name == "Ork Flak")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 2";
                value = "Value: 2 (Uncommon)";
                keywords = "Keywords: Primitive, Ork";
                traits = "Traits: None";
                type = "armor";
            }
            else if (name == "Necron Dermal Plating")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 2";
                value = "Value: 2 (Uncommon)";
                keywords = "Keywords: Integrated, Necron";
                traits = "Traits: None";
                type = "armor";
            }


            // new stuff, ammo and tools

            else if (name == "Ammunition Bandolier")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 2 (Common)";
                keywords = "Keywords: <Any>";
                traits = "Description: 2 additional Reloads";
                type = "tools";
            }
            else if (name == "Ammunition Backpack")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Uncommon)";
                keywords = "Keywords: <Any>";
                traits = "Description: 10 additional Reloads";
                type = "tools";
            }
            else if (name == "Hellfire Bolt Rounds")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 7 (Very Rare)";
                keywords = "Keywords: Imperium, Adeptus\u00A0Astartes";
                traits = "Description: +2ED, +3ED vs Organic targets";
                type = "tools";
            }
            else if (name == "Kraken Bolt Rounds")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 7 (Very Rare)";
                keywords = "Keywords: Imperium, Adeptus\u00A0Astartes";
                traits = "Description: AP -2";
                type = "tools";
            }
            else if (name == "Manstopper Rounds")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Uncommon)";
                keywords = "Keywords: Imperium, Scum";
                traits = "Description: +1ED";
                type = "tools";
            }
            else if (name == "Reloads")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 2 (Common)";
                keywords = "Keywords: <Any>";
                traits = "Description: Ammunition";
                type = "tools";
            }
            else if (name == "Vengeance Bolt Rounds")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 7 (Very Rare)";
                keywords = "Keywords: Imperium, Adeptus\u00A0Astartes";
                traits = "Description: Weapon gains Spread, defender loses Cover bonus";
                type = "tools";
            }
            else if (name == "9-70 Entrenching Tool")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 2 (Common)";
                keywords = "Keywords: Imperium, Astra\u00A0Militarum";
                traits = "Description: Halves time to dig holes";
                type = "tools";
            }
            else if (name == "Auspex")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Rare)";
                keywords = "Keywords: Imperium, Adeptus\u00A0Mechanicus";
                traits = "Description: +2d to Awareness tests";
                type = "tools";
            }
            else if (name == "Auto-Quill")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 4 (Uncommon)";
                keywords = "Keywords: Imperium";
                traits = "Description: +2d to forge documents";
                type = "tools";
            }
            else if (name == "Ballistic Appeasement Auto-Reliquary")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 6 (Very Rare";
                keywords = "Keywords: Imperium, Adeptus\u00A0Astartes, Primaris";
                traits = "Description: Clear weapon jams as a free action";
                type = "tools";
            }
            else if (name == "Clothing")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: Varies, see P.307";
                keywords = "Keywords: <Any>";
                traits = "Description: Varies, see P.307";
                type = "tools";
            }
            else if (name == "Combi-Tool")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 3 (Uncommon)";
                keywords = "Keywords: <Any>";
                traits = "Description: See P.307";
                type = "tools";
            }
            else if (name == "Chameleoline Cloak")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Rare)";
                keywords = "Keywords: <Any>";
                traits = "Description: +1d\u00A0Stealth, +1d\u00A0Defence when in shadows";
                type = "tools";
            }
            else if (name == "Chaplet Ecclesiasticus")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 3 (Uncommon)";
                keywords = "Keywords: Imperium, Adeptus\u00A0Ministorum Adepta\u00A0Sororitas";
                traits = "Description: Can be used as a garrotte";
                type = "tools";
            }
            else if (name == "Chrono")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 3 (Common)";
                keywords = "Keywords: <Any>";
                traits = "Description: A Watch";
                type = "tools";
            }
            else if (name == "Data-Slate")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 2 (Common)";
                keywords = "Keywords: Imperium";
                traits = "Description: Can read and store data";
                type = "tools";
            }
            else if (name == "Diagnostor")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Very Rare)";
                keywords = "Keywords: Imperium";
                traits = "Description: +1d Medicae when diagnosing, +1d\u00A0Awareness and Investigation when investigating cause of death";
                type = "tools";
            }
            else if (name == "Grav-Chute")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Uncommon)";
                keywords = "Keywords: Imperium, Astra\u00A0Militarum";
                traits = "Description: Can hover for 1\u00A0minute, slow falls. See P.308";
                type = "tools";
            }
            else if (name == "Munitorum-Issue Mess Kit")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 2 (Common)";
                keywords = "Keywords: Imperium, Astra\u00A0Militarum";
                traits = "Description: +1d bonus to Survival to find food";
                type = "tools";
            }
            else if (name == "Guard-Issue Mess Kit")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 2 (Common)";
                keywords = "Keywords: Imperium, Astra\u00A0Militarum";
                traits = "Description: +1d bonus to Survival to find food";
                type = "tools";
            }
            else if (name == "Blanket")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 1 (Common)";
                keywords = "Keywords: Imperium, Astra\u00A0Militarum";
                traits = "Description: A Blanket";
                type = "tools";
            }
            else if (name == "Grooming Kit")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 1 (Common)";
                keywords = "Keywords: Imperium, Astra\u00A0Militarum";
                traits = "Description: Moustache Trimmer";
                type = "tools";
            }
            else if (name == "Jump Pack")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 7 (Rare)";
                keywords = "Keywords: <Any>";
                traits = "Description: Can jump for twice Movement distance. See P.308";
                type = "tools";
            }
            else if (name == "Magnoculars")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 3 (Uncommon)";
                keywords = "Keywords: <Any>";
                traits = "Description: No distance penalties on Awareness tests";
                type = "tools";
            }
            else if (name == "Medikit")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 3 (Uncommon)";
                keywords = "Keywords: <Any>";
                traits = "Description: Contains basic medical supplies";
                type = "tools";
            }
            else if (name == "Chirurgeon's Tools Medkit")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Rare)";
                keywords = "Keywords: Imperium, Adepta\u00A0Sororitas";
                traits = "Description: +2d\u00A0Medicae tests to stabalize a dying person";
                type = "tools";
            }
            else if (name == "Martyr's Gift Variant Medkit")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 6 (Rare)";
                keywords = "Keywords: Imperium, Astra\u00A0Militarum";
                traits = "Description: +1d Medicae. See P.309";
                type = "tools";
            }
            else if (name == "Missionary Kit")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 2 (Rare)";
                keywords = "Keywords: Imperium, Adeptus\u00A0Ministorum";
                traits = "Description: +1d Persuassion to convert people to the Imperial Creed";
                type = "tools";
            }
            else if (name == "Periculum Kit")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Rare)";
                keywords = "Keywords: Imperium, <Any>";
                traits = "Description: Contains Chrono, Data-Slate, Magnoculars, 2\u00A0Ration Packs, Respirator, Vox\u2011beads";
                type = "tools";
            }
            else if (name == "Preysense Goggles")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Rare)";
                keywords = "Keywords: <Any>";
                traits = "Description: No penalties for Darkness or Fog";
                type = "tools";
            }
            else if (name == "Psychic Focus")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 3 (Rare)";
                keywords = "Keywords: <Any>";
                traits = "Description: +1d Psychic Mastery tests";
                type = "tools";
            }
            else if (name == "Ration Packs")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 1 (Common)";
                keywords = "Keywords: <Any>";
                traits = "Description: 1 day of rations";
                type = "tools";
            }
            else if (name == "Respirator")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 2 (Uncommon)";
                keywords = "Keywords: <Any>";
                traits = "Description: 2 hours of oxygen";
                type = "tools";
            }
            else if (name == "Rule of the Sororitas")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 2 (Uncommon)";
                keywords = "Keywords: Imperium, Adepta\u00A0Sororitas";
                traits = "Description: Adeptus\u00A0Sororitas bible";
                type = "tools";
            }
            else if (name == "Sacred Machine Oil")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 3 (Uncommon)";
                keywords = "Keywords: Imperium, Adeptus\u00A0Mechanicus";
                traits = "Description: May ignore the first complication in combat";
                type = "tools";
            }
            else if (name == "Slate Monitron")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Rare)";
                keywords = "Keywords: Imperium, Astra\u00A0Militarum";
                traits = "Description: Shows wearers vital signs";
                type = "tools";
            }
            else if (name == "Stimm")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 4 (Uncommon)";
                keywords = "Keywords: Imperium, Scum";
                traits = "Description: Heals 1d3+6\u00A0Shock, requires on a successful Medicae test";
                type = "tools";
            }
            else if (name == "Survival Kit")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 3 (Uncommon)";
                keywords = "Keywords: <Any>";
                traits = "Description: +1d to Survival tests";
                type = "tools";
            }
            else if (name == "Symbol of Authority")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 3 (Uncommon)";
                keywords = "Keywords: <Any>";
                traits = "Description: +1d bonus to Leadership and Intimidation\u00A0vs. appropriate targets";
                type = "tools";
            }
            else if (name == "Uplifting Primer")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 2 (Common)";
                keywords = "Keywords: Imperium, Astra\u00A0Militarum";
                traits = "Description: Soldiers field guide";
                type = "tools";
            }
            else if (name == "Void Suit")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Rare)";
                keywords = "Keywords: <Any>";
                traits = "Description: Space suit, 5\u00A0hours of oxygen";
                type = "tools";
            }
            else if (name == "Vox-beads")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 3 (Uncommon)";
                keywords = "Keywords: <Any>";
                traits = "Description: Can transmit audio\u00A01km";
                type = "tools";
            }
            else if (name == "Small Vox Unit")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 4 (Rare)";
                keywords = "Keywords: <Any>";
                traits = "Description: Can transmit audio\u00A010km";
                type = "tools";
            }
            else if (name == "Large Vox Unit")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Rare)";
                keywords = "Keywords: <Any>";
                traits = "Description: Can transmit audio\u00A0100km";
                type = "tools";
            }
            else if (name == "Writing Kit")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 2 (Common)";
                keywords = "Keywords: Imperium";
                traits = "Description: Writing utensils, scrolls";
                type = "tools";
            }
            else if (name == "Bonesinger Shard")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 6 (Rare)";
                keywords = "Keywords: Aeldari";
                traits = "Description: Repair tool";
                type = "tools";
            }
            else if (name == "Spirit Stone")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 7 (Very Rare)";
                keywords = "Keywords: Aeldari";
                traits = "Description: See P.311";
                type = "tools";
            }
            else if (name == "Webway Keystone")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 7 (Unique)";
                keywords = "Keywords: Aeldari";
                traits = "Description: Manipulate webway portals with a 5DN\u00A0Tech test";
                type = "tools";
            }
            else if (name == "Ammo Grot")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Uncommon)";
                keywords = "Keywords: Ork";
                traits = "Description: Lootgoblin that holds 2\u00A0ammo. See P.311";
                type = "tools";
            }
            else if (name == "Dok Bag")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Very Rare)";
                keywords = "Keywords: Ork";
                traits = "Description: A Medkit ";
                type = "tools";
            }
            else if (name == "Fightin' Juice")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 4 (Rare)";
                keywords = "Keywords: Ork";
                traits = "Description: Removes all Shock, +2d\u00A0bonus to Melee attacks, +1\u00A0to the result of all Defiance checks";
                type = "tools";
            }
            else if (name == "Mek Toolz")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Uncommon)";
                keywords = "Keywords: Ork";
                traits = "Description: Ork Tools";
                type = "tools";
            }


            //new stuff, weapon mods


            else if (name == "Ammunition Drum")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 3 (Common)";
                keywords = "Keywords: Imperium, Scum";
                traits = "Description: +1 Reload";
                type = "mods";
            }
            else if (name == "Autoloader")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Rare)";
                keywords = "Keywords: Imperium";
                traits = "Description: Reloading the weapon is a Free Action";
                type = "mods";
            }
            else if (name == "Bayonet Lug")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 1 (Common)";
                keywords = "Keywords: <Any>";
                traits = "Description: Can attach a bayonet";
                type = "mods";
            }
            else if (name == "Chain Bayonet Lug")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 4 (Rare)";
                keywords = "Keywords: Imperium, Chaos";
                traits = "Description: Can attach a Chain bayonet";
                type = "mods";
            }
            else if (name == "Combi-Weapon")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 6 (Rare)";
                keywords = "Keywords: Imperium, Chaos, Scum";
                traits = "Description: Combine 2\u00A0weapons, see P.298";
                type = "mods";
            }
            else if (name == "Dueling Grip")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 3 (Uncommon)";
                keywords = "Keywords: <Any>";
                traits = "Description: +1d to attacks. Can only be attached to pistols and one\u2011handed melee weapons";
                type = "mods";
            }
            else if (name == "Distinction")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Uncommon)";
                keywords = "Keywords: <Any>";
                traits = "Description: Unique weapon. +1d\u00A0to Intimidation";
                type = "mods";
            }
            else if (name == "Gene-Grip Bio-Veritor")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Rare)";
                keywords = "Keywords: Imperium";
                traits = "Description: Bio\u2011safety switch";
                type = "mods";
            }
            else if (name == "Master-Crafted")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 7 (Very Rare)";
                keywords = "Keywords: <Any>";
                traits = "Description: A true work of art. Adds Steadfast trait, +2d\u00A0bonus to attacks with this weapon";
                type = "mods";
            }
            else if (name == "Megathoule Accelerator")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 6 (Very Rare)";
                keywords = "Keywords: Imperium, Astra\u00A0Militarum";
                traits = "Description: +2\u00A0Salvo, loses Steadfast trait";
                type = "mods";
            }
            else if (name == "Monoscope")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 4 (Rare)";
                keywords = "Keywords: Imperium, Astra\u00A0Militarum";
                traits = "Description: Reduce range penalties by\u00A02DN";
                type = "mods";
            }
            else if (name == "Percussive Muzzle Brake")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 3 (Uncommon)";
                keywords = "Keywords: Imperium, Scum";
                traits = "Description: Cannot apply to Heavy weapons. Salvo\u00A0+1";
                type = "mods";
            }
            else if (name == "Preysense Sight")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 6 (Rare)";
                keywords = "Keywords: Imperium, Scum, <Any>";
                traits = "Description: Night Vision scope";
                type = "mods";
            }
            else if (name == "Red-Dot Sight")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 5 (Uncommon)";
                keywords = "Keywords: Imperium, Scum";
                traits = "Description: +1d bonus to ranged attacks";
                type = "mods";
            }
            else if (name == "Silencer")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: N/A";
                value = "Value: 3 (Uncommon)";
                keywords = "Keywords: Imperium, Scum, <Any>";
                traits = "Description: +4DN to tests to hear the weapon";
                type = "mods";
            }

            else
            {
                damage = "Damage: ";
                ap = "AP: ";
                range = "Range: ";
                salvo = "Salvo: ";
                armor = "Armor: ";
                value = "Value: ";
                keywords = "Keywords: ";
                traits = "Traits: ";
                type = "armor";

                // load in the homebrew file

                string resourceName = Environment.CurrentDirectory + "\\HomebrewExtensions\\equipmentHomebrew.json";

                //JObject eBrew = JObject.Parse(File.ReadAllText(resourceName));

                try
                {
                    List<equipmentObject> eBrew = JsonConvert.DeserializeObject<List<equipmentObject>>(File.ReadAllText(resourceName));


                    foreach (equipmentObject x in eBrew)
                    {
                        if (name == x.name)
                        {
                            damage = "Damage: " + x.damage;
                            ap = "AP:" + x.ap;
                            range = "Range: " + x.range;
                            salvo = "Salvo: " + x.salvo;
                            armor = "Armor: " + x.armor;
                            value = "Value: " + x.value;
                            keywords = "Keywords: " + x.keywords;
                            // description for mods
                            if (x.type == "mods")
                            {
                                traits = "Description: " + x.traits;
                            }
                            else
                            {
                                traits = "Traits: " + x.traits;
                            }
                            type = x.type;
                        }
                    }
                }
                catch (IOException)
                {
                    string message = "Cant find the equipmentHomebrew.json file! Have you moved it? Do you have read access to the directory the program is running from?";
                    string caption = "Error!";
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, button, MessageBoxIcon.Error);
                }

            }

            result = Tuple.Create(Tuple.Create(name, damage, ap, range, salvo), Tuple.Create(armor, value, keywords, traits, type));
            return result;
        }


        private void updateEquipSelections()
        {
            equipSelectBox.Items.Clear();

            // add all items
            if (equipBoxFilter.Items.Count > 1)
            {
                if (equipBoxFilter.SelectedIndex == 0)
                {
                    foreach (string item in rangedWeaponsList)
                    {
                        equipSelectBox.Items.Add(item);
                    }
                    foreach (string item in meleeWeaponsList)
                    {
                        equipSelectBox.Items.Add(item);
                    }
                    foreach (string item in armorList)
                    {
                        equipSelectBox.Items.Add(item);
                    }
                    foreach (string item in toolsList)
                    {
                        equipSelectBox.Items.Add(item);
                    }
                    
                }

                //add ranged weapons
                if (equipBoxFilter.SelectedIndex == 1)
                {
                    foreach (string item in rangedWeaponsList)
                    {
                        equipSelectBox.Items.Add(item);
                    }
                }

                //add melee weapons
                if (equipBoxFilter.SelectedIndex == 2)
                {
                    foreach (string item in meleeWeaponsList)
                    {
                        equipSelectBox.Items.Add(item);
                    }
                }

                //add armor
                if (equipBoxFilter.SelectedIndex == 3)
                {
                    foreach (string item in armorList)
                    {
                        equipSelectBox.Items.Add(item);
                    }
                }

                //add tools and ammo
                if (equipBoxFilter.SelectedIndex == 4)
                {
                    foreach (string item in toolsList)
                    {
                        equipSelectBox.Items.Add(item);
                    }
                }
            }

            // we are in mod selection
            else
            {
                if (equipBoxFilter.SelectedIndex == 0)
                {
                    foreach (string item in weaponModList)
                    {
                        equipSelectBox.Items.Add(item);
                    }
                }
            }
            unfilteredEquipList = equipSelectBox.Items.Cast<string>().ToList();
        }



        private void createEquipLists()
        {
            //ranged weapons
            rangedWeaponsList.Add("Assault Bolter");
            rangedWeaponsList.Add("Bolt Rifle");
            rangedWeaponsList.Add("Bolt Pistol");
            rangedWeaponsList.Add("Boltgun");
            rangedWeaponsList.Add("Heavy Bolter");
            rangedWeaponsList.Add("Heavy Bolt Pistol");
            rangedWeaponsList.Add("Storm Bolter");
            rangedWeaponsList.Add("Flamer");
            rangedWeaponsList.Add("Hand Flamer");
            rangedWeaponsList.Add("Heavy Flamer");
            rangedWeaponsList.Add("Duelling Laspistol");
            rangedWeaponsList.Add("Hot-Shot Lasgun");
            rangedWeaponsList.Add("Hot-Shot Laspistol");
            rangedWeaponsList.Add("Hot-Shot Volley Gun");
            rangedWeaponsList.Add("Lascannon");
            rangedWeaponsList.Add("Lasgun");
            rangedWeaponsList.Add("Laspistol");
            rangedWeaponsList.Add("Long Las");
            rangedWeaponsList.Add("Inferno Pistol");
            rangedWeaponsList.Add("Meltagun");
            rangedWeaponsList.Add("Multi-Melta");
            rangedWeaponsList.Add("Plasma Cannon");
            rangedWeaponsList.Add("Plasma Gun");
            rangedWeaponsList.Add("Plasma Pistol");
            rangedWeaponsList.Add("Assault Cannon");
            rangedWeaponsList.Add("Astartes Shotgun");
            rangedWeaponsList.Add("Astartes Sniper Rifle");
            rangedWeaponsList.Add("Autocannon");
            rangedWeaponsList.Add("Autogun");
            rangedWeaponsList.Add("Autopistol");
            rangedWeaponsList.Add("Combat Shotgun");
            rangedWeaponsList.Add("Hand Cannon");
            rangedWeaponsList.Add("Heavy Stubber");
            rangedWeaponsList.Add("Shotgun");
            rangedWeaponsList.Add("Stubber");
            rangedWeaponsList.Add("Stubcannon");
            rangedWeaponsList.Add("Cyclone Missile Launcher");
            rangedWeaponsList.Add("Missile Launcher");
            rangedWeaponsList.Add("Frag Missile");
            rangedWeaponsList.Add("Krak Missile");
            rangedWeaponsList.Add("Militarum\u00A0Tempestus Grenade Launcher");
            rangedWeaponsList.Add("Astra\u00A0Militarum Voss Pattern Grenade Launcher");
            rangedWeaponsList.Add("Frag Grenade");
            rangedWeaponsList.Add("Krak Grenade");
            rangedWeaponsList.Add("Plasma Grenade");
            rangedWeaponsList.Add("Arc Pistol");
            rangedWeaponsList.Add("Arc Rifle");
            rangedWeaponsList.Add("Galvanic Rifle");
            rangedWeaponsList.Add("Radium Carbine");
            rangedWeaponsList.Add("Radium Pistol");
            rangedWeaponsList.Add("Fusion Gun");
            rangedWeaponsList.Add("Lasblaster");
            rangedWeaponsList.Add("Ranger Long Rifle");
            rangedWeaponsList.Add("Shuriken Catapult");
            rangedWeaponsList.Add("Shuriken Pistol");
            rangedWeaponsList.Add("Big Shoota");
            rangedWeaponsList.Add("Burna");
            rangedWeaponsList.Add("Rokkit Launcha");
            rangedWeaponsList.Add("Shoota");
            rangedWeaponsList.Add("Slugga");
            rangedWeaponsList.Add("Snazzgun");
            rangedWeaponsList.Add("Stikkbomb");
            rangedWeaponsList.Add("Gauss Rifle");

            //melee weapons
            meleeWeaponsList.Add("Astartes Combat Knife");
            meleeWeaponsList.Add("Industrial Bludgeon");
            meleeWeaponsList.Add("Knife");
            meleeWeaponsList.Add("Mono Knife");
            meleeWeaponsList.Add("Psykana Mercy Blade");
            meleeWeaponsList.Add("Sword");
            meleeWeaponsList.Add("Throwing Knife");
            meleeWeaponsList.Add("Chain Axe");
            meleeWeaponsList.Add("Chain Bayonet");
            meleeWeaponsList.Add("Chain Fist");
            meleeWeaponsList.Add("Chain Sword");
            meleeWeaponsList.Add("Eviscerator");
            meleeWeaponsList.Add("Force Axe");
            meleeWeaponsList.Add("Force Hammer");
            meleeWeaponsList.Add("Force Rod");
            meleeWeaponsList.Add("Force Sword");
            meleeWeaponsList.Add("Death Cult Powerblade");
            meleeWeaponsList.Add("Omnissian Axe");
            meleeWeaponsList.Add("Power Axe");
            meleeWeaponsList.Add("Power Fist");
            meleeWeaponsList.Add("Power Sword");
            meleeWeaponsList.Add("Thunder Hammer");
            meleeWeaponsList.Add("Void Sabre");
            meleeWeaponsList.Add("Neural Whip");
            meleeWeaponsList.Add("Shock Maul");
            meleeWeaponsList.Add("Shock Whip");
            meleeWeaponsList.Add("Whip");
            meleeWeaponsList.Add("Singing Spear");
            meleeWeaponsList.Add("Witchblade");
            meleeWeaponsList.Add("Big Choppa");
            meleeWeaponsList.Add("Chain Choppa");
            meleeWeaponsList.Add("Choppa");
            meleeWeaponsList.Add("Power Klaw");
            meleeWeaponsList.Add("Weirdboy Staff");
            meleeWeaponsList.Add("Axe Bayonet");

            //armor
            armorList.Add("Bodyglove");
            armorList.Add("Carapace Armour");
            armorList.Add("Flak Armour");
            armorList.Add("Flak Coat");
            armorList.Add("Mesh Armour");
            armorList.Add("Primitive Armour");
            armorList.Add("Skitarii Auto-Cuirass");
            armorList.Add("Tempestus Carapace");
            armorList.Add("Heavy Power Armour");
            armorList.Add("Ignatus Power Armour");
            armorList.Add("Light Power Armour");
            armorList.Add("Sororitas Powered Armour");
            armorList.Add("Aquila Mk VII");
            armorList.Add("Scout Armour");
            armorList.Add("Tacticus Mk X");
            armorList.Add("Terminator Armour");
            armorList.Add("Refractor Field");
            armorList.Add("Rosarius");
            armorList.Add("Storm Shield");
            armorList.Add("Corsair Armour");
            armorList.Add("Eldar Mesh Armour");
            armorList.Add("Heavy Mesh Armour");
            armorList.Add("Shimmershield");
            armorList.Add("Rune Armour");
            armorList.Add("Voidplate Harness");
            armorList.Add("Eavy Armour");
            armorList.Add("Mega Armour");
            armorList.Add("Ork Flak");
            armorList.Add("Necron Dermal Plating");

            //mods list
            weaponModList.Add("Ammunition Drum");
            weaponModList.Add("Autoloader");
            weaponModList.Add("Bayonet Lug");
            weaponModList.Add("Chain Bayonet Lug");
            weaponModList.Add("Combi-Weapon");
            weaponModList.Add("Dueling Grip");
            weaponModList.Add("Distinction");
            weaponModList.Add("Gene-Grip Bio-Veritor");
            weaponModList.Add("Master-Crafted");
            weaponModList.Add("Megathoule Accelerator");
            weaponModList.Add("Monoscope");
            weaponModList.Add("Percussive Muzzle Brake");
            weaponModList.Add("Preysense Sight");
            weaponModList.Add("Red-Dot Sight");
            weaponModList.Add("Silencer");

            //tools and ammo
            toolsList.Add("Hellfire Bolt Rounds");
            toolsList.Add("Kraken Bolt Rounds");
            toolsList.Add("Manstopper Rounds");
            toolsList.Add("Vengeance Bolt Rounds");
            toolsList.Add("Reloads");
            toolsList.Add("Ammunition Bandolier");
            toolsList.Add("Ammunition Backpack");
            toolsList.Add("9-70 Entrenching Tool");
            toolsList.Add("Auspex");
            toolsList.Add("Auto-Quill");
            toolsList.Add("Ballistic Appeasement Auto-Reliquary");
            toolsList.Add("Clothing");
            toolsList.Add("Combi-Tool");
            toolsList.Add("Chameleoline Cloak");
            toolsList.Add("Chaplet Ecclesiasticus");
            toolsList.Add("Chrono");
            toolsList.Add("Data-Slate");
            toolsList.Add("Diagnostor");
            toolsList.Add("Grav-Chute");
            toolsList.Add("Munitorum-Issue Mess Kit");
            toolsList.Add("Guard-Issue Mess Kit");
            toolsList.Add("Blanket");
            toolsList.Add("Grooming Kit");
            toolsList.Add("Jump Pack");
            toolsList.Add("Magnoculars");
            toolsList.Add("Medikit");
            toolsList.Add("Chirurgeon's Tools Medkit");
            toolsList.Add("Martyr's Gift Variant Medkit");
            toolsList.Add("Missionary Kit");
            toolsList.Add("Periculum Kit");
            toolsList.Add("Preysense Goggles");
            toolsList.Add("Psychic Focus");
            toolsList.Add("Ration Packs");
            toolsList.Add("Respirator");
            toolsList.Add("Rule of the Sororitas");
            toolsList.Add("Sacred Machine Oil");
            toolsList.Add("Slate Monitron");
            toolsList.Add("Stimm");
            toolsList.Add("Survival Kit");
            toolsList.Add("Symbol of Authority");
            toolsList.Add("Uplifting Primer");
            toolsList.Add("Void Suit");
            toolsList.Add("Vox-beads");
            toolsList.Add("Small Vox Unit");
            toolsList.Add("Large Vox Unit");
            toolsList.Add("Writing Kit");
            toolsList.Add("Bonesinger Shard");
            toolsList.Add("Spirit Stone");
            toolsList.Add("Webway Keystone");
            toolsList.Add("Ammo Grot");
            toolsList.Add("Dok Bag");
            toolsList.Add("Fightin' Juice");
            toolsList.Add("Mek Toolz");


            // load in the homebrew file

            string resourceName = Environment.CurrentDirectory + "\\HomebrewExtensions\\equipmentHomebrew.json";

            //JObject eBrew = JObject.Parse(File.ReadAllText(resourceName));

            try
            {
                List<equipmentObject> eBrew = JsonConvert.DeserializeObject<List<equipmentObject>>(File.ReadAllText(resourceName));
            

                foreach(equipmentObject x in eBrew)
                {
                    string name;
                    string type;

                    name = x.name;
                    type = x.type;

                    if (type == "ranged")
                    {
                        rangedWeaponsList.Add(name);
                    }
                    else if (type == "melee")
                    {
                        meleeWeaponsList.Add(name);
                    }
                    else if (type == "armor")
                    {
                        armorList.Add(name);
                    }
                    else if (type == "tools")
                    {
                        toolsList.Add(name);
                    }
                    else if (type == "mods")
                    {
                        weaponModList.Add(name);
                    }
                    else
                    {

                    }
                }
            }
            catch (IOException)
            {
                string message = "Cant find the equipmentHomebrew.json file! Have you moved it? Do you have read access to the directory the program is running from?";
                string caption = "Error!";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, button, MessageBoxIcon.Error);
            }
        }


    }
}
