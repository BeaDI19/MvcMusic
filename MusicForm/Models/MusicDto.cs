﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicForm.Models
{
    public class MusicDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public string Price { get; set; }
        public string Rating { get; set; }
       // public string Validation { get; set; }
    }
}
