namespace ColonyManager.Domain.Models
{
    public class UpdateSystemDataTypeRequestDto
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool IsList { get; set; }
        public string Comment { get; set; }
    }
}
