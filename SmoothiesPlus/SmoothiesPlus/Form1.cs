using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smoothies
{
    public partial class frmSmoothiesPlus : Form
    {
        Ingrediënt[] ingrediënten;
        Ingrediënt Ingrediënt = new Ingrediënt();

        public frmSmoothiesPlus()
        {
            InitializeComponent();
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void fillLivIngrediënten()
        {
            livIngrediënten.Items.Clear();

            foreach (var ingrediënt in ingrediënten)
            {
                ListViewItem livIngrediëntenItem = new ListViewItem(ingrediënt.Naam);

                livIngrediënten.Items.Add(livIngrediëntenItem);
            }
        }

        private void frmSmoothies_Load(object sender, EventArgs e)
        {
            ingrediënten = defaultIngrediëntenArray();

            fillLivIngrediënten();

            opmaakLivIngrediënten();
        }

        private void opmaakLivIngrediënten()
        {
            livIngrediënten.OwnerDraw = true;

            livIngrediënten.View = View.Details;

            ColumnHeader headerNaam = livIngrediënten.Columns.Add("Naam", 75);
            ColumnHeader headerKleur = livIngrediënten.Columns.Add("Kleur", 80);
            ColumnHeader headerLandVanHerkomst = livIngrediënten.Columns.Add("Land van herkomst", 150);
            ColumnHeader headerCalorieën = livIngrediënten.Columns.Add("Calorieën", 70);
            ColumnHeader headerPrijsPerKilo = livIngrediënten.Columns.Add("Prijs per kilo", -2);
        }

        private void livIngrediënten_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;

            Font headerFont = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);

            e.Graphics.FillRectangle(Brushes.Turquoise, e.Bounds);

            e.Graphics.DrawString(e.Header.Text, headerFont, Brushes.Black, e.Bounds, stringFormat);
        }

        private void livIngrediënten_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Near;

            Font subItemFont = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);

            Brush regelKleur = Brushes.PaleTurquoise;

            if(e.Item.Selected == true)
            {
                regelKleur = Brushes.SteelBlue;
            }

            if(e.ItemIndex % 2 == 1)
            {
                if(e.Item.Selected == true)
                {
                    regelKleur = Brushes.LightSteelBlue;
                }
                else
                {
                    regelKleur = Brushes.WhiteSmoke;
                }
            }

            e.Graphics.FillRectangle(regelKleur, e.Bounds);

            e.Graphics.DrawString(e.SubItem.Text, subItemFont, Brushes.Black, e.Bounds, stringFormat);
        }

        private void txbIngrediënt_TextChanged(object sender, EventArgs e)
        {
            Ingrediënt.Naam = txbIngrediënt.Text;
        }

        private int zoekIngrediënt(string ingrediënt)
        {
            int index = 0;

            while(index < ingrediënten.Length)
            {
                string sIngredient = ingrediënten[index].ToString();
                if (sIngredient == ingrediënt)
                {
                    break;
                }

                index++;
            }

            if (index == ingrediënten.Length)
            {
                index = -1;
            }

            return index;
        }

        private int voegIngrediëntToe(string ingrediënt)
        {
            int grootte = ingrediënten.Length + 1;

            int positie = 0;

            Array.Resize(ref ingrediënten, grootte);

            positie = grootte - 1;
        
            ingrediënten[positie] = Ingrediënt;

            return grootte - 1;
        }

        private void selecteerIngrediënt()
        {
            int positie = zoekIngrediënt(Ingrediënt.ToString());

            if(positie == -1)
            {
                if (MessageBox.Show("Ingrediënt " + Ingrediënt + " komt niet voor." +
                Environment.NewLine + Environment.NewLine +
                "Nieuw ingrediënt " + Ingrediënt + " aanmaken?",
                "Waarschuwing",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    voegIngrediëntToe(Ingrediënt.ToString());
                    fillLivIngrediënten();
                    selecteerIngrediënt();
                }
            }
            else
            {
                livIngrediënten.Items[positie].Selected = true;
            }
        }

        private void btnZoek_Click(object sender, EventArgs e)
        {
            selecteerIngrediënt();
        }

        private void deSelecteerIngrediënten()
        {
            for(int i = 0; i < livIngrediënten.Items.Count; i++)
            {
                livIngrediënten.Items[i].Selected = false;
            }
        }

        private void btnWisSelectie_Click(object sender, EventArgs e)
        {
            deSelecteerIngrediënten();
        }

        private void verwijderIngrediëntUitIngrediëntenArray(int startPositie)
        {
            int grootte = ingrediënten.Length - 1;

            for(int positie = startPositie; positie < grootte; positie++)
            {
                ingrediënten[positie] = ingrediënten[positie + 1];
            }

            Array.Resize(ref ingrediënten, grootte);
        }

        private void verwijderGeselecteerdeIngrediënten()
        {
            for(int i = 0; i < livIngrediënten.Items.Count; i++)
            {
                if(livIngrediënten.Items[i].Selected == true)
                {
                    livIngrediënten.Items[i].Remove();

                    verwijderIngrediëntUitIngrediëntenArray(i);

                    i = i - 1;
                }
            }
        }

        private void btnWisIngrediënt_Click(object sender, EventArgs e)
        {
            verwijderGeselecteerdeIngrediënten();
        }

        private Ingrediënt[] defaultIngrediëntenArray()
        {
            Ingrediënt[] defaultIngrediënten = new Ingrediënt[6];

            defaultIngrediënten[0] = new Ingrediënt("Appel",Color.Green,"Nederland",10,1.76);
            defaultIngrediënten[1] = new Ingrediënt("Peer", Color.Green, "Luxemburg", 10, 1.71);
            defaultIngrediënten[2] = new Ingrediënt("Meloen", Color.Orange, "België", 15, 2.15);
            defaultIngrediënten[3] = new Ingrediënt("Aarbei", Color.Red, "Israël", 5, 12.20);
            defaultIngrediënten[4] = new Ingrediënt("Framboos", Color.IndianRed, "België", 7, 7.33);
            defaultIngrediënten[5] = new Ingrediënt("Rode bes", Color.Red, "Frankrijk", 17, 14.10);

            return defaultIngrediënten;
        }

        private void btnDefaultLijst_Click(object sender, EventArgs e)
        {
            ingrediënten = defaultIngrediëntenArray();
            fillLivIngrediënten();
        }

        private void livIngrediënten_Click(object sender, EventArgs e)
        {
            txbIngrediënt.Text = livIngrediënten.FocusedItem.SubItems[0].Text;
        }

        private void txbLandVanHerkomst_TextChanged(object sender, EventArgs e)
        {
            Ingrediënt.LandVanHerkomst = txbIngrediënt.Text;
        }

        private void txbCalorieën_TextChanged(object sender, EventArgs e)
        {
            if(txbCalorieën.Text.Length > 0)
            {

                try
                {
                    Ingrediënt.Calorieën = int.Parse(txbCalorieën.Text);
                    errorProvider1.SetError(txbCalorieën, "");
                }
                catch
                {
                    //errorProvider1.SetError(txbCalorieën, exception.Message);
                }
            }
        }

        private void txbPrijsPerKilo_TextChanged(object sender, EventArgs e)
        {
            if (txbCalorieën.Text.Length > 0)
            {

                try
                {
                    Ingrediënt.PrijsPerKilo = int.Parse(txbPrijsPerKilo.Text);
                    errorProvider1.SetError(txbPrijsPerKilo, "");
                }
                catch
                {
                    //errorProvider1.SetError(txbPrijsPerKilo, exception.Message);
                }
            }
        }

        private void btnKleurIngrediënt_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Ingrediënt.Kleur = colorDialog1.Color;
                btnKleurIngrediënt.BackColor = Ingrediënt.Kleur;
                btnKleurIngrediënt.Text = Ingrediënt.Kleur.Name;
            }
        }

        private void btnKleurIngrediënt_TextChanged(object sender, EventArgs e)
        {
            btnKleurIngrediënt.BackColor = Ingrediënt.Kleur;
        }
        
    }
}
