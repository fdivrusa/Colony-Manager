using NetTopologySuite.Geometries;

namespace ColonyManager.Domain.Models
{
    public class ColonyDto : BaseDto
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string TypeCode { get; set; }
        public string TypeDescription { get; set; }
        public int MaxPopulation { get; set; }
        public int ActualPopulation { get; set; }
        public Geometry Border { get; set; }
    }
}
