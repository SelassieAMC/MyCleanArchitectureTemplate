using MyDevPortfolioAPI.Core.Common;
using System.Collections.Generic;

namespace MyDevPortfolioAPI.Core.Entities
{
    public class DocumentType : DictionaryEntity
    {
        public ICollection<Person> DocumentTypePersons { get; set; } = new HashSet<Person>();
    }
}