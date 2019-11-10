using AutoMapper;
using Passenger.Core.Domain;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
                => new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<User,UserDto>();
                    cfg.CreateMap<Driver,DriverDto>();

                    // domyslnie mapowane pola, musza miec taka sama nazwe. Jezeli nie maja, to mozna zrobic
                    // cfg.CreateMap<Driver,DriverDto>()
                        // .ForMember(x => x.MyVihicle, m => m.MapFrom(p => p.Vehicle));
                })
                .CreateMapper();
    }
}