using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace FunPlus_MapTweaker
{
    public partial class Form1 : Form
    {
        string sceneName = "";
        string version = "";
        bool isOutside, useTime;
        int mapSize = 0;
        string[] monster = new string[] { "TinkyWinky", "PlayerTinky", "BossTinky" };
        public List<CustomWave> waves = new List<CustomWave>();
        public int wave = 1;
        public Form1()
        {
            InitializeComponent();
            sizeCombo.SelectedIndex = 0;
            vsCombo.SelectedIndex = 0;
            coopCombo.SelectedIndex = 0;
            surCombo.SelectedIndex = 0;
            AddWave(10, 15, "NewBorn_Bot", new CustomWave.specialNPC[] { new CustomWave.specialNPC() { npcName = "NewBorn_Runner_Bot", spawnChance = 6 } });
           // AddWave(20, 15, "NewBorn_Bot", new CustomWave.specialNPC[] { new CustomWave.specialNPC() { npcName = "NewBorn_Runner_Bot", spawnChance = 4 } });
            UpdateValues();
        }

        private void AddWave(int npcCount, int maxNpc, string defaultNpc, CustomWave.specialNPC[] npcs)
        {
            CustomWave wave = new CustomWave();
            wave.maxNPC = maxNpc;
            wave.waveInfo = new CustomWave.CustomWaveInfo();
            wave.waveInfo.defaultNPC = defaultNpc;
            wave.waveInfo.totalCount = npcCount;
            wave.waveInfo.npc = npcs;
            waves.Add(wave);
        }
        private void UpdateValues()
        {
            var w = waves[wave - 1];
            waveTextbox.Text = wave.ToString() + " / " + waves.Count.ToString();
            defaultNPCname.Text = w.waveInfo.defaultNPC;
            maxNPCnum.Value = w.maxNPC;
            countNum.Value = w.waveInfo.totalCount;
            specialNPClist.Items.Clear();
            foreach (CustomWave.specialNPC npc in w.waveInfo.npc)
            {
                specialNPClist.Items.Add($"{npc.npcName}|{npc.spawnChance}|{npc.isBoss}");
            }
        }
        private void SaveValues()
        {
            if (wave <= 0) return;
            var w = waves[wave - 1];
            w.waveInfo.defaultNPC = defaultNPCname.Text;
            w.maxNPC = (int)maxNPCnum.Value;
            w.waveInfo.totalCount = (int)countNum.Value;
            w.waveInfo.npc = new CustomWave.specialNPC[specialNPClist.Items.Count];
            for (var i = 0; i < specialNPClist.Items.Count; i++)
            {
                var npc = specialNPClist.Items[i].ToString();
                w.waveInfo.npc[i] = new CustomWave.specialNPC() { npcName = npc.Split('|')[0], spawnChance = Convert.ToInt32(npc.Split('|')[1]), isBoss = Convert.ToBoolean(npc.Split('|')[2]) };
            }
        }
        private void NextWave()
        {
            SaveValues();
            if (wave == waves.Count) return;
            wave++;
            UpdateValues();
        }
        private void PrevWave()
        {
            SaveValues();
            if (wave <= 1) return;
            wave--;
            UpdateValues();
        }
        private void RemoveWave()
        {
            waves.Remove(waves[wave - 1]);
            waveTextbox.Text = wave.ToString() + " / " + waves.Count.ToString();
        }
        private void AddWave()
        {
            SaveValues();
            wave = waves.Count + 1;
            AddWave(10, 15, "NewBorn_Bot", new CustomWave.specialNPC[] { new CustomWave.specialNPC() { npcName = "NewBorn_Runner_Bot", spawnChance = 4 } });
            waveTextbox.Text = wave.ToString() + " / " + waves.Count.ToString();
        }
        private void waveRemoveButton_Click(object sender, EventArgs e)
        {
            if (wave <= 1)
            {
                if (waves.Count == 1) return;
                NextWave();
                wave--;
                RemoveWave();
            }
            else
            {
                if (waves.Count == 1) return;
                PrevWave();
                RemoveWave();
            }
        }

        private void waveAddButton_Click(object sender, EventArgs e)
        {
            AddWave();
        }
        private void outsideCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            isOutside = outsideCheckBox.Checked;
        }

        private void timeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            useTime = timeCheckBox.Checked;
        }

        private void sizeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            mapSize = sizeCombo.SelectedIndex;
        }

        private void surCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            monster[2] = surCombo.Items[surCombo.SelectedIndex].ToString();
        }

        private void vsCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            monster[1] = vsCombo.Items[vsCombo.SelectedIndex].ToString();
        }

        private void coopCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            monster[0] = coopCombo.Items[coopCombo.SelectedIndex].ToString();
        }

        private void buildButton_Click(object sender, EventArgs e)
        {
            if (sceneName != "")
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    IniFile map = new IniFile(saveFileDialog1.FileName);
                    map.Write("mapName", sceneName, "CustomMap");
                    map.Write("version", version, "CustomMap");
                    map.Write("useDayAndNight", useTime.ToString(), "CustomMap");
                    map.Write("size", mapSize.ToString(), "CustomMap");
                    map.Write("isOutside", isOutside.ToString(), "CustomMap");
                    map.Write("collectMonster", monster[0], "CustomMap");
                    map.Write("versusMonster", monster[1], "CustomMap");
                    map.Write("survivalMonster", monster[2], "CustomMap");
                    MessageBox.Show("Done");
                }
            }
            else
            {
                MessageBox.Show("Enter scene name");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            version = textBox1.Text;
        }

        private void waveNextButton_Click(object sender, EventArgs e)
        {
            NextWave();
        }

        private void wavePrevButton_Click(object sender, EventArgs e)
        {
            PrevWave();
        }

        private void specialAddButton_Click(object sender, EventArgs e)
        {
            specialNPClist.Items.Add($"{specialNPCname.Text}|{spawnChanceNum.Value}|{isBossCheck.Checked}");
        }

        private void specialRemoveButton_Click(object sender, EventArgs e)
        {
            specialNPClist.Items.Remove(specialNPClist.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveValues();
            if (saveFileDialog2.ShowDialog() == DialogResult.OK)
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                var w = new AllWaves();
                //MessageBox.Show(w.waves.Count.ToString());
                string json = JsonSerializer.Serialize(waves, new JsonSerializerOptions { PropertyNamingPolicy = JsonNamingPolicy.CamelCase, WriteIndented = true, IncludeFields = true });
                File.WriteAllText(saveFileDialog2.FileName, json);
               // MessageBox.Show(json);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    IncludeFields = true
                };
                string json = File.ReadAllText(openFileDialog1.FileName);
                waves = JsonSerializer.Deserialize<List<CustomWave>>(json, options);
                UpdateValues();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            waves.Clear();
            wave = 1;
            AddWave(10, 15, "NewBorn_Bot", new CustomWave.specialNPC[] { new CustomWave.specialNPC() { npcName = "NewBorn_Runner_Bot", spawnChance = 4 } });
            UpdateValues();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string defaultPath = AppDomain.CurrentDomain.BaseDirectory + @"\default.json";
            if (File.Exists(defaultPath))
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    IncludeFields = true
                };
                string json = File.ReadAllText(defaultPath);
                waves = JsonSerializer.Deserialize<List<CustomWave>>(json, options);
                UpdateValues();
            }
        }

        private void sceneTextBox_TextChanged(object sender, EventArgs e)
        {
            sceneName = sceneTextBox.Text;
        }
    }
    class IniFile   // revision 11
    {
        string Path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public IniFile(string IniPath = null)
        {
            Path = new System.IO.FileInfo(IniPath ?? EXE + ".ini").FullName;
        }

        public string Read(string Key, string Section = null)
        {
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
            return RetVal.ToString();
        }

        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }

        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? EXE);
        }

        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? EXE);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }
    }
}