using AutoMapper;
using TurSys.Application.Models.BusLocationModels;
using TurSys.Application.Requests;

namespace TurSys.Application.Profiles.BusLocationProfiles;

public class BusLocationProfile : Profile
{
    public BusLocationProfile()
    {
        CreateMap<GetBusLocationRequestModel, BusLocationsRequest>().ReverseMap();
    }
}
