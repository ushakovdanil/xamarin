using Firebase.Annotations;
using Firebase.Database;
using Newtonsoft.Json;
using System;

namespace MovieAppDiplom.Droid.Models
{
    public class MovieDto
    {

        [JsonProperty("Id")]
        public Guid Id { get; set; }
        
        [PropertyName]
        public string Name { get; set; }

        [JsonProperty("Year")]
        public int Year { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }

        [JsonProperty("ImageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("IMDBRate")]
        public double IMDBRate { get; set; }

        [JsonProperty("Genre")]
        public string Genre { get; set; }

        [JsonProperty("Time")]
        public string Time { get; set; }

        [JsonProperty("Title")]
        public string Title { get; set; }

        [JsonProperty("Author")]
        public string Author { get; set; }

    }
}
