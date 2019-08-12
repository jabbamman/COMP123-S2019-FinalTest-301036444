using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Student Name: Mohamed A. Ali 
 * Student ID: 301036444
 * Description: this is the character calss used in character creationb this 
 * is also the data container for applicattion
 * 
 */


namespace COMP123_S2019_FinalTest_301036444.Objects
{
    public class Character
    {
        // 
        public string Strength { get; set; }
        public string Desxterity { get; set; }
        public string Constitution { get; set; }
        public string Intelligence { get; set; }
        public string Wisdom { get; set; }
        public string Charisma { get; set; }

        // Secondary Ability
        public int ArmourClass { get; set; }
        public int HitPoints { get; set; }

        // Chararcter Class
        public CharacterClass Class { get; set; }
        public int Level { get; set; }

        // Equipment
        List<Item> Inventory;

        // Constructor 
        Character()
        {
            this.Inventory = new List<Item>();
        }
    }
}
