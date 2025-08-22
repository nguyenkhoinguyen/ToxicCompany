using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReviewCompany.Models.Requests;
using ReviewCompany.Models.Responses;

namespace ReviewCompany.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class CommentController : ControllerBase
    {
        [HttpGet("GetComment")]
        public ActionResult<GetCommentResponse> GetComment([FromQuery] GetCommentRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.DeviceId))
                return BadRequest("DeviceId is required.");

            var now = DateTime.UtcNow;

            var list = new List<CommentDto>
            {
                new CommentDto
                {
                    ParentComentId = Guid.NewGuid(),
                    UserId = 101, UserName = "Dat", UserImageUrl = "/u/dat.png",
                    Content = "Dịch vụ ổn!", NumberLike = 10, NumberDislike = 0, NumberAngry = 0,
                    CreatedDate = now.AddMinutes(-30), Type = "text"
                },
                new CommentDto
                {
                    ParentComentId = Guid.NewGuid(),
                    UserId = 102, UserName = "Linh", UserImageUrl = "/u/linh.png",
                    Content = "Giá hơi cao.", NumberLike = 2, NumberDislike = 1, NumberAngry = 0,
                    CreatedDate = now.AddHours(-2), Type = "text"
                }
            };

            // TODO: áp dụng CompanyId, ParentComentId, Page, PageSize nếu cần

            return new GetCommentResponse
            {
                Success = true,
                Total = list.Count,
                Result = list
            };
        }
    }
}
