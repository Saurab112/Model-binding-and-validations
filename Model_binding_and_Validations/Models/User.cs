using System.ComponentModel.DataAnnotations;

namespace Model_binding_and_Validations.Models
{
	public class User
	{
		/*
		 * There are different types of models in ASP.NET, but the most common ones are:
        Plain Old C# Objects (POCO) models
		View Models
		Data Transfer Objects (DTOs)
		Entity Models (for Entity Framework)
		*/


		//POCO model representing the data structure for a user.
		public int UserID { get; set; }
		public string? UserName { get; set; }
		public string? Email { get; set; }


		//View Models are models specifically designed to represent the data that will be displayed in a view (HTML page). 

		//DTOs are often used to transfer data between different layers of the application, such as between the controller and service or controller and API. 

		//The entity model represents a User table in a database, and Entity Framework would map this class to the corresponding table in your database.

		//For future reference:
		/*
		 * ASP.NET Model Binding 
		 * **Key Concepts:**
		1. **Automatic Mapping** - Automatically maps incoming data (query strings, form data) to controller action parameters.
		2. **Model Binding Sources**:
		- Form Fields (POST requests)
		- Query Strings (GET requests)
		- Route Data (URL Segments)
		- JSON Data (Body of Request)
		3. **Custom Model Binders** - Allows creation of custom logic for binding complex data types.
		4. **Validation** - Automatically performs validation through `DataAnnotations`.
		*/


	}
}
