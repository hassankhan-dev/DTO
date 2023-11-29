using AutoMapper;
using DTO.DTO;
using DTO.Model;

namespace DTO.AutoMapper
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<LocationDto, Location>();
            CreateMap<CategoryDto, Category>();
            CreateMap<Breed, BreedDto>(); 
            CreateMap<PetDto, Pet>();
        }
    }
}
