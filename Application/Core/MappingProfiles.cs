using System;
using AutoMapper;
using Domain;

namespace Application.Core;

public class MappingProfiles :Profile
{
    //And we need to tell Automapper where we're going to map from and what we're going to map to.s
    public MappingProfiles()
    {
        CreateMap<Activity, Activity>();
    }
}
