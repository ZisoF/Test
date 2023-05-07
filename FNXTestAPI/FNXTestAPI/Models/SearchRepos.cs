using Newtonsoft.Json;

namespace FNXTestAPI.Models
{
//    {
//    "total_count": 27546,
//    "incomplete_results": false,
//    "items": [
//        {
//            "id": 24005775,
//            "node_id": "MDEwOlJlcG9zaXRvcnkyNDAwNTc3NQ==",
//            "name": "nba",
//            "full_name": "bttmly/nba",
//            "private": false,
//            "owner": {
//                "login": "bttmly",
//                "id": 3442934,
//                "node_id": "MDQ6VXNlcjM0NDI5MzQ=",
//                "avatar_url": "https://avatars.githubusercontent.com/u/3442934?v=4",
//                "gravatar_id": "",
//                "url": "https://api.github.com/users/bttmly",
//                "html_url": "https://github.com/bttmly",
//                "followers_url": "https://api.github.com/users/bttmly/followers",
//                "following_url": "https://api.github.com/users/bttmly/following{/other_user}",
//                "gists_url": "https://api.github.com/users/bttmly/gists{/gist_id}",
//                "starred_url": "https://api.github.com/users/bttmly/starred{/owner}{/repo}",
//                "subscriptions_url": "https://api.github.com/users/bttmly/subscriptions",
//                "organizations_url": "https://api.github.com/users/bttmly/orgs",
//                "repos_url": "https://api.github.com/users/bttmly/repos",
//                "events_url": "https://api.github.com/users/bttmly/events{/privacy}",
//                "received_events_url": "https://api.github.com/users/bttmly/received_events",
//                "type": "User",
//                "site_admin": false
//            },
//            "html_url": "https://github.com/bttmly/nba",
//            "description": "Node.js client for nba.com API endpoints",
//            "fork": false,
//            "url": "https://api.github.com/repos/bttmly/nba",
//            "forks_url": "https://api.github.com/repos/bttmly/nba/forks",
//            "keys_url": "https://api.github.com/repos/bttmly/nba/keys{/key_id}",
//            "collaborators_url": "https://api.github.com/repos/bttmly/nba/collaborators{/collaborator}",
//            "teams_url": "https://api.github.com/repos/bttmly/nba/teams",
//            "hooks_url": "https://api.github.com/repos/bttmly/nba/hooks",
//            "issue_events_url": "https://api.github.com/repos/bttmly/nba/issues/events{/number}",
//            "events_url": "https://api.github.com/repos/bttmly/nba/events",
//            "assignees_url": "https://api.github.com/repos/bttmly/nba/assignees{/user}",
//            "branches_url": "https://api.github.com/repos/bttmly/nba/branches{/branch}",
//            "tags_url": "https://api.github.com/repos/bttmly/nba/tags",
//            "blobs_url": "https://api.github.com/repos/bttmly/nba/git/blobs{/sha}",
//            "git_tags_url": "https://api.github.com/repos/bttmly/nba/git/tags{/sha}",
//            "git_refs_url": "https://api.github.com/repos/bttmly/nba/git/refs{/sha}",
//            "trees_url": "https://api.github.com/repos/bttmly/nba/git/trees{/sha}",
//            "statuses_url": "https://api.github.com/repos/bttmly/nba/statuses/{sha}",
//            "languages_url": "https://api.github.com/repos/bttmly/nba/languages",
//            "stargazers_url": "https://api.github.com/repos/bttmly/nba/stargazers",
//            "contributors_url": "https://api.github.com/repos/bttmly/nba/contributors",
//            "subscribers_url": "https://api.github.com/repos/bttmly/nba/subscribers",
//            "subscription_url": "https://api.github.com/repos/bttmly/nba/subscription",
//            "commits_url": "https://api.github.com/repos/bttmly/nba/commits{/sha}",
//            "git_commits_url": "https://api.github.com/repos/bttmly/nba/git/commits{/sha}",
//            "comments_url": "https://api.github.com/repos/bttmly/nba/comments{/number}",
//            "issue_comment_url": "https://api.github.com/repos/bttmly/nba/issues/comments{/number}",
//            "contents_url": "https://api.github.com/repos/bttmly/nba/contents/{+path}",
//            "compare_url": "https://api.github.com/repos/bttmly/nba/compare/{base}...{head}",
//            "merges_url": "https://api.github.com/repos/bttmly/nba/merges",
//            "archive_url": "https://api.github.com/repos/bttmly/nba/{archive_format}{/ref}",
//            "downloads_url": "https://api.github.com/repos/bttmly/nba/downloads",
//            "issues_url": "https://api.github.com/repos/bttmly/nba/issues{/number}",
//            "pulls_url": "https://api.github.com/repos/bttmly/nba/pulls{/number}",
//            "milestones_url": "https://api.github.com/repos/bttmly/nba/milestones{/number}",
//            "notifications_url": "https://api.github.com/repos/bttmly/nba/notifications{?since,all,participating}",
//            "labels_url": "https://api.github.com/repos/bttmly/nba/labels{/name}",
//            "releases_url": "https://api.github.com/repos/bttmly/nba/releases{/id}",
//            "deployments_url": "https://api.github.com/repos/bttmly/nba/deployments",
//            "created_at": "2014-09-13T21:02:53Z",
//            "updated_at": "2023-04-30T04:29:31Z",
//            "pushed_at": "2023-04-15T22:26:54Z",
//            "git_url": "git://github.com/bttmly/nba.git",
//            "ssh_url": "git@github.com:bttmly/nba.git",
//            "clone_url": "https://github.com/bttmly/nba.git",
//            "svn_url": "https://github.com/bttmly/nba",
//            "homepage": "",
//            "size": 1807,
//            "stargazers_count": 677,
//            "watchers_count": 677,
//            "language": "JavaScript",
//            "has_issues": true,
//            "has_projects": true,
//            "has_downloads": true,
//            "has_wiki": true,
//            "has_pages": false,
//            "has_discussions": false,
//            "forks_count": 175,
//            "mirror_url": null,
//            "archived": false,
//            "disabled": false,
//            "open_issues_count": 12,
//            "license": {
//            "key": "mit",
//                "name": "MIT License",
//                "spdx_id": "MIT",
//                "url": "https://api.github.com/licenses/mit",
//                "node_id": "MDc6TGljZW5zZTEz"
//            },
//            "allow_forking": true,
//            "is_template": false,
//            "web_commit_signoff_required": false,
//            "topics": [
//                "basketball",
//                "http-client",
//                "nba",
//                "sports"
//            ],
//            "visibility": "public",
//            "forks": 175,
//            "open_issues": 12,
//            "watchers": 677,
//            "default_branch": "master",
//            "score": 1.0
//        },
//    ]
//}
    public class SearchRepos
    {
        [JsonProperty("items")]
        public Items[]? items { get; set; }
    }

    public class Items
    {
        [JsonProperty("id")]
        public int? id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("owner")]
        public Owner? owner { get; set; }
    }

    public class Owner
    {
        [JsonProperty("avatar_url")]
        public string? Url { get; set; }
    }
}
