public class ExercisesModel
{
	public int ExerciseID { get; set; }
	public string? ExerciseName { get; set; }
	public string? MuscleGroup { get; set; }

	public ExercisesModel()
	{
		ExerciseID = 1;
		ExerciseName = "Bench Press";
		MuscleGroup = "Chest";
	}
}