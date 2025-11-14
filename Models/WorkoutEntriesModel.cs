public class WorkoutEntriesModel
{
	public int EntryID { get; set; }
	public int WorkoutID { get; set; }
	public int ExerciseID { get; set; }
	public int Sets { get; set; }
	public int Reps { get; set; }
	public int Weight { get; set; }
	public int RestTime { get; set; }

	public WorkoutEntriesModel(int entryid, int workoutid, int exerciseid, int sets, int reps, int weight, int resttime)
	{
		EntryID = entryid;
		WorkoutID = workoutid;
		ExerciseID = exerciseid;
		Sets = sets;
		Reps = reps;
		Weight = weight;
		RestTime = resttime;
	}
}