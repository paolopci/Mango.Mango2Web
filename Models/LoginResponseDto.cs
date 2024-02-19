namespace Mango.Web.Models
{
    public class LoginResponseDto
    {
        //todo: Se un utente riesce a loggarsi allora ritorna UserDto+Token !!!!
        public UserDto User { get; set; }
        public string Token { get; set; }
    }
}
