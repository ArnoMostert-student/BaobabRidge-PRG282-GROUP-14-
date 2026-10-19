using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        
private Animal selectedAnimal = null;
private FileHandler fileHandler = new FileHandler();

// Finds an animal by its exact ID.
private void btnSearch_Click(object sender, EventArgs e)
{
    string searchID = txtSearchID.Text.Trim();

    foreach (DataGridViewRow row in dgvAnimals.Rows)
    {
        if (row.IsNewRow)
            continue;

        if (row.Cells["Animal ID"].Value.ToString()
            .Equals(searchID, StringComparison.OrdinalIgnoreCase))
        {
            txtAnimalID.Text = row.Cells["Animal ID"].Value.ToString();
            txtName.Text = row.Cells["Name"].Value.ToString();
            txtSpecies.Text = row.Cells["Species"].Value.ToString();
            txtAge.Text = row.Cells["Age"].Value.ToString();
            txtScore.Text = row.Cells["Recovery Score"].Value.ToString();

            selectedAnimal = new Animal(
                txtAnimalID.Text,
                txtName.Text,
                txtSpecies.Text,
                int.Parse(txtAge.Text),
                int.Parse(txtScore.Text));

            txtAnimalID.ReadOnly = true;
            btnAdd.Enabled = false;
            btnSave.Enabled = true;

            return;
        }
    }

    MessageBox.Show("Animal ID not found.");
}

// Validates and saves changes to the selected animal.
private void btnSaveChanges_Click(object sender, EventArgs e)
{
    if (selectedAnimal == null)
    {
        MessageBox.Show("Please select an animal first.");
        return;
    }

    // Reuse Member 2's validation method here.
    if (!ValidateAnimal())
        return;

    string id = txtAnimalID.Text.Trim().ToUpper();
    string name = txtName.Text.Trim();
    string species = txtSpecies.Text.Trim();
    int age = int.Parse(txtAge.Text);
    int score = int.Parse(txtScore.Text);

    // Reuse the same classification method used by Add.
    Animal updatedAnimal = new Animal(id, name, species, age, score);

    ClassifyAnimal(updatedAnimal);

    fileHandler.UpdateAnimal(id, updatedAnimal);

    RefreshAnimalGrid();
    ClearForm();
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
if (e.RowIndex < 0)
        return;

    DataGridViewRow row = dgvAnimals.Rows[e.RowIndex];

    txtAnimalID.Text = row.Cells["Animal ID"].Value.ToString();
    txtName.Text = row.Cells["Name"].Value.ToString();
    txtSpecies.Text = row.Cells["Species"].Value.ToString();
    txtAge.Text = row.Cells["Age"].Value.ToString();
    txtScore.Text = row.Cells["Recovery Score"].Value.ToString();

    selectedAnimal = new Animal(
        txtAnimalID.Text,
        txtName.Text,
        txtSpecies.Text,
        int.Parse(txtAge.Text),
        int.Parse(txtScore.Text));

    txtAnimalID.ReadOnly = true;
    btnAdd.Enabled = false;
    btnSave.Enabled = true;
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

        
       // Reloads the animal records and refreshes the grid.
private void RefreshAnimalGrid()
{
    int skippedLines;

    dgvAnimals.DataSource = null;
    dgvAnimals.DataSource = fileHandler.LoadAnimals(out skippedLines);
}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check whether an animal row has been selected.
            if (dgvAnimals.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an animal to delete.");
                return;
            }

            // Get the animal represented by the selected row.
            Animal selectedAnimal =
                dgvAnimals.SelectedRows[0].DataBoundItem as Animal;

            if (selectedAnimal == null)
            {
                MessageBox.Show("Could not identify the selected animal.");
                return;
            }

            // Ask the user to confirm the deletion.
            DialogResult result = MessageBox.Show(
                $"Delete {selectedAnimal.AnimalID} ({selectedAnimal.Name})? This cannot be undone.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            // Stop if the user chooses No.
            if (result != DialogResult.Yes)
            {
                return;
            }

            // Delete the selected animal from the file.
            FileHandler fileHandler = new FileHandler();
            bool deleted = fileHandler.DeleteAnimal(
                selectedAnimal.AnimalID);

            if (deleted)
            {
                // Clear the fields only if they contain this animal's ID.
                if (txtAnimalID.Text.Trim().Equals(
                    selectedAnimal.AnimalID,
                    StringComparison.OrdinalIgnoreCase))
                {
                    txtAnimalID.Clear();
                    txtName.Clear();
                    txtSpecies.Clear();
                    txtAge.Clear();
                    txtScore.Clear();
                }

                // Reload the table after successful deletion.
                LoadAnimalsIntoGrid();
            }
        }

        private void btnGenerateSummary_Click(object sender, EventArgs e)
        {
            try
            {
                // Load the latest animal records from the file.
                FileHandler fileHandler = new FileHandler();
                List<Animal> animals =
                    fileHandler.LoadAnimals(out int skippedLines);

                // Generate and save the summary report.
                SummaryReport summaryReport = new SummaryReport();
                string reportText = summaryReport.GenerateReport(animals);

                // Do not update the labels if report generation failed.
                if (string.IsNullOrEmpty(reportText))
                {
                    return;
                }

                // Update the summary values displayed on the form.
                int total = animals.Count;

                lblTotalAnimalsValue.Text = total.ToString();

                lblAverageAgeValue.Text = total == 0
                    ? "N/A"
                    : animals.Average(a => a.Age).ToString(
                        "F2", System.Globalization.CultureInfo.InvariantCulture);

                lblAverageScoreValue.Text = total == 0
                    ? "N/A"
                    : animals.Average(a => a.RecoveryScore).ToString(
                        "F2", System.Globalization.CultureInfo.InvariantCulture);

                lblCriticalValue.Text =
                    animals.Count(a => a.Status == "Critical").ToString();

                lblSeriousValue.Text =
                    animals.Count(a => a.Status == "Serious").ToString();

                lblStableValue.Text =
                    animals.Count(a => a.Status == "Stable").ToString();

                lblRecoveringValue.Text =
                    animals.Count(a => a.Status == "Recovering").ToString();

                lblReleaseReadyValue.Text =
                    animals.Count(a => a.Status == "Release-Ready").ToString();

                MessageBox.Show(
                    "Summary report generated successfully.",
                    "Summary Report",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (IOException)
            {
                MessageBox.Show("The summary report could not be written.");
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show(
                    "You do not have permission to write the summary report.");
            }
        }
    }
}

