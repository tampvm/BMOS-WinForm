using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models.Entities
{
    public partial class TblFavouriteList
    {
        public string FavouriteListId { get; set; }
        public int? UserId { get; set; }
        public string ProductId { get; set; }

        public virtual TblProduct Product { get; set; }
        public virtual TblUser User { get; set; }
    }
}
