using Microsoft.AspNetCore.Mvc;
using Model_binding_and_Validations.CustomModelBinders;
using Model_binding_and_Validations.Models;

namespace Model_binding_and_Validations.Controllers
{
	public class PersonController : Controller
	{
		[Route("register")]
		//Example JSON: { "PersonName": "William", "Email": "william@example.com", "Phone": "123456", "Password": "william123", "ConfirmPassword": "william123" }
		public IActionResult Index([FromBody][ModelBinder(BinderType = typeof(PersonModelBinder))] Person person)
		{
			if (!ModelState.IsValid)
			{
				//get error messages from model state
				string errors = string.Join("\n", ModelState.Values.SelectMany(value => value.Errors).Select(err => err.ErrorMessage));

				return BadRequest(errors);
			}

			return Json(person);
		}
	}
}
