﻿using System;
using System.Collections.Generic;

namespace Wilson.Companies.Core.Entities
{
    public class Inquiry : Entity
    {
        public DateTime ReceivedAt { get; set; }

        public DateTime? ClosedAt { get; set; }

        public string Description { get; set; }

        public string ReceivedById { get; set; }

        public string CustomerId { get; set; }

        public string ProjectId { get; set; }

        public virtual Employee RecivedBy { get; set; }

        public virtual Company Customer { get; set; }

        public virtual Project Project { get; set; }

        public virtual ICollection<Attachment> Attachmnets { get; set; } = new HashSet<Attachment>();

        public virtual ICollection<InfoRequest> InfoRequests { get; set; } = new HashSet<InfoRequest>();

        public virtual ICollection<InquiryEmployee> Assignees { get; set; } = new HashSet<InquiryEmployee>();

        public virtual ICollection<Offer> Offers { get; set; } = new HashSet<Offer>();
    }
}
