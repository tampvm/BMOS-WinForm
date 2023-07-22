﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models.Entities
{
    public partial class TblAddress
    {
        public int AddressId { get; set; }
        public int? UserId { get; set; }
        public string Address { get; set; }
        public string CityProvince { get; set; }
        public string District { get; set; }
        public string BlockVillage { get; set; }
        public bool? IsDefault { get; set; }

        public virtual TblUser User { get; set; }
    }
}
