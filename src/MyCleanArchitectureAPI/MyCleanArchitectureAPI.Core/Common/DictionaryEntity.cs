namespace MyDevPortfolioAPI.Core.Common
{
    public class DictionaryEntity : AuditableEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}