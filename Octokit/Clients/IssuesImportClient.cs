using System.Collections.Generic;
using System.Threading.Tasks;

namespace Octokit
{
    /// <summary>
    /// A client for GitHub's Issues API.
    /// </summary>
    /// <remarks>
    /// See the <a href="http://developer.github.com/v3/issues/">Issues API documentation</a> for more information.
    /// </remarks>
    public class IssuesImportClient : ApiClient, IIssuesImportClient
    {
        /// <summary>
        /// Instantiates a new GitHub Issues API client.
        /// </summary>
        /// <param name="apiConnection">An API connection</param>
        public IssuesImportClient(IApiConnection apiConnection) : base(apiConnection)
        {
        }

        public Task<IssueImport> StartImport(string owner, string name, NewIssueImport newIssueImport)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, "owner");
            Ensure.ArgumentNotNullOrEmptyString(name, "name");
            Ensure.ArgumentNotNull(newIssueImport, "newIssueImport");

            return ApiConnection.Post<IssueImport>(ApiUrls.ImportIssues(owner, name), newIssueImport, AcceptHeaders.ImportIssuesApiPreview);
        }

        public Task<IssueImport> StartImport(long repositoryId, NewIssueImport newIssueImport)
        {
            Ensure.ArgumentNotNull(newIssueImport, "newIssue");

            return ApiConnection.Post<IssueImport>(ApiUrls.ImportIssues(repositoryId), newIssueImport, AcceptHeaders.ImportIssuesApiPreview);
        }
    }
}