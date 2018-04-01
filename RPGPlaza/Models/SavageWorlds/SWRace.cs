using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RPGPlaza.Models.SavageWorlds
{
    // Race class
    public class SWRace
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        public List<Modifier> Modifiers;
        public String ModifiersJson { get; set; }  //json string of modifiers for db

        // each modifier as class
        public class Modifier
        {
            public String Name { get; set; }
            public String Text { get; set; }
        }
    }

    // Custom race class
    public class SWRaceCustom
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public String UserID { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }

        public List<Modifier> Modifiers;
        public String ModifiersJson { get; set; }  //json string of modifiers for db

        // each modifier as class
        public class Modifier
        {
            public String Name { get; set; }
            public String Text { get; set; }
        }
    }
}
