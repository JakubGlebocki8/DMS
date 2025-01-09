namespace DMS.Domain;
public class Device
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string serialNumber { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public DateTime? DayOfPurchase { get; set; }
    public int? UserId { get; set; }
    public User? User { get; set; }
}