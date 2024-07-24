namespace ExternalLibrary
{
    public class Specifications
    {
        public ClassicalAnalysisSpecifications ClassicalAnalysis { get; set; } = new ClassicalAnalysisSpecifications();

    }
    public class ClassicalAnalysisSpecifications
    {
        public CriterionScoreType CriterionScoreTypeSpecification { get; set; } = new CriterionScoreType();
        public ExclusionCriteria ExclusionCriteria { get; set; } = new ExclusionCriteria();
        public List<PartStatus> PartStatuses { get; set; } = new List<PartStatus>();    
        public List<FormExclusion> FormExclusions { get; set; } = new List<FormExclusion>();
        
        public enum CriterionScoreType //crude placeholder
        {
            Raw,
            Theta
        }
    }
    public class CalibrationSpecifications
    {
        public string Software { get; set; } = "";
        public string MultipleChoiceModel { get; set; } = "";
        public string DichotomousResponseModel { get; set; } = "";
        public string PolytomousModel { get; set; } = "";
        public double ScalingConstantD { get; set; }
        public double StartingValueParameterC { get; set; }
        public double ConvergenceCriterion { get; set; }
        public int MaximumIterations { get; set; }
    }
    public class DecisionConsistencyAndAccuracySpecifications
    {
        
    }
    public class DifferentialItemFunctioningSpecifications
    {
        
    }
    public class DimensionalitySpecifications
    {
        
    }
    public class DriftSpecifications
    {
        public string DriftSpecification { get; set; } = "";
    }
    public class EquatingSpecifications
    {
        public string Software = "";
        public string MultipleChoiceModel = "";
        public string DichotomousResponseModel = "";
        public string PolytomousModel = "";
        public double ScalingConstantD;
        public double StartingValueParameterC;
        public double ConvergenceCriterion;
        public int MaximumIterations;
    }
    public class ScoringSpecifications
    {
        public string ThetaCalculationMethod { get; set; } = "";
        public List<double> ListQuadratures { get; set; } = new List<double>();
        public List<double> ScorePriors { get; set; } = new List<double>(); //variable type is a placeholder
        public int ThetaNumberOfDecimalPlaces { get; set; }
        public int ScaleScoreIncrement { get; set; }
        public bool IsClassifiedOnTheta { get; set; }
        public double MaximumScaleScoreStandardError { get; set; }
        public bool IsUsingScaleForms { get; set; } = true;
        public double MinimumScalingTheta { get; set; }
        public double MaximumScalingTheta { get; set; }
        public double ScalingThetaBelowChance { get; set; }
        public double ScalingThetaIncrement { get; set; }
        public bool IsDisaggregatingScaling { get; set; }
        public SubscoreCategorizationMethodType SubscoreCategorizationMethod { get; set; } 
        public ReportingCategorySpecifications ReportingCategorySpecifications { get; set; } = new ReportingCategorySpecifications();
        public enum SubscoreCategorizationMethodType
        {
            None,
            StandardError
        }
    }
    public class ReportingCategorySpecifications
    {

    }
    //specification objects
    public class ExclusionCriteria
    {
        public int MinimumPValue { get; set; }
        public int MinimumCorrelationWithTotal { get; set; }
        public int MinimumScoreCategoryCount { get; set; }
        public bool IsExcludingBreach { get; set; }
        public bool IsExcludingSpanish { get; set; }
        public bool IsExcludingWritingPrompts { get; set; }
        public bool IsExcludingStringerResponseVectors { get; set; }
        public bool IsExcludingAllIncorrectResponseVectors { get; set; }
    }
    public class PartStatus
    {
        public char Identifier { get; set; }
        public bool IsExcluded { get; set; }
    }
    public class FormExclusion
    {
        public int FormId { get; set; }
        public bool IsExcluded { get; set; }
    }
}