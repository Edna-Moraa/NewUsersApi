using System.ComponentModel.DataAnnotations;

namespace NewUsersApi.Models
{
    public class UserModel
    {
        [Required]
        [MinLength(10)]
        public string FirstName { get; private set; }
    }
}
