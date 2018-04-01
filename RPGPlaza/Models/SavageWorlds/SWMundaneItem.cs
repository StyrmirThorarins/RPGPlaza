using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RPGPlaza.Models.SavageWorlds
{
    // Mundane Items class
    public class SWMundaneItem
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public int Type { get; set; }
        public String Name { get; set; }
        public double Weight { get; set; }
        public double Cost { get; set; }
    }

    public class SWMundaneItemCustom
    {
        [Key]
        public int Id { get; set; }
        //public int BookId { get; set; }
        public String UserID { get; set; }
        public int Type { get; set; }
        public String Name { get; set; }
        public double Weight { get; set; }
        public double Cost { get; set; }
    }
}
