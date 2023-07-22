using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models.Entities
{
    public partial class TblVoucherUsed
    {
        public int Id { get; set; }
        public string VoucherId { get; set; }
        public int? UserId { get; set; }
    }
}
