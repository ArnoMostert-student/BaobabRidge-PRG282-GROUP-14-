using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BaobabRidge
{
    /// <summary>
    /// Represents an animal currently being cared for at the rehabilitation centre.
    /// Stores the animal's details and determines its recovery status and housing unit.
    /// </summary>
    public class Animal
    {
        // Stores the basic animal details entered by the user.
        public string AnimalID { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }

        // Stores the recovery score and the classification calculated by the system.
        public int RecoveryScore { get; private set; }
        public string Status { get; private set; }
        public string HousingUnit { get; private set; }

        public Animal(string animalID, string name, string species, int age, int recoveryScore)
        {
            // Assigns the provided values to the animal's properties.
            AnimalID = animalID;
            Name = name;
            Species = species;
            Age = age;
            RecoveryScore = recoveryScore;

            // Determines the animal's status and housing unit based on its recovery score.
            ClassifyAnimal();
        }

        // Determines the animal's recovery status and housing unit based on its recovery score.
        public void ClassifyAnimal()
        {
            if (RecoveryScore >= 0 && RecoveryScore <= 19)
            {
                Status = "Critical";
                HousingUnit = "Intensive Care Unit";
            }
            else if (RecoveryScore <= 39)
            {
                Status = "Serious";
                HousingUnit = "High-Dependency Ward";
            }
            else if (RecoveryScore <= 59)
            {
                Status = "Stable";
                HousingUnit = "Recovery Ward";
            }
            else if (RecoveryScore <= 79)
            {
                Status = "Recovering";
                HousingUnit = "Outdoor Enclosure";
            }
            else if (RecoveryScore <= 100)
            {
                Status = "Release-Ready";
                HousingUnit = "Pre-Release Camp";
            }
            else
            {
                // Assigns an invalid classification when the recovery score exceeds the allowed range.
                Status = "Invalid";
                HousingUnit = "Invalid";
            }

        }

    }
}
