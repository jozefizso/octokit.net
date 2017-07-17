using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;

namespace Octokit
{
    /// <summary>
    /// A client for GitHub's Import Issues API.
    /// </summary>
    /// <remarks>
    /// See the <a href="https://gist.github.com/jonmagic/5282384165e0f86ef105">Import Issues API documentation</a> for more information.
    /// </remarks>
    public interface IIssuesImportClient
    {
        /// <summary>
        /// Creates an issue for the specified repository. Any user with pull access to a repository can create an
        /// issue.
        /// </summary>
        /// <remarks>https://gist.github.com/jonmagic/5282384165e0f86ef105#start-an-issue-import</remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="NewIssueImport">A <see cref="NewIssueImport"/> instance describing the issue to import</param>
        Task<IssueImport> StartImport(string owner, string name, NewIssueImport newIssueImport);

        /// <summary>
        /// Creates an issue for the specified repository. Any user with pull access to a repository can create an
        /// issue.
        /// </summary>
        /// <remarks>https://gist.github.com/jonmagic/5282384165e0f86ef105#start-an-issue-import</remarks>
        /// <param name="repositoryId">The Id of the repository</param>
        /// <param name="NewIssueImport">A <see cref="NewIssueImport"/> instance describing the issue to import</param>
        Task<IssueImport> StartImport(long repositoryId, NewIssueImport newIssueImport);
    }
}