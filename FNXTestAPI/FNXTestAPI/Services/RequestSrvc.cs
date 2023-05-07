namespace FNXTestAPI.Services
{
    internal static class RequestSrvc
    {
        private static HttpClient generateClient(Dictionary<string, string>? headers)
        {
            var client = new HttpClient();
            if (headers != null)
            {
                foreach (var key in headers.Keys)
                {
                    client.DefaultRequestHeaders.Add(key, headers[key]);
                }
            }
            
            return client;
        }

        public static async Task<HttpResponseMessage> GetAsync(string url, Dictionary<string, string>? headers = null)
        {
            return await generateClient(headers).GetAsync(url);
        }
    }
}
