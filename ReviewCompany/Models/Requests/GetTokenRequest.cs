using System.ComponentModel.DataAnnotations;

namespace ReviewCompany.Models.Requests
{
    public class GetTokenRequest
    {
        [Required(ErrorMessage = "ApiKey is required.")]
        public string ApiKey { get; set; } = string.Empty;

        [Required(ErrorMessage = "DeviceId is required.")]
        public string DeviceId { get; set; } = string.Empty;

        [Required(ErrorMessage = "DeviceName is required.")]
        public string DeviceName { get; set; } = string.Empty;

        [Required(ErrorMessage = "IpAddress is required.")]
        public string IpAddress { get; set; } = string.Empty;

        [Required(ErrorMessage = "AppId is required.")]
        public string AppId { get; set; } = string.Empty;

        [Required(ErrorMessage = "AppCode is required.")]
        public string AppCode { get; set; } = string.Empty;

        [Required(ErrorMessage = "Country is required.")]
        public string Country { get; set; } = string.Empty;
    }
}
