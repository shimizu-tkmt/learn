using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace SampleRazorApp.Models;

public class Person: IValidatableObject
{
    public int PersonId {  get; set; }

    [Display(Name="名前")]
    public string Name { get; set; }

    [Display(Name="メールアドレス")]
    public string? Mail { get; set; }

    [Display(Name="年齢")]
    public int Age { get; set; }

    public IEnumerable<ValidationResult>
        Validate(ValidationContext validationContext)
    {
        if(Name == null)
        {
            yield return new ValidationResult("名前は必須項目です。");
        }
        if(Mail != null && !Regex.IsMatch(Mail, "[a-zA-Z0-9.+-_%]+@[a-zA-Z0-9.-]+"))
        {
            yield return new ValidationResult("メールアドレスが正しい形式ではありません。");
        }
        if(Age < 0)
        {
            yield return new ValidationResult("年齢はマイナスにできません。");
         }
    }
}
