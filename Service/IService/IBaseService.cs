using Mango.Web.Models;


namespace Mango.Web.Service.IService
{
    public interface IBaseService
    {
        // per funzionare devo passare il token all'API del servizio
        Task<ResponseDto?> SendAsync(RequestDto requestDto, bool withBearer = true);
    }
}
