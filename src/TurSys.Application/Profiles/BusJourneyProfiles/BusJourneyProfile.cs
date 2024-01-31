using AutoMapper;
using TurSys.Application.Models.BusJourneyModels;
using TurSys.Application.Requests;
using static TurSys.Application.Models.BusJourneyModels.GetListBusJourneyRequestModel;


namespace TurSys.Application.Profiles.BusJourneyProfiles;
public class BusJourneyProfile : Profile
{
    public BusJourneyProfile()
    {
        CreateMap(typeof(GetListBusJourneyRequestModel), typeof(BusJourneysRequest<DestinationRequest>)).ReverseMap();
        CreateMap<GetListBusJourneyRequestModelData, DestinationRequest>().ReverseMap();
    }
}
