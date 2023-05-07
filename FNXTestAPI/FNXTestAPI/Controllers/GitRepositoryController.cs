using FNXTestAPI.Managers;
using FNXTestAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FNXTestAPI.Controllers
{
    [Route("api/git")]
    [ApiController]
    public class GitRepositoryController : Controller
    {
        private IConfiguration _configuration;
        private GitRepositoryMng _gitRepoMng; 

        public GitRepositoryController(IConfiguration iconfig)
        {
            _configuration = iconfig;
            _gitRepoMng = new GitRepositoryMng(_configuration);
        }


        [HttpGet("repos"), Authorize]
        public async Task<ActionResult<SearchRepos?>> Get(string query)
        {
            var responseMsg = await _gitRepoMng.SearchRepositoriesByName(query);
            if(responseMsg.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<SearchRepos>(
                    await responseMsg.Content.ReadAsStringAsync()
                );
            }
            else
            {
                return StatusCode((int)responseMsg.StatusCode, responseMsg.ReasonPhrase);
            }
        }
    }
}
