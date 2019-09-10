using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumMan
{
    public partial class MainForm : Form
    {
        private Program _program;

        public MainForm(Program program)
        {
            _program = program;

            InitializeComponent();

        }

        public void HandleAlbumChange(Album album)
        {
            // Set the window title
            Text = $"AlbumMan - {album.Title}";

            // Set the photo list
            LoadPhotosList(album);
        }

        public void HandlePhotoChange(Photo photo)
        {
            if(photo == null && listBoxPhotos.SelectedItems.Count > 0)
            {
                // If a photo is being unselected, clear the list box selection
                listBoxPhotos.SelectedItems.Clear();
            } else if(photo != null)
            {
                // Find the photo and select it, if it's not already selected
                foreach (ListViewItemPhoto item in listBoxPhotos.Items)
                {
                    if (item.PhotoInstance == photo && !item.Selected)
                    {
                        listBoxPhotos.SelectedItems.Clear();
                        break;
                    }
                }

                // Update the AlbumPhotoPanel
                albumPhotoPanel1.DisplayedPhoto = photo;
            }
        }

        private void LoadPhotosList(Album album)
        {
            listBoxPhotos.Items.Clear();
            listBoxPhotos.Items.AddRange(album.Photos.Select(photo => photo.ListViewItem).ToArray());
        }

        private void OpenAlbumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var browserDialog = new FolderBrowserDialog();
            browserDialog.Description = "Select the album folder (contains photos.)";
            browserDialog.ShowNewFolderButton = true;
            var result = browserDialog.ShowDialog();
            if (result != DialogResult.OK) return;

            _program.OpenAlbum(browserDialog.SelectedPath);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListBoxPhotos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBoxPhotos.SelectedItems.Count == 1)
            {
                _program.CurrentPhoto = (listBoxPhotos.SelectedItems[0] as ListViewItemPhoto).PhotoInstance;
            } else
            {
                _program.CurrentPhoto = null;
            }
        }
    }
}
