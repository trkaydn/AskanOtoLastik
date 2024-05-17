using System.ComponentModel.DataAnnotations;

namespace AskanOtoLastik.Data.Entities
{
    public class Measure
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int MeasureInchId { get; set; }
        public virtual MeasureInch? MeasureInch { get; set; }
        public virtual List<Product>? Products { get; set; }
    }
}
