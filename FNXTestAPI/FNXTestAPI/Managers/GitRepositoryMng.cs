using FNXTestAPI.Services;
using Microsoft.Net.Http.Headers;

namespace FNXTestAPI.Managers
{
    internal class GitRepositoryMng
    {
        private string _gitRepoBaseUrl;
        private string _gitRepoSearchReposurlPrefix;

        private string _headerAccept;
        private string _headerUserAgent;

        public GitRepositoryMng(IConfiguration configuration)
        {
            _gitRepoBaseUrl = configuration["GitRepoSettings:BaseUrl"];
            _gitRepoSearchReposurlPrefix = configuration["GitRepoSettings:SearchReposUrl"];
            _headerAccept = configuration["GitRepoSettings:Headers:Accept"];
            _headerUserAgent = configuration["GitRepoSettings:Headers:UserAgent"];
        }


        private string SearchReposByName
        {
            get
            {
                return string.Format("{0}{1}", _gitRepoBaseUrl, _gitRepoSearchReposurlPrefix);
            }
        }
        private Dictionary<string, string> Headers
        {
            get
            {
                var headers = new Dictionary<string, string>();
                headers.Add(HeaderNames.Accept, _headerAccept);
                headers.Add(HeaderNames.UserAgent, _headerUserAgent);

                return headers;
            }
        }


        public async Task<HttpResponseMessage> SearchRepositoriesByName(string nameQuery)
        {
            return await RequestSrvc.GetAsync(SearchReposByName + nameQuery, Headers);
        }
    }
}
