﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstWebsite.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
    }
}