using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreBasics.Dtos
{
    public class ItemDto
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string Description { get; set; }

        public List<ItemDetailDto> ItemDetails { get; set; }
    }
}
