using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book2Hoofdstuk1Opdracht1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] telefoons = { "Microsoft Lumia 640", "Huawei Smartphone Y330"};

        string telefoon = "";

        private void fillLivTelefoons()
        {
            livTelefoons.Items.Clear();

            foreach(var telefoon in telefoons)
            {
                ListViewItem livTelefoonItem = new ListViewItem(telefoon);

                livTelefoons.Items.Add(livTelefoonItem);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillLivTelefoons();

            opmaakLivTelefoons();
        }

        private void opmaakLivTelefoons()
        {
            livTelefoons.OwnerDraw = true;

            livTelefoons.View = View.Details;

            ColumnHeader headerTelefoons = livTelefoons.Columns.Add("Telefoons", -2);
        }

        private void livTelefoons_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Near;

            Font subItemFont = new Font("Microsoflt Sans Serif", 8, FontStyle.Regular);

            Brush regelKleur = Brushes.White;

            if (e.Item.Selected == true)
            {
                regelKleur = Brushes.LightBlue;
            }

            e.Graphics.FillRectangle(regelKleur, e.Bounds);
            e.Graphics.DrawString(e.SubItem.Text, subItemFont, Brushes.Black, e.Bounds, stringFormat);
            
        }

        private void livTelefoons_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;

            Font headerFont = new Font("Microsoflt Sans Serif", 8, FontStyle.Bold);
            

            e.Graphics.DrawString(e.Header.Text, headerFont, Brushes.Black, e.Bounds, stringFormat);
        }

        private int zoekTelefoon(string telefoon)
        {
            int index = 0;
            while (index < telefoons.Length)
            {
                if (telefoons[index] == telefoon)
                {
                    break;
                }

                index++;
            }
            
            if (index == telefoons.Length)
            {
                index = -1;
            }

            return index;
        }

        private int voegTelefoonToe(string telefoon)
        {
            int grootte = telefoons.Length + 1;

            int positie = 0;

            Array.Resize(ref telefoons, grootte);

            positie = grootte - 1;

            telefoons[positie] = telefoon;

            return grootte;
        }

        private void selecteerTelefoon()
        {
            int positie = zoekTelefoon(telefoon);

            if (positie == -1)
            {
                if (MessageBox.Show("Telefoon " + telefoon + " komt niet voor." +
                Environment.NewLine + Environment.NewLine +
                "Wilt u een nieuwe " + telefoon + " toevoegen?",
                "Waarschuwing",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    voegTelefoonToe(telefoon);
                    fillLivTelefoons();
                    selecteerTelefoon();
                }
            }
            else
            {
                livTelefoons.Items[positie].Selected = true;
            }
        }
    }
}
