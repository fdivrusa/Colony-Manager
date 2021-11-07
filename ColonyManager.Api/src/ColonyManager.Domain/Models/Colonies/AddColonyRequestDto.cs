using NetTopologySuite.Geometries;

namespace ColonyManager.Domain.Models
{
    public class AddColonyRequestDto
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public int ConfigGenericTypeGroupId { get; set; }
        public int ConfigGenericTypeId { get; set; }
        public int MaxPopulation { get; set; }
        public int ActualPopulation { get; set; }
        public Geometry Border { get; set; }
    }
}
