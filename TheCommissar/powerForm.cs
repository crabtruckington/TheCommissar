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
    public partial class powerForm : Form
    {

        List<powerObject> customPowerList;

        public class powerObject
        {
            public string name { get; set; }
            public string discipline { get; set; }
            public string bpcost { get; set; }
            public string dn { get; set; }
            public string activation { get; set; }
            public string duration { get; set; }
            public string range { get; set; }
            public string multi { get; set; }
            public string keywords { get; set; }
        }

        public powerForm()
        {
            InitializeComponent();
            addHomebrewPowers();
            powerDetailLabel.Text = "";
        }

        private void addHomebrewPowers()
        {
            string resourceName = Environment.CurrentDirectory + "\\HomebrewExtensions\\powersHomebrew.json";

            //JObject eBrew = JObject.Parse(File.ReadAllText(resourceName));

            try
            {
                customPowerList = JsonConvert.DeserializeObject<List<powerObject>>(File.ReadAllText(resourceName));
                foreach (powerObject x in customPowerList)
                {
                    string name = x.name;
                    powerSelectBox.Items.Add(name);
                }
            }
            catch (IOException)
            {
                string message = "Cant find the powersHomebrew.json file! Have you moved it? Do you have read access to the directory the program is running from?";
                string caption = "Error!";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, button, MessageBoxIcon.Error);
            }
            catch
            {
                string message = "There was an error loading from powersHomebrew.json! Did you make a mistake in your syntax?";
                string caption = "Error!";
                MessageBoxButtons button = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, button, MessageBoxIcon.Error);
            }
        }

        private void powerSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string curItem = powerSelectBox.SelectedItem.ToString();
            var result = getPowerDetails(curItem);
            powerDetailLabel.Text = result.Item1.Item2 + Environment.NewLine + Environment.NewLine +
                                    "BP Cost: " + result.Item1.Item3 + Environment.NewLine + Environment.NewLine +
                                    result.Item1.Item4 + Environment.NewLine + Environment.NewLine +
                                    result.Item1.Item5 + Environment.NewLine + Environment.NewLine +
                                    result.Item2.Item1 + Environment.NewLine + Environment.NewLine +
                                    result.Item2.Item2 + Environment.NewLine + Environment.NewLine +
                                    result.Item2.Item3 + Environment.NewLine + Environment.NewLine +
                                    result.Item2.Item4;
        }

        public string returnPowerDetails()
        {
            string result = powerSelectBox.SelectedItem.ToString();
            return result;
        }

        public Tuple<Tuple<string, string, string, string, string>, Tuple<string, string, string, string>> getPowerDetails(string SelectedPower)
        {
            Tuple<Tuple<string, string, string, string, string>, Tuple<string, string, string, string>> result;
            string power = SelectedPower;
            string discipline = "";
            string bpcost = "";
            string dn = "";
            string activation = "";
            string duration = "";
            string range = "";
            string multi = "";
            string keywords = "";

            if (power == "Chameleon")
            {
                discipline = "Discipline: Minor Psychic Powers";
                bpcost = "8";
                dn = "DN: 4";
                activation= "Activation: Action";
                duration = "Duration: Sustained";
                range = "Range: Self";
                multi = "Multi-Target: No";
                keywords = "Keywords: Psychic";
            }
            else if (power == "Compel")
            {
                discipline = "Discipline: Minor Psychic Powers";
                bpcost = "10";
                dn = "DN: 5";
                activation= "Activation: 2 Simple Actions";
                duration = "Duration: 1 Round";
                range = "Range: 5 Meters";
                multi = "Multi-Target: No";
                keywords = "Keywords: Psychic";
            }
            else if (power == "Conceal Phenomena")
            {
                discipline = "Discipline: Minor Psychic Powers";
                bpcost = "5";
                dn = "DN: 3";
                activation= "Activation: Full Action";
                duration = "Duration: Sustained";
                range = "Range: Self";
                multi = "Multi-Target: No";
                keywords = "Keywords: Psychic";
            }
            else if (power == "Create Flame")
            {
                discipline = "Discipline: Minor Psychic Powers";
                bpcost = "10";
                dn = "DN: 4";
                activation= "Activation: Move Action";
                duration = "Duration: Sustained";
                range = "Range: Self";
                multi = "Multi-Target: No";
                keywords = "Keywords: Fire, Psychic";
            }
            else if (power == "Dull Pain")
            {
                discipline = "Discipline: Minor Psychic Powers";
                bpcost = "8";
                dn = "DN: 4";
                activation= "Activation: Move Action";
                duration = "Duration: 1 Round";
                range = "Range: 5 Meters";
                multi = "Multi-Target: Yes";
                keywords = "Keywords: Psychic";
            }
            else if (power == "Flash Bang ")
            {
                discipline = "Discipline: Minor Psychic Powers";
                bpcost = "8";
                dn = "DN: 4";
                activation= "Activation: Action";
                duration = "Duration: Instant";
                range = "Range: 5 Meters";
                multi = "Multi-Target: Yes";
                keywords = "Keywords: Auditory, Light, Psychic";
            }
            else if (power == "Fortune")
            {
                discipline = "Discipline: Minor Psychic Powers";
                bpcost = "10";
                dn = "DN: 4";
                activation= "Activation: 2 Simple Actions";
                duration = "Duration: 1 Round";
                range = "Range: Self";
                multi = "Multi-Target: No";
                keywords = "Keywords: Psychic";
            }
            else if (power == "Inflict Pain")
            {
                discipline = "Discipline: Minor Psychic Powers";
                bpcost = "8";
                dn = "DN: 4";
                activation= "Activation: Action";
                duration = "Duration: Sustained";
                range = "Range: 5 Meters";
                multi = "Multi-Target: Yes";
                keywords = "Keywords: Psychic";
            }
            else if (power == "Jam Mechanism")
            {
                discipline = "Discipline: Minor Psychic Powers";
                bpcost = "10";
                dn = "DN: 4";
                activation= "Activation: Action";
                duration = "Duration: Instant";
                range = "Range: 25 Meters";
                multi = "Multi-Target: Yes";
                keywords = "Keywords: Kinetic, Psychic";
            }
            else if (power == "Levitation")
            {
                discipline = "Discipline: Minor Psychic Powers";
                bpcost = "7";
                dn = "DN: 4";
                activation= "Activation: Simple Action";
                duration = "Duration: Sustained";
                range = "Range: Self";
                multi = "Multi-Target: No";
                keywords = "Keywords: Psychic";
            }
            else if (power == "Orb")
            {
                discipline = "Discipline: Minor Psychic Powers";
                bpcost = "5";
                dn = "DN: 2";
                activation= "Activation: Simple Action";
                duration = "Duration: Sustained";
                range = "Range: 5 Meters";
                multi = "Multi-Target: No";
                keywords = "Keywords: Electric, Psychic";
            }
            else if (power == "Phantom Grip")
            {
                discipline = "Discipline: Minor Psychic Powers";
                bpcost = "8";
                dn = "DN: 4";
                activation= "Activation: Full Action";
                duration = "Duration: Sustained";
                range = "Range: 10 Meters";
                multi = "Multi-Target: No";
                keywords = "Keywords: Kinetic, Psychic";
            }
            else if (power == "Psyniscience")
            {
                discipline = "Discipline: Minor Psychic Powers";
                bpcost = "5";
                dn = "DN: 2";
                activation= "Activation: Full Action";
                duration = "Duration: Sustained";
                range = "Range: 100 Meters";
                multi = "Multi-Target: No";
                keywords = "Keywords: Psychic";
            }
            else if (power == "Shove")
            {
                discipline = "Discipline: Minor Psychic Powers";
                bpcost = "8";
                dn = "DN: 3";
                activation= "Activation: Action";
                duration = "Duration: Instant";
                range = "Range: 15 Meters";
                multi = "Multi-Target: No";
                keywords = "Keywords: Kinetic, Psychic";
            }
            else if (power == "Voices")
            {
                discipline = "Discipline: Minor Psychic Powers";
                bpcost = "5";
                dn = "DN: 3";
                activation= "Activation: Action";
                duration = "Duration: Sustained";
                range = "Range: 25 Meters";
                multi = "Multi-Target: No";
                keywords = "Keywords: Auditory, Psychic";
            }
            else if (power == "Smite")
            {
                discipline = "Discipline: Universal Psychic Dsciplines";
                bpcost = "0";
                dn = "DN: Targets Defence";
                activation= "Activation: Action";
                duration = "Duration: Instant";
                range = "Range: 35 Meters";
                multi = "Multi-Target: Yes";
                keywords = "Keywords: Psychic";
            }
            else if (power == "Enfeeble")
            {
                discipline = "Discipline: Biomancy";
                bpcost = "15";
                dn = "DN: Targets Defence";
                activation= "Activation: Action";
                duration = "Duration: Sustained";
                range = "Range: 10 Meters";
                multi = "Multi-Target: Yes";
                keywords = "Keywords: Psychic";
            }
            else if (power == "Life Leech")
            {
                discipline = "Discipline: Biomancy";
                bpcost = "15";
                dn = "DN: Targets Defence";
                activation= "Activation: Action";
                duration = "Duration: Instant";
                range = "Range: 5 Meters";
                multi = "Multi-Target: No";
                keywords = "Keywords: Psychic";
            }
            else if (power == "Living Lightning")
            {
                discipline = "Discipline: Biomancy";
                bpcost = "15";
                dn = "DN: 7";
                activation= "Activation: Action";
                duration = "Duration: Sustained";
                range = "Range: Self";
                multi = "Multi-Target: No";
                keywords = "Keywords: Psychic";
            }
            else if (power == "Phantom Form")
            {
                discipline = "Discipline: Biomancy";
                bpcost = "15";
                dn = "DN: 7";
                activation= "Activation: Action";
                duration = "Duration: Sustained";
                range = "Range: Self";
                multi = "Multi-Target: No";
                keywords = "Keywords: Psychic";
            }
            else if (power == "Regenerate")
            {
                discipline = "Discipline: Biomancy";
                bpcost = "15";
                dn = "DN: 8";
                activation= "Activation: Action";
                duration = "Duration: Sustained";
                range = "Range: Self";
                multi = "Multi-Target: No";
                keywords = "Keywords: Psychic";
            }
            else if (power == "Forewarning")
            {
                discipline = "Discipline: Divination";
                bpcost = "15";
                dn = "DN: 6";
                activation= "Activation: Full Action";
                duration = "Duration: 1 Combat";
                range = "Range: Self";
                multi = "Multi-Target: No";
                keywords = "Keywords: Psychic";
            }
            else if (power == "Glimpse the Future")
            {
                discipline = "Discipline: Divination";
                bpcost = "15";
                dn = "DN: 7";
                activation= "Activation: 30 Minutes";
                duration = "Duration: 1 Scene";
                range = "Range: Self";
                multi = "Multi-Target: No";
                keywords = "Keywords: Psychic";
            }
            else if (power == "Prophetic Visions")
            {
                discipline = "Discipline: Divination";
                bpcost = "5";
                dn = "DN: 10";
                activation= "Activation: 20 Minutes";
                duration = "Duration: Instant";
                range = "Range: Self";
                multi = "Multi-Target: No";
                keywords = "Keywords: Psychic";
            }
            else if (power == "Scry")
            {
                discipline = "Discipline: Divination";
                bpcost = "5";
                dn = "DN: 6";
                activation= "Activation: Full Action";
                duration = "Duration: Sustained";
                range = "Range: 5 Kilometers";
                multi = "Multi-Target: No";
                keywords = "Keywords: Psychic";
            }
            else if (power == "Omens of Doom")
            {
                discipline = "Discipline: Divination";
                bpcost = "15";
                dn = "DN: Targets Defence";
                activation= "Activation: Full Action";
                duration = "Duration: Sustained";
                range = "Range: 30 Meters";
                multi = "Multi-Target: Yes";
                keywords = "Keywords: Psychic";
            }
            else if (power == "Fiery Form")
            {
                discipline = "Discipline: Pyromancy";
                bpcost = "15";
                dn = "DN: 7";
                activation= "Activation: Action";
                duration = "Duration: Sustained";
                range = "Range: Self";
                multi = "Multi-Target: No";
                keywords = "Keywords: Fire, Psychic";
            }
            else if (power == "Gout of Flame")
            {
                discipline = "Discipline: Pyromancy";
                bpcost = "5";
                dn = "DN: 5";
                activation= "Activation: Action";
                duration = "Duration: Action";
                range = "Range: 30 Meters";
                multi = "Multi-Target: No";
                keywords = "Keywords: Fire, Psychic";
            }
            else if (power == "Molten Beam")
            {
                discipline = "Discipline: Pyromancy";
                bpcost = "20";
                dn = "DN: Targets Defence";
                activation= "Activation: Action";
                duration = "Duration: Instant";
                range = "Range: 10 Meters";
                multi = "Multi-Target: No";
                keywords = "Keywords: Fire, Psychic";
            }
            else if (power == "Spontaneous Cumbustion")
            {
                discipline = "Discipline: Pyromancy";
                bpcost = "10";
                dn = "DN: Targets Defence";
                activation= "Activation: Action";
                duration = "Duration: Instant";
                range = "Range: 20 Meters";
                multi = "Multi-Target: Yes";
                keywords = "Keywords: Fire, Psychic";
            }
            else if (power == "Wall of Flame")
            {
                discipline = "Discipline: Pyromancy";
                bpcost = "15";
                dn = "DN: 7";
                activation= "Activation: Action";
                duration = "Duration: Sustained";
                range = "Range: 20 Meters";
                multi = "Multi-Target: No";
                keywords = "Keywords: Fire, Psychic";
            }
            else if (power == "Assail")
            {
                discipline = "Discipline: Telekinesis";
                bpcost = "10";
                dn = "DN: Targets Defence";
                activation= "Activation: Action";
                duration = "Duration: Instant";
                range = "Range: 20 Meters";
                multi = "Multi-Target: Yes";
                keywords = "Keywords: Kinetic, Psychic";
            }
            else if (power == "Crush")
            {
                discipline = "Discipline: Telekinesis";
                bpcost = "10";
                dn = "DN: Targets Defence";
                activation= "Activation: Action";
                duration = "Duration: Instant";
                range = "Range: 20 Meters";
                multi = "Multi-Target: Yes";
                keywords = "Keywords: Kinetic, Psychic";
            }
            else if (power == "Flight")
            {
                discipline = "Discipline: Telekinesis";
                bpcost = "8";
                dn = "DN: 5";
                activation= "Activation: Action";
                duration = "Duration: Sustained";
                range = "Range: Self";
                multi = "Multi-Target: No";
                keywords = "Keywords: Kinetic, Psychic";
            }
            else if (power == "Force Field")
            {
                discipline = "Discipline: Telekinesis";
                bpcost = "15";
                dn = "DN: 5";
                activation= "Activation: Full Action";
                duration = "Duration: Sustained";
                range = "Range: Self";
                multi = "Multi-Target: No";
                keywords = "Keywords: Kinetic, Psychic";
            }
            else if (power == "Shockwave")
            {
                discipline = "Discipline: Telekinesis";
                bpcost = "15";
                dn = "DN: 7";
                activation= "Activation: Action";
                duration = "Duration: Instant";
                range = "Range: 5 Meters";
                multi = "Multi-Target: No";
                keywords = "Keywords: Kinetic, Psychic";
            }
            else if (power == "Fog the Mind")
            {
                discipline = "Discipline: Telepathy";
                bpcost = "15";
                dn = "DN: 4";
                activation= "Activation: Full Action";
                duration = "Duration: Sustained";
                range = "Range: 10 Meters";
                multi = "Multi-Target: No";
                keywords = "Keywords: Telepathy, Psychic";
            }
            else if (power == "Mind Probe")
            {
                discipline = "Discipline: Telepathy";
                bpcost = "15";
                dn = "DN: Targets Willpower (Opposed)";
                activation= "Activation: Full Action";
                duration = "Duration: Sustained";
                range = "Range: 30 Meters";
                multi = "Multi-Target: No";
                keywords = "Keywords: Telepathy, Psychic";
            }
            else if (power == "Psychic Shriek")
            {
                discipline = "Discipline: Telepathy";
                bpcost = "10";
                dn = "DN: Targets Willpower";
                activation= "Activation: Action";
                duration = "Duration: Instant";
                range = "Range: 50 Meters";
                multi = "Multi-Target: Yes";
                keywords = "Keywords: Psychic";
            }
            else if (power == "Telepathy")
            {
                discipline = "Discipline: Telepathy";
                bpcost = "5";
                dn = "DN: 3";
                activation= "Activation: Action";
                duration = "Duration: Sustained";
                range = "Range: 100 Meters";
                multi = "Multi-Target: Yes";
                keywords = "Keywords: Telepathy, Psychic";
            }
            else if (power == "Terrify")
            {
                discipline = "Discipline: Telepathy";
                bpcost = "15";
                dn = "DN: 5";
                activation= "Activation: Full Action";
                duration = "Duration: Instant";
                range = "Range: 10 Meters";
                multi = "Multi-Target: No";
                keywords = "Keywords: Telepathy, Psychic";
            }
            else if (power == "Boil Blood")
            {
                discipline = "Discipline: Maleficarum";
                bpcost = "15";
                dn = "DN: 7";
                activation= "Activation: Action";
                duration = "Duration: Instant";
                range = "Range: 20 Meters";
                multi = "Multi-Target: No";
                keywords = "Keywords: Chaos, Psychic";
            }
            else if (power == "Puppet Master")
            {
                discipline = "Discipline: Maleficarum";
                bpcost = "20";
                dn = "DN: Targets Willpower (Opposed)";
                activation= "Activation: Full Action";
                duration = "Duration: Sustained";
                range = "Range: 30 Meters";
                multi = "Multi-Target: No";
                keywords = "Keywords: Chaos, Psychic";
            }
            else if (power == "Soul Shrivel")
            {
                discipline = "Discipline: Maleficarum";
                bpcost = "20";
                dn = "DN: Targets Defence";
                activation= "Activation: Action";
                duration = "Duration: Instant";
                range = "Range: 20 Meters";
                multi = "Multi-Target: Yes";
                keywords = "Keywords: Chaos, Psychic";
            }
            else if (power == "Touch of Corruption")
            {
                discipline = "Discipline: Maleficarum";
                bpcost = "15";
                dn = "DN: Targets Defence";
                activation= "Activation: Action";
                duration = "Duration: Sustained";
                range = "Range: Touch";
                multi = "Multi-Target: Yes";
                keywords = "Keywords: Chaos, Psychic";
            }
            else if (power == "Waking Nightmare")
            {
                discipline = "Discipline: Maleficarum";
                bpcost = "10";
                dn = "DN: Targets Willpower";
                activation= "Activation: Action";
                duration = "Duration: Sustained";
                range = "Range: 25 Meters";
                multi = "Multi-Target: Yes";
                keywords = "Keywords: Chaos, Psychic";
            }
            else if (power == "Conceal/Reveal")
            {
                discipline = "Discipline: Runes of Battle";
                bpcost = "20";
                dn = "DN: 5";
                activation= "Activation: Action";
                duration = "Duration: Sustained";
                range = "Range: 25 Meters";
                multi = "Multi-Target: No";
                keywords = "Keywords: Aeldari, Psychic";
            }
            else if (power == "Embolden/Horrify")
            {
                discipline = "Discipline: Runes of Battle";
                bpcost = "20";
                dn = "DN: 5";
                activation= "Activation: Action";
                duration = "Duration: Sustained";
                range = "Range: 25 Meters";
                multi = "Multi-Target: No";
                keywords = "Keywords: Psychic";
            }
            else if (power == "Empower/Enervate")
            {
                discipline = "Discipline: Runes of Battle";
                bpcost = "30";
                dn = "DN: 5";
                activation= "Activation: Action";
                duration = "Duration: Sustained";
                range = "Range: 25 Meters";
                multi = "Multi-Target: No";
                keywords = "Keywords: Psychic";
            }
            else if (power == "Enhance/Drain")
            {
                discipline = "Discipline: Runes of Battle";
                bpcost = "20";
                dn = "DN: 5";
                activation= "Activation: Action";
                duration = "Duration: Sustained";
                range = "Range: 25 Meters";
                multi = "Multi-Target: No";
                keywords = "Keywords: Psychic";
            }
            else if (power == "Protect/Jinx")
            {
                discipline = "Discipline: Runes of Battle";
                bpcost = "20";
                dn = "DN: 5";
                activation= "Activation: Action";
                duration = "Duration: Sustained";
                range = "Range: 25 Meters";
                multi = "Multi-Target: No";
                keywords = "Keywords: Psychic";
            }
            else if (power == "Quicken/Delay")
            {
                discipline = "Discipline: Runes of Battle";
                bpcost = "20";
                dn = "DN: 5";
                activation= "Activation: Action";
                duration = "Duration: Sustained";
                range = "Range: 25 Meters";
                multi = "Multi-Target: No";
                keywords = "Keywords: Psychic";
            }
            else
            {
                discipline = "Discipline: ";
                bpcost = "";
                dn = "DN: ";
                activation= "Activation: ";
                duration = "Duration: ";
                range = "Range: ";
                multi = "Multi-Target: ";
                keywords = "Keywords: ";

                foreach (powerObject x in customPowerList)
                {
                    if (power == x.name)
                    {
                        discipline = "Discipline: " + x.discipline;
                        bpcost = x.bpcost;
                        dn = "DN: " + x.dn;
                        activation = "Activation: " + x.activation;
                        duration = "Duration: " + x.duration;
                        range = "Range: " + x.range;
                        multi = "Multi-Target: " + x.multi;
                        keywords = "Keywords: " + x.keywords;

                    }
                }

            }
            result = Tuple.Create(Tuple.Create(power, discipline, bpcost, dn, activation), Tuple.Create(duration, range, multi, keywords));
            return result;

        }

        }
}
