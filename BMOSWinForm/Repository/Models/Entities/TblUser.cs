using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models.Entities
{
    public partial class TblUser
    {
        public TblUser()
        {
            TblAddresses = new HashSet<TblAddress>();
            TblFavouriteLists = new HashSet<TblFavouriteList>();
            TblFeedbacks = new HashSet<TblFeedback>();
            TblNotifies = new HashSet<TblNotify>();
            TblRefunds = new HashSet<TblRefund>();
        }

        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool? IsConfirm { get; set; } = true;
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Numberphone { get; set; }
        public string Address { get; set; }
        public DateTime? DateCreate { get; set; } = DateTime.Now;
        public DateTime? LastActivitty { get; set; }
        public double? Point { get; set; } = 0;
        public bool? Status { get; set; } = false;
        public int? UserRoleId { get; set; } = 2;

        public virtual ICollection<TblAddress> TblAddresses { get; set; }
        public virtual ICollection<TblFavouriteList> TblFavouriteLists { get; set; }
        public virtual ICollection<TblFeedback> TblFeedbacks { get; set; }
        public virtual ICollection<TblNotify> TblNotifies { get; set; }
        public virtual ICollection<TblRefund> TblRefunds { get; set; }
    }
}
