
namespace SinemaArsivSitesi.Services.Auth
{
    public class AuthService : IAuthService
    {
        public  Task<bool> ChangePassword(string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAccount()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Logout()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Register(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> ResetPassword(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProfile(string name, string surname, string email)
        {
            throw new NotImplementedException();
        }
    }
}
