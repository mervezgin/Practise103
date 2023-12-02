using Practise103.Core.Dtos;
using Practise103.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise103.Core.Services
{
    public interface IAuthenticationService
    {
        Task<ResponseDto<TokenDto>> CreateTokenAsync(LoginDto loginDto);
        Task<ResponseDto<TokenDto>> CreateTokenByRefreshToken(string refreshToken);
        Task<ResponseDto<NoDataDto>> RevokeRefreshToken(string refreshToken);
        Task<ResponseDto<ClientTokenDto>> CreateTokenByClient(ClientLoginDto clientLoginDto);
    }
}
