namespace DMS.Application.DeviceCommad.AddDevice
{
    public class AddDeviceDto
    {
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public string? UserName { get; set; }
        public DateTime DayOfPurchase { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}
