using AutoMapper;
using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using Practise103.Core.Dtos;
using Practise103.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise103.Service
{
    public class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductDto, ProductEntity>().ReverseMap();
            CreateMap<RoleDto, RoleEntity>().ReverseMap();
            CreateMap<UserDto, UserEntity>().ReverseMap();
        }
        
    }
}
