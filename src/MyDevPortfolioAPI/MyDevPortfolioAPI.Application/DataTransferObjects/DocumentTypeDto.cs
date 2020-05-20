using MyDevPortfolioAPI.Application.Common.Mappings;
using MyDevPortfolioAPI.Core.Entities;

namespace MyDevPortfolioAPI.Application.DataTransferObjects
{
    public class DocumentTypeDto : IMapFrom<DocumentType>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
