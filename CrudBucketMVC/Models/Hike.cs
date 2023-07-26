namespace CrudBucketMVC.Models
{
    public class Hike
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MilesTotal { get; set; }
        public string Difficulty { get; set; }
        public int Rating { get; set; }
        public Town Town { get; set; }
    }
}
