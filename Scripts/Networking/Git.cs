using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using ABH.Net.Payloads;

namespace ABH.Net
{
    class GitClient
    {
        public struct Repository
        {
            public string owner;
            public string repo;
        }

        class Releases
        {
            static HttpClient _client = new HttpClient();

            public List<string> ListReleases (Repository _repository)
            {
                Release _release = new Release(_repository, 30, 1);

                HttpResponseMessage _response = await _client.PostAsJsonAsync
            }
        }
    }
}
