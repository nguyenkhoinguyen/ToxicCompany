using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReviewCompany.Models.Requests;
using ReviewCompany.Models.Responses;

namespace ReviewCompany.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize] // tất cả action cần JWT
    public class CompanyController : ControllerBase
    {
        [HttpGet("GetCompany")]
        public ActionResult<GetCompanyResponse> GetCompany([FromQuery] GetCompanyRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.DeviceId))
                return BadRequest("DeviceId is required.");

            // DỮ LIỆU MẪU
            var list = new List<CompanyDto>
            {
                new CompanyDto
                {
                    Id = 1, Name = "ABC Corp", CategoryName = "Tech", Size = 200,
                    Adress = "Hà Nội", AverageStar = 4.3f, TotalReview = 128, Logo = "/img/abc.png"
                },
                new CompanyDto
                {
                    Id = 2, Name = "Sunrise", CategoryName = "Food", Size = 50,
                    Adress = "Đà Nẵng", AverageStar = 4.8f, TotalReview = 64, Logo = "/img/sunrise.png"
                }
            };

            // TODO: filter/sort/paging theo request (CompanyName/Category/Star/SortBy/Page/PageSize) nếu cần

            return new GetCompanyResponse
            {
                Success = true,
                Total = list.Count,
                Result = list
            };
        }
    }
}
