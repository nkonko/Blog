using AutoMapper;

namespace BlogAPI.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            ////CreateMap<Entity, EntityDTO>().ForMember(d => d.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name))
        }
    }
}
