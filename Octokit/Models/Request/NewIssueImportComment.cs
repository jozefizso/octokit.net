using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class NewIssueImportComment
    {
        public NewIssueImportComment(string body)
        {
            Body = body;
        }

        public string Body { get; set; }

        public DateTime? CreatedAt { get; set; }

        internal string DebuggerDisplay
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, "Body: {0} CreatedAt: {1}", Body, CreatedAt);
            }
        }
    }
}
