namespace ReviewCompany.Models.Requests
{
    public class GetCompanyRequest
    {
        public string? CompanyName { get; set; }
        public string? Category { get; set; }
        public int? Star { get; set; }
        public int? Page { get; set; }
        public int? PageSize { get; set; }
        public string DeviceId { get; set; } = string.Empty; // REQUIRED
    }
}
