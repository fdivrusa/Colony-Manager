namespace ColonyManager.Domain.Models.Config
{
    public class UpdateConfigGenericGroupRequestDto
    {
        public int GroupId { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
    }
}
