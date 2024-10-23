﻿using AutoMapper;
using CSharpClicker.Web.Domain;
using CSharpClicker.Web.UseCases.GetBoosts;

namespace CSharpClicker.Web.UseCases;

public class MappingProfie : Profile
{
    public MappingProfie()
    {
        CreateMap<Boost, BoostDto>();
    }
}
