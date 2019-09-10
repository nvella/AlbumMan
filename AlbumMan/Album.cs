using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AlbumMan
{
    public class Album
    {
        public static string PHOTO_FILE_PATTERN = "*.jpg";

        public string AlbumPath { get; private set; }
        public string Title { get; set; }

        public List<Photo> Photos { get; private set; } = new List<Photo>();

        public Album(string path)
        {
            AlbumPath = path;
            Title = Path.GetFileName(path);
        }

        private void LoadAllPhotos()
        {
            Photos = Directory.GetFiles(AlbumPath, PHOTO_FILE_PATTERN)
                .Select(photoPath => Photo.LoadFromPath(photoPath)).ToList();
        }

        public static Album LoadFromPath(string path)
        {
            if(!Directory.Exists(path)) throw new DirectoryNotFoundException($"Album not found: {path}");
            var album = new Album(path);
            album.LoadAllPhotos();
            return album;
        }
    }
}
