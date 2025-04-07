namespace PNE_Migration_Dapper_POC.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public int CompanyId { get; set; }
        public string? CustomerShort { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? MiddleName { get; set; }
        public string? Email { get; set; }
        public bool Deleted { get; set; } = false;
        public bool Imported { get; set; } = false;
        public string? ImportId { get; set; }
        public bool IsBouncedEmail { get; set; } = false;
        public string? CustomerNumber { get; set; }
        public string? Gender { get; set; }
        public DateTime? Birthday { get; set; }
        public DateTime? Anniversary { get; set; }
        public string? CountryCode { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedOn { get; set; } = DateTime.UtcNow;
    }
}
