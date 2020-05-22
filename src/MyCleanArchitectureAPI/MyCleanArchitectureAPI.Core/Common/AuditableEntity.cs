using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyDevPortfolioAPI.Core.Common
{
    public abstract class AuditableEntity
    {
        [Column(Order = 200)]
        public string CreatedBy { get; set; }
        [Column(Order = 201)]
        public DateTime Created { get; set; }
        [Column(Order = 202)]
        public string LastModifiedBy { get; set; }
        [Column(Order = 203)]
        public DateTime? LastModified { get; set; }
    }
}
