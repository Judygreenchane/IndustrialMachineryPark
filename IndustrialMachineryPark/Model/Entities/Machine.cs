namespace IndustrialMachineryPark.Model.Entities
{
    public class Machine
    {
        public int  Id { get; set; }
        public string? Name { get; set; }
        public bool IsOnline { get; set; }
        public DateTime LastUpdated { get; set; }
        public string? LatestData { get; set; }

    }
}
