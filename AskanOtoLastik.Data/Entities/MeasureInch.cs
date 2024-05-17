using System.ComponentModel.DataAnnotations;

namespace AskanOtoLastik.Data.Entities
{
    public class MeasureInch
    {
        [Key]
        public int Id { get; set; }
        public string? Inch { get; set; }
        public virtual List<Measure>? Measures { get; set; }
    }
}
