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
					var state = ModelState[key];
					foreach(var error in state.Errors)
					{
						errors += $"{key}: {error.ErrorMessage}\n";
					}
				}
				return Content(errors);
			}
			// If the model is not valid, return to the form with validation errors.
			return View(user);
		}
	}
}
