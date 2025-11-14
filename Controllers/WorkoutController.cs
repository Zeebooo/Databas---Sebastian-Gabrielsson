using Microsoft.AspNetCore.Mvc;
using databas.Models;
using Microsoft.Extensions.Configuration.UserSecrets;

namespace databas.Controllers
{
	public class WorkoutController : Controller
	{

		public IActionResult Workout(int? userid)
		{
			List<WorkoutModel> Workouts = new List<WorkoutModel>
			{
				new WorkoutModel(1, 20250615, 60, 1),
				new WorkoutModel(2, 20250616, 45, 2),
				new WorkoutModel(3, 20250617, 30, 3)
			};

			if (userid.HasValue){
				Workouts = Workouts.Where(workout => workout.UserID == userid.Value).ToList();
			}

			ViewBag.UserID = userid;
			
			return View(Workouts);
		}
	}


}