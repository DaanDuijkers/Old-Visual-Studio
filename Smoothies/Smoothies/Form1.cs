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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        string[] ingrediënten;

        string ingrediënt = "";

        private void fillLivIngrediënten()
        {
            livIngrediënten.Items.Clear();

            foreach (var ingrediënt in ingrediënten)
            {
                ListViewItem livIngrediëntenItem = new ListViewItem(ingrediënt);

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

            ColumnHeader headerIngrediënten = livIngrediënten.Columns.Add("Ingrediënten", -2);
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
            ingrediënt = txbIngrediënt.Text;
        }

        private int zoekIngrediënt(string ingrediënt)
        {
            int index = 0;

            while(index < ingrediënten.Length)
            {
                if(ingrediënten[index] == ingrediënt)
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

            ingrediënten[positie] = ingrediënt;

            return grootte - 1;
        }

        private void selecteerIngrediënt()
        {
            int positie = zoekIngrediënt(ingrediënt);

            if(positie == -1)
            {
                if (MessageBox.Show("Ingrediënt " + ingrediënt + " komt niet voor." +
                Environment.NewLine + Environment.NewLine +
                "Nieuw ingrediënt " + ingrediënt + " aanmaken?",
                "Waarschuwing",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    voegIngrediëntToe(ingrediënt);
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

        private string[] defaultIngrediëntenArray()
        {
            string[] defaultIngrediënten = { "Appel", "Peer", "Meloen", "Aardbei", "Framboos", "Rode bes" };

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
    }
}
