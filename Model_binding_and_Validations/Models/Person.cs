namespace Model_binding_and_Validations.Models
{
	public class Person
	{
		public string? PersonName { get; set; }  // FirstName and LastName concatenated
		public string? Email { get; set; }
		public string? Phone { get; set; }
		public string? Password { get; set; }
		public string? ConfirmPassword { get; set; }
		public double Price { get; set; }
		public DateTime DateOfBirth { get; set; }
	}
}
