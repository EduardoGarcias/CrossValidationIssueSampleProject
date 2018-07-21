using CrossValidationIssueSample.Constants;
using CrossValidationIssueSample.Models;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Models;
using Microsoft.ML.Trainers;
using Microsoft.ML.Transforms;

namespace CrossValidationIssueSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataFilePath = "Data/test_generated.data";

            var pipeline = new LearningPipeline()
            {
                new TextLoader(dataFilePath).CreateFrom<ReopenedIssueData>(),
                new TextFeaturizer(Columns.Environment, Columns.Environment),
                new TextFeaturizer(Columns.Type, Columns.Type),
                new TextFeaturizer(Columns.ProjectName, Columns.ProjectName),
                new TextFeaturizer(Columns.AsigneeEmail, Columns.AsigneeEmail),
                new TextFeaturizer(Columns.ReporterEmail, Columns.ReporterEmail),
                new ColumnConcatenator(
                    Columns.Features,
                    Columns.Environment,
                    Columns.Type,
                    Columns.CommentsCount,
                    Columns.CommentsLenght,
                    Columns.ReporterCommentsCount,
                    Columns.ProjectName,
                    Columns.AsigneeEmail,
                    Columns.ReporterEmail
                ),
                new FastTreeBinaryClassifier()
            };

            //var predictionModel = pipeline.Train<ReopenedIssueData, ReopenedIssuePrediction>();

            var crossValidator = new CrossValidator()
            {
                // NumFolds = numOfFolds,
                Kind = MacroUtilsTrainerKinds.SignatureBinaryClassifierTrainer
            };
            var crossValidationResult = crossValidator.CrossValidate<ReopenedIssueData, ReopenedIssuePrediction>(pipeline);

        }
    }
}
