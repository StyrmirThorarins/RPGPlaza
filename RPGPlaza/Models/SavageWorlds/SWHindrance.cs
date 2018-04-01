using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static RPGPlaza.Models.SavageWorlds.SWSupport;

namespace RPGPlaza.Models.SavageWorlds
{
    // Hindrance class
    public class SWHindrance
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public String Name { get; set; }
        public SWLevel Level { get; set; }
        public String Effects { get; set; }
        public String Text { get; set; }
    }

    // Custom hindrance class
    public class SWHindranceCustom
    {
        [Key]
        public int Id { get; set; }
        //public int BookId { get; set; }
        public String UserID { get; set; }
        public String Name { get; set; }
        public SWLevel Level { get; set; }
        public String Effects { get; set; }
        public String Text { get; set; }
    }
}