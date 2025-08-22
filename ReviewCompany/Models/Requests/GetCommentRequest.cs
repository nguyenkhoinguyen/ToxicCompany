namespace ReviewCompany.Models.Requests
{
    public class GetCommentRequest
    {
        public int? CompanyId { get; set; }
        public Guid? ParentComentId { get; set; } // giữ nguyên theo spec
        public int? Page { get; set; }
        public int? PageSize { get; set; }
        public string DeviceId { get; set; } = string.Empty; // REQUIRED
    }
}
