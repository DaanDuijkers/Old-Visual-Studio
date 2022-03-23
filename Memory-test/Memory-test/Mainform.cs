using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_test
{
    public partial class Memory : Form
    {
        Game _game = new Game();
        int _countClick = 1;
        string _image1;
        string _image2;
        PictureBox picturebox1;
        PictureBox picturebox2;
        int _pairsFound = 0;
        int timeLeft;
        int _noClick = 1;

        public Memory()
        {
            InitializeComponent();
            _game.newGame();
            setDefaultPics();
            enableAll();
        }

        private void sluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void setDefaultPics()
        {
            Image img = Image.FromFile(@"..\..\Resources\default.png");
            foreach (PictureBox picture in panel1.Controls)
            {
                picture.Cursor = Cursors.Hand;
                picture.Image = img;
            }
        }

        private void enableAll()
        {
            a1.Enabled = true;
            a2.Enabled = true;
            a3.Enabled = true;
            a4.Enabled = true;
            a5.Enabled = true;
            a6.Enabled = true;
            a7.Enabled = true;
            a8.Enabled = true;
            a9.Enabled = true;
            a10.Enabled = true;
            a11.Enabled = true;
            a12.Enabled = true;
            a13.Enabled = true;
            a14.Enabled = true;
            a15.Enabled = true;
            a16.Enabled = true;
            a17.Enabled = true;
            a18.Enabled = true;
            a19.Enabled = true;
            a20.Enabled = true;
            a21.Enabled = true;
            a22.Enabled = true;
            a23.Enabled = true;
            a24.Enabled = true;
        }

        private void pb_clicked(object sender, EventArgs e)
        {
            if (_noClick == 0)
            {
                MessageBox.Show("Even wachten met klikken.");
                return;
            }

            PictureBox pb = (PictureBox)sender;
            
            int plaatjeNummer = 0;
            if (pb.Name.Length == 2) 
            {
                plaatjeNummer = int.Parse(pb.Name.Substring(1, 1));
            }
            if (pb.Name.Length == 3)
            {
                plaatjeNummer = int.Parse(pb.Name.Substring(1, 2));
            }

            string iPicture = _game.checkPicture(plaatjeNummer);

            Image image = Image.FromFile(@"..\..\Resources\" + iPicture + ".png");
            pb.Image = image;

           // MessageBox.Show("laat plaatje zien");
            if (_countClick == 1)
            {
                _countClick++;
                _image1 = iPicture;
                picturebox1 = pb;
                Thread.Sleep(500);
                return;
            }

            //na de tweede klik controleren of er twee dezelfde plaatjes zijn
            if (_countClick == 2)
            {
                _noClick = 0;
                _countClick = 1;
                _image2 = iPicture;
                picturebox2 = pb;

                //Als plaatjes gelijk zijn, dan laten we ze staan
                if (_image1 == _image2)
                {
                    //MessageBox.Show("Hoera!");
                    _pairsFound++;
                    picturebox1.Enabled = false;
                    picturebox2.Enabled = false;
                    _noClick = 1;
                    if (_pairsFound == 12)
                    {
                        MessageBox.Show("Hoera, je hebt het spel gewonnen. Klik in het menu om opnieuw te spelen.");
                    }
                    return;
                } else
                {
                    //Als ze niet gelijk zijn, dan moeten de default plaatjes weer erin.
                    //Maar eerst stoppen we even, door een timer neer te zetten.
                    //Anders verdwijnen de plaatjes te snel. Als de timer klaar is starten we een nieuwe functie.
                    goTimer();
                }
            }
        }

        private void setBackToDefault()
        {
            Image img = Image.FromFile(@"..\..\Resources\default.png");
            picturebox1.Image = img;
            picturebox2.Image = img;
        }

        private void nieuwSpelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _pairsFound = 0;
            _countClick = 1;
            _game.newGame();
            setDefaultPics();
            enableAll();
        }

        private void goTimer()
        {
            //Dit start de timer1_tick functie
            timeLeft = 1;
            timeLabel.Text = "1 seconds";
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
                Console.Write("Time left\r\n");
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                setBackToDefault();
                timeLabel.Text = "0";
                _noClick = 1;
            }
        }
    }
}
