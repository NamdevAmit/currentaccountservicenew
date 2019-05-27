using System;
using System.Collections.Generic;

namespace CurrentAccountService.Models
{
    public partial class Application
    {
        public int ApplicationId { get; set; }
        public string CustomerId { get; set; }
        public int ApplicationTypeCode { get; set; }
        public int? StatusCode { get; set; }
        public string BrachNo { get; set; }
        public int? ProductTypeCode { get; set; }
        public DateTime? BloblatAmmendedDate { get; set; }
        public string Data { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
    }
}
