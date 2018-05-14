﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using Octokit.Internal;

namespace Octokit
{
    /// <summary>
    /// Search labels
    /// https://developer.github.com/v3/search/#search-labels
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class SearchLabelsRequest : BaseSearchRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchLabelsRequest"/> class.
        /// </summary>
        public SearchLabelsRequest() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchLabelsRequest"/> class.
        /// </summary>
        /// <param name="term">The search term.</param>
        /// <param name="repositoryId">The repository to search in</param>
        public SearchLabelsRequest(string term, long repositoryId) : base(term)
        {
            RepositoryId = repositoryId;
        }

        /// <summary>
        /// Optional Sort field. Can only be indexed, which indicates how recently 
        /// a file has been indexed by the GitHub search infrastructure. 
        /// If not provided, results are sorted by best match.
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/search/#search-code
        /// </remarks>
        public LabelSearchSort? SortField { get; set; }

        public override string Sort
        {
            get { return SortField.ToParameter(); }
        }

        /// <summary>
        /// Limits searches to a specific organization.
        /// </summary>
        /// <remarks>
        /// https://help.github.com/articles/searching-code/#search-within-a-users-or-organizations-repositories
        /// </remarks>
        public long RepositoryId { get; set; }

        public override IDictionary<string, string> AdditionalParameters()
        {
            return new Dictionary<string, string>
            {
                { "repository_id", RepositoryId.ToString() }
            };
        }

        internal string DebuggerDisplay
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, "Term: {0} Sort: {1} RepositoryId: {2}", Term, Sort, RepositoryId);
            }
        }
    }

    public enum LabelSearchSort
    {
        /// <summary>
        /// search by created
        /// </summary>
        [Parameter(Value = "created")]
        Created,
        
        /// <summary>
        /// search by last updated
        /// </summary>
        [Parameter(Value = "updated")]
        Updated
    }
}
