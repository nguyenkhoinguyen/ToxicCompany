using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReviewCompany.Helpers;
using ReviewCompany.Models.Requests;
using ReviewCompany.Models.Responses;

namespace ReviewCompany.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IConfiguration _config;
        public AuthController(IConfiguration config) => _config = config;

        [AllowAnonymous]
        [HttpPost("GetToken")]
        public ActionResult<GetTokenResponse> GetToken([FromBody] GetTokenRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.ApiKey))
                return BadRequest("ApiKey is required.");

            // Check API key policy
            var allowedKeys = _config.GetSection("Auth:AllowedApiKeys").Get<string[]>() ?? Array.Empty<string>();
            if (allowedKeys.Length > 0 && !allowedKeys.Contains(request.ApiKey))
                return Unauthorized("Invalid ApiKey");

            var token = JwtHelper.GenerateToken(
                subject: request.ApiKey,
                key: _config["Jwt:Key"]!,
                issuer: _config["Jwt:Issuer"],
                audience: _config["Jwt:Audience"],
                expiresMinutes: int.TryParse(_config["Jwt:ExpiresMinutes"], out var m) ? m : 60
            );

            return new GetTokenResponse
            {
                Success = true,
                Total = 1,
                Result = token
            };
        }
    }
}
