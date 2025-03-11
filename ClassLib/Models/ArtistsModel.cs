using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib.Models
{
    public class ArtistsModel
    {
        public List<Artist> Artists { get; }

        public ArtistsModel()
        {
            Artists = new List<Artist>();
            
            Artists.Add(new Artist
            {
                Name = "Пабло",
                Surname = "Руис-и-Пикассо",
                DateBirth = new System.DateTime(1881, 10, 25)
            });
        }

    }
}
