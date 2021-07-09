﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DtoVsAnonymousVsJson_API.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Count { get; set; }
        public Storage Storage { get; set; }
    }
}