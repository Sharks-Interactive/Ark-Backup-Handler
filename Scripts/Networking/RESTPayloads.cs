using System;
using System.Collections.Generic;
using System.Text;
using static ABH.Net.GitClient;

namespace ABH.Net.Payloads
{
    // See https://docs.github.com/en/rest/reference/repos#releases
    class Release
    {
        public string accept = "application/vnd.github.v3+json";
        public Repository repo;
        public int per_page;
        public int page;

        public Release(Repository _repo, int _per_page, int _page)
        {
            repo = _repo;
            per_page = _per_page;
            page = _page;
        }

        public Release(string _accept, Repository _repo, int _per_page, int _page)
        {
            accept = _accept;
            repo = _repo;
            per_page = _per_page;
            page = _page;
        }
    }
}
