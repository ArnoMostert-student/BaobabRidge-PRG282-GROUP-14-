using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    }
}
