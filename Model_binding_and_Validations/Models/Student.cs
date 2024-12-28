using System.ComponentModel.DataAnnotations;

namespace Model_binding_and_Validations.Models
{
	public class Student
	{
		[Required(ErrorMessage = "Name is required.")]
		public string? Name { get; set; }

		[Range(1, 100, ErrorMessage = "Age must be between 1 and 100.")]
		public int Age { get; set; }

		[EmailAddress(ErrorMessage = "Invalid email address.")]
		public string? Email { get; set; }
	}
}
