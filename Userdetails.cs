namespace UserApi.Models
{
    public class Userdetails
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsAdult { get; set; }

        public long Age { get; set; }
        public string? Secret { get; set; }
    }
}