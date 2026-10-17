using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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

