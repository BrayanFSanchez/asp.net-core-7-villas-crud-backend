using System.Net;

namespace CrudVillasAPI.Models
{
    public class APIResponse
    {
        public HttpStatusCode statusCode { get; set; }
        public bool IsSuccessful { get; set; } = true;

        public List<string> ErrorMessages { get; set; }

        public Object Result { get; set; }
    }
}
