namespace DMS.Application.Devices
{
    public class DeviceDto
    {
        public string Name { get; set; }
        public string SerialNumber { get; set; }
        public string? UserName { get; set; }
        public DateTime DayOfPurchase { get; set; }
        public DateTime? ReleseDate { get; set; }
    }
}
