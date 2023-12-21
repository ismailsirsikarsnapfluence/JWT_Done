using JWT_Authentication_Authorization.Models;
using JWT_Authentication_Authorization.Models.Response;
using Microsoft.AspNetCore.Identity.Data;
namespace JWT_Authentication_Authorization.Interfaces
{
    public interface IAuthService
    {
        User AddUser(User user);
        LoginResponse Login(Models.LoginRequest loginRequest);
        Role AddRole(Role role);
        bool AssignRoleToUser(AddUserRole obj);
    }
}
