using System.ComponentModel.DataAnnotations;

namespace Recruitment.Core.Auth
{
    public class LoginResult
	{
		public string Message { get; set; } = string.Empty;

		public string Email { get; set; } = string.Empty;

		public string JwtBearer { get; set; } = string.Empty;

		public bool Success { get; set; } = false;
	}

	public class LoginModel
	{
		[Required(ErrorMessage = "Email is required.")]
		[EmailAddress(ErrorMessage = "Email address is not valid.")]
		public string Email { get; set; } = string.Empty;

		[Required(ErrorMessage = "Password is required.")]
		[DataType(DataType.Password)]
		public string Password { get; set; } = string.Empty;
	}

	public class RegModel : LoginModel
	{
		[Required(ErrorMessage = "Confirm password is required.")]
		[DataType(DataType.Password)]
		[Compare("password", ErrorMessage = "Password and confirm password do not match.")]
		public string Confirmpwd { get; set; } = string.Empty;
	}
}
