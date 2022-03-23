using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoofdstuk8Opdracht1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void loadEvent()
            {
                lblOutcome.Text = "Beste " + Environment.UserName + "\r\n" +
                    "Welkom in ons systeem. Zoals je zult begrijpen zijn er enkele regels op " +
                    "ons systeem van toepassing waar iedere gebruiker zich aan moet houden. " +
                    "Door op de knop 'ok' te klikken gaat u ermee akkoord dat de " + 
                    "systeembeheerder onbeperkt toegang heeft tot uw computer.";
            }

        private void lblOutcome_Click(object sender, EventArgs e)
        {
            loadEvent();
        }
    }
}
