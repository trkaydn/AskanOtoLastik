using System.ComponentModel.DataAnnotations;

namespace AskanOtoLastik.Data.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? Model { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public int MeasureId { get; set; }
        public int Year { get; set; }
        public int Type { get; set; }
        public int Stock { get; set; }
        public virtual Brand? Brand { get; set; }
        public virtual Category? Category { get; set; }
        public virtual Measure? Measure { get; set; }
    }
}
