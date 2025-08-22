using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReviewCompany.Models.Requests;
using ReviewCompany.Models.Responses;

namespace ReviewCompany.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class StarController : ControllerBase
    {
        [HttpGet("GetStar")]
        public ActionResult<GetStarResponse> GetStar([FromQuery] GetStarRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.DeviceId))
                return BadRequest("DeviceId is required.");

            var data = new StarDto
            {
                NumberStar1 = 5,
                NumberStar2 = 10,
                NumberStar3 = 18,
                NumberStar4 = 40,
                NumberStar5 = 27
            };

            var list = new List<StarDto> { data };
            var totalRatings = data.NumberStar1 + data.NumberStar2 + data.NumberStar3 + data.NumberStar4 + data.NumberStar5;
            var avg = totalRatings == 0
                ? 0f
                : (float)((1 * data.NumberStar1 + 2 * data.NumberStar2 + 3 * data.NumberStar3 + 4 * data.NumberStar4 + 5 * data.NumberStar5) / (double)totalRatings);

            return new GetStarResponse
            {
                Success = true,
                Total = list.Count,
                Result = list,
                Average = (float)Math.Round(avg, 2)
            };
        }
    }
}
