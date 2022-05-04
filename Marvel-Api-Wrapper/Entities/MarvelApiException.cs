using System.Net;

namespace SpotifyApiWrapper.Entities
{
    public class MarvelApiException : Exception
    {
        public MarvelApiException()
        {

        }

        public MarvelApiException(string code, HttpStatusCode statusCode)
        {
            this.Code = code;
            this.StatusCode = statusCode;
        }

        public string Code { get; set; }
        public HttpStatusCode StatusCode { get; set; }
    }
}
