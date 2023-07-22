using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models.Entities
{
    public partial class TblVoucherCode
    {
        public string VoucherId { get; set; }
        public string VoucherCode { get; set; }
        public double? Value { get; set; }
        public int? Quantity { get; set; }
        public int? Used { get; set; }
        public bool? Status { get; set; }
    }
}
