using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunPlus_MapTweaker
{
    public class CustomWave
    {
        public int maxNPC = 15;
        public CustomWaveInfo waveInfo;


        public class CustomWaveInfo
        {
            public int totalCount = 5;

            public string defaultNPC = "Newborn_Bot";

            public specialNPC[] npc;

        }
        public class specialNPC
        {
            public string npcName;
            public int spawnChance;
            public bool isBoss;
        }
    }
    public class AllWaves
    {
        public AllWaves() { }
        public AllWaves(List<CustomWave> waves) 
        { 
            this.waves = waves;
        }
        public List<CustomWave> waves;
    }
}
