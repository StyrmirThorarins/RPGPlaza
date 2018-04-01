using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPGPlaza.Models;
using RPGPlaza.Models.SavageWorlds;
using static RPGPlaza.Models.SavageWorlds.SWSupport;

namespace RPGPlaza.Models
{
    public class SWCharacterVM
    {
        SWCharacter Character = new SWCharacter();

        //Lists
        // Skills       
        public class SWSkillChar
        {
            public SWSkill Skill { get; set; }
            public SWDice Dice { get; set; }
        }
        public List<SWSkillChar> Skills { get; set; }
        public List<SWHindrance> Hindrances { get; set; }
        public List<SWEdge> Edges { get; set; }

        // Advances
        /*
            Experience Points Rank
            0-19 Novice
            20-39 Seasoned
            0-59 Veteran
            60-79 Heroic
            80+ Legendary 
        */
        public List<Object> AdvancesNovice { get; set; }    // 3 advances
        public List<Object> AdvancesSeasoned { get; set; }  // 4 advances
        public List<Object> AdvancesVeteran { get; set; }   // 4 advances
        public List<Object> AdvancesHeroic { get; set; }    // 4 advances
        public List<Object> AdvancesLegendary { get; set; } // 5 advances

        public class WeaponChar
        {
            public SWWeapon Weapon { get; set; }
            public int Count { get; set; }
        }
        public List<WeaponChar> Weapons { get; set; }

        public class SWArmorChar
        {
            public SWArmor Armor { get; set; }
            public int Count { get; set; }
        }
        public List<SWArmorChar> Armours { get; set; }

        public class SWMundaneItemChar
        {
            public SWMundaneItem MundaneItem { get; set; }
            public int Count { get; set; }
        }
        public List<SWMundaneItemChar> MundaneItems { get; set; }

        public SWCharacterVM()
        {
            AdvancesNovice = new List<object>(3);
            AdvancesSeasoned = new List<object>(4);
            AdvancesVeteran = new List<object>(4);
            AdvancesHeroic = new List<object>(4);
            AdvancesLegendary = new List<object>(5);
        }
    }
}
