using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;

namespace Octokit
{
    /// <summary>
    /// Describes a new issue to create via the <see cref="IIssuesClient.Create(string,string,NewIssue)" /> method.
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class NewIssueImportIssue
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewIssueImport"/> class.
        /// </summary>
        /// <param name="title">The title of the issue.</param>
        public NewIssueImportIssue(string title)
        {
            Title = title;
            Labels = new Collection<string>();
        }

        /// <summary>
        /// Title of the milestone (required)
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Details about the issue.
        /// </summary>
        public string Body { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? ClosedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string Assignee { get; set; }

        public int? Milestone { get; set; }

        public bool Closed { get; set; }

        /// <summary>
        /// Labels to associate with this issue.
        /// </summary>
        /// <remarks>
        /// Only users with push access can set labels for new issues. Labels are silently dropped otherwise.
        /// </remarks>
        public Collection<string> Labels { get; private set; }

        internal string DebuggerDisplay
        {
            get
            {
                var labels = Labels ?? new Collection<string>();
                return string.Format(CultureInfo.InvariantCulture, "Title: {0} Labels: {1}", Title, string.Join(",", labels));
            }
        }
    }
}
