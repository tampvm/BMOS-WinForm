﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Repository.Models.Entities
{
    public partial class TblFeedback
    {
        public string FeedbackId { get; set; }
        public string ProductId { get; set; }
        public int? UserId { get; set; }
        public string Content { get; set; }
        public int? Star { get; set; }
        public DateTime? Date { get; set; }

        public virtual TblProduct Product { get; set; }
        public virtual TblUser User { get; set; }
    }
}
