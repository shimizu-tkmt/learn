using System.ComponentModel.DataAnnotations;

namespace SampleBlazorApp.Data
{
    public class Mydata
    {
        [Required]
        public string Name {  get; set; }
        public string Password { get; set; }
        [EmailAddress]
        public string Mail { get; set; }

        public Mydata(string Nmae, string Password, string Mail)
        {
            this.Name = Nmae ?? "my name.";
            this.Password = Password ?? "";
            this.Mail = Mail ?? "";
        }

        public override string ToString()
        {
            return "[" + Name + " (" + Password + ")" + Mail + "]";
        }
    }
}
