using Microsoft.AspNetCore.Mvc;
using Model_binding_and_Validations.Models;

namespace Model_binding_and_Validations.Controllers
{
	public class UserController : Controller
	{

		public IActionResult Index()
		{
			return View();
		}
		//model binding to automatically map values from the HTTP request (query string, form data, route data, etc.) to the properties of a model
		[Route("/user")]
		public IActionResult UserName([FromQuery] User user)
		{
			 // The User model is automatically populated from query parameters /user?username=saurab
			 //user.UserName gets value from query string

			if (string.IsNullOrEmpty(user.UserName))
			{
				return BadRequest("Enter the username");
			}
			return Ok($"Username: {user.UserName}");
		}

		//get user details
		[Route("/user1/{id}")]
		public IActionResult GetUserDetails(int id)
		{
			var user = new User() {  UserID = id, Email = "saurab11@gmail.com", UserName="Saurab" };
			
			
			return View(user);
		}
	}
}
