using System.ComponentModel.DataAnnotations;

namespace Model_binding_and_Validations.Models
{
	public class User11
	{
		[Required(ErrorMessage ="FirstName is required")]
		public string FirstName { get; set; }

		[Required(ErrorMessage ="Last Name is required")]
		public string LastName { get; set; }

		[Required(ErrorMessage ="Email is required")]
		[EmailAddress(ErrorMessage ="Invalid email format.")]
		public string Email { get; set; }
	}
}
