using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RPGPlaza.Models.SavageWorlds
{
    // Weapon class
    public class SWWeapon
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public int Type { get; set; }
        public int TimePeriod { get; set; }
        public String Name { get; set; }
        public String Damage { get; set; }
        public double Weight { get; set; }
        public double Cost { get; set; }
        public String Notes { get; set; }
    }


    // Custom weapon class
    public class SWWeaponCustom
    {
        [Key]
        public int Id { get; set; }
        //public int BookId { get; set; }
        public String UserID { get; set; }
        public int Type { get; set; }
        public int TimePeriod { get; set; }
        public String Name { get; set; }
        public String Damage { get; set; }
        public double Weight { get; set; }
        public double Cost { get; set; }
        public String Notes { get; set; }
    }
}
