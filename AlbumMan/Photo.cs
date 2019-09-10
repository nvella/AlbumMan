using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace AlbumMan
{
    public class Photo
    {
        public string ImagePath { get; private set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Marked { get; set; }

        private Image _image = null;
        public Image Image {
            get
            {
                if (_image == null) _image = Image.FromFile(ImagePath);
                return _image;
             }
        }

        public Photo(string path)
        {
            ImagePath = path;
            Title = Path.GetFileName(path);
        }

        public static Photo LoadFromPath(string photoPath)
            => new Photo(photoPath);

        public ListViewItemPhoto ListViewItem => new ListViewItemPhoto(this);
    }

    public class ListViewItemPhoto : ListViewItem
    {
        public Photo PhotoInstance { get; private set; }

        public ListViewItemPhoto(Photo photo) : base()
        {
            PhotoInstance = photo;
            Update();
        }

        public void Update()
        {
            SubItems.Clear();

            Text = PhotoInstance.Title;
            SubItems.Add(PhotoInstance.Description);
        }
    }
}
