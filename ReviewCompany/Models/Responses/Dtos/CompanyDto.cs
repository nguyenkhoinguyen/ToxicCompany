namespace ReviewCompany.Models.Responses.Dtos
{
    public class CompanyDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public int Size { get; set; }
        public string Adress { get; set; } = string.Empty;   // giữ nguyên theo spec (Adress)
        public float AverageStar { get; set; }
        public int TotalReview { get; set; }
        public string Logo { get; set; } = string.Empty;
    }
}
