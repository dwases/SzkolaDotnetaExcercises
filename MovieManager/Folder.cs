using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManager
{
    public class Folder
    {
        public string Name { get; set; }
        //public List <Movie> movies = new List <Movie> ();
        public List <Movie> Movies { get; set; }
        public Folder()
        {
            Movies = new List<Movie>();
        }
    }
}
