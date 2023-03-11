using Domain;

namespace Services.Services
{
    public interface IUserService
    {
        bool Login(string userName, string password);
        void LogicDelete(int userId);
    }
}