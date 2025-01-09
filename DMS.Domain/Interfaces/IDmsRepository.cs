namespace DMS.Domain
{
    public interface IDmsRepository
    {
        Task<List<Device>> GetAll();
        Task Commit();
        Task Create(Device device);
        Task<User?> GetUserByNameAsync(string userName);
        Task<Device?> GetDeviceBySerialNumberAsync(string serialNumber);
        Task<bool> DeleteDeviceBySerialNumber(string serialNumber);
        Task<List<User>> GetAllUsers();
        Task<int> CountDevice(string name);
        Task CreateUser(User user);
        Task<bool> DeleteUserByName(string name);
    }
}