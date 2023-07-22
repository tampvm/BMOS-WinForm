﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models.Entities
{
    public partial class TblProduct
    {
        public TblProduct()
        {
            TblFavouriteLists = new HashSet<TblFavouriteList>();
            TblFeedbacks = new HashSet<TblFeedback>();
            TblOrderDetails = new HashSet<TblOrderDetail>();
        }

        public string ProductId { get; set; }
        public string Name { get; set; }
        public int? Quantity { get; set; }
        public string Description { get; set; }
        public double? Weight { get; set; }
        public int? SoldQuantity { get; set; }
        public bool? IsLoved { get; set; }
        public bool? Status { get; set; }
        public double? Price { get; set; }
        public string Type { get; set; }

        public virtual ICollection<TblFavouriteList> TblFavouriteLists { get; set; }
        public virtual ICollection<TblFeedback> TblFeedbacks { get; set; }
        public virtual ICollection<TblOrderDetail> TblOrderDetails { get; set; }
    }
}
