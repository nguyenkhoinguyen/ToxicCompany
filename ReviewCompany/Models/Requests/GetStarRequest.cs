namespace ReviewCompany.Models.Requests
{
    public class GetStarRequest
    {
        public int? CompanyId { get; set; }
        public string DeviceId { get; set; } = string.Empty; // REQUIRED
    }
}
