using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace privateMessenger
{
    /// <summary>
    /// Interaction logic for GebruikerForm.xaml
    /// </summary>
    public partial class GebruikerForm : Window
    {
        db db = new db();
        public GebruikerForm()
        {
            
            InitializeComponent();
            loadGebruiker();
        }
        public void loadGebruiker()
        {
            List<Gebruiker> gebruikers = db.GetGebruikers();

            foreach (Gebruiker gebruiker in gebruikers)
            {
                GebruikerListBox.Items.Add(gebruiker);
            }
        }
    }

  
}
