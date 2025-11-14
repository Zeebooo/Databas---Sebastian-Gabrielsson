using Microsoft.AspNetCore.Mvc;
using databas.Models;

namespace databas.Controllers
{
	public class WorkoutController : Controller
	{

		public IActionResult Workout()
		{
			List<WorkoutModel> Workouts = new List<WorkoutModel>
			{
				new WorkoutModel(1, 20250615, 60, 1),
				new WorkoutModel(2, 20250616, 45, 2),
				new WorkoutModel(3, 20250617, 30, 3)
			};

			return View(Workouts);
		}
	}


}