namespace ColonyManager.Domain.Models
{
    public class AddConfigGenericItemExtentionValueRequestDto
    {
        public int GroupId { get; set; }
        public int ItemId { get; set; }
        public int ExtentionId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        public string Comment { get; set; }
    }
}
