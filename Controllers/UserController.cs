using Microsoft.AspNetCore.Mvc;
using databas.Models;

namespace databas.Controllers
{
	public class UserController : Controller
	{
		static IList<UserModel> Users = new List<UserModel>
		{
			new UserModel(1, "Alice"),
			new UserModel(2, "Bob"),
			new UserModel(3, "Charlie")
		};
	}
}