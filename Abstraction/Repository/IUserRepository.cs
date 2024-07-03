using WebAppForDocker.Dto;
using WebAppForDocker.Models;

namespace WebAppForDocker.Abstraction.Repository
{
    public interface IUserRepository
    {
        int AddUser(UserDto user);
        RoleId CheckUser(LoginDto loginDto);
    }
}
