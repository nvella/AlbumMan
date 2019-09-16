using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumMan.DocumentModels
{
    public class AlbumModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<PhotoModel> Photos { get; set; }
    }
}
