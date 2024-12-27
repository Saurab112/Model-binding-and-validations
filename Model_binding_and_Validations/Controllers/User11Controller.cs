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
			// If the model is not valid, return to the form with validation errors.
			return View(user);
		}
	}
}
