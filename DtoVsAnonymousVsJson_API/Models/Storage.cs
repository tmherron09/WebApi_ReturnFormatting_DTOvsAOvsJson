using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DtoVsAnonymousVsJson_API.Models
{
    public class Storage
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public List<Item> Items { get; set; }
    }
}
