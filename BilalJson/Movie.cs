using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilalJson
{
    public class Movie
    {  
        public int Id { get; set; }
        public bool Adult { get; set; }
        public string BackdropPath { get; set; }
        public int MovieId { get; set; }
        public string OriginalLanguage { get; set; }
        public string OriginalTitle { get; set; }
        public string Overview { get; set; }
        public double Popularity { get; set; }
        public string PosterPath { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Title { get; set; }
        public bool Video { get; set; }
        public float VoteAverage { get; set; }
        public int VoteCount { get; set; }
        public Genre[] Genres { get; set; }
    }
    public class Genre
    {
        public int Id { get; set; }
        public int GenreId { get; set; }
        public string Name { get; set; }
    }
}
