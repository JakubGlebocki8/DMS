namespace DMS.Domain;
public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public List<Device> Devices { get; set; }
}