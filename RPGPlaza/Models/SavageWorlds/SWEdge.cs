using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RPGPlaza.Models.SavageWorlds
{
    // Edge class
    public class SWEdge
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public int EdgeTypeId { get; set; }
        public String Name { get; set; }
        public String Requirement { get; set; }
        public String Effects { get; set; }
        public String Text { get; set; }
    }

    // Custom edge class
    public class SWEdgeCustom
    {
        [Key]
        public int Id { get; set; }
        //public int BookId { get; set; }
        public String UserID { get; set; }
        public String Name { get; set; }
        public String Requirement { get; set; }
        public String Effects { get; set; }
        public String Text { get; set; }
    }
}
