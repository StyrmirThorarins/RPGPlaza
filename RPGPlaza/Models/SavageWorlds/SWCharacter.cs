using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using RPGPlaza.Models;
using Newtonsoft.Json;
using RPGPlaza.Models.SavageWorlds;
using static RPGPlaza.Models.SavageWorlds.SWSupport;

namespace RPGPlaza.Models
{

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

}
