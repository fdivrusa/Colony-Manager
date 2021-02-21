namespace ColonyManager.Domain.Models
{
    public class UpdateConfigGenericItemExtentionValueRequestDto
    {
        public int GroupId { get; set; }
        public int ItemId { get; set; }
        public int ExentionId { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public string Comment { get; set; }
    }
}
