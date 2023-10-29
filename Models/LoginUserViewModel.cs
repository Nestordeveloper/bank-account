#pragma warning disable CS8618
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace bank_account.Models;
public class LoginUser
{
    [Required(ErrorMessage = "Debes ingresar tu correo.")]
    public string EmailLog { get; set; }
    [Required(ErrorMessage = "Debes ingresar tu contraseña.")]
    public string PasswordLog { get; set; }
}
