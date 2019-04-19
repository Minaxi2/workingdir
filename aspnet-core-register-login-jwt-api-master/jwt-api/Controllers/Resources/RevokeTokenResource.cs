using System.ComponentModel.DataAnnotations;

namespace jwt_api.Controllers.Resources
{
    public class RevokeTokenResource
    {
        [Required]
        public string Token { get; set; }
    }
}