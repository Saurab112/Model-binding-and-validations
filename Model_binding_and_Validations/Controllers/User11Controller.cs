using Microsoft.AspNetCore.Mvc;
using Model_binding_and_Validations.Models;

namespace Model_binding_and_Validations.Controllers
{
	public class User11Controller : Controller
	{
		//form
		[HttpGet("user/create")]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost("user/create")]
		public IActionResult Create(User11 user)
		{
			if(ModelState.IsValid)
			{
				return Content($"User:{user.FirstName} {user.LastName} with Email: {user.Email} is successfully created");
			}
			else
			{
				string errors = "Validation Errors: ";
				foreach(var key in ModelState.Keys)
				{
					var state = ModelState[key];   //ModelState is a dict, contains an Errors collection that holds any validation errors associated with the key.

					foreach (var error in state.Errors)  //state.Errors is a list of errors for the specific key
					{
						errors += $"{key}: {error.ErrorMessage}\n";   // This line formats and appends each validation error to the errors string.
					}
				}
				return Content(errors);
			}
		}
	}
}
