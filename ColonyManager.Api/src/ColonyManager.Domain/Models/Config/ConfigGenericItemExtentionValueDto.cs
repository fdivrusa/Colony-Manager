namespace ColonyManager.Domain.Models
{
    public class ConfigGenericItemExtentionValueDto : BaseDto
    {
        public int GroupId { get; set; }
        public int ItemId { get; set; }
        public int ExtentionId { get; set; }
        public string Value { get; set; }
    }
}