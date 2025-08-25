namespace ReviewCompany.Models.Requests
{
    public class GetCompanyDetailRequest
    {
        public int? Id { get; set; }
        public string DeviceId { get; set; } = string.Empty; // REQUIRED
    }
}
