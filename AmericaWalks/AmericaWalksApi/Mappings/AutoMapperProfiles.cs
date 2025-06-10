using AutoMapper;
using AmericaWalksApi.Models.Domain;
using AmericaWalksApi.Models.DTO;

namespace AmericaWalksApi.Mappings
{
    // Created a Mapping folder. In it, I crafted a AutoMapperProfile class which inherits from a base class in the AutoMapper library named Profile.
    // The AutoMapperProfile allows the mapping of LocalDTO, AddLocationRequestDto, and UpdateLocationRequestDto into the Location Domain class.
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Location, LocationDto>().ReverseMap();
            CreateMap<Location, AddLocationRequestDto>().ReverseMap();
            CreateMap<Location, UpdateLocationRequestDto>().ReverseMap();
            CreateMap< Walk, AddWalkRequestDto>().ReverseMap();
            CreateMap<Walk, WalkDto>().ReverseMap();
            CreateMap<Difficulty, DifficultyDto>().ReverseMap();
            CreateMap<Walk, UpdateWalkRequestDto>().ReverseMap();
        }
    }
}
