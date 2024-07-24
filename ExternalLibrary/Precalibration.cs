namespace ExternalLibrary
{
    public static class ClassicalAnalysis
    {
        public static List<ClassicalItemAnalysisResult> PerformItemAnalysis(AssessmentData pAssessmentData,
                                               ClassicalAnalysisSpecifications pClassicalAnalysisSpecifications)
        {
            return new List<ClassicalItemAnalysisResult>();
        }
        public static List<ClassicalDistractorAnalysisResult> PerformDistractorAnalysis(AssessmentData pAssessmentData,
                                               ClassicalAnalysisSpecifications pAnalysisSpecifications)
        {
            return new List<ClassicalDistractorAnalysisResult>();
        }
    }
    public class ClassicalItemAnalysisResult //likely nested in Item object - CttAttributes?
    {
        public int ItemId { get; set; }
        public bool IsRemoved { get; set; }
        public int StudentCount { get; set; }
        public int Points { get; set; }
        public double Mean { get; set; }
        public double StandardDeviation { get; set; }
        public double PValue { get; set;}
        public double CorrelationWithTotal { get; set;}
        public List<ClassicalDistractorAnalysisResult> ClassicalDistractorsAnalysisResults { get; set; } = new List<ClassicalDistractorAnalysisResult>();   
    }
    public class ClassicalDistractorAnalysisResult
    {
        public char DistractorValue { get; set; }
        public int ResponseCount { get; set; }
        public double MeanCriterionScore { get; set; }
        public double FirstQuartileRespondentsProportion { get; set; }
        public double SecondQuartileRespondentsProportion { get; set; }
        public double ThirdQuartileRespondentsProportion { get; set; }
        public double FourthQuartileRespondentsProportion { get; set; }
        public double Mean { get; set; } //Always same as p value?
        public double StandardDeviation { get; set; }
        public double PValue { get; set;}
        public double CorrelationWithTotal { get; set;}
    }
}