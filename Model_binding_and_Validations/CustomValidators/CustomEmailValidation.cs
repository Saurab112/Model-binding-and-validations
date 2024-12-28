using System.ComponentModel.DataAnnotations;

namespace Model_binding_and_Validations.CustomValidators
{
	public class CustomEmailValidation : ValidationAttribute
	{
		public override bool IsValid(object? value)
		{
			if (value == null)
			{
				return false;
			}
			return value.ToString().EndsWith("@gmail.com");
		}
	}
}