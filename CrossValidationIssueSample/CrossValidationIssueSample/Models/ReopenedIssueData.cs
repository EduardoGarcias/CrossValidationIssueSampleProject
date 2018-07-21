using CrossValidationIssueSample.Constants;
using Microsoft.ML.Runtime.Api;

namespace CrossValidationIssueSample.Models
{
    public class ReopenedIssueData : IssueData
    {
        public ReopenedIssueData()
        {

        }

        public ReopenedIssueData(IssueData issueData) : base(issueData)
        {

        }

        [Column(ordinal: "0", name: Columns.Label)]
        public bool WasReopened;
    }
}
