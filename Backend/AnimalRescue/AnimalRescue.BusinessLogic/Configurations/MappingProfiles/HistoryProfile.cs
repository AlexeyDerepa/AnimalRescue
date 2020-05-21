﻿using AnimalRescue.Contracts.BusinessLogic.Models.History;
using AnimalRescue.DataAccess.Mongodb.Models.History;
using AutoMapper;

namespace AnimalRescue.BusinessLogic.Configurations.MappingProfiles
{
    internal class HistoryProfile : Profile
    {
        public HistoryProfile()
        {
            CreateMap<DifferenceValue, DifferenceValueDto>();
            CreateMap<DifferenceValueDto, DifferenceValue>();
            CreateMap<History, HistoryDto>();
            CreateMap<HistoryDto, History>();
        }
    }
}