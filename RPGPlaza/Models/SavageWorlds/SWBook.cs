using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RPGPlaza.Models.SavageWorlds
{
    /// <summary>
    /// This class encapsulates Savage Worlds books.
    /// </summary>    
    public class SWBook
    {       
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
    }
}
