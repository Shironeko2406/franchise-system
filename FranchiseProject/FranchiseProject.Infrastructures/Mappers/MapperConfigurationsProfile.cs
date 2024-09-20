﻿using AutoMapper;
using FranchiseProject.Application.Commons;
using FranchiseProject.Application.ViewModels.AgencyViewModel;
using FranchiseProject.Application.ViewModels.SlotViewModels;
using FranchiseProject.Application.ViewModels.UserViewModels;
using FranchiseProject.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FranchiseProject.Infrastructures.Mappers
{
    public class MapperConfigurationsProfile : Profile 
    {
        public MapperConfigurationsProfile() {

            CreateMap<RegisFranchiseViewModel, FranchiseRegistrationRequests>();
            CreateMap<FranchiseRegistrationRequests, RegisFranchiseViewModel>().ForMember(dest => dest.CustomerName,otp=>otp.MapFrom(src => src.CusomterName)).ReverseMap();
            CreateMap<FranchiseRegistrationRequests, FranchiseRegistrationRequestsViewModel>()
           .ForMember(dest => dest.ConsultantUserName, opt => opt.MapFrom(src => src.User.UserName)).ReverseMap();

            #region User
            CreateMap<User, UserViewModel>();
            #endregion

            #region Slot
            CreateMap<CreateSlotModel, Slot>();
            CreateMap<Slot, SlotViewModel>();
            CreateMap<Pagination<Slot>, Pagination<SlotViewModel>>().ReverseMap();
            #endregion
        }
    }
}
