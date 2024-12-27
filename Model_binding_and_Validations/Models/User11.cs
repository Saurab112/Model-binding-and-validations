using System.ComponentModel.DataAnnotations;

namespace Model_binding_and_Validations.Models
{
	public class User11
	{
		[Required(ErrorMessage ="FirstName is required")]
		[StringLength(50)]
		public string FirstName { get; set; }

		[Required(ErrorMessage ="Last Name is required")]
		[StringLength(50)]
		public string LastName { get; set; }

		[Required(ErrorMessage ="Email is required")]
		[EmailAddress(ErrorMessage ="Invalid email format.")]
		[CustomEmailValidation]
		public string Email { get; set; }
	}
}
