namespace ColonyManager.Domain.Models
{
    public class UpdateConfigGenericGroupRequestDto
    {
        public int GroupId { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
    }
}
