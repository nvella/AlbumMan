using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumMan
{
    public partial class AlbumPropertiesDialog : Form
    {
        public AlbumPropertiesDialog()
        {
            InitializeComponent();
        }

        public string Title
        {
            get => textBoxTitle.Text;
            set => textBoxTitle.Text = value;
        }

        public string Description
        {
            get => textBoxDescription.Text;
            set => textBoxDescription.Text = value;
        }

        public void SaveToAlbum(Album album)
        {
            album.Title = Title;
            album.Description = Description;
        }

        public void LoadFromAlbum(Album album)
        {
            Title = album.Title;
            Description = album.Description;
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
