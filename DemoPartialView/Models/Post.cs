﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoPartialView.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PostDate { get; set; }
    }
}