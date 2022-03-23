using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boek3Hoofdstuk2Voorbeeld
{
    public partial class frmLookUpTable : Form
    {
        DataSet dataSetPersonen = new DataSet("Personen");

        BindingSource bindingSourcePersoon = new BindingSource();
        BindingSource bindingSourcePlaatsen = new BindingSource();

        public frmLookUpTable()
        {
            InitializeComponent();
            dataSetPersonen.Tables.Add(createDataTablePersonen());
            dataSetPersonen.Tables.Add(createDataTablePlaatsen());
            
            // vullen van plaatsen
            fillPlaatsen();

            bindingSourcePersoon.DataSource = dataSetPersonen.Tables["Personen"];
            bindingSourcePlaatsen.DataSource = dataSetPersonen.Tables["Plaatsen"];

            // initialiseren datagridview personen
            initDataGridViewPersonen();

            // Kopelen van de textbox aan een kolom
            txbRoepnaam.DataBindings.Add("Text", bindingSourcePersoon, "Roepnaam");
            txbVoorletters.DataBindings.Add("Text", bindingSourcePersoon, "Voorletters");
            txbTussenvoegsel.DataBindings.Add("Text", bindingSourcePersoon, "Tussenvoegsel");
            txbAchternaam.DataBindings.Add("Text", bindingSourcePersoon, "Achternaam");
            dtpGeboortedatum.DataBindings.Add("Text", bindingSourcePersoon, "GeboorteDatum");

            // Kopelen van een kolom aan een combobox
            cmbAchternaam.DataSource = bindingSourcePersoon;
            cmbAchternaam.DisplayMember = "Achternaam";
            cmbRoepnaam.DataSource = bindingSourcePersoon;
            cmbRoepnaam.DisplayMember = "Roepnaam";
            cmbGeboortedatum.DataSource = bindingSourcePersoon;
            cmbGeboortedatum.DisplayMember = "GeboorteDatum";

            cmbGeboorteplaats.DataSource = bindingSourcePlaatsen;
            cmbGeboorteplaats.DisplayMember = "Plaatsnaam";
            cmbGeboorteplaats.ValueMember = "Plaatsnaam";
            cmbGeboorteplaats.DataBindings.Add("SelectedValue", bindingSourcePersoon, "Geboorteplaats");

            // Koppelen van de hele tabel aan een datagridview
            dgvPersonen.DataSource = bindingSourcePersoon;
        }

        private DataTable createDataTablePersonen()
        {
            DataTable dtPersonen = new DataTable("Personen");

            DataColumn Id = new DataColumn("Id", typeof(Int32));
            Id.AutoIncrement = true;
            Id.AllowDBNull = false;

            dtPersonen.Columns.Add(Id);
            dtPersonen.Columns.Add("Roepnaam", typeof(string));
            dtPersonen.Columns["Roepnaam"].MaxLength = 15;
            dtPersonen.Columns.Add("Voorletters", typeof(string));
            dtPersonen.Columns["Voorletters"].MaxLength = 10;
            dtPersonen.Columns.Add("Tussenvoegsel", typeof(string));
            dtPersonen.Columns["Tussenvoegsel"].MaxLength = 7;
            dtPersonen.Columns.Add("Achternaam", typeof(string));
            dtPersonen.Columns["Achternaam"].MaxLength = 15;
            dtPersonen.Columns.Add("GeboorteDatum", typeof(DateTime));
            dtPersonen.Columns.Add("Geboorteplaats", typeof(string));
            dtPersonen.Columns["Geboorteplaats"].MaxLength = 28;

            dtPersonen.PrimaryKey = new DataColumn[] { Id };

            return dtPersonen;
        }

        private DataTable createDataTablePlaatsen()
        {
            DataTable dtPlaatsen = new DataTable("Plaatsen");
            
            // Aanmaken Primary Key kolom
            DataColumn plaatsnaam = new System.Data.DataColumn("Plaatsnaam", typeof(String));
            plaatsnaam.Unique = true;
            plaatsnaam.AllowDBNull = false;
            plaatsnaam.MaxLength = 28;

            // Toevoegen van de kolom aan de tabel
            dtPlaatsen.Columns.Add(plaatsnaam);

            // Primary key aanmaken en toevoegen
            dtPlaatsen.PrimaryKey = new DataColumn[] { plaatsnaam };

            return dtPlaatsen;
        }
        
        private void fillPlaatsen()
        {
            // gegevens in de database zetten
            dataSetPersonen.Tables["Plaatsen"].LoadDataRow(new object[] { "Aadorp" }, true);
            dataSetPersonen.Tables["Plaatsen"].LoadDataRow(new object[] { "Amsterdam" }, true);
            dataSetPersonen.Tables["Plaatsen"].LoadDataRow(new object[] { "Arnhem" }, true);
            dataSetPersonen.Tables["Plaatsen"].LoadDataRow(new object[] { "Assen" }, true);
            dataSetPersonen.Tables["Plaatsen"].LoadDataRow(new object[] { "Nieuwkoop" }, true);
            dataSetPersonen.Tables["Plaatsen"].LoadDataRow(new object[] { "Vlissingen" }, true);
            dataSetPersonen.Tables["Plaatsen"].LoadDataRow(new object[] { "Zundert" }, true);
            dataSetPersonen.Tables["Plaatsen"].LoadDataRow(new object[] { "Appelscha" }, true);
            dataSetPersonen.Tables["Plaatsen"].LoadDataRow(new object[] { "Lelystad" }, true);
            dataSetPersonen.Tables["Plaatsen"].LoadDataRow(new object[] { "Haarlem" }, true);
        }

        private void initDataGridViewPersonen()
        {
            dgvPersonen.AutoGenerateColumns = false;

            dgvPersonen.Columns.Add (new DataGridViewTextBoxColumn {
                DataPropertyName = "Id",
                HeaderText = "Id",
                ValueType = typeof(int),
                ReadOnly = true,
                Width = 30
            });
            dgvPersonen.Columns.Add (new DataGridViewTextBoxColumn {
                DataPropertyName = "Roepnaam",
                HeaderText = "Roepnaam",
                ValueType = typeof(string),
                Width = 150
            });
            dgvPersonen.Columns.Add (new DataGridViewTextBoxColumn {
                DataPropertyName = "Voorletters",
                HeaderText = "Voorletters",
                ValueType = typeof(string),
                Width = 75
            });
            dgvPersonen.Columns.Add (new DataGridViewTextBoxColumn {
                DataPropertyName = "Tussenvoegsel",
                HeaderText = "Tussenvoegsel",
                ValueType = typeof(string),
                Width = 80
            });
            dgvPersonen.Columns.Add (new DataGridViewTextBoxColumn {
                DataPropertyName = "Achternaam",
                HeaderText = "Achternaam",
                ValueType = typeof(string),
                Width = 250
            });
            dgvPersonen.Columns.Add (new DataGridViewTextBoxColumn {
                DataPropertyName = "Geboortedatum",
                HeaderText = "Geboortedatum",
                ValueType = typeof(DateTime),
                Width = 110
            });

            // Geboorteplaats ComboBox toevoegen
            DataGridViewComboBoxColumn geboorteplaatsComboBoxColumn = new DataGridViewComboBoxColumn();
            geboorteplaatsComboBoxColumn.DataPropertyName = "Geboorteplaats";
            geboorteplaatsComboBoxColumn.HeaderText = "Geboorteplaats";
            geboorteplaatsComboBoxColumn.ValueType = typeof(string);
            // Koppeling met de DataTable waarin de look-up-data staan
            geboorteplaatsComboBoxColumn.DataSource = dataSetPersonen.Tables["Plaatsen"];
            // Het item van deze tabel dat je aan de gebruiker wilt laten zien
            geboorteplaatsComboBoxColumn.DisplayMember = "Plaatsnaam";
            // Het item waarvan je de waarde kopieert naar de DataTable van de DataGridView.
            geboorteplaatsComboBoxColumn.ValueMember = "Plaatsnaam";
            geboorteplaatsComboBoxColumn.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            geboorteplaatsComboBoxColumn.Width = 120;

            dgvPersonen.Columns.Add(geboorteplaatsComboBoxColumn);
        }
    }
}
