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
    public partial class frmPersonen : Form
    {
        DataSet dataSetPersonen = new DataSet("Personen");

        BindingSource bindingSourcePersoon = new BindingSource();

        public frmPersonen()
        {
            InitializeComponent();
            dataSetPersonen.Tables.Add(createDataTablePersonen());
            bindingSourcePersoon.DataSource = dataSetPersonen.Tables["Personen"];

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

            dtPersonen.PrimaryKey = new DataColumn[] { Id };

            return dtPersonen;
        }

        
    }
}
