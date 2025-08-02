using System.ComponentModel.DataAnnotations;

namespace CursoWeb.Models
{
    public class UserModel
    {
        // São variaveis privadas automaticamente.
        [Required(ErrorMessage = "Informe o Login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Informe sua password")]
        public string Password { get; set; }
        public bool LembraMe { get; set; } //Novo
    }
}
