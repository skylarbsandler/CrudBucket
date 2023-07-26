namespace CrudBucketMVC.Models
{
    public class Town
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TimeAway { get; set; }
        public int DistanceRT { get; set; }
        public List<Hike> Hikes { get; set; } = new List<Hike>();
    }
}