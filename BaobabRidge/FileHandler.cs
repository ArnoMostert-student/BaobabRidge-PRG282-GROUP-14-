using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace BaobabRidge
{
    // Handles reading and writing animal records to animals.txt.
    public class FileHandler
    {
        // Stores the path to animals.txt beside the running application.
        private readonly string filePath =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "animals.txt");

        // Loads valid animal records and counts malformed lines.
        public List<Animal> LoadAnimals(out int skippedLines)
        {
            List<Animal> animals = new List<Animal>();
            skippedLines = 0;

            try
            {
                // Create an empty file if animals.txt does not exist.
                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Close();
                }

                // Read all lines from the file.
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    // Split the line into fields using the pipe character.
                    string[] fields = line.Split('|');

                    // Skip lines that do not contain exactly seven fields.
                    if (fields.Length != 7)
                    {
                        skippedLines++;
                        continue;
                    }

                    // Remove unnecessary spaces from text fields.
                    string animalID = fields[0].Trim().ToUpper();
                    string name = fields[1].Trim();
                    string species = fields[2].Trim();

                    // Convert the age and recovery score to whole numbers.
                    if (!int.TryParse(fields[3].Trim(), out int age) || !int.TryParse(fields[4].Trim(), out int score))
                    {
                        skippedLines++;
                        continue;
                    }

                    // Check the animal ID format.
                    bool isValidId = Regex.IsMatch(animalID, @"^WR-\d{4}$");
                    if (!isValidId)
                    {
                        skippedLines++;
                        continue;
                    }

                    // Create the animal using the constructor in Animal.cs.
                    Animal animal = new Animal(animalID, name, species, age, score);

                    // Store the valid animal in the list.
                    animals.Add(animal);
                }
            }
            catch (IOException)
            {
                MessageBox.Show("The animal file could not be accessed. Please close any program using it and try again.");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("You do not have permission to access the animal file.");
            }
            catch (Exception)
            {
                MessageBox.Show("An unexpected error occurred while loading animal records.");
            }

            // Return all valid animal records.
            return animals;
        }

        // Appends a new animal record to animals.txt.
        public void AddAnimal(Animal animal)
        {
            // TODO: Convert the animal properties into the required file format.
            // TODO: Append one line without overwriting existing records.
            // TODO: Handle file-related exceptions.
        }

        // Rewrites animals.txt with the updated animal record.
        public void UpdateAnimal(string animalID, Animal updatedAnimal)
        {
            // TODO: Load the current records.
            // TODO: Replace only the matching animal.
            // TODO: Rewrite the file with all records in their original order.
            // TODO: Handle file-related exceptions.
        }

        // Removes the specified animal from animals.txt.
        // Removes the first record matching the supplied animal ID.
        public bool DeleteAnimal(string animalID)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("The animal file could not be found.");
                    return false;
                }

                // Keep the original lines so unrelated records are preserved.
                List<string> lines = File.ReadAllLines(filePath).ToList();

                int indexToDelete = lines.FindIndex(line =>
                {
                    string[] fields = line.Split('|');

                    return fields.Length == 7 &&
                           fields[0].Trim().Equals(
                               animalID.Trim(),
                               StringComparison.OrdinalIgnoreCase);
                });

                if (indexToDelete == -1)
                {
                    MessageBox.Show("The selected animal was not found.");
                    return false;
                }

                // Remove only the matching record.
                lines.RemoveAt(indexToDelete);

                // Write the remaining records back in their original order.
                File.WriteAllLines(filePath, lines);

                return true;
            }
            catch (IOException)
            {
                MessageBox.Show(
                    "The animal file could not be accessed. Close any program using it and try again.");
                return false;
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    "You do not have permission to modify the animal file.");
                return false;
            }
        



    }
            
        }
}

