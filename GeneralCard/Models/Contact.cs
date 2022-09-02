using System.ComponentModel.DataAnnotations;

namespace GeneralCard.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است"), MinLength(3,ErrorMessage ="نام وارد شده کمتر از سه کاراکتر نمی تواند باشد"), MaxLength(100)]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage ="ایمیل وارد شده صحیح نمی باشد")]
        public string Email { get; set; }
        public string Message { get; set; }
        public string Service { get; set; }
    }
}
