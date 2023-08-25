namespace RedBadgeFinal_BlazorServer.Data.Entities
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Region> Regions { get; set; } = new List<Region>();

    }
}
