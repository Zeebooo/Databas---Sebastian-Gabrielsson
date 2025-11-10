using Microsoft.AspNetCore.Razor.TagHelpers;

public class WorkoutModel
{
	public int WorkoutID { get; set; }
	public int Date { get; set; }
	public int Duration { get; set; }
	public int UserID { get; set; }

	public WorkoutModel()
	{
		WorkoutID = 1;
		Date = 20240615;
		Duration = 60;
		UserID = 1;
	}
}