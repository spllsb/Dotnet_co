using System;
using System.Collections.Generic;
using Passenger.Core.Repositories;
using Passenger.Core.Domain;
using Passenger.Infrastructure.DTO;
using System.Linq;

namespace Passenger.Infrastructure.Repositories
{
    public class InMemoryDriverRepository : IDriverRepository
    {
        private ISet<Driver> _drivers = new HashSet<Driver>();

        public void Add(Driver driver)
        {
            _drivers.Add(driver);
        }
        public Driver Get(Guid userid)
            => _drivers.Single(x=> x.UserId == userid);
        public IEnumerable<Driver> GetAll()
            => _drivers;

        public void Update(Driver driver)
        {
        }
    }
}