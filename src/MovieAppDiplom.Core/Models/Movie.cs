using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;
using Newtonsoft.Json;

namespace MovieAppDiplom.Core.Models
{
    public class Movie 
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        public int Year { get; set; }
        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public double IMDBRate { get; set; }

        public string Genre { get; set; }

        public string Time { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string VideoUrl { get; set; }

        public List<Comment> Comments { get; set; }

        public Movie(FirebaseObject<Movie> fbMovie) {
            Name = fbMovie.Object.Name;
            Year = fbMovie.Object.Year;
            Description = fbMovie.Object.Description;
            ImageUrl = fbMovie.Object.ImageUrl;
            IMDBRate = fbMovie.Object.IMDBRate;
            Genre = fbMovie.Object.Genre;
            Time = fbMovie.Object.Time;
            Title = fbMovie.Object.Title;
            Author = fbMovie.Object.Author;
            VideoUrl = fbMovie.Object.VideoUrl;
            Comments = fbMovie.Object.Comments;
        }

        public Movie() { }

    }
}
