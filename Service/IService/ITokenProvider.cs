namespace Mango.Web.Service.IService
{
    public interface ITokenProvider
    {
        // il token lo possiamo salvare sia nella Session che nei Cookie
        // noi usiamo i Cookie

        void SetToken(string token);
        string? GetToken();
        void ClearToken();
    }
}
