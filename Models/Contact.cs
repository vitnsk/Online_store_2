using System.ComponentModel.DataAnnotations;

namespace Online_store_2.Models
{
    public class Contact
    {
        [Display(Name="Ведите имя")]
        [Required(ErrorMessage ="Вам нужно ввести имя")]
        public string Name { get; set; }

        [Display(Name = "Ведите фамилию")]
        [Required(ErrorMessage = "Вам нужно ввести фамилию")]
        public string Surname { get; set; }

        [Display(Name = "Ведите возраст")]
        [Required(ErrorMessage = "Вам нужно ввести возраст")]
        public int Age { get; set; }

        [Display(Name = "Ведите адрес электронной почты")]
        [Required(ErrorMessage = "Вам нужно ввести адрес электронной почты")]
        public string Email { get; set; }

        [Display(Name = "Ведите номер контактного телефона")]
        [Required(ErrorMessage = "Вам нужно ввести номер контактного телефона")]
        public string Phone { get; set; }

        [Display(Name = "Ведите сообщение")]
        [StringLength(30,ErrorMessage ="Текст менее 30 символов")]
        [Required(ErrorMessage = "Вам нужно ввести сообщение")]
        public string Message { get; set; }

    }
}
