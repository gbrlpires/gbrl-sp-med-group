using System.ComponentModel.DataAnnotations;


namespace SpMedGroup.WebApi.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o email cadastrado")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe sua senha cadastrada")]
        public string Senha { get; set; }
    }
}
