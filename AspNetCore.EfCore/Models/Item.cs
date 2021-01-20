using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AspNetCoreBasics.Models
{
    public partial class Item
    {
        public Item()
        {
            ItemDetail = new HashSet<ItemDetail>();
        }

        public int Id { get; set; }
        public string Item1 { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ItemDetail> ItemDetail { get; set; }
    }
}
