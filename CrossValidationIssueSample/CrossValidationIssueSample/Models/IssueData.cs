using CrossValidationIssueSample.Constants;
using Microsoft.ML.Runtime.Api;

namespace CrossValidationIssueSample.Models
{
    public class IssueData
    {
        public IssueData()
        {

        }

        public IssueData(IssueData issue)
        {
            this.ReporterCommentsCount = issue.ReporterCommentsCount;
            this.CommentsCount = issue.CommentsCount;
            this.CommentsLenght = issue.CommentsLenght;
            this.AsigneeEmail = issue.AsigneeEmail;
            this.Environment = issue.Environment;
            this.ProjectName = issue.ProjectName;
            this.ReporterEmail = issue.ReporterEmail;
            this.Type = issue.Type;
        }

        [Column("1", Columns.Environment)]
        public string Environment;

        [Column("2", Columns.Type)]
        public string Type;

        [Column("3", Columns.CommentsCount)]
        public float CommentsCount;

        [Column("4", Columns.CommentsLenght)]
        public float CommentsLenght;

        [Column("5", Columns.ReporterCommentsCount)]
        public float ReporterCommentsCount;

        [Column("6", Columns.ProjectName)]
        public string ProjectName;

        [Column("7", Columns.AsigneeEmail)]
        public string AsigneeEmail;

        [Column("8", Columns.ReporterEmail)]
        public string ReporterEmail;
    }
}
