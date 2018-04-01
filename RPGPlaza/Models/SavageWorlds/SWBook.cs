using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RPGPlaza.Models.SavageWorlds
{
    // Book class
    public class SWBook
    {       
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
    }
}
