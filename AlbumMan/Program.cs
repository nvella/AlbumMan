﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlbumMan
{
    public class Program
    {
        private MainForm _mainForm;

        public void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(_mainForm = new MainForm(this));
        }

        public void OpenAlbum(string albumPath)
            => CurrentAlbum = Album.LoadFromPath(albumPath);

        private Album _currentAlbum;
        public Album CurrentAlbum
        {
            get => _currentAlbum;
            set
            {
                _currentAlbum = value;
                _mainForm.HandleAlbumChange(value);
                CurrentPhoto = value.Photos.Count > 0 ? value.Photos[0] : null;
            }
        }

        private Photo _currentPhoto;
        public Photo CurrentPhoto
        {
            get => _currentPhoto;
            set
            {
                _currentPhoto = value;
                _mainForm.HandlePhotoChange(value);
            }
        }

        public void NextPhoto()
        {
            var i = CurrentAlbum.Photos.IndexOf(CurrentPhoto);
            if (i < 0) return;
            i = (i + 1) % CurrentAlbum.Photos.Count;
            CurrentPhoto = CurrentAlbum.Photos[i];
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var program = new Program();
            program.Run();
        }
    }
}
