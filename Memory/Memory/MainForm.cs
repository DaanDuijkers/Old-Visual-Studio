using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Memory
{
    public partial class MainForm : Form
    {
        int countClick = 0;
        PictureBox rememberPlaatje1;
        PictureBox rememberPlaatje2;
        int rememberNumber;
        int noClick = 1;
        int plaatjeNummer = 0;
        int gewonnen;
        List<Point> points = new List<Point>();
        Random location = new Random();
        int next;
        int pogingen;
        SqlConnection con = new SqlConnection(
            @"Data Source=LAPTOP-22DSHTEM\SQLEXPRESS;
            Initial Catalog=HighScore;
            Integrated Security=true;
        ");
        SqlCommand cmd;
        SqlDataAdapter adapt;

        public MainForm()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            con.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter(
                    "SELECT Pogingen FROM Scoren ORDER BY Pogingen ASC", 
                    con);
                adapt.Fill(dt);
                lblHighScore.Text = dt.Rows[0]["Pogingen"].ToString();
            con.Close();
        }

        private void NewHighScore()
        {
            cmd = new SqlCommand(
                "INSERT INTO Scoren(Pogingen) values(@Pogingen)",
                con);

            con.Open();
                cmd.Parameters.AddWithValue("@Pogingen", pogingen);
                cmd.ExecuteNonQuery();
            con.Close();
        }

        private void sluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pogingen = 0;
            gewonnen = 0;

            foreach (PictureBox picture in Cardsholder.Controls)
            {
                picture.Cursor = Cursors.Hand;
                picture.Image = Properties.Resources._default;
                points.Add(picture.Location);
                picture.Enabled = true;
            }
            foreach (PictureBox picture in Cardsholder.Controls)
            {
                next = location.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);
            }
        }

        private void pb_clicked(object sender, EventArgs e)
        {
            if(noClick == 0)
            {
            }
            else
            {
                PictureBox picturebox = (PictureBox)sender;
                countClick = countClick + 1;
            
                if (picturebox.Name.Length == 2)
                {
                    plaatjeNummer = int.Parse(picturebox.Name.Substring(1, 1));
                }
                else if (picturebox.Name.Length == 3)
                {
                    plaatjeNummer = int.Parse(picturebox.Name.Substring(1, 2));
                }

                if(plaatjeNummer > 12)
                {
                    plaatjeNummer = plaatjeNummer - 12;
                }

                string iPicture = plaatjeNummer.ToString();
                picturebox.Image = Image.FromFile(@"..\..\Resources\card" + iPicture + ".png");
            
                if(countClick == 1)
                {
                    rememberPlaatje1 = picturebox;
                    rememberNumber = plaatjeNummer;
                    rememberPlaatje1.Enabled = false;
                }
                else if(countClick == 2)
                {
                    rememberPlaatje2 = picturebox;

                    if (rememberNumber != plaatjeNummer)
                    {
                        rememberPlaatje1.Enabled = true;
                        noClick = 0;
                        timer1.Start();
                    }
                    else
                    {
                        rememberPlaatje1.Enabled = false;
                        rememberPlaatje2.Enabled = false;
                        gewonnen = gewonnen + 1;
                        pogingen = pogingen + 1;

                        if (gewonnen == 12)
                        {
                            NewHighScore();
                            DisplayData();

                            MessageBox.Show("U hebt gewonnen!!!\r\n\r\n" +
                                "Klik in het menu op 'Speel Spel Opnieuw' om nog een keer te spelen!");
                        }
                    }
                    
                    lblPoging.Text = pogingen.ToString();
                    countClick = 0;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            noClick = 1;
            rememberPlaatje1.Image = Properties.Resources._default;
            rememberPlaatje2.Image = Properties.Resources._default;
        }

        private void speelSpelOpnieuwToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainForm_Load(sender, e);
        }
    }
}
