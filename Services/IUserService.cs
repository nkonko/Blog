using Domain;

namespace Services
{
	public interface IUserService
	{
		bool Login(string userName, string password);
		void LogicDelete(int userId);
	}
}