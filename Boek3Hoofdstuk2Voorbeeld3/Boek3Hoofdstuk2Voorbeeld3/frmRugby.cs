using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boek3Hoofdstuk2Voorbeeld3
{
    public partial class frmRugby : Form
    {
        DataSet dataSetRugby = new DataSet("Rugby");
        BindingSource masterBindingSourceRugbyTeam = new BindingSource();
        BindingSource detailBindingSourceSpelers = new BindingSource();

        public frmRugby()
        {
            InitializeComponent();
            dataSetRugby.Tables.Add(createDataTableRugbyTeams());
            dataSetRugby.Tables.Add(createDataTableSpelers());

            // Aanmaken relaties
            createDataRelations();

            // Bind de master-dataconnector aan de teams datatable
            masterBindingSourceRugbyTeam.DataSource = dataSetRugby.Tables["RugbyTeams"];

            // Koppelen van diverse Controls aan de master-DataTable
            txbAantalSpelers.DataBindings.Add("Text", masterBindingSourceRugbyTeam, "Aantal Spelers");
            txbTeamnaam.DataBindings.Add("Text", masterBindingSourceRugbyTeam, "Teamnaam");
            txbTrainer.DataBindings.Add("Text", masterBindingSourceRugbyTeam, "Trainer");
            lblTeamId.DataBindings.Add("Text", masterBindingSourceRugbyTeam, "Id");
            cmbKlasse.DataBindings.Add("Text", masterBindingSourceRugbyTeam, "Klasse");
            cmbSoortRugby.DataBindings.Add("Text", masterBindingSourceRugbyTeam, "Soort Rugby");

            // Bind de detail-dataconnector aan de master-dataconnector met behulp van de DataRelation-naam 
            // zodat de informatie in de detail-DataTable zo gefilterd wordt dat alleen die informatie
            // getoond wordt die hoort bij de huidige rij in de master-DataTable
            detailBindingSourceSpelers.DataSource = masterBindingSourceRugbyTeam;
            detailBindingSourceSpelers.DataMember = "relationTeamSpeler";
            dgvSpelers.DataSource = detailBindingSourceSpelers;
        }

        private DataTable createDataTableRugbyTeams()
        {
            DataTable dtRugbyTeams = new DataTable("RugbyTeams");

            DataColumn id = new DataColumn("Id", typeof(Int32));

            id.AutoIncrement = true;
            id.AllowDBNull = false;

            dtRugbyTeams.Columns.Add(id);
            dtRugbyTeams.Columns.Add("Teamnaam", typeof(string));
            dtRugbyTeams.Columns["Teamnaam"].MaxLength = 50;
            dtRugbyTeams.Columns.Add("Trainer", typeof(string));
            dtRugbyTeams.Columns["Trainer"].MaxLength = 50;
            dtRugbyTeams.Columns.Add("Klasse", typeof(string));
            dtRugbyTeams.Columns["Klasse"].MaxLength = 13;
            dtRugbyTeams.Columns.Add("Soort Rugby", typeof(string));
            dtRugbyTeams.Columns["Soort Rugby"].MaxLength = 12;
            dtRugbyTeams.Columns.Add("Aantal Spelers", typeof(byte));

            dtRugbyTeams.PrimaryKey = new DataColumn[] { id };

            return dtRugbyTeams;
        }

        private void createDataRelations()
        {
            DataColumn dataColumnParent, dataColumnChild;

            dataColumnParent = dataSetRugby.Tables["RugbyTeams"].Columns["id"];
            dataColumnChild = dataSetRugby.Tables["Spelers"].Columns["TeamId"];

            DataRelation dataRelationTeamSpeler = new DataRelation("relationTeamSpeler", dataColumnParent, dataColumnChild);

            dataSetRugby.Relations.Add(dataRelationTeamSpeler);

            ForeignKeyConstraint foreignKeyConstraintTeamSpeler = dataRelationTeamSpeler.ChildKeyConstraint;
            foreignKeyConstraintTeamSpeler.DeleteRule = Rule.None;
            foreignKeyConstraintTeamSpeler.UpdateRule = Rule.Cascade;
        }

        private DataTable createDataTableSpelers()
        {
            DataTable dtSpelers = new DataTable("Spelers");

            DataColumn id = new DataColumn("Id", typeof(Int32));
            DataColumn teamId = new DataColumn("TeamId", typeof(Int32));
            DataColumn rugnummer = new DataColumn("Rugnummer", typeof(byte));

            id.AutoIncrement = true;
            id.AllowDBNull = false;
            rugnummer.AllowDBNull = false;

            dtSpelers.Columns.Add(id);
            dtSpelers.Columns.Add("Roepnaam", typeof(string));
            dtSpelers.Columns["Roepnaam"].MaxLength = 15;
            dtSpelers.Columns.Add("Voorletters", typeof(string));
            dtSpelers.Columns["Voorletters"].MaxLength = 10;
            dtSpelers.Columns.Add("Tussenvoegsels", typeof(string));
            dtSpelers.Columns["Tussenvoegsels"].MaxLength = 7;
            dtSpelers.Columns.Add("Achternaam", typeof(string));
            dtSpelers.Columns["Achternaam"].MaxLength = 25;
            dtSpelers.Columns.Add("Geboortedatum", typeof(DateTime));
            dtSpelers.Columns.Add(rugnummer);
            dtSpelers.Columns.Add(teamId);

            dtSpelers.PrimaryKey = new DataColumn[] { id };

            return dtSpelers;
        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            masterBindingSourceRugbyTeam.AddNew();
            masterBindingSourceRugbyTeam.EndEdit();
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            try
            {
                masterBindingSourceRugbyTeam.RemoveCurrent();
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "Verwijderen mislukt", MessageBoxButtons.OK,
                    MessageBoxIcon.Stop);
            }
        }

        private void btnEerste_Click(object sender, EventArgs e)
        {
            masterBindingSourceRugbyTeam.MoveFirst();
        }

        private void btnVerwijder_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnVerwijder, "Verwijder een team, inclusief de spelers, uit de Dataset.");
        }

        private byte getAantalSpelers(string soortRugby)
        {
            byte aantalSpelers = 0;
            switch(soortRugby)
            {
                case "Rugby Union":
                {
                    aantalSpelers = 15;
                    break;
                }
                case "Rugby League":
                {
                    aantalSpelers = 13;
                    break;
                }
                case "Rugby Sevens":
                {
                     aantalSpelers = 7;
                    break;
                }
                case "Ten-a-side":
                {
                    aantalSpelers = 10;
                    break;
                }
                case "Touch Rugby":
                {
                    aantalSpelers = 6;
                    break;
                }
                default:
                {
                    aantalSpelers = 0;
                    break;
                }
            }

            return aantalSpelers;
        }

        private void cmbSoortRugby_SelectedIndexChanged(object sender, EventArgs e)
        {
            txbAantalSpelers.Text = getAantalSpelers(cmbSoortRugby.SelectedItem.ToString()).ToString();
        }

        private void frmRugby_Load(object sender, EventArgs e)
        {

        }
    }
}
