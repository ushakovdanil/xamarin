using System;
using System.Collections.Generic;
using System.Text;
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

        public Movie() { }

    }
}
