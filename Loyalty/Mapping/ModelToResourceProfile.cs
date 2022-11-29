using AutoMapper;
using si730ebu20201b980.API.Loyalty.Domain.Models;
using si730ebu20201b980.API.Loyalty.Resources;

namespace si730ebu20201b980.API.Loyalty.Mapping;

public class ModelToResourceProfile : Profile
{
    public ModelToResourceProfile()
    {
        CreateMap<Guardian, GuardianResource>();
        CreateMap<Urgency, UrgencyResource>();
        CreateMap<Reward, RewardResource>();
    }
}