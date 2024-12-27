using Microsoft.AspNetCore.Mvc;

namespace Model_binding_and_Validations.Controllers
{
	public class HomeController : Controller
	{
		//getbyname?name=Saurab
		[HttpGet("/getbyname")]
		public IActionResult Index([FromQuery] string name)
		{
			if (string.IsNullOrEmpty(name))
			{
				return BadRequest("Name is required");

			}
			return Ok($"Hello {name}");
		}
		
		/*
		 * [FromQuery]
           Use [FromQuery] to extract values from the query string in the URL (everything after the ?).
		[FromRoute]
           Use [FromRoute] when you want to extract values directly from the URL path (i.e., the route template).
		 */

		[HttpGet("/user/{userId}/{firstname}/{lastname}")]
		//http://localhost:5042/user/saurab/raj?userId=10
		public IActionResult GetUserbyUserId([FromQuery] int userId, [FromRoute] string firstname, [FromRoute] string lastname)
		{
			if (userId <= 0)
			{
				return BadRequest("Invalid user id");
			}
			return Ok($"User id {userId} found\n Hello {firstname} {lastname}");
			
		}


	}
}
