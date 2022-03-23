using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace musicPlaylist
{
    public partial class frmMusicPlaylist : Form
    {
        // the listboxes used to store data (artistNumberList serves as a link between songList and artistList)
        List<string> songList = new List<string>();
        List<int> artistNumberList = new List<int>();
        List<string> artistList = new List<string>();
        List<string> genreList = new List<string>();

        public frmMusicPlaylist()
        {
            InitializeComponent();
        }

        // method called on whenever the available songs listbox needs to be refreshed
        private void refresh()
        {
            lbSongs.Items.Clear();

            // goes through all items in songLists and displays it along with the matching artist and genre if the song's artist matches selected the artist
            for (int i = 0; i < songList.Count; i++)
            {
                if (artistNumberList[i] == cmbArtist.SelectedIndex)
                {
                    lbSongs.Items.Add(songList[i] + " - " + artistList[cmbArtist.SelectedIndex] + " - " + genreList[i]);
                }
            }
        }

        // adds a new long to the available songs listbox
        private void Add_Click(object sender, EventArgs e)
        {
            if (txbArtist.Text != string.Empty && txbSong.Text != string.Empty && txbGenre.Text != string.Empty)
            {
                // see if inputted artist already exists in artistList, and if not add them to list
                string artist = txbArtist.Text;
                txbArtist.Text = string.Empty;
                int artistNumber = artistList.IndexOf(artist);
                if (artistNumber == -1 || artistNumber >= artistList.Count)
                {
                    artistList.Add(artist);
                    artistNumber = artistList.IndexOf(artist);

                    // refesh combobox when adding a new artist
                    cmbArtist.Enabled = true;
                    cmbArtist.Items.Clear();
                    foreach (string a in artistList)
                    {
                        cmbArtist.Items.Add(a);
                    }
                    cmbArtist.SelectedIndex = 0;
                }
                artistNumberList.Add(artistNumber);

                // add song to songList
                string song = txbSong.Text;
                txbSong.Text = string.Empty;
                songList.Add(song);

                // add the genre to genreList
                string genre = txbGenre.Text;
                txbGenre.Text = string.Empty;
                genreList.Add(genre);

                // refresh the available songs listbox to display newly inputted data
                refresh();
            }
            else
            {
                MessageBox.Show("Please enter a song, artist, and genre");
            }
        }

        // goes through all listbox items and removes the song selected in the available songs listbox and calls on the refresh method to refresh the listbox
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbSongs.SelectedItem != null)
            {
                int index = 0;

                for (int i = 0; i < songList.Count; i++)
                {
                    if (artistNumberList[i] == cmbArtist.SelectedIndex)
                    {
                        if (index == lbSongs.SelectedIndex)
                        {
                            songList.RemoveAt(i);
                            artistNumberList.RemoveAt(i);
                            genreList.RemoveAt(i);
                        }

                        index += 1;
                    }
                }

                refresh();
            }
            else
            {
                MessageBox.Show("Please select a song in Available Songs");
            }
        }

        // copies the selected song from the available songs listbox to the playlist listbox
        private void btnPlaylistAdd_Click(object sender, EventArgs e)
        {
            if (lbSongs.SelectedItem != null)
            {
                lbPlaylist.Items.Add(lbSongs.SelectedItem);
            }
            else
            {
                MessageBox.Show("Please select a song in Available Songs");
            }
        }

        // removes a song selected selected in the playlist listbox from the playlist listbox
        private void btnPlaylistRemove_Click(object sender, EventArgs e)
        {
            if (lbPlaylist.SelectedItem != null)
            {
                lbPlaylist.Items.RemoveAt(lbPlaylist.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a song in the Playlist");
            }
        }

        // changing the selected artist in the combobox calls on the refresh method to only display songs from that artist
        private void cmbArtist_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }
    }
}