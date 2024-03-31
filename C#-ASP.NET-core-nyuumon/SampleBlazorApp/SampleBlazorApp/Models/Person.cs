using System.ComponentModel.DataAnnotations;

namespace SampleBlazorApp.Models;

public class Person
{
    public int PersonId {  get; set; }
    
    [Required]
    public string Name { get; set; }
    [EmailAddressAttribute]
    public string? Mail {  get; set; }
    [Range(0, 200)]
    public int Age { get; set; }
}
