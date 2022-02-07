namespace UserApi.Models
{
    public class UserdetailsDTO
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsAdult { get; set; }

        public long Age { get; set; }
    }
}