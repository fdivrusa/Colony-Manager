namespace ColonyManager.Domain.Models
{
    public class AddSystemDataTypeRequestDto
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsList { get; set; }
        public string Comment { get; set; }
    }
}
