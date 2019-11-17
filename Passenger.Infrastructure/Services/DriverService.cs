using System;
using System.Threading.Tasks;
using AutoMapper;
using Passenger.Core.Repositories;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Services
{
    public class DriverService : IDriverService
    {
        private readonly IDriverRepository _driverRepository;
        private readonly IMapper _mapper; 

        public DriverService (IDriverRepository driverRepository, IMapper mapper)
        {
            _driverRepository = driverRepository;
            _mapper = mapper;
        }
        
        public async Task<DriverDto> GetAsync(Guid userid)
        {
            var driver = await _driverRepository.GetAsync(userid);
            return _mapper.Map<DriverDto>(driver);
        }
    }
}