using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreBasics.Dtos
{
    public class ItemDetailDto
    {
        public int Id { get; set; }
        public int? ItemId { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
    }
}
