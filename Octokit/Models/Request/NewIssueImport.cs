using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class NewIssueImport
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewIssueImport"/> class.
        /// </summary>
        /// <param name="title">The title of the issue.</param>
        public NewIssueImport(string title)
        {
            Issue = new NewIssueImportIssue(title);
            Comments = new Collection<NewIssueImportComment>();
        }

        public NewIssueImportIssue Issue { get; private set; }

        public Collection<NewIssueImportComment> Comments { get; private set; }

        internal string DebuggerDisplay
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, "Title: '{0}', Comments: {1}", Issue.Title, Comments.Count);
            }
        }
    }
}
