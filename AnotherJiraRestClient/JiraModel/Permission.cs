using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherJiraRestClient.JiraModel
{
    public class Permission
    {
        public string id { get; set; }
        public string key { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string description { get; set; }
        public bool havePermission { get; set; }
        public bool deprecatedKey { get; set; }
    }
}
