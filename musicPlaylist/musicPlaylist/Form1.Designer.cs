namespace musicPlaylist
{
    partial class frmMusicPlaylist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbSongs = new System.Windows.Forms.ListBox();
            this.txbArtist = new System.Windows.Forms.TextBox();
            this.lblArist = new System.Windows.Forms.Label();
            this.lblSongs = new System.Windows.Forms.Label();
            this.lblSong = new System.Windows.Forms.Label();
            this.txbSong = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPlaylistAdd = new System.Windows.Forms.Button();
            this.lbPlaylist = new System.Windows.Forms.ListBox();
            this.lblPlaylist = new System.Windows.Forms.Label();
            this.btnPlaylistRemove = new System.Windows.Forms.Button();
            this.lblGenre = new System.Windows.Forms.Label();
            this.txbGenre = new System.Windows.Forms.TextBox();
            this.cmbArtist = new System.Windows.Forms.ComboBox();
            this.lblArtistList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSongs
            // 
            this.lbSongs.FormattingEnabled = true;
            this.lbSongs.ItemHeight = 25;
            this.lbSongs.Location = new System.Drawing.Point(547, 50);
            this.lbSongs.MultiColumn = true;
            this.lbSongs.Name = "lbSongs";
            this.lbSongs.Size = new System.Drawing.Size(281, 479);
            this.lbSongs.TabIndex = 0;
            // 
            // txbArtist
            // 
            this.txbArtist.Location = new System.Drawing.Point(12, 50);
            this.txbArtist.Name = "txbArtist";
            this.txbArtist.Size = new System.Drawing.Size(202, 30);
            this.txbArtist.TabIndex = 1;
            // 
            // lblArist
            // 
            this.lblArist.AutoSize = true;
            this.lblArist.Location = new System.Drawing.Point(7, 13);
            this.lblArist.Name = "lblArist";
            this.lblArist.Size = new System.Drawing.Size(56, 25);
            this.lblArist.TabIndex = 2;
            this.lblArist.Text = "Artist";
            // 
            // lblSongs
            // 
            this.lblSongs.AutoSize = true;
            this.lblSongs.Location = new System.Drawing.Point(542, 13);
            this.lblSongs.Name = "lblSongs";
            this.lblSongs.Size = new System.Drawing.Size(154, 25);
            this.lblSongs.TabIndex = 3;
            this.lblSongs.Text = "Available Songs";
            // 
            // lblSong
            // 
            this.lblSong.AutoSize = true;
            this.lblSong.Location = new System.Drawing.Point(7, 92);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(59, 25);
            this.lblSong.TabIndex = 4;
            this.lblSong.Text = "Song";
            // 
            // txbSong
            // 
            this.txbSong.Location = new System.Drawing.Point(12, 120);
            this.txbSong.Name = "txbSong";
            this.txbSong.Size = new System.Drawing.Size(202, 30);
            this.txbSong.TabIndex = 5;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(12, 283);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(82, 34);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(100, 283);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(114, 33);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPlaylistAdd
            // 
            this.btnPlaylistAdd.Location = new System.Drawing.Point(846, 204);
            this.btnPlaylistAdd.Name = "btnPlaylistAdd";
            this.btnPlaylistAdd.Size = new System.Drawing.Size(199, 33);
            this.btnPlaylistAdd.TabIndex = 8;
            this.btnPlaylistAdd.Text = "Add to playlist";
            this.btnPlaylistAdd.UseVisualStyleBackColor = true;
            this.btnPlaylistAdd.Click += new System.EventHandler(this.btnPlaylistAdd_Click);
            // 
            // lbPlaylist
            // 
            this.lbPlaylist.FormattingEnabled = true;
            this.lbPlaylist.ItemHeight = 25;
            this.lbPlaylist.Location = new System.Drawing.Point(1064, 50);
            this.lbPlaylist.Name = "lbPlaylist";
            this.lbPlaylist.Size = new System.Drawing.Size(281, 479);
            this.lbPlaylist.TabIndex = 9;
            // 
            // lblPlaylist
            // 
            this.lblPlaylist.AutoSize = true;
            this.lblPlaylist.Location = new System.Drawing.Point(1059, 13);
            this.lblPlaylist.Name = "lblPlaylist";
            this.lblPlaylist.Size = new System.Drawing.Size(73, 25);
            this.lblPlaylist.TabIndex = 10;
            this.lblPlaylist.Text = "Playlist";
            // 
            // btnPlaylistRemove
            // 
            this.btnPlaylistRemove.Location = new System.Drawing.Point(846, 284);
            this.btnPlaylistRemove.Name = "btnPlaylistRemove";
            this.btnPlaylistRemove.Size = new System.Drawing.Size(199, 33);
            this.btnPlaylistRemove.TabIndex = 11;
            this.btnPlaylistRemove.Text = "Remove from playlist";
            this.btnPlaylistRemove.UseVisualStyleBackColor = true;
            this.btnPlaylistRemove.Click += new System.EventHandler(this.btnPlaylistRemove_Click);
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(7, 162);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(66, 25);
            this.lblGenre.TabIndex = 12;
            this.lblGenre.Text = "Genre";
            // 
            // txbGenre
            // 
            this.txbGenre.Location = new System.Drawing.Point(12, 190);
            this.txbGenre.Name = "txbGenre";
            this.txbGenre.Size = new System.Drawing.Size(202, 30);
            this.txbGenre.TabIndex = 13;
            // 
            // cmbArtist
            // 
            this.cmbArtist.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbArtist.Enabled = false;
            this.cmbArtist.FormattingEnabled = true;
            this.cmbArtist.Location = new System.Drawing.Point(247, 50);
            this.cmbArtist.Name = "cmbArtist";
            this.cmbArtist.Size = new System.Drawing.Size(280, 33);
            this.cmbArtist.TabIndex = 14;
            this.cmbArtist.SelectedIndexChanged += new System.EventHandler(this.cmbArtist_SelectedIndexChanged);
            // 
            // lblArtistList
            // 
            this.lblArtistList.AutoSize = true;
            this.lblArtistList.Location = new System.Drawing.Point(242, 13);
            this.lblArtistList.Name = "lblArtistList";
            this.lblArtistList.Size = new System.Drawing.Size(66, 25);
            this.lblArtistList.TabIndex = 15;
            this.lblArtistList.Text = "Artists";
            // 
            // frmMusicPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 542);
            this.Controls.Add(this.lblArtistList);
            this.Controls.Add(this.cmbArtist);
            this.Controls.Add(this.txbGenre);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.btnPlaylistRemove);
            this.Controls.Add(this.lblPlaylist);
            this.Controls.Add(this.lbPlaylist);
            this.Controls.Add(this.btnPlaylistAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.txbSong);
            this.Controls.Add(this.lblSong);
            this.Controls.Add(this.lblSongs);
            this.Controls.Add(this.lblArist);
            this.Controls.Add(this.txbArtist);
            this.Controls.Add(this.lbSongs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMusicPlaylist";
            this.Text = "Music playlist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSongs;
        private System.Windows.Forms.TextBox txbArtist;
        private System.Windows.Forms.Label lblArist;
        private System.Windows.Forms.Label lblSongs;
        private System.Windows.Forms.Label lblSong;
        private System.Windows.Forms.TextBox txbSong;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnPlaylistAdd;
        private System.Windows.Forms.ListBox lbPlaylist;
        private System.Windows.Forms.Label lblPlaylist;
        private System.Windows.Forms.Button btnPlaylistRemove;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.TextBox txbGenre;
        private System.Windows.Forms.ComboBox cmbArtist;
        private System.Windows.Forms.Label lblArtistList;
    }
}

