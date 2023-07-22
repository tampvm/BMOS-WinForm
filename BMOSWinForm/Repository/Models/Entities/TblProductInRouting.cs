using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models.Entities
{
    public partial class TblProductInRouting
    {
        public int Id { get; set; }
        public string ProductId { get; set; }
        public string RoutingId { get; set; }
    }
}
