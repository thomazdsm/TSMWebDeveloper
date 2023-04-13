using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSM.Application.ViewModels;
using TSM.Domain.Entities;

namespace TSM.Application.Mappings
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile() 
        {
            CreateMap<User, UserViewModel>();
        }
    }
}
