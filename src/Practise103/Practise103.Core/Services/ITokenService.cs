using Practise103.Core.Configuration;
using Practise103.Core.Dtos;
using Practise103.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise103.Core.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(UserEntity userEntity);

        ClientTokenDto CreateTokenByClient(Client client);

    }
}
