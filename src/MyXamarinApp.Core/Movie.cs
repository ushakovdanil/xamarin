﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyXamarinApp.Core
{
    public class Movie
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Year { get; set; }
        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public int IMDBRate { get; set; }

        public string Genre { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public Movie() { }

    }
}
