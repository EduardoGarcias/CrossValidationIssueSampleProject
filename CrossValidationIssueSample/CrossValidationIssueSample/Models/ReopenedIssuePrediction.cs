using CrossValidationIssueSample.Constants;
using Microsoft.ML.Runtime.Api;

namespace CrossValidationIssueSample.Models
{
    public class ReopenedIssuePrediction
    {
        [ColumnName(Columns.PredictedLabel)]
        public bool IsGoingToBeReopened;
    }
}
