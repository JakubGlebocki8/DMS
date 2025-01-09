using AutoMapper;
using DMS.Domain;
using Microsoft.EntityFrameworkCore;

namespace DMS.Infrastructure
{
    public class DmsRepository : IDmsRepository
    {
        private readonly DMSDbContext _dbContext;
        private object _mapper;
        public DmsRepository(DMSDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task Create(Domain.Device device)
        {
            _dbContext.Add(device);
            await Commit();
        }
        public Task Commit() => _dbContext.SaveChangesAsync();
        public async Task<List<Device>> GetAll() => await _dbContext.Devices.Include(d => d.User).ToListAsync();
        public async Task<User?> GetUserByNameAsync(string userName)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.Name == userName);
        }
        public async Task CreateUser(User user)
        {
            _dbContext.Add(user);
            await Commit();
        }
        public async Task<int> CountDevice(string name)
        {
            return await _dbContext.Devices
                .Where(r => r.User.Name == name)
                .CountAsync();
        }
        public async Task<Device?> GetDeviceBySerialNumberAsync(string serialNumber)
        {
            return await _dbContext.Devices.FirstOrDefaultAsync(u => u.serialNumber == serialNumber);
        }
        public async Task<List<User>> GetAllUsers() => await _dbContext.Users.ToListAsync();

        public async Task<bool> DeleteDeviceBySerialNumber(string serialNumber)
        {
            var user = await GetDeviceBySerialNumberAsync(serialNumber);
            if (user != null)
            {
                _dbContext.Devices.Remove(user);
                await Commit();
                return true;
            }
            else { return false; }

        }
        public async Task<bool> DeleteUserByName(string name)
        {
            var user = await GetUserByNameAsync(name);
            if (user != null)
            {
                _dbContext.Users.Remove(user);
                await Commit();
                return true;
            }
            else { return false; }



        }
    }
}