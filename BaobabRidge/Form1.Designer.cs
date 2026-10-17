namespace BaobabRidge
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.gpbAnimalDetails = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAnimalID = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAnimalID = new System.Windows.Forms.Label();
            this.gpbDataView = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvAnimals = new System.Windows.Forms.DataGridView();
            this.gpbSummaryReport = new System.Windows.Forms.GroupBox();
            this.lblReleaseReadyValue = new System.Windows.Forms.Label();
            this.lblRecoveringValue = new System.Windows.Forms.Label();
            this.lblReleaseReady = new System.Windows.Forms.Label();
            this.lblRecovering = new System.Windows.Forms.Label();
            this.lblStableValue = new System.Windows.Forms.Label();
            this.lblSeriousValue = new System.Windows.Forms.Label();
            this.lblCriticalValue = new System.Windows.Forms.Label();
            this.lblStable = new System.Windows.Forms.Label();
            this.lblSerious = new System.Windows.Forms.Label();
            this.lblCritical = new System.Windows.Forms.Label();
            this.lblAverageScoreValue = new System.Windows.Forms.Label();
            this.lblAverageAgeValue = new System.Windows.Forms.Label();
            this.lblTotalAnimalsValue = new System.Windows.Forms.Label();
            this.lblAverageScore = new System.Windows.Forms.Label();
            this.lblAverageAge = new System.Windows.Forms.Label();
            this.lblTotalAnimals = new System.Windows.Forms.Label();
            this.btnGenerateSummary = new System.Windows.Forms.Button();
            this.lblGenerateSummary = new System.Windows.Forms.Label();
            this.gpbAnimalDetails.SuspendLayout();
            this.gpbDataView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).BeginInit();
            this.gpbSummaryReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(829, 39);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Baobab Ridge Wildlife Rehabilitation Records System";
            // 
            // gpbAnimalDetails
            // 
            this.gpbAnimalDetails.Controls.Add(this.btnClear);
            this.gpbAnimalDetails.Controls.Add(this.btnSave);
            this.gpbAnimalDetails.Controls.Add(this.btnAdd);
            this.gpbAnimalDetails.Controls.Add(this.txtScore);
            this.gpbAnimalDetails.Controls.Add(this.txtAge);
            this.gpbAnimalDetails.Controls.Add(this.txtSpecies);
            this.gpbAnimalDetails.Controls.Add(this.txtName);
            this.gpbAnimalDetails.Controls.Add(this.txtAnimalID);
            this.gpbAnimalDetails.Controls.Add(this.lblScore);
            this.gpbAnimalDetails.Controls.Add(this.lblAge);
            this.gpbAnimalDetails.Controls.Add(this.lblSpecies);
            this.gpbAnimalDetails.Controls.Add(this.lblName);
            this.gpbAnimalDetails.Controls.Add(this.lblAnimalID);
            this.gpbAnimalDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAnimalDetails.Location = new System.Drawing.Point(18, 56);
            this.gpbAnimalDetails.Name = "gpbAnimalDetails";
            this.gpbAnimalDetails.Size = new System.Drawing.Size(209, 342);
            this.gpbAnimalDetails.TabIndex = 1;
            this.gpbAnimalDetails.TabStop = false;
            this.gpbAnimalDetails.Text = "Animal Details";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(135, 305);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(61, 31);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(68, 305);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(61, 31);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1, 305);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 31);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(101, 258);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 30);
            this.txtScore.TabIndex = 9;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(101, 205);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 30);
            this.txtAge.TabIndex = 8;
            // 
            // txtSpecies
            // 
            this.txtSpecies.Location = new System.Drawing.Point(101, 150);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(100, 30);
            this.txtSpecies.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(101, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 30);
            this.txtName.TabIndex = 6;
            // 
            // txtAnimalID
            // 
            this.txtAnimalID.Location = new System.Drawing.Point(101, 34);
            this.txtAnimalID.Name = "txtAnimalID";
            this.txtAnimalID.Size = new System.Drawing.Size(100, 30);
            this.txtAnimalID.TabIndex = 5;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(6, 264);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(53, 20);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(6, 211);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(38, 20);
            this.lblAge.TabIndex = 3;
            this.lblAge.Text = "Age";
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecies.Location = new System.Drawing.Point(6, 156);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(69, 20);
            this.lblSpecies.TabIndex = 2;
            this.lblSpecies.Text = "Species";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 99);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(53, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblAnimalID
            // 
            this.lblAnimalID.AutoSize = true;
            this.lblAnimalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimalID.Location = new System.Drawing.Point(6, 40);
            this.lblAnimalID.Name = "lblAnimalID";
            this.lblAnimalID.Size = new System.Drawing.Size(82, 20);
            this.lblAnimalID.TabIndex = 0;
            this.lblAnimalID.Text = "Animal ID";
            // 
            // gpbDataView
            // 
            this.gpbDataView.Controls.Add(this.btnSearch);
            this.gpbDataView.Controls.Add(this.txtSearchID);
            this.gpbDataView.Controls.Add(this.lblSearch);
            this.gpbDataView.Controls.Add(this.btnDelete);
            this.gpbDataView.Controls.Add(this.dgvAnimals);
            this.gpbDataView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDataView.Location = new System.Drawing.Point(244, 56);
            this.gpbDataView.Name = "gpbDataView";
            this.gpbDataView.Size = new System.Drawing.Size(840, 342);
            this.gpbDataView.TabIndex = 2;
            this.gpbDataView.TabStop = false;
            this.gpbDataView.Text = "Data View";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(369, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(61, 31);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(83, 25);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(280, 30);
            this.txtSearchID.TabIndex = 15;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(3, 31);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(89, 20);
            this.lblSearch.TabIndex = 14;
            this.lblSearch.Text = "Search ID:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(773, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(61, 31);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvAnimals
            // 
            this.dgvAnimals.AllowUserToAddRows = false;
            this.dgvAnimals.AllowUserToDeleteRows = false;
            this.dgvAnimals.AllowUserToResizeColumns = false;
            this.dgvAnimals.AllowUserToResizeRows = false;
            this.dgvAnimals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAnimals.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimals.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvAnimals.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvAnimals.Location = new System.Drawing.Point(6, 61);
            this.dgvAnimals.MultiSelect = false;
            this.dgvAnimals.Name = "dgvAnimals";
            this.dgvAnimals.ReadOnly = true;
            this.dgvAnimals.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAnimals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAnimals.Size = new System.Drawing.Size(828, 275);
            this.dgvAnimals.TabIndex = 0;
            // 
            // gpbSummaryReport
            // 
            this.gpbSummaryReport.Controls.Add(this.lblReleaseReadyValue);
            this.gpbSummaryReport.Controls.Add(this.lblRecoveringValue);
            this.gpbSummaryReport.Controls.Add(this.lblReleaseReady);
            this.gpbSummaryReport.Controls.Add(this.lblRecovering);
            this.gpbSummaryReport.Controls.Add(this.lblStableValue);
            this.gpbSummaryReport.Controls.Add(this.lblSeriousValue);
            this.gpbSummaryReport.Controls.Add(this.lblCriticalValue);
            this.gpbSummaryReport.Controls.Add(this.lblStable);
            this.gpbSummaryReport.Controls.Add(this.lblSerious);
            this.gpbSummaryReport.Controls.Add(this.lblCritical);
            this.gpbSummaryReport.Controls.Add(this.lblAverageScoreValue);
            this.gpbSummaryReport.Controls.Add(this.lblAverageAgeValue);
            this.gpbSummaryReport.Controls.Add(this.lblTotalAnimalsValue);
            this.gpbSummaryReport.Controls.Add(this.lblAverageScore);
            this.gpbSummaryReport.Controls.Add(this.lblAverageAge);
            this.gpbSummaryReport.Controls.Add(this.lblTotalAnimals);
            this.gpbSummaryReport.Controls.Add(this.btnGenerateSummary);
            this.gpbSummaryReport.Controls.Add(this.lblGenerateSummary);
            this.gpbSummaryReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbSummaryReport.Location = new System.Drawing.Point(18, 404);
            this.gpbSummaryReport.Name = "gpbSummaryReport";
            this.gpbSummaryReport.Size = new System.Drawing.Size(717, 176);
            this.gpbSummaryReport.TabIndex = 3;
            this.gpbSummaryReport.TabStop = false;
            this.gpbSummaryReport.Text = "Summary Report";
            // 
            // lblReleaseReadyValue
            // 
            this.lblReleaseReadyValue.AutoSize = true;
            this.lblReleaseReadyValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseReadyValue.Location = new System.Drawing.Point(660, 112);
            this.lblReleaseReadyValue.Name = "lblReleaseReadyValue";
            this.lblReleaseReadyValue.Size = new System.Drawing.Size(18, 20);
            this.lblReleaseReadyValue.TabIndex = 29;
            this.lblReleaseReadyValue.Text = "0";
            // 
            // lblRecoveringValue
            // 
            this.lblRecoveringValue.AutoSize = true;
            this.lblRecoveringValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecoveringValue.Location = new System.Drawing.Point(660, 74);
            this.lblRecoveringValue.Name = "lblRecoveringValue";
            this.lblRecoveringValue.Size = new System.Drawing.Size(18, 20);
            this.lblRecoveringValue.TabIndex = 28;
            this.lblRecoveringValue.Text = "0";
            // 
            // lblReleaseReady
            // 
            this.lblReleaseReady.AutoSize = true;
            this.lblReleaseReady.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseReady.Location = new System.Drawing.Point(512, 112);
            this.lblReleaseReady.Name = "lblReleaseReady";
            this.lblReleaseReady.Size = new System.Drawing.Size(123, 20);
            this.lblReleaseReady.TabIndex = 27;
            this.lblReleaseReady.Text = "Release-Ready";
            // 
            // lblRecovering
            // 
            this.lblRecovering.AutoSize = true;
            this.lblRecovering.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecovering.Location = new System.Drawing.Point(512, 74);
            this.lblRecovering.Name = "lblRecovering";
            this.lblRecovering.Size = new System.Drawing.Size(93, 20);
            this.lblRecovering.TabIndex = 26;
            this.lblRecovering.Text = "Recovering";
            // 
            // lblStableValue
            // 
            this.lblStableValue.AutoSize = true;
            this.lblStableValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStableValue.Location = new System.Drawing.Point(382, 146);
            this.lblStableValue.Name = "lblStableValue";
            this.lblStableValue.Size = new System.Drawing.Size(18, 20);
            this.lblStableValue.TabIndex = 25;
            this.lblStableValue.Text = "0";
            // 
            // lblSeriousValue
            // 
            this.lblSeriousValue.AutoSize = true;
            this.lblSeriousValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeriousValue.Location = new System.Drawing.Point(382, 112);
            this.lblSeriousValue.Name = "lblSeriousValue";
            this.lblSeriousValue.Size = new System.Drawing.Size(18, 20);
            this.lblSeriousValue.TabIndex = 24;
            this.lblSeriousValue.Text = "0";
            // 
            // lblCriticalValue
            // 
            this.lblCriticalValue.AutoSize = true;
            this.lblCriticalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriticalValue.Location = new System.Drawing.Point(382, 74);
            this.lblCriticalValue.Name = "lblCriticalValue";
            this.lblCriticalValue.Size = new System.Drawing.Size(18, 20);
            this.lblCriticalValue.TabIndex = 23;
            this.lblCriticalValue.Text = "0";
            // 
            // lblStable
            // 
            this.lblStable.AutoSize = true;
            this.lblStable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStable.Location = new System.Drawing.Point(275, 146);
            this.lblStable.Name = "lblStable";
            this.lblStable.Size = new System.Drawing.Size(56, 20);
            this.lblStable.TabIndex = 22;
            this.lblStable.Text = "Stable";
            // 
            // lblSerious
            // 
            this.lblSerious.AutoSize = true;
            this.lblSerious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerious.Location = new System.Drawing.Point(275, 112);
            this.lblSerious.Name = "lblSerious";
            this.lblSerious.Size = new System.Drawing.Size(66, 20);
            this.lblSerious.TabIndex = 21;
            this.lblSerious.Text = "Serious";
            // 
            // lblCritical
            // 
            this.lblCritical.AutoSize = true;
            this.lblCritical.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCritical.Location = new System.Drawing.Point(275, 74);
            this.lblCritical.Name = "lblCritical";
            this.lblCritical.Size = new System.Drawing.Size(62, 20);
            this.lblCritical.TabIndex = 20;
            this.lblCritical.Text = "Critical";
            // 
            // lblAverageScoreValue
            // 
            this.lblAverageScoreValue.AutoSize = true;
            this.lblAverageScoreValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageScoreValue.Location = new System.Drawing.Point(137, 146);
            this.lblAverageScoreValue.Name = "lblAverageScoreValue";
            this.lblAverageScoreValue.Size = new System.Drawing.Size(18, 20);
            this.lblAverageScoreValue.TabIndex = 19;
            this.lblAverageScoreValue.Text = "0";
            // 
            // lblAverageAgeValue
            // 
            this.lblAverageAgeValue.AutoSize = true;
            this.lblAverageAgeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageAgeValue.Location = new System.Drawing.Point(137, 112);
            this.lblAverageAgeValue.Name = "lblAverageAgeValue";
            this.lblAverageAgeValue.Size = new System.Drawing.Size(18, 20);
            this.lblAverageAgeValue.TabIndex = 18;
            this.lblAverageAgeValue.Text = "0";
            // 
            // lblTotalAnimalsValue
            // 
            this.lblTotalAnimalsValue.AutoSize = true;
            this.lblTotalAnimalsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAnimalsValue.Location = new System.Drawing.Point(137, 74);
            this.lblTotalAnimalsValue.Name = "lblTotalAnimalsValue";
            this.lblTotalAnimalsValue.Size = new System.Drawing.Size(18, 20);
            this.lblTotalAnimalsValue.TabIndex = 17;
            this.lblTotalAnimalsValue.Text = "0";
            // 
            // lblAverageScore
            // 
            this.lblAverageScore.AutoSize = true;
            this.lblAverageScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageScore.Location = new System.Drawing.Point(6, 146);
            this.lblAverageScore.Name = "lblAverageScore";
            this.lblAverageScore.Size = new System.Drawing.Size(119, 20);
            this.lblAverageScore.TabIndex = 16;
            this.lblAverageScore.Text = "Average Score";
            // 
            // lblAverageAge
            // 
            this.lblAverageAge.AutoSize = true;
            this.lblAverageAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageAge.Location = new System.Drawing.Point(6, 112);
            this.lblAverageAge.Name = "lblAverageAge";
            this.lblAverageAge.Size = new System.Drawing.Size(104, 20);
            this.lblAverageAge.TabIndex = 15;
            this.lblAverageAge.Text = "Average Age";
            // 
            // lblTotalAnimals
            // 
            this.lblTotalAnimals.AutoSize = true;
            this.lblTotalAnimals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAnimals.Location = new System.Drawing.Point(6, 74);
            this.lblTotalAnimals.Name = "lblTotalAnimals";
            this.lblTotalAnimals.Size = new System.Drawing.Size(111, 20);
            this.lblTotalAnimals.TabIndex = 14;
            this.lblTotalAnimals.Text = "Total Animals";
            // 
            // btnGenerateSummary
            // 
            this.btnGenerateSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateSummary.Location = new System.Drawing.Point(140, 25);
            this.btnGenerateSummary.Name = "btnGenerateSummary";
            this.btnGenerateSummary.Size = new System.Drawing.Size(132, 31);
            this.btnGenerateSummary.TabIndex = 13;
            this.btnGenerateSummary.Text = "Generate Summary";
            this.btnGenerateSummary.UseVisualStyleBackColor = true;
            this.btnGenerateSummary.Click += new System.EventHandler(this.btnGenerateSummary_Click);
            // 
            // lblGenerateSummary
            // 
            this.lblGenerateSummary.AutoSize = true;
            this.lblGenerateSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenerateSummary.Location = new System.Drawing.Point(6, 32);
            this.lblGenerateSummary.Name = "lblGenerateSummary";
            this.lblGenerateSummary.Size = new System.Drawing.Size(154, 20);
            this.lblGenerateSummary.TabIndex = 0;
            this.lblGenerateSummary.Text = "Generate Summary";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 592);
            this.Controls.Add(this.gpbSummaryReport);
            this.Controls.Add(this.gpbDataView);
            this.Controls.Add(this.gpbAnimalDetails);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmMain";
            this.Text = "Baobab Ridge Records System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gpbAnimalDetails.ResumeLayout(false);
            this.gpbAnimalDetails.PerformLayout();
            this.gpbDataView.ResumeLayout(false);
            this.gpbDataView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimals)).EndInit();
            this.gpbSummaryReport.ResumeLayout(false);
            this.gpbSummaryReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gpbAnimalDetails;
        private System.Windows.Forms.Label lblAnimalID;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAnimalID;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gpbDataView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvAnimals;
        private System.Windows.Forms.GroupBox gpbSummaryReport;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnGenerateSummary;
        private System.Windows.Forms.Label lblGenerateSummary;
        private System.Windows.Forms.Label lblTotalAnimals;
        private System.Windows.Forms.Label lblAverageScoreValue;
        private System.Windows.Forms.Label lblAverageAgeValue;
        private System.Windows.Forms.Label lblTotalAnimalsValue;
        private System.Windows.Forms.Label lblAverageScore;
        private System.Windows.Forms.Label lblAverageAge;
        private System.Windows.Forms.Label lblReleaseReadyValue;
        private System.Windows.Forms.Label lblRecoveringValue;
        private System.Windows.Forms.Label lblReleaseReady;
        private System.Windows.Forms.Label lblRecovering;
        private System.Windows.Forms.Label lblStableValue;
        private System.Windows.Forms.Label lblSeriousValue;
        private System.Windows.Forms.Label lblCriticalValue;
        private System.Windows.Forms.Label lblStable;
        private System.Windows.Forms.Label lblSerious;
        private System.Windows.Forms.Label lblCritical;
    }
}

