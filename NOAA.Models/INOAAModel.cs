namespace NOAA.Models
{
    public interface INOAAModel
    {
        string GetModelUri();

        int Id { get; set; }
        DateTime Timestamp { get; }
    }
}
