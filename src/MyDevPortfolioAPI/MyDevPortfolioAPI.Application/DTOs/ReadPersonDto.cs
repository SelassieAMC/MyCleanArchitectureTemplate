using MyDevPortfolioAPI.Application.Common.DTOsBase;

namespace MyDevPortfolioAPI.Application.DTOs
{
    public sealed class ReadPersonDto : PersonDto
    {
        public DocumentTypeDto DocumentType { get; set; }
        
    }
}
