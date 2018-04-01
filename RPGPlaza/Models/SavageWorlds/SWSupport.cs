using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPGPlaza.Models.SavageWorlds
{
    public static class SWSupport
    {
        public enum SWDice { d0, d4, d6, d8, d10, d12, d12_1, d12_2, d12_3, d12_4, d12_5, d12_6, d12_7, d12_8, d12_9, d12_10, d12_11, d12_12 };
        public enum SWLevel { Major, Minor };
        public enum SWAttributes { Agility, Smarts, Spirit, Strength, Vigor };
    }
}
