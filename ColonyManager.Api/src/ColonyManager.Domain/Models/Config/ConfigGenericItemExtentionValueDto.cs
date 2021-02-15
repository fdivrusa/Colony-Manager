namespace ColonyManager.Domain.Models.Config
{
    public class ConfigGenericItemExtentionValueDto : BaseDto
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int ItemId { get; set; }
        public int ExtentionId { get; set; }
        public string Value { get; set; }
    }
}