using Microsoft.Extensions.Configuration.UserSecrets;

public class UserModel
{
	public int UserID { get; set; }
	public string? Username { get; set; }

	public UserModel()
{
	UserID = 1;
	Username = "Sebastian";
}
}