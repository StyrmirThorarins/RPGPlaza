using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RPGPlaza.Models.SavageWorlds
{
    // Armor class
    public class SWArmor
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public int Type { get; set; }
        public int TimePeriod { get; set; }
        public String Name { get; set; }
        public String ArmorValue { get; set; }
        public double Weight { get; set; }
        public double Cost { get; set; }
        public String Notes { get; set; }
    }

    public class SWArmorCustom
    {
        [Key]
        public int Id { get; set; }
        //public int BookId { get; set; }
        public String UserID { get; set; }
        public int Type { get; set; }
        public int TimePeriod { get; set; }
        public String Name { get; set; }
        public String ArmorValue { get; set; }
        public double Weight { get; set; }
        public double Cost { get; set; }
        public String Notes { get; set; }
    }
}
