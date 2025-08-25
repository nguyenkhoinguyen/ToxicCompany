using ReviewCompany.Models.Responses.Dtos;

namespace ReviewCompany.Models.Responses
{
    public class GetStarResponse : BaseResponse<List<StarDto>>
    {
        public float Average { get; set; }
    }
}
