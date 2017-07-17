using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class IssueImport
    {
        public IssueImport() { }

        public IssueImport(int id, string status, string url, string importIssuesUrl, string repositoryUrl)
        {
            Id = id;
            Status = status;
            Url = url;
            ImportIssuesUrl = importIssuesUrl;
            RepositoryUrl = repositoryUrl;
        }

        public int Id { get; protected set; }

        public string Status { get; protected set; }

        public string Url { get; protected set; }

        public string ImportIssuesUrl { get; protected set; }

        public string RepositoryUrl { get; protected set; }

        internal string DebuggerDisplay
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, "Id: {0} Status: {1}", Id, Status);
            }
        }
    }
}