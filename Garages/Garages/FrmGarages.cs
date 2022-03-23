using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garages
{
    public partial class FrmGarages : Form
    {
        DataSet dsGarage = new DataSet("Garage");

        private DataTable createDataTableAutos()
        {
            DataTable dtAutos = new DataTable("Auto’s");

            DataColumn Chassisnummer = new DataColumn("Chassisnummer",
                         typeof(String));
            Chassisnummer.Unique = true;

            dtAutos.Columns.Add(Chassisnummer);

            dtAutos.Columns.Add("Kenteken", typeof(String));
            dtAutos.Columns["Kenteken"].MaxLength = 8;
            dtAutos.Columns["Kenteken"].AllowDBNull = false;
            dtAutos.Columns["Kenteken"].Unique = true;

            dtAutos.Columns.Add("FabricageDatum", typeof(DateTime));

            dtAutos.Columns.Add("DatumOpKenteken", typeof(DateTime));
            dtAutos.Columns["DatumOpKenteken"].AllowDBNull = false;

            dtAutos.Columns.Add("Merk", typeof(String));
            dtAutos.Columns["Merk"].MaxLength = 25;

            dtAutos.Columns.Add("Type", typeof(String));
            dtAutos.Columns["Type"].MaxLength = 25;

            dtAutos.Columns.Add("Kleur", typeof(Color));

            dtAutos.Columns.Add("Brandstof", typeof(String));
            dtAutos.Columns["Brandstof"].MaxLength = 10;

            dtAutos.Columns.Add("AantalKilowatt", typeof(double));

            dtAutos.Columns.Add("AantalPortieren", typeof(Byte));

            dtAutos.Columns.Add("Model", typeof(String));
            dtAutos.Columns["Model"].MaxLength = 15;
            dtAutos.Columns.Add("Trekhaak", typeof(bool));

            //Aanmaken primary key.
            dtAutos.PrimaryKey = new DataColumn[] { Chassisnummer };

            return dtAutos;
        }

        public FrmGarages()

        {
            InitializeComponent();
            dsGarage.Tables.Add(createDataTableAutos());
        }
    }
}
