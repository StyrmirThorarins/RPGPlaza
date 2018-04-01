using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static RPGPlaza.Models.SavageWorlds.SWSupport;

namespace RPGPlaza.Models.SavageWorlds
{
    // Skill class
    public class SWSkill
    {
        [Key]
        public int Id { get; set; }
        public int BookId { get; set; }
        public String Name { get; set; }
        public SWAttributes LinkedAttribute { get; set; }
        public String Text { get; set; }
    }

    // Custom Skill class
    public class SWSkillCustom
    {
        [Key]
        public int Id { get; set; }
        //public int BookId { get; set; }
        public String UserID { get; set; }
        public String Name { get; set; }
        public SWAttributes LinkedAttribute { get; set; }
        public String Text { get; set; }
    }
}