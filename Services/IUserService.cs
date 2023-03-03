namespace Services
{
	public interface IUserService
	{
		bool Login(string userName, string password);
	}
}