using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
     public class Artist
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime DateBirth { get; set; }


        public static Dictionary<string, string> Aliases = new Dictionary<string, string>();
    }
}
