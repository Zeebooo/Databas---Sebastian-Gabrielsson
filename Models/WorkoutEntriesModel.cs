public class WorkoutEntriesModel
{
	public int EntryID { get; set; }
	public int WorkoutID { get; set; }
	public int ExerciseID { get; set; }
	public int Sets { get; set; }
	public int Reps { get; set; }
	public int Weight { get; set; }
	public int RestTime { get; set; }

	public WorkoutEntriesModel()
	{
		EntryID = 1;
		WorkoutID = 1;
		ExerciseID = 1;
		Sets = 4;
		Reps = 10;
		Weight = 100;
		RestTime = 60;
	}
}