namespace ColonyManager.Domain.Models
{
    public class UpdateConfigGenericItemRequestDto
    {
        public int GroupId { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
    }
}
