using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaobabRidge
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // Load animal records when the application starts.
            LoadAnimalsIntoGrid();
        }

        // Loads animal records from the file and displays them in the DataGridView.
        private void LoadAnimalsIntoGrid()
        {
            // Create a FileHandler to read the animal records.
            FileHandler fileHandler = new FileHandler();

            // Load the animals and count any malformed lines.
            List<Animal> animals = fileHandler.LoadAnimals(out int skippedLines);

            // Display the animal records in the DataGridView.
            dgvAnimals.DataSource = null;
            dgvAnimals.DataSource = animals;

            // Show a warning if any malformed lines were skipped.
            if (skippedLines > 0)
            {
                MessageBox.Show($"{skippedLines} invalid line(s) were skipped while loading animals.txt.");
            }
        }

        private void dgvAnimals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtAnimalID.Text.Trim().ToUpper();
            string name = txtName.Text.Trim().ToUpper();
            string species = txtSpecies.Text.Trim().ToUpper();
            string age = txtAge.Text.Trim().ToUpper();
            string score = txtScore.Text.Trim().ToUpper();

            if (!Regex.IsMatch(id,@"^WR-\d{4}$"))
            {
                MessageBox.Show("Animal ID should be within a specific format, WR-followed by 4 digits (Eg. WR-004");
                txtAnimalID.Focus();
                return;
            }
            FileHandler fileHandler = new FileHandler();
            int skipped;
            var existingAnimals = fileHandler.LoadAnimals(out skipped);

            if (existingAnimals.Any(a => a.AnimalID.Equals(id,StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("This ID already exists. Animal ID must be unique, please try again.");
                txtAnimalID.Focus();
                return;
            }
            if (string.IsNullOrEmpty(name) || name.Length > 30 || name.Contains("|"))
            {
                MessageBox.Show("Animal name must be filled in. Must be between 1 and 30 characters and cannot contain the pipe character (|)");
                txtName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(species) || species.Length > 30 || species.Contains("|"))
            {
                MessageBox.Show("Animal Species must be filled in. Must be between 1 and 30 characters and cannot contain the pipe character (|)");
                txtSpecies.Focus();
                return;
            }
            if (!int.TryParse(age, out int ageValue) || ageValue < 0 || ageValue > 100)
            {
                MessageBox.Show("Age must be between 0 and 100 years old. Must be a whole number.");
                txtAge.Focus();
                return;
            }
            if (!int.TryParse(score, out int scoreValue) || scoreValue < 0 || scoreValue > 100)
            {
                MessageBox.Show("Score must be between 0 and 100 years old. Must be a whole number.");
                txtScore.Focus();
                return;
            }
            Animal animal = new Animal(id,name,species,ageValue,scoreValue);
            fileHandler.AddAnimal(animal);
            MessageBox.Show($"Animal has been succesfully added\nStatus: {animal.Status}\nHousing Unit: {animal.HousingUnit}","Successful",MessageBoxButtons.OK,MessageBoxIcon.Information);
            ClearAllInputs();
            LoadAnimalsIntoGrid();




        }
        private void ClearAllInputs()
        {
            txtAnimalID.Clear();
            txtName.Clear();
            txtAge.Clear();
            txtScore.Clear();
            txtSearchID.Clear();
            txtSpecies.Clear();
        }
       
    }
}
