﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleMVCGrid.Models
{
    public class Comment
    {
        public int id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public virtual Post Post { get; set; }
    }
}
