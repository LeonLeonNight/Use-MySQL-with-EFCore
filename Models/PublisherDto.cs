﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class PublisherDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<BookDto> Books { get; set; }
    }
}
