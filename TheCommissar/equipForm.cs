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
    public partial class equipForm : Form
    {

        List<string> rangedWeaponsList = new List<string>();
        List<string> meleeWeaponsList = new List<string>();
        List<string> armorList = new List<string>();


        public equipForm()
        {
            InitializeComponent();

            equipBoxFilter.SelectedIndex = 0;
            createEquipLists();
            updateEquipSelections();


        }

        private void equipSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //55 length
            //result = Tuple.Create(Tuple.Create(name, damage, ap, range, salvo), Tuple.Create(armor, value, keywords, traits));
            string curItem = equipSelectBox.SelectedItem.ToString();
            var result = getEquipValues(curItem);
            equipDamageLabel.Text = result.Item1.Item2;
            equipAPLabel.Text = result.Item1.Item3;
            equipRangeLabel.Text = result.Item1.Item4;
            equipSalvoLabel.Text = result.Item1.Item5;
            equipArmorRatingLabel.Text = result.Item2.Item1;
            equipValueLabel.Text = result.Item2.Item2;
            equipKeywordsLabel.Text = result.Item2.Item3;
            equipTraitsLabel.Text = result.Item2.Item4;

            if (equipKeywordsLabel.Text.Contains(Environment.NewLine))
            {
                equipTraitsLabel.Visible = false;
                equipKeywordsLabel.Text += Environment.NewLine + Environment.NewLine + equipTraitsLabel.Text;
            }
            else
            {
                equipTraitsLabel.Visible = true;
            }            
        }

        private void addEquipButton_Click(object sender, EventArgs e)
        {

        }

        public string returnEquipDetails()
        {
            string result = equipSelectBox.SelectedItem.ToString();
            return result;
        }


        private void equipBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateEquipSelections();
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
                keywords = "Keywords: Bolt, Imperium, Adeptus Astartes," + Environment.NewLine + "Primaris";
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
                keywords = "Keywords: Bolt, Imperium, Adeptus Astartes," + Environment.NewLine + "Primaris";
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
                keywords = "Keywords: Bolt, Imperium, Adeptus Astartes," + Environment.NewLine + "Primaris";
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
                traits = "Traits: Assault, Blast (Medium), Blaze, Spread";
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
                traits = "Traits: Blast (Small), Blaze, Pistol, Spread";
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
                traits = "Traits: Blast (Large), Blaze, Heavy, Spread";
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
                keywords = "Keywords: Las, Imperium, Astra Militarum";
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
                keywords = "Keywords: Las, Imperium, Astra Militarum";
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
                keywords = "Keywords: Las, Imperium, Astra Militarum";
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
                traits = "Traits: Rapid Fire(1), Steadfast";
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
                keywords = "Keywords: Las, Imperium, Astra Militarum";
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
                keywords = "Keywords: Melta, Imperium, Adepta Sororitas," + Environment.NewLine + "Adeptus Astartes";
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
                keywords = "Keywords: Projectile, Imperium, Adeptus Astartes";
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
                keywords = "Keywords: Projectile, Imperium, Adeptus Astartes";
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
                keywords = "Keywords: Projectile, Imperium, Adeptus Astartes";
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
                traits = "Traits: Assault, Rapid Fire(1), Spread";
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
                keywords = "Keywords: Explosive, Imperium, Adeptus Astartes";
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
                traits = "Traits: Blast (Small)";
                type = "ranged";
            }
            else if (name == "Militarum Tempestus Grenade Launcher")
            {
                damage = "Damage: By Grenade";
                ap = "AP: By Grenade";
                range = "Range: 50m";
                salvo = "Salvo: 1";
                armor = "Armor: N/A";
                value = "Value: 6 (Uncommon)";
                keywords = "Keywords: Explosive, Imperium, Astra Militarum";
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
                keywords = "Keywords: Explosive, Imperium, Astra Militarum";
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
                traits = "Traits: Blast (Medium)";
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
                traits = "Traits: Blast (Small)";
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
                traits = "Traits: Blast (Medium)";
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
                keywords = "Keywords: Arc, Adeptus Mechanicus";
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
                keywords = "Keywords: Arc, Adeptus Mechanicus";
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
                keywords = "Keywords: Projectile, Adeptus Mechanicus";
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
                keywords = "Keywords: Projectile, Adeptus Mechanicus";
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
                keywords = "Keywords: Projectile, Adeptus Mechanicus";
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
                traits = "Traits: Assault, Blast (Small), Blaze, Spread";
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
                traits = "Traits: Blast (Small)";
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
                range = "Range: Strength X4 Meters or By Launcher";
                salvo = "Salvo: --";
                armor = "Armor: N/A";
                value = "Value: 2 (Uncommon)";
                keywords = "Keywords: Explosive, Ork";
                traits = "Traits: Blast (Medium)";
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
                keywords = "Keywords: Blade, Imperium, Adeptus Astartes";
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
                keywords = "Keywords: Blade, Imperium, Aeldari, Ork," + Environment.NewLine + "Scum, <Any>";
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
                keywords = "Keywords: Blade, Imperium," + Environment.NewLine + "Adeptus Astra Telepathica";
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
                keywords = "Keywords: Blade, Imperium," + Environment.NewLine + "Aeldari, <Any>";
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
                keywords = "Keywords: Blade, Aeldari," + Environment.NewLine + "Scum, <Any>";
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
                keywords = "Keywords: Chain, Power Field," + Environment.NewLine + "Imperium, Chaos, Adeptus Astartes";
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
                keywords = "Keywords: Chain, Aeldari, Imperium," + Environment.NewLine + "Chaos";
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
                keywords = "Keywords: Chain, Adeptus Ministorum," + Environment.NewLine + "Adeptus Sororitaas, Two-Handed";
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
                keywords = "Keywords: Force, Imperium, Inquisition," + Environment.NewLine + "Adeptus Astartes";
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
                keywords = "Keywords: Force, Imperium, Inquisition," + Environment.NewLine + "Two-Handed, Adeptus Astartes";
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
                keywords = "Keywords: Force, Imperium, Inquisition," + Environment.NewLine + "Adeptus Astartes, Adeptus Astra Telepathica," + Environment.NewLine + "Two-Handed";
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
                keywords = "Keywords: Force, Imperium, Inquisition," + Environment.NewLine + "Adeptus Astartes";
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
                keywords = "Keywords: Power Field, Imperium," + Environment.NewLine + "Adeptus Ministorum";
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
                keywords = "Keywords: Power Field, Imperium," + Environment.NewLine + "Adeptus Mechanicus, Two-Handed";
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
                keywords = "Keywords: Power Field, Imperium," + Environment.NewLine + "Adeptus Astartes, Adeptus Mechanicus, Aeldari";
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
                keywords = "Keywords: Power Field, Imperium," + Environment.NewLine + "Adeptus Astartes";
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
                keywords = "Keywords: Power Field, Imperium, Aeldari";
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
                keywords = "Keywords: Power Field, Imperium," + Environment.NewLine + "Adeptus Astartes, Inquisition, Two-Handed";
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
                keywords = "Keywords: Power Field, Aeldari," + Environment.NewLine + "Anhrathe";
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
                keywords = "Keywords: Exotic, Imperium," + Environment.NewLine + "Adeptus Arbites";
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
                traits = "Traits: Assault, Force, Warp Weapon";
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
                traits = "Traits: Force, Parry, Warp Weapon";
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
                keywords = "Keywords: Blade, Ork, Two-Handed";
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
                keywords = "Keywords: Power Field, Ork";
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
                keywords = "Keywords: Force, Ork, Two-Handed";
                traits = "Traits: Force, Waaagh!";
                type = "melee";
            }

            //armor
            else if (name == "Bodyglove")
            {
                damage = "Damage: N/A";
                ap = "AP: N/A";
                range = "Range: N/A";
                salvo = "Salvo: N/A";
                armor = "Armor: 2";
                value = "Value: 3 (Rare)";
                keywords = "Keywords: Light, Imperium," + Environment.NewLine + "Adeptus Ministorum";
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
                keywords = "Keywords: Imperium, Officio Assassinorum," + Environment.NewLine + "Astra Militarum";
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
                keywords = "Keywords: Flak, Imperium, Astra Militarum";
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
                keywords = "Keywords: Flak Imperium, Astra Militarum";
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
                keywords = "Keywords: Heavy, Imperium, Adeptus Mechanicus," + Environment.NewLine + "Skitarii";
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
                keywords = "Keywords: Heavy, Imperium, Astra Militarum," + Environment.NewLine + "Militarum Tempestus";
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
                keywords = "Keywords: Powered, Imperium, Adepta Sororitas";
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
                keywords = "Keywords: Powered, Imperium, Adeptus Astartes";
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
                keywords = "Keywords: Imperium, Adeptus Astartes";
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
                keywords = "Keywords: Powered, Imperium, Adeptus Astartes," + Environment.NewLine + "Primaris";
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
                keywords = "Keywords: Powered, Imperium, Adeptus Astartes";
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
                keywords = "Keywords: Force Field, Imperium, Astra Militarum";
                traits = "Traits: Force Shield";
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
                keywords = "Keywords: Force Field, Imperium, Adeptus Astartes," + Environment.NewLine + "Adeptus Ministorum";
                traits = "Traits: Force Shield";
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
                keywords = "Keywords: Force Field, Imperium, Adeptus Astartes," + Environment.NewLine + "Adeptus Ministorum, Inquisition";
                traits = "Traits: Bulk(1), Force Shield, Shield";
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
                keywords = "Keywords: Force Field, Aeldari, Asuryani";
                traits = "Traits: Force Shield, Shield";
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
                keywords = "Keywords: Force Field, Aeldari, Asuryani";
                traits = "Traits: Force Shield";
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
                keywords = "Keywords: Heavy, Primitive Ork";
                traits = "Traits: Ere We Go, Bulk(1)";
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
                traits = "Traits: Ere We Go, Cumbersome, Powered(4)";
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
            }

            result = Tuple.Create(Tuple.Create(name, damage, ap, range, salvo), Tuple.Create(armor, value, keywords, traits, type));
            return result;
        }


        private void updateEquipSelections()
        {
            equipSelectBox.Items.Clear();

            // add all items
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
            rangedWeaponsList.Add("Militarum Tempestus Grenade Launcher");
            rangedWeaponsList.Add("Astra Militarum Voss Pattern Grenade Launcher");
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
        }


    }
}
