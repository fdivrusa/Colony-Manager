namespace ColonyManager.Domain.Models
{
    public class ConfigGenericItemDto : BaseDto
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
