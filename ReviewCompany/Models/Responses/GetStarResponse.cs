namespace ReviewCompany.Models.Responses
{
    public class StarDto
    {
        public int NumberStar1 { get; set; }
        public int NumberStar2 { get; set; }
        public int NumberStar3 { get; set; }
        public int NumberStar4 { get; set; }
        public int NumberStar5 { get; set; }
    }

    public class GetStarResponse : BaseResponse<List<StarDto>>
    {
        public float Average { get; set; }
    }
}
