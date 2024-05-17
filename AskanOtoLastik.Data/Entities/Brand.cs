using System.ComponentModel.DataAnnotations;

namespace AskanOtoLastik.Data.Entities
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public virtual List<Product>? Products { get; set; }
    }
}
