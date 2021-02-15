namespace ColonyManager.Domain.Models
{
    public class AddConfigGenericItemRequestDto : BaseDto
    {
        public int GroupId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
