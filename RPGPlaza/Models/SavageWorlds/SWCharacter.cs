using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using RPGPlaza.Models;
using Newtonsoft.Json;

namespace RPGPlaza.Models
{
    public enum SWDice { d0, d4, d6, d8, d10, d12, d12_1, d12_2, d12_3, d12_4, d12_5, d12_6, d12_7, d12_8, d12_9, d12_10, d12_11, d12_12 };
    public enum SWLevel { Major, Minor };
    public enum SWAttributes { Agility, Smarts, Spirit, Strength, Vigor };


    public class SWCharacter
    {
        [Key]
        public int Id { get; set; }

        // Details
        public String Name { get; set; }
        public String Race { get; set; }
        public String Gender { get; set; }
        public String Description { get; set; }
        public String Background { get; set; }

        // Attributes
        public SWDice Agility { get; set; }
        public SWDice Smarts { get; set; }
        public SWDice Spirit { get; set; }
        public SWDice Strength { get; set; }
        public SWDice Vigor { get; set; }

        // Other
        public double Wealth { get; set; }
        public int XP { get; set; }


        /*
         *  Database variables, data serialized for database using JSON.Net  http://www.newtonsoft.com/json/help/html/SerializingJSON.htm         
         */
        public String SkillsJson { get; set; }
        public String HindrancesJson { get; set; }
        public String EdgesJson { get; set; }
        public String AdvancesNoviceJson { get; set; }
        public String AdvancesSeasonedJson { get; set; }
        public String AdvancesVeteranJson { get; set; }
        public String AdvancesHeroicJson { get; set; }
        public String AdvancesLegendaryJson { get; set; }
        public String WeaponsJson { get; set; }
        public String ArmoursJson { get; set; }
        public String MundaneItemsJson { get; set; }


        // methods
        public SWCharacter()
        {
            Agility = SWDice.d4;
            Smarts = SWDice.d4;
            Spirit = SWDice.d4;
            Strength = SWDice.d4;
            Vigor = SWDice.d4;


        }

        public SWCharacterVM SeedViewModel()
        {
            SWCharacterVM model = new SWCharacterVM();
            ReadJSON(model);

            return model;
        }

        public void SaveViewModel(SWCharacterVM model)
        {
            WriteJSON(model);
            // save model to database, called here via controller
        }

        // reads from Json Strings and puts into the SWCharacterVM variables
        private void ReadJSON(SWCharacterVM model)
        {
            model.Skills = JsonConvert.DeserializeObject<List<SWCharacterVM.SWSkillChar>>(SkillsJson);
            model.Hindrances = JsonConvert.DeserializeObject<List<SWHindrance>>(HindrancesJson);
            model.Edges = JsonConvert.DeserializeObject<List<SWEdge>>(EdgesJson);
            // run these to test, if works add the advances

        }

        // reads from the class variables and creates Json data in strings to save to database
        private void WriteJSON(SWCharacterVM model)
        {
            SkillsJson = JsonConvert.SerializeObject(model.Skills);
            HindrancesJson = JsonConvert.SerializeObject(model.Hindrances);
            EdgesJson = JsonConvert.SerializeObject(model.Edges);
            AdvancesNoviceJson = JsonConvert.SerializeObject(model.AdvancesNovice);
            AdvancesSeasonedJson = JsonConvert.SerializeObject(model.AdvancesSeasoned);
            AdvancesVeteranJson = JsonConvert.SerializeObject(model.AdvancesVeteran);
            AdvancesHeroicJson = JsonConvert.SerializeObject(model.AdvancesHeroic);
            AdvancesLegendaryJson = JsonConvert.SerializeObject(model.AdvancesLegendary);
            WeaponsJson = JsonConvert.SerializeObject(model.Weapons);
            ArmoursJson = JsonConvert.SerializeObject(model.Armours);
            MundaneItemsJson = JsonConvert.SerializeObject(model.MundaneItems);
        }
    }

    // Book class
    public class SWBook
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
    }

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

    // Skill class
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

    public class SWEdgeType
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Text { get; set; }
    }

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
