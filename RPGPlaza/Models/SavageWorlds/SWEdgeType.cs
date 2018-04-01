using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RPGPlaza.Models.SavageWorlds
{
    public class SWEdgeType
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Text { get; set; }
    }
}
