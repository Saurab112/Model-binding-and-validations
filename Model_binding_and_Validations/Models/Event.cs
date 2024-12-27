using Model_binding_and_Validations.CustomValidators;
using System.ComponentModel.DataAnnotations;

namespace Model_binding_and_Validations.Models
{
	public class Event
	{
		[Required]
		public string? EventName { get; set; }

		[Required]
		[MinimumYearValidator(2015, ErrorMessage = "Event date must be after 2015.")]
		public DateTime EventDate { get; set; }
	}
}
