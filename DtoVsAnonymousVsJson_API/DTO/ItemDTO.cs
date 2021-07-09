using DtoVsAnonymousVsJson_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DtoVsAnonymousVsJson_API.DTO
{
    public class ItemDTO
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Count { get; set; }
    }

    public class ItemWithStorageDTO
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Count { get; set; }
        public List<Storage> Storages{ get; set; }

    }

}
