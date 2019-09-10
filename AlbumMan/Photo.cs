using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AlbumMan
{
    public class Photo
    {
        public string ImagePath { get; private set; }

        public string Title { get; set; }
        public string Description { get; set; }

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

            Text = photo.Title;
            SubItems.Add(photo.Description);
        }
    }
}
