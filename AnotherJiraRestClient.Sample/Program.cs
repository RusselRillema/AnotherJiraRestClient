using AnotherJiraRestClient.JiraModel;
using System.Collections.Generic;

namespace AnotherJiraRestClient.Sample
{
	class Program
	{
		static void Main(string[] args)
		{
			JiraClient client = Client(args);

            var projects = client.GetProjects();
            List<Project> createIssueInProject = new List<Project>();
            foreach (var project in projects)
            {
                if (client.MyPermissions(project.key).permissions.CREATE_ISSUES.havePermission)
                    createIssueInProject.Add(project);
            }

            string projectKey = "CLAPPS";//args[3];
			string issueKey = projectKey + "-" + args[4];
			string customFieldToUpdate = args[5];

			ProjectMeta projectMetaData = client.GetProjectMeta(projectKey);
			Issue issueWithAllFields = client.GetIssue(issueKey);

			// https://developer.atlassian.com/jiradev/jira-apis/jira-rest-apis/jira-rest-api-tutorials/jira-rest-api-example-edit-issues
			var updateIssue = new
			{
				fields = new { customfield_11421 = "1.0.0" }
			};
			client.UpdateIssueFields(issueKey, updateIssue);
		}

		private static JiraClient Client(string[] args)
		{
            var jiraUrl = System.Configuration.ConfigurationSettings.AppSettings.Get("jiraUrl");
            var userName = System.Configuration.ConfigurationSettings.AppSettings.Get("jiraUser");
            var password = System.Configuration.ConfigurationSettings.AppSettings.Get("jiraPassword");

			var client = new JiraClient(new JiraAccount
			{
				ServerUrl = jiraUrl,
				User = userName,
				Password = password
			});
			return client;
		}
	}
}
