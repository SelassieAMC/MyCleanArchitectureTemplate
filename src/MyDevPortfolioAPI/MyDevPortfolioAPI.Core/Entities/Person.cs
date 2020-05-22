using System;
using MyDevPortfolioAPI.Core.Common;

namespace MyDevPortfolioAPI.Core.Entities
{
    public class Person : AuditableEntity
    {
        public Guid Id { get; set; } = new Guid();
        public int DocumentTypeID { get; set; }
        public DocumentType DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string SeconLastName { get; set; }
        public DateTime BirthDay { get; set; }
        public char Gender { get; set; }
        public string PhotoFile { get; set; }
        public string Phone { get; set; }
    }
}