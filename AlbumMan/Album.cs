using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AlbumMan.DocumentModels;

namespace AlbumMan
{
    public class Album
    {
        public static string PHOTO_FILE_PATTERN = "*.jpg";

        public string AlbumPath { get; private set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public List<Photo> Photos { get; private set; } = new List<Photo>();

        public Album(string path)
        {
            AlbumPath = path;
            Title = Path.GetFileName(path);
        }

        public AlbumModel ToAlbumModel()
            => new AlbumModel()
            {
                Title = Title,
                Description = Description,
                Photos = Photos.Select(photo => photo.ToPhotoModel()).ToList()
            };

        public void SaveMetadata()
        {
            var yaml = Yaml.Serializer.Serialize(ToAlbumModel());
            File.WriteAllText(Path.Combine(AlbumPath, "album.yml"), yaml);
        }

        public void LoadMetadata()
        {
            var yaml = File.ReadAllText(Path.Combine(AlbumPath, "album.yml"));
            LoadFromAlbumModel(Yaml.Deserializer.Deserialize<AlbumModel>(yaml));
        }

        public void LoadFromAlbumModel(AlbumModel model)
        {
            Title = model.Title;
            Description = model.Description;
            
            // Load photos into existing photos
            foreach(var photoModel in model.Photos)
            {
                var photo = Photos.Where(p => Path.GetFileName(p.ImagePath) == photoModel.FileName).First();
                if (photo == null) continue; // photo not found
                photo.LoadFromPhotoModel(photoModel);
            }
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
            if(File.Exists(Path.Combine(album.AlbumPath, "album.yml"))) album.LoadMetadata();
            return album;
        }
    }
}
