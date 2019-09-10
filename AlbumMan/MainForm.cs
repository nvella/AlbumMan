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

        public AlbumPhotoPanel PhotoPanel { get => albumPhotoPanel1; }

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
                        item.Selected = true;
                        break;
                    }
                }

                // Update the AlbumPhotoPanel
                PhotoPanel.Title = photo.Title;
                PhotoPanel.Description = photo.Description;
                PhotoPanel.Image = photo.Image;
                PhotoPanel.Marked = photo.Marked;

                // Select the Title text box
                PhotoPanel.SelectTitle();
            }
        }

        private void LoadPhotosList(Album album)
        {
            listBoxPhotos.Items.Clear();
            listBoxPhotos.Items.AddRange(album.Photos.Select(photo => photo.ListViewItem).ToArray());
        }

        public void UpdatePhotoList()
        {
            foreach(ListViewItemPhoto item in listBoxPhotos.Items) item.Update();
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

        private void SaveAndNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _program.ConfirmPhotoData();
            _program.NextPhoto();
        }

        private void ToggleMarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _program.ToggleMark();
        }

        private void ToolStripButtonOpen_Click(object sender, EventArgs e)
            => OpenAlbumToolStripMenuItem_Click(sender, e);

        private void ToolStripButtonSave_Click(object sender, EventArgs e)
        {
            // TODO point to save menu item handler
        }

        private void ToolStripButtonPrev_Click(object sender, EventArgs e)
            => PreviousToolStripMenuItem_Click(sender, e);

        private void ToolStripButtonNext_Click(object sender, EventArgs e)
            => NextToolStripMenuItem_Click(sender, e);

        private void PreviousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _program.PreviousPhoto();
        }

        private void NextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _program.NextPhoto();
        }
    }
}
