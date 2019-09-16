using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumMan.DocumentModels
{
    public class PhotoModel
    {
        public string FileName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Marked { get; set; }
        public DateTime Date { get; set; }
        public List<string> Tags { get; set; }
    }
}
