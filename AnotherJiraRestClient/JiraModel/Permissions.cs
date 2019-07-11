using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherJiraRestClient.JiraModel
{
    public class Permissions
    {
        public Permission VIEW_WORKFLOW_READONLY { get; set; }
        public Permission CREATE_ISSUES { get; set; }
        public Permission VIEW_DEV_TOOLS { get; set; }
        public Permission BULK_CHANGE { get; set; }
        public Permission CREATE_ATTACHMENT { get; set; }
        public Permission DELETE_OWN_COMMENTS { get; set; }
        public Permission WORK_ON_ISSUES { get; set; }
        public Permission PROJECT_ADMIN { get; set; }
        public Permission COMMENT_EDIT_ALL { get; set; }
        public Permission ATTACHMENT_DELETE_OWN { get; set; }
        public Permission WORKLOG_DELETE_OWN { get; set; }
        public Permission CLOSE_ISSUE { get; set; }
        public Permission MANAGE_WATCHER_LIST { get; set; }
        public Permission VIEW_VOTERS_AND_WATCHERS { get; set; }
        public Permission ADD_COMMENTS { get; set; }
        public Permission COMMENT_DELETE_ALL { get; set; }
        public Permission CREATE_ISSUE { get; set; }
        public Permission DELETE_OWN_ATTACHMENTS { get; set; }
        public Permission DELETE_ALL_ATTACHMENTS { get; set; }
        public Permission ASSIGN_ISSUE { get; set; }
        public Permission LINK_ISSUE { get; set; }
        public Permission EDIT_OWN_WORKLOGS { get; set; }
        public Permission CREATE_ATTACHMENTS { get; set; }
        public Permission EDIT_ALL_WORKLOGS { get; set; }
        public Permission SCHEDULE_ISSUE { get; set; }
        public Permission CLOSE_ISSUES { get; set; }
        public Permission SET_ISSUE_SECURITY { get; set; }
        public Permission SCHEDULE_ISSUES { get; set; }
        public Permission WORKLOG_DELETE_ALL { get; set; }
        public Permission COMMENT_DELETE_OWN { get; set; }
        public Permission ADMINISTER_PROJECTS { get; set; }
        public Permission DELETE_ALL_COMMENTS { get; set; }
        public Permission RESOLVE_ISSUES { get; set; }
        public Permission VIEW_READONLY_WORKFLOW { get; set; }
        public Permission ADMINISTER { get; set; }
        public Permission MOVE_ISSUES { get; set; }
        public Permission TRANSITION_ISSUES { get; set; }
        public Permission SYSTEM_ADMIN { get; set; }
        public Permission DELETE_OWN_WORKLOGS { get; set; }
        public Permission BROWSE { get; set; }
        public Permission EDIT_ISSUE { get; set; }
        public Permission MODIFY_REPORTER { get; set; }
        public Permission EDIT_ISSUES { get; set; }
        public Permission MANAGE_WATCHERS { get; set; }
        public Permission EDIT_OWN_COMMENTS { get; set; }
        public Permission ASSIGN_ISSUES { get; set; }
        public Permission BROWSE_PROJECTS { get; set; }
        public Permission VIEW_VERSION_CONTROL { get; set; }
        public Permission WORK_ISSUE { get; set; }
        public Permission COMMENT_ISSUE { get; set; }
        public Permission WORKLOG_EDIT_ALL { get; set; }
        public Permission EDIT_ALL_COMMENTS { get; set; }
        public Permission DELETE_ISSUE { get; set; }
        public Permission MANAGE_SPRINTS_PERMISSION { get; set; }
        public Permission USER_PICKER { get; set; }
        public Permission CREATE_SHARED_OBJECTS { get; set; }
        public Permission ATTACHMENT_DELETE_ALL { get; set; }
        public Permission DELETE_ISSUES { get; set; }
        public Permission MANAGE_GROUP_FILTER_SUBSCRIPTIONS { get; set; }
        public Permission RESOLVE_ISSUE { get; set; }
        public Permission ASSIGNABLE_USER { get; set; }
        public Permission TRANSITION_ISSUE { get; set; }
        public Permission COMMENT_EDIT_OWN { get; set; }
        public Permission MOVE_ISSUE { get; set; }
        public Permission WORKLOG_EDIT_OWN { get; set; }
        public Permission DELETE_ALL_WORKLOGS { get; set; }
        public Permission LINK_ISSUES { get; set; }
    }
}
