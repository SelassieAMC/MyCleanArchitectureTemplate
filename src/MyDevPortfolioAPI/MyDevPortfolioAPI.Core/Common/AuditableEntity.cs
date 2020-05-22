using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDevPortfolioAPI.Core.Common
{
    public abstract class AuditableEntity
    {
        [Column(Order = 20)]
        public string CreatedBy { get; set; }
        [Column(Order = 21)]
        public DateTime Created { get; set; }
        [Column(Order = 22)]
        public string LastModifiedBy { get; set; }
        [Column(Order = 23)]
        public DateTime? LastModified { get; set; }
    }
}
