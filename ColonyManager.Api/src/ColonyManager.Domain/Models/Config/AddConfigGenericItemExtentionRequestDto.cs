namespace ColonyManager.Domain.Models
{
    public class AddConfigGenericItemExtentionRequestDto
    {
        public int GroupId { get; set; }
        public int ItemId { get; set; }
        public int SystemDataTypeId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
    }
}
