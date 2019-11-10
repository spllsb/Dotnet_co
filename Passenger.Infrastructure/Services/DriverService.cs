using System;
using System.Threading.Tasks;
using Passenger.Core.Repositories;
using Passenger.Infrastructure.DTO;

namespace Passenger.Infrastructure.Services
{
    public class DriverService : IDriverService
    {
        private readonly IDriverRepository _driverRepository;

        public DriverService (IDriverRepository driverRepository)
        {
            _driverRepository = driverRepository;
        }
        public async Task<DriverDto> GetAsync(Guid userid)
        {
            var driver = await _driverRepository.GetAsync(userid);
            return new DriverDto
            {

            };
        }
    }
}