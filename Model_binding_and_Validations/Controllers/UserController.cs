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

		//get user details
		[Route("/user/{id}")]
		public IActionResult GetUserDetails(int id)
		{
			var user = new User() {  UserID = id, Email = "saurab11@gmail.com", UserName="Saurab" };
			
			
			return View(user);
		}
	}
}
