using Microsoft.AspNetCore.Razor.TagHelpers;

public class WorkoutModel
{
	public int WorkoutID { get; set; }
	public int Date { get; set; }
	public int Duration { get; set; }
	public int UserID { get; set; }

	public WorkoutModel(int workoutid, int date, int duration, int userid)
	{
		WorkoutID = workoutid;
		Date = date;
		Duration = duration;
		UserID = userid;
	}
}