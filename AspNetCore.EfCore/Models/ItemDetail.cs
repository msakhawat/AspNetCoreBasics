using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace AspNetCoreBasics.Models
{
    public partial class ItemDetail
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public int? ItemId { get; set; }

        public virtual Item Item { get; set; }
    }
}
