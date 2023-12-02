using Practise103.Core.Dtos;
using Practise103.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise103.Core.Services
{
    public interface IUserService
    {
        Task<ResponseDto<UserDto>> CreateUserAsync(CreateUserDto createUserDto);
        Task<ResponseDto<UserDto>> GetUserByNameAsync(string userName);
    }
}
