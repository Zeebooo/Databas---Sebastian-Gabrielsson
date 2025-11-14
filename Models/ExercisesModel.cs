public class ExercisesModel
{
	public int ExerciseID { get; set; }
	public string? ExerciseName { get; set; }
	public string? MuscleGroup { get; set; }

	public ExercisesModel(int exerciseid, string exercisename, string musclegroup)
	{
		ExerciseID = exerciseid;
		ExerciseName = exercisename;
		MuscleGroup = musclegroup;
	}
}