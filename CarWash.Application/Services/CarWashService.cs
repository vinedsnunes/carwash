using CarWash.Application.Data.Context;
using CarWash.Application.Services.Interfaces;

namespace CarWash.Application.Services
{
    public class CarWashService : ICarWashService
    {
        private readonly ApplicationDbContext _context;

        public CarWashService(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
