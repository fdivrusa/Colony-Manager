namespace ColonyManager.Domain.Models
{
    public class UpdateConfigGenericItemExtentionRequestDto
    {
        public int GroupId { get; set; }
        public int ItemId { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
    }
}
