using Microsoft.AspNetCore.Mvc;
using Model_binding_and_Validations.Models;

namespace Model_binding_and_Validations.Controllers
{
	//[ApiController] Attribute
	[ApiController]
	[Route("api/[controller]")]
	public class StudentController : Controller
	{
		//http://localhost:5042/api/student and should provide json data using postman with post request.
		[HttpPost]
		//Model Binding with [FromBody], it allows you to bind the incoming JSON data directly to a C# model object.

		public IActionResult SaveStudent([FromBody] Student student)
		{
			if (!ModelState.IsValid)
			{
				string errors = "Validation Errors: ";
				foreach (var key in ModelState.Keys)
				{
					var state = ModelState[key];
					foreach (var error in state.Errors)
					{
						errors += $"{key}: {error.ErrorMessage}\n";
					}
				}
				return Content(errors);
			}
			return Content($"Student {student.Name} successfully saved");
		}
	}
}
