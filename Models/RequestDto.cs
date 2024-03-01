using static Mango.Web.Utility.SD;



namespace Mango.Web.Models
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; }
        public string  AccessToken { get; set; }

        // ho aggiunto questa property nella sezione 16 'images' perchè se devo uploadare
        // le immagini non posso più usare 
        // essage.Headers.Add("Accept", "application/json");
        // di conseguenza modifico anche Enum SD
        public ContentType ContentType { get; set; } = ContentType.Json;

    }
}