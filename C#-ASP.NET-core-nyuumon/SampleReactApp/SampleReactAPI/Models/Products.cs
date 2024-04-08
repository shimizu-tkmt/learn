using System.ComponentModel.DataAnnotations;

namespace SampleAPIApp.Models;

public class Product
{
    public int ProductId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    [DataType(DataType.Currency)]
    public int Price { get; set; }
    public string Description { get; set; }
}
