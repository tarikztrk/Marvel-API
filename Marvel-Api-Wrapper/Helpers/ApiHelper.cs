using Marvel_Api_Wrapper.Entities;
using System.Net.Http.Headers;
using System.Web;

namespace Marvel_Api_Wrapper.Helpers
{

    public static class ApiHelper
    {

        /// <summary>Gets an HTTP response from the Spotify API.</summary>
        /// <param name="token">The access token to use for the request.</param>
        /// <param name="url">The URL to request.</param>
        /// <returns>The response from the Spotify API.</returns>
        public async static Task<HttpResponseMessage> GetAsync(Uri url)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(MarvelUrls.APIV1.ToString());
                    url = AddApikeyToQuery(url);
                    var response = await client.GetAsync(url);
                    return response;
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                return null;
            }
        }



        public static Uri AddSingleParameter(this Uri url, string paramName, string paramValue)
        {
            var uriBuilder = new UriBuilder(url);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query[paramName] = paramValue;
            uriBuilder.Query = query.ToString();

            return uriBuilder.Uri;
        }

        public static Uri AddParameterFromList(this Uri url, Type parameters)
        {
            var uriBuilder = new UriBuilder(url);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);

            var parameterList = parameters.GetType().GetProperties().ToList();


            foreach (var item in parameterList)
            {
                if (!string.IsNullOrEmpty(item.ToString()))
                {
                    query[item.ToString().ToLower()] = item.ToString();
                }
            }

            uriBuilder.Query = query.ToString();

            return uriBuilder.Uri;
        }



        public static Uri AddApikeyToQuery(this Uri url/*, string apikey*/)
        {
            url = ApiHelper.AddSingleParameter(url, "ts", "1");
            url = ApiHelper.AddSingleParameter(url, "apikey", "13e0b75f20c8155317486dff796c32df");
            url = ApiHelper.AddSingleParameter(url, "hash", "7e236a8d1390bfa9870a0df88400b882");

            return url;
        }



    }
}